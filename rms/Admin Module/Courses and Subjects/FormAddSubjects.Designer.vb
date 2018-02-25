<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddSubjects))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddSubjects = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddSubjects = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAddSubjects = New System.Windows.Forms.Panel()
        Me.ButtonAddSubject = New System.Windows.Forms.Button()
        Me.PanelAddSubjectLabel = New System.Windows.Forms.Panel()
        Me.LabelSubjects = New System.Windows.Forms.Label()
        Me.TextSubject = New System.Windows.Forms.TextBox()
        Me.LabelSubjectName = New System.Windows.Forms.Label()
        Me.ErrorProviderSubject = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddSubjects.SuspendLayout()
        Me.PanelAddSubjects.SuspendLayout()
        Me.PanelAddSubjectLabel.SuspendLayout()
        CType(Me.ErrorProviderSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddSubjects)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 1)
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
        'LabelAddSubjects
        '
        Me.LabelAddSubjects.AutoSize = True
        Me.LabelAddSubjects.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddSubjects.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddSubjects.Name = "LabelAddSubjects"
        Me.LabelAddSubjects.Size = New System.Drawing.Size(145, 39)
        Me.LabelAddSubjects.TabIndex = 0
        Me.LabelAddSubjects.Text = "Add Subjects"
        '
        'ContextMenuStripAddSubjects
        '
        Me.ContextMenuStripAddSubjects.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddSubjects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddSubjects.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddSubjects.Size = New System.Drawing.Size(184, 76)
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
        'PanelAddSubjects
        '
        Me.PanelAddSubjects.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelAddSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSubjects.Controls.Add(Me.ButtonAddSubject)
        Me.PanelAddSubjects.Controls.Add(Me.PanelAddSubjectLabel)
        Me.PanelAddSubjects.Controls.Add(Me.TextSubject)
        Me.PanelAddSubjects.Controls.Add(Me.LabelSubjectName)
        Me.PanelAddSubjects.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAddSubjects.Location = New System.Drawing.Point(425, 223)
        Me.PanelAddSubjects.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelAddSubjects.Name = "PanelAddSubjects"
        Me.PanelAddSubjects.Size = New System.Drawing.Size(500, 282)
        Me.PanelAddSubjects.TabIndex = 6
        '
        'ButtonAddSubject
        '
        Me.ButtonAddSubject.AutoSize = True
        Me.ButtonAddSubject.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddSubject.Location = New System.Drawing.Point(176, 213)
        Me.ButtonAddSubject.Name = "ButtonAddSubject"
        Me.ButtonAddSubject.Size = New System.Drawing.Size(147, 36)
        Me.ButtonAddSubject.TabIndex = 7
        Me.ButtonAddSubject.Text = "Add Subject"
        Me.ButtonAddSubject.UseVisualStyleBackColor = True
        '
        'PanelAddSubjectLabel
        '
        Me.PanelAddSubjectLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddSubjectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddSubjectLabel.Controls.Add(Me.LabelSubjects)
        Me.PanelAddSubjectLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddSubjectLabel.Name = "PanelAddSubjectLabel"
        Me.PanelAddSubjectLabel.Size = New System.Drawing.Size(500, 78)
        Me.PanelAddSubjectLabel.TabIndex = 4
        '
        'LabelSubjects
        '
        Me.LabelSubjects.AutoSize = True
        Me.LabelSubjects.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubjects.Location = New System.Drawing.Point(159, 15)
        Me.LabelSubjects.Name = "LabelSubjects"
        Me.LabelSubjects.Size = New System.Drawing.Size(181, 46)
        Me.LabelSubjects.TabIndex = 3
        Me.LabelSubjects.Text = "Add Subjects"
        '
        'TextSubject
        '
        Me.TextSubject.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSubject.Location = New System.Drawing.Point(42, 135)
        Me.TextSubject.Name = "TextSubject"
        Me.TextSubject.Size = New System.Drawing.Size(414, 27)
        Me.TextSubject.TabIndex = 2
        '
        'LabelSubjectName
        '
        Me.LabelSubjectName.AutoSize = True
        Me.LabelSubjectName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubjectName.Location = New System.Drawing.Point(37, 104)
        Me.LabelSubjectName.Name = "LabelSubjectName"
        Me.LabelSubjectName.Size = New System.Drawing.Size(186, 28)
        Me.LabelSubjectName.TabIndex = 1
        Me.LabelSubjectName.Text = "Name of the Subject"
        '
        'ErrorProviderSubject
        '
        Me.ErrorProviderSubject.ContainerControl = Me
        '
        'FormAddSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelAddSubjects)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddSubjects"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddSubjects.ResumeLayout(False)
        Me.PanelAddSubjects.ResumeLayout(False)
        Me.PanelAddSubjects.PerformLayout()
        Me.PanelAddSubjectLabel.ResumeLayout(False)
        Me.PanelAddSubjectLabel.PerformLayout()
        CType(Me.ErrorProviderSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddSubjects As Label
    Friend WithEvents ContextMenuStripAddSubjects As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelAddSubjects As Panel
    Friend WithEvents ButtonAddSubject As Button
    Friend WithEvents PanelAddSubjectLabel As Panel
    Friend WithEvents LabelSubjects As Label
    Friend WithEvents TextSubject As TextBox
    Friend WithEvents LabelSubjectName As Label
    Friend WithEvents ErrorProviderSubject As ErrorProvider
End Class
