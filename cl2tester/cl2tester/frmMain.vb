Public Class frmMain

    Dim rndKey(-1) As Byte
    Dim rndData(-1) As Byte

    Private Sub chkKey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKey.CheckedChanged

        If CType(sender, CheckBox).Checked Then
            lblKeyLen.Enabled = True
            txtKeyLen.Enabled = True
            lstkey.Enabled = True
            btnRndKey.Show()
            txtPW.Enabled = False
            lblPW.Enabled = False
        Else
            lblKeyLen.Enabled = False
            txtKeyLen.Enabled = False
            lstkey.Enabled = False
            btnRndKey.Hide()
            txtPW.Enabled = True
            lblPW.Enabled = True
        End If

    End Sub

    Private Sub btnRndKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRndKey.Click

        If Not txtKeyLen.Text = "" Then
            If Not Val(txtKeyLen.Text) < 4 Then
                ReDim rndKey(Val(txtKeyLen.Text) - 1)
                lstkey.Items.Clear()
                For i As Integer = 0 To Val(txtKeyLen.Text) - 1
                    rndKey(i) = CInt(Rnd() * 1000) Mod 256
                    lstkey.Items.Add(Hex(rndKey(i)))
                Next
            Else
                MsgBox("Invalid Key Length", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub btnRndData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRndData.Click

        If Not txtDataLen.Text = "" Then
            If Not Val(txtDataLen.Text) < 4 Then
                ReDim rndData(Val(txtDataLen.Text) - 1)
                lstData.Items.Clear()
                For i As Integer = 0 To Val(txtDataLen.Text) - 1
                    rndData(i) = CInt(Rnd() * 1000) Mod 256
                    lstData.Items.Add(Hex(rndData(i)))
                Next
            Else
                MsgBox("Invalid Data Length", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Dim stE As DateTime
    Dim etE As DateTime
    Dim stD As DateTime
    Dim etD As DateTime

    Private Sub btnTgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTgo.Click

        If Not (rndData.Length = 0 Or (rndKey.Length = 0 And txtPW.Text.Length < 2)) Then
            Select Case cmbCN.Text
                Case "clandestine"

                    Dim clan As Cl2.Cipher
                    If Not chkKey.Checked Then
                        clan = New Cl2.Cipher(Cl2.Cipher.CipherName.clandestine, txtPW.Text)
                    Else
                        clan = New Cl2.Cipher(Cl2.Cipher.CipherName.clandestine, rndKey)
                    End If

                    If Not txtNumBlk.Text = "" Then
                        stE = Now
                        For i As Integer = 0 To CInt(Val(txtNumBlk.Text))
                            clan.Encrypt(rndData)
                        Next
                        etE = Now
                    Else

                    End If

                    If Not txtNumBlk.Text = "" Then
                        stD = Now
                        For i As Integer = 0 To CInt(Val(txtNumBlk.Text))
                            clan.Decrypt(rndData)
                        Next
                        etD = Now
                    Else

                    End If

                Case "codelord"

                    Dim code As Cl2.Cipher
                    If Not chkKey.Checked Then
                        code = New Cl2.Cipher(Cl2.Cipher.CipherName.codelord, txtPW.Text)
                    Else
                        code = New Cl2.Cipher(Cl2.Cipher.CipherName.codelord, rndKey)
                    End If

                    If Not txtNumBlk.Text = "" Then
                        stE = Now
                        For i As Integer = 0 To CInt(Val(txtNumBlk.Text))
                            code.Encrypt(rndData)
                        Next
                        etE = Now
                    Else

                    End If

                    If Not txtNumBlk.Text = "" Then
                        stD = Now
                        For i As Integer = 0 To CInt(Val(txtNumBlk.Text))
                            code.Decrypt(rndData)
                        Next
                        etD = Now
                    Else

                    End If

                Case Else
                    MsgBox("Select a cipher", MsgBoxStyle.Exclamation)
            End Select
        Else
            MsgBox("Invalid Input", MsgBoxStyle.Exclamation)
        End If

        txtTDL.Text = (Val(txtNumBlk.Text) * rndData.Length).ToString
        txtTKL.Text = rndKey.Length.ToString

        txtTST.Text = stE.ToLongTimeString + stE.Millisecond.ToString + " , " + stD.ToLongTimeString + stD.Millisecond.ToString
        txtTET.Text = etE.ToLongTimeString + etE.Millisecond.ToString + " , " + etD.ToLongTimeString + etD.Millisecond.ToString

        txtTS.Text = (((CInt(Val(txtNumBlk.Text)) * rndData.Length) / (etE - stE).TotalSeconds) / 1024).ToString + " K , " + (((CInt(Val(txtNumBlk.Text)) * rndData.Length) / (etD - stD).TotalSeconds) / 1024).ToString + " K"

    End Sub

    Private Sub btnTCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTCI.Click

        On Error Resume Next

        If MsgBox("This operation will include CPU speed, OS and RAM amount. Continue?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question) = MsgBoxResult.Ok Then
            Clipboard.SetText("Data length: " + txtTDL.Text + vbCrLf + _
                              "Key length: " + txtTKL.Text + vbCrLf + _
                              "Start time: " + txtTST.Text + " (e,d)" + vbCrLf + _
                              "End time: " + txtTET.Text + " (e,d)" + vbCrLf + _
                              "Speed: " + txtTS.Text + " (e,d)" + vbCrLf + _
                              "Cipher: " + cmbCN.Text + vbCrLf + _
                              "RAM: " + My.Computer.Info.TotalPhysicalMemory.ToString + vbCrLf + _
                              "OS: " + My.Computer.Info.OSFullName.ToString + vbCrLf + _
                              "CPU: " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", "Unknown"))
        End If

    End Sub

End Class
