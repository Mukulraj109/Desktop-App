Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

Public Class EditSubmissionForm

    Private submission As SubmissionEntry ' Assuming SubmissionEntry is your data model
    Private currentSubmissionIndex As Integer

    Public Sub New(ByVal submission As SubmissionEntry, ByVal index As Integer)
        InitializeComponent()

        ' Initialize form with existing submission data
        Me.submission = submission
        Me.currentSubmissionIndex = index
        LoadSubmissionData()
        ApplyStyles()

        ' Ensure the form does not exceed the screen size
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
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

                ' Set form background color and rounded corners
                Me.BackColor = Color.LightBlue
                Me.FormBorderStyle = FormBorderStyle.None ' No border
                Me.Region = GetRoundedRegion(Me.ClientRectangle, 20) ' 20 is the radius of rounded corners
            Else
                MessageBox.Show("Failed to load custom font.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading custom font: {ex.Message}")
        End Try
    End Sub

    Private Function GetRoundedRegion(rect As Rectangle, radius As Integer) As Region
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()
        Return New Region(path)
    End Function

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validate user input for name, email, and phone number
        If Not ValidateInput() Then
            MessageBox.Show("Please enter valid data.")
            Return
        End If

        ' Validate phone number
        If Not ValidatePhoneNumber() Then
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

    Private Function ValidatePhoneNumber() As Boolean
        ' Trim the phone number text to remove leading and trailing whitespace
        Dim phoneNumber As String = txtPhoneNumber.Text.Trim()

        ' Check if the phone number is empty
        If String.IsNullOrWhiteSpace(phoneNumber) Then
            MessageBox.Show("Please enter a phone number.")
            Return False
        End If

        ' Example: Validate phone number format using a regular expression
        ' Modify the regex pattern based on your specific requirements
        ' Example: 10 digits or format like 123-456-7890
        If Not System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, "^(\d{10}|\d{3}-\d{3}-\d{4})$") Then
            MessageBox.Show("Please enter a valid phone number (e.g., 1234567890 or 123-456-7890).")
            Return False
        End If

        Return True
    End Function

    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        ' Adjust button appearance on mouse enter
        btnUpdate.Font = New Font(btnUpdate.Font.FontFamily, btnUpdate.Font.Size + 1, FontStyle.Bold)
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        ' Restore button appearance on mouse leave
        btnUpdate.Font = New Font(btnUpdate.Font.FontFamily, btnUpdate.Font.Size - 1, FontStyle.Regular)
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        ' Adjust button appearance on mouse enter
        btnCancel.Font = New Font(btnCancel.Font.FontFamily, btnCancel.Font.Size + 1, FontStyle.Bold)
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        ' Restore button appearance on mouse leave
        btnCancel.Font = New Font(btnCancel.Font.FontFamily, btnCancel.Font.Size - 1, FontStyle.Regular)
    End Sub

    Private Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
