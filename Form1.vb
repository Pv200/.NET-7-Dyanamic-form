Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1

    Public Sub New()

        InitializeComponent()

        Me.KeyPreview = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()


    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.C Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            Button2.PerformClick()
        End If

    End Sub
End Class
