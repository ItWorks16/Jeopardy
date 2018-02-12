Public Class Costomize
    Dim intCount1 As Integer = 1
    Dim intCount2 As Integer = 1
    Dim strFileLocationAndName As String
    Dim ofd As New OpenFileDialog
   
    Private Sub btnSetQuestions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetQuestions.Click
        strTextBox(1, 1) = tbx1.Text
        strTextBox(1, 2) = tbx2.Text
        strTextBox(1, 3) = tbx3.Text
        strTextBox(1, 4) = tbx4.Text
        strTextBox(1, 5) = tbx5.Text
        strTextBox(2, 1) = tbx6.Text
        strTextBox(2, 2) = tbx7.Text
        strTextBox(2, 3) = tbx8.Text
        strTextBox(2, 4) = tbx9.Text
        strTextBox(2, 5) = tbx10.Text
        strTextBox(3, 1) = tbx11.Text
        strTextBox(3, 2) = tbx12.Text
        strTextBox(3, 3) = tbx13.Text
        strTextBox(3, 4) = tbx14.Text
        strTextBox(3, 5) = tbx15.Text
        strTextBox(4, 1) = tbx16.Text
        strTextBox(4, 2) = tbx17.Text
        strTextBox(4, 3) = tbx18.Text
        strTextBox(4, 4) = tbx19.Text
        strTextBox(4, 5) = tbx20.Text
        strTextBox(5, 1) = tbx21.Text
        strTextBox(5, 2) = tbx22.Text
        strTextBox(5, 3) = tbx23.Text
        strTextBox(5, 4) = tbx24.Text
        strTextBox(5, 5) = tbx25.Text
        strColumns(1) = tbxColumn1.Text
        strColumns(2) = tbxColumn2.Text
        strColumns(3) = tbxColumn3.Text
        strColumns(4) = tbxColumn4.Text
        strColumns(5) = tbxColumn5.Text

        Try
            SaveFileDialog1.Filter = "Jep Game files (*.jepdy)|*.jepdy"
            ' SaveFileDialog1.FileName = txtCourseName.Text
            SaveFileDialog1.ShowDialog()

            Dim textFile As New System.IO.StreamWriter(SaveFileDialog1.FileName)

            Dim i, j As Integer
            For i = 1 To 5
                For j = 1 To 5
                    textFile.WriteLine(strTextBox(i, j))
                Next
            Next
            textFile.WriteLine(strColumns(1))
            For i = 1 To 5
                textFile.WriteLine(strColumns(i))
            Next
            For i = 1 To 5
                For j = 1 To 5
                    textFile.WriteLine(strAnswer(i, j))
                Next
            Next
            For i = 1 To 5
                For j = 1 To 5
                    textFile.WriteLine(strFilePath(i, j))
                Next
            Next
            For i = 1 To 5
                For j = 1 To 5
                    textFile.WriteLine(strAFilePath(i, j))
                Next
            Next
            textFile.Close()
        Catch
            MessageBox.Show("There was an error saving your file.")
        End Try
        ShowSubjects()
        Me.Hide()
    End Sub

    Private Sub btnAddAnswers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAnswers.Click
        Form3.Show()
    End Sub

    Private Sub btnInformation_Click(sender As System.Object, e As System.EventArgs) Handles btnInformation.Click
        Form4.Show()
    End Sub
#Region "addpictures"
    Private Sub tbx1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx1.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(1, 1) = ofd.FileName
            tbx1.Text = "&"
        End If
    End Sub
    Private Sub tbx2_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx2.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(1, 2) = ofd.FileName
            tbx2.Text = "&"
        End If
    End Sub
    Private Sub tbx3_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx4.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(1, 3) = ofd.FileName
            tbx3.Text = "&"
        End If
    End Sub
    Private Sub tbx4_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx4.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(1, 4) = ofd.FileName
            tbx4.Text = "&"
        End If
    End Sub
    Private Sub tbx5_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx5.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(1, 5) = ofd.FileName
            tbx5.Text = "&"
        End If
    End Sub
    Private Sub tbx6_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx6.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(2, 1) = ofd.FileName
            tbx6.Text = "&"
        End If
    End Sub
    Private Sub tbx7_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx7.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(2, 2) = ofd.FileName
            tbx7.Text = "&"
        End If
    End Sub
    Private Sub tbx8_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx8.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(2, 3) = ofd.FileName
            tbx8.Text = "&"
        End If
    End Sub
    Private Sub tbx9_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx9.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(2, 4) = ofd.FileName
            tbx9.Text = "&"
        End If
    End Sub
    Private Sub tbx10_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx10.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(2, 5) = ofd.FileName
            tbx10.Text = "&"
        End If
    End Sub
    Private Sub tbx11_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx11.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(3, 1) = ofd.FileName
            tbx11.Text = "&"
        End If
    End Sub
    Private Sub tbx12_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx12.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(3, 2) = ofd.FileName
            tbx12.Text = "&"
        End If
    End Sub
    Private Sub tbx13_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx13.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(3, 3) = ofd.FileName
            tbx13.Text = "&"
        End If
    End Sub
    Private Sub tbx14_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx14.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(3, 4) = ofd.FileName
            tbx14.Text = "&"
        End If
    End Sub
    Private Sub tbx15_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx15.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(3, 5) = ofd.FileName
            tbx15.Text = "&"
        End If
    End Sub
    Private Sub tbx16_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx16.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(4, 1) = ofd.FileName
            tbx16.Text = "&"
        End If
    End Sub
    Private Sub tbx17_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx17.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(4, 2) = ofd.FileName
            tbx17.Text = "&"
        End If
    End Sub
    Private Sub tbx18_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx18.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(4, 3) = ofd.FileName
            tbx18.Text = "&"
        End If
    End Sub
    Private Sub tbx19_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx19.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(4, 4) = ofd.FileName
            tbx19.Text = "&"
        End If
    End Sub
    Private Sub tbx20_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx20.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(4, 5) = ofd.FileName
            tbx20.Text = "&"
        End If
    End Sub
    Private Sub tbx21_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx21.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(5, 1) = ofd.FileName
            tbx21.Text = "&"
        End If
    End Sub
    Private Sub tbx22_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx22.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(5, 2) = ofd.FileName
            tbx22.Text = "&"
        End If
    End Sub
    Private Sub tbx23_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx23.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(5, 3) = ofd.FileName
            tbx23.Text = "&"
        End If
    End Sub
    Private Sub tbx24_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx24.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(5, 4) = ofd.FileName
            tbx24.Text = "&"
        End If
    End Sub
    Private Sub tbx25_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx25.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strFilePath(5, 5) = ofd.FileName
            tbx25.Text = "&"
        End If
    End Sub
#End Region

    Private Sub Costomize_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbxColumn1.Text = strColumns(1)
        tbxColumn2.Text = strColumns(2)
        tbxColumn3.Text = strColumns(3)
        tbxColumn4.Text = strColumns(4)
        tbxColumn5.Text = strColumns(5)
        tbx1.Text = strTextBox(1, 1)
        tbx2.Text = strTextBox(1, 2)
        tbx3.Text = strTextBox(1, 3)
        tbx4.Text = strTextBox(1, 4)
        tbx5.Text = strTextBox(1, 5)
        tbx6.Text = strTextBox(2, 1)
        tbx7.Text = strTextBox(2, 2)
        tbx8.Text = strTextBox(2, 3)
        tbx9.Text = strTextBox(2, 4)
        tbx10.Text = strTextBox(2, 5)
        tbx11.Text = strTextBox(3, 1)
        tbx12.Text = strTextBox(3, 2)
        tbx13.Text = strTextBox(3, 3)
        tbx14.Text = strTextBox(3, 4)
        tbx15.Text = strTextBox(3, 5)
        tbx16.Text = strTextBox(4, 1)
        tbx17.Text = strTextBox(4, 2)
        tbx18.Text = strTextBox(4, 3)
        tbx19.Text = strTextBox(4, 4)
        tbx20.Text = strTextBox(4, 5)
        tbx21.Text = strTextBox(5, 1)
        tbx22.Text = strTextBox(5, 2)
        tbx23.Text = strTextBox(5, 3)
        tbx24.Text = strTextBox(5, 4)
        tbx25.Text = strTextBox(5, 5)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbxColumn1.Text = ""
        tbxColumn2.Text = ""
        tbxColumn3.Text = ""
        tbxColumn4.Text = ""
        tbxColumn5.Text = ""
        tbx1.Text = ""
        tbx2.Text = ""
        tbx3.Text = ""
        tbx4.Text = ""
        tbx5.Text = ""
        tbx6.Text = ""
        tbx7.Text = ""
        tbx8.Text = ""
        tbx9.Text = ""
        tbx10.Text = ""
        tbx11.Text = ""
        tbx12.Text = ""
        tbx13.Text = ""
        tbx14.Text = ""
        tbx15.Text = ""
        tbx16.Text = ""
        tbx17.Text = ""
        tbx18.Text = ""
        tbx19.Text = ""
        tbx20.Text = ""
        tbx21.Text = ""
        tbx22.Text = ""
        tbx23.Text = ""
        tbx24.Text = ""
        tbx25.Text = ""
    End Sub
End Class