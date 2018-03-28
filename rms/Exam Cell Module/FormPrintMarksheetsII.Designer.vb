<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrintMarksheetsII
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrintMarksheetsII))
        Me.ErrorProviderAddInformation = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.PanelMarksheet = New System.Windows.Forms.Panel()
        Me.PanelData = New System.Windows.Forms.Panel()
        Me.LabelCollege = New System.Windows.Forms.Label()
        Me.LabelCourse = New System.Windows.Forms.Label()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.ErrorProviderAddInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPage.SuspendLayout()
        Me.PanelAddMarks.SuspendLayout()
        Me.PanelData.SuspendLayout()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProviderAddInformation
        '
        Me.ErrorProviderAddInformation.ContainerControl = Me
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
        Me.ComboBoxRoll.Location = New System.Drawing.Point(900, 3)
        Me.ComboBoxRoll.Name = "ComboBoxRoll"
        Me.ComboBoxRoll.Size = New System.Drawing.Size(330, 31)
        Me.ComboBoxRoll.TabIndex = 13
        '
        'LabelRoll
        '
        Me.LabelRoll.AutoSize = True
        Me.LabelRoll.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRoll.Location = New System.Drawing.Point(677, 4)
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
        Me.ComboBoxCollege.Location = New System.Drawing.Point(139, 7)
        Me.ComboBoxCollege.Name = "ComboBoxCollege"
        Me.ComboBoxCollege.Size = New System.Drawing.Size(330, 31)
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
        Me.PanelPage.Location = New System.Drawing.Point(-8, 66)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Size = New System.Drawing.Size(1366, 662)
        Me.PanelPage.TabIndex = 8
        '
        'PanelAddMarks
        '
        Me.PanelAddMarks.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddMarks.Controls.Add(Me.PanelMarksheet)
        Me.PanelAddMarks.Controls.Add(Me.PanelData)
        Me.PanelAddMarks.Controls.Add(Me.LabelCourse)
        Me.PanelAddMarks.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddMarks.Location = New System.Drawing.Point(43, 3)
        Me.PanelAddMarks.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddMarks.Name = "PanelAddMarks"
        Me.PanelAddMarks.Size = New System.Drawing.Size(1280, 630)
        Me.PanelAddMarks.TabIndex = 1
        '
        'PanelMarksheet
        '
        Me.PanelMarksheet.Location = New System.Drawing.Point(12, 85)
        Me.PanelMarksheet.Name = "PanelMarksheet"
        Me.PanelMarksheet.Size = New System.Drawing.Size(1254, 543)
        Me.PanelMarksheet.TabIndex = 15
        '
        'PanelData
        '
        Me.PanelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelData.Controls.Add(Me.LabelCollege)
        Me.PanelData.Controls.Add(Me.ComboBoxCollege)
        Me.PanelData.Controls.Add(Me.ComboBoxRoll)
        Me.PanelData.Controls.Add(Me.LabelRoll)
        Me.PanelData.Location = New System.Drawing.Point(-8, 37)
        Me.PanelData.Name = "PanelData"
        Me.PanelData.Size = New System.Drawing.Size(1295, 41)
        Me.PanelData.TabIndex = 14
        '
        'LabelCollege
        '
        Me.LabelCollege.AutoSize = True
        Me.LabelCollege.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCollege.Location = New System.Drawing.Point(58, 8)
        Me.LabelCollege.Name = "LabelCollege"
        Me.LabelCollege.Size = New System.Drawing.Size(78, 28)
        Me.LabelCollege.TabIndex = 1
        Me.LabelCollege.Text = "College"
        '
        'LabelCourse
        '
        Me.LabelCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelCourse.Font = New System.Drawing.Font("Alegreya Sans", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCourse.Location = New System.Drawing.Point(-8, -1)
        Me.LabelCourse.Name = "LabelCourse"
        Me.LabelCourse.Size = New System.Drawing.Size(1295, 39)
        Me.LabelCourse.TabIndex = 5
        Me.LabelCourse.Text = "Course"
        Me.LabelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PanelData.ResumeLayout(False)
        Me.PanelData.PerformLayout()
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
    Friend WithEvents ComboBoxRoll As ComboBox
    Friend WithEvents LabelRoll As Label
    Friend WithEvents ComboBoxCollege As ComboBox
    Friend WithEvents LabelCollege As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents LabelCourse As Label
    Friend WithEvents PanelData As Panel
    Friend WithEvents PanelMarksheet As Panel
End Class
