<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddUsers))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddUsersPanel = New System.Windows.Forms.Label()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.ButtonDeleteUsers = New System.Windows.Forms.Button()
        Me.ButtonEditUsers = New System.Windows.Forms.Button()
        Me.PanelAddUsers = New System.Windows.Forms.Panel()
        Me.RadioButtonUserType2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUserType1 = New System.Windows.Forms.RadioButton()
        Me.LabelUserType = New System.Windows.Forms.Label()
        Me.ButtonSelectImage = New System.Windows.Forms.Button()
        Me.LabelThumbnail = New System.Windows.Forms.Label()
        Me.PictureBoxThumbnail = New System.Windows.Forms.PictureBox()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.ButtonAddUsers = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.PanelAddUsersLabel = New System.Windows.Forms.Panel()
        Me.LabelAddUsers = New System.Windows.Forms.Label()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.LabelAddUsername = New System.Windows.Forms.Label()
        Me.OpenFileDialogAddUsers = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProviderAddUsers = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.PanelAddUsers.SuspendLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAddUsersLabel.SuspendLayout()
        CType(Me.ErrorProviderAddUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddUsersPanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-11, 1)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 1
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1066, 7)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 4
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(155, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddUsersPanel
        '
        Me.LabelAddUsersPanel.AutoSize = True
        Me.LabelAddUsersPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUsersPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddUsersPanel.Name = "LabelAddUsersPanel"
        Me.LabelAddUsersPanel.Size = New System.Drawing.Size(118, 39)
        Me.LabelAddUsersPanel.TabIndex = 0
        Me.LabelAddUsersPanel.Text = "Add Users"
        '
        'ContextMenuStripUsers
        '
        Me.ContextMenuStripUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUsers.Size = New System.Drawing.Size(184, 76)
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
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.ButtonDeleteUsers)
        Me.PanelPage.Controls.Add(Me.ButtonEditUsers)
        Me.PanelPage.Controls.Add(Me.PanelAddUsers)
        Me.PanelPage.Location = New System.Drawing.Point(-8, 67)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 662)
        Me.PanelPage.TabIndex = 2
        '
        'ButtonDeleteUsers
        '
        Me.ButtonDeleteUsers.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteUsers.Location = New System.Drawing.Point(849, 16)
        Me.ButtonDeleteUsers.Name = "ButtonDeleteUsers"
        Me.ButtonDeleteUsers.Size = New System.Drawing.Size(116, 39)
        Me.ButtonDeleteUsers.TabIndex = 3
        Me.ButtonDeleteUsers.Text = "Delete Users"
        Me.ButtonDeleteUsers.UseVisualStyleBackColor = True
        '
        'ButtonEditUsers
        '
        Me.ButtonEditUsers.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditUsers.Location = New System.Drawing.Point(976, 16)
        Me.ButtonEditUsers.Name = "ButtonEditUsers"
        Me.ButtonEditUsers.Size = New System.Drawing.Size(102, 39)
        Me.ButtonEditUsers.TabIndex = 2
        Me.ButtonEditUsers.Text = "Edit Users"
        Me.ButtonEditUsers.UseVisualStyleBackColor = True
        '
        'PanelAddUsers
        '
        Me.PanelAddUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddUsers.Controls.Add(Me.RadioButtonUserType2)
        Me.PanelAddUsers.Controls.Add(Me.RadioButtonUserType1)
        Me.PanelAddUsers.Controls.Add(Me.LabelUserType)
        Me.PanelAddUsers.Controls.Add(Me.ButtonSelectImage)
        Me.PanelAddUsers.Controls.Add(Me.LabelThumbnail)
        Me.PanelAddUsers.Controls.Add(Me.PictureBoxThumbnail)
        Me.PanelAddUsers.Controls.Add(Me.TextLastName)
        Me.PanelAddUsers.Controls.Add(Me.LabelLastName)
        Me.PanelAddUsers.Controls.Add(Me.ButtonAddUsers)
        Me.PanelAddUsers.Controls.Add(Me.TextFirstName)
        Me.PanelAddUsers.Controls.Add(Me.LabelFirstName)
        Me.PanelAddUsers.Controls.Add(Me.PanelAddUsersLabel)
        Me.PanelAddUsers.Controls.Add(Me.TextUsername)
        Me.PanelAddUsers.Controls.Add(Me.LabelAddUsername)
        Me.PanelAddUsers.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddUsers.Location = New System.Drawing.Point(289, 85)
        Me.PanelAddUsers.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddUsers.Name = "PanelAddUsers"
        Me.PanelAddUsers.Size = New System.Drawing.Size(789, 528)
        Me.PanelAddUsers.TabIndex = 1
        '
        'RadioButtonUserType2
        '
        Me.RadioButtonUserType2.AutoSize = True
        Me.RadioButtonUserType2.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUserType2.Location = New System.Drawing.Point(170, 395)
        Me.RadioButtonUserType2.Name = "RadioButtonUserType2"
        Me.RadioButtonUserType2.Size = New System.Drawing.Size(124, 38)
        Me.RadioButtonUserType2.TabIndex = 18
        Me.RadioButtonUserType2.TabStop = True
        Me.RadioButtonUserType2.Text = "Exam Cell"
        Me.RadioButtonUserType2.UseVisualStyleBackColor = True
        '
        'RadioButtonUserType1
        '
        Me.RadioButtonUserType1.AutoSize = True
        Me.RadioButtonUserType1.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUserType1.Location = New System.Drawing.Point(52, 395)
        Me.RadioButtonUserType1.Name = "RadioButtonUserType1"
        Me.RadioButtonUserType1.Size = New System.Drawing.Size(96, 38)
        Me.RadioButtonUserType1.TabIndex = 17
        Me.RadioButtonUserType1.TabStop = True
        Me.RadioButtonUserType1.Text = "Admin"
        Me.RadioButtonUserType1.UseVisualStyleBackColor = True
        '
        'LabelUserType
        '
        Me.LabelUserType.AutoSize = True
        Me.LabelUserType.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserType.Location = New System.Drawing.Point(47, 359)
        Me.LabelUserType.Name = "LabelUserType"
        Me.LabelUserType.Size = New System.Drawing.Size(98, 28)
        Me.LabelUserType.TabIndex = 14
        Me.LabelUserType.Text = "User Type"
        '
        'ButtonSelectImage
        '
        Me.ButtonSelectImage.AutoSize = True
        Me.ButtonSelectImage.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelectImage.Location = New System.Drawing.Point(573, 385)
        Me.ButtonSelectImage.Name = "ButtonSelectImage"
        Me.ButtonSelectImage.Size = New System.Drawing.Size(126, 36)
        Me.ButtonSelectImage.TabIndex = 12
        Me.ButtonSelectImage.Text = "Select image"
        Me.ButtonSelectImage.UseVisualStyleBackColor = True
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
        Me.TextLastName.Location = New System.Drawing.Point(52, 242)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(300, 27)
        Me.TextLastName.TabIndex = 9
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(47, 207)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(104, 28)
        Me.LabelLastName.TabIndex = 8
        Me.LabelLastName.Text = "Last Name"
        '
        'ButtonAddUsers
        '
        Me.ButtonAddUsers.AutoSize = True
        Me.ButtonAddUsers.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddUsers.Location = New System.Drawing.Point(52, 458)
        Me.ButtonAddUsers.Name = "ButtonAddUsers"
        Me.ButtonAddUsers.Size = New System.Drawing.Size(124, 39)
        Me.ButtonAddUsers.TabIndex = 7
        Me.ButtonAddUsers.Text = "Add User"
        Me.ButtonAddUsers.UseVisualStyleBackColor = True
        '
        'TextFirstName
        '
        Me.TextFirstName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFirstName.Location = New System.Drawing.Point(52, 166)
        Me.TextFirstName.Name = "TextFirstName"
        Me.TextFirstName.Size = New System.Drawing.Size(300, 27)
        Me.TextFirstName.TabIndex = 6
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(47, 131)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(108, 28)
        Me.LabelFirstName.TabIndex = 5
        Me.LabelFirstName.Text = "First Name"
        '
        'PanelAddUsersLabel
        '
        Me.PanelAddUsersLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddUsersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddUsersLabel.Controls.Add(Me.LabelAddUsers)
        Me.PanelAddUsersLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddUsersLabel.Name = "PanelAddUsersLabel"
        Me.PanelAddUsersLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelAddUsersLabel.TabIndex = 4
        '
        'LabelAddUsers
        '
        Me.LabelAddUsers.AutoSize = True
        Me.LabelAddUsers.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUsers.Location = New System.Drawing.Point(320, 15)
        Me.LabelAddUsers.Name = "LabelAddUsers"
        Me.LabelAddUsers.Size = New System.Drawing.Size(146, 46)
        Me.LabelAddUsers.TabIndex = 3
        Me.LabelAddUsers.Text = "Add Users"
        '
        'TextUsername
        '
        Me.TextUsername.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsername.Location = New System.Drawing.Point(52, 318)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(300, 27)
        Me.TextUsername.TabIndex = 2
        '
        'LabelAddUsername
        '
        Me.LabelAddUsername.AutoSize = True
        Me.LabelAddUsername.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUsername.Location = New System.Drawing.Point(47, 283)
        Me.LabelAddUsername.Name = "LabelAddUsername"
        Me.LabelAddUsername.Size = New System.Drawing.Size(103, 28)
        Me.LabelAddUsername.TabIndex = 1
        Me.LabelAddUsername.Text = "Username"
        '
        'OpenFileDialogAddUsers
        '
        Me.OpenFileDialogAddUsers.FileName = "OpenFileDialogAddUsers"
        '
        'ErrorProviderAddUsers
        '
        Me.ErrorProviderAddUsers.ContainerControl = Me
        '
        'FormAddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelPage)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddUsers"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.PanelPage.ResumeLayout(False)
        Me.PanelAddUsers.ResumeLayout(False)
        Me.PanelAddUsers.PerformLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAddUsersLabel.ResumeLayout(False)
        Me.PanelAddUsersLabel.PerformLayout()
        CType(Me.ErrorProviderAddUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddUsersPanel As Label
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelAddUsers As Panel
    Friend WithEvents ButtonAddUsers As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents PanelAddUsersLabel As Panel
    Friend WithEvents LabelAddUsers As Label
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents LabelAddUsername As Label
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents LabelThumbnail As Label
    Friend WithEvents PictureBoxThumbnail As PictureBox
    Friend WithEvents ButtonSelectImage As Button
    Friend WithEvents LabelUserType As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialogAddUsers As OpenFileDialog
    Friend WithEvents ErrorProviderAddUsers As ErrorProvider
    Friend WithEvents ButtonDeleteUsers As Button
    Friend WithEvents ButtonEditUsers As Button
    Friend WithEvents RadioButtonUserType2 As RadioButton
    Friend WithEvents RadioButtonUserType1 As RadioButton
    Friend WithEvents PictureBoxUser As PictureBox
End Class
