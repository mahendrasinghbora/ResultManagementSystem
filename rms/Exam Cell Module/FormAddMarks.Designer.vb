<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddMarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddMarks))
        Me.ErrorProviderAddUsers = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LabelAddUsers = New System.Windows.Forms.Label()
        Me.OpenFileDialogAddUsers = New System.Windows.Forms.OpenFileDialog()
        Me.PanelAddUsers = New System.Windows.Forms.Panel()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.ButtonAddUsers = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.PanelAddUsersLabel = New System.Windows.Forms.Panel()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.LabelAddUsername = New System.Windows.Forms.Label()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddUsersPanel = New System.Windows.Forms.Label()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorProviderAddUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAddUsers.SuspendLayout()
        Me.PanelAddUsersLabel.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProviderAddUsers
        '
        Me.ErrorProviderAddUsers.ContainerControl = Me
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
        'OpenFileDialogAddUsers
        '
        Me.OpenFileDialogAddUsers.FileName = "OpenFileDialogAddUsers"
        '
        'PanelAddUsers
        '
        Me.PanelAddUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelAddUsers)
        Me.PanelPage.Location = New System.Drawing.Point(-12, 66)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 662)
        Me.PanelPage.TabIndex = 4
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddUsersPanel)
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
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.LogOutToolStripMenuItem.Text = "Log out"
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
        'FormAddMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelPage)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddMarks"
        Me.ShowIcon = False
        CType(Me.ErrorProviderAddUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAddUsers.ResumeLayout(False)
        Me.PanelAddUsers.PerformLayout()
        Me.PanelAddUsersLabel.ResumeLayout(False)
        Me.PanelAddUsersLabel.PerformLayout()
        Me.PanelPage.ResumeLayout(False)
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProviderAddUsers As ErrorProvider
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelAddUsers As Panel
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents ButtonAddUsers As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents PanelAddUsersLabel As Panel
    Friend WithEvents LabelAddUsers As Label
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents LabelAddUsername As Label
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddUsersPanel As Label
    Friend WithEvents OpenFileDialogAddUsers As OpenFileDialog
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
End Class
