<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        CheckBox1 = New Windows.Forms.CheckBox()
        CheckBox2 = New Windows.Forms.CheckBox()
        CheckBox3 = New Windows.Forms.CheckBox()
        CheckBox4 = New Windows.Forms.CheckBox()
        CheckBox5 = New Windows.Forms.CheckBox()
        CheckBox6 = New Windows.Forms.CheckBox()
        CheckBox7 = New Windows.Forms.CheckBox()
        CheckBox8 = New Windows.Forms.CheckBox()
        TextBox1 = New TextBox()
        ColorDialog1 = New ColorDialog()
        ColorDialog2 = New ColorDialog()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(356, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter any String :-"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(219, 216)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(51, 19)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Italic"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(219, 259)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(50, 19)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(219, 310)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(76, 19)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "Highlight"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(219, 358)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(55, 19)
        CheckBox4.TabIndex = 4
        CheckBox4.Text = "Strike"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(521, 216)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(81, 19)
        CheckBox5.TabIndex = 5
        CheckBox5.Text = "color - red"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(521, 259)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(77, 19)
        CheckBox6.TabIndex = 6
        CheckBox6.Text = "Underline"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(521, 310)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(87, 19)
        CheckBox7.TabIndex = 7
        CheckBox7.Text = "color - pink"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(521, 358)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(54, 19)
        CheckBox8.TabIndex = 8
        CheckBox8.Text = "purpl"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(356, 131)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(159, 42)
        TextBox1.TabIndex = 9
        ' 
        ' ColorDialog1
        ' 
        ColorDialog1.AnyColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(CheckBox8)
        Controls.Add(CheckBox7)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
End Class
