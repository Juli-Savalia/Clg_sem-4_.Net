Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim age As Integer = TextBox2.Text
        Dim city As String = ComboBox1.Text
        MessageBox.Show("your Name is = " & name & "Your Age is =" & age & "Your City is = " & city)
    End Sub
End Class
