Imports Newtonsoft.Json
Imports System.Net.Http

Public Class EditSubmissionForm

    Private submission As SubmissionEntry ' Assuming SubmissionEntry is your data model
    Private currentSubmissionIndex As Integer

    Public Sub New(ByVal submission As SubmissionEntry, ByVal index As Integer)
        InitializeComponent()

        ' Initialize form with existing submission data
        Me.submission = submission
        Me.currentSubmissionIndex = index
        LoadSubmissionData()
    End Sub

    Private Sub LoadSubmissionData()
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhoneNumber.Text = submission.Phone
        txtGitHubLink.Text = submission.GitHub_Link
    End Sub

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validate user input
        If Not ValidateInput() Then
            MessageBox.Show("Please enter valid data.")
            Return
        End If

        ' Update submission with new data
        submission.Name = txtName.Text
        submission.Email = txtEmail.Text
        submission.Phone = txtPhoneNumber.Text
        submission.GitHub_Link = txtGitHubLink.Text

        ' Create a new anonymous object to ensure all properties are included in the payload
        Dim updatePayload As New With {
            .name = submission.Name,
            .email = submission.Email,
            .phone = submission.Phone,
            .github_link = submission.GitHub_Link,
            .stopwatch_time = submission.Stopwatch_Time
        }

        ' Perform update logic here (e.g., send update request to backend)
        Dim apiUrl As String = $"http://localhost:3000/edit?index={currentSubmissionIndex}" ' Replace with your actual endpoint
        Dim jsonPayload As String = JsonConvert.SerializeObject(updatePayload)

        Using httpClient As New HttpClient()
            Dim content As New StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json")
            Try
                Dim response As HttpResponseMessage = Await httpClient.PutAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission updated successfully!")
                    DialogResult = DialogResult.OK ' Set DialogResult to OK if update succeeds
                    Close()
                Else
                    MessageBox.Show($"Failed to update submission. Status code: {response.StatusCode}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close() ' Simply close the form if cancel button is clicked
    End Sub

    Private Function ValidateInput() As Boolean
        ' Add your validation logic here (e.g., email format, phone number format, etc.)
        ' Example validation for email format
        If Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            Return False
        End If

        ' Additional validation logic can be added here
        Return True
    End Function
End Class
