Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormEditProfileExamCell
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormEditProfileExamCell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Edit Profile")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelEditProfilePanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelEditProfileLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelEditProfile.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonEditProfile.Enabled = False
        FillData()   ' To fill the current data of the user
    End Sub

    Private Sub FillData()
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE USERNAME='{Username}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextUsername.Text = Username
            TextFirstName.Text = Reader.GetString("FIRST_NAME")
            TextLastName.Text = Reader.GetString("LAST_NAME")
            Con.Close()
            Reader.Dispose()
            Dim ImageByte() As Byte
            Dim Stream As MemoryStream
            Dim Adapter As MySqlDataAdapter   ' Data Adapter
            Dim Table As New DataTable()   ' Data Table
            Adapter = New MySqlDataAdapter(Command)
            Adapter.Fill(Table)
            ImageByte = Table(0)(5)
            Stream = New MemoryStream(ImageByte)
            PictureBoxThumbnail.Image = Image.FromStream(stream:=Stream)
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        ButtonEditProfile.Enabled = True
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
        ExamCellDashboard(CallingForm:=Me)
    End Sub

    Private Sub ButtonSelectImage_Click(sender As Object, e As EventArgs) Handles ButtonSelectImage.Click
        OpenFileDialogEditProfile.Title = "Choose an image"
        OpenFileDialogEditProfile.Filter = "Image files (*.jpg*.jpeg*.png*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*"
        If OpenFileDialogEditProfile.ShowDialog() = DialogResult.OK Then
            PictureBoxThumbnail.Image = Image.FromFile(OpenFileDialogEditProfile.FileName())
        End If
    End Sub

    Private Sub TextUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextUsername.Validating
        If TextUsername.Text = "" Then
            ErrorProviderEditProfile.SetError(control:=TextUsername, value:="Username can't be empty.")
            TextUsername.Focus()
        Else
            ErrorProviderEditProfile.Dispose()
        End If
    End Sub

    Private Sub TextFirstName_Validating(sender As Object, e As EventArgs) Handles TextFirstName.Validating
        If TextFirstName.Text = "" Then
            ErrorProviderEditProfile.SetError(control:=TextFirstName, value:="First name can't be empty.")
            TextFirstName.Focus()
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderEditProfile.SetError(control:=TextFirstName, value:="First name can't contain digits.")
            TextFirstName.Focus()
        End If
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderEditProfile.Dispose()
        End If
    End Sub

    Private Sub TextFirstName_TextChanged(sender As Object, e As EventArgs) Handles TextFirstName.TextChanged
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") And TextUsername.Text <> "" Then
            ErrorProviderEditProfile.Dispose()
            ButtonEditProfile.Enabled = True
        Else
            ButtonEditProfile.Enabled = False
        End If
    End Sub

    Private Sub TextLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextLastName.Validating
        If System.Text.RegularExpressions.Regex.IsMatch(TextLastName.Text, "\d+") Then
            ErrorProviderEditProfile.SetError(control:=TextLastName, value:="Last name can't contain digits.")
            TextLastName.Focus()
        Else
            ErrorProviderEditProfile.Dispose()
        End If
    End Sub

    Private Sub TextUsername_TextChanged(sender As Object, e As EventArgs) Handles TextUsername.TextChanged
        If TextUsername.Text = "" Then
            ErrorProviderEditProfile.SetError(TextUsername, "Username can't be empty.")
            TextUsername.Focus()
            ButtonEditProfile.Enabled = False
        Else
            If System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[^a-zA-Z0-9\._]") Then
                ErrorProviderEditProfile.SetError(TextUsername, "Username can only contain letters, digits, dot and underscore.")
                ButtonEditProfile.Enabled = False
                TextUsername.Focus()
            Else
                If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[a-zA-Z]+[0-9\._]*") Then
                    ErrorProviderEditProfile.SetError(TextUsername, "Username must contain atleast one letter.")
                    ButtonEditProfile.Enabled = False
                    TextUsername.Focus()
                Else
                    If TextFirstName.Text <> "" Then
                        ErrorProviderEditProfile.Dispose()
                        ButtonEditProfile.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonEditProfile_Click(sender As Object, e As EventArgs) Handles ButtonEditProfile.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }

        Dim Stream As New MemoryStream
        PictureBoxThumbnail.Image.Save(stream:=Stream, format:=PictureBoxThumbnail.Image.RawFormat)
        Try
            Con.Open()
            Dim Query As String
            Query = $"UPDATE users SET USERNAME='{TextUsername.Text}', FIRST_NAME='{TextFirstName.Text}', LAST_NAME='{TextLastName.Text}',
THUMBNAIL=@THUMBNAIL WHERE USERNAME='{Username}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Command.Parameters.Add("@THUMBNAIL", MySqlDbType.Blob).Value = Stream.ToArray()
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormEditProfile As FormEditProfile
            NewFormEditProfile = New FormEditProfile()
            NewFormEditProfile.Show()
            Dispose()
            MessageBox.Show(text:="Profile successfully updated.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Username already in use. Please choose a different username.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ButtonChangePassword_Click(sender As Object, e As EventArgs) Handles ButtonChangePassword.Click
        Dim NewFormChangePasswordExamCell As FormChangePasswordExamCell
        NewFormChangePasswordExamCell = New FormChangePasswordExamCell()
        NewFormChangePasswordExamCell.Show()
        Dispose()
    End Sub
End Class