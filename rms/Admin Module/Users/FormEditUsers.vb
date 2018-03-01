Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormEditUsers
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormEditUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Change Users' Authority")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelEditUsersPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelEditUsersLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelEditUsers.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonEditUsers.Enabled = False
        FillUsers()    ' To fill combobox with users
    End Sub

    Private Sub FillUsers()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE STATUS='1' AND USERNAME<>'{Username}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                ComboBoxUsername.Items.Add(Reader.GetString(column:="USERNAME"))
            End While
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
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

    Private Sub ComboBoxUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsername.SelectedIndexChanged
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE USERNAME='{ComboBoxUsername.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextFirstName.Text = Reader.GetString("FIRST_NAME")
            TextLastName.Text = Reader.GetString("LAST_NAME")
            Dim UserStatusID As Integer = Reader.GetInt16("USER_STATUS_ID")
            If UserStatusID = 1 Then
                RadioButtonUserType1.Select()
            Else
                RadioButtonUserType2.Select()
            End If
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
        ButtonEditUsers.Enabled = True
    End Sub

    Private Sub ButtonEditUsers_Click(sender As Object, e As EventArgs) Handles ButtonEditUsers.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Dim UserStatusID As Integer
            If RadioButtonUserType1.Checked() Then
                UserStatusID = 1
            Else
                UserStatusID = 2
            End If
            Query = $"UPDATE users SET USER_STATUS_ID='{UserStatusID}' WHERE USERNAME='{ComboBoxUsername.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormEditUsers As FormEditUsers
            NewFormEditUsers = New FormEditUsers()
            NewFormEditUsers.Show()
            Dispose()
            MessageBox.Show(text:="User successfully Edited.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub
End Class