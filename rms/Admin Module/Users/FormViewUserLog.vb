Imports MySql.Data.MySqlClient

Public Class FormViewUserLog
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormViewUserLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | View Users' Log")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelViewUserLog.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelLogLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelLog.ForeColor = Color.FromArgb(255, 255, 255)
        FillUsers()    ' To fill combobox with users
        LoadDefaultLog()   ' To fill the datagrid with the log details of the current user
    End Sub

    Private Sub LoadDefaultLog()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms;Allow User Variables=True"
        }
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE USERNAME='{Username}';"
            Command = New MySqlCommand(Query, Con)
            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextName.Text = Reader.GetString(column:="FIRST_NAME") & " " & Reader.GetString(column:="LAST_NAME")
            Reader.Dispose()
            Query = $"SELECT @Record:=@Record+1 As 'Record #', LOG_IN_TIME, LOG_OUT_TIME FROM USERS_LOG JOIN (SELECT @Record:=0) As Alias 
WHERE USERNAME='{Username}' ORDER BY LOG_IN_TIME DESC;"
            Using Command As New MySqlCommand(cmdText:=Query, connection:=Con)
                Command.CommandType = CommandType.Text
                Using DataAdapter As New MySqlDataAdapter(Command)
                    Using Table As New DataTable()
                        DataAdapter.Fill(Table)
                        DataGridViewLog.DataSource = Table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub FillUsers()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE STATUS='1';"
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

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripViewUserLog.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub

    Private Sub ComboBoxUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsername.SelectedIndexChanged
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms;Allow User Variables=True"
        }
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE USERNAME='{ComboBoxUsername.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Dim Reader As MySqlDataReader
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextName.Text = Reader.GetString(column:="FIRST_NAME") & " " & Reader.GetString(column:="LAST_NAME")
            Reader.Dispose()
            Query = $"SELECT @Record:=@Record+1 As 'Record #', LOG_IN_TIME, LOG_OUT_TIME FROM USERS_LOG JOIN (SELECT @Record:=0) As Alias 
WHERE USERNAME='{ComboBoxUsername.SelectedItem}' ORDER BY LOG_IN_TIME DESC;"
            Using Command As New MySqlCommand(cmdText:=Query, connection:=Con)
                Command.CommandType = CommandType.Text
                Using DataAdapter As New MySqlDataAdapter(Command)
                    Using Table As New DataTable()
                        DataAdapter.Fill(Table)
                        DataGridViewLog.DataSource = Table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class