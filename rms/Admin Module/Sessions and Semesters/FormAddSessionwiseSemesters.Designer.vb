<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSessionwiseSemesters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddSessionwiseSemesters))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddSessionswiseSemesters = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddSessionwiseSemesters = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelSessionwiseSemesters = New System.Windows.Forms.Panel()
        Me.ComboBoxSession = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.ButtonAddSessionwiseSemester = New System.Windows.Forms.Button()
        Me.PanelAddSessionwiseSemestersLabel = New System.Windows.Forms.Panel()
        Me.LabelSessionwiseSemesters = New System.Windows.Forms.Label()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddSessionwiseSemesters.SuspendLayout()
        Me.PanelSessionwiseSemesters.SuspendLayout()
        Me.PanelAddSessionwiseSemestersLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddSessionswiseSemesters)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, -1)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 5
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1072, 5)
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(324, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddSessionswiseSemesters
        '
        Me.LabelAddSessionswiseSemesters.AutoSize = True
        Me.LabelAddSessionswiseSemesters.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddSessionswiseSemesters.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddSessionswiseSemesters.Name = "LabelAddSessionswiseSemesters"
        Me.LabelAddSessionswiseSemesters.Size = New System.Drawing.Size(290, 39)
        Me.LabelAddSessionswiseSemesters.TabIndex = 0
        Me.LabelAddSessionswiseSemesters.Text = "Add Sessionswise Semesters"
        '
        'ContextMenuStripAddSessionwiseSemesters
        '
        Me.ContextMenuStripAddSessionwiseSemesters.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddSessionwiseSemesters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddSessionwiseSemesters.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddSessionwiseSemesters.Size = New System.Drawing.Size(184, 76)
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
        'PanelSessionwiseSemesters
        '
        Me.PanelSessionwiseSemesters.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelSessionwiseSemesters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSessionwiseSemesters.Controls.Add(Me.ComboBoxSession)
        Me.PanelSessionwiseSemesters.Controls.Add(Me.ComboBoxSemester)
        Me.PanelSessionwiseSemesters.Controls.Add(Me.LabelSemester)
        Me.PanelSessionwiseSemesters.Controls.Add(Me.ButtonAddSessionwiseSemester)
        Me.PanelSessionwiseSemesters.Controls.Add(Me.PanelAddSessionwiseSemestersLabel)
        Me.PanelSessionwiseSemesters.Controls.Add(Me.LabelSession)
        Me.PanelSessionwiseSemesters.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSessionwiseSemesters.Location = New System.Drawing.Point(425, 205)
        Me.PanelSessionwiseSemesters.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelSessionwiseSemesters.Name = "PanelSessionwiseSemesters"
        Me.PanelSessionwiseSemesters.Size = New System.Drawing.Size(500, 384)
        Me.PanelSessionwiseSemesters.TabIndex = 6
        '
        'ComboBoxSession
        '
        Me.ComboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSession.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSession.FormattingEnabled = True
        Me.ComboBoxSession.Location = New System.Drawing.Point(42, 153)
        Me.ComboBoxSession.Name = "ComboBoxSession"
        Me.ComboBoxSession.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxSession.TabIndex = 10
        '
        'ComboBoxSemester
        '
        Me.ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSemester.FormattingEnabled = True
        Me.ComboBoxSemester.Location = New System.Drawing.Point(42, 241)
        Me.ComboBoxSemester.Name = "ComboBoxSemester"
        Me.ComboBoxSemester.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxSemester.TabIndex = 9
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(37, 208)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemester.TabIndex = 8
        Me.LabelSemester.Text = "Semester"
        '
        'ButtonAddSessionwiseSemester
        '
        Me.ButtonAddSessionwiseSemester.AutoSize = True
        Me.ButtonAddSessionwiseSemester.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddSessionwiseSemester.Location = New System.Drawing.Point(123, 311)
        Me.ButtonAddSessionwiseSemester.Name = "ButtonAddSessionwiseSemester"
        Me.ButtonAddSessionwiseSemester.Size = New System.Drawing.Size(253, 36)
        Me.ButtonAddSessionwiseSemester.TabIndex = 7
        Me.ButtonAddSessionwiseSemester.Text = "Add Semester to the Session"
        Me.ButtonAddSessionwiseSemester.UseVisualStyleBackColor = True
        '
        'PanelAddSessionwiseSemestersLabel
        '
        Me.PanelAddSessionwiseSemestersLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddSessionwiseSemestersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSessionwiseSemestersLabel.Controls.Add(Me.LabelSessionwiseSemesters)
        Me.PanelAddSessionwiseSemestersLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddSessionwiseSemestersLabel.Name = "PanelAddSessionwiseSemestersLabel"
        Me.PanelAddSessionwiseSemestersLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddSessionwiseSemestersLabel.TabIndex = 4
        '
        'LabelSessionwiseSemesters
        '
        Me.LabelSessionwiseSemesters.AutoSize = True
        Me.LabelSessionwiseSemesters.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSessionwiseSemesters.Location = New System.Drawing.Point(75, 15)
        Me.LabelSessionwiseSemesters.Name = "LabelSessionwiseSemesters"
        Me.LabelSessionwiseSemesters.Size = New System.Drawing.Size(348, 46)
        Me.LabelSessionwiseSemesters.TabIndex = 3
        Me.LabelSessionwiseSemesters.Text = "Add Semesters to Sessions"
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(37, 117)
        Me.LabelSession.Name = "LabelSession"
        Me.LabelSession.Size = New System.Drawing.Size(79, 28)
        Me.LabelSession.TabIndex = 1
        Me.LabelSession.Text = "Session"
        '
        'FormAddSessionwiseSemesters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelSessionwiseSemesters)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddSessionwiseSemesters"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddSessionwiseSemesters.ResumeLayout(False)
        Me.PanelSessionwiseSemesters.ResumeLayout(False)
        Me.PanelSessionwiseSemesters.PerformLayout()
        Me.PanelAddSessionwiseSemestersLabel.ResumeLayout(False)
        Me.PanelAddSessionwiseSemestersLabel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddSessionswiseSemesters As Label
    Friend WithEvents ContextMenuStripAddSessionwiseSemesters As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelSessionwiseSemesters As Panel
    Friend WithEvents ComboBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents ButtonAddSessionwiseSemester As Button
    Friend WithEvents PanelAddSessionwiseSemestersLabel As Panel
    Friend WithEvents LabelSessionwiseSemesters As Label
    Friend WithEvents LabelSession As Label
    Friend WithEvents ComboBoxSession As ComboBox
End Class
