Public Class Form1
    Dim intTurns As Integer = 0
    Dim intPoints As Integer = 0
    Dim intTeamCount1, intTeamCount2, intTeamCount3, intTeamCount4, intTeamCount5, intTeamCount6 As Integer
    Dim intCount, intX, intY, intDoubleJep(25), intDouble As Integer
    Dim intRightWrong As Integer = 4
    Dim rndGen As New Random
    Dim dblDouble As Boolean = False
    Dim bolName As Boolean = False

    Public Sub DisableBTN()
        btn100A.Enabled = False
        btn100B.Enabled = False
        btn100C.Enabled = False
        btn100D.Enabled = False
        btn100E.Enabled = False
        btn200A.Enabled = False
        btn200B.Enabled = False
        btn200C.Enabled = False
        btn200D.Enabled = False
        btn200E.Enabled = False
        btn300A.Enabled = False
        btn300B.Enabled = False
        btn300C.Enabled = False
        btn300D.Enabled = False
        btn300E.Enabled = False
        btn400A.Enabled = False
        btn400B.Enabled = False
        btn400C.Enabled = False
        btn400D.Enabled = False
        btn400C.Enabled = False
        btn400D.Enabled = False
        btn400E.Enabled = False
        btn500A.Enabled = False
        btn500B.Enabled = False
        btn500C.Enabled = False
        btn500D.Enabled = False
        btn500E.Enabled = False
    End Sub

    Public Sub IdiotProof()
        DoubleJeoperdy()
        FinalJep()
        btnDoubleJep.Enabled = False
        If intCount = 1 Then
            btn100A.Visible = False
        ElseIf intCount = 2 Then
            btn100B.Visible = False
        ElseIf intCount = 3 Then
            btn100C.Visible = False
        ElseIf intCount = 4 Then
            btn100D.Visible = False
        ElseIf intCount = 5 Then
            btn100E.Visible = False
        ElseIf intCount = 6 Then
            btn200A.Visible = False
        ElseIf intCount = 7 Then
            btn200B.Visible = False
        ElseIf intCount = 8 Then
            btn200C.Visible = False
        ElseIf intCount = 9 Then
            btn200D.Visible = False
        ElseIf intCount = 10 Then
            btn200E.Visible = False
        ElseIf intCount = 11 Then
            btn300A.Visible = False
        ElseIf intCount = 12 Then
            btn300B.Visible = False
        ElseIf intCount = 13 Then
            btn300C.Visible = False
        ElseIf intCount = 14 Then
            btn300D.Visible = False
        ElseIf intCount = 15 Then
            btn300E.Visible = False
        ElseIf intCount = 16 Then
            btn400A.Visible = False
        ElseIf intCount = 17 Then
            btn400B.Visible = False
        ElseIf intCount = 18 Then
            btn400C.Visible = False
        ElseIf intCount = 19 Then
            btn400D.Visible = False
        ElseIf intCount = 20 Then
            btn400E.Visible = False
        ElseIf intCount = 21 Then
            btn500A.Visible = False
        ElseIf intCount = 22 Then
            btn500B.Visible = False
        ElseIf intCount = 23 Then
            btn500C.Visible = False
        ElseIf intCount = 24 Then
            btn500D.Visible = False
        ElseIf intCount = 25 Then
            btn500E.Visible = False
        End If
        btnRight.Visible = True
        btnWrong.Visible = True
        btnShowAnswer.Visible = True
        intTurns = intTurns + 1
    End Sub

    Public Sub Question()
        If intCount = 1 Then
            lblQuestion.Text = strTextBox(1, 1)
            intX = 1
            intY = 1
        ElseIf intCount = 2 Then
            lblQuestion.Text = strTextBox(1, 2)
            intX = 1
            intY = 2
        ElseIf intCount = 3 Then
            lblQuestion.Text = strTextBox(1, 3)
            intX = 1
            intY = 3
        ElseIf intCount = 4 Then
            lblQuestion.Text = strTextBox(1, 4)
            intX = 1
            intY = 4
        ElseIf intCount = 5 Then
            lblQuestion.Text = strTextBox(1, 5)
            intX = 1
            intY = 5
        ElseIf intCount = 6 Then
            lblQuestion.Text = strTextBox(2, 1)
            intX = 2
            intY = 1
        ElseIf intCount = 7 Then
            lblQuestion.Text = strTextBox(2, 2)
            intX = 2
            intY = 2
        ElseIf intCount = 8 Then
            lblQuestion.Text = strTextBox(2, 3)
            intX = 2
            intY = 3
        ElseIf intCount = 9 Then
            lblQuestion.Text = strTextBox(2, 4)
            intX = 2
            intY = 4
        ElseIf intCount = 10 Then
            lblQuestion.Text = strTextBox(2, 5)
            intX = 2
            intY = 5
        ElseIf intCount = 11 Then
            lblQuestion.Text = strTextBox(3, 1)
            intX = 3
            intY = 1
        ElseIf intCount = 12 Then
            lblQuestion.Text = strTextBox(3, 2)
            intX = 3
            intY = 2
        ElseIf intCount = 13 Then
            lblQuestion.Text = strTextBox(3, 3)
            intX = 3
            intY = 3
        ElseIf intCount = 14 Then
            lblQuestion.Text = strTextBox(3, 4)
            intX = 3
            intY = 4
        ElseIf intCount = 15 Then
            lblQuestion.Text = strTextBox(3, 5)
            intX = 3
            intY = 5
        ElseIf intCount = 16 Then
            lblQuestion.Text = strTextBox(4, 1)
            intX = 4
            intY = 1
        ElseIf intCount = 17 Then
            lblQuestion.Text = strTextBox(4, 2)
            intX = 4
            intY = 2
        ElseIf intCount = 18 Then
            lblQuestion.Text = strTextBox(4, 3)
            intX = 4
            intY = 3
        ElseIf intCount = 19 Then
            lblQuestion.Text = strTextBox(4, 4)
            intX = 4
            intY = 4
        ElseIf intCount = 20 Then
            lblQuestion.Text = strTextBox(4, 5)
            intX = 4
            intY = 5
        ElseIf intCount = 21 Then
            lblQuestion.Text = strTextBox(5, 1)
            intX = 5
            intY = 1
        ElseIf intCount = 22 Then
            lblQuestion.Text = strTextBox(5, 2)
            intX = 5
            intY = 2
        ElseIf intCount = 23 Then
            lblQuestion.Text = strTextBox(5, 3)
            intX = 5
            intY = 3
        ElseIf intCount = 24 Then
            lblQuestion.Text = strTextBox(5, 4)
            intX = 5
            intY = 4
        ElseIf intCount = 25 Then
            lblQuestion.Text = strTextBox(5, 5)
            intX = 5
            intY = 5
        End If
    End Sub

#Region "Game Buttons"
    Private Sub btn100A_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100A.Click
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
            MessageBox.Show("Double Jeopardy!!")
            dblDouble = True
        End If
    End Sub

    Public Sub DJPoints()
        If dblDouble = True Then
            intPoints = intPoints * 2
        End If
    End Sub

    Public Sub DJPoints2()
        If cbxTeam1.Checked = True Then
            intTeamCount1 = intPoints
        End If
        If cbxTeam1.Checked = True Then
            intTeamCount1 = intPoints
        End If
        If cbxTeam2.Checked = True Then
            intTeamCount2 = intPoints
        End If
        If cbxTeam3.Checked = True Then
            intTeamCount3 = intPoints
        End If
        If cbxTeam4.Checked = True Then
            intTeamCount4 = intPoints
        End If
        If cbxTeam5.Checked = True Then
            intTeamCount5 = intPoints
        End If
        If cbxTeam6.Checked = True Then
            intTeamCount6 = intPoints
        End If
        dblDouble = False
    End Sub

    Public Sub FinalJep()
        If intTurns = 24 Then
            intPoints = InputBox("How much would you like to wager?")
            If intRightWrong = 1 Then
                intPoints = intPoints * 2
            ElseIf intRightWrong = 0 Then
                intPoints = intPoints
            End If
        End If
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        ButtonRight()
    End Sub
    Public Sub ButtonRight()
        intRightWrong = 1
        btnRight.Visible = False
        btnWrong.Visible = False
        btnShowAnswer.Visible = False
        If cbxTeam1.Checked = True Then
            DJPoints()
            If intPoints = 100 Then
                intTeamCount1 = intTeamCount1 + 100
            ElseIf intPoints = 200 Then
                intTeamCount1 = intTeamCount1 + 200
            ElseIf intPoints = 300 Then
                intTeamCount1 = intTeamCount1 + 300
            ElseIf intPoints = 400 Then
                intTeamCount1 = intTeamCount1 + 400
            ElseIf intPoints = 500 Then
                intTeamCount1 = intTeamCount1 + 500
            Else
                DJPoints2()
            End If
            lblTeamCount1.Text = CInt(intTeamCount1.ToString)
            cbxTeam1.Checked = False
        End If
        If cbxTeam2.Checked = True Then
            DJPoints()
            If intPoints = 100 Then
                intTeamCount2 = intTeamCount2 + 100
            ElseIf intPoints = 200 Then
                intTeamCount2 = intTeamCount2 + 200
            ElseIf intPoints = 300 Then
                intTeamCount2 = intTeamCount2 + 300
            ElseIf intPoints = 400 Then
                intTeamCount2 = intTeamCount2 + 400
            ElseIf intPoints = 500 Then
                intTeamCount2 = intTeamCount2 + 500
            End If
            lblTeamCount2.Text = CInt(intTeamCount2.ToString)
            cbxTeam2.Checked = False
        End If
        If cbxTeam3.Checked = True Then
            DJPoints()
            If intPoints = 100 Then
                intTeamCount3 = intTeamCount3 + 100
            ElseIf intPoints = 200 Then
                intTeamCount3 = intTeamCount3 + 200
            ElseIf intPoints = 300 Then
                intTeamCount3 = intTeamCount3 + 300
            ElseIf intPoints = 400 Then
                intTeamCount3 = intTeamCount3 + 400
            ElseIf intPoints = 500 Then
                intTeamCount3 = intTeamCount3 + 500
            End If
            lblTeamCount3.Text = CInt(intTeamCount3.ToString)
            cbxTeam3.Checked = False
        End If
        If cbxTeam4.Checked = True Then
            DJPoints()
            If intPoints = 100 Then
                intTeamCount4 = intTeamCount4 + 100
            ElseIf intPoints = 200 Then
                intTeamCount4 = intTeamCount4 + 200
            ElseIf intPoints = 300 Then
                intTeamCount4 = intTeamCount4 + 300
            ElseIf intPoints = 400 Then
                intTeamCount4 = intTeamCount4 + 400
            ElseIf intPoints = 500 Then
                intTeamCount4 = intTeamCount4 + 500
            End If
            lblTeamCount4.Text = CInt(intTeamCount4.ToString)
            cbxTeam4.Checked = False
        End If
        If cbxTeam5.Checked = True Then
            DJPoints()
            If intPoints = 100 Then
                intTeamCount4 = intTeamCount4 + 100
            ElseIf intPoints = 200 Then
                intTeamCount4 = intTeamCount4 + 200
            ElseIf intPoints = 300 Then
                intTeamCount4 = intTeamCount4 + 300
            ElseIf intPoints = 400 Then
                intTeamCount4 = intTeamCount4 + 400
            ElseIf intPoints = 500 Then
                intTeamCount4 = intTeamCount4 + 500
            End If
            lblTeamCount5.Text = CInt(intTeamCount4.ToString)
            cbxTeam5.Checked = False
        End If
        If cbxTeam6.Checked = True Then
            DJPoints()
            If intPoints = 100 Then
                intTeamCount4 = intTeamCount4 + 100
            ElseIf intPoints = 200 Then
                intTeamCount4 = intTeamCount4 + 200
            ElseIf intPoints = 300 Then
                intTeamCount4 = intTeamCount4 + 300
            ElseIf intPoints = 400 Then
                intTeamCount4 = intTeamCount4 + 400
            ElseIf intPoints = 500 Then
                intTeamCount4 = intTeamCount4 + 500
            End If
            lblTeamCount6.Text = CInt(intTeamCount4.ToString)
            cbxTeam6.Checked = False
        End If
        If intTurns = 25 Then
            btnShowWinner.Visible = True
        End If
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
        intRightWrong = 4
    End Sub

    Private Sub btnWrong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrong.Click
        ButtonWrong()
    End Sub
    Public Sub ButtonWrong()
        intRightWrong = 0
        btnWrong.Visible = False
        btnRight.Visible = False
        btnShowAnswer.Visible = False
        If cbxTeam1.Checked = True Then
            If dblDouble = True Then
                intPoints = intTeamCount1 - intPoints
                DJPoints2()
            ElseIf intTurns <> 25 Then
                intTeamCount1 = intTeamCount1 - 50
            Else
                intTeamCount1 = intTeamCount1 - intPoints
            End If
            lblTeamCount1.Text = CInt(intTeamCount1.ToString)
            cbxTeam1.Checked = False
        End If
        If cbxTeam2.Checked = True Then
            If dblDouble = True Then
                intPoints = intTeamCount2 - intPoints
                DJPoints2()
            ElseIf intTurns <> 25 Then
                intTeamCount2 = intTeamCount2 - 50
            Else
                intTeamCount2 = intTeamCount2 - intPoints
            End If
            lblTeamCount2.Text = CInt(intTeamCount2.ToString)
            cbxTeam2.Checked = False
        End If
        If cbxTeam3.Checked = True Then
            If dblDouble = True Then
                intPoints = intTeamCount3 - intPoints
                DJPoints2()
            ElseIf intTurns <> 25 Then
                intTeamCount3 = intTeamCount3 - 50
            Else
                intTeamCount3 = intTeamCount3 - intPoints
            End If
            lblTeamCount3.Text = CInt(intTeamCount3.ToString)
            cbxTeam3.Checked = False
        End If
        If cbxTeam4.Checked = True Then
            If dblDouble = True Then
                intPoints = intTeamCount4 - intPoints
                DJPoints2()
            ElseIf intTurns <> 25 Then
                intTeamCount4 = intTeamCount4 - 50
            Else
                intTeamCount4 = intTeamCount4 - intPoints
            End If
            lblTeamCount4.Text = CInt(intTeamCount4.ToString)
            cbxTeam4.Checked = False
        End If
        If cbxTeam5.Checked = True Then
            If dblDouble = True Then
                intPoints = intTeamCount5 - intPoints
                DJPoints2()
            ElseIf intTurns <> 25 Then
                intTeamCount5 = intTeamCount5 - 50
            Else
                intTeamCount5 = intTeamCount5 - intPoints
            End If
            lblTeamCount5.Text = CInt(intTeamCount4.ToString)
            cbxTeam5.Checked = False
        End If
        If cbxTeam6.Checked = True Then
            If dblDouble = True Then
                intPoints = intTeamCount6 - intPoints
                DJPoints2()
            ElseIf intTurns <> 25 Then
                intTeamCount6 = intTeamCount6 - 50
            Else
                intTeamCount5 = intTeamCount5 - intPoints
            End If
            lblTeamCount6.Text = CInt(intTeamCount4.ToString)
            cbxTeam6.Checked = False
        End If
        If intTurns = 25 Then
            btnShowWinner.Visible = True
        End If
        intPoints = 0
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
        intRightWrong = 4
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblA.Text = strColumns(1)
        lblB.Text = strColumns(2)
        lblC.Text = strColumns(3)
        lblD.Text = strColumns(4)
        lblE.Text = strColumns(5)
        lblQuestion.Visible = False
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
    End Sub

    Private Sub btnMakeOwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeOwn.Click
        Dim Costomize As New Costomize
        Costomize.Show()
    End Sub

    Private Sub btnSave1_Click(sender As System.Object, e As System.EventArgs) Handles btnSave1.Click
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
    Private Sub btnUp1_Click(sender As System.Object, e As System.EventArgs) Handles btnUp1.Click
        intTeamCount1 += 50
        lblTeamCount1.Text = intTeamCount1
    End Sub

    Private Sub btnDown1_Click(sender As System.Object, e As System.EventArgs) Handles btnDown1.Click
        intTeamCount1 -= 50
        lblTeamCount1.Text = intTeamCount1
    End Sub

    Private Sub btnUp2_Click(sender As System.Object, e As System.EventArgs) Handles btnUp2.Click
        intTeamCount2 += 50
        lblTeamCount2.Text = intTeamCount2
    End Sub

    Private Sub btnDown2_Click(sender As System.Object, e As System.EventArgs) Handles btnDown2.Click
        intTeamCount2 -= 50
        lblTeamCount2.Text = intTeamCount2
    End Sub

    Private Sub btnUp3_Click(sender As System.Object, e As System.EventArgs) Handles btnUp3.Click
        intTeamCount3 += 50
        lblTeamCount3.Text = intTeamCount3
    End Sub

    Private Sub btnDown3_Click(sender As System.Object, e As System.EventArgs) Handles btnDown3.Click
        intTeamCount3 -= 50
        lblTeamCount3.Text = intTeamCount3
    End Sub

    Private Sub btnUp4_Click(sender As System.Object, e As System.EventArgs) Handles btnUp4.Click
        intTeamCount4 += 50
        lblTeamCount4.Text = intTeamCount4
    End Sub

    Private Sub btnDown4_Click(sender As System.Object, e As System.EventArgs) Handles btnDown4.Click
        intTeamCount4 -= 50
        lblTeamCount4.Text = intTeamCount4
    End Sub

    Private Sub btnUp5_Click(sender As System.Object, e As System.EventArgs) Handles btnUp5.Click
        intTeamCount5 += 50
        lblTeamCount5.Text = intTeamCount5
    End Sub

    Private Sub btnDown5_Click(sender As System.Object, e As System.EventArgs) Handles btnDown5.Click
        intTeamCount5 -= 50
        lblTeamCount5.Text = intTeamCount5
    End Sub

    Private Sub btnUp6_Click(sender As System.Object, e As System.EventArgs) Handles btnUp6.Click
        intTeamCount6 += 50
        lblTeamCount6.Text = intTeamCount6
    End Sub

    Private Sub btnDown6_Click(sender As System.Object, e As System.EventArgs) Handles btnDown6.Click
        intTeamCount6 -= 50
        lblTeamCount6.Text = intTeamCount6
    End Sub
#End Region

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            ButtonRight()
        ElseIf e.KeyCode = Keys.W Then
            ButtonWrong()
        ElseIf e.KeyCode = Keys.S Then
            lblQuestion.Text = strAnswer(intX, intY)
        End If
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBox2.Show()
    End Sub

#Region "NameBTN"
    Private Sub btnNameTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName1.Click
        If bolName = False Then
            txtb1.Enabled = True
            bolName = True
        ElseIf bolName = True Then
            txtb1.Enabled = False
            bolName = False
        End If
    End Sub
    Private Sub btnName2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName2.Click
        If bolName = False Then
            txtb2.Enabled = True
            bolName = True
        ElseIf bolName = True Then
            txtb2.Enabled = False
            bolName = False
        End If
    End Sub
    Private Sub btnName3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName3.Click
        If bolName = False Then
            txtb3.Enabled = True
            bolName = True
        ElseIf bolName = True Then
            txtb3.Enabled = False
            bolName = False
        End If
    End Sub
    Private Sub btnName4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName4.Click
        If bolName = False Then
            txtb4.Enabled = True
            bolName = True
        ElseIf bolName = True Then
            txtb4.Enabled = False
            bolName = False
        End If
    End Sub
    Private Sub btnName5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName5.Click
        If bolName = False Then
            txtb5.Enabled = True
            bolName = True
        ElseIf bolName = True Then
            txtb5.Enabled = False
            bolName = False
        End If
    End Sub
    Private Sub btnName6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName6.Click
        If bolName = False Then
            txtb6.Enabled = True
            bolName = True
        ElseIf bolName = True Then
            txtb6.Enabled = False
            bolName = False
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
End Class