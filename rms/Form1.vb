Public Class FormSigIn
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "rms. | Result Management System"
        BackColor = Color.GhostWhite   ' Background Color
        MinimizeBox = True
        MaximizeBox = True
        Size = New Size(1366, 768)   ' Default Size- 1368x768 px
        MaximumSize = New Size(1366, 768)   ' Maximum Size- 1366x768 px
        MinimumSize = New Size(1366, 768)   ' Minimum Size- 1366x768 px
        StartPosition = FormStartPosition.CenterScreen   ' Default Start Position- CenterScreen
        WindowState = FormWindowState.Normal   ' Default Window State- Normal
        LabelCopyright.Text = "© " & Year(Now) & " Result Management System (rms.)"   ' Copyright text
        TextPassword.MaxLength = 20   ' Maximum Length of Password
        TextUsername.MaxLength = 20   ' Maximum Length of Username
        PanelRms.BackColor = Color.FromArgb(52, 58, 64)   ' Top Panel Color
        LabelRms.ForeColor = Color.FromArgb(243, 244, 245)
        LabelRmsFull.ForeColor = Color.FromArgb(243, 244, 245)
        LabelSignIn.ForeColor = Color.FromArgb(243, 244, 245)
        PanelSignInLabel.BackColor = Color.FromArgb(44, 150, 118)
        PanelCopyright.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub LinkGuideSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGuideSite.LinkClicked
        Process.Start("http://www.onlinegurujee.in/harshvpant/")
    End Sub
End Class
