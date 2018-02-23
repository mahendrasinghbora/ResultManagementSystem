<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminDashboard))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelDashboard = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtonOption8 = New System.Windows.Forms.Button()
        Me.LabelOption8 = New System.Windows.Forms.Label()
        Me.ButtonOption11 = New System.Windows.Forms.Button()
        Me.LabelOption11 = New System.Windows.Forms.Label()
        Me.ButtonOption3 = New System.Windows.Forms.Button()
        Me.LabelOption3 = New System.Windows.Forms.Label()
        Me.ButtonOption7 = New System.Windows.Forms.Button()
        Me.LabelOption7 = New System.Windows.Forms.Label()
        Me.ButtonOption10 = New System.Windows.Forms.Button()
        Me.LabelOption10 = New System.Windows.Forms.Label()
        Me.ButtonOption12 = New System.Windows.Forms.Button()
        Me.LabelOption12 = New System.Windows.Forms.Label()
        Me.ButtonOption9 = New System.Windows.Forms.Button()
        Me.LabelOption9 = New System.Windows.Forms.Label()
        Me.ButtonOption6 = New System.Windows.Forms.Button()
        Me.LabelOption6 = New System.Windows.Forms.Label()
        Me.ButtonOption5 = New System.Windows.Forms.Button()
        Me.LabelOption5 = New System.Windows.Forms.Label()
        Me.ButtonOption2 = New System.Windows.Forms.Button()
        Me.LabelOption2 = New System.Windows.Forms.Label()
        Me.ButtonOption4 = New System.Windows.Forms.Button()
        Me.LabelOption4 = New System.Windows.Forms.Label()
        Me.ButtonOption1 = New System.Windows.Forms.Button()
        Me.LabelOption1 = New System.Windows.Forms.Label()
        Me.ContextMenuStripUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.ContextMenuStripUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.LabelDashboard)
        Me.PanelNavigation.Location = New System.Drawing.Point(-8, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 0
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1064, 5)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 3
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
        'LabelDashboard
        '
        Me.LabelDashboard.AutoSize = True
        Me.LabelDashboard.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDashboard.Location = New System.Drawing.Point(33, 9)
        Me.LabelDashboard.Name = "LabelDashboard"
        Me.LabelDashboard.Size = New System.Drawing.Size(211, 39)
        Me.LabelDashboard.TabIndex = 0
        Me.LabelDashboard.Text = "Admin's Dashboard"
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.ButtonOption8)
        Me.PanelMenu.Controls.Add(Me.LabelOption8)
        Me.PanelMenu.Controls.Add(Me.ButtonOption11)
        Me.PanelMenu.Controls.Add(Me.LabelOption11)
        Me.PanelMenu.Controls.Add(Me.ButtonOption3)
        Me.PanelMenu.Controls.Add(Me.LabelOption3)
        Me.PanelMenu.Controls.Add(Me.ButtonOption7)
        Me.PanelMenu.Controls.Add(Me.LabelOption7)
        Me.PanelMenu.Controls.Add(Me.ButtonOption10)
        Me.PanelMenu.Controls.Add(Me.LabelOption10)
        Me.PanelMenu.Controls.Add(Me.ButtonOption12)
        Me.PanelMenu.Controls.Add(Me.LabelOption12)
        Me.PanelMenu.Controls.Add(Me.ButtonOption9)
        Me.PanelMenu.Controls.Add(Me.LabelOption9)
        Me.PanelMenu.Controls.Add(Me.ButtonOption6)
        Me.PanelMenu.Controls.Add(Me.LabelOption6)
        Me.PanelMenu.Controls.Add(Me.ButtonOption5)
        Me.PanelMenu.Controls.Add(Me.LabelOption5)
        Me.PanelMenu.Controls.Add(Me.ButtonOption2)
        Me.PanelMenu.Controls.Add(Me.LabelOption2)
        Me.PanelMenu.Controls.Add(Me.ButtonOption4)
        Me.PanelMenu.Controls.Add(Me.LabelOption4)
        Me.PanelMenu.Controls.Add(Me.ButtonOption1)
        Me.PanelMenu.Controls.Add(Me.LabelOption1)
        Me.PanelMenu.Location = New System.Drawing.Point(-8, 86)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1366, 643)
        Me.PanelMenu.TabIndex = 1
        '
        'ButtonOption8
        '
        Me.ButtonOption8.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption8.Location = New System.Drawing.Point(1097, 355)
        Me.ButtonOption8.Name = "ButtonOption8"
        Me.ButtonOption8.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption8.TabIndex = 31
        Me.ButtonOption8.Text = "Add Subjects"
        Me.ButtonOption8.UseVisualStyleBackColor = True
        '
        'LabelOption8
        '
        Me.LabelOption8.BackColor = System.Drawing.Color.White
        Me.LabelOption8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption8.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption8.Location = New System.Drawing.Point(1037, 236)
        Me.LabelOption8.Name = "LabelOption8"
        Me.LabelOption8.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption8.TabIndex = 30
        Me.LabelOption8.Text = "Add new subjects to the system."
        Me.LabelOption8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption11
        '
        Me.ButtonOption11.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption11.Location = New System.Drawing.Point(758, 571)
        Me.ButtonOption11.Name = "ButtonOption11"
        Me.ButtonOption11.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption11.TabIndex = 29
        Me.ButtonOption11.Text = "Add Result Criteria"
        Me.ButtonOption11.UseVisualStyleBackColor = True
        '
        'LabelOption11
        '
        Me.LabelOption11.BackColor = System.Drawing.Color.White
        Me.LabelOption11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption11.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption11.Location = New System.Drawing.Point(698, 452)
        Me.LabelOption11.Name = "LabelOption11"
        Me.LabelOption11.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption11.TabIndex = 28
        Me.LabelOption11.Text = "Add new result criteria to the system."
        Me.LabelOption11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption3
        '
        Me.ButtonOption3.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption3.Location = New System.Drawing.Point(758, 139)
        Me.ButtonOption3.Name = "ButtonOption3"
        Me.ButtonOption3.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption3.TabIndex = 27
        Me.ButtonOption3.Text = "Add Colleges"
        Me.ButtonOption3.UseVisualStyleBackColor = True
        '
        'LabelOption3
        '
        Me.LabelOption3.BackColor = System.Drawing.Color.White
        Me.LabelOption3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption3.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption3.Location = New System.Drawing.Point(698, 20)
        Me.LabelOption3.Name = "LabelOption3"
        Me.LabelOption3.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption3.TabIndex = 26
        Me.LabelOption3.Text = "Add new colleges to the system."
        Me.LabelOption3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption7
        '
        Me.ButtonOption7.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption7.Location = New System.Drawing.Point(758, 355)
        Me.ButtonOption7.Name = "ButtonOption7"
        Me.ButtonOption7.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption7.TabIndex = 25
        Me.ButtonOption7.Text = "Add Courses"
        Me.ButtonOption7.UseVisualStyleBackColor = True
        '
        'LabelOption7
        '
        Me.LabelOption7.BackColor = System.Drawing.Color.White
        Me.LabelOption7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption7.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption7.Location = New System.Drawing.Point(698, 236)
        Me.LabelOption7.Name = "LabelOption7"
        Me.LabelOption7.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption7.TabIndex = 24
        Me.LabelOption7.Text = "Add new courses to the system."
        Me.LabelOption7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption10
        '
        Me.ButtonOption10.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption10.Location = New System.Drawing.Point(430, 571)
        Me.ButtonOption10.Name = "ButtonOption10"
        Me.ButtonOption10.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption10.TabIndex = 21
        Me.ButtonOption10.Text = "Add Students"
        Me.ButtonOption10.UseVisualStyleBackColor = True
        '
        'LabelOption10
        '
        Me.LabelOption10.BackColor = System.Drawing.Color.White
        Me.LabelOption10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption10.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption10.Location = New System.Drawing.Point(368, 452)
        Me.LabelOption10.Name = "LabelOption10"
        Me.LabelOption10.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption10.TabIndex = 20
        Me.LabelOption10.Text = "Add new students to the system."
        Me.LabelOption10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption12
        '
        Me.ButtonOption12.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption12.Location = New System.Drawing.Point(1097, 571)
        Me.ButtonOption12.Name = "ButtonOption12"
        Me.ButtonOption12.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption12.TabIndex = 19
        Me.ButtonOption12.Text = "View Users' Log"
        Me.ButtonOption12.UseVisualStyleBackColor = True
        '
        'LabelOption12
        '
        Me.LabelOption12.BackColor = System.Drawing.Color.White
        Me.LabelOption12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption12.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption12.Location = New System.Drawing.Point(1037, 452)
        Me.LabelOption12.Name = "LabelOption12"
        Me.LabelOption12.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption12.TabIndex = 18
        Me.LabelOption12.Text = "View users' log with log in and log out time."
        Me.LabelOption12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption9
        '
        Me.ButtonOption9.Font = New System.Drawing.Font("Alegreya", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption9.Location = New System.Drawing.Point(97, 571)
        Me.ButtonOption9.Name = "ButtonOption9"
        Me.ButtonOption9.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption9.TabIndex = 17
        Me.ButtonOption9.Text = "Add Coursewise-Subjects"
        Me.ButtonOption9.UseVisualStyleBackColor = True
        '
        'LabelOption9
        '
        Me.LabelOption9.BackColor = System.Drawing.Color.White
        Me.LabelOption9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption9.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption9.Location = New System.Drawing.Point(35, 452)
        Me.LabelOption9.Name = "LabelOption9"
        Me.LabelOption9.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption9.TabIndex = 16
        Me.LabelOption9.Text = "Add new subjects to a course. New subjects to a course can only be added from the" &
    " list of existing subjects."
        Me.LabelOption9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption6
        '
        Me.ButtonOption6.Font = New System.Drawing.Font("Alegreya", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption6.Location = New System.Drawing.Point(430, 355)
        Me.ButtonOption6.Name = "ButtonOption6"
        Me.ButtonOption6.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption6.TabIndex = 13
        Me.ButtonOption6.Text = "Add Sessionwise-Semesters"
        Me.ButtonOption6.UseVisualStyleBackColor = True
        '
        'LabelOption6
        '
        Me.LabelOption6.BackColor = System.Drawing.Color.White
        Me.LabelOption6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption6.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption6.Location = New System.Drawing.Point(368, 236)
        Me.LabelOption6.Name = "LabelOption6"
        Me.LabelOption6.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption6.TabIndex = 12
        Me.LabelOption6.Text = "Add new semesters to a session. New semesters to a session can only be added from" &
    " the list of existing semesters."
        Me.LabelOption6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption5
        '
        Me.ButtonOption5.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption5.Location = New System.Drawing.Point(97, 355)
        Me.ButtonOption5.Name = "ButtonOption5"
        Me.ButtonOption5.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption5.TabIndex = 9
        Me.ButtonOption5.Text = "Add Semesters"
        Me.ButtonOption5.UseVisualStyleBackColor = True
        '
        'LabelOption5
        '
        Me.LabelOption5.BackColor = System.Drawing.Color.White
        Me.LabelOption5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption5.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption5.Location = New System.Drawing.Point(35, 236)
        Me.LabelOption5.Name = "LabelOption5"
        Me.LabelOption5.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption5.TabIndex = 8
        Me.LabelOption5.Text = "Add new semesters to the system."
        Me.LabelOption5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption2
        '
        Me.ButtonOption2.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption2.Location = New System.Drawing.Point(430, 139)
        Me.ButtonOption2.Name = "ButtonOption2"
        Me.ButtonOption2.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption2.TabIndex = 5
        Me.ButtonOption2.Text = "Add Universities"
        Me.ButtonOption2.UseVisualStyleBackColor = True
        '
        'LabelOption2
        '
        Me.LabelOption2.BackColor = System.Drawing.Color.White
        Me.LabelOption2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption2.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption2.Location = New System.Drawing.Point(370, 20)
        Me.LabelOption2.Name = "LabelOption2"
        Me.LabelOption2.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption2.TabIndex = 4
        Me.LabelOption2.Text = "Add new universities to the system."
        Me.LabelOption2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption4
        '
        Me.ButtonOption4.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption4.Location = New System.Drawing.Point(1097, 139)
        Me.ButtonOption4.Name = "ButtonOption4"
        Me.ButtonOption4.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption4.TabIndex = 3
        Me.ButtonOption4.Text = "Add Sessions"
        Me.ButtonOption4.UseVisualStyleBackColor = True
        '
        'LabelOption4
        '
        Me.LabelOption4.BackColor = System.Drawing.Color.White
        Me.LabelOption4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption4.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption4.Location = New System.Drawing.Point(1037, 20)
        Me.LabelOption4.Name = "LabelOption4"
        Me.LabelOption4.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption4.TabIndex = 2
        Me.LabelOption4.Text = "Add new sessions (for example 2017-18, 2018-19, etcetera) to the system."
        Me.LabelOption4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption1
        '
        Me.ButtonOption1.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption1.Location = New System.Drawing.Point(97, 139)
        Me.ButtonOption1.Name = "ButtonOption1"
        Me.ButtonOption1.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption1.TabIndex = 1
        Me.ButtonOption1.Text = "Add Users"
        Me.ButtonOption1.UseVisualStyleBackColor = True
        '
        'LabelOption1
        '
        Me.LabelOption1.BackColor = System.Drawing.Color.White
        Me.LabelOption1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption1.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption1.Location = New System.Drawing.Point(37, 20)
        Me.LabelOption1.Name = "LabelOption1"
        Me.LabelOption1.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption1.TabIndex = 0
        Me.LabelOption1.Text = "Add users to the system. A new user can be an admin or someone from the examinati" &
    "on cell."
        Me.LabelOption1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContextMenuStripUser
        '
        Me.ContextMenuStripUser.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUser.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUser.Size = New System.Drawing.Size(184, 76)
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
        'FormAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Font = New System.Drawing.Font("Alegreya Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAdminDashboard"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.ContextMenuStripUser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents LabelDashboard As Label
    Friend WithEvents ContextMenuStripUser As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonOption1 As Button
    Friend WithEvents LabelOption1 As Label
    Friend WithEvents ButtonOption4 As Button
    Friend WithEvents LabelOption4 As Label
    Friend WithEvents ButtonOption2 As Button
    Friend WithEvents LabelOption2 As Label
    Friend WithEvents ButtonOption6 As Button
    Friend WithEvents LabelOption6 As Label
    Friend WithEvents ButtonOption5 As Button
    Friend WithEvents LabelOption5 As Label
    Friend WithEvents ButtonOption10 As Button
    Friend WithEvents LabelOption10 As Label
    Friend WithEvents ButtonOption12 As Button
    Friend WithEvents LabelOption12 As Label
    Friend WithEvents ButtonOption9 As Button
    Friend WithEvents LabelOption9 As Label
    Friend WithEvents ButtonOption7 As Button
    Friend WithEvents LabelOption7 As Label
    Friend WithEvents ButtonOption3 As Button
    Friend WithEvents LabelOption3 As Label
    Friend WithEvents ButtonOption11 As Button
    Friend WithEvents LabelOption11 As Label
    Friend WithEvents ButtonOption8 As Button
    Friend WithEvents LabelOption8 As Label
    Friend WithEvents PictureBoxUser As PictureBox
End Class
