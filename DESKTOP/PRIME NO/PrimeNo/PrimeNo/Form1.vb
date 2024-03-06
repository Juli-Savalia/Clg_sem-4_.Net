Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim n As Integer = TextBox1.Text
        If n = 0 Or n = 1 Then
            MessageBox.Show("Its not an prime no..")
        End If

        For i = 2 To (n - 1)
            If n Mod i = 0 Then
                MessageBox.Show("Its not an prime no..")
                Return
            End If
        Next i
        If i = n Then
            MessageBox.Show("Its prime no..")
        End If
    End Sub
End Class
