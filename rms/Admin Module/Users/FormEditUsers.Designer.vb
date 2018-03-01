<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditUsers))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelEditUsersPanel = New System.Windows.Forms.Label()
        Me.ContextMenuStripEditUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.PanelEditUsers = New System.Windows.Forms.Panel()
        Me.RadioButtonUserType2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUserType1 = New System.Windows.Forms.RadioButton()
        Me.ComboBoxUsername = New System.Windows.Forms.ComboBox()
        Me.LabelUserType = New System.Windows.Forms.Label()
        Me.LabelThumbnail = New System.Windows.Forms.Label()
        Me.PictureBoxThumbnail = New System.Windows.Forms.PictureBox()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.ButtonEditUsers = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.PanelEditUsersLabel = New System.Windows.Forms.Panel()
        Me.LabelEditUsers = New System.Windows.Forms.Label()
        Me.LabelAddUsername = New System.Windows.Forms.Label()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEditUsers.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.PanelEditUsers.SuspendLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEditUsersLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelEditUsersPanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 2
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(295, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelEditUsersPanel
        '
        Me.LabelEditUsersPanel.AutoSize = True
        Me.LabelEditUsersPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditUsersPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelEditUsersPanel.Name = "LabelEditUsersPanel"
        Me.LabelEditUsersPanel.Size = New System.Drawing.Size(263, 39)
        Me.LabelEditUsersPanel.TabIndex = 0
        Me.LabelEditUsersPanel.Text = "Change  Users' Authority"
        '
        'ContextMenuStripEditUsers
        '
        Me.ContextMenuStripEditUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripEditUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripEditUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripEditUsers.Size = New System.Drawing.Size(184, 98)
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
        Me.PanelPage.Controls.Add(Me.PanelEditUsers)
        Me.PanelPage.Location = New System.Drawing.Point(-8, 65)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 664)
        Me.PanelPage.TabIndex = 3
        '
        'PanelEditUsers
        '
        Me.PanelEditUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelEditUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEditUsers.Controls.Add(Me.RadioButtonUserType2)
        Me.PanelEditUsers.Controls.Add(Me.RadioButtonUserType1)
        Me.PanelEditUsers.Controls.Add(Me.ComboBoxUsername)
        Me.PanelEditUsers.Controls.Add(Me.LabelUserType)
        Me.PanelEditUsers.Controls.Add(Me.LabelThumbnail)
        Me.PanelEditUsers.Controls.Add(Me.PictureBoxThumbnail)
        Me.PanelEditUsers.Controls.Add(Me.TextLastName)
        Me.PanelEditUsers.Controls.Add(Me.LabelLastName)
        Me.PanelEditUsers.Controls.Add(Me.ButtonEditUsers)
        Me.PanelEditUsers.Controls.Add(Me.TextFirstName)
        Me.PanelEditUsers.Controls.Add(Me.LabelFirstName)
        Me.PanelEditUsers.Controls.Add(Me.PanelEditUsersLabel)
        Me.PanelEditUsers.Controls.Add(Me.LabelAddUsername)
        Me.PanelEditUsers.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEditUsers.Location = New System.Drawing.Point(289, 78)
        Me.PanelEditUsers.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelEditUsers.Name = "PanelEditUsers"
        Me.PanelEditUsers.Size = New System.Drawing.Size(789, 500)
        Me.PanelEditUsers.TabIndex = 5
        '
        'RadioButtonUserType2
        '
        Me.RadioButtonUserType2.AutoSize = True
        Me.RadioButtonUserType2.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUserType2.Location = New System.Drawing.Point(170, 380)
        Me.RadioButtonUserType2.Name = "RadioButtonUserType2"
        Me.RadioButtonUserType2.Size = New System.Drawing.Size(124, 38)
        Me.RadioButtonUserType2.TabIndex = 20
        Me.RadioButtonUserType2.TabStop = True
        Me.RadioButtonUserType2.Text = "Exam Cell"
        Me.RadioButtonUserType2.UseVisualStyleBackColor = True
        '
        'RadioButtonUserType1
        '
        Me.RadioButtonUserType1.AutoSize = True
        Me.RadioButtonUserType1.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUserType1.Location = New System.Drawing.Point(52, 380)
        Me.RadioButtonUserType1.Name = "RadioButtonUserType1"
        Me.RadioButtonUserType1.Size = New System.Drawing.Size(96, 38)
        Me.RadioButtonUserType1.TabIndex = 19
        Me.RadioButtonUserType1.TabStop = True
        Me.RadioButtonUserType1.Text = "Admin"
        Me.RadioButtonUserType1.UseVisualStyleBackColor = True
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
        'ButtonEditUsers
        '
        Me.ButtonEditUsers.AutoSize = True
        Me.ButtonEditUsers.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditUsers.Location = New System.Drawing.Point(52, 441)
        Me.ButtonEditUsers.Name = "ButtonEditUsers"
        Me.ButtonEditUsers.Size = New System.Drawing.Size(128, 39)
        Me.ButtonEditUsers.TabIndex = 7
        Me.ButtonEditUsers.Text = "Update"
        Me.ButtonEditUsers.UseVisualStyleBackColor = True
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
        'PanelEditUsersLabel
        '
        Me.PanelEditUsersLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelEditUsersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEditUsersLabel.Controls.Add(Me.LabelEditUsers)
        Me.PanelEditUsersLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelEditUsersLabel.Name = "PanelEditUsersLabel"
        Me.PanelEditUsersLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelEditUsersLabel.TabIndex = 4
        '
        'LabelEditUsers
        '
        Me.LabelEditUsers.AutoSize = True
        Me.LabelEditUsers.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditUsers.Location = New System.Drawing.Point(273, 15)
        Me.LabelEditUsers.Name = "LabelEditUsers"
        Me.LabelEditUsers.Size = New System.Drawing.Size(241, 46)
        Me.LabelEditUsers.TabIndex = 3
        Me.LabelEditUsers.Text = "Change Authority"
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
        'FormEditUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelPage)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormEditUsers"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEditUsers.ResumeLayout(False)
        Me.PanelPage.ResumeLayout(False)
        Me.PanelEditUsers.ResumeLayout(False)
        Me.PanelEditUsers.PerformLayout()
        CType(Me.PictureBoxThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEditUsersLabel.ResumeLayout(False)
        Me.PanelEditUsersLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelEditUsersPanel As Label
    Friend WithEvents ContextMenuStripEditUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelEditUsers As Panel
    Friend WithEvents ComboBoxUsername As ComboBox
    Friend WithEvents LabelUserType As Label
    Friend WithEvents LabelThumbnail As Label
    Friend WithEvents PictureBoxThumbnail As PictureBox
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents ButtonEditUsers As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents PanelEditUsersLabel As Panel
    Friend WithEvents LabelEditUsers As Label
    Friend WithEvents LabelAddUsername As Label
    Friend WithEvents RadioButtonUserType2 As RadioButton
    Friend WithEvents RadioButtonUserType1 As RadioButton
End Class
