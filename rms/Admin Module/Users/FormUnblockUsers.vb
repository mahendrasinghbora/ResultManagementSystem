Imports MySql.Data.MySqlClient

Public Class FormUnblockUsers
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormUnblockUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Unblock Users")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelUnblockUsersPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelUnblockUsersLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelUnblockUsers.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonUnblockUser.Enabled = False
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
            Query = "SELECT * FROM users WHERE STATUS='0';"
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
        ContextMenuStripDeleteUsers.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub

    Private Sub ButtonBlockUsers_Click(sender As Object, e As EventArgs) Handles ButtonBlockUsers.Click
        Dim NewFormDeleteUsers As FormDeleteUsers
        NewFormDeleteUsers = New FormDeleteUsers()
        NewFormDeleteUsers.Show()
        Dispose()
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
            TextName.Text = Reader.GetString("FIRST_NAME") & " " & Reader.GetString("LAST_NAME")
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        ButtonUnblockUser.Enabled = True
    End Sub

    Private Sub ButtonUnblockUser_Click(sender As Object, e As EventArgs) Handles ButtonUnblockUser.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"UPDATE users SET STATUS='1' WHERE USERNAME='{ComboBoxUsername.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormUnblockUsers As FormUnblockUsers
            NewFormUnblockUsers = New FormUnblockUsers()
            NewFormUnblockUsers.Show()
            Dispose()
            MessageBox.Show(text:="User successfully unblocked.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try

    End Sub
End Class