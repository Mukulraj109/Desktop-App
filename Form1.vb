﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keyboard shortcuts
        btnViewSubmissions.Text = "&View Submissions"
        btnCreateSubmissions.Text = "&Create Submissions"
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