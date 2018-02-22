Public Class FormAddUsers
    Private Sub FormAddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "RMS | Add Users"
        MinimizeBox = True
        MaximizeBox = True
        Size = New Size(1366, 768)   ' Default Size- 1368x768 px
        MaximumSize = New Size(1366, 768)   ' Maximum Size- 1366x768 px
        MinimumSize = New Size(1366, 768)   ' Minimum Size- 1366x768 px
        StartPosition = FormStartPosition.CenterScreen   ' Default Start Position- CenterScreen
        WindowState = FormWindowState.Normal   ' Default Window State- Normal
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddUsersPanel.ForeColor = Color.FromArgb(255, 255, 255)
        LabelUsername.Text = FormSigIn.FullUsername & "    "   ' Extra spaces to accomodate the dropdown arrow.
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddUsersLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelAddUsers.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddUsers.Enabled = False
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripUsers.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonSelectImage_Click(sender As Object, e As EventArgs) Handles ButtonSelectImage.Click
        OpenFileDialogAddUsers.ShowDialog()
        PictureBoxThumbnail.ImageLocation = OpenFileDialogAddUsers.FileName()
    End Sub

    Private Sub TextUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextUsername.Validating
        If TextUsername.Text = "" Then
            ErrorProviderAddUsers.SetError(control:=TextUsername, value:="Username can't be empty.")
        Else
            ErrorProviderAddUsers.Dispose()
            ButtonAddUsers.Enabled = True

        End If
    End Sub

    Private Sub TextFirstName_Validating(sender As Object, e As EventArgs) Handles TextFirstName.Validating
        If TextFirstName.Text = "" Then
            ErrorProviderAddUsers.SetError(control:=TextFirstName, value:="First name can't be empty.")
            TextFirstName.Focus()
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderAddUsers.SetError(control:=TextFirstName, value:="First name can't contain numbers.")
            TextFirstName.Focus()
        End If
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderAddUsers.Dispose()
        End If
    End Sub

    Private Sub TextLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextLastName.Validating
        If System.Text.RegularExpressions.Regex.IsMatch(TextLastName.Text, "\d+") Then
            ErrorProviderAddUsers.SetError(control:=TextLastName, value:="Last name can't contain numbers.")
            TextLastName.Focus()
        Else
            ErrorProviderAddUsers.Dispose()
        End If
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub ButtonEditUsers_Click(sender As Object, e As EventArgs) Handles ButtonEditUsers.Click
        Dim NewFormEditUsers As FormEditUsers
        NewFormEditUsers = New FormEditUsers()
        NewFormEditUsers.Show()
        Dispose()
    End Sub

    Private Sub ButtonDeleteUsers_Click(sender As Object, e As EventArgs) Handles ButtonDeleteUsers.Click
        Dim NewFormDeleteUsers As FormDeleteUsers
        NewFormDeleteUsers = New FormDeleteUsers()
        NewFormDeleteUsers.Show()
        Dispose()
    End Sub
End Class