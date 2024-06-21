Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class CreateSubmissionsForm

    Private stopwatch As New Stopwatch()
    Private customFont As Font

    Public Sub New()
        ' Form constructor
        InitializeComponent()
        ' Apply custom font and initialize timer
        ApplyCustomFont()
        InitializeTimer()
        ' Set form properties
        DoubleBuffered = True ' Reduce flickering
        SetStyle(ControlStyles.ResizeRedraw, True) ' Redraw on resize
        UpdateStyles() ' Update form styles
        AddHoverEffects(btnStartStop)
        AddHoverEffects(btnSubmit)
    End Sub

    Private Sub ApplyCustomFont()
        ' Custom font
        Dim pfc As New PrivateFontCollection()
        Try
            pfc.AddFontFile("C:\Users\Mukul raj\source\repos\windowapp\font\font.ttf") ' Adjust path as necessary
            If pfc.Families.Length > 0 Then
                customFont = New Font(pfc.Families(0), 12, FontStyle.Regular) ' Use FontStyle.Regular for normal font weight

                ' Apply custom font to all TextBox controls
                txtName.Font = customFont
                txtEmail.Font = customFont
                txtPhoneNumber.Font = customFont
                txtGitHubLink.Font = customFont

                ' Apply custom font to all Label controls
                lblTitle.Font = customFont
                lblName.Font = customFont
                lblEmail.Font = customFont
                lblPhoneNumber.Font = customFont
                lblGitHubLink.Font = customFont

                ' Apply custom font to all Button controls
                btnStartStop.Font = customFont
                btnSubmit.Font = customFont
            Else
                MessageBox.Show("Failed to load custom font.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading custom font: {ex.Message}")
        End Try

        ' Apply custom font to timer label
        lblTimer.Font = New Font(customFont.FontFamily, 24, FontStyle.Bold) ' Example size and style for timer
    End Sub

    Private Sub AddHoverEffects(button As Button)
        ' Add MouseEnter and MouseLeave event handlers
        AddHandler button.MouseEnter, AddressOf Button_MouseEnter
        AddHandler button.MouseLeave, AddressOf Button_MouseLeave
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        ' Adjust button appearance on mouse enter
        Dim button As Button = DirectCast(sender, Button)
        button.Font = New Font(customFont.FontFamily, customFont.Size + 1, FontStyle.Bold)

    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        ' Restore button appearance on mouse leave
        Dim button As Button = DirectCast(sender, Button)
        button.Font = customFont

    End Sub

    Private Sub btnStartStop_MouseEnter(sender As Object, e As EventArgs) Handles btnStartStop.MouseEnter
        ' Adjust button appearance on mouse enter (simulate hover effect)
        btnStartStop.Font = New Font(customFont.FontFamily, customFont.Size + 1, FontStyle.Bold)

    End Sub

    Private Sub btnStartStop_MouseLeave(sender As Object, e As EventArgs) Handles btnStartStop.MouseLeave
        ' Restore button appearance on mouse leave
        btnStartStop.Font = customFont
    End Sub

    Private Function ValidateInput() As Boolean
        ' Validate email format
        If Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.")
            Return False
        End If

        ' Validate other required fields (e.g., not empty)
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name.")
            Return False
        End If

        ' Additional validation rules can be added here (e.g., phone number format)

        Return True
    End Function


    Private Sub InitializeTimer()
        ' Initialize timer
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

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate user input
        If Not ValidateInput() Then
            Return
        End If

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


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Create a gradient brush for the form background
        Using brush As New LinearGradientBrush(ClientRectangle, Color.LightBlue, Color.White, LinearGradientMode.Vertical)
            ' Paint the form background with the gradient brush
            e.Graphics.FillRectangle(brush, ClientRectangle)
        End Using

        ' Create rounded corners
        Using path As New GraphicsPath()
            Dim rect As New Rectangle(0, 0, Width, Height)
            Dim radius As Integer = 20 ' Adjust the radius as per your preference
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
            path.CloseFigure()

            ' Set the region with the rounded rectangle path
            Region = New Region(path)
        End Using

        ' Call base implementation
        MyBase.OnPaint(e)
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

    Private Sub createSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
