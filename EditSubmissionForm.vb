Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Drawing
Imports System.Drawing.Text



Public Class EditSubmissionForm

    Private submission As SubmissionEntry ' Assuming SubmissionEntry is your data model
    Private currentSubmissionIndex As Integer
    Private Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyStyles()
    End Sub
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

    Private Sub ApplyStyles()
        ' Custom font
        Dim pfc As New PrivateFontCollection()
        Try
            pfc.AddFontFile("C:\Users\Mukul raj\source\repos\windowapp\font\font.ttf") ' Adjust path as necessary
            If pfc.Families.Length > 0 Then
                Dim customFont As New Font(pfc.Families(0), 12)

                ' Apply custom font to controls
                txtName.Font = customFont
                txtEmail.Font = customFont
                txtPhoneNumber.Font = customFont
                txtGitHubLink.Font = customFont
                btnUpdate.Font = customFont
                btnCancel.Font = customFont
                lblEmail.Font = customFont
                lblName.Font = customFont
                lblGitHubLink.Font = customFont
                lblPhoneNumber.Font = customFont

                ' Custom colors
                Dim customBackColor As Color = Color.FromArgb(255, 255, 192) ' Light yellow
                Dim customForeColor As Color = Color.FromArgb(0, 0, 128) ' Dark blue

                ' Apply custom colors
                txtName.BackColor = customBackColor
                txtEmail.BackColor = customBackColor
                txtPhoneNumber.BackColor = customBackColor
                txtGitHubLink.BackColor = customBackColor

                txtName.ForeColor = customForeColor
                txtEmail.ForeColor = customForeColor
                txtPhoneNumber.ForeColor = customForeColor
                txtGitHubLink.ForeColor = customForeColor

                ' Set form background color
                Me.BackColor = Color.LightBlue
            Else
                MessageBox.Show("Failed to load custom font.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading custom font: {ex.Message}")
        End Try
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
