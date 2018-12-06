Imports System.Text.RegularExpressions
Imports VB_ndef.uFCoder

Public Class Form1

    Public Sub read_info()

        Dim dll_ver As Int32
        Dim dll_major_ver As Byte
        Dim dll_minor_ver As Byte
        Dim dll_build As UShort
        Dim reader_type As UInt32
        dll_ver = GetDllVersion()

        dll_major_ver = dll_ver Mod 256 ' instead of casting, same result
        dll_minor_ver = dll_ver >> 8
        dll_build = dll_ver >> 16

        DevInfoDLL.Text = " DLL: " + dll_major_ver.ToString() + "." + dll_minor_ver.ToString() + "." + dll_build.ToString()

        Dim reader_sn(7) As Byte
        Dim str_reader_sn As String
        GetReaderSerialDescription(reader_sn)
        Dim fw_minor As Byte
        Dim fw_major As Byte
        Dim fw_build As Byte
        Dim hw_minor As Byte
        Dim hw_major As Byte

        GetReaderType(reader_type)
        GetReaderFirmwareVersion(fw_major, fw_minor)
        GetReaderHardwareVersion(hw_major, hw_minor)
        GetBuildNumber(fw_build)

        str_reader_sn = System.Text.Encoding.ASCII.GetString(reader_sn)

        DevInfoSN.Text = " SN : " + str_reader_sn

        DevInfoHW.Text = " HW : " + Convert.ToInt32(hw_major).ToString() + "." + hw_minor.ToString()

        DevInfoFW.Text = " FW : " + fw_major.ToString() + "." +
                                    fw_minor.ToString() + "." +
                                    fw_build.ToString()




    End Sub

    Function getcardlen(ByVal cardtype As DLCARDTYPE) As Int32

        Dim data_len As Int32

        Select Case cardtype
            Case DLCARDTYPE.DL_MIFARE_MINI
                data_len = 320
                Exit Select
            Case DLCARDTYPE.DL_MIFARE_CLASSIC_1K
                data_len = 752
                Exit Select
            Case DLCARDTYPE.DL_MIFARE_CLASSIC_4K
                data_len = 3440
                Exit Select
            Case DLCARDTYPE.DL_NTAG_203
                data_len = 144
                Exit Select
            Case DLCARDTYPE.DL_NTAG_213
                data_len = 144
                Exit Select
            Case DLCARDTYPE.DL_NTAG_215
                data_len = 504
                Exit Select
            Case DLCARDTYPE.DL_NTAG_216
                data_len = 888
                Exit Select
            Case DLCARDTYPE.DL_MIFARE_ULTRALIGHT
                data_len = 48
                Exit Select
            Case DLCARDTYPE.DL_MIFARE_ULTRALIGHT_C
                data_len = 144
                Exit Select
            Case DLCARDTYPE.DL_MIFARE_ULTRALIGHT_EV1_11
                data_len = 48
                Exit Select
            Case DLCARDTYPE.DL_MIFARE_ULTRALIGHT_EV1_21
                data_len = 144
                Exit Select
            Case DLCARDTYPE.DL_UNKNOWN_ISO_14443_4
                data_len = 8192
                Exit Select
            Case Else
                data_len = 0
                Exit Select

        End Select


        Return data_len

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUriIdentifierCode.SelectedIndex = 1
        tPayload.ReadOnly = True
        read_info()
    End Sub

    Private Sub bReaderOpen_Click(sender As Object, e As EventArgs) Handles bReaderOpen.Click
        Dim status As UInt32

        status = ReaderOpen()
        If status = 0 Then
            statusResult.Text = "Reader opened"
            statusReader.Text = "CONNECTED"
            readerPanel.BackColor = Color.LimeGreen
            statusResult.BackColor = Color.Lime

        Else
            statusResult.Text = "Reader opening error, status: 0x" + status.ToString("X2")
            readerPanel.BackColor = Color.Red

        End If

        read_info()


    End Sub

    Private Sub bReaderClose_Click(sender As Object, e As EventArgs) Handles bReaderClose.Click
        Dim status As UInt32

        status = ReaderClose()
        If status = 0 Then
            statusResult.Text = "Reader closed"
            statusReader.Text = "Not connected"
            readerPanel.BackColor = Color.Red
            statusResult.BackColor = Color.Red

            DevInfoFW.Text = ""
            DevInfoHW.Text = ""
            DevInfoSN.Text = ""
        Else
            statusResult.Text = "Reader opening error, tatus: 0x" + status.ToString("X2")
            readerPanel.BackColor = Color.Red
        End If
    End Sub

    Private Sub bReadCard_Click(sender As Object, e As EventArgs) Handles bReadCard.Click

        Dim status As Int32

        Dim type(255) As Byte
        Dim id As Byte
        Dim payload(999) As Byte
        Dim payload_length As Int32
        Dim type_length As Byte
        Dim id_length As Byte
        Dim tnf As Byte
        Dim record_nr As Byte
        Dim message_cnt As Byte
        Dim record_cnt As Byte
        Dim empty_record_cnt As Byte

        Dim record_cnt_array As Byte
        Dim cardtype As DLCARDTYPE

        Dim ct As String
        Dim card_len As Int32

        tPayload.Clear()
        dataGrid.Rows.Clear()
        tPayload.Text = "Payload:"
        'payload.Initialize()

        status = GetDlogicCardType(cardtype)

        ct = String.Format("[{0:X}]", Convert.ToInt32(cardtype))
        ct += " " + cardtype.ToString()
        card_len = getcardlen(cardtype)

        If (cardtype = DLCARDTYPE.DL_NO_CARD) Then
            statusResult.Text = "NO_CARD"
        End If

        NdefInfoCardType.Text = ct

        status = get_ndef_record_count(message_cnt, record_cnt, record_cnt_array, empty_record_cnt)

        If (status > 0) Then
            statusResult.Text = "Card is not initialized"
            Return
        End If

        NdefInfoMsgs.Text = "Msgs : " + message_cnt.ToString()
        NdefInfoRecs.Text = "Recs : " + record_cnt.ToString()
        NdefInfoEmpty.Text = "Empty: " + empty_record_cnt.ToString()


        For record_nr = 1 To record_cnt

            status = read_ndef_record(1, record_nr, tnf, type, type_length, id, id_length, payload, payload_length)

            'avoiding junk in free array indexes this way
            Dim write_payload(payload_length) As Byte
            Dim write_type(type_length) As Byte
            Array.Copy(payload, write_payload, payload_length)
            Array.Copy(type, write_type, type_length)


            If (status > 0) Then
                If (status = ERRORCODES.UFR_WRONG_NDEF_CARD_FORMAT) Then
                    statusResult.Text = " NDEF format error"
                End If
            ElseIf (status = ERRORCODES.UFR_NDEF_MESSAGE_NOT_FOUND) Then
                statusResult.Text = " NDEF message not found"

            Else statusResult.Text = " Error: " + status.ToString()

            End If

            Dim str_payload As String = System.Text.Encoding.ASCII.GetString(write_payload)

            Dim str_type As String = System.Text.Encoding.ASCII.GetString(type)

            Dim str_tnf As String = "TNF: " + System.Convert.ToString(tnf)


            dataGrid.Rows.Add(record_nr.ToString(), str_type.ToString(), payload_length.ToString(), str_payload)

            NdefInfoTNF.Text = str_tnf

            statusResult.Text = " Reading " + record_nr.ToString() + "/" + record_cnt.ToString()

            NdefInfoMsgs.Text = "Msgs : " + message_cnt.ToString()

            str_payload = ""
            str_tnf = ""
            str_type = ""
            Array.Clear(write_type, 0, type_length)
            Array.Clear(write_payload, 0, payload_length)
            Array.Clear(payload, 0, payload.Length)
            Array.Clear(type, 0, type.Length)

        Next record_nr

        dataGrid.Update()

        statusResult.Text = "Reading DONE!"

        If (message_cnt = 0 & empty_record_cnt = 0) Then
            statusResult.Text = "Card must be formatted first!"
        End If

        If (message_cnt = 1 & empty_record_cnt = 1) Then
            statusResult.Text = "NFC formatted! Ready for use..."
        End If

    End Sub

    Private Sub bWritePhone_Click(sender As Object, e As EventArgs) Handles bWritePhone.Click

        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String
        ' Dim payload() As Byte
        Dim tmp_str As String
        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        If (ePhone.Text.Length = 0) Then

            MessageBox.Show("Phone number is mandatory!")
            ePhone.Focus()
            Return
        End If

        ' Tel TNF=1, Type = URI = "U", Type Length =1 , payload[0]=5

        tmp_str = ePhone.Text
        tmp_payload = System.Text.Encoding.UTF8.GetBytes(tmp_str)

        Dim payload(tmp_payload.Length) As Byte

        Array.Copy(tmp_payload, 0, payload, 1, tmp_payload.Length)

        payload(0) = 5
        tnf = 1
        type = "U"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length

        status = write_ndef_record(1, tnf, type_byte, type_length, id_byte, id_length, payload, payload_length, card_formatted)

        If (status = 0) Then
            statusResult.Text = "Phone NDEF written"
            statusResult.BackColor = Color.Lime

        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red

        End If
    End Sub

    Private Sub dataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles dataGrid.SelectionChanged

        tPayload.Text = dataGrid.CurrentRow.Cells(3).Value.ToString()

    End Sub

    Private Sub bEraseAllRecords_Click(sender As Object, e As EventArgs) Handles bEraseAllRecords.Click
        Dim status As UInt32

        status = uFCoder.erase_all_ndef_records(1)
        If (status = 0) Then
            statusResult.Text = "All NDEF records erased"
            statusResult.BackColor = Color.Lime
        Else
            statusResult.Text = "Failed to erase, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If


    End Sub

    Private Sub bEraseLastRecord_Click(sender As Object, e As EventArgs) Handles bEraseLastRecord.Click
        Dim status As UInt32

        status = uFCoder.erase_last_ndef_record(1)
        If (status = 0) Then
            statusResult.Text = "Last NDEF record erased"
            statusResult.BackColor = Color.Lime
        Else
            statusResult.Text = "Failed to erase, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub bCardNDEFInit_Click(sender As Object, e As EventArgs) Handles bCardNDEFInit.Click
        Dim status As UInt32

        status = uFCoder.ndef_card_initialization()
        If (status = 0) Then
            statusResult.Text = "Initialized"
            statusResult.BackColor = Color.Lime
        Else
            statusResult.Text = "Failed to initialize, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub bWriteSMS_Click(sender As Object, e As EventArgs) Handles bWriteSMS.Click

        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String

        Dim tmp_str As String
        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        If (eSMS.Text.Length = 0) Then

            MessageBox.Show("SMS message is mandatory!")
            eSMS.Focus()
            Return
        End If

        tmp_str = "sms: " + eSMSPhone.Text + "?body=" + eSMS.Text
        tmp_payload = System.Text.Encoding.UTF8.GetBytes(tmp_str)

        Dim payload(tmp_payload.Length) As Byte

        Array.Copy(tmp_payload, 0, payload, 1, tmp_payload.Length)

        payload(0) = 0
        tnf = 1
        type = "U"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length


        status = write_ndef_record(1, tnf, type_byte, type_length, id_byte, id_length, payload, payload_length, card_formatted)

        If (status = 0) Then
            statusResult.Text = "SMS NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If


    End Sub

    Private Sub bWriteURI_Click(sender As Object, e As EventArgs) Handles bWriteURI.Click
        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String


        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        If (eURL.Text.Length = 0) Then

            MessageBox.Show("URL field is mandatory!")
            eURL.Focus()
            Return
        End If

        ' URL TNF=1, Type = URI = "U", Type Length =1 , payload[0]=1

        tmp_payload = System.Text.Encoding.UTF8.GetBytes(eURL.Text)

        Dim payload(tmp_payload.Length) As Byte

        Array.Copy(tmp_payload, 0, payload, 1, tmp_payload.Length)

        payload(0) = cbUriIdentifierCode.SelectedIndex

        tnf = 1
        type = "U"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length

        status = write_ndef_record(1, tnf, type_byte, type_length, id_byte, id_length, payload, payload_length, card_formatted)

        If (status = 0) Then
            statusResult.Text = "URI NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub bWriteVCard_Click(sender As Object, e As EventArgs) Handles bWriteVCard.Click
        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String

        Dim tmp_str As String
        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        Dim dispName As String
        Dim lastName As String
        Dim firstName As String
        Dim title As String
        Dim company As String
        Dim bPhone As String
        Dim cPhone As String
        Dim pPhone As String
        Dim bEmail As String
        Dim pEmail As String
        Dim webURL As String
        Dim skypeName As String

        dispName = eDisplay.Text.Trim()
        lastName = eLast.Text.Trim()
        firstName = eFirst.Text.Trim()
        bPhone = eBPhone.Text.Trim()
        cPhone = eCPhone.Text.Trim()
        pPhone = ePPhone.Text.Trim()
        bEmail = eBEmail.Text.Trim()
        pEmail = ePEmail.Text.Trim()
        title = eTitle.Text.Trim()
        company = eCompany.Text.Trim()
        webURL = eWeb.Text.Trim()
        skypeName = eSkype.Text.Trim()

        If (lastName.Length = 0 Or dispName.Length = 0) Then
            MessageBox.Show("Display Name and Last Name fields are mandatory!")
            eLast.Focus()
        End If

        tmp_str = ""

        tmp_str = Regex.Unescape("BEGIN:VCARD\r\n")
        tmp_str += Regex.Unescape("VERSION:3.0\r\n")
        tmp_str += Regex.Unescape("N:" + lastName + ";") ' replace N With N;CHARSET=UTF-8;ENCODING=8BIT
        tmp_str += Regex.Unescape(firstName + ";;;\r\n")
        tmp_str += Regex.Unescape("FN:" + dispName + "\r\n")

        If cPhone.Length > 0 Then
            tmp_str += Regex.Unescape("TEL;CELL:" + cPhone + "\r\n")
        End If
        If bPhone.Length > 0 Then
            tmp_str += Regex.Unescape("TEL;WORK:" + bPhone + "\r\n")
        End If
        If pPhone.Length > 0 Then
            tmp_str += Regex.Unescape("TEL;HOME:" + pPhone + "\r\n")
        End If
        If bEmail.Length > 0 Then
            tmp_str += Regex.Unescape("EMAIL;WORK:" + bEmail + "\r\n")
        End If
        If pEmail.Length > 0 Then
            tmp_str += Regex.Unescape("EMAIL;HOME:" + pEmail + "\r\n")
        End If
        If title.Length > 0 Then
            tmp_str += Regex.Unescape("TITLE:" + title + "\r\n")
        End If
        If company.Length > 0 Then
            tmp_str += Regex.Unescape("ORG:" + company + "\r\n")
        End If
        If webURL.Length > 0 Then
            tmp_str += Regex.Unescape("URL:" + webURL + "\r\n")
        End If
        If skypeName.Length > 0 Then
            tmp_str += Regex.Unescape("X-SKYPE:" + skypeName + "\r\n")
        End If
        tmp_str += "END:VCARD"

        MessageBox.Show(tmp_str, "vCard len= " + tmp_str.Length.ToString())

        tmp_payload = System.Text.Encoding.UTF8.GetBytes(tmp_str)

        Dim payload = tmp_payload

        tnf = 2
        type = "text/x-vCard"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length


        status = write_ndef_record(1, tnf, type_byte, type_length, id_byte, id_length, payload, payload_length, card_formatted)

        If (status = 0) Then
            statusResult.Text = "vCard NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub btnWriteBluetooth_Click(sender As Object, e As EventArgs) Handles btnWriteBluetooth.Click

        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String

        Dim card_formatted As Byte

        Dim hex_str As String

        hex_str = MaskedTextBox1.Text.Replace(" ", "").Replace("::", "").Replace(":", "")

        If hex_str.Length <> 12 Then
            MessageBox.Show("You must enter 6 hexadecimal numbers!") ' +"\nDebug: >" + hexStr + "< " + hexStr.Length */);
            MaskedTextBox1.Focus()
            Return

        End If

        Dim nBytes = hex_str.Length \ 2
        Dim a(nBytes - 1) As Byte
        For i = 0 To nBytes - 1
            a(i) = Convert.ToByte(hex_str.Substring(i * 2, 2), 16)
        Next
        Dim payload_addr_fragment = System.Text.Encoding.UTF8.GetBytes(hex_str)

        Dim payload(7) As Byte

        payload(1) = 0
        payload(0) = 8
        Array.Copy(a, 0, payload, 2, 6)

        tnf = 2
        type = "application/vnd.bluetooth.ep.oob"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length

        status = write_ndef_record(1, tnf, type_byte, type_length, id_byte, id_length, payload, payload_length, card_formatted)
        If (status = 0) Then
            statusResult.Text = "Bluetooth NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub eSMS_TextChanged(sender As Object, e As EventArgs) Handles eSMS.TextChanged
        smsChars.Text = "Chars: " + eSMS.Text.Length.ToString()
    End Sub

    Private Sub btnStorePhoneToReader_Click(sender As Object, e As EventArgs) Handles btnStorePhoneToReader.Click

        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String
        ' Dim payload() As Byte
        Dim tmp_str As String
        Dim tmp_payload() As Byte


        If (ePhone.Text.Length = 0) Then

            MessageBox.Show("Phone number is mandatory!")
            ePhone.Focus()
            Return
        End If

        ' Tel TNF=1, Type = URI = "U", Type Length =1 , payload[0]=5

        tmp_str = ePhone.Text
        tmp_payload = System.Text.Encoding.UTF8.GetBytes(tmp_str)

        Dim payload(tmp_payload.Length) As Byte

        Array.Copy(tmp_payload, 0, payload, 1, tmp_payload.Length)

        payload(0) = 5
        tnf = 1
        type = "U"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length

        status = WriteEmulationNdef(tnf, type_byte, type_length, id_byte, id_length, payload, payload_length)

        If (status = 0) Then
            statusResult.Text = "Phone NDEF written"
            statusResult.BackColor = Color.Lime

        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red

        End If
    End Sub

    Private Sub bStartTagEmulation_Click(sender As Object, e As EventArgs) Handles bStartTagEmulation.Click

        Dim status As UInt32

        status = TagEmulationStart()

        If status = 0 Then
            statusResult.Text = "Tag emulation mode activated"

            statusResult.BackColor = Color.Lime

        Else
            statusResult.Text = "Tag emulation error, status: 0x" + status.ToString("X2")

            statusResult.BackColor = Color.Red

        End If
    End Sub

    Private Sub bStartCombinedEmulation_Click(sender As Object, e As EventArgs) Handles bStartCombinedEmulation.Click
        Dim status As UInt32

        status = CombinedModeEmulationStart()

        If status = 0 Then
            statusResult.Text = "Combined emulation mode activated"

            statusResult.BackColor = Color.Lime

        Else
            statusResult.Text = "Combined emulation error, status: 0x" + status.ToString("X2")

            statusResult.BackColor = Color.Red

        End If
    End Sub

    Private Sub bStopEmulation_Click(sender As Object, e As EventArgs) Handles bStopEmulation.Click
        Dim status As UInt32

        status = TagEmulationStop()

        If status = 0 Then
            statusResult.Text = "Tag emulation stopped"

            statusResult.BackColor = Color.Lime

        Else
            statusResult.Text = "Tag emulation stop error, status: 0x" + status.ToString("X2")
            readerPanel.BackColor = Color.Red

        End If
    End Sub

    Private Sub btnStoreUrlToReader_Click(sender As Object, e As EventArgs) Handles btnStoreUrlToReader.Click
        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String


        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        If (eURL.Text.Length = 0) Then

            MessageBox.Show("URL field is mandatory!")
            eURL.Focus()
            Return
        End If

        ' URL TNF=1, Type = URI = "U", Type Length =1 , payload[0]=1

        tmp_payload = System.Text.Encoding.UTF8.GetBytes(eURL.Text)

        Dim payload(tmp_payload.Length) As Byte

        Array.Copy(tmp_payload, 0, payload, 1, tmp_payload.Length)

        payload(0) = cbUriIdentifierCode.SelectedIndex

        tnf = 1
        type = "U"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length




        status = WriteEmulationNdef(tnf, type_byte, type_length, id_byte, id_length, payload, payload_length)


        If (status = 0) Then
            statusResult.Text = "URI NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub bStoreSMSToReader_Click(sender As Object, e As EventArgs) Handles bStoreSMSToReader.Click

        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String

        Dim tmp_str As String
        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        If (eSMS.Text.Length = 0) Then

            MessageBox.Show("SMS message is mandatory!")
            eSMS.Focus()
            Return
        End If

        tmp_str = "sms: " + eSMSPhone.Text + "?body=" + eSMS.Text
        tmp_payload = System.Text.Encoding.UTF8.GetBytes(tmp_str)

        Dim payload(tmp_payload.Length) As Byte

        Array.Copy(tmp_payload, 0, payload, 1, tmp_payload.Length)

        payload(0) = 0
        tnf = 1
        type = "U"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length

        status = WriteEmulationNdef(tnf, type_byte, type_length, id_byte, id_length, payload, payload_length)

        If (status = 0) Then
            statusResult.Text = "SMS NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF"
            statusResult.BackColor = Color.Red
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String

        Dim tmp_str As String
        Dim tmp_payload() As Byte
        Dim card_formatted As Byte

        Dim dispName As String
        Dim lastName As String
        Dim firstName As String
        Dim title As String
        Dim company As String
        Dim bPhone As String
        Dim cPhone As String
        Dim pPhone As String
        Dim bEmail As String
        Dim pEmail As String
        Dim webURL As String
        Dim skypeName As String

        dispName = eDisplay.Text.Trim()
        lastName = eLast.Text.Trim()
        firstName = eFirst.Text.Trim()
        bPhone = eBPhone.Text.Trim()
        cPhone = eCPhone.Text.Trim()
        pPhone = ePPhone.Text.Trim()
        bEmail = eBEmail.Text.Trim()
        pEmail = ePEmail.Text.Trim()
        title = eTitle.Text.Trim()
        company = eCompany.Text.Trim()
        webURL = eWeb.Text.Trim()
        skypeName = eSkype.Text.Trim()

        If (lastName.Length = 0 Or dispName.Length = 0) Then
            MessageBox.Show("Display Name and Last Name fields are mandatory!")
            eLast.Focus()
        End If

        tmp_str = ""

        tmp_str = Regex.Unescape("BEGIN:VCARD\r\n")
        tmp_str += Regex.Unescape("VERSION:3.0\r\n")
        tmp_str += Regex.Unescape("N:" + lastName + ";") ' replace N With N;CHARSET=UTF-8;ENCODING=8BIT
        tmp_str += Regex.Unescape(firstName + ";;;\r\n")
        tmp_str += Regex.Unescape("FN:" + dispName + "\r\n")

        If cPhone.Length > 0 Then
            tmp_str += Regex.Unescape("TEL;CELL:" + cPhone + "\r\n")
        End If
        If bPhone.Length > 0 Then
            tmp_str += Regex.Unescape("TEL;WORK:" + bPhone + "\r\n")
        End If
        If pPhone.Length > 0 Then
            tmp_str += Regex.Unescape("TEL;HOME:" + pPhone + "\r\n")
        End If
        If bEmail.Length > 0 Then
            tmp_str += Regex.Unescape("EMAIL;WORK:" + bEmail + "\r\n")
        End If
        If pEmail.Length > 0 Then
            tmp_str += Regex.Unescape("EMAIL;HOME:" + pEmail + "\r\n")
        End If
        If title.Length > 0 Then
            tmp_str += Regex.Unescape("TITLE:" + title + "\r\n")
        End If
        If company.Length > 0 Then
            tmp_str += Regex.Unescape("ORG:" + company + "\r\n")
        End If
        If webURL.Length > 0 Then
            tmp_str += Regex.Unescape("URL:" + webURL + "\r\n")
        End If
        If skypeName.Length > 0 Then
            tmp_str += Regex.Unescape("X-SKYPE:" + skypeName + "\r\n")
        End If
        tmp_str += "END:VCARD"

        MessageBox.Show(tmp_str, "vCard len= " + tmp_str.Length.ToString())

        tmp_payload = System.Text.Encoding.UTF8.GetBytes(tmp_str)

        Dim payload = tmp_payload

        tnf = 2
        type = "text/x-vCard"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length


        status = WriteEmulationNdef(tnf, type_byte, type_length, id_byte, id_length, payload, payload_length)

        If (status = 0) Then
            statusResult.Text = "vCard NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If



    End Sub

    Private Sub btnStoreBluetoothToReader_Click(sender As Object, e As EventArgs) Handles btnStoreBluetoothToReader.Click

        Dim status As UInt32
        Dim tnf As UInt32
        Dim type As String
        Dim id As String

        Dim card_formatted As Byte

        Dim hex_str As String

        hex_str = MaskedTextBox1.Text.Replace(" ", "").Replace("::", "").Replace(":", "")

        If hex_str.Length <> 12 Then
            MessageBox.Show("You must enter 6 hexadecimal numbers!") ' +"\nDebug: >" + hexStr + "< " + hexStr.Length */);
            MaskedTextBox1.Focus()
            Return

        End If

        Dim nBytes = hex_str.Length \ 2
        Dim a(nBytes - 1) As Byte
        For i = 0 To nBytes - 1
            a(i) = Convert.ToByte(hex_str.Substring(i * 2, 2), 16)
        Next
        Dim payload_addr_fragment = System.Text.Encoding.UTF8.GetBytes(hex_str)

        Dim payload(7) As Byte

        payload(1) = 0
        payload(0) = 8
        Array.Copy(a, 0, payload, 2, 6)

        tnf = 2
        type = "application/vnd.bluetooth.ep.oob"
        id = ""

        Dim type_byte() = System.Text.Encoding.UTF8.GetBytes(type)
        Dim id_byte() = System.Text.Encoding.UTF8.GetBytes(id)
        'Dim type_byte = Convert.ToByte(type)
        'Dim id_byte = Convert.ToByte(id)
        Dim type_length = type.Length
        Dim id_length = id.Length
        Dim payload_length = payload.Length

        status = WriteEmulationNdef(tnf, type_byte, type_length, id_byte, id_length, payload, payload_length)
        If (status = 0) Then
            statusResult.Text = "Bluetooth NDEF written"
            statusResult.BackColor = Color.Lime
        End If
        If (status > 0) Then
            statusResult.Text = "Error while writing NDEF, status: 0x" + status.ToString("X2")
            statusResult.BackColor = Color.Red
        End If
    End Sub
End Class
