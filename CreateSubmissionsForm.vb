Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class CreateSubmissionsForm

    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize timer in Load event
        timer1 = New Timer()
        AddHandler timer1.Tick, AddressOf Timer1_Tick
        timer1.Interval = 1000 ' 1 second
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        lblTimer.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer1.Stop()
        Else
            stopwatch.Start()
            timer1.Start()
        End If
    End Sub

    Private  Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Create a new submission entry
        Dim submission As New SubmissionEntry(
            txtName.Text,
            txtEmail.Text,
            txtPhoneNumber.Text,
            txtGitHubLink.Text,
            stopwatch.Elapsed
        )
        ' Prepare JSON payload
        Dim jsonPayload As String = $"{{ ""name"": ""{submission.Name}"", ""email"": ""{submission.Email}"", ""phone"": ""{submission.Phone}"", ""github_link"": ""{submission.GitHub_Link}"", ""stopwatch_time"": ""{stopwatch.Elapsed.ToString("hh\:mm\:ss")}"", ""createdAt"": ""{DateTime.Now.ToString("yyyy-MM-ddTHH\:mm\:ssZ")}"", ""updatedAt"": ""{DateTime.Now.ToString("yyyy-MM-ddTHH\:mm\:ssZ")}"", ""deletedAt"": ""null"" }}"


        ' Send HTTP POST request to backend
        Dim response As HttpResponseMessage = Nothing
        Using httpClient As New HttpClient()
            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")
            Try
                response = Await httpClient.PostAsync("http://localhost:3000/submit", content)
                response.EnsureSuccessStatusCode() ' Ensure success status code
                MessageBox.Show("Submission created successfully!")
                ResetForm()
            Catch ex As HttpRequestException
                ' Handle exception if request fails
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End Using

        ' Check response status
        If response IsNot Nothing AndAlso response.IsSuccessStatusCode Then
            ' Submission successful
            MessageBox.Show("Submission created successfully!")
        Else
            ' Error handling if submission fails
            MessageBox.Show("Failed to submit the form. Please try again.")
        End If

        ' Reset fields and stopwatch
        ResetForm()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Handle Ctrl+S for submitting the form
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If

        ' Handle Ctrl+T for starting/stopping the stopwatch
        If keyData = (Keys.Control Or Keys.T) Then
            btnStartStop.PerformClick()
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub ResetForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtGitHubLink.Clear()
        stopwatch.Reset()
        lblTimer.Text = "00:00:00"
    End Sub
End Class
