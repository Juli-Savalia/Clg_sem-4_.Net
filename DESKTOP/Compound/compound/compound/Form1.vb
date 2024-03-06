Imports Microsoft.Win32

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Double = TextBox3.Text
        Dim r As Double = TextBox1.Text
        Dim t As Double = TextBox2.Text
        Dim amount As Double

        amount = (p * ((1 + r / 100) ^ t)) - p

        MessageBox.Show("YouR CI is = " & amount)
    End Sub
End Class
