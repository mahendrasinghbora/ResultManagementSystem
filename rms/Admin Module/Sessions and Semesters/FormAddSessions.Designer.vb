<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSessions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddSessions))
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddSessions = New System.Windows.Forms.Label()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStripAddSessions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddSessions = New System.Windows.Forms.Panel()
        Me.TextEndYear = New System.Windows.Forms.TextBox()
        Me.LabelEndYear = New System.Windows.Forms.Label()
        Me.ButtonAddSession = New System.Windows.Forms.Button()
        Me.PanelAddSessionLabel = New System.Windows.Forms.Panel()
        Me.LabelSessions = New System.Windows.Forms.Label()
        Me.TextStartYear = New System.Windows.Forms.TextBox()
        Me.LabelStartYear = New System.Windows.Forms.Label()
        Me.ErrorProviderSession = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddSessions.SuspendLayout()
        Me.PanelAddSessions.SuspendLayout()
        Me.PanelAddSessionLabel.SuspendLayout()
        CType(Me.ErrorProviderSession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'LabelAddSessions
        '
        Me.LabelAddSessions.AutoSize = True
        Me.LabelAddSessions.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddSessions.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddSessions.Name = "LabelAddSessions"
        Me.LabelAddSessions.Size = New System.Drawing.Size(144, 39)
        Me.LabelAddSessions.TabIndex = 0
        Me.LabelAddSessions.Text = "Add Sessions"
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddSessions)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 1)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 4
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1072, 7)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 6
        Me.PictureBoxUser.TabStop = False
        '
        'ContextMenuStripAddSessions
        '
        Me.ContextMenuStripAddSessions.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddSessions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddSessions.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddSessions.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddSessions
        '
        Me.PanelAddSessions.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSessions.Controls.Add(Me.TextEndYear)
        Me.PanelAddSessions.Controls.Add(Me.LabelEndYear)
        Me.PanelAddSessions.Controls.Add(Me.ButtonAddSession)
        Me.PanelAddSessions.Controls.Add(Me.PanelAddSessionLabel)
        Me.PanelAddSessions.Controls.Add(Me.TextStartYear)
        Me.PanelAddSessions.Controls.Add(Me.LabelStartYear)
        Me.PanelAddSessions.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddSessions.Location = New System.Drawing.Point(425, 223)
        Me.PanelAddSessions.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddSessions.Name = "PanelAddSessions"
        Me.PanelAddSessions.Size = New System.Drawing.Size(500, 363)
        Me.PanelAddSessions.TabIndex = 8
        '
        'TextEndYear
        '
        Me.TextEndYear.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEndYear.Location = New System.Drawing.Point(45, 229)
        Me.TextEndYear.Name = "TextEndYear"
        Me.TextEndYear.ReadOnly = True
        Me.TextEndYear.Size = New System.Drawing.Size(414, 27)
        Me.TextEndYear.TabIndex = 9
        '
        'LabelEndYear
        '
        Me.LabelEndYear.AutoSize = True
        Me.LabelEndYear.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEndYear.Location = New System.Drawing.Point(40, 198)
        Me.LabelEndYear.Name = "LabelEndYear"
        Me.LabelEndYear.Size = New System.Drawing.Size(160, 28)
        Me.LabelEndYear.TabIndex = 8
        Me.LabelEndYear.Text = "Session End Year"
        '
        'ButtonAddSession
        '
        Me.ButtonAddSession.AutoSize = True
        Me.ButtonAddSession.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddSession.Location = New System.Drawing.Point(176, 305)
        Me.ButtonAddSession.Name = "ButtonAddSession"
        Me.ButtonAddSession.Size = New System.Drawing.Size(147, 36)
        Me.ButtonAddSession.TabIndex = 7
        Me.ButtonAddSession.Text = "Add Session"
        Me.ButtonAddSession.UseVisualStyleBackColor = True
        '
        'PanelAddSessionLabel
        '
        Me.PanelAddSessionLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddSessionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSessionLabel.Controls.Add(Me.LabelSessions)
        Me.PanelAddSessionLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddSessionLabel.Name = "PanelAddSessionLabel"
        Me.PanelAddSessionLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddSessionLabel.TabIndex = 4
        '
        'LabelSessions
        '
        Me.LabelSessions.AutoSize = True
        Me.LabelSessions.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSessions.Location = New System.Drawing.Point(158, 15)
        Me.LabelSessions.Name = "LabelSessions"
        Me.LabelSessions.Size = New System.Drawing.Size(183, 46)
        Me.LabelSessions.TabIndex = 3
        Me.LabelSessions.Text = "Add Sessions"
        '
        'TextStartYear
        '
        Me.TextStartYear.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStartYear.Location = New System.Drawing.Point(42, 135)
        Me.TextStartYear.Name = "TextStartYear"
        Me.TextStartYear.Size = New System.Drawing.Size(414, 27)
        Me.TextStartYear.TabIndex = 2
        '
        'LabelStartYear
        '
        Me.LabelStartYear.AutoSize = True
        Me.LabelStartYear.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStartYear.Location = New System.Drawing.Point(37, 104)
        Me.LabelStartYear.Name = "LabelStartYear"
        Me.LabelStartYear.Size = New System.Drawing.Size(171, 28)
        Me.LabelStartYear.TabIndex = 1
        Me.LabelStartYear.Text = "Session Start Year"
        '
        'ErrorProviderSession
        '
        Me.ErrorProviderSession.ContainerControl = Me
        '
        'FormAddSessions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddSessions)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddSessions"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddSessions.ResumeLayout(False)
        Me.PanelAddSessions.ResumeLayout(False)
        Me.PanelAddSessions.PerformLayout()
        Me.PanelAddSessionLabel.ResumeLayout(False)
        Me.PanelAddSessionLabel.PerformLayout()
        CType(Me.ErrorProviderSession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddSessions As Label
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents ContextMenuStripAddSessions As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddSessions As Panel
    Friend WithEvents TextEndYear As TextBox
    Friend WithEvents LabelEndYear As Label
    Friend WithEvents ButtonAddSession As Button
    Friend WithEvents PanelAddSessionLabel As Panel
    Friend WithEvents LabelSessions As Label
    Friend WithEvents TextStartYear As TextBox
    Friend WithEvents LabelStartYear As Label
    Friend WithEvents ErrorProviderSession As ErrorProvider
End Class
