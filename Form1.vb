Public Class Form1
    Dim intTurns As Integer = 0
    Dim intPoints As Integer = 0
    Dim intTeamCount1, intTeamCount2, intTeamCount3, intTeamCount4, intTeamCount5, intTeamCount6 As Integer
    Dim intCount, intX, intY, intDoubleJep(25), intDouble As Integer
    Dim intRightWrong As Integer = 4
    Dim rndGen As New Random
    Dim dblDouble As Boolean = False
    Dim strImage1 As String
#Region "Back btn Declarations"
    Dim intPlayerPoints(7)
    Dim lastBTN As New Button


#End Region


    Public Sub DisableBTN()
        For i = 1 To 5
            For j = 1 To 5
                btnGameButtons(i, j).Enabled = False
            Next
        Next
    End Sub

    Public Sub IdiotProof()
        DoubleJeoperdy()
        FinalJep()
        btnDoubleJep.Enabled = False
        For i = 1 To 5
            For j = 1 To 5
                Dim Q As Integer
                Q += 1
                If intCount = Q Then
                    btnGameButtons(i, j).Visible = False
                End If
            Next
        Next
        btnShowAnswer.Visible = True
        intTurns = intTurns + 1
    End Sub

    Public Sub Question()
        If intCount = 1 Then
            lastBTN = btn100A
            lblQuestion.Text = strTextBox(1, 1)
            intX = 1
            intY = 1
        ElseIf intCount = 2 Then
            lastBTN = btn100B
            lblQuestion.Text = strTextBox(1, 2)
            intX = 1
            intY = 2
        ElseIf intCount = 3 Then
            lastBTN = btn100C
            lblQuestion.Text = strTextBox(1, 3)
            intX = 1
            intY = 3
        ElseIf intCount = 4 Then
            lastBTN = btn100D
            lblQuestion.Text = strTextBox(1, 4)
            intX = 1
            intY = 4
        ElseIf intCount = 5 Then
            lastBTN = btn100E
            lblQuestion.Text = strTextBox(1, 5)
            intX = 1
            intY = 5
        ElseIf intCount = 6 Then
            lastBTN = btn200A
            lblQuestion.Text = strTextBox(2, 1)
            intX = 2
            intY = 1
        ElseIf intCount = 7 Then
            lastBTN = btn200B
            lblQuestion.Text = strTextBox(2, 2)
            intX = 2
            intY = 2
        ElseIf intCount = 8 Then
            lastBTN = btn200C
            lblQuestion.Text = strTextBox(2, 3)
            intX = 2
            intY = 3
        ElseIf intCount = 9 Then
            lastBTN = btn200D
            lblQuestion.Text = strTextBox(2, 4)
            intX = 2
            intY = 4
        ElseIf intCount = 10 Then
            lastBTN = btn200E
            lblQuestion.Text = strTextBox(2, 5)
            intX = 2
            intY = 5
        ElseIf intCount = 11 Then
            lastBTN = btn300A
            lblQuestion.Text = strTextBox(3, 1)
            intX = 3
            intY = 1
        ElseIf intCount = 12 Then
            lastBTN = btn300B
            lblQuestion.Text = strTextBox(3, 2)
            intX = 3
            intY = 2
        ElseIf intCount = 13 Then
            lastBTN = btn300C
            lblQuestion.Text = strTextBox(3, 3)
            intX = 3
            intY = 3
        ElseIf intCount = 14 Then
            lastBTN = btn300D
            lblQuestion.Text = strTextBox(3, 4)
            intX = 3
            intY = 4
        ElseIf intCount = 15 Then
            lastBTN = btn300E
            lblQuestion.Text = strTextBox(3, 5)
            intX = 3
            intY = 5
        ElseIf intCount = 16 Then
            lastBTN = btn400A
            lblQuestion.Text = strTextBox(4, 1)
            intX = 4
            intY = 1
        ElseIf intCount = 17 Then
            lastBTN = btn400B
            lblQuestion.Text = strTextBox(4, 2)
            intX = 4
            intY = 2
        ElseIf intCount = 18 Then
            lastBTN = btn400C
            lblQuestion.Text = strTextBox(4, 3)
            intX = 4
            intY = 3
        ElseIf intCount = 19 Then
            lastBTN = btn400D
            lblQuestion.Text = strTextBox(4, 4)
            intX = 4
            intY = 4
        ElseIf intCount = 20 Then
            lastBTN = btn400E
            lblQuestion.Text = strTextBox(4, 5)
            intX = 4
            intY = 5
        ElseIf intCount = 21 Then
            lastBTN = btn500A
            lblQuestion.Text = strTextBox(5, 1)
            intX = 5
            intY = 1
        ElseIf intCount = 22 Then
            lastBTN = btn500B
            lblQuestion.Text = strTextBox(5, 2)
            intX = 5
            intY = 2
        ElseIf intCount = 23 Then
            lastBTN = btn500C
            lblQuestion.Text = strTextBox(5, 3)
            intX = 5
            intY = 3
        ElseIf intCount = 24 Then
            lastBTN = btn500D
            lblQuestion.Text = strTextBox(5, 4)
            intX = 5
            intY = 4
        ElseIf intCount = 25 Then
            lastBTN = btn500E
            lblQuestion.Text = strTextBox(5, 5)
            intX = 5
            intY = 5
        End If
        If strTextBox(intX, intY) = "&" Then
            pbxQuestion.Visible = True
            lblQuestion.Visible = False
            strImage1 = strFilePath(intX, intY)
            pbxQuestion.Image = Image.FromFile(strFilePath(intX, intY))
        End If
        BackSetup()
    End Sub

#Region "Game Buttons"
    Public Sub btn100A_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100A.Click
        intCount = 1
        lblQuestion.Visible = True
        Question()
        intPoints = 100
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn100B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100B.Click
        intCount = 2
        lblQuestion.Visible = True
        Question()
        intPoints = 100
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn100C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100C.Click
        intCount = 3
        lblQuestion.Visible = True
        Question()
        intPoints = 100
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn100D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100D.Click
        intCount = 4
        lblQuestion.Visible = True
        Question()
        intPoints = 100
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn100E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100E.Click
        intCount = 5
        lblQuestion.Visible = True
        Question()
        intPoints = 100
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn200A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200A.Click
        intCount = 6
        lblQuestion.Visible = True
        Question()
        intPoints = 200
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn200B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200B.Click
        intCount = 7
        lblQuestion.Visible = True
        Question()
        intPoints = 200
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn200C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200C.Click
        intCount = 8
        lblQuestion.Visible = True
        Question()
        intPoints = 200
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn200D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200D.Click
        intCount = 9
        lblQuestion.Visible = True
        Question()
        intPoints = 200
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn200E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200E.Click
        intCount = 10
        lblQuestion.Visible = True
        Question()
        intPoints = 200
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn300A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn300A.Click
        intCount = 11
        lblQuestion.Visible = True
        Question()
        intPoints = 300
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn300B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn300B.Click
        intCount = 12
        lblQuestion.Visible = True
        Question()
        intPoints = 300
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn300C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn300C.Click
        intCount = 13
        lblQuestion.Visible = True
        Question()
        intPoints = 300
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn300D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn300D.Click
        intCount = 14
        lblQuestion.Visible = True
        Question()
        intPoints = 300
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn300E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn300E.Click
        intCount = 15
        lblQuestion.Visible = True
        Question()
        intPoints = 300
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn400A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn400A.Click
        intCount = 16
        lblQuestion.Visible = True
        Question()
        intPoints = 400
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn400B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn400B.Click
        intCount = 17
        lblQuestion.Visible = True
        Question()
        intPoints = 400
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn400C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn400C.Click
        intCount = 18
        lblQuestion.Visible = True
        Question()
        intPoints = 400
        DisableBTN()
        IdiotProof()
    End Sub

    Private Sub btn400D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn400D.Click
        intCount = 19
        lblQuestion.Visible = True
        Question()
        intPoints = 400
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn400E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn400E.Click
        intCount = 20
        lblQuestion.Visible = True
        Question()
        intPoints = 400
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn500A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn500A.Click
        intCount = 21
        lblQuestion.Visible = True
        Question()
        intPoints = 500
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn500B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn500B.Click
        intCount = 22
        lblQuestion.Visible = True
        Question()
        intPoints = 500
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn500C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn500C.Click
        intCount = 23
        lblQuestion.Visible = True
        Question()
        intPoints = 500
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn500D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn500D.Click
        intCount = 24
        lblQuestion.Visible = True
        Question()
        intPoints = 500
        DisableBTN()
        IdiotProof()
    End Sub
    Private Sub btn500E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn500E.Click
        intCount = 25
        lblQuestion.Visible = True
        Question()
        intPoints = 500
        DisableBTN()
        IdiotProof()
    End Sub
#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If (MessageBox.Show("Are you sure you want to exit?", "Leaving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            MessageBox.Show("Bye :'(")
            Me.Close()
        Else
            MessageBox.Show("Good Choice :)")
        End If
    End Sub

    Public Sub CheckWin()
        If btn100A.Visible = False And btn100B.Visible = False And btn100C.Visible = False And btn100D.Visible = False And btn100E.Visible = False _
        And btn200A.Visible = False And btn200B.Visible = False And btn200C.Visible = False And btn200D.Visible = False And btn200E.Visible = False _
        And btn300A.Visible = False And btn300B.Visible = False And btn300C.Visible = False And btn300D.Visible = False And btn300E.Visible = False _
        And btn400A.Visible = False And btn400B.Visible = False And btn400C.Visible = False And btn400D.Visible = False And btn400E.Visible = False _
        And btn500A.Visible = False And btn500B.Visible = False And btn500C.Visible = False And btn500D.Visible = False And btn500E.Visible = False Then
            CheckScores()
        End If
    End Sub

    Public Sub CheckScores()
        lblQuestion.Visible = True
        If intTeamCount1 > intTeamCount2 And intTeamCount1 > intTeamCount3 And intTeamCount1 > intTeamCount4 And intTeamCount1 > intTeamCount5 And intTeamCount1 > intTeamCount6 Then
            lblQuestion.Text = txtb1.Text & " WINS!!"
        ElseIf intTeamCount2 > intTeamCount1 And intTeamCount2 > intTeamCount3 And intTeamCount2 > intTeamCount4 And intTeamCount2 > intTeamCount5 And intTeamCount2 > intTeamCount6 Then
            lblQuestion.Text = txtb2.Text & " WINS!!"
        ElseIf intTeamCount3 > intTeamCount2 And intTeamCount3 > intTeamCount1 And intTeamCount3 > intTeamCount4 And intTeamCount3 > intTeamCount5 And intTeamCount3 > intTeamCount6 Then
            lblQuestion.Text = txtb3.Text & " WINS!!"
        ElseIf intTeamCount4 > intTeamCount1 And intTeamCount4 > intTeamCount2 And intTeamCount4 > intTeamCount3 And intTeamCount4 > intTeamCount5 And intTeamCount4 > intTeamCount6 Then
            lblQuestion.Text = txtb4.Text & " WINS!!"
        ElseIf intTeamCount5 > intTeamCount1 And intTeamCount5 > intTeamCount2 And intTeamCount5 > intTeamCount3 And intTeamCount5 > intTeamCount5 And intTeamCount5 > intTeamCount6 Then
            lblQuestion.Text = txtb5.Text & " WINS!!"
        ElseIf intTeamCount6 > intTeamCount1 And intTeamCount6 > intTeamCount2 And intTeamCount6 > intTeamCount3 And intTeamCount6 > intTeamCount4 And intTeamCount6 > intTeamCount5 Then
            lblQuestion.Text = txtb6.Text & " WINS!!"
        End If
    End Sub

    Public Sub TurnColor()
        If cbxTeam1.Checked = True Then
            txtb1.BackColor = Color.Blue
        ElseIf cbxTeam2.Checked = True Then
            txtb2.BackColor = Color.Blue
        ElseIf cbxTeam3.Checked = True Then
            txtb3.BackColor = Color.Blue
        ElseIf cbxTeam4.Checked = True Then
            txtb4.BackColor = Color.Blue
        ElseIf cbxTeam5.Checked = True Then
            txtb5.BackColor = Color.Blue
        ElseIf cbxTeam6.Checked = True Then
            txtb6.BackColor = Color.Blue
        End If
    End Sub

    Public Sub DoubleJeoperdy()
        If intCount = intDouble Then
            MessageBox.Show("Double Jeoperdy!!")
            dblDouble = True
        End If
        DJPoints()
    End Sub

    Public Sub DJPoints()
        If dblDouble = True Then
            intPoints = intPoints * 2
        End If
    End Sub

    Public Sub DJPoints2()
        dblDouble = False
    End Sub

    Public Sub FinalJep()
        If intTurns = 24 Then
            intPoints = InputBox("How much would you like to wager?")
            intPoints = intPoints * 2
        End If
    End Sub
    Dim t As Integer = 0
    Dim x As Integer = 1
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        For i = 0 To 5
            For j = 0 To 5
                If strFilePath(i, j) <> "" Then
                    btnGameButtons(i, j).PerformClick()
                    Exit For
                End If
            Next
        Next

        t = t + 1
        If t = 2 Then
            btnShowAnswer.PerformClick()
            btnDone.PerformClick()
            Reset()
            t = 0
        End If
    End Sub
    Public Sub Reset()
        Timer1.Enabled = False
        lblA.Text = strColumns(1)
        lblB.Text = strColumns(2)
        lblC.Text = strColumns(3)
        lblD.Text = strColumns(4)
        lblE.Text = strColumns(5)
        lblQuestion.Visible = False
        pbxQuestion.Visible = False
        btnShowAnswer.Visible = False
        lblQuestion.Text = "?"
        txtb1.BackColor = Color.Firebrick
        txtb2.BackColor = Color.Firebrick
        txtb3.BackColor = Color.Firebrick
        txtb4.BackColor = Color.Firebrick
        lblTeamCount1.Text = "000"
        lblTeamCount2.Text = "000"
        lblTeamCount3.Text = "000"
        lblTeamCount4.Text = "000"
        intTurns = 0
        intPoints = 0
        intTeamCount1 = 0
        intTeamCount2 = 0
        intTeamCount3 = 0
        intTeamCount4 = 0
        btn100A.Visible = True
        btn100B.Visible = True
        btn100C.Visible = True
        btn100D.Visible = True
        btn100E.Visible = True
        btn200A.Visible = True
        btn200B.Visible = True
        btn200C.Visible = True
        btn200D.Visible = True
        btn200E.Visible = True
        btn300A.Visible = True
        btn300B.Visible = True
        btn300C.Visible = True
        btn300D.Visible = True
        btn300E.Visible = True
        btn400A.Visible = True
        btn400B.Visible = True
        btn400C.Visible = True
        btn400D.Visible = True
        btn400E.Visible = True
        btn500A.Visible = True
        btn500B.Visible = True
        btn500C.Visible = True
        btn500D.Visible = True
        btn500E.Visible = True
        btn100A.Enabled = True
        btn100B.Enabled = True
        btn100C.Enabled = True
        btn100D.Enabled = True
        btn100E.Enabled = True
        btn200A.Enabled = True
        btn200B.Enabled = True
        btn200C.Enabled = True
        btn200D.Enabled = True
        btn200E.Enabled = True
        btn300A.Enabled = True
        btn300B.Enabled = True
        btn300C.Enabled = True
        btn300D.Enabled = True
        btn300E.Enabled = True
        btn400A.Enabled = True
        btn400B.Enabled = True
        btn400C.Enabled = True
        btn400D.Enabled = True
        btn400C.Enabled = True
        btn400D.Enabled = True
        btn400E.Enabled = True
        btn500A.Enabled = True
        btn500B.Enabled = True
        btn500C.Enabled = True
        btn500D.Enabled = True
        btn500E.Enabled = True
        btnDoubleJep.Enabled = True
        btnT1R.Visible = False
        btnT2R.Visible = False
        btnT3R.Visible = False
        btnT4R.Visible = False
        btnT5R.Visible = False
        btnT6R.Visible = False
        btnT1W.Visible = False
        btnT2W.Visible = False
        btnT3W.Visible = False
        btnT4W.Visible = False
        btnT5W.Visible = False
        btnT6W.Visible = False
        btnDone.Visible = False
        Timer1.Enabled = False
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnMakeOwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeOwn.Click
        Dim Costomize As New Costomize
        Costomize.Show()
    End Sub

    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        Try
            Dim strNextName As String
            OpenFileDialog1.Filter = "Jep Game files (*.jepdy)|*.jepdy"
            OpenFileDialog1.ShowDialog()

            Dim textFile As New System.IO.StreamReader(OpenFileDialog1.FileName)
            Dim intCount As Integer

            strNextName = textFile.ReadLine
            intCount = 0

            Do While strNextName <> Nothing
                intCount += 1
                Dim i, j As Integer
                For i = 1 To 5
                    For j = 1 To 5
                        strTextBox(i, j) = strNextName
                        strNextName = textFile.ReadLine
                    Next
                Next
                strNextName = textFile.ReadLine
                For i = 1 To 5
                    strColumns(i) = strNextName
                    strNextName = textFile.ReadLine
                Next
                For i = 1 To 5
                    For j = 1 To 5
                        strAnswer(i, j) = strNextName
                        strNextName = textFile.ReadLine
                    Next
                Next
                'strNextName = textFile.ReadLine
                For i = 1 To 5
                    For j = 1 To 5
                        strFilePath(i, j) = strNextName
                        strNextName = textFile.ReadLine
                    Next
                Next
                For i = 1 To 5
                    For j = 1 To 5
                        strAFilePath(i, j) = strNextName
                        strNextName = textFile.ReadLine
                    Next
                Next
            Loop
            lblA.Text = strColumns(1)
            lblB.Text = strColumns(2)
            lblC.Text = strColumns(3)
            lblD.Text = strColumns(4)
            lblE.Text = strColumns(5)
        Catch
            MessageBox.Show("There was an error opening your file.")
        End Try
    End Sub

    Private Sub btnShowAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswer.Click
        lblQuestion.Text = strAnswer(intX, intY)
        pbxQuestion.ImageLocation = strAFilePath(intX, intY)
        btnShowAnswer.Visible = False
        btnT1R.Visible = True
        btnT2R.Visible = True
        btnT3R.Visible = True
        btnT4R.Visible = True
        btnT5R.Visible = True
        btnT6R.Visible = True
        btnT1W.Visible = True
        btnT2W.Visible = True
        btnT3W.Visible = True
        btnT4W.Visible = True
        btnT5W.Visible = True
        btnT6W.Visible = True
        btnDone.Visible = True
        If strAnswer(intX, intY) = "&" Then
            pbxQuestion.Visible = True
            lblQuestion.Visible = False
            pbxQuestion.ImageLocation = strAFilePath(intX, intY)
        ElseIf strAnswer(intX, intY) <> "&" Then
            lblQuestion.Visible = True
            pbxQuestion.Visible = False
        End If
    End Sub

    Private Sub btnSHowWinner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowWinner.Click
        CheckWin()
        btnShowWinner.Visible = False
    End Sub

    Private Sub btnDoubleJep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoubleJep.Click
        If btnDoubleJep.Text = "Double Jeoperdy(off)" Then
            btnDoubleJep.Text = "Double Jeoperdy(on)"
            intDouble = rndGen.Next(1, 25)
        ElseIf btnDoubleJep.Text = "Double Jeoperdy(on)" Then
            btnDoubleJep.Text = "Double Jeoperdy(off)"
            intDouble = 0
        End If
    End Sub

#Region "UpDown"
    Private Sub btnUp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp1.Click
        intTeamCount1 += 50
        lblTeamCount1.Text = intTeamCount1
    End Sub

    Private Sub btnDown1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown1.Click
        intTeamCount1 -= 50
        lblTeamCount1.Text = intTeamCount1
    End Sub

    Private Sub btnUp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp2.Click
        intTeamCount2 += 50
        lblTeamCount2.Text = intTeamCount2
    End Sub

    Private Sub btnDown2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown2.Click
        intTeamCount2 -= 50
        lblTeamCount2.Text = intTeamCount2
    End Sub

    Private Sub btnUp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp3.Click
        intTeamCount3 += 50
        lblTeamCount3.Text = intTeamCount3
    End Sub

    Private Sub btnDown3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown3.Click
        intTeamCount3 -= 50
        lblTeamCount3.Text = intTeamCount3
    End Sub

    Private Sub btnUp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp4.Click
        intTeamCount4 += 50
        lblTeamCount4.Text = intTeamCount4
    End Sub

    Private Sub btnDown4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown4.Click
        intTeamCount4 -= 50
        lblTeamCount4.Text = intTeamCount4
    End Sub

    Private Sub btnUp5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp5.Click
        intTeamCount5 += 50
        lblTeamCount5.Text = intTeamCount5
    End Sub

    Private Sub btnDown5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown5.Click
        intTeamCount5 -= 50
        lblTeamCount5.Text = intTeamCount5
    End Sub

    Private Sub btnUp6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp6.Click
        intTeamCount6 += 50
        lblTeamCount6.Text = intTeamCount6
    End Sub

    Private Sub btnDown6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown6.Click
        intTeamCount6 -= 50
        lblTeamCount6.Text = intTeamCount6
    End Sub
#End Region

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBox2.Show()
    End Sub

#Region "NameBTN"
    Private Sub btnNameTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName1.Click
        If txtb1.Enabled = False Then
            txtb1.Enabled = True
        ElseIf txtb1.Enabled = True Then
            txtb1.Enabled = False
        End If
    End Sub
    Private Sub btnName2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName2.Click
        If txtb2.Enabled = False Then
            txtb2.Enabled = True
        ElseIf txtb2.Enabled = True Then
            txtb2.Enabled = False
        End If
    End Sub
    Private Sub btnName3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName3.Click
        If txtb3.Enabled = False Then
            txtb3.Enabled = True
        ElseIf txtb3.Enabled = True Then
            txtb3.Enabled = False
        End If
    End Sub
    Private Sub btnName4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName4.Click
        If txtb4.Enabled = False Then
            txtb4.Enabled = True
        ElseIf txtb4.Enabled = True Then
            txtb4.Enabled = False
        End If
    End Sub
    Private Sub btnName5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName5.Click
        If txtb5.Enabled = False Then
            txtb5.Enabled = True
        ElseIf txtb5.Enabled = True Then
            txtb5.Enabled = False
        End If
    End Sub
    Private Sub btnName6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName6.Click
        If txtb6.Enabled = False Then
            txtb6.Enabled = True
        ElseIf txtb6.Enabled = True Then
            txtb6.Enabled = False
        End If
    End Sub

    Private Sub txtb1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtb1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtb1.Enabled = False
        End If
    End Sub
    Private Sub txtb2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtb2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtb2.Enabled = False
        End If
    End Sub
    Private Sub txtb3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtb3.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtb3.Enabled = False
        End If
    End Sub
    Private Sub txtb4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtb4.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtb4.Enabled = False
        End If
    End Sub
    Private Sub txtb5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtb5.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtb5.Enabled = False
        End If
    End Sub
    Private Sub txtb6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtb6.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtb6.Enabled = False
        End If
    End Sub
#End Region
    Public Sub RightWrong()
        btn100A.Enabled = True
        btn100B.Enabled = True
        btn100C.Enabled = True
        btn100D.Enabled = True
        btn100E.Enabled = True
        btn200A.Enabled = True
        btn200B.Enabled = True
        btn200C.Enabled = True
        btn200D.Enabled = True
        btn200E.Enabled = True
        btn300A.Enabled = True
        btn300B.Enabled = True
        btn300C.Enabled = True
        btn300D.Enabled = True
        btn300E.Enabled = True
        btn400A.Enabled = True
        btn400B.Enabled = True
        btn400C.Enabled = True
        btn400D.Enabled = True
        btn400C.Enabled = True
        btn400D.Enabled = True
        btn400E.Enabled = True
        btn500A.Enabled = True
        btn500B.Enabled = True
        btn500C.Enabled = True
        btn500D.Enabled = True
        btn500E.Enabled = True
        txtb1.BackColor = Color.Firebrick
        txtb2.BackColor = Color.Firebrick
        txtb3.BackColor = Color.Firebrick
        txtb4.BackColor = Color.Firebrick
        txtb5.BackColor = Color.Firebrick
        txtb6.BackColor = Color.Firebrick
        CheckWin()
        TurnColor()
        lblQuestion.Visible = False
        pbxQuestion.Visible = False
        btnT1R.Visible = False
        btnT2R.Visible = False
        btnT3R.Visible = False
        btnT4R.Visible = False
        btnT5R.Visible = False
        btnT6R.Visible = False
        btnT1W.Visible = False
        btnT2W.Visible = False
        btnT3W.Visible = False
        btnT4W.Visible = False
        btnT5W.Visible = False
        btnT6W.Visible = False
        btnShowAnswer.Visible = False
        DJPoints2()
        If intTurns = 25 Then
            btnShowWinner.Visible = True
        End If
    End Sub
#Region "RightWrongBTN"
    Private Sub btnT1R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT1R.Click
        intTeamCount1 = intTeamCount1 + intPoints
        lblTeamCount1.Text = CInt(intTeamCount1.ToString)
    End Sub

    Private Sub btnT1W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT1W.Click
        If dblDouble = True Then
            intTeamCount1 = intTeamCount1 - intPoints
        ElseIf intTurns <> 25 Then
            intTeamCount1 = intTeamCount1 - 50
        Else
            intTeamCount1 = intTeamCount1 - intPoints
        End If
        lblTeamCount1.Text = CInt(intTeamCount1.ToString)
    End Sub

    Private Sub btnT2R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT2R.Click
        intTeamCount2 = intTeamCount2 + intPoints
        lblTeamCount2.Text = CInt(intTeamCount2.ToString)
    End Sub

    Private Sub btnT2W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT2W.Click
        If dblDouble = True Then
            intTeamCount2 = intTeamCount2 - intPoints
        ElseIf intTurns <> 25 Then
            intTeamCount2 = intTeamCount2 - 50
        Else
            intTeamCount2 = intTeamCount2 - intPoints
        End If
        lblTeamCount2.Text = CInt(intTeamCount2.ToString)
    End Sub

    Private Sub btnT3R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT3R.Click
        intTeamCount3 = intTeamCount3 + intPoints
        lblTeamCount3.Text = CInt(intTeamCount3.ToString)
    End Sub

    Private Sub btnT3W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT3W.Click
        If dblDouble = True Then
            intTeamCount3 = intTeamCount3 - intPoints
        ElseIf intTurns <> 25 Then
            intTeamCount3 = intTeamCount3 - 50
        Else
            intTeamCount3 = intTeamCount3 - intPoints
        End If
        lblTeamCount3.Text = CInt(intTeamCount3.ToString)
    End Sub

    Private Sub btnT4R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT4R.Click
        intTeamCount4 = intTeamCount4 + intPoints
        lblTeamCount4.Text = CInt(intTeamCount4.ToString)
    End Sub

    Private Sub btnT4W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT4W.Click
        If dblDouble = True Then
            intTeamCount4 = intTeamCount4 - intPoints
        ElseIf intTurns <> 25 Then
            intTeamCount4 = intTeamCount4 - 50
        Else
            intTeamCount4 = intTeamCount4 - intPoints
        End If
        lblTeamCount4.Text = CInt(intTeamCount4.ToString)
    End Sub

    Private Sub btnT5R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT5R.Click
        intTeamCount5 = intTeamCount5 + intPoints
        lblTeamCount5.Text = CInt(intTeamCount5.ToString)
    End Sub

    Private Sub btnT5W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT5W.Click
        If dblDouble = True Then
            intTeamCount5 = intTeamCount5 - intPoints
        ElseIf intTurns <> 25 Then
            intTeamCount5 = intTeamCount5 - 50
        Else
            intTeamCount5 = intTeamCount5 - intPoints
        End If
        lblTeamCount5.Text = CInt(intTeamCount5.ToString)
    End Sub

    Private Sub btnT6R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT6R.Click
        intTeamCount6 = intTeamCount6 + intPoints
        lblTeamCount6.Text = CInt(intTeamCount6.ToString)
    End Sub

    Private Sub btnT6W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT6W.Click
        If dblDouble = True Then
            intTeamCount6 = intTeamCount6 - intPoints
        ElseIf intTurns <> 25 Then
            intTeamCount6 = intTeamCount6 - 50
        Else
            intTeamCount6 = intTeamCount6 - intPoints
        End If
        lblTeamCount6.Text = CInt(intTeamCount6.ToString)
    End Sub
#End Region

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        RightWrong()
        btnDone.Visible = False
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Me.GroupBox1.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GameButtons()
    End Sub
    Public Sub BackSetup()
        intPlayerPoints(1) = intTeamCount1
        intPlayerPoints(2) = intTeamCount2
        intPlayerPoints(3) = intTeamCount3
        intPlayerPoints(4) = intTeamCount4
        intPlayerPoints(5) = intTeamCount5
        intPlayerPoints(6) = intTeamCount6
    End Sub
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        lastBTN.Visible = True
        lastBTN.Enabled = True
        intTeamCount1 = intPlayerPoints(1)
        intTeamCount2 = intPlayerPoints(2)
        intTeamCount3 = intPlayerPoints(3)
        intTeamCount4 = intPlayerPoints(4)
        intTeamCount5 = intPlayerPoints(5)
        intTeamCount6 = intPlayerPoints(6)
        RightWrong()
        lblTeamCount1.Text = CInt(intTeamCount1.ToString)
        lblTeamCount2.Text = CInt(intTeamCount2.ToString)
        lblTeamCount3.Text = CInt(intTeamCount3.ToString)
        lblTeamCount4.Text = CInt(intTeamCount4.ToString)
        lblTeamCount5.Text = CInt(intTeamCount5.ToString)
        lblTeamCount6.Text = CInt(intTeamCount6.ToString)
        btnDone.Visible = False
        intTurns -= 1
    End Sub

    Private Sub cbxLabelBGColor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxLabelBGColor.CheckedChanged
        If lblQuestion.BackColor = Color.White Then
            lblQuestion.BackColor = Color.Black
        ElseIf lblQuestion.BackColor = Color.Black Then
            lblQuestion.BackColor = Color.White
        End If
    End Sub
End Class