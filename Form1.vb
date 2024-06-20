Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply custom font and other initializations
        ApplyCustomFont()

        ' Set button texts
        btnViewSubmissions.Text = "&View Submissions"
        btnCreateSubmissions.Text = "&Create Submissions"
    End Sub

    Private Sub ApplyCustomFont()
        ' Custom font
        Dim pfc As New PrivateFontCollection()
        Try
            pfc.AddFontFile("C:\Users\Mukul raj\source\repos\windowapp\font\font.ttf") ' Adjust path as necessary
            If pfc.Families.Length > 0 Then
                Dim customFont As New Font(pfc.Families(0), 12, FontStyle.Regular) ' Use FontStyle.Regular to ensure no bold

                ' Apply custom font to form and controls
                Me.Font = customFont
                btnViewSubmissions.Font = customFont
                btnCreateSubmissions.Font = customFont
            Else
                MessageBox.Show("Failed to load custom font.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading custom font: {ex.Message}")
        End Try
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Create a gradient brush for the form background
        Using brush As New LinearGradientBrush(Me.ClientRectangle, Color.LightBlue, Color.White, LinearGradientMode.Vertical)
            ' Paint the form background with the gradient brush
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using

        ' Call base implementation
        MyBase.OnPaint(e)
    End Sub

    Private Sub btnViewSubmission_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New viewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmissions.Click
        Dim createSubmissionForm As New createSubmissionsForm()
        createSubmissionForm.ShowDialog()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Handle keyboard shortcuts for opening forms
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSubmission_Click(Nothing, Nothing)
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnCreateSubmission_Click(Nothing, Nothing)
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
