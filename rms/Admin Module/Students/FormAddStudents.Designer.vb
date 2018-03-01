<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddStudents))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddStudents = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddStudents = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddUsers = New System.Windows.Forms.Panel()
        Me.TextMobile = New System.Windows.Forms.TextBox()
        Me.LabelMobile = New System.Windows.Forms.Label()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.ComboBoxCollege = New System.Windows.Forms.ComboBox()
        Me.LabelCollege = New System.Windows.Forms.Label()
        Me.DateTimePickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.LabelDOB = New System.Windows.Forms.Label()
        Me.TextMother = New System.Windows.Forms.TextBox()
        Me.LabelMother = New System.Windows.Forms.Label()
        Me.RadioButtonGender3 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGender2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGender1 = New System.Windows.Forms.RadioButton()
        Me.LabelUserType = New System.Windows.Forms.Label()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.TextFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.PanelAddStudentsLabel = New System.Windows.Forms.Panel()
        Me.LabelStudents = New System.Windows.Forms.Label()
        Me.TextFather = New System.Windows.Forms.TextBox()
        Me.LabelFather = New System.Windows.Forms.Label()
        Me.ErrorProviderStudent = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddStudents.SuspendLayout()
        Me.PanelAddUsers.SuspendLayout()
        Me.PanelAddStudentsLabel.SuspendLayout()
        CType(Me.ErrorProviderStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddStudents)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 6
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1073, 7)
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(190, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddStudents
        '
        Me.LabelAddStudents.AutoSize = True
        Me.LabelAddStudents.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddStudents.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddStudents.Name = "LabelAddStudents"
        Me.LabelAddStudents.Size = New System.Drawing.Size(151, 39)
        Me.LabelAddStudents.TabIndex = 0
        Me.LabelAddStudents.Text = "Add Students"
        '
        'ContextMenuStripAddStudents
        '
        Me.ContextMenuStripAddStudents.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddStudents.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddStudents.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddStudents.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddUsers
        '
        Me.PanelAddUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddUsers.Controls.Add(Me.TextMobile)
        Me.PanelAddUsers.Controls.Add(Me.LabelMobile)
        Me.PanelAddUsers.Controls.Add(Me.TextEmail)
        Me.PanelAddUsers.Controls.Add(Me.LabelEmail)
        Me.PanelAddUsers.Controls.Add(Me.TextAddress)
        Me.PanelAddUsers.Controls.Add(Me.LabelAddress)
        Me.PanelAddUsers.Controls.Add(Me.ComboBoxCollege)
        Me.PanelAddUsers.Controls.Add(Me.LabelCollege)
        Me.PanelAddUsers.Controls.Add(Me.DateTimePickerDOB)
        Me.PanelAddUsers.Controls.Add(Me.LabelDOB)
        Me.PanelAddUsers.Controls.Add(Me.TextMother)
        Me.PanelAddUsers.Controls.Add(Me.LabelMother)
        Me.PanelAddUsers.Controls.Add(Me.RadioButtonGender3)
        Me.PanelAddUsers.Controls.Add(Me.RadioButtonGender2)
        Me.PanelAddUsers.Controls.Add(Me.RadioButtonGender1)
        Me.PanelAddUsers.Controls.Add(Me.LabelUserType)
        Me.PanelAddUsers.Controls.Add(Me.TextLastName)
        Me.PanelAddUsers.Controls.Add(Me.LabelLastName)
        Me.PanelAddUsers.Controls.Add(Me.ButtonAddStudent)
        Me.PanelAddUsers.Controls.Add(Me.TextFirstName)
        Me.PanelAddUsers.Controls.Add(Me.LabelFirstName)
        Me.PanelAddUsers.Controls.Add(Me.PanelAddStudentsLabel)
        Me.PanelAddUsers.Controls.Add(Me.TextFather)
        Me.PanelAddUsers.Controls.Add(Me.LabelFather)
        Me.PanelAddUsers.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddUsers.Location = New System.Drawing.Point(167, 100)
        Me.PanelAddUsers.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddUsers.Name = "PanelAddUsers"
        Me.PanelAddUsers.Size = New System.Drawing.Size(1017, 571)
        Me.PanelAddUsers.TabIndex = 7
        '
        'TextMobile
        '
        Me.TextMobile.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMobile.Location = New System.Drawing.Point(694, 438)
        Me.TextMobile.Name = "TextMobile"
        Me.TextMobile.Size = New System.Drawing.Size(260, 27)
        Me.TextMobile.TabIndex = 32
        '
        'LabelMobile
        '
        Me.LabelMobile.AutoSize = True
        Me.LabelMobile.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMobile.Location = New System.Drawing.Point(690, 403)
        Me.LabelMobile.Name = "LabelMobile"
        Me.LabelMobile.Size = New System.Drawing.Size(147, 28)
        Me.LabelMobile.TabIndex = 31
        Me.LabelMobile.Text = "Mobile Number"
        '
        'TextEmail
        '
        Me.TextEmail.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmail.Location = New System.Drawing.Point(694, 350)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(260, 27)
        Me.TextEmail.TabIndex = 30
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(690, 315)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(62, 28)
        Me.LabelEmail.TabIndex = 29
        Me.LabelEmail.Text = "Email"
        '
        'TextAddress
        '
        Me.TextAddress.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.Location = New System.Drawing.Point(373, 350)
        Me.TextAddress.Multiline = True
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextAddress.Size = New System.Drawing.Size(260, 115)
        Me.TextAddress.TabIndex = 28
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Location = New System.Drawing.Point(368, 315)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(84, 28)
        Me.LabelAddress.TabIndex = 27
        Me.LabelAddress.Text = "Address"
        '
        'ComboBoxCollege
        '
        Me.ComboBoxCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCollege.DropDownWidth = 325
        Me.ComboBoxCollege.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCollege.FormattingEnabled = True
        Me.ComboBoxCollege.Location = New System.Drawing.Point(52, 150)
        Me.ComboBoxCollege.Name = "ComboBoxCollege"
        Me.ComboBoxCollege.Size = New System.Drawing.Size(260, 31)
        Me.ComboBoxCollege.TabIndex = 26
        '
        'LabelCollege
        '
        Me.LabelCollege.AutoSize = True
        Me.LabelCollege.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCollege.Location = New System.Drawing.Point(47, 110)
        Me.LabelCollege.Name = "LabelCollege"
        Me.LabelCollege.Size = New System.Drawing.Size(78, 28)
        Me.LabelCollege.TabIndex = 24
        Me.LabelCollege.Text = "College"
        '
        'DateTimePickerDOB
        '
        Me.DateTimePickerDOB.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerDOB.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDOB.Location = New System.Drawing.Point(694, 263)
        Me.DateTimePickerDOB.Name = "DateTimePickerDOB"
        Me.DateTimePickerDOB.Size = New System.Drawing.Size(260, 30)
        Me.DateTimePickerDOB.TabIndex = 23
        Me.DateTimePickerDOB.Value = New Date(2018, 3, 1, 0, 0, 0, 0)
        '
        'LabelDOB
        '
        Me.LabelDOB.AutoSize = True
        Me.LabelDOB.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDOB.Location = New System.Drawing.Point(690, 232)
        Me.LabelDOB.Name = "LabelDOB"
        Me.LabelDOB.Size = New System.Drawing.Size(125, 28)
        Me.LabelDOB.TabIndex = 22
        Me.LabelDOB.Text = "Date of Birth"
        '
        'TextMother
        '
        Me.TextMother.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMother.Location = New System.Drawing.Point(373, 267)
        Me.TextMother.Name = "TextMother"
        Me.TextMother.Size = New System.Drawing.Size(260, 27)
        Me.TextMother.TabIndex = 21
        '
        'LabelMother
        '
        Me.LabelMother.AutoSize = True
        Me.LabelMother.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMother.Location = New System.Drawing.Point(368, 232)
        Me.LabelMother.Name = "LabelMother"
        Me.LabelMother.Size = New System.Drawing.Size(146, 28)
        Me.LabelMother.TabIndex = 20
        Me.LabelMother.Text = "Mother's Name"
        '
        'RadioButtonGender3
        '
        Me.RadioButtonGender3.AutoSize = True
        Me.RadioButtonGender3.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonGender3.Location = New System.Drawing.Point(52, 427)
        Me.RadioButtonGender3.Name = "RadioButtonGender3"
        Me.RadioButtonGender3.Size = New System.Drawing.Size(87, 38)
        Me.RadioButtonGender3.TabIndex = 19
        Me.RadioButtonGender3.TabStop = True
        Me.RadioButtonGender3.Text = "Other"
        Me.RadioButtonGender3.UseVisualStyleBackColor = True
        '
        'RadioButtonGender2
        '
        Me.RadioButtonGender2.AutoSize = True
        Me.RadioButtonGender2.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonGender2.Location = New System.Drawing.Point(52, 390)
        Me.RadioButtonGender2.Name = "RadioButtonGender2"
        Me.RadioButtonGender2.Size = New System.Drawing.Size(100, 38)
        Me.RadioButtonGender2.TabIndex = 18
        Me.RadioButtonGender2.TabStop = True
        Me.RadioButtonGender2.Text = "Female"
        Me.RadioButtonGender2.UseVisualStyleBackColor = True
        '
        'RadioButtonGender1
        '
        Me.RadioButtonGender1.AutoSize = True
        Me.RadioButtonGender1.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonGender1.Location = New System.Drawing.Point(52, 350)
        Me.RadioButtonGender1.Name = "RadioButtonGender1"
        Me.RadioButtonGender1.Size = New System.Drawing.Size(80, 38)
        Me.RadioButtonGender1.TabIndex = 17
        Me.RadioButtonGender1.TabStop = True
        Me.RadioButtonGender1.Text = "Male"
        Me.RadioButtonGender1.UseVisualStyleBackColor = True
        '
        'LabelUserType
        '
        Me.LabelUserType.AutoSize = True
        Me.LabelUserType.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserType.Location = New System.Drawing.Point(47, 315)
        Me.LabelUserType.Name = "LabelUserType"
        Me.LabelUserType.Size = New System.Drawing.Size(77, 28)
        Me.LabelUserType.TabIndex = 14
        Me.LabelUserType.Text = "Gender"
        '
        'TextLastName
        '
        Me.TextLastName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLastName.Location = New System.Drawing.Point(694, 154)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(260, 27)
        Me.TextLastName.TabIndex = 9
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(690, 110)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(104, 28)
        Me.LabelLastName.TabIndex = 8
        Me.LabelLastName.Text = "Last Name"
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.AutoSize = True
        Me.ButtonAddStudent.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddStudent.Location = New System.Drawing.Point(437, 517)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(140, 39)
        Me.ButtonAddStudent.TabIndex = 7
        Me.ButtonAddStudent.Text = "Add Student"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'TextFirstName
        '
        Me.TextFirstName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFirstName.Location = New System.Drawing.Point(373, 154)
        Me.TextFirstName.Name = "TextFirstName"
        Me.TextFirstName.Size = New System.Drawing.Size(260, 27)
        Me.TextFirstName.TabIndex = 6
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(368, 110)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(108, 28)
        Me.LabelFirstName.TabIndex = 5
        Me.LabelFirstName.Text = "First Name"
        '
        'PanelAddStudentsLabel
        '
        Me.PanelAddStudentsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddStudentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddStudentsLabel.Controls.Add(Me.LabelStudents)
        Me.PanelAddStudentsLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddStudentsLabel.Name = "PanelAddStudentsLabel"
        Me.PanelAddStudentsLabel.Size = New System.Drawing.Size(1017, 78)
        Me.PanelAddStudentsLabel.TabIndex = 4
        '
        'LabelStudents
        '
        Me.LabelStudents.AutoSize = True
        Me.LabelStudents.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStudents.Location = New System.Drawing.Point(413, 15)
        Me.LabelStudents.Name = "LabelStudents"
        Me.LabelStudents.Size = New System.Drawing.Size(189, 46)
        Me.LabelStudents.TabIndex = 3
        Me.LabelStudents.Text = "Add Students"
        '
        'TextFather
        '
        Me.TextFather.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFather.Location = New System.Drawing.Point(52, 266)
        Me.TextFather.Name = "TextFather"
        Me.TextFather.Size = New System.Drawing.Size(260, 27)
        Me.TextFather.TabIndex = 2
        '
        'LabelFather
        '
        Me.LabelFather.AutoSize = True
        Me.LabelFather.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFather.Location = New System.Drawing.Point(47, 231)
        Me.LabelFather.Name = "LabelFather"
        Me.LabelFather.Size = New System.Drawing.Size(139, 28)
        Me.LabelFather.TabIndex = 1
        Me.LabelFather.Text = "Father's Name"
        '
        'ErrorProviderStudent
        '
        Me.ErrorProviderStudent.ContainerControl = Me
        '
        'FormAddStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddUsers)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddStudents"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddStudents.ResumeLayout(False)
        Me.PanelAddUsers.ResumeLayout(False)
        Me.PanelAddUsers.PerformLayout()
        Me.PanelAddStudentsLabel.ResumeLayout(False)
        Me.PanelAddStudentsLabel.PerformLayout()
        CType(Me.ErrorProviderStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddStudents As Label
    Friend WithEvents ContextMenuStripAddStudents As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddUsers As Panel
    Friend WithEvents RadioButtonGender3 As RadioButton
    Friend WithEvents RadioButtonGender2 As RadioButton
    Friend WithEvents RadioButtonGender1 As RadioButton
    Friend WithEvents LabelUserType As Label
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents TextFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents PanelAddStudentsLabel As Panel
    Friend WithEvents LabelStudents As Label
    Friend WithEvents TextFather As TextBox
    Friend WithEvents LabelFather As Label
    Friend WithEvents TextMother As TextBox
    Friend WithEvents LabelMother As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents LabelCollege As Label
    Friend WithEvents ComboBoxCollege As ComboBox
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents TextMobile As TextBox
    Friend WithEvents LabelMobile As Label
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents ErrorProviderStudent As ErrorProvider
End Class
