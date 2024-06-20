Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Net.Http
Imports System.Windows.Forms

Public Class ViewSubmissionsForm
    Private currentSubmissionIndex As Integer = 0
    Private customFont As Font

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial submission
        LoadSubmission(currentSubmissionIndex)
        ApplyCustomFont()
    End Sub

    Private Sub ApplyCustomFont()
        ' Custom font
        Dim pfc As New PrivateFontCollection()
        Try
            pfc.AddFontFile("C:\Users\Mukul raj\source\repos\windowapp\font\font.ttf") ' Adjust path as necessary
            If pfc.Families.Length > 0 Then
                customFont = New Font(pfc.Families(0), 12, FontStyle.Regular) ' Use FontStyle.Regular to ensure no bold

                ' Apply custom font to all TextBox controls
                txtName.Font = customFont
                txtEmail.Font = customFont
                txtPhoneNumber.Font = customFont
                txtGithubLink.Font = customFont
                txtElapsedTime.Font = customFont

                ' Apply custom font to all Label controls
                lblTitle.Font = customFont
                lblName.Font = customFont
                lblEmail.Font = customFont
                lblPhoneNumber.Font = customFont
                lblGitHubLink.Font = customFont
                lblGitHubLink1.Font = customFont
                lblElapsedTime.Font = customFont
                lblElapsedTime1.Font = customFont

                ' Apply custom font to all Button controls
                btnPrevious.Font = customFont
                btnNext.Font = customFont
                btnEdit.Font = customFont
                btnDelete.Font = customFont
            Else
                MessageBox.Show("Failed to load custom font.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading custom font: {ex.Message}")
        End Try
    End Sub

    Private Function GetSubmissionCount() As Integer
        Dim apiUrl As String = "http://localhost:3000/count" ' Replace with your actual endpoint

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    Dim countResponse As Dictionary(Of String, Integer) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Integer))(json)

                    If countResponse.ContainsKey("count") Then
                        Return countResponse("count")
                    End If
                Else
                    MessageBox.Show($"Failed to fetch submission count. Status code: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try

        Return 0
    End Function

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
        Dim totalCount As Integer = GetSubmissionCount()
        If currentSubmissionIndex < totalCount - 1 Then
            currentSubmissionIndex += 1
            LoadSubmission(currentSubmissionIndex)
        Else
            MessageBox.Show("You are at the end of the submissions.")
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Deletion", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim apiUrl = $"http://localhost:3000/delete?index={currentSubmissionIndex}" ' Replace with your actual endpoint

            Try
                Using client As New HttpClient()
                    Dim response = Await client.DeleteAsync(apiUrl)

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully!")
                        ' Adjust the current index and reload submission
                        If currentSubmissionIndex > 0 Then
                            currentSubmissionIndex -= 1
                        End If

                        ' Fetch the count again after deletion
                        Dim totalCount As Integer = GetSubmissionCount()
                        If totalCount > 0 Then
                            LoadSubmission(currentSubmissionIndex)
                        Else
                            MessageBox.Show("No more submissions available.")
                            ' Clear the form fields if no submissions are left
                            ClearSubmissionDetails()
                        End If
                    Else
                        MessageBox.Show($"Failed to delete submission. Status code: {response.StatusCode}")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub ClearSubmissionDetails()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        txtGithubLink.Text = ""
        txtElapsedTime.Text = ""
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

    Private Sub ViewSubmissionsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Dispose of custom font when form is closing
        If customFont IsNot Nothing Then
            customFont.Dispose()
        End If
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

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Create a gradient brush for the form background
        Using brush As New LinearGradientBrush(Me.ClientRectangle, Color.LightBlue, Color.White, LinearGradientMode.Vertical)
            ' Paint the form background with the gradient brush
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using

        ' Call base implementation
        MyBase.OnPaint(e)
    End Sub

End Class
