Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Or FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Or FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox1.ForeColor = Color.Pink
        Else
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Or FontStyle.Strikeout)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub
End Class
