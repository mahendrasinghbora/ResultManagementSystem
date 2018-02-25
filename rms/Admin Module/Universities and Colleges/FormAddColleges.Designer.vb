<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddColleges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddColleges))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddColleges = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddColleges = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddColleges = New System.Windows.Forms.Panel()
        Me.ComboBoxUniversity = New System.Windows.Forms.ComboBox()
        Me.LabelUniversityName = New System.Windows.Forms.Label()
        Me.ButtonAddCollege = New System.Windows.Forms.Button()
        Me.PanelAddCollegesLabel = New System.Windows.Forms.Panel()
        Me.LabelColleges = New System.Windows.Forms.Label()
        Me.TextCollege = New System.Windows.Forms.TextBox()
        Me.LabelCollegeName = New System.Windows.Forms.Label()
        Me.ErrorProviderCollege = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddColleges.SuspendLayout()
        Me.PanelAddColleges.SuspendLayout()
        Me.PanelAddCollegesLabel.SuspendLayout()
        CType(Me.ErrorProviderCollege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddColleges)
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
        Me.PictureBoxUser.TabIndex = 6
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(190, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddColleges
        '
        Me.LabelAddColleges.AutoSize = True
        Me.LabelAddColleges.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddColleges.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddColleges.Name = "LabelAddColleges"
        Me.LabelAddColleges.Size = New System.Drawing.Size(144, 39)
        Me.LabelAddColleges.TabIndex = 0
        Me.LabelAddColleges.Text = "Add Colleges"
        '
        'ContextMenuStripAddColleges
        '
        Me.ContextMenuStripAddColleges.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddColleges.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddColleges.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddColleges.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddColleges
        '
        Me.PanelAddColleges.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddColleges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddColleges.Controls.Add(Me.ComboBoxUniversity)
        Me.PanelAddColleges.Controls.Add(Me.LabelUniversityName)
        Me.PanelAddColleges.Controls.Add(Me.ButtonAddCollege)
        Me.PanelAddColleges.Controls.Add(Me.PanelAddCollegesLabel)
        Me.PanelAddColleges.Controls.Add(Me.TextCollege)
        Me.PanelAddColleges.Controls.Add(Me.LabelCollegeName)
        Me.PanelAddColleges.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddColleges.Location = New System.Drawing.Point(425, 203)
        Me.PanelAddColleges.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddColleges.Name = "PanelAddColleges"
        Me.PanelAddColleges.Size = New System.Drawing.Size(500, 384)
        Me.PanelAddColleges.TabIndex = 4
        '
        'ComboBoxUniversity
        '
        Me.ComboBoxUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUniversity.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUniversity.FormattingEnabled = True
        Me.ComboBoxUniversity.Location = New System.Drawing.Point(42, 241)
        Me.ComboBoxUniversity.Name = "ComboBoxUniversity"
        Me.ComboBoxUniversity.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxUniversity.TabIndex = 9
        '
        'LabelUniversityName
        '
        Me.LabelUniversityName.AutoSize = True
        Me.LabelUniversityName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversityName.Location = New System.Drawing.Point(37, 208)
        Me.LabelUniversityName.Name = "LabelUniversityName"
        Me.LabelUniversityName.Size = New System.Drawing.Size(213, 28)
        Me.LabelUniversityName.TabIndex = 8
        Me.LabelUniversityName.Text = "Name of the University"
        '
        'ButtonAddCollege
        '
        Me.ButtonAddCollege.AutoSize = True
        Me.ButtonAddCollege.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCollege.Location = New System.Drawing.Point(176, 311)
        Me.ButtonAddCollege.Name = "ButtonAddCollege"
        Me.ButtonAddCollege.Size = New System.Drawing.Size(147, 36)
        Me.ButtonAddCollege.TabIndex = 7
        Me.ButtonAddCollege.Text = "Add College"
        Me.ButtonAddCollege.UseVisualStyleBackColor = True
        '
        'PanelAddCollegesLabel
        '
        Me.PanelAddCollegesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddCollegesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddCollegesLabel.Controls.Add(Me.LabelColleges)
        Me.PanelAddCollegesLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddCollegesLabel.Name = "PanelAddCollegesLabel"
        Me.PanelAddCollegesLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddCollegesLabel.TabIndex = 4
        '
        'LabelColleges
        '
        Me.LabelColleges.AutoSize = True
        Me.LabelColleges.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelColleges.Location = New System.Drawing.Point(158, 15)
        Me.LabelColleges.Name = "LabelColleges"
        Me.LabelColleges.Size = New System.Drawing.Size(183, 46)
        Me.LabelColleges.TabIndex = 3
        Me.LabelColleges.Text = "Add Colleges"
        '
        'TextCollege
        '
        Me.TextCollege.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCollege.Location = New System.Drawing.Point(42, 150)
        Me.TextCollege.Name = "TextCollege"
        Me.TextCollege.Size = New System.Drawing.Size(414, 27)
        Me.TextCollege.TabIndex = 2
        '
        'LabelCollegeName
        '
        Me.LabelCollegeName.AutoSize = True
        Me.LabelCollegeName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCollegeName.Location = New System.Drawing.Point(37, 117)
        Me.LabelCollegeName.Name = "LabelCollegeName"
        Me.LabelCollegeName.Size = New System.Drawing.Size(188, 28)
        Me.LabelCollegeName.TabIndex = 1
        Me.LabelCollegeName.Text = "Name of the College"
        '
        'ErrorProviderCollege
        '
        Me.ErrorProviderCollege.ContainerControl = Me
        '
        'FormAddColleges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddColleges)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddColleges"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddColleges.ResumeLayout(False)
        Me.PanelAddColleges.ResumeLayout(False)
        Me.PanelAddColleges.PerformLayout()
        Me.PanelAddCollegesLabel.ResumeLayout(False)
        Me.PanelAddCollegesLabel.PerformLayout()
        CType(Me.ErrorProviderCollege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddColleges As Label
    Friend WithEvents ContextMenuStripAddColleges As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddColleges As Panel
    Friend WithEvents LabelUniversityName As Label
    Friend WithEvents ButtonAddCollege As Button
    Friend WithEvents PanelAddCollegesLabel As Panel
    Friend WithEvents LabelColleges As Label
    Friend WithEvents TextCollege As TextBox
    Friend WithEvents LabelCollegeName As Label
    Friend WithEvents ComboBoxUniversity As ComboBox
    Friend WithEvents ErrorProviderCollege As ErrorProvider
End Class
