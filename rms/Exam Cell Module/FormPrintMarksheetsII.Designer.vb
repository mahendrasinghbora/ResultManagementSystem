<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintMarksheetsII
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrintMarksheetsII))
        Me.ErrorProviderAddInformation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextSemester = New System.Windows.Forms.TextBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.TextSession = New System.Windows.Forms.TextBox()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelPrintMarksheetsPanel = New System.Windows.Forms.Label()
        Me.ComboBoxRoll = New System.Windows.Forms.ComboBox()
        Me.LabelRoll = New System.Windows.Forms.Label()
        Me.ComboBoxCollege = New System.Windows.Forms.ComboBox()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.PanelAddMarks = New System.Windows.Forms.Panel()
        Me.PanelAddMarksLabel = New System.Windows.Forms.Panel()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.LabelAddMarks = New System.Windows.Forms.Label()
        Me.LabelCollege = New System.Windows.Forms.Label()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.ErrorProviderAddInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPage.SuspendLayout()
        Me.PanelAddMarks.SuspendLayout()
        Me.PanelAddMarksLabel.SuspendLayout()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProviderAddInformation
        '
        Me.ErrorProviderAddInformation.ContainerControl = Me
        '
        'TextSemester
        '
        Me.TextSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSemester.Location = New System.Drawing.Point(1177, 123)
        Me.TextSemester.Name = "TextSemester"
        Me.TextSemester.ReadOnly = True
        Me.TextSemester.Size = New System.Drawing.Size(86, 27)
        Me.TextSemester.TabIndex = 19
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(1078, 122)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemester.TabIndex = 18
        Me.LabelSemester.Text = "Semester"
        '
        'TextSession
        '
        Me.TextSession.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSession.Location = New System.Drawing.Point(889, 123)
        Me.TextSession.Name = "TextSession"
        Me.TextSession.ReadOnly = True
        Me.TextSession.Size = New System.Drawing.Size(133, 27)
        Me.TextSession.TabIndex = 17
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(807, 122)
        Me.LabelSession.Name = "LabelSession"
        Me.LabelSession.Size = New System.Drawing.Size(79, 28)
        Me.LabelSession.TabIndex = 16
        Me.LabelSession.Text = "Session"
        '
        'TextName
        '
        Me.TextName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(224, 123)
        Me.TextName.Name = "TextName"
        Me.TextName.ReadOnly = True
        Me.TextName.Size = New System.Drawing.Size(253, 27)
        Me.TextName.TabIndex = 15
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(25, 122)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(193, 28)
        Me.LabelName.TabIndex = 14
        Me.LabelName.Text = "Name of the Student"
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelPrintMarksheetsPanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 7
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(222, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelPrintMarksheetsPanel
        '
        Me.LabelPrintMarksheetsPanel.AutoSize = True
        Me.LabelPrintMarksheetsPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrintMarksheetsPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelPrintMarksheetsPanel.Name = "LabelPrintMarksheetsPanel"
        Me.LabelPrintMarksheetsPanel.Size = New System.Drawing.Size(186, 39)
        Me.LabelPrintMarksheetsPanel.TabIndex = 0
        Me.LabelPrintMarksheetsPanel.Text = "Print Marksheets"
        '
        'ComboBoxRoll
        '
        Me.ComboBoxRoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRoll.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRoll.FormattingEnabled = True
        Me.ComboBoxRoll.Location = New System.Drawing.Point(1028, 80)
        Me.ComboBoxRoll.Name = "ComboBoxRoll"
        Me.ComboBoxRoll.Size = New System.Drawing.Size(235, 31)
        Me.ComboBoxRoll.TabIndex = 13
        '
        'LabelRoll
        '
        Me.LabelRoll.AutoSize = True
        Me.LabelRoll.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRoll.Location = New System.Drawing.Point(807, 81)
        Me.LabelRoll.Name = "LabelRoll"
        Me.LabelRoll.Size = New System.Drawing.Size(218, 28)
        Me.LabelRoll.TabIndex = 12
        Me.LabelRoll.Text = "University Roll Number"
        '
        'ComboBoxCollege
        '
        Me.ComboBoxCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCollege.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCollege.FormattingEnabled = True
        Me.ComboBoxCollege.Location = New System.Drawing.Point(100, 80)
        Me.ComboBoxCollege.Name = "ComboBoxCollege"
        Me.ComboBoxCollege.Size = New System.Drawing.Size(377, 31)
        Me.ComboBoxCollege.TabIndex = 11
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
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelAddMarks)
        Me.PanelPage.Location = New System.Drawing.Point(-12, 66)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 662)
        Me.PanelPage.TabIndex = 8
        '
        'PanelAddMarks
        '
        Me.PanelAddMarks.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddMarks.Controls.Add(Me.TextSemester)
        Me.PanelAddMarks.Controls.Add(Me.LabelSemester)
        Me.PanelAddMarks.Controls.Add(Me.TextSession)
        Me.PanelAddMarks.Controls.Add(Me.LabelSession)
        Me.PanelAddMarks.Controls.Add(Me.TextName)
        Me.PanelAddMarks.Controls.Add(Me.LabelName)
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxRoll)
        Me.PanelAddMarks.Controls.Add(Me.LabelRoll)
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxCollege)
        Me.PanelAddMarks.Controls.Add(Me.PanelAddMarksLabel)
        Me.PanelAddMarks.Controls.Add(Me.LabelCollege)
        Me.PanelAddMarks.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddMarks.Location = New System.Drawing.Point(36, 21)
        Me.PanelAddMarks.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddMarks.Name = "PanelAddMarks"
        Me.PanelAddMarks.Size = New System.Drawing.Size(1295, 630)
        Me.PanelAddMarks.TabIndex = 1
        '
        'PanelAddMarksLabel
        '
        Me.PanelAddMarksLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddMarksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddMarksLabel.Controls.Add(Me.LabelCourse)
        Me.PanelAddMarksLabel.Controls.Add(Me.LabelAddMarks)
        Me.PanelAddMarksLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddMarksLabel.Name = "PanelAddMarksLabel"
        Me.PanelAddMarksLabel.Size = New System.Drawing.Size(1295, 78)
        Me.PanelAddMarksLabel.TabIndex = 4
        '
        'LabelCourse
        '
        Me.LabelCourse.Font = New System.Drawing.Font("Alegreya Sans", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(-1, 35)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(1295, 35)
        Me.LabelCourse.TabIndex = 4
        Me.LabelCourse.Text = "Course"
        Me.LabelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAddMarks
        '
        Me.LabelAddMarks.Font = New System.Drawing.Font("Alegreya Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddMarks.Location = New System.Drawing.Point(514, 0)
        Me.LabelAddMarks.Name = "LabelAddMarks"
        Me.LabelAddMarks.Size = New System.Drawing.Size(265, 35)
        Me.LabelAddMarks.TabIndex = 3
        Me.LabelAddMarks.Text = "Add Marks Information"
        Me.LabelAddMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCollege
        '
        Me.LabelCollege.AutoSize = True
        Me.LabelCollege.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCollege.Location = New System.Drawing.Point(25, 81)
        Me.LabelCollege.Name = "LabelCollege"
        Me.LabelCollege.Size = New System.Drawing.Size(78, 28)
        Me.LabelCollege.TabIndex = 1
        Me.LabelCollege.Text = "College"
        '
        'ContextMenuStripUsers
        '
        Me.ContextMenuStripUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUsers.Size = New System.Drawing.Size(184, 76)
        '
        'FormPrintMarksheetsII
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Controls.Add(Me.PanelPage)
        Me.Name = "FormPrintMarksheetsII"
        Me.ShowIcon = False
        CType(Me.ErrorProviderAddInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPage.ResumeLayout(False)
        Me.PanelAddMarks.ResumeLayout(False)
        Me.PanelAddMarks.PerformLayout()
        Me.PanelAddMarksLabel.ResumeLayout(False)
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProviderAddInformation As ErrorProvider
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelPrintMarksheetsPanel As Label
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelAddMarks As Panel
    Friend WithEvents TextSemester As TextBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents TextSession As TextBox
    Friend WithEvents LabelSession As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents ComboBoxRoll As ComboBox
    Friend WithEvents LabelRoll As Label
    Friend WithEvents ComboBoxCollege As ComboBox
    Friend WithEvents PanelAddMarksLabel As Panel
    Friend WithEvents LabelCourse As Label
    Friend WithEvents LabelAddMarks As Label
    Friend WithEvents LabelCollege As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
End Class
