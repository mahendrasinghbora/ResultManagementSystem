<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddCourses))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddCourses = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddCourses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddCourses = New System.Windows.Forms.Panel()
        Me.ButtonAddCourse = New System.Windows.Forms.Button()
        Me.PanelAddCourseLabel = New System.Windows.Forms.Panel()
        Me.LabelCourses = New System.Windows.Forms.Label()
        Me.TextCourse = New System.Windows.Forms.TextBox()
        Me.LabelCourseName = New System.Windows.Forms.Label()
        Me.ErrorProviderCourse = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddCourses.SuspendLayout()
        Me.PanelAddCourses.SuspendLayout()
        Me.PanelAddCourseLabel.SuspendLayout()
        CType(Me.ErrorProviderCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddCourses)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 4
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1072, 5)
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(190, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddCourses
        '
        Me.LabelAddCourses.AutoSize = True
        Me.LabelAddCourses.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCourses.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddCourses.Name = "LabelAddCourses"
        Me.LabelAddCourses.Size = New System.Drawing.Size(139, 39)
        Me.LabelAddCourses.TabIndex = 0
        Me.LabelAddCourses.Text = "Add Courses"
        '
        'ContextMenuStripAddCourses
        '
        Me.ContextMenuStripAddCourses.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddCourses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddCourses.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddCourses.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddCourses
        '
        Me.PanelAddCourses.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddCourses.Controls.Add(Me.ButtonAddCourse)
        Me.PanelAddCourses.Controls.Add(Me.PanelAddCourseLabel)
        Me.PanelAddCourses.Controls.Add(Me.TextCourse)
        Me.PanelAddCourses.Controls.Add(Me.LabelCourseName)
        Me.PanelAddCourses.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddCourses.Location = New System.Drawing.Point(425, 223)
        Me.PanelAddCourses.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddCourses.Name = "PanelAddCourses"
        Me.PanelAddCourses.Size = New System.Drawing.Size(500, 282)
        Me.PanelAddCourses.TabIndex = 5
        '
        'ButtonAddCourse
        '
        Me.ButtonAddCourse.AutoSize = True
        Me.ButtonAddCourse.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCourse.Location = New System.Drawing.Point(176, 213)
        Me.ButtonAddCourse.Name = "ButtonAddCourse"
        Me.ButtonAddCourse.Size = New System.Drawing.Size(147, 36)
        Me.ButtonAddCourse.TabIndex = 7
        Me.ButtonAddCourse.Text = "Add Course"
        Me.ButtonAddCourse.UseVisualStyleBackColor = True
        '
        'PanelAddCourseLabel
        '
        Me.PanelAddCourseLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddCourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddCourseLabel.Controls.Add(Me.LabelCourses)
        Me.PanelAddCourseLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddCourseLabel.Name = "PanelAddCourseLabel"
        Me.PanelAddCourseLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddCourseLabel.TabIndex = 4
        '
        'LabelCourses
        '
        Me.LabelCourses.AutoSize = True
        Me.LabelCourses.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourses.Location = New System.Drawing.Point(162, 15)
        Me.LabelCourses.Name = "LabelCourses"
        Me.LabelCourses.Size = New System.Drawing.Size(174, 46)
        Me.LabelCourses.TabIndex = 3
        Me.LabelCourses.Text = "Add Courses"
        '
        'TextCourse
        '
        Me.TextCourse.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCourse.Location = New System.Drawing.Point(42, 135)
        Me.TextCourse.Name = "TextCourse"
        Me.TextCourse.Size = New System.Drawing.Size(414, 27)
        Me.TextCourse.TabIndex = 2
        '
        'LabelCourseName
        '
        Me.LabelCourseName.AutoSize = True
        Me.LabelCourseName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourseName.Location = New System.Drawing.Point(37, 104)
        Me.LabelCourseName.Name = "LabelCourseName"
        Me.LabelCourseName.Size = New System.Drawing.Size(183, 28)
        Me.LabelCourseName.TabIndex = 1
        Me.LabelCourseName.Text = "Name of the Course"
        '
        'ErrorProviderCourse
        '
        Me.ErrorProviderCourse.ContainerControl = Me
        '
        'FormAddCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddCourses)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddCourses"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddCourses.ResumeLayout(False)
        Me.PanelAddCourses.ResumeLayout(False)
        Me.PanelAddCourses.PerformLayout()
        Me.PanelAddCourseLabel.ResumeLayout(False)
        Me.PanelAddCourseLabel.PerformLayout()
        CType(Me.ErrorProviderCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddCourses As Label
    Friend WithEvents ContextMenuStripAddCourses As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddCourses As Panel
    Friend WithEvents ButtonAddCourse As Button
    Friend WithEvents PanelAddCourseLabel As Panel
    Friend WithEvents LabelCourses As Label
    Friend WithEvents TextCourse As TextBox
    Friend WithEvents LabelCourseName As Label
    Friend WithEvents ErrorProviderCourse As ErrorProvider
End Class
