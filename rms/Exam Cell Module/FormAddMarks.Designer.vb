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
        Me.LabelAddMarks = New System.Windows.Forms.Label()
        Me.PanelAddMarks = New System.Windows.Forms.Panel()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.ComboBoxSession = New System.Windows.Forms.ComboBox()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.ComboBoxUniversity = New System.Windows.Forms.ComboBox()
        Me.ButtonAddMarks = New System.Windows.Forms.Button()
        Me.PanelAddMarksLabel = New System.Windows.Forms.Panel()
        Me.LabelUniversity = New System.Windows.Forms.Label()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddMarksPanel = New System.Windows.Forms.Label()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddMarks.SuspendLayout()
        Me.PanelAddMarksLabel.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelAddMarks
        '
        Me.LabelAddMarks.AutoSize = True
        Me.LabelAddMarks.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddMarks.Location = New System.Drawing.Point(237, 15)
        Me.LabelAddMarks.Name = "LabelAddMarks"
        Me.LabelAddMarks.Size = New System.Drawing.Size(312, 46)
        Me.LabelAddMarks.TabIndex = 3
        Me.LabelAddMarks.Text = "Add Marks Information"
        '
        'PanelAddMarks
        '
        Me.PanelAddMarks.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxSemester)
        Me.PanelAddMarks.Controls.Add(Me.LabelSemester)
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxSession)
        Me.PanelAddMarks.Controls.Add(Me.LabelSession)
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxCourse)
        Me.PanelAddMarks.Controls.Add(Me.LabelCourse)
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxUniversity)
        Me.PanelAddMarks.Controls.Add(Me.ButtonAddMarks)
        Me.PanelAddMarks.Controls.Add(Me.PanelAddMarksLabel)
        Me.PanelAddMarks.Controls.Add(Me.LabelUniversity)
        Me.PanelAddMarks.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddMarks.Location = New System.Drawing.Point(289, 85)
        Me.PanelAddMarks.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddMarks.Name = "PanelAddMarks"
        Me.PanelAddMarks.Size = New System.Drawing.Size(789, 422)
        Me.PanelAddMarks.TabIndex = 1
        '
        'ComboBoxSemester
        '
        Me.ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSemester.FormattingEnabled = True
        Me.ComboBoxSemester.Location = New System.Drawing.Point(436, 256)
        Me.ComboBoxSemester.Name = "ComboBoxSemester"
        Me.ComboBoxSemester.Size = New System.Drawing.Size(314, 31)
        Me.ComboBoxSemester.TabIndex = 17
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(431, 219)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemester.TabIndex = 16
        Me.LabelSemester.Text = "Semester"
        '
        'ComboBoxSession
        '
        Me.ComboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSession.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSession.FormattingEnabled = True
        Me.ComboBoxSession.Location = New System.Drawing.Point(42, 256)
        Me.ComboBoxSession.Name = "ComboBoxSession"
        Me.ComboBoxSession.Size = New System.Drawing.Size(314, 31)
        Me.ComboBoxSession.TabIndex = 15
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(37, 219)
        Me.LabelSession.Name = "LabelSession"
        Me.LabelSession.Size = New System.Drawing.Size(79, 28)
        Me.LabelSession.TabIndex = 14
        Me.LabelSession.Text = "Session"
        '
        'ComboBoxCourse
        '
        Me.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCourse.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourse.FormattingEnabled = True
        Me.ComboBoxCourse.Location = New System.Drawing.Point(431, 149)
        Me.ComboBoxCourse.Name = "ComboBoxCourse"
        Me.ComboBoxCourse.Size = New System.Drawing.Size(314, 31)
        Me.ComboBoxCourse.TabIndex = 13
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(426, 112)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(73, 28)
        Me.LabelCourse.TabIndex = 12
        Me.LabelCourse.Text = "Course"
        '
        'ComboBoxUniversity
        '
        Me.ComboBoxUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUniversity.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUniversity.FormattingEnabled = True
        Me.ComboBoxUniversity.Location = New System.Drawing.Point(37, 149)
        Me.ComboBoxUniversity.Name = "ComboBoxUniversity"
        Me.ComboBoxUniversity.Size = New System.Drawing.Size(314, 31)
        Me.ComboBoxUniversity.TabIndex = 11
        '
        'ButtonAddMarks
        '
        Me.ButtonAddMarks.AutoSize = True
        Me.ButtonAddMarks.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddMarks.Location = New System.Drawing.Point(305, 348)
        Me.ButtonAddMarks.Name = "ButtonAddMarks"
        Me.ButtonAddMarks.Size = New System.Drawing.Size(177, 39)
        Me.ButtonAddMarks.TabIndex = 7
        Me.ButtonAddMarks.Text = "Add Information"
        Me.ButtonAddMarks.UseVisualStyleBackColor = True
        '
        'PanelAddMarksLabel
        '
        Me.PanelAddMarksLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddMarksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddMarksLabel.Controls.Add(Me.LabelAddMarks)
        Me.PanelAddMarksLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddMarksLabel.Name = "PanelAddMarksLabel"
        Me.PanelAddMarksLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelAddMarksLabel.TabIndex = 4
        '
        'LabelUniversity
        '
        Me.LabelUniversity.AutoSize = True
        Me.LabelUniversity.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversity.Location = New System.Drawing.Point(32, 112)
        Me.LabelUniversity.Name = "LabelUniversity"
        Me.LabelUniversity.Size = New System.Drawing.Size(103, 28)
        Me.LabelUniversity.TabIndex = 1
        Me.LabelUniversity.Text = "University"
        '
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelAddMarks)
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
        Me.PanelNavigation.Controls.Add(Me.LabelAddMarksPanel)
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(290, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddMarksPanel
        '
        Me.LabelAddMarksPanel.AutoSize = True
        Me.LabelAddMarksPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddMarksPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddMarksPanel.Name = "LabelAddMarksPanel"
        Me.LabelAddMarksPanel.Size = New System.Drawing.Size(251, 39)
        Me.LabelAddMarksPanel.TabIndex = 0
        Me.LabelAddMarksPanel.Text = "Add Marks Information"
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
        Me.PanelAddMarks.ResumeLayout(False)
        Me.PanelAddMarks.PerformLayout()
        Me.PanelAddMarksLabel.ResumeLayout(False)
        Me.PanelAddMarksLabel.PerformLayout()
        Me.PanelPage.ResumeLayout(False)
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelAddMarks As Panel
    Friend WithEvents ButtonAddMarks As Button
    Friend WithEvents PanelAddMarksLabel As Panel
    Friend WithEvents LabelAddMarks As Label
    Friend WithEvents LabelUniversity As Label
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddMarksPanel As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxCourse As ComboBox
    Friend WithEvents LabelCourse As Label
    Friend WithEvents ComboBoxUniversity As ComboBox
    Friend WithEvents ComboBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents ComboBoxSession As ComboBox
    Friend WithEvents LabelSession As Label
End Class
