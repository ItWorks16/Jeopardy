Module Module1
    Public strTextBox(6, 6) As String
    Public strColumns(5) As String
    Public strAnswer(6, 6) As String
    Public strFilePath(6, 6) As String
    Public strAFilePath(6, 6) As String
    Public intButtonName As Integer
    Public btnGameButtons(6, 6) As Button
    Public Sub ShowSubjects()
        Form1.lblA.Text = strColumns(1)
        Form1.lblB.Text = strColumns(2)
        Form1.lblC.Text = strColumns(3)
        Form1.lblD.Text = strColumns(4)
        Form1.lblE.Text = strColumns(5)
    End Sub
    Public Sub GameButtons()
        btnGameButtons(1, 1) = Form1.btn100A
        btnGameButtons(1, 2) = Form1.btn100B
        btnGameButtons(1, 3) = Form1.btn100C
        btnGameButtons(1, 4) = Form1.btn100D
        btnGameButtons(1, 5) = Form1.btn100E
        btnGameButtons(2, 1) = Form1.btn200A
        btnGameButtons(2, 2) = Form1.btn200B
        btnGameButtons(2, 3) = Form1.btn200C
        btnGameButtons(2, 4) = Form1.btn200D
        btnGameButtons(2, 5) = Form1.btn200E
        btnGameButtons(3, 1) = Form1.btn300A
        btnGameButtons(3, 2) = Form1.btn300B
        btnGameButtons(3, 3) = Form1.btn300C
        btnGameButtons(3, 4) = Form1.btn300D
        btnGameButtons(3, 5) = Form1.btn300E
        btnGameButtons(4, 1) = Form1.btn400A
        btnGameButtons(4, 2) = Form1.btn400B
        btnGameButtons(4, 3) = Form1.btn400C
        btnGameButtons(4, 4) = Form1.btn400D
        btnGameButtons(4, 5) = Form1.btn400E
        btnGameButtons(5, 1) = Form1.btn500A
        btnGameButtons(5, 2) = Form1.btn500B
        btnGameButtons(5, 3) = Form1.btn500C
        btnGameButtons(5, 4) = Form1.btn500D
        btnGameButtons(5, 5) = Form1.btn500E
    End Sub
End Module