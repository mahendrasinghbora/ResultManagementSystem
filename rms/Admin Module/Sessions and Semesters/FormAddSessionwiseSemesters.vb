Imports MySql.Data.MySqlClient

Public Class FormAddSessionwiseSemesters
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountSession As Integer = 0
    Dim CountSemester As Integer = 0

    Private Sub FormAddSessionwiseSemesters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Sessionswise Semesters")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddSessionswiseSemesters.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        FillSessions()   ' To fill combobox with sessions
        FillSemesters()   ' To fill combobox with semesters
        PanelAddSessionwiseSemestersLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelSessionwiseSemesters.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddSessionwiseSemester.Enabled = False
    End Sub

    Private Sub FillSemesters()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = "SELECT * FROM semesters;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountSemester = CountSemester + 1
                ComboBoxSemester.Items.Add(Reader.GetString(column:="SEMESTER"))
            End While
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub FillSessions()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = "SELECT * FROM sessions;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountSession = CountSession + 1
                ComboBoxSession.Items.Add(Reader.GetString(column:="SESSION_ID"))
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
        ContextMenuStripAddSessionwiseSemesters.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub ComboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemester.SelectedIndexChanged
        If CountSemester <> 0 And CountSession <> 0 And ComboBoxSession.SelectedItem <> Nothing Then
            ButtonAddSessionwiseSemester.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddSessionwiseSemester_Click(sender As Object, e As EventArgs) Handles ButtonAddSessionwiseSemester.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM semesters WHERE SEMESTER = '{ComboBoxSemester.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim SemesterID As String = Reader.GetString(column:="SEMESTER_ID")
            Reader.Dispose()
            Query = $"INSERT INTO sessionwise_semesters (`SESSION_ID`, `SEMESTER_ID`, `USERNAME`) VALUES 
('{ComboBoxSession.SelectedItem}', '{SemesterID}', '{Username}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormAddSessionwiseSemesters As FormAddSessionwiseSemesters
            NewFormAddSessionwiseSemesters = New FormAddSessionwiseSemesters()
            NewFormAddSessionwiseSemesters.Show()
            Dispose()
            MessageBox.Show(text:="Semester successfully added to the session.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Semester already added to the session.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If CountSemester <> 0 And CountSession <> 0 And ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonAddSessionwiseSemester.Enabled = True
        End If
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub
End Class