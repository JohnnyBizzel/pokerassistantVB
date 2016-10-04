<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.cbxBlindsLevel = New System.Windows.Forms.ComboBox()
        Me.lboxPlayers = New System.Windows.Forms.ListBox()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.cmdAddPlayer = New System.Windows.Forms.Button()
        Me.lblNumPlayers = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblErrorText = New System.Windows.Forms.Label()
        Me.cmdRemovePlayer = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.cmdStartClock = New System.Windows.Forms.Button()
        Me.NumericUpDownMins = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSmBlind = New System.Windows.Forms.Label()
        Me.txtSmBlind = New System.Windows.Forms.TextBox()
        Me.chkContinue = New System.Windows.Forms.CheckBox()
        Me.txtBigBlind = New System.Windows.Forms.TextBox()
        Me.lblBigBlind = New System.Windows.Forms.Label()
        Me.txtBuyIn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedtxtBuyIn = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrizeFund = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt1stPrize = New System.Windows.Forms.TextBox()
        Me.txt2ndPrize = New System.Windows.Forms.TextBox()
        Me.txt3rdPrize = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdCalcPrize = New System.Windows.Forms.Button()
        Me.cbxGame1First = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxSecondPrize = New System.Windows.Forms.ComboBox()
        Me.cbxThirdPrize = New System.Windows.Forms.ComboBox()
        Me.cmdGameOver = New System.Windows.Forms.Button()
        Me.cboTimeslice = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxShowBlinds = New System.Windows.Forms.CheckBox()
        CType(Me.NumericUpDownMins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxBlindsLevel
        '
        Me.cbxBlindsLevel.FormattingEnabled = True
        Me.cbxBlindsLevel.Items.AddRange(New Object() {"Slow", "Doubling", "Building"})
        Me.cbxBlindsLevel.Location = New System.Drawing.Point(37, 277)
        Me.cbxBlindsLevel.Name = "cbxBlindsLevel"
        Me.cbxBlindsLevel.Size = New System.Drawing.Size(135, 21)
        Me.cbxBlindsLevel.TabIndex = 0
        '
        'lboxPlayers
        '
        Me.lboxPlayers.FormattingEnabled = True
        Me.lboxPlayers.Location = New System.Drawing.Point(34, 87)
        Me.lboxPlayers.Name = "lboxPlayers"
        Me.lboxPlayers.Size = New System.Drawing.Size(138, 95)
        Me.lboxPlayers.TabIndex = 1
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(34, 51)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(138, 20)
        Me.txtPlayerName.TabIndex = 2
        '
        'cmdAddPlayer
        '
        Me.cmdAddPlayer.Location = New System.Drawing.Point(188, 47)
        Me.cmdAddPlayer.Name = "cmdAddPlayer"
        Me.cmdAddPlayer.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddPlayer.TabIndex = 3
        Me.cmdAddPlayer.Text = "Add player"
        Me.cmdAddPlayer.UseVisualStyleBackColor = True
        '
        'lblNumPlayers
        '
        Me.lblNumPlayers.AutoSize = True
        Me.lblNumPlayers.Location = New System.Drawing.Point(31, 198)
        Me.lblNumPlayers.Name = "lblNumPlayers"
        Me.lblNumPlayers.Size = New System.Drawing.Size(0, 13)
        Me.lblNumPlayers.TabIndex = 4
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(31, 24)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(41, 13)
        Me.lblPlayer.TabIndex = 5
        Me.lblPlayer.Text = "Players"
        '
        'lblErrorText
        '
        Me.lblErrorText.AutoSize = True
        Me.lblErrorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorText.ForeColor = System.Drawing.Color.Red
        Me.lblErrorText.Location = New System.Drawing.Point(34, 494)
        Me.lblErrorText.Name = "lblErrorText"
        Me.lblErrorText.Size = New System.Drawing.Size(155, 13)
        Me.lblErrorText.TabIndex = 6
        Me.lblErrorText.Text = "ERROR: No players found"
        '
        'cmdRemovePlayer
        '
        Me.cmdRemovePlayer.Location = New System.Drawing.Point(188, 143)
        Me.cmdRemovePlayer.Name = "cmdRemovePlayer"
        Me.cmdRemovePlayer.Size = New System.Drawing.Size(75, 38)
        Me.cmdRemovePlayer.TabIndex = 7
        Me.cmdRemovePlayer.Text = "Remove player"
        Me.cmdRemovePlayer.UseVisualStyleBackColor = True
        Me.cmdRemovePlayer.Visible = False
        '
        'Timer1
        '
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Black
        Me.lblClock.Font = New System.Drawing.Font("Trebuchet MS", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.Gold
        Me.lblClock.Location = New System.Drawing.Point(15, 18)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(0, 119)
        Me.lblClock.TabIndex = 8
        '
        'cmdStartClock
        '
        Me.cmdStartClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartClock.Location = New System.Drawing.Point(649, 47)
        Me.cmdStartClock.Name = "cmdStartClock"
        Me.cmdStartClock.Size = New System.Drawing.Size(110, 59)
        Me.cmdStartClock.TabIndex = 9
        Me.cmdStartClock.Text = "Start"
        Me.cmdStartClock.UseVisualStyleBackColor = True
        '
        'NumericUpDownMins
        '
        Me.NumericUpDownMins.Location = New System.Drawing.Point(113, 215)
        Me.NumericUpDownMins.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownMins.Name = "NumericUpDownMins"
        Me.NumericUpDownMins.Size = New System.Drawing.Size(59, 20)
        Me.NumericUpDownMins.TabIndex = 10
        Me.NumericUpDownMins.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Level minutes"
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(649, 159)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 12
        Me.cmdReset.Text = "Reset clock"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblClock)
        Me.Panel1.Location = New System.Drawing.Point(299, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 155)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Small Blind"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(494, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Big Blind"
        '
        'lblSmBlind
        '
        Me.lblSmBlind.AutoSize = True
        Me.lblSmBlind.BackColor = System.Drawing.Color.Black
        Me.lblSmBlind.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmBlind.ForeColor = System.Drawing.Color.Gold
        Me.lblSmBlind.Location = New System.Drawing.Point(303, 228)
        Me.lblSmBlind.Name = "lblSmBlind"
        Me.lblSmBlind.Size = New System.Drawing.Size(28, 32)
        Me.lblSmBlind.TabIndex = 16
        Me.lblSmBlind.Text = "\"
        '
        'txtSmBlind
        '
        Me.txtSmBlind.Location = New System.Drawing.Point(382, 193)
        Me.txtSmBlind.Multiline = True
        Me.txtSmBlind.Name = "txtSmBlind"
        Me.txtSmBlind.Size = New System.Drawing.Size(50, 172)
        Me.txtSmBlind.TabIndex = 17
        Me.txtSmBlind.Text = "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "200" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "300" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "400" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "600"
        Me.txtSmBlind.Visible = False
        '
        'chkContinue
        '
        Me.chkContinue.AutoSize = True
        Me.chkContinue.Location = New System.Drawing.Point(649, 127)
        Me.chkContinue.Name = "chkContinue"
        Me.chkContinue.Size = New System.Drawing.Size(92, 17)
        Me.chkContinue.TabIndex = 18
        Me.chkContinue.Text = "Auto continue"
        Me.chkContinue.UseVisualStyleBackColor = True
        '
        'txtBigBlind
        '
        Me.txtBigBlind.Location = New System.Drawing.Point(574, 193)
        Me.txtBigBlind.Multiline = True
        Me.txtBigBlind.Name = "txtBigBlind"
        Me.txtBigBlind.Size = New System.Drawing.Size(50, 172)
        Me.txtBigBlind.TabIndex = 19
        Me.txtBigBlind.Text = "10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "40" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "60" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "200" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "400" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "600" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "800" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1200"
        Me.txtBigBlind.Visible = False
        '
        'lblBigBlind
        '
        Me.lblBigBlind.AutoSize = True
        Me.lblBigBlind.BackColor = System.Drawing.Color.Black
        Me.lblBigBlind.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigBlind.ForeColor = System.Drawing.Color.Gold
        Me.lblBigBlind.Location = New System.Drawing.Point(494, 228)
        Me.lblBigBlind.Name = "lblBigBlind"
        Me.lblBigBlind.Size = New System.Drawing.Size(28, 32)
        Me.lblBigBlind.TabIndex = 20
        Me.lblBigBlind.Text = "\"
        '
        'txtBuyIn
        '
        Me.txtBuyIn.Enabled = False
        Me.txtBuyIn.Location = New System.Drawing.Point(37, 364)
        Me.txtBuyIn.Name = "txtBuyIn"
        Me.txtBuyIn.Size = New System.Drawing.Size(135, 20)
        Me.txtBuyIn.TabIndex = 21
        Me.txtBuyIn.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Buy In"
        '
        'MaskedtxtBuyIn
        '
        Me.MaskedtxtBuyIn.Location = New System.Drawing.Point(72, 338)
        Me.MaskedtxtBuyIn.Mask = "£000.00"
        Me.MaskedtxtBuyIn.Name = "MaskedtxtBuyIn"
        Me.MaskedtxtBuyIn.Size = New System.Drawing.Size(100, 20)
        Me.MaskedtxtBuyIn.TabIndex = 23
        Me.MaskedtxtBuyIn.Text = "  25"
        Me.MaskedtxtBuyIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrizeFund
        '
        Me.txtPrizeFund.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrizeFund.ForeColor = System.Drawing.Color.Black
        Me.txtPrizeFund.Location = New System.Drawing.Point(72, 409)
        Me.txtPrizeFund.Name = "txtPrizeFund"
        Me.txtPrizeFund.ReadOnly = True
        Me.txtPrizeFund.Size = New System.Drawing.Size(100, 20)
        Me.txtPrizeFund.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Prize Fund"
        '
        'txt1stPrize
        '
        Me.txt1stPrize.Location = New System.Drawing.Point(37, 464)
        Me.txt1stPrize.Name = "txt1stPrize"
        Me.txt1stPrize.Size = New System.Drawing.Size(35, 20)
        Me.txt1stPrize.TabIndex = 26
        '
        'txt2ndPrize
        '
        Me.txt2ndPrize.Location = New System.Drawing.Point(89, 464)
        Me.txt2ndPrize.Name = "txt2ndPrize"
        Me.txt2ndPrize.Size = New System.Drawing.Size(32, 20)
        Me.txt2ndPrize.TabIndex = 27
        '
        'txt3rdPrize
        '
        Me.txt3rdPrize.Location = New System.Drawing.Point(139, 464)
        Me.txt3rdPrize.Name = "txt3rdPrize"
        Me.txt3rdPrize.Size = New System.Drawing.Size(32, 20)
        Me.txt3rdPrize.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "1st"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "2nd"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(139, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "3rd"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 412)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "GBP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Blind structure"
        '
        'cmdCalcPrize
        '
        Me.cmdCalcPrize.Location = New System.Drawing.Point(188, 334)
        Me.cmdCalcPrize.Name = "cmdCalcPrize"
        Me.cmdCalcPrize.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalcPrize.TabIndex = 34
        Me.cmdCalcPrize.Text = "Calculate"
        Me.cmdCalcPrize.UseVisualStyleBackColor = True
        '
        'cbxGame1First
        '
        Me.cbxGame1First.FormattingEnabled = True
        Me.cbxGame1First.Location = New System.Drawing.Point(299, 371)
        Me.cbxGame1First.Name = "cbxGame1First"
        Me.cbxGame1First.Size = New System.Drawing.Size(121, 21)
        Me.cbxGame1First.TabIndex = 37
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(649, 228)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(229, 300)
        Me.RichTextBox1.TabIndex = 38
        Me.RichTextBox1.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(646, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Results"
        '
        'cbxSecondPrize
        '
        Me.cbxSecondPrize.FormattingEnabled = True
        Me.cbxSecondPrize.Location = New System.Drawing.Point(299, 399)
        Me.cbxSecondPrize.Name = "cbxSecondPrize"
        Me.cbxSecondPrize.Size = New System.Drawing.Size(121, 21)
        Me.cbxSecondPrize.TabIndex = 40
        '
        'cbxThirdPrize
        '
        Me.cbxThirdPrize.FormattingEnabled = True
        Me.cbxThirdPrize.Location = New System.Drawing.Point(299, 427)
        Me.cbxThirdPrize.Name = "cbxThirdPrize"
        Me.cbxThirdPrize.Size = New System.Drawing.Size(121, 21)
        Me.cbxThirdPrize.TabIndex = 41
        '
        'cmdGameOver
        '
        Me.cmdGameOver.Location = New System.Drawing.Point(299, 460)
        Me.cmdGameOver.Name = "cmdGameOver"
        Me.cmdGameOver.Size = New System.Drawing.Size(121, 23)
        Me.cmdGameOver.TabIndex = 42
        Me.cmdGameOver.Text = "Game Completed"
        Me.cmdGameOver.UseVisualStyleBackColor = True
        Me.cmdGameOver.Visible = False
        '
        'cboTimeslice
        '
        Me.cboTimeslice.FormattingEnabled = True
        Me.cboTimeslice.Items.AddRange(New Object() {"50", "1000"})
        Me.cboTimeslice.Location = New System.Drawing.Point(792, 46)
        Me.cboTimeslice.Name = "cboTimeslice"
        Me.cboTimeslice.Size = New System.Drawing.Size(86, 21)
        Me.cboTimeslice.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(265, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "1st"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 407)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "2nd"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(264, 434)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "3rd"
        '
        'cbxShowBlinds
        '
        Me.cbxShowBlinds.AutoSize = True
        Me.cbxShowBlinds.Location = New System.Drawing.Point(188, 279)
        Me.cbxShowBlinds.Name = "cbxShowBlinds"
        Me.cbxShowBlinds.Size = New System.Drawing.Size(80, 17)
        Me.cbxShowBlinds.TabIndex = 47
        Me.cbxShowBlinds.Text = "Show/Hide"
        Me.cbxShowBlinds.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(925, 538)
        Me.Controls.Add(Me.cbxShowBlinds)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboTimeslice)
        Me.Controls.Add(Me.cmdGameOver)
        Me.Controls.Add(Me.cbxThirdPrize)
        Me.Controls.Add(Me.cbxSecondPrize)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.cbxGame1First)
        Me.Controls.Add(Me.cmdCalcPrize)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt3rdPrize)
        Me.Controls.Add(Me.txt2ndPrize)
        Me.Controls.Add(Me.txt1stPrize)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrizeFund)
        Me.Controls.Add(Me.MaskedtxtBuyIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBuyIn)
        Me.Controls.Add(Me.lblBigBlind)
        Me.Controls.Add(Me.txtBigBlind)
        Me.Controls.Add(Me.chkContinue)
        Me.Controls.Add(Me.txtSmBlind)
        Me.Controls.Add(Me.lblSmBlind)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownMins)
        Me.Controls.Add(Me.cmdStartClock)
        Me.Controls.Add(Me.cmdRemovePlayer)
        Me.Controls.Add(Me.lblErrorText)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblNumPlayers)
        Me.Controls.Add(Me.cmdAddPlayer)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lboxPlayers)
        Me.Controls.Add(Me.cbxBlindsLevel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Poker Assistant"
        CType(Me.NumericUpDownMins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxBlindsLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lboxPlayers As System.Windows.Forms.ListBox
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddPlayer As System.Windows.Forms.Button
    Friend WithEvents lblNumPlayers As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblErrorText As System.Windows.Forms.Label
    Friend WithEvents cmdRemovePlayer As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents cmdStartClock As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownMins As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSmBlind As System.Windows.Forms.Label
    Friend WithEvents txtSmBlind As System.Windows.Forms.TextBox
    Friend WithEvents chkContinue As System.Windows.Forms.CheckBox
    Friend WithEvents txtBigBlind As System.Windows.Forms.TextBox
    Friend WithEvents lblBigBlind As System.Windows.Forms.Label
    Friend WithEvents txtBuyIn As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedtxtBuyIn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPrizeFund As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt1stPrize As System.Windows.Forms.TextBox
    Friend WithEvents txt2ndPrize As System.Windows.Forms.TextBox
    Friend WithEvents txt3rdPrize As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdCalcPrize As System.Windows.Forms.Button
    Friend WithEvents cbxGame1First As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxSecondPrize As System.Windows.Forms.ComboBox
    Friend WithEvents cbxThirdPrize As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGameOver As System.Windows.Forms.Button
    Friend WithEvents cboTimeslice As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbxShowBlinds As System.Windows.Forms.CheckBox

End Class
