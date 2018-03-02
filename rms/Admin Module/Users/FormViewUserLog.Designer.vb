<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewUserLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewUserLog))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelViewUserLog = New System.Windows.Forms.Label()
        Me.PanelLog = New System.Windows.Forms.Panel()
        Me.DataGridViewLog = New System.Windows.Forms.DataGridView()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.ComboBoxUsername = New System.Windows.Forms.ComboBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PanelLogLabel = New System.Windows.Forms.Panel()
        Me.LabelLog = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.ContextMenuStripViewUserLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLog.SuspendLayout()
        CType(Me.DataGridViewLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogLabel.SuspendLayout()
        Me.ContextMenuStripViewUserLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelViewUserLog)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 0)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 4
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(1073, 5)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(35, 46)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 5
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(205, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelViewUserLog
        '
        Me.LabelViewUserLog.AutoSize = True
        Me.LabelViewUserLog.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelViewUserLog.Location = New System.Drawing.Point(33, 9)
        Me.LabelViewUserLog.Name = "LabelViewUserLog"
        Me.LabelViewUserLog.Size = New System.Drawing.Size(172, 39)
        Me.LabelViewUserLog.TabIndex = 0
        Me.LabelViewUserLog.Text = "View Users' Log"
        '
        'PanelLog
        '
        Me.PanelLog.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLog.Controls.Add(Me.DataGridViewLog)
        Me.PanelLog.Controls.Add(Me.TextName)
        Me.PanelLog.Controls.Add(Me.ComboBoxUsername)
        Me.PanelLog.Controls.Add(Me.LabelName)
        Me.PanelLog.Controls.Add(Me.PanelLogLabel)
        Me.PanelLog.Controls.Add(Me.LabelUser)
        Me.PanelLog.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelLog.Location = New System.Drawing.Point(271, 100)
        Me.PanelLog.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelLog.Name = "PanelLog"
        Me.PanelLog.Size = New System.Drawing.Size(809, 578)
        Me.PanelLog.TabIndex = 5
        '
        'DataGridViewLog
        '
        Me.DataGridViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewLog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLog.Location = New System.Drawing.Point(186, 194)
        Me.DataGridViewLog.MultiSelect = False
        Me.DataGridViewLog.Name = "DataGridViewLog"
        Me.DataGridViewLog.ReadOnly = True
        Me.DataGridViewLog.Size = New System.Drawing.Size(434, 365)
        Me.DataGridViewLog.TabIndex = 17
        '
        'TextName
        '
        Me.TextName.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(457, 141)
        Me.TextName.Name = "TextName"
        Me.TextName.ReadOnly = True
        Me.TextName.Size = New System.Drawing.Size(300, 27)
        Me.TextName.TabIndex = 16
        '
        'ComboBoxUsername
        '
        Me.ComboBoxUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsername.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUsername.FormattingEnabled = True
        Me.ComboBoxUsername.Location = New System.Drawing.Point(52, 137)
        Me.ComboBoxUsername.Name = "ComboBoxUsername"
        Me.ComboBoxUsername.Size = New System.Drawing.Size(300, 31)
        Me.ComboBoxUsername.TabIndex = 15
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(452, 95)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(101, 28)
        Me.LabelName.TabIndex = 14
        Me.LabelName.Text = "Full Name"
        '
        'PanelLogLabel
        '
        Me.PanelLogLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelLogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLogLabel.Controls.Add(Me.LabelLog)
        Me.PanelLogLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelLogLabel.Name = "PanelLogLabel"
        Me.PanelLogLabel.Size = New System.Drawing.Size(809, 78)
        Me.PanelLogLabel.TabIndex = 4
        '
        'LabelLog
        '
        Me.LabelLog.AutoSize = True
        Me.LabelLog.Font = New System.Drawing.Font("Alegreya Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLog.Location = New System.Drawing.Point(297, 15)
        Me.LabelLog.Name = "LabelLog"
        Me.LabelLog.Size = New System.Drawing.Size(212, 46)
        Me.LabelLog.TabIndex = 3
        Me.LabelLog.Text = "View Users' Log"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(47, 95)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(103, 28)
        Me.LabelUser.TabIndex = 1
        Me.LabelUser.Text = "Username"
        '
        'ContextMenuStripViewUserLog
        '
        Me.ContextMenuStripViewUserLog.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripViewUserLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripViewUserLog.Name = "ContextMenuStripUser"
        Me.ContextMenuStripViewUserLog.Size = New System.Drawing.Size(184, 76)
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
        'FormViewUserLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelLog)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Font = New System.Drawing.Font("Alegreya Sans", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FormViewUserLog"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLog.ResumeLayout(False)
        Me.PanelLog.PerformLayout()
        CType(Me.DataGridViewLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogLabel.ResumeLayout(False)
        Me.PanelLogLabel.PerformLayout()
        Me.ContextMenuStripViewUserLog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelViewUserLog As Label
    Friend WithEvents PanelLog As Panel
    Friend WithEvents TextName As TextBox
    Friend WithEvents ComboBoxUsername As ComboBox
    Friend WithEvents LabelName As Label
    Friend WithEvents PanelLogLabel As Panel
    Friend WithEvents LabelLog As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents DataGridViewLog As DataGridView
    Friend WithEvents ContextMenuStripViewUserLog As ContextMenuStrip
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
