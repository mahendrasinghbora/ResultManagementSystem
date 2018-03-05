Imports MySql.Data.MySqlClient

Public Class FormAddMarks
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountSession As Integer = 0
    Dim CountSemester As Integer = 0
    Dim CountCourse As Integer = 0
    Dim CountUniversity As Integer = 0

    Private Sub FormAddMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Marks Information")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddMarksPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddMarksLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelAddMarks.ForeColor = Color.FromArgb(255, 255, 255)
        FillSessions()   ' To fill combobox with sessions
        FillSemesters()   ' To fill combobox with semesters
        FillUniversities()   ' To fill combobox with universities
        ButtonAddMarks.Enabled = False
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        ExamCellDashboard(CallingForm:=Me)
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfileExamCell(CallingForm:=Me)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripUsers.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
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

    Private Sub FillUniversities()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = "SELECT * FROM universities;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountUniversity = CountUniversity + 1
                ComboBoxUniversity.Items.Add(Reader.GetString(column:="UNIVERSITY_NAME"))
            End While
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxUniversity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUniversity.SelectedIndexChanged
        ComboBoxCourse.Items.Clear()
        CountCourse = 0
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM universities WHERE UNIVERSITY_NAME = '{ComboBoxUniversity.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim UniversityID As String = Reader.GetString(column:="UNIVERSITY_ID")
            Reader.Dispose()
            Query = $"SELECT COURSE_NAME FROM universitywise_courses, courses WHERE
universitywise_courses.COURSE_ID=courses.COURSE_ID AND universitywise_courses.UNIVERSITY_ID='{UniversityID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountCourse = CountCourse + 1
                ComboBoxCourse.Items.Add(Reader.GetString(column:="COURSE_NAME"))
            End While
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        If CountCourse <> 0 And CountSession <> 0 And CountSemester <> 0 And ComboBoxCourse.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
                ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonAddMarks.Enabled = True
        Else
            ButtonAddMarks.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse.SelectedIndexChanged
        If CountUniversity <> 0 And CountSession <> 0 And CountSemester <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
                ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonAddMarks.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If CountUniversity <> 0 And CountCourse <> 0 And CountSemester <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
              ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonAddMarks.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemester.SelectedIndexChanged
        If CountUniversity <> 0 And CountCourse <> 0 And CountSession <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing Then
            ButtonAddMarks.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddMarks_Click(sender As Object, e As EventArgs) Handles ButtonAddMarks.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            CourseID = Reader.GetString(column:="COURSE_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM semesters WHERE SEMESTER = '{ComboBoxSemester.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            SemesterID = Reader.GetString(column:="SEMESTER_ID")
            Reader.Dispose()
            SessionID = ComboBoxSession.SelectedItem
            Query = $"SELECT * FROM sessionwise_semesters WHERE SESSION_ID = '{ComboBoxSession.SelectedItem}' AND SEMESTER_ID = '{SemesterID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            SessionwiseSemesterID = Reader.GetString(column:="SESSIONWISE_SEMESTER_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM universities WHERE UNIVERSITY_NAME = '{ComboBoxUniversity.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            UniversityID = Reader.GetString(column:="UNIVERSITY_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM universitywise_courses WHERE UNIVERSITY_ID = '{UniversityID}' AND COURSE_ID = '{CourseID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            UniversitywiseCourseID = Reader.GetString(column:="UNIVERSITYWISE_COURSE_ID")
            Reader.Dispose()
            Con.Close()
            Dim NewFormAddMarksII As FormAddMarksII
            NewFormAddMarksII = New FormAddMarksII()
            NewFormAddMarksII.Show()
            Dispose()
        Catch ex As Exception
            MessageBox.Show(text:="Selected semester is not available for selected session. Please, add the semester to the session.",
                            caption:="Semester unavailable alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class