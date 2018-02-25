<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSemesters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddSemesters))
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddSemesters = New System.Windows.Forms.Label()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddSemesters = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddSemesters = New System.Windows.Forms.Panel()
        Me.ButtonAddSemester = New System.Windows.Forms.Button()
        Me.PanelAddSemesterLabel = New System.Windows.Forms.Panel()
        Me.LabelSemesters = New System.Windows.Forms.Label()
        Me.TextSemester = New System.Windows.Forms.TextBox()
        Me.LabelSemesterName = New System.Windows.Forms.Label()
        Me.ErrorProviderSemester = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddSemesters.SuspendLayout()
        Me.PanelAddSemesters.SuspendLayout()
        Me.PanelAddSemesterLabel.SuspendLayout()
        CType(Me.ErrorProviderSemester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDashboard
        '
        Me.ButtonDashboard.Font = New System.Drawing.Font("Acme", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDashboard.Location = New System.Drawing.Point(199, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddSemesters
        '
        Me.LabelAddSemesters.AutoSize = True
        Me.LabelAddSemesters.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddSemesters.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddSemesters.Name = "LabelAddSemesters"
        Me.LabelAddSemesters.Size = New System.Drawing.Size(161, 39)
        Me.LabelAddSemesters.TabIndex = 0
        Me.LabelAddSemesters.Text = "Add Semesters"
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddSemesters)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
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
        'ContextMenuStripAddSemesters
        '
        Me.ContextMenuStripAddSemesters.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddSemesters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddSemesters.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddSemesters.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddSemesters
        '
        Me.PanelAddSemesters.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddSemesters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSemesters.Controls.Add(Me.ButtonAddSemester)
        Me.PanelAddSemesters.Controls.Add(Me.PanelAddSemesterLabel)
        Me.PanelAddSemesters.Controls.Add(Me.TextSemester)
        Me.PanelAddSemesters.Controls.Add(Me.LabelSemesterName)
        Me.PanelAddSemesters.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddSemesters.Location = New System.Drawing.Point(425, 223)
        Me.PanelAddSemesters.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddSemesters.Name = "PanelAddSemesters"
        Me.PanelAddSemesters.Size = New System.Drawing.Size(500, 282)
        Me.PanelAddSemesters.TabIndex = 7
        '
        'ButtonAddSemester
        '
        Me.ButtonAddSemester.AutoSize = True
        Me.ButtonAddSemester.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddSemester.Location = New System.Drawing.Point(176, 213)
        Me.ButtonAddSemester.Name = "ButtonAddSemester"
        Me.ButtonAddSemester.Size = New System.Drawing.Size(147, 36)
        Me.ButtonAddSemester.TabIndex = 7
        Me.ButtonAddSemester.Text = "Add Semester"
        Me.ButtonAddSemester.UseVisualStyleBackColor = True
        '
        'PanelAddSemesterLabel
        '
        Me.PanelAddSemesterLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddSemesterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSemesterLabel.Controls.Add(Me.LabelSemesters)
        Me.PanelAddSemesterLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddSemesterLabel.Name = "PanelAddSemesterLabel"
        Me.PanelAddSemesterLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddSemesterLabel.TabIndex = 4
        '
        'LabelSemesters
        '
        Me.LabelSemesters.AutoSize = True
        Me.LabelSemesters.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemesters.Location = New System.Drawing.Point(146, 15)
        Me.LabelSemesters.Name = "LabelSemesters"
        Me.LabelSemesters.Size = New System.Drawing.Size(206, 46)
        Me.LabelSemesters.TabIndex = 3
        Me.LabelSemesters.Text = "Add Semesters"
        '
        'TextSemester
        '
        Me.TextSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSemester.Location = New System.Drawing.Point(42, 135)
        Me.TextSemester.Name = "TextSemester"
        Me.TextSemester.Size = New System.Drawing.Size(414, 27)
        Me.TextSemester.TabIndex = 2
        '
        'LabelSemesterName
        '
        Me.LabelSemesterName.AutoSize = True
        Me.LabelSemesterName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemesterName.Location = New System.Drawing.Point(37, 104)
        Me.LabelSemesterName.Name = "LabelSemesterName"
        Me.LabelSemesterName.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemesterName.TabIndex = 1
        Me.LabelSemesterName.Text = "Semester"
        '
        'ErrorProviderSemester
        '
        Me.ErrorProviderSemester.ContainerControl = Me
        '
        'FormAddSemesters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddSemesters)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddSemesters"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddSemesters.ResumeLayout(False)
        Me.PanelAddSemesters.ResumeLayout(False)
        Me.PanelAddSemesters.PerformLayout()
        Me.PanelAddSemesterLabel.ResumeLayout(False)
        Me.PanelAddSemesterLabel.PerformLayout()
        CType(Me.ErrorProviderSemester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddSemesters As Label
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ContextMenuStripAddSemesters As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddSemesters As Panel
    Friend WithEvents ButtonAddSemester As Button
    Friend WithEvents PanelAddSemesterLabel As Panel
    Friend WithEvents LabelSemesters As Label
    Friend WithEvents TextSemester As TextBox
    Friend WithEvents LabelSemesterName As Label
    Friend WithEvents ErrorProviderSemester As ErrorProvider
End Class
