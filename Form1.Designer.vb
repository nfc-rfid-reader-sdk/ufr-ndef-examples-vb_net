<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bReaderOpen = New System.Windows.Forms.Button()
        Me.bReaderClose = New System.Windows.Forms.Button()
        Me.readerPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tPayload = New System.Windows.Forms.RichTextBox()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.gridNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridPayload = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bReadCard = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ePhone = New System.Windows.Forms.TextBox()
        Me.bWritePhone = New System.Windows.Forms.Button()
        Me.btnStorePhoneToReader = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.bStoreSMSToReader = New System.Windows.Forms.Button()
        Me.eSMSPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bWriteSMS = New System.Windows.Forms.Button()
        Me.smsChars = New System.Windows.Forms.Label()
        Me.eSMS = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnStoreUrlToReader = New System.Windows.Forms.Button()
        Me.bWriteURI = New System.Windows.Forms.Button()
        Me.eURL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbUriIdentifierCode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bWriteVCard = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.eSkype = New System.Windows.Forms.TextBox()
        Me.eWeb = New System.Windows.Forms.TextBox()
        Me.eCompany = New System.Windows.Forms.TextBox()
        Me.eTitle = New System.Windows.Forms.TextBox()
        Me.ePEmail = New System.Windows.Forms.TextBox()
        Me.eBEmail = New System.Windows.Forms.TextBox()
        Me.ePPhone = New System.Windows.Forms.TextBox()
        Me.eCPhone = New System.Windows.Forms.TextBox()
        Me.eBPhone = New System.Windows.Forms.TextBox()
        Me.eFirst = New System.Windows.Forms.TextBox()
        Me.eLast = New System.Windows.Forms.TextBox()
        Me.eDisplay = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnStoreBluetoothToReader = New System.Windows.Forms.Button()
        Me.btnWriteBluetooth = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gReaderEmu = New System.Windows.Forms.GroupBox()
        Me.bStopEmulation = New System.Windows.Forms.Button()
        Me.bStartCombinedEmulation = New System.Windows.Forms.Button()
        Me.bStartTagEmulation = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bEraseAllRecords = New System.Windows.Forms.Button()
        Me.bCardNDEFInit = New System.Windows.Forms.Button()
        Me.bEraseLastRecord = New System.Windows.Forms.Button()
        Me.statInfo = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NdefInfoCardType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NdefInfoMsgs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NdefInfoRecs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NdefInfoEmpty = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NdefInfoTNF = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statDevice = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DevInfoSN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DevInfoHW = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DevInfoFW = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DevInfoDLL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statNDEF = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusReader = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusResult = New System.Windows.Forms.ToolStripStatusLabel()
        Me.readerPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gReaderEmu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.statInfo.SuspendLayout()
        Me.statDevice.SuspendLayout()
        Me.statNDEF.SuspendLayout()
        Me.SuspendLayout()
        '
        'bReaderOpen
        '
        Me.bReaderOpen.Location = New System.Drawing.Point(15, 5)
        Me.bReaderOpen.Name = "bReaderOpen"
        Me.bReaderOpen.Size = New System.Drawing.Size(190, 40)
        Me.bReaderOpen.TabIndex = 0
        Me.bReaderOpen.Text = "Open Reader"
        Me.bReaderOpen.UseVisualStyleBackColor = True
        '
        'bReaderClose
        '
        Me.bReaderClose.Location = New System.Drawing.Point(245, 5)
        Me.bReaderClose.Name = "bReaderClose"
        Me.bReaderClose.Size = New System.Drawing.Size(190, 40)
        Me.bReaderClose.TabIndex = 1
        Me.bReaderClose.Text = "Close Reader"
        Me.bReaderClose.UseVisualStyleBackColor = True
        '
        'readerPanel
        '
        Me.readerPanel.BackColor = System.Drawing.Color.Red
        Me.readerPanel.Controls.Add(Me.bReaderOpen)
        Me.readerPanel.Controls.Add(Me.bReaderClose)
        Me.readerPanel.Location = New System.Drawing.Point(-3, 12)
        Me.readerPanel.Name = "readerPanel"
        Me.readerPanel.Size = New System.Drawing.Size(449, 50)
        Me.readerPanel.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 424)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tPayload)
        Me.TabPage1.Controls.Add(Me.dataGrid)
        Me.TabPage1.Controls.Add(Me.bReadCard)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 395)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Read NFC data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tPayload
        '
        Me.tPayload.Location = New System.Drawing.Point(4, 295)
        Me.tPayload.Name = "tPayload"
        Me.tPayload.Size = New System.Drawing.Size(427, 94)
        Me.tPayload.TabIndex = 2
        Me.tPayload.Text = "Payload:"
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.AllowUserToResizeRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gridNo, Me.gridType, Me.gridLength, Me.gridPayload})
        Me.dataGrid.Location = New System.Drawing.Point(8, 52)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGrid.Size = New System.Drawing.Size(427, 237)
        Me.dataGrid.TabIndex = 0
        '
        'gridNo
        '
        Me.gridNo.HeaderText = "No"
        Me.gridNo.Name = "gridNo"
        '
        'gridType
        '
        Me.gridType.HeaderText = "Type"
        Me.gridType.Name = "gridType"
        '
        'gridLength
        '
        Me.gridLength.HeaderText = "Length"
        Me.gridLength.Name = "gridLength"
        '
        'gridPayload
        '
        Me.gridPayload.HeaderText = "Payload"
        Me.gridPayload.Name = "gridPayload"
        '
        'bReadCard
        '
        Me.bReadCard.Location = New System.Drawing.Point(6, 6)
        Me.bReadCard.Name = "bReadCard"
        Me.bReadCard.Size = New System.Drawing.Size(426, 40)
        Me.bReadCard.TabIndex = 0
        Me.bReadCard.Text = "Read Card"
        Me.bReadCard.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(439, 395)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Write NFC data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Location = New System.Drawing.Point(0, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(438, 480)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.ePhone)
        Me.TabPage4.Controls.Add(Me.bWritePhone)
        Me.TabPage4.Controls.Add(Me.btnStorePhoneToReader)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(430, 454)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Phone"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Phone number:"
        '
        'ePhone
        '
        Me.ePhone.Location = New System.Drawing.Point(12, 57)
        Me.ePhone.Name = "ePhone"
        Me.ePhone.Size = New System.Drawing.Size(396, 20)
        Me.ePhone.TabIndex = 0
        '
        'bWritePhone
        '
        Me.bWritePhone.Location = New System.Drawing.Point(12, 95)
        Me.bWritePhone.Name = "bWritePhone"
        Me.bWritePhone.Size = New System.Drawing.Size(402, 84)
        Me.bWritePhone.TabIndex = 1
        Me.bWritePhone.Text = "Write Phone"
        Me.bWritePhone.UseVisualStyleBackColor = True
        '
        'btnStorePhoneToReader
        '
        Me.btnStorePhoneToReader.Location = New System.Drawing.Point(6, 209)
        Me.btnStorePhoneToReader.Name = "btnStorePhoneToReader"
        Me.btnStorePhoneToReader.Size = New System.Drawing.Size(402, 84)
        Me.btnStorePhoneToReader.TabIndex = 2
        Me.btnStorePhoneToReader.Text = "Store phone number for tag emulation mode (min. v3.8.0 firmware and library neede" &
    "d)"
        Me.btnStorePhoneToReader.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.bStoreSMSToReader)
        Me.TabPage5.Controls.Add(Me.eSMSPhone)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.bWriteSMS)
        Me.TabPage5.Controls.Add(Me.smsChars)
        Me.TabPage5.Controls.Add(Me.eSMS)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(430, 454)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "SMS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'bStoreSMSToReader
        '
        Me.bStoreSMSToReader.Location = New System.Drawing.Point(11, 254)
        Me.bStoreSMSToReader.Name = "bStoreSMSToReader"
        Me.bStoreSMSToReader.Size = New System.Drawing.Size(294, 61)
        Me.bStoreSMSToReader.TabIndex = 6
        Me.bStoreSMSToReader.Text = "Store SMS for tag emulation mode (min. v3.8.0 firmware and library needed)"
        Me.bStoreSMSToReader.UseVisualStyleBackColor = True
        '
        'eSMSPhone
        '
        Me.eSMSPhone.Location = New System.Drawing.Point(11, 217)
        Me.eSMSPhone.Name = "eSMSPhone"
        Me.eSMSPhone.Size = New System.Drawing.Size(151, 20)
        Me.eSMSPhone.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone No."
        '
        'bWriteSMS
        '
        Me.bWriteSMS.Location = New System.Drawing.Point(179, 30)
        Me.bWriteSMS.Name = "bWriteSMS"
        Me.bWriteSMS.Size = New System.Drawing.Size(126, 207)
        Me.bWriteSMS.TabIndex = 3
        Me.bWriteSMS.Text = "Write SMS"
        Me.bWriteSMS.UseVisualStyleBackColor = True
        '
        'smsChars
        '
        Me.smsChars.AutoSize = True
        Me.smsChars.Location = New System.Drawing.Point(107, 179)
        Me.smsChars.Name = "smsChars"
        Me.smsChars.Size = New System.Drawing.Size(37, 13)
        Me.smsChars.TabIndex = 2
        Me.smsChars.Text = "Chars:"
        '
        'eSMS
        '
        Me.eSMS.Location = New System.Drawing.Point(11, 30)
        Me.eSMS.MaxLength = 160
        Me.eSMS.Name = "eSMS"
        Me.eSMS.Size = New System.Drawing.Size(151, 146)
        Me.eSMS.TabIndex = 1
        Me.eSMS.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Message text (max. 160 chars)."
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnStoreUrlToReader)
        Me.TabPage6.Controls.Add(Me.bWriteURI)
        Me.TabPage6.Controls.Add(Me.eURL)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.cbUriIdentifierCode)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(430, 454)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "URI"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnStoreUrlToReader
        '
        Me.btnStoreUrlToReader.Location = New System.Drawing.Point(38, 240)
        Me.btnStoreUrlToReader.Name = "btnStoreUrlToReader"
        Me.btnStoreUrlToReader.Size = New System.Drawing.Size(336, 60)
        Me.btnStoreUrlToReader.TabIndex = 11
        Me.btnStoreUrlToReader.Text = "Store URL for tag emulation mode (min. v3.8.0 firmware and library needed)"
        Me.btnStoreUrlToReader.UseVisualStyleBackColor = True
        '
        'bWriteURI
        '
        Me.bWriteURI.Location = New System.Drawing.Point(38, 165)
        Me.bWriteURI.Name = "bWriteURI"
        Me.bWriteURI.Size = New System.Drawing.Size(336, 40)
        Me.bWriteURI.TabIndex = 10
        Me.bWriteURI.Text = "Write URI"
        Me.bWriteURI.UseVisualStyleBackColor = True
        '
        'eURL
        '
        Me.eURL.Location = New System.Drawing.Point(38, 97)
        Me.eURL.Name = "eURL"
        Me.eURL.Size = New System.Drawing.Size(336, 20)
        Me.eURL.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "URI field:"
        '
        'cbUriIdentifierCode
        '
        Me.cbUriIdentifierCode.FormattingEnabled = True
        Me.cbUriIdentifierCode.Items.AddRange(New Object() {"N/A. No prepending is done.", "http://www.", "https://www.", "http://", "https://", "tel:", "mailto:", "ftp://anonymous:anonymous@", "ftp://ftp.", "ftps://", "sftp://", "smb://", "nfs://", "ftp://", "dav://", "news:", "telnet://", "imap:", "rtsp://", "urn:", "pop:", "sip:", "sips:", "tftp:", "btspp://", "btl2cap://", "btgoep://", "tcpobex://", "irdaobex://", "file://", "urn:epc:id:", " urn:epc:tag:", "urn:epc:pat:", "urn:epc:raw:", "urn:epc:", "urn:nfc:"})
        Me.cbUriIdentifierCode.Location = New System.Drawing.Point(144, 39)
        Me.cbUriIdentifierCode.Name = "cbUriIdentifierCode"
        Me.cbUriIdentifierCode.Size = New System.Drawing.Size(230, 21)
        Me.cbUriIdentifierCode.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "URI Identifier Code:"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Button2)
        Me.TabPage7.Controls.Add(Me.bWriteVCard)
        Me.TabPage7.Controls.Add(Me.Label21)
        Me.TabPage7.Controls.Add(Me.Label20)
        Me.TabPage7.Controls.Add(Me.Label19)
        Me.TabPage7.Controls.Add(Me.Label18)
        Me.TabPage7.Controls.Add(Me.Label17)
        Me.TabPage7.Controls.Add(Me.Label16)
        Me.TabPage7.Controls.Add(Me.Label15)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Controls.Add(Me.Label13)
        Me.TabPage7.Controls.Add(Me.Label12)
        Me.TabPage7.Controls.Add(Me.Label11)
        Me.TabPage7.Controls.Add(Me.Label10)
        Me.TabPage7.Controls.Add(Me.eSkype)
        Me.TabPage7.Controls.Add(Me.eWeb)
        Me.TabPage7.Controls.Add(Me.eCompany)
        Me.TabPage7.Controls.Add(Me.eTitle)
        Me.TabPage7.Controls.Add(Me.ePEmail)
        Me.TabPage7.Controls.Add(Me.eBEmail)
        Me.TabPage7.Controls.Add(Me.ePPhone)
        Me.TabPage7.Controls.Add(Me.eCPhone)
        Me.TabPage7.Controls.Add(Me.eBPhone)
        Me.TabPage7.Controls.Add(Me.eFirst)
        Me.TabPage7.Controls.Add(Me.eLast)
        Me.TabPage7.Controls.Add(Me.eDisplay)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(430, 454)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "vCard"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 109)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Store vCard for tag emulation mode (min. v3.8.0 firmware and library needed)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bWriteVCard
        '
        Me.bWriteVCard.Location = New System.Drawing.Point(22, 329)
        Me.bWriteVCard.Name = "bWriteVCard"
        Me.bWriteVCard.Size = New System.Drawing.Size(300, 23)
        Me.bWriteVCard.TabIndex = 24
        Me.bWriteVCard.Text = "Write vCard"
        Me.bWriteVCard.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(72, 301)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Skype name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(67, 275)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Website URL"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(87, 249)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Company"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(111, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Title"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(64, 197)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Private E-mail"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(53, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Bussiness E-mail"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(64, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Private Phone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(80, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Cell Phone"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(50, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Bussiness Phone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(81, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "First Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "* Last Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "* Display Name"
        '
        'eSkype
        '
        Me.eSkype.Location = New System.Drawing.Point(144, 298)
        Me.eSkype.Name = "eSkype"
        Me.eSkype.Size = New System.Drawing.Size(178, 20)
        Me.eSkype.TabIndex = 11
        '
        'eWeb
        '
        Me.eWeb.Location = New System.Drawing.Point(144, 272)
        Me.eWeb.Name = "eWeb"
        Me.eWeb.Size = New System.Drawing.Size(178, 20)
        Me.eWeb.TabIndex = 10
        '
        'eCompany
        '
        Me.eCompany.Location = New System.Drawing.Point(144, 246)
        Me.eCompany.Name = "eCompany"
        Me.eCompany.Size = New System.Drawing.Size(178, 20)
        Me.eCompany.TabIndex = 9
        '
        'eTitle
        '
        Me.eTitle.Location = New System.Drawing.Point(144, 220)
        Me.eTitle.Name = "eTitle"
        Me.eTitle.Size = New System.Drawing.Size(178, 20)
        Me.eTitle.TabIndex = 8
        '
        'ePEmail
        '
        Me.ePEmail.Location = New System.Drawing.Point(144, 194)
        Me.ePEmail.Name = "ePEmail"
        Me.ePEmail.Size = New System.Drawing.Size(178, 20)
        Me.ePEmail.TabIndex = 7
        '
        'eBEmail
        '
        Me.eBEmail.Location = New System.Drawing.Point(144, 168)
        Me.eBEmail.Name = "eBEmail"
        Me.eBEmail.Size = New System.Drawing.Size(178, 20)
        Me.eBEmail.TabIndex = 6
        '
        'ePPhone
        '
        Me.ePPhone.Location = New System.Drawing.Point(144, 142)
        Me.ePPhone.Name = "ePPhone"
        Me.ePPhone.Size = New System.Drawing.Size(178, 20)
        Me.ePPhone.TabIndex = 5
        '
        'eCPhone
        '
        Me.eCPhone.Location = New System.Drawing.Point(144, 116)
        Me.eCPhone.Name = "eCPhone"
        Me.eCPhone.Size = New System.Drawing.Size(178, 20)
        Me.eCPhone.TabIndex = 4
        '
        'eBPhone
        '
        Me.eBPhone.Location = New System.Drawing.Point(144, 90)
        Me.eBPhone.Name = "eBPhone"
        Me.eBPhone.Size = New System.Drawing.Size(178, 20)
        Me.eBPhone.TabIndex = 3
        '
        'eFirst
        '
        Me.eFirst.Location = New System.Drawing.Point(144, 64)
        Me.eFirst.Name = "eFirst"
        Me.eFirst.Size = New System.Drawing.Size(178, 20)
        Me.eFirst.TabIndex = 2
        '
        'eLast
        '
        Me.eLast.Location = New System.Drawing.Point(144, 38)
        Me.eLast.Name = "eLast"
        Me.eLast.Size = New System.Drawing.Size(178, 20)
        Me.eLast.TabIndex = 1
        '
        'eDisplay
        '
        Me.eDisplay.Location = New System.Drawing.Point(144, 12)
        Me.eDisplay.Name = "eDisplay"
        Me.eDisplay.Size = New System.Drawing.Size(178, 20)
        Me.eDisplay.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.GroupBox5)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(430, 454)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "Bluetooth"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnStoreBluetoothToReader)
        Me.GroupBox5.Controls.Add(Me.btnWriteBluetooth)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(29, 31)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(365, 299)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Bluetooth secure simple pairing"
        '
        'btnStoreBluetoothToReader
        '
        Me.btnStoreBluetoothToReader.Location = New System.Drawing.Point(38, 178)
        Me.btnStoreBluetoothToReader.Name = "btnStoreBluetoothToReader"
        Me.btnStoreBluetoothToReader.Size = New System.Drawing.Size(274, 62)
        Me.btnStoreBluetoothToReader.TabIndex = 3
        Me.btnStoreBluetoothToReader.Text = "Store Bluetooth Address for tag emulation mode (min. v3.8.0 firmware and library " &
    "needed)"
        Me.btnStoreBluetoothToReader.UseVisualStyleBackColor = True
        '
        'btnWriteBluetooth
        '
        Me.btnWriteBluetooth.Location = New System.Drawing.Point(80, 115)
        Me.btnWriteBluetooth.Name = "btnWriteBluetooth"
        Me.btnWriteBluetooth.Size = New System.Drawing.Size(182, 40)
        Me.btnWriteBluetooth.TabIndex = 2
        Me.btnWriteBluetooth.Text = "Write Bluetooth address"
        Me.btnWriteBluetooth.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Bluetooth address:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Linux Libertine G", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(80, 62)
        Me.MaskedTextBox1.Mask = ">AA:AA:AA:AA:AA:AA"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(182, 29)
        Me.MaskedTextBox1.TabIndex = 0
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gReaderEmu)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(439, 395)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tools"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gReaderEmu
        '
        Me.gReaderEmu.Controls.Add(Me.bStopEmulation)
        Me.gReaderEmu.Controls.Add(Me.bStartCombinedEmulation)
        Me.gReaderEmu.Controls.Add(Me.bStartTagEmulation)
        Me.gReaderEmu.Location = New System.Drawing.Point(8, 193)
        Me.gReaderEmu.Name = "gReaderEmu"
        Me.gReaderEmu.Size = New System.Drawing.Size(420, 170)
        Me.gReaderEmu.TabIndex = 4
        Me.gReaderEmu.TabStop = False
        Me.gReaderEmu.Text = "Reader emulation commands"
        '
        'bStopEmulation
        '
        Me.bStopEmulation.Location = New System.Drawing.Point(74, 124)
        Me.bStopEmulation.Name = "bStopEmulation"
        Me.bStopEmulation.Size = New System.Drawing.Size(250, 40)
        Me.bStopEmulation.TabIndex = 2
        Me.bStopEmulation.Text = "Stop tag emulation mode"
        Me.bStopEmulation.UseVisualStyleBackColor = True
        '
        'bStartCombinedEmulation
        '
        Me.bStartCombinedEmulation.Location = New System.Drawing.Point(74, 78)
        Me.bStartCombinedEmulation.Name = "bStartCombinedEmulation"
        Me.bStartCombinedEmulation.Size = New System.Drawing.Size(250, 40)
        Me.bStartCombinedEmulation.TabIndex = 1
        Me.bStartCombinedEmulation.Text = "Start combined tag emulation mode"
        Me.bStartCombinedEmulation.UseVisualStyleBackColor = True
        '
        'bStartTagEmulation
        '
        Me.bStartTagEmulation.Location = New System.Drawing.Point(74, 32)
        Me.bStartTagEmulation.Name = "bStartTagEmulation"
        Me.bStartTagEmulation.Size = New System.Drawing.Size(250, 40)
        Me.bStartTagEmulation.TabIndex = 0
        Me.bStartTagEmulation.Text = "Start dedicated tag emulation mode"
        Me.bStartTagEmulation.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bEraseAllRecords)
        Me.GroupBox1.Controls.Add(Me.bCardNDEFInit)
        Me.GroupBox1.Controls.Add(Me.bEraseLastRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card actions"
        '
        'bEraseAllRecords
        '
        Me.bEraseAllRecords.Location = New System.Drawing.Point(74, 123)
        Me.bEraseAllRecords.Name = "bEraseAllRecords"
        Me.bEraseAllRecords.Size = New System.Drawing.Size(250, 40)
        Me.bEraseAllRecords.TabIndex = 2
        Me.bEraseAllRecords.Text = "Erase All Records"
        Me.bEraseAllRecords.UseVisualStyleBackColor = True
        '
        'bCardNDEFInit
        '
        Me.bCardNDEFInit.Location = New System.Drawing.Point(0, 19)
        Me.bCardNDEFInit.Name = "bCardNDEFInit"
        Me.bCardNDEFInit.Size = New System.Drawing.Size(420, 40)
        Me.bCardNDEFInit.TabIndex = 0
        Me.bCardNDEFInit.Text = "Card Initialize for NDEF messages"
        Me.bCardNDEFInit.UseVisualStyleBackColor = True
        '
        'bEraseLastRecord
        '
        Me.bEraseLastRecord.Location = New System.Drawing.Point(74, 77)
        Me.bEraseLastRecord.Name = "bEraseLastRecord"
        Me.bEraseLastRecord.Size = New System.Drawing.Size(250, 40)
        Me.bEraseLastRecord.TabIndex = 1
        Me.bEraseLastRecord.Text = "Erase Last Record"
        Me.bEraseLastRecord.UseVisualStyleBackColor = True
        '
        'statInfo
        '
        Me.statInfo.Dock = System.Windows.Forms.DockStyle.None
        Me.statInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.NdefInfoCardType, Me.NdefInfoMsgs, Me.NdefInfoRecs, Me.NdefInfoEmpty, Me.NdefInfoTNF})
        Me.statInfo.Location = New System.Drawing.Point(4, 495)
        Me.statInfo.Name = "statInfo"
        Me.statInfo.Size = New System.Drawing.Size(443, 22)
        Me.statInfo.TabIndex = 4
        Me.statInfo.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel1.Text = "NDEF"
        '
        'NdefInfoCardType
        '
        Me.NdefInfoCardType.AutoSize = False
        Me.NdefInfoCardType.Name = "NdefInfoCardType"
        Me.NdefInfoCardType.Size = New System.Drawing.Size(160, 17)
        Me.NdefInfoCardType.Text = "NdefInfocardType"
        '
        'NdefInfoMsgs
        '
        Me.NdefInfoMsgs.AutoSize = False
        Me.NdefInfoMsgs.Name = "NdefInfoMsgs"
        Me.NdefInfoMsgs.Size = New System.Drawing.Size(60, 17)
        Me.NdefInfoMsgs.Text = "Msgs"
        '
        'NdefInfoRecs
        '
        Me.NdefInfoRecs.AutoSize = False
        Me.NdefInfoRecs.Name = "NdefInfoRecs"
        Me.NdefInfoRecs.Size = New System.Drawing.Size(56, 17)
        Me.NdefInfoRecs.Text = "Recs"
        '
        'NdefInfoEmpty
        '
        Me.NdefInfoEmpty.AutoSize = False
        Me.NdefInfoEmpty.Name = "NdefInfoEmpty"
        Me.NdefInfoEmpty.Size = New System.Drawing.Size(50, 17)
        Me.NdefInfoEmpty.Text = "Empty"
        '
        'NdefInfoTNF
        '
        Me.NdefInfoTNF.AutoSize = False
        Me.NdefInfoTNF.Name = "NdefInfoTNF"
        Me.NdefInfoTNF.Size = New System.Drawing.Size(50, 17)
        Me.NdefInfoTNF.Text = "TNF"
        '
        'statDevice
        '
        Me.statDevice.Dock = System.Windows.Forms.DockStyle.None
        Me.statDevice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7, Me.DevInfoSN, Me.DevInfoHW, Me.DevInfoFW, Me.DevInfoDLL})
        Me.statDevice.Location = New System.Drawing.Point(8, 517)
        Me.statDevice.Name = "statDevice"
        Me.statDevice.Size = New System.Drawing.Size(443, 22)
        Me.statDevice.TabIndex = 3
        Me.statDevice.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.AutoSize = False
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel7.Text = "DEVICE"
        '
        'DevInfoSN
        '
        Me.DevInfoSN.AutoSize = False
        Me.DevInfoSN.Name = "DevInfoSN"
        Me.DevInfoSN.Size = New System.Drawing.Size(94, 17)
        Me.DevInfoSN.Text = "DevInfoSN"
        '
        'DevInfoHW
        '
        Me.DevInfoHW.AutoSize = False
        Me.DevInfoHW.Name = "DevInfoHW"
        Me.DevInfoHW.Size = New System.Drawing.Size(94, 17)
        Me.DevInfoHW.Text = "DevInfoHW"
        '
        'DevInfoFW
        '
        Me.DevInfoFW.AutoSize = False
        Me.DevInfoFW.Name = "DevInfoFW"
        Me.DevInfoFW.Size = New System.Drawing.Size(94, 17)
        Me.DevInfoFW.Text = "DevInfoFW"
        '
        'DevInfoDLL
        '
        Me.DevInfoDLL.AutoSize = False
        Me.DevInfoDLL.Name = "DevInfoDLL"
        Me.DevInfoDLL.Size = New System.Drawing.Size(94, 17)
        Me.DevInfoDLL.Text = "DevInfoDLL"
        '
        'statNDEF
        '
        Me.statNDEF.Dock = System.Windows.Forms.DockStyle.None
        Me.statNDEF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel12, Me.statusReader, Me.statusResult})
        Me.statNDEF.Location = New System.Drawing.Point(9, 539)
        Me.statNDEF.Name = "statNDEF"
        Me.statNDEF.Size = New System.Drawing.Size(443, 22)
        Me.statNDEF.TabIndex = 5
        Me.statNDEF.Text = "StatusStrip3"
        '
        'ToolStripStatusLabel12
        '
        Me.ToolStripStatusLabel12.AutoSize = False
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        Me.ToolStripStatusLabel12.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel12.Text = "STATUS"
        '
        'statusReader
        '
        Me.statusReader.AutoSize = False
        Me.statusReader.Name = "statusReader"
        Me.statusReader.Size = New System.Drawing.Size(150, 17)
        Me.statusReader.Text = "statusReader"
        '
        'statusResult
        '
        Me.statusResult.AutoSize = False
        Me.statusResult.Name = "statusResult"
        Me.statusResult.Size = New System.Drawing.Size(222, 17)
        Me.statusResult.Text = "statusResult"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 568)
        Me.Controls.Add(Me.statNDEF)
        Me.Controls.Add(Me.statDevice)
        Me.Controls.Add(Me.statInfo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.readerPanel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "vb.net read-write ndef example"
        Me.readerPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.gReaderEmu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.statInfo.ResumeLayout(False)
        Me.statInfo.PerformLayout()
        Me.statDevice.ResumeLayout(False)
        Me.statDevice.PerformLayout()
        Me.statNDEF.ResumeLayout(False)
        Me.statNDEF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bReaderOpen As Button
    Friend WithEvents bReaderClose As Button
    Friend WithEvents readerPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents bReadCard As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents tPayload As RichTextBox
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents statInfo As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents NdefInfoCardType As ToolStripStatusLabel
    Friend WithEvents NdefInfoMsgs As ToolStripStatusLabel
    Friend WithEvents NdefInfoRecs As ToolStripStatusLabel
    Friend WithEvents NdefInfoEmpty As ToolStripStatusLabel
    Friend WithEvents NdefInfoTNF As ToolStripStatusLabel
    Friend WithEvents statDevice As StatusStrip
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents DevInfoSN As ToolStripStatusLabel
    Friend WithEvents DevInfoHW As ToolStripStatusLabel
    Friend WithEvents DevInfoFW As ToolStripStatusLabel
    Friend WithEvents DevInfoDLL As ToolStripStatusLabel
    Friend WithEvents statNDEF As StatusStrip
    Friend WithEvents ToolStripStatusLabel12 As ToolStripStatusLabel
    Friend WithEvents statusReader As ToolStripStatusLabel
    Friend WithEvents statusResult As ToolStripStatusLabel
    Friend WithEvents gridNo As DataGridViewTextBoxColumn
    Friend WithEvents gridType As DataGridViewTextBoxColumn
    Friend WithEvents gridLength As DataGridViewTextBoxColumn
    Friend WithEvents gridPayload As DataGridViewTextBoxColumn
    Friend WithEvents btnStorePhoneToReader As Button
    Friend WithEvents bWritePhone As Button
    Friend WithEvents ePhone As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents eSMS As RichTextBox
    Friend WithEvents smsChars As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bWriteSMS As Button
    Friend WithEvents eSMSPhone As TextBox
    Friend WithEvents bStoreSMSToReader As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbUriIdentifierCode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents eURL As TextBox
    Friend WithEvents btnStoreUrlToReader As Button
    Friend WithEvents bWriteURI As Button
    Friend WithEvents eSkype As TextBox
    Friend WithEvents eWeb As TextBox
    Friend WithEvents eCompany As TextBox
    Friend WithEvents eTitle As TextBox
    Friend WithEvents ePEmail As TextBox
    Friend WithEvents eBEmail As TextBox
    Friend WithEvents eCPhone As TextBox
    Friend WithEvents eBPhone As TextBox
    Friend WithEvents eFirst As TextBox
    Friend WithEvents eLast As TextBox
    Friend WithEvents eDisplay As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents bWriteVCard As Button
    Friend WithEvents bEraseAllRecords As Button
    Friend WithEvents bEraseLastRecord As Button
    Friend WithEvents bCardNDEFInit As Button
    Friend WithEvents ePPhone As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnStoreBluetoothToReader As Button
    Friend WithEvents btnWriteBluetooth As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gReaderEmu As GroupBox
    Friend WithEvents bStopEmulation As Button
    Friend WithEvents bStartCombinedEmulation As Button
    Friend WithEvents bStartTagEmulation As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
