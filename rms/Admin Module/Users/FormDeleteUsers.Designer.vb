<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeleteUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDeleteUsers))
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelDeleteUsersPanel = New System.Windows.Forms.Label()
        Me.ContextMenuStripDeleteUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDeleteUsers = New System.Windows.Forms.Panel()
        Me.TextUserType = New System.Windows.Forms.TextBox()
        Me.ComboBoxUsername = New System.Windows.Forms.ComboBox()
        Me.LabelUserType = New System.Windows.Forms.Label()
        Me.LabelThumbnail = New System.Windows.Forms.Label()
        Me.PictureBoxThumbnail = New System.Windows.Forms.PictureBox()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.ButtonDeleteUsers = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.PanelDeleteUsersLabel = New System.Windows.Forms.Panel()
        Me.LabelDeleteUsers = New System.Windows.Forms.Label()
        Me.LabelAddUsername = New System.Windows.Forms.Label()
        Me.ButtonUnblockUsers = New System.Windows.Forms.Button()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripDeleteUsers.SuspendLayout()
        Me.PanelDeleteUsers.SuspendLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDeleteUsersLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Location = New System.Drawing.Point(169, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelDeleteUsersPanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 3
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
        'LabelDeleteUsersPanel
        '
        Me.LabelDeleteUsersPanel.AutoSize = True
        Me.LabelDeleteUsersPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeleteUsersPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelDeleteUsersPanel.Name = "LabelDeleteUsersPanel"
        Me.LabelDeleteUsersPanel.Size = New System.Drawing.Size(131, 39)
        Me.LabelDeleteUsersPanel.TabIndex = 0
        Me.LabelDeleteUsersPanel.Text = "Block Users"
        '
        'ContextMenuStripDeleteUsers
        '
        Me.ContextMenuStripDeleteUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripDeleteUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripDeleteUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripDeleteUsers.Size = New System.Drawing.Size(184, 76)
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
        'PanelDeleteUsers
        '
        Me.PanelDeleteUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelDeleteUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDeleteUsers.Controls.Add(Me.TextUserType)
        Me.PanelDeleteUsers.Controls.Add(Me.ComboBoxUsername)
        Me.PanelDeleteUsers.Controls.Add(Me.LabelUserType)
        Me.PanelDeleteUsers.Controls.Add(Me.LabelThumbnail)
        Me.PanelDeleteUsers.Controls.Add(Me.PictureBoxThumbnail)
        Me.PanelDeleteUsers.Controls.Add(Me.TextLastName)
        Me.PanelDeleteUsers.Controls.Add(Me.LabelLastName)
        Me.PanelDeleteUsers.Controls.Add(Me.ButtonDeleteUsers)
        Me.PanelDeleteUsers.Controls.Add(Me.TextFirstName)
        Me.PanelDeleteUsers.Controls.Add(Me.LabelFirstName)
        Me.PanelDeleteUsers.Controls.Add(Me.PanelDeleteUsersLabel)
        Me.PanelDeleteUsers.Controls.Add(Me.LabelAddUsername)
        Me.PanelDeleteUsers.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDeleteUsers.Location = New System.Drawing.Point(281, 120)
        Me.PanelDeleteUsers.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelDeleteUsers.Name = "PanelDeleteUsers"
        Me.PanelDeleteUsers.Size = New System.Drawing.Size(789, 528)
        Me.PanelDeleteUsers.TabIndex = 4
        '
        'TextUserType
        '
        Me.TextUserType.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUserType.Location = New System.Drawing.Point(52, 393)
        Me.TextUserType.Name = "TextUserType"
        Me.TextUserType.ReadOnly = True
        Me.TextUserType.Size = New System.Drawing.Size(300, 27)
        Me.TextUserType.TabIndex = 16
        '
        'ComboBoxUsername
        '
        Me.ComboBoxUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsername.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUsername.FormattingEnabled = True
        Me.ComboBoxUsername.Location = New System.Drawing.Point(52, 158)
        Me.ComboBoxUsername.Name = "ComboBoxUsername"
        Me.ComboBoxUsername.Size = New System.Drawing.Size(300, 31)
        Me.ComboBoxUsername.TabIndex = 15
        '
        'LabelUserType
        '
        Me.LabelUserType.AutoSize = True
        Me.LabelUserType.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserType.Location = New System.Drawing.Point(47, 354)
        Me.LabelUserType.Name = "LabelUserType"
        Me.LabelUserType.Size = New System.Drawing.Size(98, 28)
        Me.LabelUserType.TabIndex = 14
        Me.LabelUserType.Text = "User Type"
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
        Me.TextLastName.Location = New System.Drawing.Point(52, 316)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.ReadOnly = True
        Me.TextLastName.Size = New System.Drawing.Size(300, 27)
        Me.TextLastName.TabIndex = 9
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(47, 277)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(104, 28)
        Me.LabelLastName.TabIndex = 8
        Me.LabelLastName.Text = "Last Name"
        '
        'ButtonDeleteUsers
        '
        Me.ButtonDeleteUsers.AutoSize = True
        Me.ButtonDeleteUsers.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteUsers.Location = New System.Drawing.Point(52, 458)
        Me.ButtonDeleteUsers.Name = "ButtonDeleteUsers"
        Me.ButtonDeleteUsers.Size = New System.Drawing.Size(128, 39)
        Me.ButtonDeleteUsers.TabIndex = 7
        Me.ButtonDeleteUsers.Text = "Block User"
        Me.ButtonDeleteUsers.UseVisualStyleBackColor = True
        '
        'TextFirstName
        '
        Me.TextFirstName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFirstName.Location = New System.Drawing.Point(52, 239)
        Me.TextFirstName.Name = "TextFirstName"
        Me.TextFirstName.ReadOnly = True
        Me.TextFirstName.Size = New System.Drawing.Size(300, 27)
        Me.TextFirstName.TabIndex = 6
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(47, 200)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(108, 28)
        Me.LabelFirstName.TabIndex = 5
        Me.LabelFirstName.Text = "First Name"
        '
        'PanelDeleteUsersLabel
        '
        Me.PanelDeleteUsersLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelDeleteUsersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDeleteUsersLabel.Controls.Add(Me.LabelDeleteUsers)
        Me.PanelDeleteUsersLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelDeleteUsersLabel.Name = "PanelDeleteUsersLabel"
        Me.PanelDeleteUsersLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelDeleteUsersLabel.TabIndex = 4
        '
        'LabelDeleteUsers
        '
        Me.LabelDeleteUsers.AutoSize = True
        Me.LabelDeleteUsers.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeleteUsers.Location = New System.Drawing.Point(312, 15)
        Me.LabelDeleteUsers.Name = "LabelDeleteUsers"
        Me.LabelDeleteUsers.Size = New System.Drawing.Size(162, 46)
        Me.LabelDeleteUsers.TabIndex = 3
        Me.LabelDeleteUsers.Text = "Block Users"
        '
        'LabelAddUsername
        '
        Me.LabelAddUsername.AutoSize = True
        Me.LabelAddUsername.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUsername.Location = New System.Drawing.Point(47, 119)
        Me.LabelAddUsername.Name = "LabelAddUsername"
        Me.LabelAddUsername.Size = New System.Drawing.Size(103, 28)
        Me.LabelAddUsername.TabIndex = 1
        Me.LabelAddUsername.Text = "Username"
        '
        'ButtonUnblockUsers
        '
        Me.ButtonUnblockUsers.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnblockUsers.Location = New System.Drawing.Point(924, 75)
        Me.ButtonUnblockUsers.Name = "ButtonUnblockUsers"
        Me.ButtonUnblockUsers.Size = New System.Drawing.Size(146, 39)
        Me.ButtonUnblockUsers.TabIndex = 5
        Me.ButtonUnblockUsers.Text = "Unblock Users"
        Me.ButtonUnblockUsers.UseVisualStyleBackColor = True
        '
        'FormDeleteUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ButtonUnblockUsers)
        Me.Controls.Add(Me.PanelDeleteUsers)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormDeleteUsers"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripDeleteUsers.ResumeLayout(False)
        Me.PanelDeleteUsers.ResumeLayout(False)
        Me.PanelDeleteUsers.PerformLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDeleteUsersLabel.ResumeLayout(False)
        Me.PanelDeleteUsersLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelDeleteUsersPanel As Label
    Friend WithEvents ContextMenuStripDeleteUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelDeleteUsers As Panel
    Friend WithEvents LabelUserType As Label
    Friend WithEvents LabelThumbnail As Label
    Friend WithEvents PictureBoxThumbnail As PictureBox
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents ButtonDeleteUsers As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents PanelDeleteUsersLabel As Panel
    Friend WithEvents LabelDeleteUsers As Label
    Friend WithEvents LabelAddUsername As Label
    Friend WithEvents ComboBoxUsername As ComboBox
    Friend WithEvents TextUserType As TextBox
    Friend WithEvents ButtonUnblockUsers As Button
End Class
