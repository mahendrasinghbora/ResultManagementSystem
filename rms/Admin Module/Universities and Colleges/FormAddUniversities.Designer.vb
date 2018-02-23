<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddUniversities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddUniversities))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddUniversities = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddUniversities = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddUniversity = New System.Windows.Forms.Panel()
        Me.ButtonAddUniversity = New System.Windows.Forms.Button()
        Me.PanelAddUniversityLabel = New System.Windows.Forms.Panel()
        Me.LabelUniversities = New System.Windows.Forms.Label()
        Me.TextUniversity = New System.Windows.Forms.TextBox()
        Me.LabelUniversityName = New System.Windows.Forms.Label()
        Me.ErrorProviderUniversity = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddUniversities.SuspendLayout()
        Me.PanelAddUniversity.SuspendLayout()
        Me.PanelAddUniversityLabel.SuspendLayout()
        CType(Me.ErrorProviderUniversity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddUniversities)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 1)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 2
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1074, 5)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 7
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(221, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddUniversities
        '
        Me.LabelAddUniversities.AutoSize = True
        Me.LabelAddUniversities.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUniversities.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddUniversities.Name = "LabelAddUniversities"
        Me.LabelAddUniversities.Size = New System.Drawing.Size(180, 39)
        Me.LabelAddUniversities.TabIndex = 0
        Me.LabelAddUniversities.Text = "Add Universities"
        '
        'ContextMenuStripAddUniversities
        '
        Me.ContextMenuStripAddUniversities.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddUniversities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddUniversities.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddUniversities.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddUniversity
        '
        Me.PanelAddUniversity.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddUniversity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddUniversity.Controls.Add(Me.ButtonAddUniversity)
        Me.PanelAddUniversity.Controls.Add(Me.PanelAddUniversityLabel)
        Me.PanelAddUniversity.Controls.Add(Me.TextUniversity)
        Me.PanelAddUniversity.Controls.Add(Me.LabelUniversityName)
        Me.PanelAddUniversity.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddUniversity.Location = New System.Drawing.Point(425, 191)
        Me.PanelAddUniversity.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddUniversity.Name = "PanelAddUniversity"
        Me.PanelAddUniversity.Size = New System.Drawing.Size(500, 282)
        Me.PanelAddUniversity.TabIndex = 3
        '
        'ButtonAddUniversity
        '
        Me.ButtonAddUniversity.AutoSize = True
        Me.ButtonAddUniversity.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddUniversity.Location = New System.Drawing.Point(176, 213)
        Me.ButtonAddUniversity.Name = "ButtonAddUniversity"
        Me.ButtonAddUniversity.Size = New System.Drawing.Size(147, 36)
        Me.ButtonAddUniversity.TabIndex = 7
        Me.ButtonAddUniversity.Text = "Add University"
        Me.ButtonAddUniversity.UseVisualStyleBackColor = True
        '
        'PanelAddUniversityLabel
        '
        Me.PanelAddUniversityLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddUniversityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddUniversityLabel.Controls.Add(Me.LabelUniversities)
        Me.PanelAddUniversityLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddUniversityLabel.Name = "PanelAddUniversityLabel"
        Me.PanelAddUniversityLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddUniversityLabel.TabIndex = 4
        '
        'LabelUniversities
        '
        Me.LabelUniversities.AutoSize = True
        Me.LabelUniversities.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversities.Location = New System.Drawing.Point(137, 15)
        Me.LabelUniversities.Name = "LabelUniversities"
        Me.LabelUniversities.Size = New System.Drawing.Size(225, 46)
        Me.LabelUniversities.TabIndex = 3
        Me.LabelUniversities.Text = "Add Universities"
        '
        'TextUniversity
        '
        Me.TextUniversity.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUniversity.Location = New System.Drawing.Point(42, 135)
        Me.TextUniversity.Name = "TextUniversity"
        Me.TextUniversity.Size = New System.Drawing.Size(414, 27)
        Me.TextUniversity.TabIndex = 2
        '
        'LabelUniversityName
        '
        Me.LabelUniversityName.AutoSize = True
        Me.LabelUniversityName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversityName.Location = New System.Drawing.Point(37, 104)
        Me.LabelUniversityName.Name = "LabelUniversityName"
        Me.LabelUniversityName.Size = New System.Drawing.Size(213, 28)
        Me.LabelUniversityName.TabIndex = 1
        Me.LabelUniversityName.Text = "Name of the University"
        '
        'ErrorProviderUniversity
        '
        Me.ErrorProviderUniversity.ContainerControl = Me
        '
        'FormAddUniversities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddUniversity)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddUniversities"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddUniversities.ResumeLayout(False)
        Me.PanelAddUniversity.ResumeLayout(False)
        Me.PanelAddUniversity.PerformLayout()
        Me.PanelAddUniversityLabel.ResumeLayout(False)
        Me.PanelAddUniversityLabel.PerformLayout()
        CType(Me.ErrorProviderUniversity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddUniversities As Label
    Friend WithEvents ContextMenuStripAddUniversities As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddUniversity As Panel
    Friend WithEvents ButtonAddUniversity As Button
    Friend WithEvents PanelAddUniversityLabel As Panel
    Friend WithEvents LabelUniversities As Label
    Friend WithEvents TextUniversity As TextBox
    Friend WithEvents LabelUniversityName As Label
    Friend WithEvents ErrorProviderUniversity As ErrorProvider
End Class
