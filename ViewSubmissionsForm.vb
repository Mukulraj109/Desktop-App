Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ViewSubmissionsForm
    Private currentSubmissionIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial submission
        LoadSubmission(currentSubmissionIndex)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Dim apiUrl As String = $"http://localhost:3000/read?index={index}" ' Replace with your actual endpoint

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    Dim submission As SubmissionEntry = JsonConvert.DeserializeObject(Of SubmissionEntry)(json)

                    ' Display submission details
                    DisplaySubmission(submission)
                Else
                    MessageBox.Show($"Failed to fetch submission. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplaySubmission(submission As SubmissionEntry)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhoneNumber.Text = submission.Phone
        txtGithubLink.Text = submission.GitHub_Link
        txtElapsedTime.Text = "Time: " & submission.Stopwatch_Time.ToString()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            LoadSubmission(currentSubmissionIndex)
        Else
            MessageBox.Show("You are at the beginning of the submissions.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentSubmissionIndex += 1
        LoadSubmission(currentSubmissionIndex)
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Deletion", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim apiUrl = $"http://localhost:3000/delete?index={currentSubmissionIndex}" ' Replace with your actual endpoint

            Try
                Using client As New HttpClient
                    Dim response = Await client.DeleteAsync(apiUrl)

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully!")
                        ' Adjust the current index and reload submission
                        If currentSubmissionIndex > 0 Then
                            currentSubmissionIndex -= 1
                        End If
                        LoadSubmission(currentSubmissionIndex)
                    Else
                        MessageBox.Show($"Failed to delete submission. Status code: {response.StatusCode}")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            ' Fetch current submission based on currentSubmissionIndex
            Dim apiUrl As String = $"http://localhost:3000/read?index={currentSubmissionIndex}" ' Replace with actual endpoint

            Using client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    Dim submission As SubmissionEntry = JsonConvert.DeserializeObject(Of SubmissionEntry)(json)

                    ' Open edit form for current submission
                    Dim editForm As New EditSubmissionForm(submission, currentSubmissionIndex)
                    If editForm.ShowDialog() = DialogResult.OK Then
                        ' Reload submission after editing if it was updated
                        LoadSubmission(currentSubmissionIndex)
                    End If
                Else
                    MessageBox.Show($"Failed to fetch submission details for editing. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub


    Private Sub EnableEditDeleteButtons()
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Handle Ctrl+V for all TextBox controls
        If keyData = (Keys.Control Or Keys.V) Then
            If ActiveControl IsNot Nothing AndAlso TypeOf ActiveControl Is TextBox Then
                DirectCast(ActiveControl, TextBox).Paste()
                Return True
            End If
        End If

        ' Handle other keyboard shortcuts
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.D) Then
            btnDelete.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
