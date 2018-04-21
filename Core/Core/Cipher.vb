
''' <summary>
''' [Introduction ---------------------------------------------------------------------------------------
''' 
'''   1.[clandestine cipher]
'''Unicode text passwords or key files could be used.
'''Maximum length of the password will be 281474976710656+ Unicode Characters.
'''Maximum size of the key file will be 72057594037927936+ bytes.
'''Speed of the cipher is approximately 0.31MB/sec for Encryption and 0.32MB/sec for Decryption.*
'''>> Use 1MB Blocks and 1KB Keys.
'''
'''   2.[codelord cipher]
'''Unicode text passwords or key files could be used.
'''Maximum length of the password will be INFINITY Unicode Characters.
'''Maximum size of the key file will be INFINITY bytes.
'''Speed of the cipher is approximately 0.33MB/sec for Encryption and 0.38MB/sec for Decryption.*
'''>> Use 1MB Blocks and 1KB Keys.
''' 
''' </summary>
''' <remarks>
''' *Tested with 1KB key.
''' *Tested using a computer with 4.9 subscore for processor and 4.5 subscore for RAM, (Vista Experience Index)
'''  And With Vista Ultimate x64.
''' </remarks>

Public Class Cipher '714 codelines

#Region "Declarations"

    Private CN As CipherName
    Private PasswInt(-1) As Integer
    Private PasswIntMod8(-1) As Byte
    Private PasswByt(-1) As Byte
    Private fNum As Byte = 0
    Private CprSeqClan() As String = {"BTpC1", "BTpC2", "BTpC3", "STpC1", "STpC2", "STpC3", "BmSC", "BsSC", _
                                                                                            "SmSC", "SsSC"}
    Private CprSeqCode() As String = {"BTpC1", "BTpC3", "STpC1", "STpC3", "BmSC", "BsSC", "SmSC", "SsSC"}
    Private BytSeqO(-1) As Byte
    Private BytSeqR(-1) As Byte
    Private StrSeqO() As Char = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "A"c, "B"c, _
                                 "C"c, "D"c, "E"c, "F"c, "G"c, "H"c, "I"c, "J"c, "K"c, "L"c, "M"c, "N"c, _
                                 "O"c, "P"c, "Q"c, "R"c, "S"c, "T"c, "U"c, "V"c, "W"c, "X"c, "Y"c, "Z"c, _
                                 "a"c, "b"c, "c"c, "d"c, "e"c, "f"c, "g"c, "h"c, "i"c, "j"c, "k"c, "l"c, _
                                 "m"c, "n"c, "o"c, "p"c, "q"c, "r"c, "s"c, "t"c, "u"c, "v"c, "w"c, "x"c, _
                                 "y"c, "z"c, "/"c, "+"c}
    Private StrSeqR() As Char = StrSeqO
    Private PswB64 As String = ""

#End Region

#Region "Preparations"

    Private Sub FillBytSeq()

        For Int0 As Int16 = 0 To 255 Step 1

            ReDim Preserve BytSeqO(Int0)
            BytSeqO(Int0) = CByte(Int0)

            ReDim Preserve BytSeqR(Int0)
            BytSeqR(Int0) = CByte(Int0)

        Next

    End Sub

    Private Sub GenPMcode(ByVal Password As Byte())

        For Int0 As Integer = 0 To Password.Length - 1 Step 1

            ReDim Preserve PasswInt(PasswInt.Length)
            PasswInt(PasswInt.Length - 1) = Password(Int0)

            ReDim Preserve PasswIntMod8(PasswIntMod8.Length)
            PasswIntMod8(PasswIntMod8.Length - 1) = CByte(Password(Int0) Mod 8)

        Next Int0

        PasswByt = Password
        PswB64 = Convert.ToBase64String(PasswByt, 0, PasswByt.Length - PasswByt.Length Mod 3)

    End Sub

    Private Sub GenPMcode(ByVal Password As String)

        For Int0 As Integer = 0 To Password.Length - 1 Step 1

            ReDim Preserve PasswInt(PasswInt.Length)
            PasswInt(PasswInt.Length - 1) = AscW(Password(Int0))

            ReDim Preserve PasswIntMod8(PasswIntMod8.Length)
            PasswIntMod8(PasswIntMod8.Length - 1) = CByte(AscW(Password(Int0)) Mod 8)

        Next Int0

        PasswByt = System.Text.Encoding.Unicode.GetBytes(Password)
        PswB64 = Convert.ToBase64String(PasswByt, 0, PasswByt.Length - PasswByt.Length Mod 3)

    End Sub

    Private Sub GenfNum()

        Dim Str0 As String = ""
        Dim Int0 As ULong = 0

        For Each Int1 As Integer In PasswInt
            Int0 = CULng(Int0 + Int1)
        Next Int1
        Str0 = Str(Int0)
        Int0 = 0

        While Str0.Length <> 1
            For Each Chr0 As Char In Str0
                Int0 = CULng(Int0 + Val(Chr0))
            Next Chr0
            Str0 = Str(Int0).Trim
            Int0 = 0
        End While

        fNum = CByte(Val(Str0))

    End Sub

    Private Sub GenCprSeq()

        If CN = CipherName.clandestine Then
            For Byt0 As Byte = 0 To 9 Step CByte(fNum + 1)
                If Byt0 + fNum <= 10 Then
                    Array.Reverse(CprSeqClan, Byt0, fNum)
                Else
                    Array.Reverse(CprSeqClan, Byt0, CprSeqClan.Length - Byt0)
                End If
            Next Byt0
        Else
            Dim B As Byte = PasswIntMod8(0)
            For Byt0 As Integer = 0 To CprSeqCode.Length - 1 Step B + 1
                If Byt0 + B <= CprSeqCode.Length Then
                    Array.Reverse(CprSeqCode, Byt0, B)
                Else
                    Array.Reverse(CprSeqCode, Byt0, CprSeqCode.Length - Byt0)
                End If
                B = CByte(Byt0 Mod PasswIntMod8.Length)
            Next Byt0
        End If

    End Sub

    Private Sub GenBytSeq()

        Dim B As Byte = PasswIntMod8(0)
        For Byt0 As Integer = 0 To BytSeqR.Length - 1 Step B + 1
            If Byt0 + B <= BytSeqR.Length Then
                Array.Reverse(BytSeqR, Byt0, B)
            Else
                Array.Reverse(BytSeqR, Byt0, BytSeqR.Length - Byt0)
            End If
            B = CByte(Byt0 Mod PasswIntMod8.Length)
        Next Byt0

    End Sub

    Private Sub GenStrSeq()

        Dim B As Byte = PasswIntMod8(0)
        For Byt0 As Integer = 0 To StrSeqR.Length - 1 Step B + 1
            If Byt0 + B <= StrSeqR.Length Then
                Array.Reverse(StrSeqR, Byt0, B)
            Else
                Array.Reverse(StrSeqR, Byt0, StrSeqR.Length - Byt0)
            End If
            B = CByte(Byt0 Mod PasswIntMod8.Length)
        Next Byt0

    End Sub

#End Region

#Region "Compressions"

    Private Shared Function CharAtoStr(ByVal CharA As Char()) As String

        Dim StrBui As New System.Text.StringBuilder()
        For Each lCharA As Char In CharA
            StrBui.Append(lCharA)
        Next
        Return StrBui.ToString

    End Function

    Public Enum CipherName As SByte
        clandestine = -1
        codelord = +1
    End Enum

#End Region

#Region "Constituents"

    Private Shared Function BTpC1_En(ByVal ByteA As Byte()) As Byte()

        SyncLock New Object
            Array.Reverse(ByteA)
            Return ByteA
        End SyncLock

    End Function

    Private Shared Function BTpC1_De(ByVal ByteA As Byte()) As Byte()

        Return BTpC1_En(ByteA)

    End Function

    Private Function BTpC2_En(ByVal byteA As Byte()) As Byte()

        SyncLock New Object
            For Int0 As Integer = 0 To byteA.Length - 1 Step fNum + 1
                If Int0 + fNum <= byteA.Length Then
                    Array.Reverse(byteA, Int0, fNum)
                    Continue For
                End If
                Array.Reverse(byteA, Int0, byteA.Length - Int0)
            Next
            Return byteA
        End SyncLock

    End Function

    Private Function BTpC2_De(ByVal byteA As Byte()) As Byte()

        Return BTpC2_En(byteA)

    End Function

    Private Function BTpC3_En(ByVal byteA As Byte()) As Byte()

        SyncLock New Object
            Dim I As Integer = PasswInt(0)
            For Int0 As Integer = 0 To byteA.Length - 1 Step I + 1
                If Int0 + I <= byteA.Length Then
                    Array.Reverse(byteA, Int0, I)
                Else
                    Array.Reverse(byteA, Int0, byteA.Length - Int0)
                End If
                I = Int0 Mod PasswInt.Length
            Next
            Return byteA
        End SyncLock

    End Function

    Private Function BTpC3_De(ByVal byteA As Byte()) As Byte()

        Return BTpC3_En(byteA)

    End Function

    Private Shared Function STpC1i_En(ByVal CharA As Char()) As Char()

        SyncLock New Object
            Array.Reverse(CharA)
            Return CharA
        End SyncLock

    End Function

    Private Shared Function STpC1i_De(ByVal CharA As Char()) As Char()

        Return STpC1i_En(CharA)

    End Function

    Private Shared Function STpC1_En(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(STpC1i_En(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Shared Function STpC1_De(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(STpC1i_De(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function STpC2i_En(ByVal CharA As Char()) As Char()

        SyncLock New Object
            For Int0 As Integer = 0 To CharA.Length - 1 Step fNum + 1
                If Int0 + fNum <= CharA.Length Then
                    Array.Reverse(CharA, Int0, fNum)
                    Continue For
                End If
                Array.Reverse(CharA, Int0, CharA.Length - Int0)
            Next
            Return CharA
        End SyncLock

    End Function

    Private Function STpC2i_De(ByVal CharA As Char()) As Char()

        Return STpC2i_En(CharA)

    End Function

    Private Function STpC2_En(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(STpC2i_En(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function STpC2_De(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(STpC2i_De(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function STpC3i_En(ByVal CharA As Char()) As Char()

        SyncLock New Object
            Dim I As Integer = PasswInt(0)
            For Int0 As Integer = 0 To CharA.Length - 1 Step I + 1
                If Int0 + I <= CharA.Length Then
                    Array.Reverse(CharA, Int0, I)
                Else
                    Array.Reverse(CharA, Int0, CharA.Length - Int0)
                End If
                I = Int0 Mod PasswInt.Length
            Next
            Return CharA
        End SyncLock

    End Function

    Private Function STpC3i_De(ByVal CharA As Char()) As Char()

        Return STpC3i_En(CharA)

    End Function

    Private Function STpC3_En(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(STpC3i_En(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function STpC3_De(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(STpC3i_De(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function BsSC_En(ByVal Input As Byte()) As Byte()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Byte
            For i As Int64 = 0 To Input.LongLength - 1
                Output(CInt(i)) = BytSeqR(Array.IndexOf(BytSeqO, Input(CInt(i))))
            Next
            Return Output
        End SyncLock

    End Function

    Private Function BsSC_De(ByVal Input As Byte()) As Byte()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Byte
            For i As Int64 = 0 To Input.LongLength - 1
                Output(CInt(i)) = BytSeqO(Array.IndexOf(BytSeqR, Input(CInt(i))))
            Next
            Return Output
        End SyncLock

    End Function

    Private Function SsSCi_En(ByVal Input As Char()) As Char()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Char
            For i As Int64 = 0 To Input.LongLength - 1
                Output(CInt(i)) = StrSeqR(Array.IndexOf(StrSeqO, Input(CInt(i))))
            Next
            Return Output
        End SyncLock

    End Function

    Private Function SsSCi_De(ByVal Input As Char()) As Char()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Char
            For i As Int64 = 0 To Input.LongLength - 1
                Output(CInt(i)) = StrSeqO(Array.IndexOf(StrSeqR, Input(CInt(i))))
            Next
            Return Output
        End SyncLock

    End Function

    Private Function SsSC_En(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(SsSCi_En(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function SsSC_De(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(SsSCi_De(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function BmSC_En(ByVal Input As Byte()) As Byte()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Byte
            For i As Integer = 0 To Input.Length - 1
                Output(i) = If(Input(i) + 1 + CInt(PasswByt(i Mod PasswByt.Length)) + 1 > 256, _
                                Input(i) + 1 + CInt(PasswByt(i Mod PasswByt.Length)) + 1 - 256 - 1, _
                                Input(i) + 1 + CInt(PasswByt(i Mod PasswByt.Length)) + 1 - 1)
            Next
            Return Output
        End SyncLock

    End Function

    Private Function BmSC_De(ByVal Input As Byte()) As Byte()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Byte
            For i As Integer = 0 To Input.Length - 1
                Output(i) = If(Input(i) + 1 - (CInt(PasswByt(i Mod PasswByt.Length)) + 1) < 1, _
                                Input(i) + 1 - (CInt(PasswByt(i Mod PasswByt.Length)) + 1) + 256 - 1, _
                                Input(i) + 1 - (CInt(PasswByt(i Mod PasswByt.Length)) + 1) - 1)
            Next
            Return Output
        End SyncLock

    End Function

    Private Function SmSCi_En(ByVal Input As Char()) As Char()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Char
            For i As Integer = 0 To Input.Length - 1
                Output(i) = If(CSByte(Array.IndexOf(StrSeqO, Input(i))) + CSByte(Array.IndexOf(StrSeqO, PswB64(i Mod PswB64.Length))) > 63, _
                                StrSeqO(CSByte(Array.IndexOf(StrSeqO, Input(i))) + CSByte(Array.IndexOf(StrSeqO, PswB64(i Mod PswB64.Length))) - 64), _
                                StrSeqO(CSByte(Array.IndexOf(StrSeqO, Input(i))) + CSByte(Array.IndexOf(StrSeqO, PswB64(i Mod PswB64.Length)))))
            Next
            Return Output
        End SyncLock

    End Function

    Private Function SmSCi_De(ByVal Input As Char()) As Char()

        SyncLock New Object
            Dim Output(Input.Length - 1) As Char
            For i As Integer = 0 To Input.Length - 1
                Output(i) = If(CSByte(Array.IndexOf(StrSeqO, Input(i))) - CSByte(Array.IndexOf(StrSeqO, PswB64(i Mod PswB64.Length))) < 0, _
                                StrSeqO(CSByte(Array.IndexOf(StrSeqO, Input(i))) - CSByte(Array.IndexOf(StrSeqO, PswB64(i Mod PswB64.Length))) + 64), _
                                StrSeqO(CSByte(Array.IndexOf(StrSeqO, Input(i))) - CSByte(Array.IndexOf(StrSeqO, PswB64(i Mod PswB64.Length)))))
            Next
            Return Output
        End SyncLock

    End Function

    Private Function SmSC_En(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(SmSCi_En(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

    Private Function SmSC_De(ByVal Str0 As String) As String

        Dim Str1 As String = Str0.Substring(Str0.Length - 4, 4).Trim
        Return CharAtoStr(SmSCi_De(Str0.ToCharArray(0, Str0.Length - 4))) + Str1.Trim

    End Function

#End Region

#Region "Initialization"

    Private Sub Prepare(ByVal Password As Byte())

        StrSeqR = StrSeqO
        FillBytSeq()
        GenPMcode(Password)
        If CN = CipherName.clandestine Then
            GenfNum()
        End If
        GenCprSeq()
        GenBytSeq()

    End Sub

    Private Sub Prepare(ByVal Password As String)

        StrSeqR = StrSeqO
        FillBytSeq()
        GenPMcode(Password)
        If CN = CipherName.clandestine Then
            GenfNum()
        End If
        GenCprSeq()
        GenBytSeq()

    End Sub

    ''' <summary>
    ''' Creates A New Instance
    ''' </summary>
    ''' <param name="NameOfCipher">Select The Name Of The Algorithm</param>
    ''' <param name="Password">Enter Your Password Here</param>
    ''' <remarks>Use 1KB keys</remarks>
    Public Sub New(ByVal NameOfCipher As CipherName, ByVal Password As String)
        CN = NameOfCipher
        Prepare(Password)
    End Sub

    ''' <summary>
    ''' Creates A New Instance
    ''' </summary>
    ''' <param name="NameOfCipher">Select The Name Of The Algorithm</param>
    ''' <param name="Password">Enter The Bytes Of Your Key File Here</param>
    ''' <remarks>Use 1KB keys</remarks>
    Public Sub New(ByVal NameOfCipher As CipherName, ByVal Password As Byte())
        CN = NameOfCipher
        Prepare(Password)
    End Sub
#End Region

#Region "Input Redirection"

    Private Function clandestine_en(ByVal Input As Byte()) As Byte()

        Dim BytStore() As Byte = Input

        For Each Strng As String In CprSeqClan
            Select Case Strng.Trim
                Case Is = "BTpC1"
                    BytStore = BTpC1_En(BytStore)
                Case Is = "BTpC2"
                    BytStore = BTpC2_En(BytStore)
                Case Is = "BTpC3"
                    BytStore = BTpC3_En(BytStore)
                Case Is = "STpC1"
                    BytStore = Convert.FromBase64String(STpC1_En(Convert.ToBase64String(BytStore)))
                Case Is = "STpC2"
                    BytStore = Convert.FromBase64String(STpC2_En(Convert.ToBase64String(BytStore)))
                Case Is = "STpC3"
                    BytStore = Convert.FromBase64String(STpC3_En(Convert.ToBase64String(BytStore)))
                Case Is = "BmSC"
                    BytStore = BmSC_En(BytStore)
                Case Is = "BsSC"
                    BytStore = BsSC_En(BytStore)
                Case Is = "SmSC"
                    BytStore = Convert.FromBase64String(SmSC_En(Convert.ToBase64String(BytStore)))
                Case Is = "SsSC"
                    BytStore = Convert.FromBase64String(SsSC_En(Convert.ToBase64String(BytStore)))
            End Select
        Next

        Return BytStore

    End Function

    Private Function clandestine_de(ByVal Input As Byte()) As Byte()

        Dim BytStore() As Byte = Input
        Dim CprSeqClanRev As String() = CprSeqClan
        Array.Reverse(CprSeqClanRev)

        For Each Strng As String In CprSeqClanRev
            Select Case Strng.Trim
                Case Is = "BTpC1"
                    BytStore = BTpC1_De(BytStore)
                Case Is = "BTpC2"
                    BytStore = BTpC2_De(BytStore)
                Case Is = "BTpC3"
                    BytStore = BTpC3_De(BytStore)
                Case Is = "STpC1"
                    BytStore = Convert.FromBase64String(STpC1_De(Convert.ToBase64String(BytStore)))
                Case Is = "STpC2"
                    BytStore = Convert.FromBase64String(STpC2_De(Convert.ToBase64String(BytStore)))
                Case Is = "STpC3"
                    BytStore = Convert.FromBase64String(STpC3_De(Convert.ToBase64String(BytStore)))
                Case Is = "BmSC"
                    BytStore = BmSC_De(BytStore)
                Case Is = "BsSC"
                    BytStore = BsSC_De(BytStore)
                Case Is = "SmSC"
                    BytStore = Convert.FromBase64String(SmSC_De(Convert.ToBase64String(BytStore)))
                Case Is = "SsSC"
                    BytStore = Convert.FromBase64String(SsSC_De(Convert.ToBase64String(BytStore)))
            End Select
        Next

        Return BytStore

    End Function

    Private Function codelord_en(ByVal Input As Byte()) As Byte()

        Dim BytStore() As Byte = Input

        For Each Strng As String In CprSeqCode
            Select Case Strng.Trim
                Case Is = "BTpC1"
                    BytStore = BTpC1_En(BytStore)
                Case Is = "BTpC3"
                    BytStore = BTpC3_En(BytStore)
                Case Is = "STpC1"
                    BytStore = Convert.FromBase64String(STpC1_En(Convert.ToBase64String(BytStore)))
                Case Is = "STpC3"
                    BytStore = Convert.FromBase64String(STpC3_En(Convert.ToBase64String(BytStore)))
                Case Is = "BmSC"
                    BytStore = BmSC_En(BytStore)
                Case Is = "BsSC"
                    BytStore = BsSC_En(BytStore)
                Case Is = "SmSC"
                    BytStore = Convert.FromBase64String(SmSC_En(Convert.ToBase64String(BytStore)))
                Case Is = "SsSC"
                    BytStore = Convert.FromBase64String(SsSC_En(Convert.ToBase64String(BytStore)))
            End Select
        Next

        Return BytStore

    End Function

    Private Function codelord_de(ByVal Input As Byte()) As Byte()

        Dim BytStore() As Byte = Input
        Dim CprSeqCodeRev As String() = CprSeqCode
        Array.Reverse(CprSeqCodeRev)

        For Each Strng As String In CprSeqCodeRev
            Select Case Strng.Trim
                Case Is = "BTpC1"
                    BytStore = BTpC1_De(BytStore)
                Case Is = "BTpC3"
                    BytStore = BTpC3_De(BytStore)
                Case Is = "STpC1"
                    BytStore = Convert.FromBase64String(STpC1_De(Convert.ToBase64String(BytStore)))
                Case Is = "STpC3"
                    BytStore = Convert.FromBase64String(STpC3_De(Convert.ToBase64String(BytStore)))
                Case Is = "BmSC"
                    BytStore = BmSC_De(BytStore)
                Case Is = "BsSC"
                    BytStore = BsSC_De(BytStore)
                Case Is = "SmSC"
                    BytStore = Convert.FromBase64String(SmSC_De(Convert.ToBase64String(BytStore)))
                Case Is = "SsSC"
                    BytStore = Convert.FromBase64String(SsSC_De(Convert.ToBase64String(BytStore)))
            End Select
        Next

        Return BytStore

    End Function

#End Region

#Region "Direct Access Functions"

    ''' <summary>
    ''' Encrypts data with the selected algorithm
    ''' </summary>
    ''' <param name="Input">Input (Original) Data</param>
    ''' <returns>Output (Encrypted) Data</returns>
    ''' <remarks>Block Size is the complete array size.</remarks>
    Public Function Encrypt(ByVal Input As Byte()) As Byte()

        Dim BytStore() As Byte = Input

        Select Case CN
            Case CipherName.clandestine
                BytStore = clandestine_en(BytStore)
            Case CipherName.codelord
                BytStore = codelord_en(BytStore)
            Case Else
        End Select

        Return BytStore

    End Function

    ''' <summary>
    ''' Decrypts data with the selected algorithm
    ''' </summary>
    ''' <param name="Input">Input (Encrypted) Data</param>
    ''' <returns>Output (Decrypted) Data</returns>
    ''' <remarks>Block Size is the complete array size.</remarks>
    Public Function Decrypt(ByVal Input As Byte()) As Byte()

        Dim BytStore() As Byte = Input

        Select Case CN
            Case CipherName.clandestine
                BytStore = clandestine_de(BytStore)
            Case CipherName.codelord
                BytStore = codelord_de(BytStore)
            Case Else
        End Select

        Return BytStore

    End Function

#End Region

End Class