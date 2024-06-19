<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(85, 359)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 52)
        Button1.TabIndex = 0
        Button1.Text = "Next/Fetch Submission (Ctrl+N)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(311, 359)
        Button2.Name = "Button2"
        Button2.Size = New Size(190, 52)
        Button2.TabIndex = 1
        Button2.Text = "Edit Submission (Ctrl + E)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(287, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 27)
        TextBox1.TabIndex = 2
        TextBox1.Text = "VIEW SUBMISSION"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 3
        Label1.Text = "Name"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 4
        Label2.Text = "Phone"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 5
        Label3.Text = "Email"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 6
        Label4.Text = "GitHub Link"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(67, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 7
        Label5.Text = "Time"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(171, 68)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(454, 27)
        TextBox2.TabIndex = 8
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(171, 114)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(454, 27)
        TextBox3.TabIndex = 9
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(171, 168)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(454, 27)
        TextBox4.TabIndex = 10
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(171, 223)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(454, 27)
        TextBox5.TabIndex = 11
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(171, 281)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(454, 27)
        TextBox6.TabIndex = 12
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(541, 359)
        Button3.Name = "Button3"
        Button3.Size = New Size(214, 52)
        Button3.TabIndex = 13
        Button3.Text = "Delete Submission (Ctrl + D)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_padrinan_255379
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
End Class
