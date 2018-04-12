<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddBackInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddBackInformation))
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelBackPanel = New System.Windows.Forms.Label()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.LabelRollNumber = New System.Windows.Forms.Label()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.ButtonAddBackInformation = New System.Windows.Forms.Button()
        Me.PanelBackLabel = New System.Windows.Forms.Panel()
        Me.LabelBack = New System.Windows.Forms.Label()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelAddMarks = New System.Windows.Forms.Panel()
        Me.TextNewMarks = New System.Windows.Forms.TextBox()
        Me.LabelNewMarks = New System.Windows.Forms.Label()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.ComboBoxSubject = New System.Windows.Forms.ComboBox()
        Me.TextSession = New System.Windows.Forms.TextBox()
        Me.TextSemester = New System.Windows.Forms.TextBox()
        Me.TextRollNumber = New System.Windows.Forms.TextBox()
        Me.PanelPage = New System.Windows.Forms.Panel()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.ErrorProviderBackInformation = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBackLabel.SuspendLayout()
        Me.ContextMenuStripUsers.SuspendLayout()
        Me.PanelAddMarks.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.ErrorProviderBackInformation, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelBackPanel
        '
        Me.LabelBackPanel.AutoSize = True
        Me.LabelBackPanel.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBackPanel.Location = New System.Drawing.Point(33, 9)
        Me.LabelBackPanel.Name = "LabelBackPanel"
        Me.LabelBackPanel.Size = New System.Drawing.Size(236, 39)
        Me.LabelBackPanel.TabIndex = 0
        Me.LabelBackPanel.Text = "Add Back Information"
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(276, 264)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemester.TabIndex = 16
        Me.LabelSemester.Text = "Semester"
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(98, 265)
        Me.LabelSession.Name = "LabelSession"
        Me.LabelSession.Size = New System.Drawing.Size(79, 28)
        Me.LabelSession.TabIndex = 14
        Me.LabelSession.Text = "Session"
        '
        'LabelRollNumber
        '
        Me.LabelRollNumber.AutoSize = True
        Me.LabelRollNumber.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRollNumber.Location = New System.Drawing.Point(97, 106)
        Me.LabelRollNumber.Name = "LabelRollNumber"
        Me.LabelRollNumber.Size = New System.Drawing.Size(218, 28)
        Me.LabelRollNumber.TabIndex = 12
        Me.LabelRollNumber.Text = "University Roll Number"
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
        'ButtonAddBackInformation
        '
        Me.ButtonAddBackInformation.AutoSize = True
        Me.ButtonAddBackInformation.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddBackInformation.Location = New System.Drawing.Point(183, 419)
        Me.ButtonAddBackInformation.Name = "ButtonAddBackInformation"
        Me.ButtonAddBackInformation.Size = New System.Drawing.Size(177, 39)
        Me.ButtonAddBackInformation.TabIndex = 7
        Me.ButtonAddBackInformation.Text = "Add Information"
        Me.ButtonAddBackInformation.UseVisualStyleBackColor = True
        '
        'PanelBackLabel
        '
        Me.PanelBackLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBackLabel.Controls.Add(Me.LabelBack)
        Me.PanelBackLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelBackLabel.Name = "PanelBackLabel"
        Me.PanelBackLabel.Size = New System.Drawing.Size(544, 78)
        Me.PanelBackLabel.TabIndex = 4
        '
        'LabelBack
        '
        Me.LabelBack.AutoSize = True
        Me.LabelBack.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBack.Location = New System.Drawing.Point(124, 15)
        Me.LabelBack.Name = "LabelBack"
        Me.LabelBack.Size = New System.Drawing.Size(294, 46)
        Me.LabelBack.TabIndex = 3
        Me.LabelBack.Text = "Add Back Information"
        '
        'ContextMenuStripUsers
        '
        Me.ContextMenuStripUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUsers.Size = New System.Drawing.Size(184, 76)
        '
        'PanelAddMarks
        '
        Me.PanelAddMarks.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddMarks.Controls.Add(Me.TextNewMarks)
        Me.PanelAddMarks.Controls.Add(Me.LabelNewMarks)
        Me.PanelAddMarks.Controls.Add(Me.LabelSubject)
        Me.PanelAddMarks.Controls.Add(Me.ComboBoxSubject)
        Me.PanelAddMarks.Controls.Add(Me.TextSession)
        Me.PanelAddMarks.Controls.Add(Me.TextSemester)
        Me.PanelAddMarks.Controls.Add(Me.TextRollNumber)
        Me.PanelAddMarks.Controls.Add(Me.LabelSemester)
        Me.PanelAddMarks.Controls.Add(Me.LabelSession)
        Me.PanelAddMarks.Controls.Add(Me.LabelRollNumber)
        Me.PanelAddMarks.Controls.Add(Me.ButtonAddBackInformation)
        Me.PanelAddMarks.Controls.Add(Me.PanelBackLabel)
        Me.PanelAddMarks.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddMarks.Location = New System.Drawing.Point(382, 85)
        Me.PanelAddMarks.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddMarks.Name = "PanelAddMarks"
        Me.PanelAddMarks.Size = New System.Drawing.Size(544, 478)
        Me.PanelAddMarks.TabIndex = 1
        '
        'TextNewMarks
        '
        Me.TextNewMarks.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNewMarks.Location = New System.Drawing.Point(102, 372)
        Me.TextNewMarks.Name = "TextNewMarks"
        Me.TextNewMarks.Size = New System.Drawing.Size(339, 27)
        Me.TextNewMarks.TabIndex = 24
        '
        'LabelNewMarks
        '
        Me.LabelNewMarks.AutoSize = True
        Me.LabelNewMarks.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNewMarks.Location = New System.Drawing.Point(97, 343)
        Me.LabelNewMarks.Name = "LabelNewMarks"
        Me.LabelNewMarks.Size = New System.Drawing.Size(110, 28)
        Me.LabelNewMarks.TabIndex = 23
        Me.LabelNewMarks.Text = "New Marks"
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubject.Location = New System.Drawing.Point(97, 183)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(76, 28)
        Me.LabelSubject.TabIndex = 22
        Me.LabelSubject.Text = "Subject"
        '
        'ComboBoxSubject
        '
        Me.ComboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSubject.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubject.FormattingEnabled = True
        Me.ComboBoxSubject.Location = New System.Drawing.Point(102, 214)
        Me.ComboBoxSubject.Name = "ComboBoxSubject"
        Me.ComboBoxSubject.Size = New System.Drawing.Size(339, 31)
        Me.ComboBoxSubject.TabIndex = 21
        '
        'TextSession
        '
        Me.TextSession.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSession.Location = New System.Drawing.Point(102, 295)
        Me.TextSession.Name = "TextSession"
        Me.TextSession.ReadOnly = True
        Me.TextSession.Size = New System.Drawing.Size(160, 27)
        Me.TextSession.TabIndex = 20
        '
        'TextSemester
        '
        Me.TextSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSemester.Location = New System.Drawing.Point(281, 295)
        Me.TextSemester.Name = "TextSemester"
        Me.TextSemester.ReadOnly = True
        Me.TextSemester.Size = New System.Drawing.Size(160, 27)
        Me.TextSemester.TabIndex = 19
        '
        'TextRollNumber
        '
        Me.TextRollNumber.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRollNumber.Location = New System.Drawing.Point(102, 137)
        Me.TextRollNumber.Name = "TextRollNumber"
        Me.TextRollNumber.Size = New System.Drawing.Size(339, 27)
        Me.TextRollNumber.TabIndex = 18
        '
        'PanelPage
        '
        Me.PanelPage.Controls.Add(Me.PanelAddMarks)
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
        Me.PanelNavigation.Controls.Add(Me.LabelBackPanel)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 5
        '
        'ErrorProviderBackInformation
        '
        Me.ErrorProviderBackInformation.ContainerControl = Me
        '
        'FormAddBackInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelPage)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddBackInformation"
        Me.ShowIcon = False
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBackLabel.ResumeLayout(False)
        Me.PanelBackLabel.PerformLayout()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        Me.PanelAddMarks.ResumeLayout(False)
        Me.PanelAddMarks.PerformLayout()
        Me.PanelPage.ResumeLayout(False)
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.ErrorProviderBackInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelBackPanel As Label
    Friend WithEvents LabelSemester As Label
    Friend WithEvents LabelSession As Label
    Friend WithEvents LabelRollNumber As Label
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents ButtonAddBackInformation As Button
    Friend WithEvents PanelBackLabel As Panel
    Friend WithEvents LabelBack As Label
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents PanelAddMarks As Panel
    Friend WithEvents PanelPage As Panel
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents TextRollNumber As TextBox
    Friend WithEvents TextSession As TextBox
    Friend WithEvents TextSemester As TextBox
    Friend WithEvents LabelSubject As Label
    Friend WithEvents ComboBoxSubject As ComboBox
    Friend WithEvents TextNewMarks As TextBox
    Friend WithEvents LabelNewMarks As Label
    Friend WithEvents ErrorProviderBackInformation As ErrorProvider
End Class
