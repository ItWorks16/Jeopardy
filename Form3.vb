Public Class Form3
    Dim ofd As New OpenFileDialog
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        strAnswer(1, 1) = tbx1.Text
        strAnswer(1, 2) = tbx2.Text
        strAnswer(1, 3) = tbx3.Text
        strAnswer(1, 4) = tbx4.Text
        strAnswer(1, 5) = tbx5.Text
        strAnswer(2, 1) = tbx6.Text
        strAnswer(2, 2) = tbx7.Text
        strAnswer(2, 3) = tbx8.Text
        strAnswer(2, 4) = tbx9.Text
        strAnswer(2, 5) = tbx10.Text
        strAnswer(3, 1) = tbx11.Text
        strAnswer(3, 2) = tbx12.Text
        strAnswer(3, 3) = tbx13.Text
        strAnswer(3, 4) = tbx14.Text
        strAnswer(3, 5) = tbx15.Text
        strAnswer(4, 1) = tbx16.Text
        strAnswer(4, 2) = tbx17.Text
        strAnswer(4, 3) = tbx18.Text
        strAnswer(4, 4) = tbx19.Text
        strAnswer(4, 5) = tbx20.Text
        strAnswer(5, 1) = tbx21.Text
        strAnswer(5, 2) = tbx22.Text
        strAnswer(5, 3) = tbx23.Text
        strAnswer(5, 4) = tbx24.Text
        strAnswer(5, 5) = tbx25.Text
        Me.Hide()
    End Sub

#Region "addpictures"
    Private Sub tbx1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx1.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(1, 1) = ofd.FileName
            tbx1.Text = "&"
        End If
    End Sub
    Private Sub tbx2_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx2.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(1, 2) = ofd.FileName
            tbx2.Text = "&"
        End If
    End Sub
    Private Sub tbx3_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx4.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(1, 3) = ofd.FileName
            tbx3.Text = "&"
        End If
    End Sub
    Private Sub tbx4_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx4.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(1, 4) = ofd.FileName
            tbx4.Text = "&"
        End If
    End Sub
    Private Sub tbx5_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx5.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(1, 5) = ofd.FileName
            tbx5.Text = "&"
        End If
    End Sub
    Private Sub tbx6_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx6.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(2, 1) = ofd.FileName
            tbx6.Text = "&"
        End If
    End Sub
    Private Sub tbx7_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx7.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(2, 2) = ofd.FileName
            tbx7.Text = "&"
        End If
    End Sub
    Private Sub tbx8_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx8.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(2, 3) = ofd.FileName
            tbx8.Text = "&"
        End If
    End Sub
    Private Sub tbx9_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx9.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(2, 4) = ofd.FileName
            tbx9.Text = "&"
        End If
    End Sub
    Private Sub tbx10_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx10.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(2, 5) = ofd.FileName
            tbx10.Text = "&"
        End If
    End Sub
    Private Sub tbx11_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx11.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(3, 1) = ofd.FileName
            tbx11.Text = "&"
        End If
    End Sub
    Private Sub tbx12_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx12.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(3, 2) = ofd.FileName
            tbx12.Text = "&"
        End If
    End Sub
    Private Sub tbx13_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx13.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(3, 3) = ofd.FileName
            tbx13.Text = "&"
        End If
    End Sub
    Private Sub tbx14_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx14.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(3, 4) = ofd.FileName
            tbx14.Text = "&"
        End If
    End Sub
    Private Sub tbx15_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx15.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(3, 5) = ofd.FileName
            tbx15.Text = "&"
        End If
    End Sub
    Private Sub tbx16_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx16.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(4, 1) = ofd.FileName
            tbx16.Text = "&"
        End If
    End Sub
    Private Sub tbx17_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx17.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(4, 2) = ofd.FileName
            tbx17.Text = "&"
        End If
    End Sub
    Private Sub tbx18_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx18.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(4, 3) = ofd.FileName
            tbx18.Text = "&"
        End If
    End Sub
    Private Sub tbx19_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx19.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(4, 4) = ofd.FileName
            tbx19.Text = "&"
        End If
    End Sub
    Private Sub tbx20_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx20.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(4, 5) = ofd.FileName
            tbx20.Text = "&"
        End If
    End Sub
    Private Sub tbx21_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx21.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(5, 1) = ofd.FileName
            tbx21.Text = "&"
        End If
    End Sub
    Private Sub tbx22_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx22.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(5, 2) = ofd.FileName
            tbx22.Text = "&"
        End If
    End Sub
    Private Sub tbx23_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx23.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(5, 3) = ofd.FileName
            tbx23.Text = "&"
        End If
    End Sub
    Private Sub tbx24_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx24.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(5, 4) = ofd.FileName
            tbx24.Text = "&"
        End If
    End Sub
    Private Sub tbx25_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles tbx25.MouseDoubleClick
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            strAFilePath(5, 5) = ofd.FileName
            tbx25.Text = "&"
        End If
    End Sub
#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbx1.Text = strAnswer(1, 1)
        tbx2.Text = strAnswer(1, 2)
        tbx3.Text = strAnswer(1, 3)
        tbx4.Text = strAnswer(1, 4)
        tbx5.Text = strAnswer(1, 5)
        tbx6.Text = strAnswer(2, 1)
        tbx7.Text = strAnswer(2, 2)
        tbx8.Text = strAnswer(2, 3)
        tbx9.Text = strAnswer(2, 4)
        tbx10.Text = strAnswer(2, 5)
        tbx11.Text = strAnswer(3, 1)
        tbx12.Text = strAnswer(3, 2)
        tbx13.Text = strAnswer(3, 3)
        tbx14.Text = strAnswer(3, 4)
        tbx15.Text = strAnswer(3, 5)
        tbx16.Text = strAnswer(4, 1)
        tbx17.Text = strAnswer(4, 2)
        tbx18.Text = strAnswer(4, 3)
        tbx19.Text = strAnswer(4, 4)
        tbx20.Text = strAnswer(4, 5)
        tbx21.Text = strAnswer(5, 1)
        tbx22.Text = strAnswer(5, 2)
        tbx23.Text = strAnswer(5, 3)
        tbx24.Text = strAnswer(5, 4)
        tbx25.Text = strAnswer(5, 5)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
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