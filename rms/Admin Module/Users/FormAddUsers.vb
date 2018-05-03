Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormAddUsers
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormAddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Users")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddUsersPanel.ForeColor = Color.FromArgb(255, 255, 255)
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddUsersLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelAddUsers.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddUsers.Enabled = False
        TextUsername.MaxLength = 20   ' Maximum Length of Username
        TextFirstName.MaxLength = 50   ' Maximum Length of First Name
        TextLastName.MaxLength = 50   ' Maximum Length of Last Name
        RadioButtonUserType1.Select()   ' Admin- Selected by default.
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
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
            TextUsername.Focus()
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
            ErrorProviderAddUsers.SetError(control:=TextFirstName, value:="First name can't contain digits.")
            TextFirstName.Focus()
        End If
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderAddUsers.Dispose()
        End If
    End Sub

    Private Sub TextFirstName_TextChanged(sender As Object, e As EventArgs) Handles TextFirstName.TextChanged
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") And TextUsername.Text <> "" Then
            ErrorProviderAddUsers.Dispose()
            ButtonAddUsers.Enabled = True
        Else
            ButtonAddUsers.Enabled = False
        End If
    End Sub

    Private Sub TextLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextLastName.Validating
        If System.Text.RegularExpressions.Regex.IsMatch(TextLastName.Text, "\d+") Then
            ErrorProviderAddUsers.SetError(control:=TextLastName, value:="Last name can't contain digits.")
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
            ErrorProviderAddUsers.SetError(TextUsername, "Username can't be empty.")
            TextUsername.Focus()
            ButtonAddUsers.Enabled = False
        Else
            If System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[^a-zA-Z0-9\._]") Then
                ErrorProviderAddUsers.SetError(TextUsername, "Username can only contain letters, digits, dot and underscore.")
                ButtonAddUsers.Enabled = False
                TextUsername.Focus()
            Else
                If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[a-zA-Z]+[0-9\._]*") Then
                    ErrorProviderAddUsers.SetError(TextUsername, "Username must contain atleast one letter.")
                    ButtonAddUsers.Enabled = False
                    TextUsername.Focus()
                Else
                    If TextFirstName.Text <> "" Then
                        ErrorProviderAddUsers.Dispose()
                        ButtonAddUsers.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonAddUsers_Click(sender As Object, e As EventArgs) Handles ButtonAddUsers.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }

        Dim Stream As New MemoryStream
        PictureBoxThumbnail.Image.Save(stream:=Stream, format:=PictureBoxThumbnail.Image.RawFormat)
        Dim UserType As Integer
        If RadioButtonUserType1.Checked() = True Then
            UserType = 1
        Else
            UserType = 2
        End If

        Try
            Con.Open()
            Dim Query As String
            ' Default Password- username
            Query = $"INSERT INTO users VALUES ('{TextUsername.Text}', '{TextFirstName.Text}', '{TextLastName.Text}', '{TextUsername.Text}', '{UserType}', @THUMBNAIL, '1');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Command.Parameters.Add("@THUMBNAIL", MySqlDbType.Blob).Value = Stream.ToArray()
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddUsers As FormAddUsers
            NewFormAddUsers = New FormAddUsers()
            NewFormAddUsers.Show()
            Dispose()
            MessageBox.Show(text:="User successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Username already in use. Please choose a different username.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub
End Class