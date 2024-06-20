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
        lblTitle = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubLink = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        lblGitHubLink1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGithubLink = New TextBox()
        lblElapsedTime = New Label()
        txtElapsedTime = New TextBox()
        lblElapsedTime1 = New Label()
        PictureBox1 = New PictureBox()
        btnDelete = New Button()
        btnEdit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(401, 63)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(390, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Mukul raj, Slidely Task 2 - View Submissions"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(205, 156)
        lblName.Name = "lblName"
        lblName.Size = New Size(64, 28)
        lblName.TabIndex = 1
        lblName.Text = "Name"
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
        btnPrevious.Location = New Point(30, 643)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(222, 38)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "&Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SkyBlue
        btnNext.Location = New Point(337, 643)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(268, 38)
        btnNext.TabIndex = 6
        btnNext.Text = "&Next (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblGitHubLink1
        ' 
        lblGitHubLink1.AutoSize = True
        lblGitHubLink1.Location = New Point(216, 462)
        lblGitHubLink1.Name = "lblGitHubLink1"
        lblGitHubLink1.Size = New Size(98, 28)
        lblGitHubLink1.TabIndex = 7
        lblGitHubLink1.Text = "For Task 2"
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
        ' lblElapsedTime1
        ' 
        lblElapsedTime1.AutoSize = True
        lblElapsedTime1.Location = New Point(246, 557)
        lblElapsedTime1.Name = "lblElapsedTime1"
        lblElapsedTime1.Size = New Size(51, 28)
        lblElapsedTime1.TabIndex = 14
        lblElapsedTime1.Text = "time"
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
        btnDelete.Location = New Point(640, 643)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(275, 38)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete(CTRL+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.DarkOrange
        btnEdit.Location = New Point(946, 636)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(271, 45)
        btnEdit.TabIndex = 17
        btnEdit.Text = "Update(CTRL+U)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' viewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1229, 722)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(PictureBox1)
        Controls.Add(lblElapsedTime1)
        Controls.Add(txtElapsedTime)
        Controls.Add(lblElapsedTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGitHubLink1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "viewSubmissionsForm"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblGitHubLink1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents txtElapsedTime As TextBox
    Friend WithEvents lblElapsedTime1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
