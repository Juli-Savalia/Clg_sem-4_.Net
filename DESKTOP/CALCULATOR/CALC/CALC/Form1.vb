﻿Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim sign As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.AppendText("1")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.AppendText("2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.AppendText("3")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.AppendText("4")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.AppendText("5")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.AppendText("6")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.AppendText("7")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.AppendText("8")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.AppendText("9")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        a = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox1.Text = TextBox1.Text & "+"
        sign = "+"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        a = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox1.Text = TextBox1.Text + "-"
        sign = "-"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        a = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox1.Text = TextBox1.Text + "*"
        sign = "*"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        a = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox1.Text = TextBox1.Text + "/"
        sign = "/"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        a = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox1.Text = TextBox1.Text + "%"
        sign = "%"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        a = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        TextBox1.Text = TextBox1.Text + "^"
        sign = "^"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.AppendText(".")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        b = TextBox1.Text
        If sign = "+" Then
            TextBox1.Text = a + b
        ElseIf sign = "-" Then
            TextBox1.Text = a - b
        ElseIf sign = "*" Then
            TextBox1.Text = a * b
        ElseIf sign = "/" Then
            TextBox1.Text = a / b
        Else
            TextBox1.Text = a Mod b
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub


End Class
