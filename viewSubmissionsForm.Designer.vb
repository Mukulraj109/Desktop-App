<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewSubmissionsForm))
        Label1 = New Label()
        Label2 = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubLink = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        Label6 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGithubLink = New TextBox()
        lblElapsedTime = New Label()
        txtElapsedTime = New TextBox()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        btnDelete = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(401, 63)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(390, 28)
        Label1.TabIndex = 0
        Label1.Text = "Mukul raj, Slidely Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(205, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(205, 245)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(59, 28)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(205, 340)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(67, 28)
        lblPhoneNumber.TabIndex = 3
        lblPhoneNumber.Text = "Phone"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(205, 434)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(115, 28)
        lblGitHubLink.TabIndex = 4
        lblGitHubLink.Text = "GitHub Link"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.Location = New Point(30, 636)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(324, 52)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "&Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SkyBlue
        btnNext.Location = New Point(448, 636)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(343, 52)
        btnNext.TabIndex = 6
        btnNext.Text = "&Next (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(216, 462)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 28)
        Label6.TabIndex = 7
        Label6.Text = "For Task 2"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ActiveBorder
        txtName.Location = New Point(411, 153)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(307, 34)
        txtName.TabIndex = 8
        txtName.Text = "Mukul Raj"
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ActiveBorder
        txtEmail.Location = New Point(411, 239)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(307, 34)
        txtEmail.TabIndex = 9
        txtEmail.Text = "mukulraj756@gmail.com"
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = SystemColors.ActiveBorder
        txtPhoneNumber.Location = New Point(411, 340)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(307, 34)
        txtPhoneNumber.TabIndex = 10
        txtPhoneNumber.Text = "8210224305"
        txtPhoneNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.ActiveBorder
        txtGithubLink.Location = New Point(411, 434)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(307, 34)
        txtGithubLink.TabIndex = 11
        txtGithubLink.Text = "https://github.com/" & vbCrLf & "Mukulraj109"
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblElapsedTime
        ' 
        lblElapsedTime.AutoSize = True
        lblElapsedTime.Location = New Point(205, 529)
        lblElapsedTime.Name = "lblElapsedTime"
        lblElapsedTime.Size = New Size(104, 28)
        lblElapsedTime.TabIndex = 12
        lblElapsedTime.Text = "Stopwatch"
        ' 
        ' txtElapsedTime
        ' 
        txtElapsedTime.BackColor = SystemColors.ActiveBorder
        txtElapsedTime.Location = New Point(401, 523)
        txtElapsedTime.Name = "txtElapsedTime"
        txtElapsedTime.ReadOnly = True
        txtElapsedTime.Size = New Size(307, 34)
        txtElapsedTime.TabIndex = 13
        txtElapsedTime.Text = "00:01:19"
        txtElapsedTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(246, 557)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 28)
        Label8.TabIndex = 14
        Label8.Text = "time"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1162, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.Location = New Point(858, 636)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(343, 52)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete(CTRL+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' viewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1229, 722)
        Controls.Add(btnDelete)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(txtElapsedTime)
        Controls.Add(lblElapsedTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "viewSubmissionsForm"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents txtElapsedTime As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
End Class
