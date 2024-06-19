Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Form3

    Private index As Integer = 0 ' Initialize index at the class level

    ' Form constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        ' Set KeyPreview to True to allow the form to handle key events
        Me.KeyPreview = True
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/api/count")

            If response.IsSuccessStatusCode Then
                Dim content As String = Await response.Content.ReadAsStringAsync()
                Dim countObject As JObject = JObject.Parse(content)
                Dim count As Integer = countObject("count")

                If count > 0 Then
                    If index >= count Then
                        MessageBox.Show("Reached end of submissions", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        index = 0 ' Reset index to start from beginning
                        Return
                    End If

                    response = Await client.GetAsync($"http://localhost:3000/api/read?index={index}")

                    If response.IsSuccessStatusCode Then
                        content = Await response.Content.ReadAsStringAsync()
                        Dim submission As JObject = JObject.Parse(content)

                        ' Update TextBoxes with fetched data
                        TextBox2.Text = submission("name").ToString()
                        TextBox3.Text = submission("phone").ToString()
                        TextBox4.Text = submission("email").ToString()
                        TextBox5.Text = submission("link").ToString()
                        TextBox6.Text = submission("time").ToString()

                        ' Increment index for next fetch
                        index += 1
                    Else
                        MessageBox.Show("Failed to fetch submission details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("No submissions found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Failed to get submission count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/api/count")

            If response.IsSuccessStatusCode Then
                Dim content As String = Await response.Content.ReadAsStringAsync()
                Dim countObject As JObject = JObject.Parse(content)
                Dim count As Integer = countObject("count")

                If count > 0 Then
                    Dim deleteIndex As Integer = index - 1 ' Delete the previously fetched submission

                    response = Await client.DeleteAsync($"http://localhost:3000/api/delete?index={deleteIndex}")

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear TextBoxes after deletion
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox5.Clear()
                        TextBox6.Clear()

                        ' Decrement index after deletion
                        index -= 1
                    Else
                        MessageBox.Show("Failed to delete submission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("No submissions found to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Failed to get submission count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Update submission at current index (index - 1 because index was already incremented in Button1_Click)
        Try
            Dim client As New HttpClient()

            ' Fetch submission count
            Dim countResponse As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/api/count")

            If countResponse.IsSuccessStatusCode Then
                Dim countContent As String = Await countResponse.Content.ReadAsStringAsync()
                Dim countObject As JObject = JObject.Parse(countContent)
                Dim count As Integer = countObject("count")

                If count > 0 Then
                    Dim updateIndex As Integer = index - 1 ' Update the previously fetched submission

                    ' Fetch last submission data
                    Dim readResponse As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/api/read?index={updateIndex}")

                    If readResponse.IsSuccessStatusCode Then
                        Dim content As String = Await readResponse.Content.ReadAsStringAsync()
                        Dim submission As JObject = JObject.Parse(content)

                        ' Update submission data with new values
                        submission("name") = TextBox2.Text
                        submission("phone") = TextBox3.Text
                        submission("email") = TextBox4.Text
                        submission("link") = TextBox5.Text
                        submission("time") = TextBox6.Text

                        ' Send updated submission data
                        Dim updateResponse As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/api/update?index={updateIndex}", New StringContent(submission.ToString(), System.Text.Encoding.UTF8, "application/json"))

                        If updateResponse.IsSuccessStatusCode Then
                            MessageBox.Show("Submission updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show($"Failed to update submission: {updateResponse.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Failed to fetch submission details for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("No submissions found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Failed to get submission count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle shortcut keys
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            Button2.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            Button3.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Handle text changed event if needed
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ' Handle text changed event if needed
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ' Handle text changed event if needed
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ' Handle text changed event if needed
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ' Handle text changed event if needed
    End Sub
End Class
