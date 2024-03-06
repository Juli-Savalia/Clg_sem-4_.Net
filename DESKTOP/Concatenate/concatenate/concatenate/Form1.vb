Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = TextBox2.Text
        MessageBox.Show(String.Concat(str1, str2))
    End Sub
End Class
