
Public Class Form1

    'Private Shared cmdClockControl As New System.Windows.Forms.Button()
    ' Private Shared alertTimer As New System.Windows.Forms.Timer()
    Private Shared alarmCounter As Integer = 1

    '    Private Shared exitFlag As Boolean = False
    Dim myTimeSecs, myTimeMins As Integer
    Private Shared prizefund As Double
    Private Shared firstprize As Double
    Private Shared secondprize As Double
    Private Shared thirdprize As Double

    Private blindsDT As New DataTable
    Private playersCollection As New List(Of ds.players)


    Private Sub AddPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddPlayer.Click
        txtPlayerName.Focus()
        txtPlayerName.SelectAll()
        If txtPlayerName.Text = String.Empty Then
            lblErrorText.Text = "ERROR: No name specified"
            Exit Sub
        End If

        For Each item As Object In lboxPlayers.Items
            If item.ToString = txtPlayerName.Text Then
                lblErrorText.Text = "ERROR: Player already in list"
                Exit Sub
            End If
        Next
        Dim newPlayer As String
        newPlayer = txtPlayerName.Text

        lboxPlayers.Items.Add(newPlayer)
        lblNumPlayers.Text = lboxPlayers.Items.Count.ToString

        cbxGame1First.Items.Add(newPlayer)
        cbxSecondPrize.Items.Add(newPlayer)
        cbxThirdPrize.Items.Add(newPlayer)

        cmdRemovePlayer.Visible = True
        lblErrorText.Text = ""

        ' create an object
        Dim newPlayerObj As New ds.players(newPlayer, 0.0)
        ' add to global collection
        playersCollection.Add(newPlayerObj)
    End Sub

    Private Sub lboxPlayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxPlayers.SelectedIndexChanged
        txtPlayerName.Text = lboxPlayers.SelectedItem
    End Sub

    Private Sub cmdRemovePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemovePlayer.Click
        Dim tempArray As New ArrayList
        For Each item As Object In lboxPlayers.Items
            If item.ToString <> txtPlayerName.Text Then
                tempArray.Add(item)
            End If
        Next
        lboxPlayers.Items.Clear()
        cbxGame1First.Items.Clear()
        cbxSecondPrize.Items.Clear()
        cbxThirdPrize.Items.Clear()
        For Each element As Object In tempArray
            lboxPlayers.Items.Add(element)
            cbxGame1First.Items.Add(element)
            cbxSecondPrize.Items.Add(element)
            cbxThirdPrize.Items.Add(element)
        Next
        lblNumPlayers.Text = lboxPlayers.Items.Count.ToString

        Dim playerToRemove As New ds.players
        For Each p As ds.players In playersCollection
            If p.PlayerName = txtPlayerName.Text Then
                playerToRemove.PlayerName = txtPlayerName.Text
            End If
        Next
        playersCollection.Remove(playerToRemove)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim currentTime As String

        If myTimeMins <= 0 And myTimeSecs = 0 Then
            If chkContinue.CheckState = CheckState.Checked Then
                myTimeSecs = 0
                myTimeMins = NumericUpDownMins.Value
                alarmCounter += 1
                ' Todo: monitor for end of array
                If alarmCounter < txtSmBlind.Lines.Count Then
                    lblSmBlind.Text = txtSmBlind.Lines(alarmCounter - 1)
                    lblBigBlind.Text = txtBigBlind.Lines(alarmCounter - 1)
                Else
                    ContinueGame()
                End If

            Else
                Timer1.Stop()
                If alarmCounter < txtSmBlind.Lines.Count Then
                    ' Raise the blinds and reset clock
                    BlindIncreaseWarning()
                Else
                    ContinueGame()
                    cmdStartClock.Text = "Start"
                End If
                Exit Sub
            End If

        End If
        If myTimeSecs <= 0 Then
            myTimeMins -= 1
            myTimeSecs = 60
        End If
        myTimeSecs -= 1
        Dim minsformatted As String = IIf(myTimeMins < 10, " " & myTimeMins, myTimeMins)
        currentTime = minsformatted & ":" & IIf(myTimeSecs < 10, "0" & myTimeSecs, myTimeSecs)

        lblClock.Text = currentTime
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set up datatable

        'blindsDT.Columns.Add("Level", System.Type.GetType("Integer"))
        'blindsDT.Columns.Add("SmallBlind", System.Type.GetType("Integer"))
        'blindsDT.Columns.Add("BigBlind", System.Type.GetType("Integer"))

        lblClock.Text = NumericUpDownMins.Value & ":00"
        checkMinsLessThan10()

        lblSmBlind.Text = txtSmBlind.Lines(alarmCounter - 1)
        lblBigBlind.Text = txtBigBlind.Lines(alarmCounter - 1)

    End Sub

    Private Sub cmdStartClock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartClock.Click
        If txtPrizeFund.Text = "" Then
            lblErrorText.Text = "NO PRIZE FUND"
            Exit Sub
        Else
            lblErrorText.Text = ""
        End If

        'Dim DScurrentplayers As New ds.players

        'DScurrentplayers.PlayerName.Add("Test")


        'DataGridView1.DataSource = DScurrentplayers


        If cmdStartClock.Text = "Start" Then
           
            cmdStartClock.Text = "Pause"
            ' Start at 0 seconds
            myTimeSecs = 0
            myTimeMins = NumericUpDownMins.Value
            Timer1.Enabled = True
            If cboTimeslice.SelectedIndex = -1 Then
                Timer1.Interval = 100
            Else
                Timer1.Interval = CInt(cboTimeslice.SelectedItem)
            End If

        ElseIf cmdStartClock.Text = "Pause" Then
            Timer1.Enabled = False
            cmdStartClock.Text = "Resume"
        ElseIf cmdStartClock.Text = "Resume" Then
            Timer1.Enabled = True
            cmdStartClock.Text = "Pause"
        End If


    End Sub
    Private Sub ContinueGame()
        MessageBox.Show("Playing on - blinds will double")
        Dim sb, bb As Integer
        sb = CInt(lblSmBlind.Text)
        bb = CInt(lblBigBlind.Text)
        lblSmBlind.Text = sb * 2
        lblBigBlind.Text = bb * 2


    End Sub
    Private Sub BlindIncreaseWarning()
        If MessageBox.Show("Blinds increasing to" & " " & _
                                   txtSmBlind.Lines(alarmCounter) & ", " & txtBigBlind.Lines(alarmCounter), _
                                           "Level is: " & alarmCounter, _
                                            MessageBoxButtons.OK) = DialogResult.OK Then
            ' Restarts the timer and increments the counter.
            ' Counter acts as level indicator
            alarmCounter += 1
            lblSmBlind.Text = txtSmBlind.Lines(alarmCounter - 1)
            lblBigBlind.Text = txtBigBlind.Lines(alarmCounter - 1)

            cmdStartClock.Text = "Start"
        End If

    End Sub


    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        myTimeMins = NumericUpDownMins.Value
        myTimeSecs = 0
        lblClock.Text = NumericUpDownMins.Value & ":00"
        cmdStartClock.Text = "Start"
        checkMinsLessThan10()
    End Sub

    Private Sub checkMinsLessThan10()

        If NumericUpDownMins.Value < 10 Then
            If InStr(lblClock.Text, " ") = 1 Then

                Exit Sub
            End If
            lblClock.Text = " " & lblClock.Text

        End If

    End Sub


    Private Sub NumericUpDownMins_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownMins.ValueChanged

        lblClock.Text = NumericUpDownMins.Value & ":00"
        checkMinsLessThan10()
    End Sub

    Private Sub MaskedtxtBuyIn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedtxtBuyIn.Leave
        txtBuyIn.Text = MaskedtxtBuyIn.Text
        ' convert the string to a double precision number format
        Dim buyintxt() As Char
        Dim point As Boolean = False
        buyintxt = txtBuyIn.Text
        If buyintxt(UBound(buyintxt)) = "." Then
            buyintxt &= "0"c
            buyintxt &= "0"c
        End If
        For Each c As Char In buyintxt
            If c = "." Then
                point = True
            End If
            If c = " " And point = True Then
                c = "0"c
            End If
        Next
        txtBuyIn.Text = buyintxt

        Dim buyin, players As Double
        Try
            buyin = CDbl(txtBuyIn.Text)
            lblErrorText.Text = ""
        Catch ex As Exception
            lblErrorText.Text = ex.Message
        End Try
        Try
            players = CDbl(lblNumPlayers.Text)
            lblErrorText.Text = ""
        Catch ex As Exception
            lblErrorText.Text = "ERROR: No players found"
        End Try
        Dim prizefund As Double = buyin * players
        txtPrizeFund.Text = String.Format("{0:c}", prizefund)
        PrizeCalculating()
    End Sub

    Private Sub MaskedtxtBuyIn_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedtxtBuyIn.MaskInputRejected
        lblErrorText.Text = "ERROR: Buy in amount invalid"
    End Sub

    Private Sub cbxBlindsLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxBlindsLevel.SelectedIndexChanged

        txtSmBlind.Text = ""
        txtBigBlind.Text = ""

        If cbxBlindsLevel.SelectedIndex = 0 Then

            Dim sblinds() As Integer = {1, 2, 5, 10, 20, 30, 50, 100, 200, 300, 400, 600, 800}
            Dim bblinds() As Integer = {2, 5, 10, 20, 30, 50, 100, 200, 400, 600, 800, 1200, 1600}

            For i = 0 To UBound(sblinds) - 1
                txtSmBlind.AppendText(sblinds(i) & Environment.NewLine)
                txtBigBlind.AppendText(bblinds(i) & Environment.NewLine)
            Next
            lblSmBlind.Text = sblinds(0)
            lblBigBlind.Text = bblinds(0)
        End If

        If cbxBlindsLevel.SelectedIndex = 1 Then

            Dim sblinds() As Integer = {5, 10, 25, 50, 100, 200, 400, 800, 1600, 3200}
            Dim bblinds() As Integer = {10, 20, 50, 100, 200, 400, 800, 1600, 3200, 6400}

            For i = 0 To UBound(sblinds) - 1
                txtSmBlind.AppendText(sblinds(i) & Environment.NewLine)
                txtBigBlind.AppendText(bblinds(i) & Environment.NewLine)

            Next
            lblSmBlind.Text = sblinds(0)
            lblBigBlind.Text = bblinds(0)
        End If
        If cbxBlindsLevel.SelectedIndex = 2 Then

            Dim sblinds() As Integer = {1, 2, 3, 5, 10, 25, 50, 100, 250, 500, 750, 1000}
            Dim bblinds() As Integer = {1, 4, 6, 10, 20, 50, 100, 200, 500, 1000, 1500, 2000}

            For i = 0 To UBound(sblinds) - 1
                txtSmBlind.AppendText(sblinds(i) & Environment.NewLine)
                txtBigBlind.AppendText(bblinds(i) & Environment.NewLine)

            Next
            lblSmBlind.Text = sblinds(0)
            lblBigBlind.Text = bblinds(0)
        End If
        txtBigBlind.Visible = True
        txtSmBlind.Visible = True
        cbxShowBlinds.CheckState = CheckState.Checked
    End Sub

    Private Sub PrizeCalculating()

        Try
            prizefund = CDbl(txtPrizeFund.Text)
        Catch ex As Exception
            Exit Sub
        End Try
        Dim numOfPlayers As Integer
        Try
            numOfPlayers = CInt(lblNumPlayers.Text)
        Catch ex As Exception
            Exit Sub
        End Try
        If numOfPlayers < 6 Then
            firstprize = prizefund * 0.6
            secondprize = prizefund * 0.4
            thirdprize = 0
        ElseIf numOfPlayers >= 6 And numOfPlayers < 11 Then
            firstprize = prizefund * 0.5
            secondprize = prizefund * 0.3
            thirdprize = prizefund * 0.2
        Else
            ' forth prize!?

        End If
        txt1stPrize.Text = firstprize
        txt2ndPrize.Text = secondprize
        txt3rdPrize.Text = thirdprize
    End Sub

    Private Sub cmdCalcPrize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalcPrize.Click
        MaskedtxtBuyIn_Leave(sender, e)
    End Sub

    Private Sub cbxGame1First_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxGame1First.SelectedIndexChanged

        CheckGameOver()

    End Sub

    Private Sub cbxSecondPrize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxSecondPrize.SelectedIndexChanged
        CheckGameOver()
    End Sub

    Private Sub cbxThirdPrize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxThirdPrize.SelectedIndexChanged
        CheckGameOver()

    End Sub
    Private Sub CheckGameOver()
        If cbxGame1First.SelectedItem <> "" And cbxSecondPrize.SelectedItem <> "" And cbxThirdPrize.SelectedItem <> "" Then
            cmdGameOver.Visible = True
        Else
            cmdGameOver.Visible = False
        End If
    End Sub

    Dim gameNo As Integer = 1

    Private Sub cmdGameOver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGameOver.Click
        RichTextBox1.SelectionFont = New Font("Lucida Sans", 10, FontStyle.Bold)


        RichTextBox1.Text &= "Resulting balance after game " & gameNo & ": " & Environment.NewLine
        RichTextBox1.SelectionFont = New Font("Lucida Sans", 10, FontStyle.Regular)

        For Each player As ds.players In playersCollection
            If cbxGame1First.SelectedItem = player.PlayerName Then
                player.Balance += CDbl(txt1stPrize.Text)
            End If
            If cbxSecondPrize.SelectedItem = player.PlayerName Then
                player.Balance += CDbl(txt2ndPrize.Text)
            End If
            If cbxThirdPrize.SelectedItem = player.PlayerName Then
                player.Balance += CDbl(txt3rdPrize.Text)
            End If
            If cbxGame1First.FindString(player.PlayerName) > -1 Then
                player.Balance -= CDbl(txtBuyIn.Text)
            End If

            If player.Balance < 0 Then
                ' Red balance (doesn't do anything)
                RichTextBox1.Text &= player.PlayerName & " "
                RichTextBox1.SelectionColor = Color.Red
                RichTextBox1.Text &= player.Balance
                RichTextBox1.SelectionColor = Color.Black
                RichTextBox1.Text &= Environment.NewLine
            Else
                ' in the black
                RichTextBox1.Text &= player.PlayerName & " " & player.Balance & Environment.NewLine
            End If
        
        Next

        ' Reset controls
        cmdGameOver.Visible = False
        cbxGame1First.SelectedIndex = -1
        cbxSecondPrize.SelectedIndex = -1
        cbxThirdPrize.SelectedIndex = -1
        cmdReset_Click(sender, e)
        alarmCounter = 1
        gameNo += 1
        lblSmBlind.Text = txtSmBlind.Lines(0)
        lblBigBlind.Text = txtBigBlind.Lines(0)

    End Sub

    Private Sub cbxShowBlinds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxShowBlinds.CheckedChanged
        If cbxShowBlinds.Checked Then
            txtSmBlind.Visible = True
            txtBigBlind.Visible = True
        Else
            txtSmBlind.Visible = False
            txtBigBlind.Visible = False
        End If

    End Sub
End Class

Namespace ds
    Class players
        Private _playerName As String
        Private _balance As Double
        Public Property PlayerName() As String
            Get

                Return _playerName
            End Get
            Set(ByVal Value As String)
                _playerName = Value
            End Set
        End Property

        Public Property Balance() As Double
            Get

                Return _balance
            End Get
            Set(ByVal Value As Double)
                _balance = Value
            End Set
        End Property
        Public Sub New()

        End Sub
        Public Sub New(ByVal player As String, ByVal balance As Double)
            _playerName = player


        End Sub
    End Class
End Namespace
