<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangePassword))
        Me.ErrorProviderChangePassword = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelChangePasswordPanel = New System.Windows.Forms.Label()
        Me.ContextMenuStripEditUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextOldPassword = New System.Windows.Forms.TextBox()
        Me.PanelEditProfile = New System.Windows.Forms.Panel()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.PictureBoxThumbnail = New System.Windows.Forms.PictureBox()
        Me.TextConfirmation = New System.Windows.Forms.TextBox()
        Me.LabelConfirmation = New System.Windows.Forms.Label()
        Me.ButtonChangePassword = New System.Windows.Forms.Button()
        Me.TextNewPassword = New System.Windows.Forms.TextBox()
        Me.LabelNewPassword = New System.Windows.Forms.Label()
        Me.PanelEditProfileLabel = New System.Windows.Forms.Panel()
        Me.LabelChangePassword = New System.Windows.Forms.Label()
        Me.LabelOldPassword = New System.Windows.Forms.Label()
        Me.PanelPage = New System.Windows.Forms.Panel()
        CType(Me.ErrorProviderChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEditUsers.SuspendLayout()
        Me.PanelEditProfile.SuspendLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEditProfileLabel.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProviderChangePassword
        '
        Me.ErrorProviderChangePassword.ContainerControl = Me
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelChangePasswordPanel)
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(226, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelChangePasswordPanel
        '
        Me.LabelChangePasswordPanel.AutoSize = True
        Me.LabelChangePasswordPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChangePasswordPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelChangePasswordPanel.Name = "LabelChangePasswordPanel"
        Me.LabelChangePasswordPanel.Size = New System.Drawing.Size(191, 39)
        Me.LabelChangePasswordPanel.TabIndex = 0
        Me.LabelChangePasswordPanel.Text = "Change Password"
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
        'TextOldPassword
        '
        Me.TextOldPassword.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextOldPassword.Location = New System.Drawing.Point(52, 175)
        Me.TextOldPassword.Name = "TextOldPassword"
        Me.TextOldPassword.Size = New System.Drawing.Size(300, 27)
        Me.TextOldPassword.TabIndex = 21
        Me.TextOldPassword.UseSystemPasswordChar = True
        '
        'PanelEditProfile
        '
        Me.PanelEditProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelEditProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEditProfile.Controls.Add(Me.TextOldPassword)
        Me.PanelEditProfile.Controls.Add(Me.LabelUser)
        Me.PanelEditProfile.Controls.Add(Me.PictureBoxThumbnail)
        Me.PanelEditProfile.Controls.Add(Me.TextConfirmation)
        Me.PanelEditProfile.Controls.Add(Me.LabelConfirmation)
        Me.PanelEditProfile.Controls.Add(Me.ButtonChangePassword)
        Me.PanelEditProfile.Controls.Add(Me.TextNewPassword)
        Me.PanelEditProfile.Controls.Add(Me.LabelNewPassword)
        Me.PanelEditProfile.Controls.Add(Me.PanelEditProfileLabel)
        Me.PanelEditProfile.Controls.Add(Me.LabelOldPassword)
        Me.PanelEditProfile.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEditProfile.Location = New System.Drawing.Point(289, 78)
        Me.PanelEditProfile.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelEditProfile.Name = "PanelEditProfile"
        Me.PanelEditProfile.Size = New System.Drawing.Size(789, 454)
        Me.PanelEditProfile.TabIndex = 5
        '
        'LabelUser
        '
        Me.LabelUser.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(503, 131)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(266, 28)
        Me.LabelUser.TabIndex = 11
        Me.LabelUser.Text = "Username"
        Me.LabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxThumbnail
        '
        Me.PictureBoxThumbnail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxThumbnail.Image = CType(resources.GetObject("PictureBoxThumbnail.Image"), System.Drawing.Image)
        Me.PictureBoxThumbnail.Location = New System.Drawing.Point(562, 177)
        Me.PictureBoxThumbnail.Name = "PictureBoxThumbnail"
        Me.PictureBoxThumbnail.Size = New System.Drawing.Size(149, 182)
        Me.PictureBoxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxThumbnail.TabIndex = 10
        Me.PictureBoxThumbnail.TabStop = False
        '
        'TextConfirmation
        '
        Me.TextConfirmation.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextConfirmation.Location = New System.Drawing.Point(52, 332)
        Me.TextConfirmation.Name = "TextConfirmation"
        Me.TextConfirmation.Size = New System.Drawing.Size(300, 27)
        Me.TextConfirmation.TabIndex = 9
        Me.TextConfirmation.UseSystemPasswordChar = True
        '
        'LabelConfirmation
        '
        Me.LabelConfirmation.AutoSize = True
        Me.LabelConfirmation.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConfirmation.Location = New System.Drawing.Point(47, 293)
        Me.LabelConfirmation.Name = "LabelConfirmation"
        Me.LabelConfirmation.Size = New System.Drawing.Size(217, 28)
        Me.LabelConfirmation.TabIndex = 8
        Me.LabelConfirmation.Text = "Confirm New Password"
        '
        'ButtonChangePassword
        '
        Me.ButtonChangePassword.AutoSize = True
        Me.ButtonChangePassword.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChangePassword.Location = New System.Drawing.Point(52, 399)
        Me.ButtonChangePassword.Name = "ButtonChangePassword"
        Me.ButtonChangePassword.Size = New System.Drawing.Size(186, 39)
        Me.ButtonChangePassword.TabIndex = 7
        Me.ButtonChangePassword.Text = "Change Password"
        Me.ButtonChangePassword.UseVisualStyleBackColor = True
        '
        'TextNewPassword
        '
        Me.TextNewPassword.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNewPassword.Location = New System.Drawing.Point(52, 255)
        Me.TextNewPassword.Name = "TextNewPassword"
        Me.TextNewPassword.Size = New System.Drawing.Size(300, 27)
        Me.TextNewPassword.TabIndex = 6
        Me.TextNewPassword.UseSystemPasswordChar = True
        '
        'LabelNewPassword
        '
        Me.LabelNewPassword.AutoSize = True
        Me.LabelNewPassword.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNewPassword.Location = New System.Drawing.Point(47, 216)
        Me.LabelNewPassword.Name = "LabelNewPassword"
        Me.LabelNewPassword.Size = New System.Drawing.Size(141, 28)
        Me.LabelNewPassword.TabIndex = 5
        Me.LabelNewPassword.Text = "New Password"
        '
        'PanelEditProfileLabel
        '
        Me.PanelEditProfileLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelEditProfileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEditProfileLabel.Controls.Add(Me.LabelChangePassword)
        Me.PanelEditProfileLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelEditProfileLabel.Name = "PanelEditProfileLabel"
        Me.PanelEditProfileLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelEditProfileLabel.TabIndex = 4
        '
        'LabelChangePassword
        '
        Me.LabelChangePassword.AutoSize = True
        Me.LabelChangePassword.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChangePassword.Location = New System.Drawing.Point(272, 15)
        Me.LabelChangePassword.Name = "LabelChangePassword"
        Me.LabelChangePassword.Size = New System.Drawing.Size(242, 46)
        Me.LabelChangePassword.TabIndex = 3
        Me.LabelChangePassword.Text = "Change Password"
        '
        'LabelOldPassword
        '
        Me.LabelOldPassword.AutoSize = True
        Me.LabelOldPassword.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOldPassword.Location = New System.Drawing.Point(47, 135)
        Me.LabelOldPassword.Name = "LabelOldPassword"
        Me.LabelOldPassword.Size = New System.Drawing.Size(132, 28)
        Me.LabelOldPassword.TabIndex = 1
        Me.LabelOldPassword.Text = "Old Password"
        '
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelEditProfile)
        Me.PanelPage.Location = New System.Drawing.Point(-8, 65)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 664)
        Me.PanelPage.TabIndex = 7
        '
        'FormChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Controls.Add(Me.PanelPage)
        Me.Name = "FormChangePassword"
        Me.ShowIcon = False
        CType(Me.ErrorProviderChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents ErrorProviderChangePassword As ErrorProvider
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelChangePasswordPanel As Label
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelEditProfile As Panel
    Friend WithEvents TextOldPassword As TextBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents PictureBoxThumbnail As PictureBox
    Friend WithEvents TextConfirmation As TextBox
    Friend WithEvents LabelConfirmation As Label
    Friend WithEvents ButtonChangePassword As Button
    Friend WithEvents TextNewPassword As TextBox
    Friend WithEvents LabelNewPassword As Label
    Friend WithEvents PanelEditProfileLabel As Panel
    Friend WithEvents LabelChangePassword As Label
    Friend WithEvents LabelOldPassword As Label
    Friend WithEvents ContextMenuStripEditUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
