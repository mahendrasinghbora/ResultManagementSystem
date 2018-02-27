<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddResultCriteria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddResultCriteria))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelAddResultCriteria = New System.Windows.Forms.Label()
        Me.ContextMenuStripAddResultCriteria = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelResultCriteria = New System.Windows.Forms.Panel()
        Me.TextPassingMarks = New System.Windows.Forms.TextBox()
        Me.LabelPassingMarks = New System.Windows.Forms.Label()
        Me.TextExternalMarks = New System.Windows.Forms.TextBox()
        Me.LabelExternalMarks = New System.Windows.Forms.Label()
        Me.TextInternalMarks = New System.Windows.Forms.TextBox()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.ComboBoxSession = New System.Windows.Forms.ComboBox()
        Me.LabelSession = New System.Windows.Forms.Label()
        Me.ComboBoxUniversity = New System.Windows.Forms.ComboBox()
        Me.LabelInternalMarks = New System.Windows.Forms.Label()
        Me.ButtonAddResultCriteria = New System.Windows.Forms.Button()
        Me.PanelAddResultCriteriaLabel = New System.Windows.Forms.Panel()
        Me.LabelResultCriteria = New System.Windows.Forms.Label()
        Me.LabelUniversity = New System.Windows.Forms.Label()
        Me.ErrorProviderCriteria = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripAddResultCriteria.SuspendLayout()
        Me.PanelResultCriteria.SuspendLayout()
        Me.PanelAddResultCriteriaLabel.SuspendLayout()
        CType(Me.ErrorProviderCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelAddResultCriteria)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 7
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1074, 5)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 8
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(239, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(137, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelAddResultCriteria
        '
        Me.LabelAddResultCriteria.AutoSize = True
        Me.LabelAddResultCriteria.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddResultCriteria.Location = New System.Drawing.Point(33, 9)
        Me.LabelAddResultCriteria.Name = "LabelAddResultCriteria"
        Me.LabelAddResultCriteria.Size = New System.Drawing.Size(207, 39)
        Me.LabelAddResultCriteria.TabIndex = 0
        Me.LabelAddResultCriteria.Text = "Add Result Criteria"
        '
        'ContextMenuStripAddResultCriteria
        '
        Me.ContextMenuStripAddResultCriteria.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripAddResultCriteria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripAddResultCriteria.Name = "ContextMenuStripUser"
        Me.ContextMenuStripAddResultCriteria.Size = New System.Drawing.Size(184, 76)
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
        'PanelResultCriteria
        '
        Me.PanelResultCriteria.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelResultCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelResultCriteria.Controls.Add(Me.TextPassingMarks)
        Me.PanelResultCriteria.Controls.Add(Me.LabelPassingMarks)
        Me.PanelResultCriteria.Controls.Add(Me.TextExternalMarks)
        Me.PanelResultCriteria.Controls.Add(Me.LabelExternalMarks)
        Me.PanelResultCriteria.Controls.Add(Me.TextInternalMarks)
        Me.PanelResultCriteria.Controls.Add(Me.ComboBoxSemester)
        Me.PanelResultCriteria.Controls.Add(Me.LabelSemester)
        Me.PanelResultCriteria.Controls.Add(Me.ComboBoxSession)
        Me.PanelResultCriteria.Controls.Add(Me.LabelSession)
        Me.PanelResultCriteria.Controls.Add(Me.ComboBoxUniversity)
        Me.PanelResultCriteria.Controls.Add(Me.LabelInternalMarks)
        Me.PanelResultCriteria.Controls.Add(Me.ButtonAddResultCriteria)
        Me.PanelResultCriteria.Controls.Add(Me.PanelAddResultCriteriaLabel)
        Me.PanelResultCriteria.Controls.Add(Me.LabelUniversity)
        Me.PanelResultCriteria.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelResultCriteria.Location = New System.Drawing.Point(348, 140)
        Me.PanelResultCriteria.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelResultCriteria.Name = "PanelResultCriteria"
        Me.PanelResultCriteria.Size = New System.Drawing.Size(655, 522)
        Me.PanelResultCriteria.TabIndex = 8
        '
        'TextPassingMarks
        '
        Me.TextPassingMarks.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassingMarks.Location = New System.Drawing.Point(42, 403)
        Me.TextPassingMarks.Name = "TextPassingMarks"
        Me.TextPassingMarks.Size = New System.Drawing.Size(568, 27)
        Me.TextPassingMarks.TabIndex = 19
        '
        'LabelPassingMarks
        '
        Me.LabelPassingMarks.AutoSize = True
        Me.LabelPassingMarks.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassingMarks.Location = New System.Drawing.Point(37, 366)
        Me.LabelPassingMarks.Name = "LabelPassingMarks"
        Me.LabelPassingMarks.Size = New System.Drawing.Size(136, 28)
        Me.LabelPassingMarks.TabIndex = 18
        Me.LabelPassingMarks.Text = "Passing Marks"
        '
        'TextExternalMarks
        '
        Me.TextExternalMarks.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextExternalMarks.Location = New System.Drawing.Point(350, 314)
        Me.TextExternalMarks.Name = "TextExternalMarks"
        Me.TextExternalMarks.Size = New System.Drawing.Size(260, 27)
        Me.TextExternalMarks.TabIndex = 17
        '
        'LabelExternalMarks
        '
        Me.LabelExternalMarks.AutoSize = True
        Me.LabelExternalMarks.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExternalMarks.Location = New System.Drawing.Point(344, 277)
        Me.LabelExternalMarks.Name = "LabelExternalMarks"
        Me.LabelExternalMarks.Size = New System.Drawing.Size(235, 28)
        Me.LabelExternalMarks.TabIndex = 16
        Me.LabelExternalMarks.Text = "Maximum External Marks"
        '
        'TextInternalMarks
        '
        Me.TextInternalMarks.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInternalMarks.Location = New System.Drawing.Point(42, 314)
        Me.TextInternalMarks.Name = "TextInternalMarks"
        Me.TextInternalMarks.Size = New System.Drawing.Size(260, 27)
        Me.TextInternalMarks.TabIndex = 15
        '
        'ComboBoxSemester
        '
        Me.ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSemester.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSemester.FormattingEnabled = True
        Me.ComboBoxSemester.Location = New System.Drawing.Point(350, 134)
        Me.ComboBoxSemester.Name = "ComboBoxSemester"
        Me.ComboBoxSemester.Size = New System.Drawing.Size(260, 31)
        Me.ComboBoxSemester.TabIndex = 14
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(344, 98)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(96, 28)
        Me.LabelSemester.TabIndex = 13
        Me.LabelSemester.Text = "Semester"
        '
        'ComboBoxSession
        '
        Me.ComboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSession.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSession.FormattingEnabled = True
        Me.ComboBoxSession.Location = New System.Drawing.Point(42, 134)
        Me.ComboBoxSession.Name = "ComboBoxSession"
        Me.ComboBoxSession.Size = New System.Drawing.Size(260, 31)
        Me.ComboBoxSession.TabIndex = 12
        '
        'LabelSession
        '
        Me.LabelSession.AutoSize = True
        Me.LabelSession.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSession.Location = New System.Drawing.Point(37, 98)
        Me.LabelSession.Name = "LabelSession"
        Me.LabelSession.Size = New System.Drawing.Size(79, 28)
        Me.LabelSession.TabIndex = 11
        Me.LabelSession.Text = "Session"
        '
        'ComboBoxUniversity
        '
        Me.ComboBoxUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUniversity.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUniversity.FormattingEnabled = True
        Me.ComboBoxUniversity.Location = New System.Drawing.Point(42, 222)
        Me.ComboBoxUniversity.Name = "ComboBoxUniversity"
        Me.ComboBoxUniversity.Size = New System.Drawing.Size(568, 31)
        Me.ComboBoxUniversity.TabIndex = 10
        '
        'LabelInternalMarks
        '
        Me.LabelInternalMarks.AutoSize = True
        Me.LabelInternalMarks.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInternalMarks.Location = New System.Drawing.Point(37, 277)
        Me.LabelInternalMarks.Name = "LabelInternalMarks"
        Me.LabelInternalMarks.Size = New System.Drawing.Size(233, 28)
        Me.LabelInternalMarks.TabIndex = 8
        Me.LabelInternalMarks.Text = "Maximum Internal Marks"
        '
        'ButtonAddResultCriteria
        '
        Me.ButtonAddResultCriteria.AutoSize = True
        Me.ButtonAddResultCriteria.Font = New System.Drawing.Font("Acme", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddResultCriteria.Location = New System.Drawing.Point(200, 465)
        Me.ButtonAddResultCriteria.Name = "ButtonAddResultCriteria"
        Me.ButtonAddResultCriteria.Size = New System.Drawing.Size(253, 36)
        Me.ButtonAddResultCriteria.TabIndex = 7
        Me.ButtonAddResultCriteria.Text = "Add Criteria"
        Me.ButtonAddResultCriteria.UseVisualStyleBackColor = True
        '
        'PanelAddResultCriteriaLabel
        '
        Me.PanelAddResultCriteriaLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelAddResultCriteriaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAddResultCriteriaLabel.Controls.Add(Me.LabelResultCriteria)
        Me.PanelAddResultCriteriaLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelAddResultCriteriaLabel.Name = "PanelAddResultCriteriaLabel"
        Me.PanelAddResultCriteriaLabel.Size = New System.Drawing.Size(655, 78)
        Me.PanelAddResultCriteriaLabel.TabIndex = 4
        '
        'LabelResultCriteria
        '
        Me.LabelResultCriteria.AutoSize = True
        Me.LabelResultCriteria.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResultCriteria.Location = New System.Drawing.Point(200, 15)
        Me.LabelResultCriteria.Name = "LabelResultCriteria"
        Me.LabelResultCriteria.Size = New System.Drawing.Size(252, 46)
        Me.LabelResultCriteria.TabIndex = 3
        Me.LabelResultCriteria.Text = "Add Result Criteria"
        '
        'LabelUniversity
        '
        Me.LabelUniversity.AutoSize = True
        Me.LabelUniversity.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUniversity.Location = New System.Drawing.Point(37, 186)
        Me.LabelUniversity.Name = "LabelUniversity"
        Me.LabelUniversity.Size = New System.Drawing.Size(103, 28)
        Me.LabelUniversity.TabIndex = 1
        Me.LabelUniversity.Text = "University"
        '
        'ErrorProviderCriteria
        '
        Me.ErrorProviderCriteria.ContainerControl = Me
        '
        'FormAddResultCriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelResultCriteria)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Name = "FormAddResultCriteria"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripAddResultCriteria.ResumeLayout(False)
        Me.PanelResultCriteria.ResumeLayout(False)
        Me.PanelResultCriteria.PerformLayout()
        Me.PanelAddResultCriteriaLabel.ResumeLayout(False)
        Me.PanelAddResultCriteriaLabel.PerformLayout()
        CType(Me.ErrorProviderCriteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelAddResultCriteria As Label
    Friend WithEvents ContextMenuStripAddResultCriteria As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents PanelResultCriteria As Panel
    Friend WithEvents ComboBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents ComboBoxSession As ComboBox
    Friend WithEvents LabelSession As Label
    Friend WithEvents ComboBoxUniversity As ComboBox
    Friend WithEvents ButtonAddResultCriteria As Button
    Friend WithEvents PanelAddResultCriteriaLabel As Panel
    Friend WithEvents LabelResultCriteria As Label
    Friend WithEvents LabelUniversity As Label
    Friend WithEvents TextInternalMarks As TextBox
    Friend WithEvents LabelInternalMarks As Label
    Friend WithEvents TextExternalMarks As TextBox
    Friend WithEvents LabelExternalMarks As Label
    Friend WithEvents TextPassingMarks As TextBox
    Friend WithEvents LabelPassingMarks As Label
    Friend WithEvents ErrorProviderCriteria As ErrorProvider
End Class
