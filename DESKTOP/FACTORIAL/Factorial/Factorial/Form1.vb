﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim no As Integer = TextBox1.Text
        Dim fact As Integer = 1
        For i As Integer = 1 To no
            fact = fact * i
        Next i

        MessageBox.Show("your factorial numbers are :-" & fact)


    End Sub
End Class
