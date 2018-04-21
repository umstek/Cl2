Public Class TextWorks

    Class TextCase

        ''' <summary>
        ''' Converts the first letter of every word into uppercase.
        ''' </summary>
        ''' <param name="Input">Input String</param>
        ''' <returns>Converted String</returns>
        ''' <remarks>I aM iNviSiBLe. >> I Am Invisible.</remarks>
        Public Function Proper(ByVal Input As String) As String
            Return StrConv(Input, VbStrConv.ProperCase)
        End Function

        ''' <summary>
        ''' Converts the complete string into uppercase.
        ''' </summary>
        ''' <param name="Input">Input String</param>
        ''' <returns>Converted String</returns>
        ''' <remarks>I aM iNviSiBLe. >> I AM INVISIBLE.</remarks>
        Public Function Upper(ByVal Input As String) As String
            Return StrConv(Input, VbStrConv.Uppercase)
        End Function

        ''' <summary>
        ''' Converts the complete string into lowercase.
        ''' </summary>
        ''' <param name="Input">Input String</param>
        ''' <returns>Converted String</returns>
        ''' <remarks>I aM iNviSiBLe. >> i am invisible.</remarks>
        Public Function Lower(ByVal Input As String) As String
            Return StrConv(Input, VbStrConv.Lowercase)
        End Function

        ''' <summary>
        ''' Toggles the Lower/Upper Case of the each letter
        ''' </summary>
        ''' <param name="Input">Input String</param>
        ''' <returns>Converted String</returns>
        ''' <remarks>I aM iNviSiBLe. >> i Am InVIsIblE.</remarks>
        Public Function Toggle(ByVal Input As String) As String

            Dim StrBui As New System.Text.StringBuilder()
            For Each c0 As Char In Input
                If Char.IsLetter(c0) Then
                    If Char.IsUpper(c0) Then
                        StrBui.Append(Char.ToLower(c0))
                    ElseIf Char.IsLower(c0) Then
                        StrBui.Append(Char.ToUpper(c0))
                    Else
                        StrBui.Append(c0)
                    End If
                Else
                    StrBui.Append(c0)
                End If
            Next
            Return StrBui.ToString()

        End Function

    End Class

    Class TextCipher

        Class Codebook

            ''' <summary>
            ''' Encrypts a string with codebook cipher
            ''' </summary>
            ''' <param name="OriginalList">The list containing real words.</param>
            ''' <param name="ReplacementList">The list containing words to be replaced with real words.</param>
            ''' <param name="Input">Input the string to be encrypted.</param>
            ''' <returns>Encrypted String.</returns>
            ''' <remarks>ATTACK THE HILL AT DAWN >> CALCULATE THE TOTAL AT MORNING</remarks>
            Public Function Encrypt(ByVal OriginalList As String(), ByVal ReplacementList As String(), ByVal Input As String) As String

                Dim Seperator As Char() = {" "c, ","c, "."c, "("c, ")"c, "\"c, "/"c, ";"c, ":"c, "@"c, "?"c, _
                                           "!"c, """"c}
                Dim Str0 As String() = Input.Split(Seperator)
                Dim StrBui As New Text.StringBuilder
                For i As UInteger = 0 To Str0.Length - 1
                    If OriginalList.Contains(Str0(i)) Then
                        StrBui.Append(ReplacementList(Array.IndexOf(OriginalList, Str0(i))) + " ")
                    Else
                        StrBui.Append(Str0(i))
                    End If
                Next
                Return StrBui.ToString

            End Function

            ''' <summary>
            ''' Decrypts a string with codebook cipher
            ''' </summary>
            ''' <param name="OriginalList">The list containing real words.</param>
            ''' <param name="ReplacementList">The list containing fake words.</param>
            ''' <param name="Input">Input the string to be decrypted.</param>
            ''' <returns>Decrypted String.</returns>
            ''' <remarks>CALCULATE THE TOTAL AT MORNING >> ATTACK THE HILL AT DAWN</remarks>
            Public Function Decrypt(ByVal OriginalList As String(), ByVal ReplacementList As String(), ByVal Input As String) As String

                Dim Seperator As Char() = {" "c}
                Dim Str0 As String() = Input.Split(Seperator)
                Dim StrBui As New Text.StringBuilder
                For i As UInteger = 0 To Str0.Length - 1
                    If OriginalList.Contains(Str0(i)) Then
                        StrBui.Append(OriginalList(Array.IndexOf(ReplacementList, Str0(i))) + " ")
                    Else
                        StrBui.Append(Str0(i))
                    End If
                Next
                Return StrBui.ToString

            End Function

        End Class

        Class Transposition

            ''' <summary>
            ''' Returns a reversed string.
            ''' </summary>
            ''' <param name="Input">Input string to be reversed</param>
            ''' <returns>Reversed string</returns>
            ''' <remarks>reverse >> esrever</remarks>
            Public Function Reverse(ByVal Input As String) As String
                Return StrReverse(Input)
            End Function

            ''' <summary>
            ''' Returns a string with reversed blocks.
            ''' </summary>
            ''' <param name="BlockSize">Substrings of BlockSize will be reversed.</param>
            ''' <param name="Input">Input string</param>
            ''' <returns>String with reversed blocks.</returns>
            ''' <remarks>
            ''' BlkSz = 4;
            ''' A good method of transposition. >> og Am odohtefo dart opsnitis.no
            ''' </remarks>
            Public Function ReverseBlock(ByVal BlockSize As Integer, ByVal Input As String) As String

                Dim StrBui As New Text.StringBuilder
                For i As Integer = 0 To Input.Length - 1 Step BlockSize
                    If Not i + BlockSize > Input.Length - 1 Then
                        StrBui.Append(StrReverse(Input.Substring(i, BlockSize)))
                    Else
                        StrBui.Append(StrReverse(Input.Substring(i)))
                    End If
                Next
                Return StrBui.ToString

            End Function

            ''' <summary>
            ''' Returns a string containing parts reversed according to a number sequence.
            ''' </summary>
            ''' <param name="BlockSizes">Number sequence.</param>
            ''' <param name="Input">Input String.</param>
            ''' <returns>String with reversed parts.</returns>
            ''' <remarks>
            ''' BlkSzs = {1,3,7}
            ''' This cipher is better. >> Tsihrehpic   si.retteb
            ''' </remarks>
            Public Function ReverseBlockSq(ByVal BlockSizes As Integer(), ByVal Input As String) As String

                Dim StrBui As New Text.StringBuilder
                Dim BS As Integer = BlockSizes(0)
                Dim c As Integer = 0
                For i As Integer = 0 To Input.Length - 1 Step BS + 1
                    If Not (i + BS) > Input.Length Then
                        StrBui.Append(StrReverse(Input.Substring(i, BS)))
                    Else
                        StrBui.Append(StrReverse(Input.Substring(i)))
                    End If
                    c += 1
                    BS = i Mod BlockSizes.Length
                Next
                Return StrBui.ToString

            End Function

        End Class

        Class SimpleSubstitution

            ''' <summary>
            ''' Encrypts a string with simple substitution cipher
            ''' </summary>
            ''' <param name="OriginalChars">The original characters to be repaced.</param>
            ''' <param name="ReplacementChars">The repacement characters to replace originals.</param>
            ''' <param name="Input">Input the string to be encrypted.</param>
            ''' <returns>Encrypted String</returns>
            ''' <remarks>
            ''' Org. = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ''' Rep. = "ACEGIKMOQSUWYBDFHJLNPRTVXZ";
            ''' THIS CIPHER IS EASY TO BREAK >> NOQL EQFOIJ QL IALX ND CJIAU
            ''' </remarks>
            Public Function Encrypt(ByVal OriginalChars As String, ByVal ReplacementChars As String, ByVal Input As String) As String

                Dim StrBui As New Text.StringBuilder
                For i As UInt64 = 0 To Input.LongCount() - 1
                    If OriginalChars.Contains(Input(i)) = True Then
                        StrBui.Append(ReplacementChars(OriginalChars.IndexOf(Input(i))))
                    Else
                        StrBui.Append(Input(i))
                    End If
                Next
                Return StrBui.ToString

            End Function

            ''' <summary>
            ''' Decrypts a string with simple substitution cipher
            ''' </summary>
            ''' <param name="OriginalChars">The original characters.</param>
            ''' <param name="ReplacementChars">The repaced characters..</param>
            ''' <param name="Input">Input the string to be decrypted.</param>
            ''' <returns>Decrypted String</returns>
            ''' <remarks>
            ''' Org. = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ''' Rep. = "ACEGIKMOQSUWYBDFHJLNPRTVXZ";
            ''' NOQL EQFOIJ QL IALX ND CJIAU >> THIS CIPHER IS EASY TO BREAK 
            ''' </remarks>
            Public Function Decrypt(ByVal OriginalChars As String, ByVal ReplacementChars As String, ByVal Input As String) As String

                Dim StrBui As New Text.StringBuilder
                For i As UInt64 = 0 To Input.LongCount() - 1
                    If OriginalChars.Contains(Input(i)) Then
                        StrBui.Append(OriginalChars(ReplacementChars.IndexOf(Input(i))))
                    Else
                        StrBui.Append(Input(i))
                    End If
                Next
                Return StrBui.ToString

            End Function

        End Class

        Class MultipleSubstitution

            ''' <summary>
            ''' Encrypts a string with multiple substitution cipher.
            ''' </summary>
            ''' <param name="CharSequence">Character sequence.</param>
            ''' <param name="Password">Enter your password.</param>
            ''' <param name="Input">Input the string to be encrypted</param>
            ''' <returns>Encrypted string</returns>
            ''' <remarks>
            ''' Seq = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ''' Psw = "AUTOBAHN";
            ''' BREAKING THIS CIPHER IS NOT SO EASY >> CMYPMJVU UCCB EJXVFM CH PPB GP ZUHA
            ''' </remarks>
            Public Function Encrypt(ByVal CharSequence As String, ByVal Password As String, ByVal Input As String) As String

                Dim StrBui As New Text.StringBuilder
                Dim Count As UInt64 = 0
                For i As UInt64 = 0 To Input.LongCount() - 1
                    If CharSequence.Contains(Input(i)) Then
                        Dim A As UInt16 = CharSequence.IndexOf(Input(i))
                        Dim B As UInt16 = Count Mod Password.Length
                        If (A + 1) + (B + 1) > CharSequence.LongCount Then
                            StrBui.Append(CharSequence(((A + 1) + (B + 1) - CharSequence.LongCount()) - 1))
                        Else
                            StrBui.Append(CharSequence((A + 1) + (B + 1) - 1))
                        End If
                        Count += 1
                    Else
                        StrBui.Append(Input(i))
                    End If
                Next
                Return StrBui.ToString

            End Function

            ''' <summary>
            ''' Decrypts a string with multiple substitution cipher.
            ''' </summary>
            ''' <param name="CharSequence">Character sequence.</param>
            ''' <param name="Password">Enter your password.</param>
            ''' <param name="Input">Input the string to be Decrypted</param>
            ''' <returns>Decrypted string</returns>
            ''' <remarks>
            ''' Seq = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ''' Psw = "AUTOBAHN";
            ''' CMYPMJVU UCCB EJXVFM CH PPB GP ZUHA >> BREAKING THIS CIPHER IS NOT SO EASY
            ''' </remarks>
            Public Function Decrypt(ByVal CharSequence As String, ByVal Password As String, ByVal Input As String) As String

                Dim StrBui As New Text.StringBuilder
                Dim Count As UInt64 = 0
                For i As UInt64 = 0 To Input.LongCount() - 1
                    If CharSequence.Contains(Input(i)) Then
                        Dim A As UInt16 = CharSequence.IndexOf(Input(i))
                        Dim B As UInt16 = Count Mod Password.Length
                        If (A + 1) - (B + 1) < 0 Then
                            StrBui.Append(CharSequence(((A + 1) - (B + 1) + CharSequence.LongCount()) - 1))
                        Else
                            StrBui.Append(CharSequence((A + 1) - (B + 1) - 1))
                        End If
                        Count += 1
                    Else
                        StrBui.Append(Input(i))
                    End If
                Next
                Return StrBui.ToString

            End Function

        End Class

    End Class

End Class '314