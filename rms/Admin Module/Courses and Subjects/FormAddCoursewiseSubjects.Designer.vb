<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddCoursewiseSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddCoursewiseSubjects))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddCoursewiseSubjects = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddCoursewiseSubjects = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelCoursewiseSubjects = New System.Windows.Forms.Panel()
        Me.ComboBoxUniversity = New System.Windows.Forms.ComboBox()
        Me.LabelUniversity = New System.Windows.Forms.Label()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.ComboBoxSession = New System.Windows.Forms.ComboBox()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSubject = New System.Windows.Forms.ComboBox()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.ButtonAddCoursewiseSubject = New System.Windows.Forms.Button()
        Me.PanelAddCoursewiseSubjectsLabel = New System.Windows.Forms.Panel()
        Me.LabelCoursewiseSubjects = New System.Windows.Forms.Label()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.ButtonAddUniversitywiseCourses = New System.Windows.Forms.Button()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddCoursewiseSubjects.SuspendLayout()
        Me.PanelCoursewiseSubjects.SuspendLayout()
        Me.PanelAddCoursewiseSubjectsLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddCoursewiseSubjects)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 1)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 6
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1072, 5)
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
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddCoursewiseSubjects
        '
        Me.LabelAddCoursewiseSubjects.AutoSize = True
        Me.LabelAddCoursewiseSubjects.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCoursewiseSubjects.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddCoursewiseSubjects.Name = "LabelAddCoursewiseSubjects"
        Me.LabelAddCoursewiseSubjects.Size = New System.Drawing.Size(260, 39)
        Me.LabelAddCoursewiseSubjects.TabIndex = 0
        Me.LabelAddCoursewiseSubjects.Text = "Add Coursewise Subjects"
        '
        'ContextMenuStripAddCoursewiseSubjects
        '
        Me.ContextMenuStripAddCoursewiseSubjects.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddCoursewiseSubjects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddCoursewiseSubjects.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddCoursewiseSubjects.Size = New System.Drawing.Size(184, 76)
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
        'PanelCoursewiseSubjects
        '
        Me.PanelCoursewiseSubjects.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelCoursewiseSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCoursewiseSubjects.Controls.Add(Me.ComboBoxUniversity)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.LabelUniversity)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.ComboBoxSemester)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.LabelSemester)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.ComboBoxSession)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.LabelSession)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.ComboBoxCourse)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.ComboBoxSubject)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.LabelSubject)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.ButtonAddCoursewiseSubject)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.PanelAddCoursewiseSubjectsLabel)
        Me.PanelCoursewiseSubjects.Controls.Add(Me.LabelCourse)
        Me.PanelCoursewiseSubjects.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelCoursewiseSubjects.Location = New System.Drawing.Point(425, 136)
        Me.PanelCoursewiseSubjects.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelCoursewiseSubjects.Name = "PanelCoursewiseSubjects"
        Me.PanelCoursewiseSubjects.Size = New System.Drawing.Size(500, 517)
        Me.PanelCoursewiseSubjects.TabIndex = 7
        '
        'ComboBoxUniversity
        '
        Me.ComboBoxUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUniversity.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUniversity.FormattingEnabled = True
        Me.ComboBoxUniversity.Location = New System.Drawing.Point(42, 222)
        Me.ComboBoxUniversity.Name = "ComboBoxUniversity"
        Me.ComboBoxUniversity.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxUniversity.TabIndex = 16
        '
        'LabelUniversity
        '
        Me.LabelUniversity.AutoSize = True
        Me.LabelUniversity.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversity.Location = New System.Drawing.Point(37, 186)
        Me.LabelUniversity.Name = "LabelUniversity"
        Me.LabelUniversity.Size = New System.Drawing.Size(103, 28)
        Me.LabelUniversity.TabIndex = 15
        Me.LabelUniversity.Text = "University"
        '
        'ComboBoxSemester
        '
        Me.ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSemester.FormattingEnabled = True
        Me.ComboBoxSemester.Location = New System.Drawing.Point(261, 134)
        Me.ComboBoxSemester.Name = "ComboBoxSemester"
        Me.ComboBoxSemester.Size = New System.Drawing.Size(195, 31)
        Me.ComboBoxSemester.TabIndex = 14
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(255, 98)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemester.TabIndex = 13
        Me.LabelSemester.Text = "Semester"
        '
        'ComboBoxSession
        '
        Me.ComboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSession.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSession.FormattingEnabled = True
        Me.ComboBoxSession.Location = New System.Drawing.Point(42, 134)
        Me.ComboBoxSession.Name = "ComboBoxSession"
        Me.ComboBoxSession.Size = New System.Drawing.Size(195, 31)
        Me.ComboBoxSession.TabIndex = 12
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(37, 98)
        Me.LabelSession.Name = "LabelSession"
        Me.LabelSession.Size = New System.Drawing.Size(79, 28)
        Me.LabelSession.TabIndex = 11
        Me.LabelSession.Text = "Session"
        '
        'ComboBoxCourse
        '
        Me.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCourse.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourse.FormattingEnabled = True
        Me.ComboBoxCourse.Location = New System.Drawing.Point(42, 298)
        Me.ComboBoxCourse.Name = "ComboBoxCourse"
        Me.ComboBoxCourse.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxCourse.TabIndex = 10
        '
        'ComboBoxSubject
        '
        Me.ComboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSubject.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubject.FormattingEnabled = True
        Me.ComboBoxSubject.Location = New System.Drawing.Point(42, 386)
        Me.ComboBoxSubject.Name = "ComboBoxSubject"
        Me.ComboBoxSubject.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxSubject.TabIndex = 9
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubject.Location = New System.Drawing.Point(37, 353)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(76, 28)
        Me.LabelSubject.TabIndex = 8
        Me.LabelSubject.Text = "Subject"
        '
        'ButtonAddCoursewiseSubject
        '
        Me.ButtonAddCoursewiseSubject.AutoSize = True
        Me.ButtonAddCoursewiseSubject.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCoursewiseSubject.Location = New System.Drawing.Point(123, 456)
        Me.ButtonAddCoursewiseSubject.Name = "ButtonAddCoursewiseSubject"
        Me.ButtonAddCoursewiseSubject.Size = New System.Drawing.Size(253, 36)
        Me.ButtonAddCoursewiseSubject.TabIndex = 7
        Me.ButtonAddCoursewiseSubject.Text = "Add Subject to the Course"
        Me.ButtonAddCoursewiseSubject.UseVisualStyleBackColor = True
        '
        'PanelAddCoursewiseSubjectsLabel
        '
        Me.PanelAddCoursewiseSubjectsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddCoursewiseSubjectsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddCoursewiseSubjectsLabel.Controls.Add(Me.LabelCoursewiseSubjects)
        Me.PanelAddCoursewiseSubjectsLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddCoursewiseSubjectsLabel.Name = "PanelAddCoursewiseSubjectsLabel"
        Me.PanelAddCoursewiseSubjectsLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddCoursewiseSubjectsLabel.TabIndex = 4
        '
        'LabelCoursewiseSubjects
        '
        Me.LabelCoursewiseSubjects.AutoSize = True
        Me.LabelCoursewiseSubjects.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCoursewiseSubjects.Location = New System.Drawing.Point(92, 15)
        Me.LabelCoursewiseSubjects.Name = "LabelCoursewiseSubjects"
        Me.LabelCoursewiseSubjects.Size = New System.Drawing.Size(314, 46)
        Me.LabelCoursewiseSubjects.TabIndex = 3
        Me.LabelCoursewiseSubjects.Text = "Add Subjects to Courses"
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(37, 262)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(73, 28)
        Me.LabelCourse.TabIndex = 1
        Me.LabelCourse.Text = "Course"
        '
        'ButtonAddUniversitywiseCourses
        '
        Me.ButtonAddUniversitywiseCourses.AutoSize = True
        Me.ButtonAddUniversitywiseCourses.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddUniversitywiseCourses.Location = New System.Drawing.Point(678, 94)
        Me.ButtonAddUniversitywiseCourses.Name = "ButtonAddUniversitywiseCourses"
        Me.ButtonAddUniversitywiseCourses.Size = New System.Drawing.Size(247, 36)
        Me.ButtonAddUniversitywiseCourses.TabIndex = 15
        Me.ButtonAddUniversitywiseCourses.Text = "Add Courses to Universities"
        Me.ButtonAddUniversitywiseCourses.UseVisualStyleBackColor = True
        '
        'FormAddCoursewiseSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ButtonAddUniversitywiseCourses)
        Me.Controls.Add(Me.PanelCoursewiseSubjects)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddCoursewiseSubjects"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddCoursewiseSubjects.ResumeLayout(False)
        Me.PanelCoursewiseSubjects.ResumeLayout(False)
        Me.PanelCoursewiseSubjects.PerformLayout()
        Me.PanelAddCoursewiseSubjectsLabel.ResumeLayout(False)
        Me.PanelAddCoursewiseSubjectsLabel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddCoursewiseSubjects As Label
    Friend WithEvents ContextMenuStripAddCoursewiseSubjects As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelCoursewiseSubjects As Panel
    Friend WithEvents ComboBoxCourse As ComboBox
    Friend WithEvents ComboBoxSubject As ComboBox
    Friend WithEvents LabelSubject As Label
    Friend WithEvents ButtonAddCoursewiseSubject As Button
    Friend WithEvents PanelAddCoursewiseSubjectsLabel As Panel
    Friend WithEvents LabelCoursewiseSubjects As Label
    Friend WithEvents LabelCourse As Label
    Friend WithEvents ComboBoxSession As ComboBox
    Friend WithEvents LabelSession As Label
    Friend WithEvents ComboBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents ComboBoxUniversity As ComboBox
    Friend WithEvents LabelUniversity As Label
    Friend WithEvents ButtonAddUniversitywiseCourses As Button
End Class
