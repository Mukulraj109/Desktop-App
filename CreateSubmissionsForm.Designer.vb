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
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubLink = New TextBox()
        btnStartStop = New Button()
        btnSubmit = New Button()
        PictureBox1 = New PictureBox()
        lblTimer = New TextBox()
        timer1 = New Timer(components)
        Nam = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(311, 55)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 23)
        Label1.TabIndex = 0
        Label1.Text = "Mukul Raj,Slidely Task 2-Create Submissions"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(264, 241)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 23)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(242, 323)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 23)
        Label5.TabIndex = 4
        Label5.Text = "Phone Num"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(242, 394)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 23)
        Label6.TabIndex = 5
        Label6.Text = "Github Link "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(251, 417)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 23)
        Label7.TabIndex = 6
        Label7.Text = "For Task 2"
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
        btnStartStop.Location = New Point(251, 498)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(259, 30)
        btnStartStop.TabIndex = 11
        btnStartStop.Text = "&Toggle Stopwatch(CTRL+T)"
        btnStartStop.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.Location = New Point(251, 561)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(581, 47)
        btnSubmit.TabIndex = 13
        btnSubmit.Text = "&Submit (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(997, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.DarkGray
        lblTimer.Location = New Point(567, 498)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(265, 30)
        lblTimer.TabIndex = 15
        ' 
        ' Nam
        ' 
        Nam.AutoSize = True
        Nam.Location = New Point(274, 162)
        Nam.Name = "Nam"
        Nam.Size = New Size(56, 23)
        Nam.TabIndex = 16
        Nam.Text = "Name"
        ' 
        ' createSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1145, 665)
        Controls.Add(Nam)
        Controls.Add(lblTimer)
        Controls.Add(PictureBox1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStop)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "createSubmissionsForm"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTimer As TextBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents Nam As Label

End Class
