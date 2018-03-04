Imports MySql.Data.MySqlClient

Public Class FormAddCoursewiseSubjects
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountSubject As Integer = 0
    Dim CountCourse As Integer = 0
    Dim CountSemester As Integer = 0
    Dim CountSession As Integer = 0
    Dim CountUniversity As Integer = 0

    Private Sub FormAddCoursewiseSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Coursewise Subjects")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddCoursewiseSubjects.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddCoursewiseSubjectsLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelCoursewiseSubjects.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddCoursewiseSubject.Enabled = False
        FillSubjects()   ' To fill combobox with subjects
        FillSemesters()   ' To fill combobox with semesters
        FillSessions()   ' To fill combobox with sessions
        FillUniversities()   ' To fill combobox with universities
    End Sub

    Private Sub FillUniversities()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM universities;"
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

    Private Sub FillSubjects()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = "SELECT * FROM subjects;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountSubject = CountSubject + 1
                ComboBoxSubject.Items.Add(Reader.GetString(column:="SUBJECT_NAME"))
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
        ContextMenuStripAddCoursewiseSubjects.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub ComboBoxSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSubject.SelectedIndexChanged
        If CountSubject <> 0 And CountCourse <> 0 And ComboBoxCourse.SelectedItem <> Nothing And CountSemester <> 0 And CountSession <> 0 And
            ComboBoxSemester.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
            CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing Then
            ButtonAddCoursewiseSubject.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddCoursewiseSubject_Click(sender As Object, e As EventArgs) Handles ButtonAddCoursewiseSubject.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM subjects WHERE SUBJECT_NAME = '{ComboBoxSubject.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim SubjectID As String = Reader.GetString(column:="SUBJECT_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM universities WHERE UNIVERSITY_NAME = '{ComboBoxUniversity.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim UniversityID As String = Reader.GetString(column:="UNIVERSITY_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim CourseID As String = Reader.GetString(column:="COURSE_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM semesters WHERE SEMESTER = '{ComboBoxSemester.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim SemesterID As String = Reader.GetString(column:="SEMESTER_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM sessionwise_semesters WHERE SESSION_ID = '{ComboBoxSession.SelectedItem}' AND SEMESTER_ID = '{SemesterID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim SessionwiseSemesterID As String = Reader.GetString(column:="SESSIONWISE_SEMESTER_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM universitywise_courses WHERE UNIVERSITY_ID = '{UniversityID}' AND COURSE_ID = '{CourseID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim UniversitywiseCourseID As String = Reader.GetString(column:="UNIVERSITYWISE_COURSE_ID")
            Reader.Dispose()
            Query = $"INSERT INTO coursewise_Subjects (`UNIVERSITYWISE_COURSE_ID`, `SUBJECT_ID`, `SESSIONWISE_SEMESTER_ID`, `USERNAME`) VALUES 
('{UniversitywiseCourseID}', '{SubjectID}', '{SessionwiseSemesterID}', '{Username}');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormAddCoursewiseSubjects As FormAddCoursewiseSubjects
            NewFormAddCoursewiseSubjects = New FormAddCoursewiseSubjects()
            NewFormAddCoursewiseSubjects.Show()
            Dispose()
            MessageBox.Show(text:="Subject successfully added to the course.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Subject already added to the course or selected semester is not available for selected session.",
                            caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse.SelectedIndexChanged
        If CountSubject <> 0 And CountCourse <> 0 And ComboBoxSubject.SelectedItem <> Nothing And CountSemester <> 0 And CountSession <> 0 And
            ComboBoxSemester.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
            CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing Then
            ButtonAddCoursewiseSubject.Enabled = True
        Else
            ButtonAddCoursewiseSubject.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemester.SelectedIndexChanged
        If CountSubject <> 0 And CountCourse <> 0 And ComboBoxCourse.SelectedItem <> Nothing And CountSemester <> 0 And CountSession <> 0 And
            ComboBoxSubject.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
            CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing Then
            ButtonAddCoursewiseSubject.Enabled = True
        Else
            ButtonAddCoursewiseSubject.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If CountSubject <> 0 And CountCourse <> 0 And ComboBoxCourse.SelectedItem <> Nothing And CountSemester <> 0 And CountSession <> 0 And
            ComboBoxSemester.SelectedItem <> Nothing And ComboBoxSubject.SelectedItem <> Nothing And
            CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing Then
            ButtonAddCoursewiseSubject.Enabled = True
        Else
            ButtonAddCoursewiseSubject.Enabled = False
        End If
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
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
        If CountSubject <> 0 And CountCourse <> 0 And ComboBoxSubject.SelectedItem <> Nothing And CountSemester <> 0 And CountSession <> 0 And
            ComboBoxSemester.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
            CountUniversity <> 0 And ComboBoxCourse.SelectedItem <> Nothing Then
            ButtonAddCoursewiseSubject.Enabled = True
        Else
            ButtonAddCoursewiseSubject.Enabled = False
        End If
    End Sub

    Private Sub ButtonAddUniversitywiseCourses_Click(sender As Object, e As EventArgs) Handles ButtonAddUniversitywiseCourses.Click
        Dim NewFormAddUniversitywiseCourses As FormAddUniversitywiseCourses
        NewFormAddUniversitywiseCourses = New FormAddUniversitywiseCourses()
        NewFormAddUniversitywiseCourses.Show()
        Dispose()
    End Sub
End Class