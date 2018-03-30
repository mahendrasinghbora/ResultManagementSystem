<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExamCellDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExamCellDashboard))
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonOption3 = New System.Windows.Forms.Button()
        Me.LabelOption3 = New System.Windows.Forms.Label()
        Me.LabelDashboard = New System.Windows.Forms.Label()
        Me.ButtonOption2 = New System.Windows.Forms.Button()
        Me.LabelOption2 = New System.Windows.Forms.Label()
        Me.ButtonOption4 = New System.Windows.Forms.Button()
        Me.LabelOption4 = New System.Windows.Forms.Label()
        Me.ButtonOption1 = New System.Windows.Forms.Button()
        Me.LabelOption1 = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelOption5 = New System.Windows.Forms.Label()
        Me.ButtonOption5 = New System.Windows.Forms.Button()
        Me.ContextMenuStripUser.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.LogOutToolStripMenuItem.Text = "Log out"
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
        'ButtonOption3
        '
        Me.ButtonOption3.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption3.Location = New System.Drawing.Point(760, 139)
        Me.ButtonOption3.Name = "ButtonOption3"
        Me.ButtonOption3.Size = New System.Drawing.Size(202, 40)
        Me.ButtonOption3.TabIndex = 27
        Me.ButtonOption3.Text = "View Report-I"
        Me.ButtonOption3.UseVisualStyleBackColor = True
        '
        'LabelOption3
        '
        Me.LabelOption3.BackColor = System.Drawing.Color.White
        Me.LabelOption3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption3.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption3.Location = New System.Drawing.Point(711, 20)
        Me.LabelOption3.Name = "LabelOption3"
        Me.LabelOption3.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption3.TabIndex = 26
        Me.LabelOption3.Text = "View universitywise list of students with back in a particular subject in a selec" &
    "ted session and semester."
        Me.LabelOption3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelDashboard
        '
        Me.LabelDashboard.AutoSize = True
        Me.LabelDashboard.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDashboard.Location = New System.Drawing.Point(33, 9)
        Me.LabelDashboard.Name = "LabelDashboard"
        Me.LabelDashboard.Size = New System.Drawing.Size(247, 39)
        Me.LabelDashboard.TabIndex = 0
        Me.LabelDashboard.Text = "Exam Cell's Dashboard"
        '
        'ButtonOption2
        '
        Me.ButtonOption2.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption2.Location = New System.Drawing.Point(442, 139)
        Me.ButtonOption2.Name = "ButtonOption2"
        Me.ButtonOption2.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption2.TabIndex = 5
        Me.ButtonOption2.Text = "Print Marksheets"
        Me.ButtonOption2.UseVisualStyleBackColor = True
        '
        'LabelOption2
        '
        Me.LabelOption2.BackColor = System.Drawing.Color.White
        Me.LabelOption2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption2.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption2.Location = New System.Drawing.Point(382, 20)
        Me.LabelOption2.Name = "LabelOption2"
        Me.LabelOption2.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption2.TabIndex = 4
        Me.LabelOption2.Text = "Print marksheets of students."
        Me.LabelOption2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption4
        '
        Me.ButtonOption4.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption4.Location = New System.Drawing.Point(1096, 139)
        Me.ButtonOption4.Name = "ButtonOption4"
        Me.ButtonOption4.Size = New System.Drawing.Size(180, 40)
        Me.ButtonOption4.TabIndex = 3
        Me.ButtonOption4.Text = "View Report-II"
        Me.ButtonOption4.UseVisualStyleBackColor = True
        '
        'LabelOption4
        '
        Me.LabelOption4.BackColor = System.Drawing.Color.White
        Me.LabelOption4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption4.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption4.Location = New System.Drawing.Point(1036, 20)
        Me.LabelOption4.Name = "LabelOption4"
        Me.LabelOption4.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption4.TabIndex = 2
        Me.LabelOption4.Text = "View collegewise list of students with back in a particular subject in a selected" &
    " session and semester."
        Me.LabelOption4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption1
        '
        Me.ButtonOption1.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption1.Location = New System.Drawing.Point(98, 139)
        Me.ButtonOption1.Name = "ButtonOption1"
        Me.ButtonOption1.Size = New System.Drawing.Size(218, 40)
        Me.ButtonOption1.TabIndex = 1
        Me.ButtonOption1.Text = "Add Marks Information"
        Me.ButtonOption1.UseVisualStyleBackColor = True
        '
        'LabelOption1
        '
        Me.LabelOption1.BackColor = System.Drawing.Color.White
        Me.LabelOption1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption1.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption1.Location = New System.Drawing.Point(57, 20)
        Me.LabelOption1.Name = "LabelOption1"
        Me.LabelOption1.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption1.TabIndex = 0
        Me.LabelOption1.Text = "Add information related to the marks of students."
        Me.LabelOption1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.ButtonOption5)
        Me.PanelMenu.Controls.Add(Me.LabelOption5)
        Me.PanelMenu.Controls.Add(Me.ButtonOption3)
        Me.PanelMenu.Controls.Add(Me.LabelOption3)
        Me.PanelMenu.Controls.Add(Me.ButtonOption2)
        Me.PanelMenu.Controls.Add(Me.LabelOption2)
        Me.PanelMenu.Controls.Add(Me.ButtonOption4)
        Me.PanelMenu.Controls.Add(Me.LabelOption4)
        Me.PanelMenu.Controls.Add(Me.ButtonOption1)
        Me.PanelMenu.Controls.Add(Me.LabelOption1)
        Me.PanelMenu.Location = New System.Drawing.Point(-15, 86)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1366, 643)
        Me.PanelMenu.TabIndex = 3
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.LabelDashboard)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 2
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
        'LabelOption5
        '
        Me.LabelOption5.BackColor = System.Drawing.Color.White
        Me.LabelOption5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOption5.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOption5.Location = New System.Drawing.Point(57, 236)
        Me.LabelOption5.Name = "LabelOption5"
        Me.LabelOption5.Size = New System.Drawing.Size(300, 170)
        Me.LabelOption5.TabIndex = 28
        Me.LabelOption5.Text = "View universitywise list of students with back in a particular course in a select" &
    "ed session and semester."
        Me.LabelOption5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonOption5
        '
        Me.ButtonOption5.Font = New System.Drawing.Font("Alegreya", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOption5.Location = New System.Drawing.Point(106, 354)
        Me.ButtonOption5.Name = "ButtonOption5"
        Me.ButtonOption5.Size = New System.Drawing.Size(202, 40)
        Me.ButtonOption5.TabIndex = 32
        Me.ButtonOption5.Text = "View Report-III"
        Me.ButtonOption5.UseVisualStyleBackColor = True
        '
        'FormExamCellDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormExamCellDashboard"
        Me.ShowIcon = False
        Me.ContextMenuStripUser.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripUser As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonOption3 As Button
    Friend WithEvents LabelOption3 As Label
    Friend WithEvents LabelDashboard As Label
    Friend WithEvents ButtonOption2 As Button
    Friend WithEvents LabelOption2 As Label
    Friend WithEvents ButtonOption4 As Button
    Friend WithEvents LabelOption4 As Label
    Friend WithEvents ButtonOption1 As Button
    Friend WithEvents LabelOption1 As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelOption5 As Label
    Friend WithEvents ButtonOption5 As Button
End Class
