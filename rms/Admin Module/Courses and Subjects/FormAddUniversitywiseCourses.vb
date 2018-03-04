Imports MySql.Data.MySqlClient

Public Class FormAddUniversitywiseCourses
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountUniversity As Integer = 0
    Dim CountCourse As Integer = 0

    Private Sub FormAddUniversitywiseCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Universitywise Courses")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddUniversitywiseCourses.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        FillUniversities()   ' To fill combobox with universities
        FillCourses()   ' To fill combobox with courses
        PanelAddUniversitywiseCoursesLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelUniversitywiseCourses.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddUniversitywiseCourses.Enabled = False
    End Sub

    Private Sub FillCourses()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = "SELECT * FROM courses;"
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

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddUniversitywiseCourses.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
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

    Private Sub ComboBoxUniversity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUniversity.SelectedIndexChanged
        If CountUniversity <> 0 And CountCourse <> 0 And ComboBoxCourse.SelectedItem <> Nothing Then
            ButtonAddUniversitywiseCourses.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse.SelectedIndexChanged
        If CountUniversity <> 0 And CountCourse <> 0 And ComboBoxUniversity.SelectedItem <> Nothing Then
            ButtonAddUniversitywiseCourses.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddUniversitywiseCourses_Click(sender As Object, e As EventArgs) Handles ButtonAddUniversitywiseCourses.Click
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
            Query = $"SELECT * FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim CourseID As String = Reader.GetString(column:="COURSE_ID")
            Reader.Dispose()
            Query = $"INSERT INTO universitywise_courses (`UNIVERSITY_ID`, `COURSE_ID`, `USERNAME`) VALUES 
('{UniversityID}', '{CourseID}', '{Username}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormAddUniversitywiseCourses As FormAddUniversitywiseCourses
            NewFormAddUniversitywiseCourses = New FormAddUniversitywiseCourses()
            NewFormAddUniversitywiseCourses.Show()
            Dispose()
            MessageBox.Show(text:="Course successfully added to the university.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Course already added to the university.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ButtonAddCollegewiseCourses_Click_1(sender As Object, e As EventArgs) Handles ButtonAddCollegewiseCourses.Click
        Dim NewFormAddCollegewiseCourses As FormAddCollegewiseCourses
        NewFormAddCollegewiseCourses = New FormAddCollegewiseCourses()
        NewFormAddCollegewiseCourses.Show()
        Dispose()
    End Sub
End Class