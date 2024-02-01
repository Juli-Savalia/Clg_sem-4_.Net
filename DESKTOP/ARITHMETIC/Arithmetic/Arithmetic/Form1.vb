Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Double
        x = TextBox1.Text
        Dim y As Double
        y = TextBox2.Text
        Dim z As Double
        z = x + y
        MessageBox.Show("your addition is " & z)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Double
        x = TextBox1.Text - TextBox2.Text
        MessageBox.Show("your substraction is" & x)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Double
        x = TextBox1.Text / TextBox2.Text
        MessageBox.Show("your Division is" & x)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x As Double
        x = TextBox1.Text * TextBox2.Text
        MessageBox.Show("youe Multiplication is" & x)
    End Sub
End Class
