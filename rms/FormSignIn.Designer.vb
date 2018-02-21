<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSigIn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSigIn))
        Me.PanelSignIn = New System.Windows.Forms.Panel()
        Me.ButtonSignIn = New System.Windows.Forms.Button()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.PanelSignInLabel = New System.Windows.Forms.Panel()
        Me.LabelSignIn = New System.Windows.Forms.Label()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.PanelCopyright = New System.Windows.Forms.Panel()
        Me.LinkGuideSite = New System.Windows.Forms.LinkLabel()
        Me.LabelGuide = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.ButtonDevelopers = New System.Windows.Forms.Button()
        Me.PanelRms = New System.Windows.Forms.Panel()
        Me.LabelRmsFull = New System.Windows.Forms.Label()
        Me.ToolTipSignIn = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelDescription = New System.Windows.Forms.Panel()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProviderSignIn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelSignIn.SuspendLayout()
        Me.PanelSignInLabel.SuspendLayout()
        Me.PanelCopyright.SuspendLayout()
        Me.PanelRms.SuspendLayout()
        Me.PanelDescription.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderSignIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSignIn
        '
        Me.PanelSignIn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSignIn.Controls.Add(Me.ButtonSignIn)
        Me.PanelSignIn.Controls.Add(Me.TextPassword)
        Me.PanelSignIn.Controls.Add(Me.LabelPassword)
        Me.PanelSignIn.Controls.Add(Me.PanelSignInLabel)
        Me.PanelSignIn.Controls.Add(Me.TextUsername)
        Me.PanelSignIn.Controls.Add(Me.LabelUsername)
        Me.PanelSignIn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSignIn.Location = New System.Drawing.Point(907, 212)
        Me.PanelSignIn.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelSignIn.Name = "PanelSignIn"
        Me.PanelSignIn.Size = New System.Drawing.Size(400, 346)
        Me.PanelSignIn.TabIndex = 0
        '
        'ButtonSignIn
        '
        Me.ButtonSignIn.AutoSize = True
        Me.ButtonSignIn.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSignIn.Location = New System.Drawing.Point(153, 292)
        Me.ButtonSignIn.Name = "ButtonSignIn"
        Me.ButtonSignIn.Size = New System.Drawing.Size(93, 36)
        Me.ButtonSignIn.TabIndex = 7
        Me.ButtonSignIn.Text = "Sign in"
        Me.ButtonSignIn.UseVisualStyleBackColor = True
        '
        'TextPassword
        '
        Me.TextPassword.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(49, 219)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(300, 27)
        Me.TextPassword.TabIndex = 6
        Me.ToolTipSignIn.SetToolTip(Me.TextPassword, "Enter password.")
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(44, 188)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(97, 28)
        Me.LabelPassword.TabIndex = 5
        Me.LabelPassword.Text = "Password"
        '
        'PanelSignInLabel
        '
        Me.PanelSignInLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelSignInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSignInLabel.Controls.Add(Me.LabelSignIn)
        Me.PanelSignInLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelSignInLabel.Name = "PanelSignInLabel"
        Me.PanelSignInLabel.Size = New System.Drawing.Size(400, 78)
        Me.PanelSignInLabel.TabIndex = 4
        '
        'LabelSignIn
        '
        Me.LabelSignIn.AutoSize = True
        Me.LabelSignIn.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSignIn.Location = New System.Drawing.Point(146, 15)
        Me.LabelSignIn.Name = "LabelSignIn"
        Me.LabelSignIn.Size = New System.Drawing.Size(106, 46)
        Me.LabelSignIn.TabIndex = 3
        Me.LabelSignIn.Text = "Sign in"
        '
        'TextUsername
        '
        Me.TextUsername.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsername.Location = New System.Drawing.Point(49, 125)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(300, 27)
        Me.TextUsername.TabIndex = 2
        Me.ToolTipSignIn.SetToolTip(Me.TextUsername, "Enter username.")
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(44, 94)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(103, 28)
        Me.LabelUsername.TabIndex = 1
        Me.LabelUsername.Text = "Username"
        '
        'PanelCopyright
        '
        Me.PanelCopyright.Controls.Add(Me.LinkGuideSite)
        Me.PanelCopyright.Controls.Add(Me.LabelGuide)
        Me.PanelCopyright.Controls.Add(Me.LabelCopyright)
        Me.PanelCopyright.Location = New System.Drawing.Point(-8, 631)
        Me.PanelCopyright.Name = "PanelCopyright"
        Me.PanelCopyright.Size = New System.Drawing.Size(1376, 126)
        Me.PanelCopyright.TabIndex = 1
        '
        'LinkGuideSite
        '
        Me.LinkGuideSite.AutoSize = True
        Me.LinkGuideSite.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkGuideSite.LinkColor = System.Drawing.Color.Black
        Me.LinkGuideSite.Location = New System.Drawing.Point(698, 53)
        Me.LinkGuideSite.Name = "LinkGuideSite"
        Me.LinkGuideSite.Size = New System.Drawing.Size(225, 33)
        Me.LinkGuideSite.TabIndex = 2
        Me.LinkGuideSite.TabStop = True
        Me.LinkGuideSite.Text = "Mr. Harsh Vardhan Pant."
        Me.LinkGuideSite.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LabelGuide
        '
        Me.LabelGuide.AutoSize = True
        Me.LabelGuide.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuide.Location = New System.Drawing.Point(444, 58)
        Me.LabelGuide.Name = "LabelGuide"
        Me.LabelGuide.Size = New System.Drawing.Size(259, 27)
        Me.LabelGuide.TabIndex = 1
        Me.LabelGuide.Text = "Developed under the guidance of"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New System.Drawing.Font("Alegreya Sans", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.Location = New System.Drawing.Point(482, 19)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(366, 32)
        Me.LabelCopyright.TabIndex = 0
        Me.LabelCopyright.Text = "© year Result Management System (rms.)"
        '
        'ButtonAbout
        '
        Me.ButtonAbout.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbout.Location = New System.Drawing.Point(1037, 29)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(75, 46)
        Me.ButtonAbout.TabIndex = 2
        Me.ButtonAbout.Text = "About"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'ButtonDevelopers
        '
        Me.ButtonDevelopers.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDevelopers.Location = New System.Drawing.Point(1125, 29)
        Me.ButtonDevelopers.Name = "ButtonDevelopers"
        Me.ButtonDevelopers.Size = New System.Drawing.Size(182, 46)
        Me.ButtonDevelopers.TabIndex = 3
        Me.ButtonDevelopers.Text = "Meet the Developers"
        Me.ButtonDevelopers.UseVisualStyleBackColor = True
        '
        'PanelRms
        '
        Me.PanelRms.BackColor = System.Drawing.SystemColors.Control
        Me.PanelRms.Controls.Add(Me.LabelRmsFull)
        Me.PanelRms.Controls.Add(Me.ButtonAbout)
        Me.PanelRms.Controls.Add(Me.ButtonDevelopers)
        Me.PanelRms.Location = New System.Drawing.Point(-5, 0)
        Me.PanelRms.Margin = New System.Windows.Forms.Padding(11, 3, 11, 3)
        Me.PanelRms.Name = "PanelRms"
        Me.PanelRms.Size = New System.Drawing.Size(1373, 100)
        Me.PanelRms.TabIndex = 4
        '
        'LabelRmsFull
        '
        Me.LabelRmsFull.AutoSize = True
        Me.LabelRmsFull.Font = New System.Drawing.Font("Helv Children", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRmsFull.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelRmsFull.Location = New System.Drawing.Point(41, 24)
        Me.LabelRmsFull.Name = "LabelRmsFull"
        Me.LabelRmsFull.Size = New System.Drawing.Size(855, 51)
        Me.LabelRmsFull.TabIndex = 5
        Me.LabelRmsFull.Text = "Result Management System"
        Me.LabelRmsFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelDescription
        '
        Me.PanelDescription.Controls.Add(Me.LabelDescription)
        Me.PanelDescription.Controls.Add(Me.PictureBox1)
        Me.PanelDescription.Location = New System.Drawing.Point(-5, 212)
        Me.PanelDescription.Name = "PanelDescription"
        Me.PanelDescription.Size = New System.Drawing.Size(906, 346)
        Me.PanelDescription.TabIndex = 5
        '
        'LabelDescription
        '
        Me.LabelDescription.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(176, 16)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(727, 201)
        Me.LabelDescription.TabIndex = 1
        Me.LabelDescription.Text = resources.GetString("LabelDescription.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 201)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ErrorProviderSignIn
        '
        Me.ErrorProviderSignIn.ContainerControl = Me
        '
        'FormSigIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelDescription)
        Me.Controls.Add(Me.PanelRms)
        Me.Controls.Add(Me.PanelCopyright)
        Me.Controls.Add(Me.PanelSignIn)
        Me.Font = New System.Drawing.Font("Alegreya Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "FormSigIn"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelSignIn.ResumeLayout(False)
        Me.PanelSignIn.PerformLayout()
        Me.PanelSignInLabel.ResumeLayout(False)
        Me.PanelSignInLabel.PerformLayout()
        Me.PanelCopyright.ResumeLayout(False)
        Me.PanelCopyright.PerformLayout()
        Me.PanelRms.ResumeLayout(False)
        Me.PanelRms.PerformLayout()
        Me.PanelDescription.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderSignIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSignIn As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents LabelSignIn As Label
    Friend WithEvents PanelSignInLabel As Panel
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonSignIn As Button
    Friend WithEvents PanelCopyright As Panel
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelGuide As Label
    Friend WithEvents LinkGuideSite As LinkLabel
    Friend WithEvents ButtonAbout As Button
    Friend WithEvents ButtonDevelopers As Button
    Friend WithEvents PanelRms As Panel
    Friend WithEvents LabelRmsFull As Label
    Friend WithEvents ToolTipSignIn As ToolTip
    Friend WithEvents PanelDescription As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelDescription As Label
    Friend WithEvents ErrorProviderSignIn As ErrorProvider
End Class
