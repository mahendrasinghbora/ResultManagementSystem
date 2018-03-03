<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditProfileExamCell
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditProfileExamCell))
        Me.ErrorProviderEditProfile = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelEditProfilePanel = New System.Windows.Forms.Label()
        Me.ContextMenuStripEditUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonSelectImage = New System.Windows.Forms.Button()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.PanelEditProfile = New System.Windows.Forms.Panel()
        Me.LabelThumbnail = New System.Windows.Forms.Label()
        Me.PictureBoxThumbnail = New System.Windows.Forms.PictureBox()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.ButtonEditProfile = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.PanelEditProfileLabel = New System.Windows.Forms.Panel()
        Me.LabelEditProfile = New System.Windows.Forms.Label()
        Me.LabelAddUsername = New System.Windows.Forms.Label()
        Me.OpenFileDialogEditProfile = New System.Windows.Forms.OpenFileDialog()
        Me.PanelPage = New System.Windows.Forms.Panel()
        CType(Me.ErrorProviderEditProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEditUsers.SuspendLayout()
        Me.PanelEditProfile.SuspendLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEditProfileLabel.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProviderEditProfile
        '
        Me.ErrorProviderEditProfile.ContainerControl = Me
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelEditProfilePanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 6
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1073, 5)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 5
        Me.PictureBoxUser.TabStop = False
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Image = CType(resources.GetObject("LabelUsername.Image"), System.Drawing.Image)
        Me.LabelUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelUsername.Location = New System.Drawing.Point(1103, 11)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(135, 34)
        Me.LabelUsername.TabIndex = 2
        Me.LabelUsername.Text = "Username      "
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Location = New System.Drawing.Point(165, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelEditProfilePanel
        '
        Me.LabelEditProfilePanel.AutoSize = True
        Me.LabelEditProfilePanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditProfilePanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelEditProfilePanel.Name = "LabelEditProfilePanel"
        Me.LabelEditProfilePanel.Size = New System.Drawing.Size(129, 39)
        Me.LabelEditProfilePanel.TabIndex = 0
        Me.LabelEditProfilePanel.Text = "Edit Profile"
        '
        'ContextMenuStripEditUsers
        '
        Me.ContextMenuStripEditUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripEditUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripEditUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripEditUsers.Size = New System.Drawing.Size(184, 76)
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ButtonSelectImage
        '
        Me.ButtonSelectImage.AutoSize = True
        Me.ButtonSelectImage.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelectImage.Location = New System.Drawing.Point(573, 384)
        Me.ButtonSelectImage.Name = "ButtonSelectImage"
        Me.ButtonSelectImage.Size = New System.Drawing.Size(126, 36)
        Me.ButtonSelectImage.TabIndex = 13
        Me.ButtonSelectImage.Text = "Select image"
        Me.ButtonSelectImage.UseVisualStyleBackColor = True
        '
        'TextUsername
        '
        Me.TextUsername.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsername.Location = New System.Drawing.Point(52, 175)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(300, 27)
        Me.TextUsername.TabIndex = 21
        '
        'PanelEditProfile
        '
        Me.PanelEditProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelEditProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEditProfile.Controls.Add(Me.ButtonSelectImage)
        Me.PanelEditProfile.Controls.Add(Me.TextUsername)
        Me.PanelEditProfile.Controls.Add(Me.LabelThumbnail)
        Me.PanelEditProfile.Controls.Add(Me.PictureBoxThumbnail)
        Me.PanelEditProfile.Controls.Add(Me.TextLastName)
        Me.PanelEditProfile.Controls.Add(Me.LabelLastName)
        Me.PanelEditProfile.Controls.Add(Me.ButtonEditProfile)
        Me.PanelEditProfile.Controls.Add(Me.TextFirstName)
        Me.PanelEditProfile.Controls.Add(Me.LabelFirstName)
        Me.PanelEditProfile.Controls.Add(Me.PanelEditProfileLabel)
        Me.PanelEditProfile.Controls.Add(Me.LabelAddUsername)
        Me.PanelEditProfile.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEditProfile.Location = New System.Drawing.Point(289, 78)
        Me.PanelEditProfile.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelEditProfile.Name = "PanelEditProfile"
        Me.PanelEditProfile.Size = New System.Drawing.Size(789, 476)
        Me.PanelEditProfile.TabIndex = 5
        '
        'LabelThumbnail
        '
        Me.LabelThumbnail.AutoSize = True
        Me.LabelThumbnail.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelThumbnail.Location = New System.Drawing.Point(554, 131)
        Me.LabelThumbnail.Name = "LabelThumbnail"
        Me.LabelThumbnail.Size = New System.Drawing.Size(165, 28)
        Me.LabelThumbnail.TabIndex = 11
        Me.LabelThumbnail.Text = "User's Thumbnail"
        '
        'PictureBoxThumbnail
        '
        Me.PictureBoxThumbnail.BackColor = System.Drawing.Color.Azure
        Me.PictureBoxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxThumbnail.Image = CType(resources.GetObject("PictureBoxThumbnail.Image"), System.Drawing.Image)
        Me.PictureBoxThumbnail.Location = New System.Drawing.Point(562, 177)
        Me.PictureBoxThumbnail.Name = "PictureBoxThumbnail"
        Me.PictureBoxThumbnail.Size = New System.Drawing.Size(149, 182)
        Me.PictureBoxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxThumbnail.TabIndex = 10
        Me.PictureBoxThumbnail.TabStop = False
        '
        'TextLastName
        '
        Me.TextLastName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLastName.Location = New System.Drawing.Point(52, 332)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(300, 27)
        Me.TextLastName.TabIndex = 9
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(47, 293)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(104, 28)
        Me.LabelLastName.TabIndex = 8
        Me.LabelLastName.Text = "Last Name"
        '
        'ButtonEditProfile
        '
        Me.ButtonEditProfile.AutoSize = True
        Me.ButtonEditProfile.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditProfile.Location = New System.Drawing.Point(52, 419)
        Me.ButtonEditProfile.Name = "ButtonEditProfile"
        Me.ButtonEditProfile.Size = New System.Drawing.Size(128, 39)
        Me.ButtonEditProfile.TabIndex = 7
        Me.ButtonEditProfile.Text = "Update"
        Me.ButtonEditProfile.UseVisualStyleBackColor = True
        '
        'TextFirstName
        '
        Me.TextFirstName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFirstName.Location = New System.Drawing.Point(52, 255)
        Me.TextFirstName.Name = "TextFirstName"
        Me.TextFirstName.Size = New System.Drawing.Size(300, 27)
        Me.TextFirstName.TabIndex = 6
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(47, 216)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(108, 28)
        Me.LabelFirstName.TabIndex = 5
        Me.LabelFirstName.Text = "First Name"
        '
        'PanelEditProfileLabel
        '
        Me.PanelEditProfileLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelEditProfileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEditProfileLabel.Controls.Add(Me.LabelEditProfile)
        Me.PanelEditProfileLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelEditProfileLabel.Name = "PanelEditProfileLabel"
        Me.PanelEditProfileLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelEditProfileLabel.TabIndex = 4
        '
        'LabelEditProfile
        '
        Me.LabelEditProfile.AutoSize = True
        Me.LabelEditProfile.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditProfile.Location = New System.Drawing.Point(315, 15)
        Me.LabelEditProfile.Name = "LabelEditProfile"
        Me.LabelEditProfile.Size = New System.Drawing.Size(157, 46)
        Me.LabelEditProfile.TabIndex = 3
        Me.LabelEditProfile.Text = "Edit Profile"
        '
        'LabelAddUsername
        '
        Me.LabelAddUsername.AutoSize = True
        Me.LabelAddUsername.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUsername.Location = New System.Drawing.Point(47, 135)
        Me.LabelAddUsername.Name = "LabelAddUsername"
        Me.LabelAddUsername.Size = New System.Drawing.Size(103, 28)
        Me.LabelAddUsername.TabIndex = 1
        Me.LabelAddUsername.Text = "Username"
        '
        'OpenFileDialogEditProfile
        '
        Me.OpenFileDialogEditProfile.FileName = "OpenFileDialogEditProfile"
        '
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelEditProfile)
        Me.PanelPage.Location = New System.Drawing.Point(-8, 65)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 664)
        Me.PanelPage.TabIndex = 7
        '
        'FormEditProfileExamCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Controls.Add(Me.PanelPage)
        Me.Name = "FormEditProfileExamCell"
        Me.ShowIcon = False
        CType(Me.ErrorProviderEditProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEditUsers.ResumeLayout(False)
        Me.PanelEditProfile.ResumeLayout(False)
        Me.PanelEditProfile.PerformLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEditProfileLabel.ResumeLayout(False)
        Me.PanelEditProfileLabel.PerformLayout()
        Me.PanelPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProviderEditProfile As ErrorProvider
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelEditProfilePanel As Label
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelEditProfile As Panel
    Friend WithEvents ButtonSelectImage As Button
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents LabelThumbnail As Label
    Friend WithEvents PictureBoxThumbnail As PictureBox
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents ButtonEditProfile As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents PanelEditProfileLabel As Panel
    Friend WithEvents LabelEditProfile As Label
    Friend WithEvents LabelAddUsername As Label
    Friend WithEvents ContextMenuStripEditUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialogEditProfile As OpenFileDialog
End Class
