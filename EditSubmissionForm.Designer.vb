<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSubmissionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSubmissionForm))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Email = New Label()
        Phone = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHubLink = New TextBox()
        btnUpdate = New Button()
        btnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1081, 1)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(182, 109)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(182, 214)
        Email.Margin = New Padding(4, 0, 4, 0)
        Email.Name = "Email"
        Email.Size = New Size(54, 25)
        Email.TabIndex = 2
        Email.Text = "Email"
        ' 
        ' Phone
        ' 
        Phone.AutoSize = True
        Phone.Location = New Point(182, 298)
        Phone.Margin = New Padding(4, 0, 4, 0)
        Phone.Name = "Phone"
        Phone.RightToLeft = RightToLeft.No
        Phone.Size = New Size(62, 25)
        Phone.TabIndex = 3
        Phone.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(182, 384)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 4
        Label4.Text = "GitHubLink"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(434, 106)
        txtName.Margin = New Padding(4, 4, 4, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(296, 31)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(434, 208)
        txtEmail.Margin = New Padding(4, 4, 4, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(296, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(434, 292)
        txtPhoneNumber.Margin = New Padding(4, 4, 4, 4)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(296, 31)
        txtPhoneNumber.TabIndex = 7
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(434, 378)
        txtGitHubLink.Margin = New Padding(4, 4, 4, 4)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(296, 31)
        txtGitHubLink.TabIndex = 8
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.AntiqueWhite
        btnUpdate.Location = New Point(182, 483)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(302, 32)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DarkGray
        btnCancel.Location = New Point(569, 483)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(277, 32)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EditSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1144, 708)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Phone)
        Controls.Add(Email)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "EditSubmissionForm"
        Text = "EditSubmissionForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Email As Label
    Friend WithEvents Phone As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
