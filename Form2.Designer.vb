<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Timer1 = New Timer(components)
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(363, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 37)
        Button1.TabIndex = 0
        Button1.Text = "StopWatch (Ctrl + T)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(444, 346)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 42)
        Button2.TabIndex = 1
        Button2.Text = "Submit (Ctrl+S)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(363, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(362, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 3
        Label2.Text = "Phone"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(362, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 4
        Label3.Text = "Email"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(363, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "GitHub LInk"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(598, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 20)
        Label5.TabIndex = 6
        Label5.Text = "00:00:00"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(543, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(543, 123)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(197, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(543, 182)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(197, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(543, 239)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(197, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(365, 16)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(296, 27)
        TextBox5.TabIndex = 11
        TextBox5.Text = "Create New Submission"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.Online_Dynamic_Form_Builder_4_p3hcilv910bbz6i858x0z9li27pfulwe9tqpvtxsls
        Button3.Location = New Point(12, 45)
        Button3.Name = "Button3"
        Button3.Size = New Size(308, 353)
        Button3.TabIndex = 12
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
End Class
