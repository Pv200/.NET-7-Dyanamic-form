Imports System.ComponentModel.DataAnnotations
Imports System.Net.Mail
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form2
    Dim ss, tt, vv As Integer
    Public Sub New()

        InitializeComponent()

        Me.KeyPreview = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If (vv > 59) Then
            vv = 0
            tt = tt + 1

        End If

    End Sub

    Private Async Sub SubmitForm()
        Dim submission = New With {
            .name = TextBox1.Text,
            .phone = TextBox2.Text,
            .email = TextBox3.Text,
            .link = TextBox4.Text,
            .time = Label5.Text
        }

        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response = Await client.PostAsync("http://localhost:3000/api/submit", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission successful")
            Catch ex As Exception
                MessageBox.Show("Error submitting form: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        SubmitForm()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim name As String




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim phone As Integer

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim mail As String
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim link As String

    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.T Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick()
        End If

    End Sub
End Class