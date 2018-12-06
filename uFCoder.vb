
Imports System.Runtime.InteropServices
Public Class uFCoder

    Public Enum DLCARDTYPE

        DL_NO_CARD = &H0
        DL_MIFARE_ULTRALIGHT = &H1
        DL_MIFARE_ULTRALIGHT_EV1_11 = &H2
        DL_MIFARE_ULTRALIGHT_EV1_21 = &H3
        DL_MIFARE_ULTRALIGHT_C = &H4
        DL_NTAG_203 = &H5
        DL_NTAG_210 = &H6
        DL_NTAG_212 = &H7
        DL_NTAG_213 = &H8
        DL_NTAG_215 = &H9
        DL_NTAG_216 = &HA

        DL_MIFARE_MINI = &H20
        DL_MIFARE_CLASSIC_1K = &H21
        DL_MIFARE_CLASSIC_4K = &H22
        DL_MIFARE_PLUS_S_2K = &H23
        DL_MIFARE_PLUS_S_4K = &H24
        DL_MIFARE_PLUS_X_2K = &H25
        DL_MIFARE_PLUS_X_4K = &H26
        DL_MIFARE_DESFIRE = &H27
        DL_MIFARE_DESFIRE_EV1_2K = &H28
        DL_MIFARE_DESFIRE_EV1_4K = &H29
        DL_MIFARE_DESFIRE_EV1_8K = &H2A

        DL_UNKNOWN_ISO_14443_4 = &H40

    End Enum

    Public Enum ERRORCODES

        DL_OK = &H0
        COMMUNICATION_ERROR = &H1
        CHKSUM_ERROR = &H2
        READING_ERROR = &H3
        WRITING_ERROR = &H4
        BUFFER_OVERFLOW = &H5
        MAX_ADDRESS_EXCEEDED = &H6
        MAX_KEY_INDEX_EXCEEDED = &H7
        NO_CARD = &H8
        COMMAND_NOT_SUPPORTED = &H9
        FORBIDEN_DIRECT_WRITE_IN_SECTOR_TRAILER = &HA
        ADDRESSED_BLOCK_IS_NOT_SECTOR_TRAILER = &HB
        WRONG_ADDRESS_MODE = &HC
        WRONG_ACCESS_BITS_VALUES = &HD
        AUTH_ERROR = &HE
        PARAMETERS_ERROR = &HF
        MAX_SIZE_EXCEEDED = &H10
        UNSUPPORTED_CARD_TYPE = &H11

        COMMUNICATION_BREAK = &H50
        NO_MEMORY_ERROR = &H51
        CAN_NOT_OPEN_READER = &H52
        READER_NOT_SUPPORTED = &H53
        READER_OPENING_ERROR = &H54
        READER_PORT_NOT_OPENED = &H55
        CANT_CLOSE_READER_PORT = &H56

        WRITE_VERIFICATION_ERROR = &H70
        BUFFER_SIZE_EXCEEDED = &H71
        VALUE_BLOCK_INVALID = &H72
        VALUE_BLOCK_ADDR_INVALID = &H73
        VALUE_BLOCK_MANIPULATION_ERROR = &H74
        WRONG_UI_MODE = &H75
        KEYS_LOCKED = &H76
        KEYS_UNLOCKED = &H77
        WRONG_PASSWORD = &H78
        CAN_NOT_LOCK_DEVICE = &H79
        CAN_NOT_UNLOCK_DEVICE = &H7A
        DEVICE_EEPROM_BUSY = &H7B
        RTC_SET_ERROR = &H7C
        ANTICOLLISION_DISABLED = &H7D
        NO_CARDS_ENUMERRATED = &H7E
        CARD_ALREADY_SELECTED = &H7F
        UFR_WRONG_NDEF_CARD_FORMAT = &H80
        UFR_NDEF_MESSAGE_NOT_FOUND = &H81

        FT_STATUS_ERROR_1 = &HA0
        FT_STATUS_ERROR_2 = &HA1
        FT_STATUS_ERROR_3 = &HA2
        FT_STATUS_ERROR_4 = &HA3
        FT_STATUS_ERROR_5 = &HA4
        FT_STATUS_ERROR_6 = &HA5
        FT_STATUS_ERROR_7 = &HA6
        FT_STATUS_ERROR_8 = &HA7
        FT_STATUS_ERROR_9 = &HA8

    End Enum

#If WIN64 Then
    Const DLL_PATH = "..\\..\\lib\\windows\\x86_64\\"
    Const NAME_DLL = "uFCoder-x86_64.dll"
#Else
    Const DLL_PATH = "..\\..\\lib\\windows\\x86\\"
    Const NAME_DLL = "uFCoder-x86.dll"
#End If
    Const DLL_NAME = DLL_PATH + NAME_DLL

    Dim dll_ver As UInt32


    <DllImport(DLL_NAME, EntryPoint:="ReaderOpen", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ReaderOpen() As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="ReaderClose", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ReaderClose() As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="ReaderUISignal", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ReaderUISignal(ByVal light_mode As Integer, ByVal sound_mode As Integer) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetReaderType", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetReaderType(ByRef get_reader_type As ULong) As UInt32
    End Function



    <DllImport(DLL_NAME, EntryPoint:="GetCardIdEx", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetCardIdEx(ByRef bCardType As Byte,
                                       ByRef bCardUID As Byte,
                                       ByRef bCardUIDSize As Byte
                                      ) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetDlogicCardType", CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetDlogicCardType(ByRef bCardType As Byte
                                            ) As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetDllVersion", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetDllVersion() As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetReaderSerialDescription", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetReaderSerialDescription(ParamArray pSerialDescription As Byte()) As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetBuildNumber", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetBuildNumber(ByRef build_nr As Byte) As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetReaderHardwareVersion", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetReaderHardwareVersion(ByRef hw_major As Byte, ByRef hw_minor As Byte) As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="GetReaderFirmwareVersion", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function GetReaderFirmwareVersion(ByRef version_major As Byte, ByRef version_minor As Byte) As UInt32

    End Function
    <DllImport(DLL_NAME, EntryPoint:="read_ndef_record", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function read_ndef_record(ByVal message_nr As Byte,
                                            ByVal record_nr As Byte,
                                            ByRef tnf As Byte,
                                            ByVal type_record() As Byte,
                                            ByRef type_length As Byte,
                                            ByRef id As Byte,
                                            ByRef id_length As Byte,
                                            ByVal payload() As Byte,
                                            ByRef payload_length As UInt32) As UInt32
    End Function

    <DllImport(DLL_NAME, EntryPoint:="get_ndef_record_count", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function get_ndef_record_count(ByRef ndef_message_cnt As Byte,
                                                  ByRef ndef_record_cnt As Byte,
                                                  ByRef ndef_record_array As Byte,
                                                  ByRef empty_ndef_message_cnt As Byte) As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="write_ndef_record", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function write_ndef_record(ByVal message_nr As Byte,
                                             ByRef tnf As Byte,
                                             ByVal type_record() As Byte,
                                             ByRef type_length As Byte,
                                             ByVal id() As Byte,
                                             ByRef id_length As Byte,
                                             ByVal payload() As Byte,
                                             ByRef payload_length As UInt32,
                                             ByRef card_formatted As Byte) As UInt32


    End Function


    <DllImport(DLL_NAME, EntryPoint:="erase_last_ndef_record", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function erase_last_ndef_record(ByVal message_nr As Byte) As UInt32


    End Function

    <DllImport(DLL_NAME, EntryPoint:="erase_all_ndef_records", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function erase_all_ndef_records(ByVal message_nr As Byte) As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="ndef_card_initialization", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function ndef_card_initialization() As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="TagEmulationStart", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function TagEmulationStart() As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="TagEmulationStop", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function TagEmulationStop() As UInt32

    End Function

    <DllImport(DLL_NAME, EntryPoint:="CombinedModeEmulationStart", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function CombinedModeEmulationStart() As UInt32

    End Function


    <DllImport(DLL_NAME, EntryPoint:="WriteEmulationNdef", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function WriteEmulationNdef(ByVal tnf As Byte,
                                              ByVal type_record() As Byte,
                                              ByVal type_length As Byte,
                                              ByVal id() As Byte,
                                              ByVal id_length As Byte,
                                              ByVal payload() As Byte,
                                              ByVal payload_length As UInt32) As UInt32

    End Function


End Class
