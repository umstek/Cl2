<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblDesc = New System.Windows.Forms.Label
        Me.grpCipher = New System.Windows.Forms.GroupBox
        Me.btnRndKey = New System.Windows.Forms.Button
        Me.lstkey = New System.Windows.Forms.ListBox
        Me.txtKeyLen = New System.Windows.Forms.TextBox
        Me.lblKeyLen = New System.Windows.Forms.Label
        Me.lblPW = New System.Windows.Forms.Label
        Me.txtPW = New System.Windows.Forms.TextBox
        Me.chkKey = New System.Windows.Forms.CheckBox
        Me.lblCN = New System.Windows.Forms.Label
        Me.cmbCN = New System.Windows.Forms.ComboBox
        Me.lblInfo = New System.Windows.Forms.Label
        Me.grpData = New System.Windows.Forms.GroupBox
        Me.btnRndData = New System.Windows.Forms.Button
        Me.lstData = New System.Windows.Forms.ListBox
        Me.lblNumBlk = New System.Windows.Forms.Label
        Me.lblDataLen = New System.Windows.Forms.Label
        Me.txtNumBlk = New System.Windows.Forms.TextBox
        Me.txtDataLen = New System.Windows.Forms.TextBox
        Me.grpTest = New System.Windows.Forms.GroupBox
        Me.lblTKL = New System.Windows.Forms.Label
        Me.lblTDL = New System.Windows.Forms.Label
        Me.txtTET = New System.Windows.Forms.TextBox
        Me.txtTS = New System.Windows.Forms.TextBox
        Me.txtTST = New System.Windows.Forms.TextBox
        Me.txtTKL = New System.Windows.Forms.TextBox
        Me.txtTDL = New System.Windows.Forms.TextBox
        Me.lblTS = New System.Windows.Forms.Label
        Me.lblTET = New System.Windows.Forms.Label
        Me.lblTST = New System.Windows.Forms.Label
        Me.btnTCI = New System.Windows.Forms.Button
        Me.btnTgo = New System.Windows.Forms.Button
        Me.grpCipher.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.grpTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDesc.ForeColor = System.Drawing.Color.Brown
        Me.lblDesc.Location = New System.Drawing.Point(331, 318)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(451, 95)
        Me.lblDesc.TabIndex = 4
        Me.lblDesc.Text = resources.GetString("lblDesc.Text")
        '
        'grpCipher
        '
        Me.grpCipher.Controls.Add(Me.btnRndKey)
        Me.grpCipher.Controls.Add(Me.lstkey)
        Me.grpCipher.Controls.Add(Me.txtKeyLen)
        Me.grpCipher.Controls.Add(Me.lblKeyLen)
        Me.grpCipher.Controls.Add(Me.lblPW)
        Me.grpCipher.Controls.Add(Me.txtPW)
        Me.grpCipher.Controls.Add(Me.chkKey)
        Me.grpCipher.Controls.Add(Me.lblCN)
        Me.grpCipher.Controls.Add(Me.cmbCN)
        Me.grpCipher.Location = New System.Drawing.Point(15, 12)
        Me.grpCipher.Name = "grpCipher"
        Me.grpCipher.Size = New System.Drawing.Size(310, 251)
        Me.grpCipher.TabIndex = 0
        Me.grpCipher.TabStop = False
        Me.grpCipher.Text = "Cipher and the key"
        '
        'btnRndKey
        '
        Me.btnRndKey.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRndKey.Location = New System.Drawing.Point(229, 73)
        Me.btnRndKey.Name = "btnRndKey"
        Me.btnRndKey.Size = New System.Drawing.Size(75, 19)
        Me.btnRndKey.TabIndex = 5
        Me.btnRndKey.Text = "Randomize"
        Me.btnRndKey.UseVisualStyleBackColor = True
        Me.btnRndKey.Visible = False
        '
        'lstkey
        '
        Me.lstkey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstkey.ColumnWidth = 16
        Me.lstkey.Enabled = False
        Me.lstkey.FormattingEnabled = True
        Me.lstkey.ItemHeight = 15
        Me.lstkey.Location = New System.Drawing.Point(6, 120)
        Me.lstkey.MultiColumn = True
        Me.lstkey.Name = "lstkey"
        Me.lstkey.Size = New System.Drawing.Size(298, 120)
        Me.lstkey.TabIndex = 8
        '
        'txtKeyLen
        '
        Me.txtKeyLen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKeyLen.Enabled = False
        Me.txtKeyLen.Location = New System.Drawing.Point(146, 98)
        Me.txtKeyLen.Name = "txtKeyLen"
        Me.txtKeyLen.Size = New System.Drawing.Size(158, 16)
        Me.txtKeyLen.TabIndex = 7
        Me.txtKeyLen.Text = "1024"
        '
        'lblKeyLen
        '
        Me.lblKeyLen.AutoSize = True
        Me.lblKeyLen.Enabled = False
        Me.lblKeyLen.Location = New System.Drawing.Point(6, 99)
        Me.lblKeyLen.Name = "lblKeyLen"
        Me.lblKeyLen.Size = New System.Drawing.Size(134, 15)
        Me.lblKeyLen.TabIndex = 6
        Me.lblKeyLen.Text = "Size of the key (in Bytes)"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(6, 51)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(57, 15)
        Me.lblPW.TabIndex = 2
        Me.lblPW.Text = "Password"
        '
        'txtPW
        '
        Me.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPW.Location = New System.Drawing.Point(89, 51)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(215, 16)
        Me.txtPW.TabIndex = 3
        Me.txtPW.UseSystemPasswordChar = True
        '
        'chkKey
        '
        Me.chkKey.AutoSize = True
        Me.chkKey.Location = New System.Drawing.Point(9, 73)
        Me.chkKey.Name = "chkKey"
        Me.chkKey.Size = New System.Drawing.Size(123, 19)
        Me.chkKey.TabIndex = 4
        Me.chkKey.Text = "Use a random key."
        Me.chkKey.UseVisualStyleBackColor = True
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.Location = New System.Drawing.Point(6, 25)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(77, 15)
        Me.lblCN.TabIndex = 0
        Me.lblCN.Text = "Cipher Name"
        '
        'cmbCN
        '
        Me.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCN.FormattingEnabled = True
        Me.cmbCN.Items.AddRange(New Object() {"clandestine", "codelord"})
        Me.cmbCN.Location = New System.Drawing.Point(89, 22)
        Me.cmbCN.Name = "cmbCN"
        Me.cmbCN.Size = New System.Drawing.Size(215, 23)
        Me.cmbCN.TabIndex = 1
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Location = New System.Drawing.Point(331, 266)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(451, 49)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "E-mail : umstek@live.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Twitter : @hexmint" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Web site : http://www.umstek.co.nr"
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.btnRndData)
        Me.grpData.Controls.Add(Me.lstData)
        Me.grpData.Controls.Add(Me.lblNumBlk)
        Me.grpData.Controls.Add(Me.lblDataLen)
        Me.grpData.Controls.Add(Me.txtNumBlk)
        Me.grpData.Controls.Add(Me.txtDataLen)
        Me.grpData.Location = New System.Drawing.Point(331, 12)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(451, 251)
        Me.grpData.TabIndex = 1
        Me.grpData.TabStop = False
        Me.grpData.Text = "Data"
        '
        'btnRndData
        '
        Me.btnRndData.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRndData.Location = New System.Drawing.Point(370, 17)
        Me.btnRndData.Name = "btnRndData"
        Me.btnRndData.Size = New System.Drawing.Size(75, 19)
        Me.btnRndData.TabIndex = 3
        Me.btnRndData.Text = "Randomize"
        Me.btnRndData.UseVisualStyleBackColor = True
        '
        'lstData
        '
        Me.lstData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstData.ColumnWidth = 16
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 15
        Me.lstData.Location = New System.Drawing.Point(6, 40)
        Me.lstData.MultiColumn = True
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(439, 180)
        Me.lstData.TabIndex = 2
        '
        'lblNumBlk
        '
        Me.lblNumBlk.AutoSize = True
        Me.lblNumBlk.Location = New System.Drawing.Point(6, 229)
        Me.lblNumBlk.Name = "lblNumBlk"
        Me.lblNumBlk.Size = New System.Drawing.Size(102, 15)
        Me.lblNumBlk.TabIndex = 4
        Me.lblNumBlk.Text = "Number of blocks"
        '
        'lblDataLen
        '
        Me.lblDataLen.AutoSize = True
        Me.lblDataLen.Location = New System.Drawing.Point(6, 19)
        Me.lblDataLen.Name = "lblDataLen"
        Me.lblDataLen.Size = New System.Drawing.Size(145, 15)
        Me.lblDataLen.TabIndex = 0
        Me.lblDataLen.Text = "Size of the block (in Bytes)"
        '
        'txtNumBlk
        '
        Me.txtNumBlk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumBlk.Location = New System.Drawing.Point(171, 229)
        Me.txtNumBlk.Name = "txtNumBlk"
        Me.txtNumBlk.Size = New System.Drawing.Size(274, 16)
        Me.txtNumBlk.TabIndex = 5
        Me.txtNumBlk.Text = "10"
        '
        'txtDataLen
        '
        Me.txtDataLen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDataLen.Location = New System.Drawing.Point(171, 18)
        Me.txtDataLen.Name = "txtDataLen"
        Me.txtDataLen.Size = New System.Drawing.Size(193, 16)
        Me.txtDataLen.TabIndex = 1
        Me.txtDataLen.Text = "102400"
        '
        'grpTest
        '
        Me.grpTest.Controls.Add(Me.lblTKL)
        Me.grpTest.Controls.Add(Me.lblTDL)
        Me.grpTest.Controls.Add(Me.txtTET)
        Me.grpTest.Controls.Add(Me.txtTS)
        Me.grpTest.Controls.Add(Me.txtTST)
        Me.grpTest.Controls.Add(Me.txtTKL)
        Me.grpTest.Controls.Add(Me.txtTDL)
        Me.grpTest.Controls.Add(Me.lblTS)
        Me.grpTest.Controls.Add(Me.lblTET)
        Me.grpTest.Controls.Add(Me.lblTST)
        Me.grpTest.Controls.Add(Me.btnTCI)
        Me.grpTest.Controls.Add(Me.btnTgo)
        Me.grpTest.Location = New System.Drawing.Point(15, 269)
        Me.grpTest.Name = "grpTest"
        Me.grpTest.Size = New System.Drawing.Size(310, 141)
        Me.grpTest.TabIndex = 2
        Me.grpTest.TabStop = False
        Me.grpTest.Text = "Test"
        '
        'lblTKL
        '
        Me.lblTKL.AutoSize = True
        Me.lblTKL.Location = New System.Drawing.Point(10, 44)
        Me.lblTKL.Name = "lblTKL"
        Me.lblTKL.Size = New System.Drawing.Size(63, 15)
        Me.lblTKL.TabIndex = 2
        Me.lblTKL.Text = "Key length"
        '
        'lblTDL
        '
        Me.lblTDL.AutoSize = True
        Me.lblTDL.Location = New System.Drawing.Point(10, 22)
        Me.lblTDL.Name = "lblTDL"
        Me.lblTDL.Size = New System.Drawing.Size(68, 15)
        Me.lblTDL.TabIndex = 0
        Me.lblTDL.Text = "Data length"
        '
        'txtTET
        '
        Me.txtTET.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTET.Location = New System.Drawing.Point(89, 88)
        Me.txtTET.Name = "txtTET"
        Me.txtTET.ReadOnly = True
        Me.txtTET.Size = New System.Drawing.Size(153, 16)
        Me.txtTET.TabIndex = 7
        '
        'txtTS
        '
        Me.txtTS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTS.Location = New System.Drawing.Point(89, 116)
        Me.txtTS.Name = "txtTS"
        Me.txtTS.ReadOnly = True
        Me.txtTS.Size = New System.Drawing.Size(153, 16)
        Me.txtTS.TabIndex = 9
        '
        'txtTST
        '
        Me.txtTST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTST.Location = New System.Drawing.Point(89, 66)
        Me.txtTST.Name = "txtTST"
        Me.txtTST.ReadOnly = True
        Me.txtTST.Size = New System.Drawing.Size(153, 16)
        Me.txtTST.TabIndex = 5
        '
        'txtTKL
        '
        Me.txtTKL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTKL.Location = New System.Drawing.Point(89, 44)
        Me.txtTKL.Name = "txtTKL"
        Me.txtTKL.ReadOnly = True
        Me.txtTKL.Size = New System.Drawing.Size(153, 16)
        Me.txtTKL.TabIndex = 3
        '
        'txtTDL
        '
        Me.txtTDL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTDL.Location = New System.Drawing.Point(89, 22)
        Me.txtTDL.Name = "txtTDL"
        Me.txtTDL.ReadOnly = True
        Me.txtTDL.Size = New System.Drawing.Size(153, 16)
        Me.txtTDL.TabIndex = 1
        '
        'lblTS
        '
        Me.lblTS.AutoSize = True
        Me.lblTS.Location = New System.Drawing.Point(10, 116)
        Me.lblTS.Name = "lblTS"
        Me.lblTS.Size = New System.Drawing.Size(39, 15)
        Me.lblTS.TabIndex = 8
        Me.lblTS.Text = "Speed"
        '
        'lblTET
        '
        Me.lblTET.AutoSize = True
        Me.lblTET.Location = New System.Drawing.Point(10, 88)
        Me.lblTET.Name = "lblTET"
        Me.lblTET.Size = New System.Drawing.Size(54, 15)
        Me.lblTET.TabIndex = 6
        Me.lblTET.Text = "End time"
        '
        'lblTST
        '
        Me.lblTST.AutoSize = True
        Me.lblTST.Location = New System.Drawing.Point(10, 66)
        Me.lblTST.Name = "lblTST"
        Me.lblTST.Size = New System.Drawing.Size(58, 15)
        Me.lblTST.TabIndex = 4
        Me.lblTST.Text = "Start time"
        '
        'btnTCI
        '
        Me.btnTCI.Location = New System.Drawing.Point(248, 51)
        Me.btnTCI.Name = "btnTCI"
        Me.btnTCI.Size = New System.Drawing.Size(56, 80)
        Me.btnTCI.TabIndex = 11
        Me.btnTCI.Text = "Copy Info."
        Me.btnTCI.UseVisualStyleBackColor = True
        '
        'btnTgo
        '
        Me.btnTgo.Location = New System.Drawing.Point(248, 22)
        Me.btnTgo.Name = "btnTgo"
        Me.btnTgo.Size = New System.Drawing.Size(56, 23)
        Me.btnTgo.TabIndex = 10
        Me.btnTgo.Text = "Go"
        Me.btnTgo.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 422)
        Me.Controls.Add(Me.grpTest)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpCipher)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblDesc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benchmark Test"
        Me.grpCipher.ResumeLayout(False)
        Me.grpCipher.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpTest.ResumeLayout(False)
        Me.grpTest.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents grpCipher As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCN As System.Windows.Forms.ComboBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents chkKey As System.Windows.Forms.CheckBox
    Friend WithEvents lblCN As System.Windows.Forms.Label
    Friend WithEvents txtKeyLen As System.Windows.Forms.TextBox
    Friend WithEvents lblKeyLen As System.Windows.Forms.Label
    Friend WithEvents lstkey As System.Windows.Forms.ListBox
    Friend WithEvents grpData As System.Windows.Forms.GroupBox
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents lblDataLen As System.Windows.Forms.Label
    Friend WithEvents txtDataLen As System.Windows.Forms.TextBox
    Friend WithEvents btnRndKey As System.Windows.Forms.Button
    Friend WithEvents btnRndData As System.Windows.Forms.Button
    Friend WithEvents lblNumBlk As System.Windows.Forms.Label
    Friend WithEvents txtNumBlk As System.Windows.Forms.TextBox
    Friend WithEvents grpTest As System.Windows.Forms.GroupBox
    Friend WithEvents btnTgo As System.Windows.Forms.Button
    Friend WithEvents lblTDL As System.Windows.Forms.Label
    Friend WithEvents lblTET As System.Windows.Forms.Label
    Friend WithEvents lblTST As System.Windows.Forms.Label
    Friend WithEvents lblTKL As System.Windows.Forms.Label
    Friend WithEvents txtTET As System.Windows.Forms.TextBox
    Friend WithEvents txtTST As System.Windows.Forms.TextBox
    Friend WithEvents txtTKL As System.Windows.Forms.TextBox
    Friend WithEvents txtTDL As System.Windows.Forms.TextBox
    Friend WithEvents txtTS As System.Windows.Forms.TextBox
    Friend WithEvents lblTS As System.Windows.Forms.Label
    Friend WithEvents btnTCI As System.Windows.Forms.Button

End Class
