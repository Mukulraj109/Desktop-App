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

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
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
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
