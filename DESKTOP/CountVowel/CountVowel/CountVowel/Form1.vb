Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Word As String = "AEIOUaeiou"
        Dim i As Integer
        Dim count As Integer = 0
        Dim instring As String = TextBox1.Text
        For i = 1 To Len(instring)
            If InStr(Word, Mid(instring, i, 1)) Then
                count += 1
            End If
        Next i
        MessageBox.Show("The number of vowels in your string are :- " & count)
    End Sub
End Class
