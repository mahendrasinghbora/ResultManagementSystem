Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormChangePassword
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Change Password")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelChangePasswordPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        UserImage(PictureBoxUser:=PictureBoxThumbnail, LabelUsername:=LabelUsername)
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelEditProfileLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelChangePassword.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonChangePassword.Enabled = False
        LabelUser.Text = FullUsername
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripEditUsers.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub ButtonChangePassword_Click(sender As Object, e As EventArgs) Handles ButtonChangePassword.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Dim OldPassword As String
        Dim Flag As Integer = 1
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT PASSWORD FROM users WHERE USERNAME='{Username}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            OldPassword = Reader.GetString(column:="PASSWORD")
            Reader.Dispose()
            Con.Close()
            If OldPassword = TextNewPassword.Text Then
                MessageBox.Show(text:="New password can't be the same as old password.", caption:="Duplicate password error", buttons:=MessageBoxButtons.OKCancel,
                                icon:=MessageBoxIcon.Error)
                Flag = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Dispose()
        End Try
        If Flag <> 0 Then
            Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }

            Try
                Con.Open()
                Dim Query As String
                Query = $"UPDATE users SET PASSWORD='{TextNewPassword.Text}' WHERE USERNAME='{Username}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Dim NewFormChangePassword As FormChangePassword
                NewFormChangePassword = New FormChangePassword()
                NewFormChangePassword.Show()
                Dispose()
                MessageBox.Show(text:="Password successfully updated.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Dispose()
            End Try
        End If
    End Sub

    Private Sub TextOldPassword_TextChanged(sender As Object, e As EventArgs) Handles TextOldPassword.TextChanged
        If TextOldPassword.Text = "" Then
            ErrorProviderChangePassword.SetError(TextOldPassword, "Password can't be empty.")
            ButtonChangePassword.Enabled = False
        Else
            ErrorProviderChangePassword.Dispose()
        End If
    End Sub

    Private Sub TextOldPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextOldPassword.Validating
        If TextOldPassword.Text = "" Then
            ErrorProviderChangePassword.SetError(TextOldPassword, "Password can't be empty.")
            TextOldPassword.Focus()
            ButtonChangePassword.Enabled = False
        Else
            ErrorProviderChangePassword.Dispose()
        End If
    End Sub

    Private Sub TextNewPassword_TextChanged(sender As Object, e As EventArgs) Handles TextNewPassword.TextChanged
        If TextNewPassword.Text = "" Then
            ErrorProviderChangePassword.SetError(TextNewPassword, "Password can't be empty.")
            ButtonChangePassword.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextNewPassword.Text, pattern:="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$#!%*?&])[A-Za-z\d$@$#!%*?&]{8,}") Then
                ErrorProviderChangePassword.SetError(TextNewPassword, "Password must contain minimum eight characters, at least one uppercase letter, one
lowercase letter, one number and one special character.")
                ButtonChangePassword.Enabled = False
            Else
                ErrorProviderChangePassword.Dispose()
            End If
        End If
    End Sub

    Private Sub TextNewPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextNewPassword.Validating
        If TextNewPassword.Text = "" Then
            ErrorProviderChangePassword.SetError(TextNewPassword, "Password can't be empty.")
            ButtonChangePassword.Enabled = False
            TextNewPassword.Focus()
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextNewPassword.Text, pattern:="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$#!%*?&])[A-Za-z\d$@$#!%*?&]{8,}") Then
                ErrorProviderChangePassword.SetError(TextNewPassword, "Password must contain minimum eight characters, at least one uppercase letter, one
lowercase letter, one number and one special character.")
                ButtonChangePassword.Enabled = False
                TextNewPassword.Focus()
            Else
                ErrorProviderChangePassword.Dispose()
            End If
        End If
    End Sub

    Private Sub TextConfirmation_TextChanged(sender As Object, e As EventArgs) Handles TextConfirmation.TextChanged
        If TextConfirmation.Text = "" Then
            ErrorProviderChangePassword.SetError(TextConfirmation, "Password can't be empty.")
            ButtonChangePassword.Enabled = False
        Else
            If TextNewPassword.Text <> TextConfirmation.Text Then
                ErrorProviderChangePassword.SetError(TextConfirmation, "The two password fields didn't match.")
                ButtonChangePassword.Enabled = False
            Else
                ErrorProviderChangePassword.Dispose()
                If TextOldPassword.Text <> "" And TextNewPassword.Text <> "" Then
                    ButtonChangePassword.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub TextConfirmation_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextConfirmation.Validating
        If TextConfirmation.Text = "" Then
            ErrorProviderChangePassword.SetError(TextConfirmation, "Password can't be empty.")
            ButtonChangePassword.Enabled = False
            TextConfirmation.Focus()
        Else
            If TextNewPassword.Text <> TextConfirmation.Text Then
                ErrorProviderChangePassword.SetError(TextConfirmation, "The two password fields didn't match.")
                ButtonChangePassword.Enabled = False
                TextConfirmation.Focus()
            Else
                ErrorProviderChangePassword.Dispose()
                If TextOldPassword.Text <> "" And TextNewPassword.Text <> "" Then
                    ButtonChangePassword.Enabled = True
                End If
            End If
        End If
    End Sub
End Class