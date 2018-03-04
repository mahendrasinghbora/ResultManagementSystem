<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddUniversitywiseCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddUniversitywiseCourses))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddUniversitywiseCourses = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddUniversitywiseCourses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelUniversitywiseCourses = New System.Windows.Forms.Panel()
        Me.ComboBoxUniversity = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.ButtonAddUniversitywiseCourses = New System.Windows.Forms.Button()
        Me.PanelAddUniversitywiseCoursesLabel = New System.Windows.Forms.Panel()
        Me.LabelUniversitywiseCourses = New System.Windows.Forms.Label()
        Me.LabelUniversity = New System.Windows.Forms.Label()
        Me.ButtonAddCollegewiseCourses = New System.Windows.Forms.Button()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddUniversitywiseCourses.SuspendLayout()
        Me.PanelUniversitywiseCourses.SuspendLayout()
        Me.PanelAddUniversitywiseCoursesLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddUniversitywiseCourses)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 7
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(325, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddUniversitywiseCourses
        '
        Me.LabelAddUniversitywiseCourses.AutoSize = True
        Me.LabelAddUniversitywiseCourses.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUniversitywiseCourses.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddUniversitywiseCourses.Name = "LabelAddUniversitywiseCourses"
        Me.LabelAddUniversitywiseCourses.Size = New System.Drawing.Size(290, 39)
        Me.LabelAddUniversitywiseCourses.TabIndex = 0
        Me.LabelAddUniversitywiseCourses.Text = "Add Universitywise Courses"
        '
        'ContextMenuStripAddUniversitywiseCourses
        '
        Me.ContextMenuStripAddUniversitywiseCourses.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddUniversitywiseCourses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddUniversitywiseCourses.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddUniversitywiseCourses.Size = New System.Drawing.Size(184, 76)
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
        'PanelUniversitywiseCourses
        '
        Me.PanelUniversitywiseCourses.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelUniversitywiseCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUniversitywiseCourses.Controls.Add(Me.ComboBoxUniversity)
        Me.PanelUniversitywiseCourses.Controls.Add(Me.ComboBoxCourse)
        Me.PanelUniversitywiseCourses.Controls.Add(Me.LabelCourse)
        Me.PanelUniversitywiseCourses.Controls.Add(Me.ButtonAddUniversitywiseCourses)
        Me.PanelUniversitywiseCourses.Controls.Add(Me.PanelAddUniversitywiseCoursesLabel)
        Me.PanelUniversitywiseCourses.Controls.Add(Me.LabelUniversity)
        Me.PanelUniversitywiseCourses.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelUniversitywiseCourses.Location = New System.Drawing.Point(425, 206)
        Me.PanelUniversitywiseCourses.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelUniversitywiseCourses.Name = "PanelUniversitywiseCourses"
        Me.PanelUniversitywiseCourses.Size = New System.Drawing.Size(500, 384)
        Me.PanelUniversitywiseCourses.TabIndex = 8
        '
        'ComboBoxUniversity
        '
        Me.ComboBoxUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUniversity.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUniversity.FormattingEnabled = True
        Me.ComboBoxUniversity.Location = New System.Drawing.Point(42, 153)
        Me.ComboBoxUniversity.Name = "ComboBoxUniversity"
        Me.ComboBoxUniversity.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxUniversity.TabIndex = 10
        '
        'ComboBoxCourse
        '
        Me.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCourse.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourse.FormattingEnabled = True
        Me.ComboBoxCourse.Location = New System.Drawing.Point(42, 241)
        Me.ComboBoxCourse.Name = "ComboBoxCourse"
        Me.ComboBoxCourse.Size = New System.Drawing.Size(414, 31)
        Me.ComboBoxCourse.TabIndex = 9
        '
        'LabelCourse
        '
        Me.LabelCourse.AutoSize = True
        Me.LabelCourse.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(37, 208)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(73, 28)
        Me.LabelCourse.TabIndex = 8
        Me.LabelCourse.Text = "Course"
        '
        'ButtonAddUniversitywiseCourses
        '
        Me.ButtonAddUniversitywiseCourses.AutoSize = True
        Me.ButtonAddUniversitywiseCourses.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddUniversitywiseCourses.Location = New System.Drawing.Point(121, 311)
        Me.ButtonAddUniversitywiseCourses.Name = "ButtonAddUniversitywiseCourses"
        Me.ButtonAddUniversitywiseCourses.Size = New System.Drawing.Size(257, 36)
        Me.ButtonAddUniversitywiseCourses.TabIndex = 7
        Me.ButtonAddUniversitywiseCourses.Text = "Add Course to the University"
        Me.ButtonAddUniversitywiseCourses.UseVisualStyleBackColor = True
        '
        'PanelAddUniversitywiseCoursesLabel
        '
        Me.PanelAddUniversitywiseCoursesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddUniversitywiseCoursesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddUniversitywiseCoursesLabel.Controls.Add(Me.LabelUniversitywiseCourses)
        Me.PanelAddUniversitywiseCoursesLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddUniversitywiseCoursesLabel.Name = "PanelAddUniversitywiseCoursesLabel"
        Me.PanelAddUniversitywiseCoursesLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddUniversitywiseCoursesLabel.TabIndex = 4
        '
        'LabelUniversitywiseCourses
        '
        Me.LabelUniversitywiseCourses.AutoSize = True
        Me.LabelUniversitywiseCourses.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversitywiseCourses.Location = New System.Drawing.Point(70, 15)
        Me.LabelUniversitywiseCourses.Name = "LabelUniversitywiseCourses"
        Me.LabelUniversitywiseCourses.Size = New System.Drawing.Size(358, 46)
        Me.LabelUniversitywiseCourses.TabIndex = 3
        Me.LabelUniversitywiseCourses.Text = "Add Courses to Universities"
        '
        'LabelUniversity
        '
        Me.LabelUniversity.AutoSize = True
        Me.LabelUniversity.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversity.Location = New System.Drawing.Point(37, 117)
        Me.LabelUniversity.Name = "LabelUniversity"
        Me.LabelUniversity.Size = New System.Drawing.Size(103, 28)
        Me.LabelUniversity.TabIndex = 1
        Me.LabelUniversity.Text = "University"
        '
        'ButtonAddCollegewiseCourses
        '
        Me.ButtonAddCollegewiseCourses.AutoSize = True
        Me.ButtonAddCollegewiseCourses.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCollegewiseCourses.Location = New System.Drawing.Point(678, 164)
        Me.ButtonAddCollegewiseCourses.Name = "ButtonAddCollegewiseCourses"
        Me.ButtonAddCollegewiseCourses.Size = New System.Drawing.Size(247, 36)
        Me.ButtonAddCollegewiseCourses.TabIndex = 11
        Me.ButtonAddCollegewiseCourses.Text = "Add Courses to Colleges"
        Me.ButtonAddCollegewiseCourses.UseVisualStyleBackColor = True
        '
        'FormAddUniversitywiseCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ButtonAddCollegewiseCourses)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Controls.Add(Me.PanelUniversitywiseCourses)
        Me.Name = "FormAddUniversitywiseCourses"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddUniversitywiseCourses.ResumeLayout(False)
        Me.PanelUniversitywiseCourses.ResumeLayout(False)
        Me.PanelUniversitywiseCourses.PerformLayout()
        Me.PanelAddUniversitywiseCoursesLabel.ResumeLayout(False)
        Me.PanelAddUniversitywiseCoursesLabel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddUniversitywiseCourses As Label
    Friend WithEvents ContextMenuStripAddUniversitywiseCourses As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelUniversitywiseCourses As Panel
    Friend WithEvents ComboBoxUniversity As ComboBox
    Friend WithEvents ComboBoxCourse As ComboBox
    Friend WithEvents LabelCourse As Label
    Friend WithEvents ButtonAddUniversitywiseCourses As Button
    Friend WithEvents PanelAddUniversitywiseCoursesLabel As Panel
    Friend WithEvents LabelUniversitywiseCourses As Label
    Friend WithEvents LabelUniversity As Label
    Friend WithEvents ButtonAddCollegewiseCourses As Button
End Class
