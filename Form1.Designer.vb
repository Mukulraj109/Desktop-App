<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnViewSubmissions = New Button()
        btnCreateSubmissions = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Khaki
        btnViewSubmissions.Cursor = Cursors.Hand
        btnViewSubmissions.Location = New Point(167, 123)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(345, 54)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "&View Submissions(CTRL+V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmissions
        ' 
        btnCreateSubmissions.BackColor = Color.LightSkyBlue
        btnCreateSubmissions.Location = New Point(167, 287)
        btnCreateSubmissions.Name = "btnCreateSubmissions"
        btnCreateSubmissions.Size = New Size(345, 52)
        btnCreateSubmissions.TabIndex = 1
        btnCreateSubmissions.Text = "&Create Submissions (CTRL +N)"
        btnCreateSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(190, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 20)
        Label1.TabIndex = 2
        Label1.Text = "Mukul Raj , Slidely Task 2-Slidely Form App"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(704, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 51)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(762, 447)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnCreateSubmissions)
        Controls.Add(btnViewSubmissions)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmissions As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
