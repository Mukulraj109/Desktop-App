<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class createSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createSubmissionsForm))
        lblTitle = New Label()
        Label2 = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubLink = New Label()
        lblGitHubLink1 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubLink = New TextBox()
        btnStartStop = New Button()
        btnSubmit = New Button()
        PictureBox1 = New PictureBox()
        lblTimer = New TextBox()
        timer1 = New Timer(components)
        lblName = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(311, 55)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(342, 23)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Mukul Raj,Slidely Task 2-Create Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(274, 139)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 23)
        Label2.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(264, 241)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(51, 23)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(242, 323)
        lblPhoneNumber.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(102, 23)
        lblPhoneNumber.TabIndex = 4
        lblPhoneNumber.Text = "Phone Num"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(242, 394)
        lblGitHubLink.Margin = New Padding(4, 0, 4, 0)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(102, 23)
        lblGitHubLink.TabIndex = 5
        lblGitHubLink.Text = "Github Link "
        ' 
        ' lblGitHubLink1
        ' 
        lblGitHubLink1.AutoSize = True
        lblGitHubLink1.Location = New Point(251, 417)
        lblGitHubLink1.Margin = New Padding(4, 0, 4, 0)
        lblGitHubLink1.Name = "lblGitHubLink1"
        lblGitHubLink1.Size = New Size(84, 23)
        lblGitHubLink1.TabIndex = 6
        lblGitHubLink1.Text = "For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(444, 155)
        txtName.Name = "txtName"
        txtName.Size = New Size(244, 30)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(444, 241)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(244, 30)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(444, 317)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(244, 30)
        txtPhoneNumber.TabIndex = 9
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(444, 394)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(244, 30)
        txtGitHubLink.TabIndex = 10
        ' 
        ' btnStartStop
        ' 
        btnStartStop.BackColor = Color.Khaki
        btnStartStop.Location = New Point(201, 498)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(278, 66)
        btnStartStop.TabIndex = 11
        btnStartStop.Text = "&Toggle Stopwatch(CTRL+T)"
        btnStartStop.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.Location = New Point(176, 586)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(539, 47)
        btnSubmit.TabIndex = 13
        btnSubmit.Text = "&Submit (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1007, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.DarkGray
        lblTimer.Location = New Point(541, 498)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(147, 30)
        lblTimer.TabIndex = 15
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(274, 162)
        lblName.Name = "lblName"
        lblName.Size = New Size(56, 23)
        lblName.TabIndex = 16
        lblName.Text = "Name"
        ' 
        ' createSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 660)
        Controls.Add(lblName)
        Controls.Add(lblTimer)
        Controls.Add(PictureBox1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStop)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGitHubLink1)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(Label2)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "createSubmissionsForm"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents lblGitHubLink1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTimer As TextBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents lblName As Label

End Class
