<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintMarksheets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrintMarksheets))
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelPrintMarksheets = New System.Windows.Forms.Label()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.ComboBoxSession = New System.Windows.Forms.ComboBox()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.ComboBoxUniversity = New System.Windows.Forms.ComboBox()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.ButtonPrintMarksheet = New System.Windows.Forms.Button()
        Me.PanelPrintMarksheetsLabel = New System.Windows.Forms.Panel()
        Me.LabelPrintMarksheetsPanel = New System.Windows.Forms.Label()
        Me.LabelUniversity = New System.Windows.Forms.Label()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelPrintMarksheets = New System.Windows.Forms.Panel()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrintMarksheetsLabel.SuspendLayout()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.PanelPrintMarksheets.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.PanelNavigation.SuspendLayout()
        Me.SuspendLayout()
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
        'LabelPrintMarksheets
        '
        Me.LabelPrintMarksheets.AutoSize = True
        Me.LabelPrintMarksheets.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrintMarksheets.Location = New System.Drawing.Point(33, 9)
        Me.LabelPrintMarksheets.Name = "LabelPrintMarksheets"
        Me.LabelPrintMarksheets.Size = New System.Drawing.Size(186, 39)
        Me.LabelPrintMarksheets.TabIndex = 0
        Me.LabelPrintMarksheets.Text = "Print Marksheets"
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(219, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'ButtonPrintMarksheet
        '
        Me.ButtonPrintMarksheet.AutoSize = True
        Me.ButtonPrintMarksheet.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintMarksheet.Location = New System.Drawing.Point(305, 348)
        Me.ButtonPrintMarksheet.Name = "ButtonPrintMarksheet"
        Me.ButtonPrintMarksheet.Size = New System.Drawing.Size(177, 39)
        Me.ButtonPrintMarksheet.TabIndex = 7
        Me.ButtonPrintMarksheet.Text = "Print Marksheet"
        Me.ButtonPrintMarksheet.UseVisualStyleBackColor = True
        '
        'PanelPrintMarksheetsLabel
        '
        Me.PanelPrintMarksheetsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelPrintMarksheetsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPrintMarksheetsLabel.Controls.Add(Me.LabelPrintMarksheetsPanel)
        Me.PanelPrintMarksheetsLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelPrintMarksheetsLabel.Name = "PanelPrintMarksheetsLabel"
        Me.PanelPrintMarksheetsLabel.Size = New System.Drawing.Size(789, 78)
        Me.PanelPrintMarksheetsLabel.TabIndex = 4
        '
        'LabelPrintMarksheetsPanel
        '
        Me.LabelPrintMarksheetsPanel.AutoSize = True
        Me.LabelPrintMarksheetsPanel.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrintMarksheetsPanel.Location = New System.Drawing.Point(277, 15)
        Me.LabelPrintMarksheetsPanel.Name = "LabelPrintMarksheetsPanel"
        Me.LabelPrintMarksheetsPanel.Size = New System.Drawing.Size(233, 46)
        Me.LabelPrintMarksheetsPanel.TabIndex = 3
        Me.LabelPrintMarksheetsPanel.Text = "Print Marksheets"
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
        'ContextMenuStripUsers
        '
        Me.ContextMenuStripUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUsers.Size = New System.Drawing.Size(184, 76)
        '
        'PanelPrintMarksheets
        '
        Me.PanelPrintMarksheets.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelPrintMarksheets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPrintMarksheets.Controls.Add(Me.ComboBoxSemester)
        Me.PanelPrintMarksheets.Controls.Add(Me.LabelSemester)
        Me.PanelPrintMarksheets.Controls.Add(Me.ComboBoxSession)
        Me.PanelPrintMarksheets.Controls.Add(Me.LabelSession)
        Me.PanelPrintMarksheets.Controls.Add(Me.ComboBoxCourse)
        Me.PanelPrintMarksheets.Controls.Add(Me.LabelCourse)
        Me.PanelPrintMarksheets.Controls.Add(Me.ComboBoxUniversity)
        Me.PanelPrintMarksheets.Controls.Add(Me.ButtonPrintMarksheet)
        Me.PanelPrintMarksheets.Controls.Add(Me.PanelPrintMarksheetsLabel)
        Me.PanelPrintMarksheets.Controls.Add(Me.LabelUniversity)
        Me.PanelPrintMarksheets.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrintMarksheets.Location = New System.Drawing.Point(289, 85)
        Me.PanelPrintMarksheets.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelPrintMarksheets.Name = "PanelPrintMarksheets"
        Me.PanelPrintMarksheets.Size = New System.Drawing.Size(789, 413)
        Me.PanelPrintMarksheets.TabIndex = 1
        '
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelPrintMarksheets)
        Me.PanelPage.Location = New System.Drawing.Point(-12, 66)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 662)
        Me.PanelPage.TabIndex = 6
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelPrintMarksheets)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 5
        '
        'FormPrintMarksheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelPage)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormPrintMarksheets"
        Me.ShowIcon = False
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrintMarksheetsLabel.ResumeLayout(False)
        Me.PanelPrintMarksheetsLabel.PerformLayout()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.PanelPrintMarksheets.ResumeLayout(False)
        Me.PanelPrintMarksheets.PerformLayout()
        Me.PanelPage.ResumeLayout(False)
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelPrintMarksheets As Label
    Friend WithEvents ComboBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents ComboBoxSession As ComboBox
    Friend WithEvents LabelSession As Label
    Friend WithEvents ComboBoxCourse As ComboBox
    Friend WithEvents LabelCourse As Label
    Friend WithEvents ComboBoxUniversity As ComboBox
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonPrintMarksheet As Button
    Friend WithEvents PanelPrintMarksheetsLabel As Panel
    Friend WithEvents LabelPrintMarksheetsPanel As Label
    Friend WithEvents LabelUniversity As Label
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents PanelPrintMarksheets As Panel
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelNavigation As Panel
End Class
