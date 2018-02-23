﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormAddUsers
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
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
        LabelUsername.Text = FullUsername & "    "   ' Extra spaces to accomodate the dropdown arrow.
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddUsersLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelAddUsers.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddUsers.Enabled = False
        RadioButtonUserType1.Select()   ' Admin- Selected by default.
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripUsers.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonSelectImage_Click(sender As Object, e As EventArgs) Handles ButtonSelectImage.Click
        OpenFileDialogAddUsers.Title = "Choose an image"
        OpenFileDialogAddUsers.Filter = "Image files (*.jpg*.jpeg*.png*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*"
        If OpenFileDialogAddUsers.ShowDialog() = DialogResult.OK Then
            PictureBoxThumbnail.Image = Image.FromFile(OpenFileDialogAddUsers.FileName())
        End If
    End Sub

    Private Sub TextUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextUsername.Validating
        If TextUsername.Text = "" Then
            ErrorProviderAddUsers.SetError(control:=TextUsername, value:="Username can't be empty.")
        Else
            ErrorProviderAddUsers.Dispose()
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

    Private Sub TextUsername_TextChanged(sender As Object, e As EventArgs) Handles TextUsername.TextChanged
        If TextUsername.Text = "" Then
            ButtonAddUsers.Enabled = False
        Else
            ErrorProviderAddUsers.Dispose()
            ButtonAddUsers.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddUsers_Click(sender As Object, e As EventArgs) Handles ButtonAddUsers.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }

        Dim Stream As New MemoryStream
        PictureBoxThumbnail.Image.Save(stream:=Stream, format:=PictureBoxThumbnail.Image.RawFormat)
        Dim UserType As Integer
        If RadioButtonUserType1.Checked = True Then
            UserType = 1
        Else
            UserType = 2
        End If

        Try
            Con.Open()
            Dim Query As String
            ' Default Password- 123456
            Query = $"INSERT INTO users VALUES ('{TextUsername.Text}', '{TextFirstName.Text}', '{TextLastName.Text}', '123456', '{UserType}', @THUMBNAIL, '1');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Command.Parameters.Add("@THUMBNAIL", MySqlDbType.Blob).Value = Stream.ToArray()
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddUsers As FormAddUsers
            NewFormAddUsers = New FormAddUsers()
            NewFormAddUsers.Show()
            Dispose()
            MessageBox.Show(text:="User successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class