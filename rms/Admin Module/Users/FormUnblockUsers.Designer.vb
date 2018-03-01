<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUnblockUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUnblockUsers))
        Me.ButtonBlockUsers = New System.Windows.Forms.Button()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripDeleteUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelUnblockUsersPanel = New System.Windows.Forms.Label()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.PanelUnblockUsers = New System.Windows.Forms.Panel()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ComboBoxUsername = New System.Windows.Forms.ComboBox()
        Me.ButtonUnblockUser = New System.Windows.Forms.Button()
        Me.PanelUnblockUsersLabel = New System.Windows.Forms.Panel()
        Me.LabelUnblockUsers = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.ContextMenuStripDeleteUsers.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavigation.SuspendLayout()
        Me.PanelUnblockUsers.SuspendLayout()
        Me.PanelUnblockUsersLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBlockUsers
        '
        Me.ButtonBlockUsers.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBlockUsers.Location = New System.Drawing.Point(806, 151)
        Me.ButtonBlockUsers.Name = "ButtonBlockUsers"
        Me.ButtonBlockUsers.Size = New System.Drawing.Size(120, 39)
        Me.ButtonBlockUsers.TabIndex = 8
        Me.ButtonBlockUsers.Text = "Block Users"
        Me.ButtonBlockUsers.UseVisualStyleBackColor = True
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.LogOutToolStripMenuItem.Text = "Log out"
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
        'LabelUnblockUsersPanel
        '
        Me.LabelUnblockUsersPanel.AutoSize = True
        Me.LabelUnblockUsersPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnblockUsersPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelUnblockUsersPanel.Name = "LabelUnblockUsersPanel"
        Me.LabelUnblockUsersPanel.Size = New System.Drawing.Size(158, 39)
        Me.LabelUnblockUsersPanel.TabIndex = 0
        Me.LabelUnblockUsersPanel.Text = "Unblock Users"
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelUnblockUsersPanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 6
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Location = New System.Drawing.Point(195, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'PanelUnblockUsers
        '
        Me.PanelUnblockUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelUnblockUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUnblockUsers.Controls.Add(Me.TextName)
        Me.PanelUnblockUsers.Controls.Add(Me.LabelName)
        Me.PanelUnblockUsers.Controls.Add(Me.ComboBoxUsername)
        Me.PanelUnblockUsers.Controls.Add(Me.ButtonUnblockUser)
        Me.PanelUnblockUsers.Controls.Add(Me.PanelUnblockUsersLabel)
        Me.PanelUnblockUsers.Controls.Add(Me.LabelUser)
        Me.PanelUnblockUsers.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelUnblockUsers.Location = New System.Drawing.Point(424, 196)
        Me.PanelUnblockUsers.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelUnblockUsers.Name = "PanelUnblockUsers"
        Me.PanelUnblockUsers.Size = New System.Drawing.Size(502, 367)
        Me.PanelUnblockUsers.TabIndex = 9
        '
        'TextName
        '
        Me.TextName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(42, 240)
        Me.TextName.Name = "TextName"
        Me.TextName.ReadOnly = True
        Me.TextName.Size = New System.Drawing.Size(416, 27)
        Me.TextName.TabIndex = 12
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(37, 200)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(101, 28)
        Me.LabelName.TabIndex = 11
        Me.LabelName.Text = "Full Name"
        '
        'ComboBoxUsername
        '
        Me.ComboBoxUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsername.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUsername.FormattingEnabled = True
        Me.ComboBoxUsername.Location = New System.Drawing.Point(42, 157)
        Me.ComboBoxUsername.Name = "ComboBoxUsername"
        Me.ComboBoxUsername.Size = New System.Drawing.Size(416, 31)
        Me.ComboBoxUsername.TabIndex = 10
        '
        'ButtonUnblockUser
        '
        Me.ButtonUnblockUser.AutoSize = True
        Me.ButtonUnblockUser.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnblockUser.Location = New System.Drawing.Point(174, 302)
        Me.ButtonUnblockUser.Name = "ButtonUnblockUser"
        Me.ButtonUnblockUser.Size = New System.Drawing.Size(153, 36)
        Me.ButtonUnblockUser.TabIndex = 7
        Me.ButtonUnblockUser.Text = "Unblock User"
        Me.ButtonUnblockUser.UseVisualStyleBackColor = True
        '
        'PanelUnblockUsersLabel
        '
        Me.PanelUnblockUsersLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelUnblockUsersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUnblockUsersLabel.Controls.Add(Me.LabelUnblockUsers)
        Me.PanelUnblockUsersLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelUnblockUsersLabel.Name = "PanelUnblockUsersLabel"
        Me.PanelUnblockUsersLabel.Size = New System.Drawing.Size(502, 78)
        Me.PanelUnblockUsersLabel.TabIndex = 4
        '
        'LabelUnblockUsers
        '
        Me.LabelUnblockUsers.AutoSize = True
        Me.LabelUnblockUsers.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnblockUsers.Location = New System.Drawing.Point(152, 15)
        Me.LabelUnblockUsers.Name = "LabelUnblockUsers"
        Me.LabelUnblockUsers.Size = New System.Drawing.Size(197, 46)
        Me.LabelUnblockUsers.TabIndex = 3
        Me.LabelUnblockUsers.Text = "Unblock Users"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(37, 117)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(103, 28)
        Me.LabelUser.TabIndex = 1
        Me.LabelUser.Text = "Username"
        '
        'FormUnblockUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelUnblockUsers)
        Me.Controls.Add(Me.ButtonBlockUsers)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormUnblockUsers"
        Me.ShowIcon = False
        Me.ContextMenuStripDeleteUsers.ResumeLayout(False)
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        Me.PanelUnblockUsers.ResumeLayout(False)
        Me.PanelUnblockUsers.PerformLayout()
        Me.PanelUnblockUsersLabel.ResumeLayout(False)
        Me.PanelUnblockUsersLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonBlockUsers As Button
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripDeleteUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelUnblockUsersPanel As Label
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents PanelUnblockUsers As Panel
    Friend WithEvents ComboBoxUsername As ComboBox
    Friend WithEvents ButtonUnblockUser As Button
    Friend WithEvents PanelUnblockUsersLabel As Panel
    Friend WithEvents LabelUnblockUsers As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents LabelName As Label
End Class
