Public Class SubmissionEntry
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub_Link As String
    Public Property Stopwatch_Time As TimeSpan

    Public Sub New(name As String, email As String, phoneNumber As String, gitHubLink As String, elapsedTime As TimeSpan)
        Me.Name = name
        Me.Email = email
        Me.Phone = phoneNumber
        Me.GitHub_Link = gitHubLink
        Me.Stopwatch_Time = elapsedTime
    End Sub
End Class
