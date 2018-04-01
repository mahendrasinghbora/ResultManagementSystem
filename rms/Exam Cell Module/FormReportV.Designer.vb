<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportV))
        Me.PanelNavigation = New System.Windows.Forms.Panel()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonDashboard = New System.Windows.Forms.Button()
        Me.LabelPrintMarksheets = New System.Windows.Forms.Label()
        Me.LabelReport = New System.Windows.Forms.Label()
        Me.PanelReport = New System.Windows.Forms.Panel()
        Me.TextRollNumber = New System.Windows.Forms.TextBox()
        Me.ButtonGenerateReport = New System.Windows.Forms.Button()
        Me.PanelReportLabel = New System.Windows.Forms.Panel()
        Me.LabelRollNumber = New System.Windows.Forms.Label()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ErrorProviderReportV = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelNavigation.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelReport.SuspendLayout()
        Me.PanelReportLabel.SuspendLayout()
        Me.ContextMenuStripUsers.SuspendLayout()
        CType(Me.ErrorProviderReportV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNavigation
        '
        Me.PanelNavigation.Controls.Add(Me.PictureBoxUser)
        Me.PanelNavigation.Controls.Add(Me.LabelUsername)
        Me.PanelNavigation.Controls.Add(Me.ButtonDashboard)
        Me.PanelNavigation.Controls.Add(Me.LabelPrintMarksheets)
        Me.PanelNavigation.Location = New System.Drawing.Point(-15, 2)
        Me.PanelNavigation.Name = "PanelNavigation"
        Me.PanelNavigation.Size = New System.Drawing.Size(1381, 60)
        Me.PanelNavigation.TabIndex = 16
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
        Me.ButtonDashboard.Location = New System.Drawing.Point(204, 9)
        Me.ButtonDashboard.Name = "ButtonDashboard"
        Me.ButtonDashboard.Size = New System.Drawing.Size(102, 39)
        Me.ButtonDashboard.TabIndex = 1
        Me.ButtonDashboard.Text = "Dashboard"
        Me.ButtonDashboard.UseVisualStyleBackColor = True
        '
        'LabelPrintMarksheets
        '
        Me.LabelPrintMarksheets.AutoSize = True
        Me.LabelPrintMarksheets.Font = New System.Drawing.Font("Alegreya", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrintMarksheets.Location = New System.Drawing.Point(33, 9)
        Me.LabelPrintMarksheets.Name = "LabelPrintMarksheets"
        Me.LabelPrintMarksheets.Size = New System.Drawing.Size(159, 39)
        Me.LabelPrintMarksheets.TabIndex = 0
        Me.LabelPrintMarksheets.Text = "View Report-V"
        '
        'LabelReport
        '
        Me.LabelReport.AutoSize = True
        Me.LabelReport.Font = New System.Drawing.Font("Alegreya Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReport.Location = New System.Drawing.Point(159, 3)
        Me.LabelReport.Name = "LabelReport"
        Me.LabelReport.Size = New System.Drawing.Size(177, 34)
        Me.LabelReport.TabIndex = 3
        Me.LabelReport.Text = "Generate Reports"
        '
        'PanelReport
        '
        Me.PanelReport.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelReport.Controls.Add(Me.TextRollNumber)
        Me.PanelReport.Controls.Add(Me.ButtonGenerateReport)
        Me.PanelReport.Controls.Add(Me.PanelReportLabel)
        Me.PanelReport.Controls.Add(Me.LabelRollNumber)
        Me.PanelReport.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelReport.Location = New System.Drawing.Point(427, 69)
        Me.PanelReport.Margin = New System.Windows.Forms.Padding(150, 3, 150, 3)
        Me.PanelReport.Name = "PanelReport"
        Me.PanelReport.Size = New System.Drawing.Size(496, 175)
        Me.PanelReport.TabIndex = 17
        '
        'TextRollNumber
        '
        Me.TextRollNumber.Font = New System.Drawing.Font("Alegreya Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRollNumber.Location = New System.Drawing.Point(117, 88)
        Me.TextRollNumber.Name = "TextRollNumber"
        Me.TextRollNumber.Size = New System.Drawing.Size(260, 27)
        Me.TextRollNumber.TabIndex = 8
        '
        'ButtonGenerateReport
        '
        Me.ButtonGenerateReport.AutoSize = True
        Me.ButtonGenerateReport.Font = New System.Drawing.Font("Acme", 16.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerateReport.Location = New System.Drawing.Point(159, 129)
        Me.ButtonGenerateReport.Name = "ButtonGenerateReport"
        Me.ButtonGenerateReport.Size = New System.Drawing.Size(177, 39)
        Me.ButtonGenerateReport.TabIndex = 7
        Me.ButtonGenerateReport.Text = "Generate Report"
        Me.ButtonGenerateReport.UseVisualStyleBackColor = True
        '
        'PanelReportLabel
        '
        Me.PanelReportLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PanelReportLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelReportLabel.Controls.Add(Me.LabelReport)
        Me.PanelReportLabel.Location = New System.Drawing.Point(-1, -1)
        Me.PanelReportLabel.Name = "PanelReportLabel"
        Me.PanelReportLabel.Size = New System.Drawing.Size(496, 40)
        Me.PanelReportLabel.TabIndex = 4
        '
        'LabelRollNumber
        '
        Me.LabelRollNumber.AutoSize = True
        Me.LabelRollNumber.Font = New System.Drawing.Font("Acme", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRollNumber.Location = New System.Drawing.Point(138, 48)
        Me.LabelRollNumber.Name = "LabelRollNumber"
        Me.LabelRollNumber.Size = New System.Drawing.Size(218, 28)
        Me.LabelRollNumber.TabIndex = 1
        Me.LabelRollNumber.Text = "University Roll Number"
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
        'ContextMenuStripUsers
        '
        Me.ContextMenuStripUsers.Font = New System.Drawing.Font("Alegreya Sans", 16.0!)
        Me.ContextMenuStripUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ContextMenuStripUsers.Name = "ContextMenuStripUser"
        Me.ContextMenuStripUsers.Size = New System.Drawing.Size(184, 76)
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 250)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1319, 476)
        Me.CrystalReportViewer1.TabIndex = 18
        '
        'ErrorProviderReportV
        '
        Me.ErrorProviderReportV.ContainerControl = Me
        '
        'FormReportV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.PanelNavigation)
        Me.Controls.Add(Me.PanelReport)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormReportV"
        Me.ShowIcon = False
        Me.PanelNavigation.ResumeLayout(False)
        Me.PanelNavigation.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelReport.ResumeLayout(False)
        Me.PanelReport.PerformLayout()
        Me.PanelReportLabel.ResumeLayout(False)
        Me.PanelReportLabel.PerformLayout()
        Me.ContextMenuStripUsers.ResumeLayout(False)
        CType(Me.ErrorProviderReportV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNavigation As Panel
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonDashboard As Button
    Friend WithEvents LabelPrintMarksheets As Label
    Friend WithEvents LabelReport As Label
    Friend WithEvents PanelReport As Panel
    Friend WithEvents ButtonGenerateReport As Button
    Friend WithEvents PanelReportLabel As Panel
    Friend WithEvents LabelRollNumber As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripUsers As ContextMenuStrip
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TextRollNumber As TextBox
    Friend WithEvents ErrorProviderReportV As ErrorProvider
End Class
