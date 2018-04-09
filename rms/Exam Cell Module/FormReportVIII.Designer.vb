<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportVIII
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportVIII))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LabelReport = New System.Windows.Forms.Label()
        Me.ButtonGenerateReport = New System.Windows.Forms.Button()
        Me.PanelReport = New System.Windows.Forms.Panel()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.ComboBoxSession = New System.Windows.Forms.ComboBox()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.ComboBoxCollege = New System.Windows.Forms.ComboBox()
        Me.PanelReportLabel = New System.Windows.Forms.Panel()
        Me.LabelCollege = New System.Windows.Forms.Label()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelPrintMarksheets = New System.Windows.Forms.Label()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PanelReport.SuspendLayout()
        Me.PanelReportLabel.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.PanelNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 250)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1319, 476)
        Me.CrystalReportViewer1.TabIndex = 18
        '
        'LabelReport
        '
        Me.LabelReport.AutoSize = True
        Me.LabelReport.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReport.Location = New System.Drawing.Point(570, 0)
        Me.LabelReport.Name = "LabelReport"
        Me.LabelReport.Size = New System.Drawing.Size(177, 34)
        Me.LabelReport.TabIndex = 3
        Me.LabelReport.Text = "Generate Reports"
        '
        'ButtonGenerateReport
        '
        Me.ButtonGenerateReport.AutoSize = True
        Me.ButtonGenerateReport.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerateReport.Location = New System.Drawing.Point(570, 126)
        Me.ButtonGenerateReport.Name = "ButtonGenerateReport"
        Me.ButtonGenerateReport.Size = New System.Drawing.Size(177, 39)
        Me.ButtonGenerateReport.TabIndex = 7
        Me.ButtonGenerateReport.Text = "Generate Report"
        Me.ButtonGenerateReport.UseVisualStyleBackColor = True
        '
        'PanelReport
        '
        Me.PanelReport.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelReport.Controls.Add(Me.ButtonGenerateReport)
        Me.PanelReport.Controls.Add(Me.ComboBoxSemester)
        Me.PanelReport.Controls.Add(Me.LabelSemester)
        Me.PanelReport.Controls.Add(Me.ComboBoxSession)
        Me.PanelReport.Controls.Add(Me.LabelSession)
        Me.PanelReport.Controls.Add(Me.ComboBoxCourse)
        Me.PanelReport.Controls.Add(Me.LabelCourse)
        Me.PanelReport.Controls.Add(Me.ComboBoxCollege)
        Me.PanelReport.Controls.Add(Me.PanelReportLabel)
        Me.PanelReport.Controls.Add(Me.LabelCollege)
        Me.PanelReport.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelReport.Location = New System.Drawing.Point(16, 69)
        Me.PanelReport.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelReport.Name = "PanelReport"
        Me.PanelReport.Size = New System.Drawing.Size(1319, 175)
        Me.PanelReport.TabIndex = 17
        '
        'ComboBoxSemester
        '
        Me.ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSemester.FormattingEnabled = True
        Me.ComboBoxSemester.Location = New System.Drawing.Point(683, 84)
        Me.ComboBoxSemester.Name = "ComboBoxSemester"
        Me.ComboBoxSemester.Size = New System.Drawing.Size(140, 31)
        Me.ComboBoxSemester.TabIndex = 17
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(671, 43)
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
        Me.ComboBoxSession.Location = New System.Drawing.Point(488, 84)
        Me.ComboBoxSession.Name = "ComboBoxSession"
        Me.ComboBoxSession.Size = New System.Drawing.Size(140, 31)
        Me.ComboBoxSession.TabIndex = 15
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(483, 43)
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
        Me.ComboBoxCourse.Location = New System.Drawing.Point(878, 84)
        Me.ComboBoxCourse.Name = "ComboBoxCourse"
        Me.ComboBoxCourse.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxCourse.TabIndex = 13
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(871, 43)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(73, 28)
        Me.LabelCourse.TabIndex = 12
        Me.LabelCourse.Text = "Course"
        '
        'ComboBoxCollege
        '
        Me.ComboBoxCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCollege.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCollege.FormattingEnabled = True
        Me.ComboBoxCollege.Location = New System.Drawing.Point(19, 84)
        Me.ComboBoxCollege.Name = "ComboBoxCollege"
        Me.ComboBoxCollege.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxCollege.TabIndex = 11
        '
        'PanelReportLabel
        '
        Me.PanelReportLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelReportLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelReportLabel.Controls.Add(Me.LabelReport)
        Me.PanelReportLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelReportLabel.Name = "PanelReportLabel"
        Me.PanelReportLabel.Size = New System.Drawing.Size(1319, 40)
        Me.PanelReportLabel.TabIndex = 4
        '
        'LabelCollege
        '
        Me.LabelCollege.AutoSize = True
        Me.LabelCollege.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCollege.Location = New System.Drawing.Point(15, 43)
        Me.LabelCollege.Name = "LabelCollege"
        Me.LabelCollege.Size = New System.Drawing.Size(78, 28)
        Me.LabelCollege.TabIndex = 1
        Me.LabelCollege.Text = "College"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(218, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelPrintMarksheets
        '
        Me.LabelPrintMarksheets.AutoSize = True
        Me.LabelPrintMarksheets.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrintMarksheets.Location = New System.Drawing.Point(33, 9)
        Me.LabelPrintMarksheets.Name = "LabelPrintMarksheets"
        Me.LabelPrintMarksheets.Size = New System.Drawing.Size(186, 39)
        Me.LabelPrintMarksheets.TabIndex = 0
        Me.LabelPrintMarksheets.Text = "View Report-VIII"
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
        'ContextMenuStripUsers
        '
        Me.ContextMenuStripUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUsers.Size = New System.Drawing.Size(184, 76)
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelPrintMarksheets)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 2)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 16
        '
        'FormReportVIII
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.PanelReport)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormReportVIII"
        Me.ShowIcon = False
        Me.PanelReport.ResumeLayout(False)
        Me.PanelReport.PerformLayout()
        Me.PanelReportLabel.ResumeLayout(False)
        Me.PanelReportLabel.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LabelReport As Label
    Friend WithEvents ButtonGenerateReport As Button
    Friend WithEvents PanelReport As Panel
    Friend WithEvents ComboBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents ComboBoxSession As ComboBox
    Friend WithEvents LabelSession As Label
    Friend WithEvents ComboBoxCourse As ComboBox
    Friend WithEvents LabelCourse As Label
    Friend WithEvents ComboBoxCollege As ComboBox
    Friend WithEvents PanelReportLabel As Panel
    Friend WithEvents LabelCollege As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelPrintMarksheets As Label
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents PanelNavigation As Panel
End Class
