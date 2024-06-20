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
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblGitHubLink = New Label()
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
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(182, 109)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(182, 214)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(182, 298)
        lblPhoneNumber.Margin = New Padding(4, 0, 4, 0)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.RightToLeft = RightToLeft.No
        lblPhoneNumber.Size = New Size(62, 25)
        lblPhoneNumber.TabIndex = 3
        lblPhoneNumber.Text = "Phone"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(182, 384)
        lblGitHubLink.Margin = New Padding(4, 0, 4, 0)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(99, 25)
        lblGitHubLink.TabIndex = 4
        lblGitHubLink.Text = "GitHubLink"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(434, 106)
        txtName.Margin = New Padding(4)
        txtName.Name = "txtName"
        txtName.Size = New Size(296, 31)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(434, 208)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(296, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(434, 292)
        txtPhoneNumber.Margin = New Padding(4)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(296, 31)
        txtPhoneNumber.TabIndex = 7
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(434, 378)
        txtGitHubLink.Margin = New Padding(4)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(296, 31)
        txtGitHubLink.TabIndex = 8
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.AntiqueWhite
        btnUpdate.Location = New Point(129, 534)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(313, 54)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DarkGray
        btnCancel.Location = New Point(563, 533)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(354, 55)
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
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "EditSubmissionForm"
        Text = "EditSubmissionForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
