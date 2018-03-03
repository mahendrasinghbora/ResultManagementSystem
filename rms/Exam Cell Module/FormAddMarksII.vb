Imports MySql.Data.MySqlClient

Public Class FormAddMarksII
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountCollege As Integer = 0
    Dim CountStudent As Integer = 0

    Private Sub FormAddMarksII_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Marks Information")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddMarksPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddMarksLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelAddMarks.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddMarks.Enabled = False
        FillColleges()   ' To fill combobox with colleges
        FillData()   ' To fill session and semester
        SetMaximum()   ' To set maximum length of textboxes
        FillSubjects()   ' To fill subjects
    End Sub

    Private Sub FillSubjects()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT COUNT(SUBJECT_NAME) FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.COURSE_ID='{CourseID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim TotalSubjects As Integer = Reader.GetString(column:="COUNT(SUBJECT_NAME)")
            Reader.Dispose()
            If TotalSubjects = 1 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.COURSE_ID='{CourseID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject2.Visible = False
                LabelSubject3.Visible = False
                LabelSubject4.Visible = False
                LabelSubject5.Visible = False
                LabelSubject6.Visible = False
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal2.Visible = False
                TextInternal3.Visible = False
                TextInternal4.Visible = False
                TextInternal5.Visible = False
                TextInternal6.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal2.Visible = False
                TextExternal3.Visible = False
                TextExternal4.Visible = False
                TextExternal5.Visible = False
                TextExternal6.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal2.Visible = False
                TextMarksInternal3.Visible = False
                TextMarksInternal4.Visible = False
                TextMarksInternal5.Visible = False
                TextMarksInternal6.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal2.Visible = False
                TextMarksExternal3.Visible = False
                TextMarksExternal4.Visible = False
                TextMarksExternal5.Visible = False
                TextMarksExternal6.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks2.Visible = False
                TextTotalMarks3.Visible = False
                TextTotalMarks4.Visible = False
                TextTotalMarks5.Visible = False
                TextTotalMarks6.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult2.Visible = False
                TextResult3.Visible = False
                TextResult4.Visible = False
                TextResult5.Visible = False
                TextResult6.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 2 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.COURSE_ID='{CourseID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
            End If
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub SetMaximum()
        TextMarksInternal1.MaxLength = 3
        TextMarksInternal2.MaxLength = 3
        TextMarksInternal3.MaxLength = 3
        TextMarksInternal4.MaxLength = 3
        TextMarksInternal5.MaxLength = 3
        TextMarksInternal6.MaxLength = 3
        TextMarksInternal7.MaxLength = 3
        TextMarksInternal8.MaxLength = 3
        TextMarksInternal9.MaxLength = 3
        TextMarksInternal10.MaxLength = 3
        TextMarksExternal1.MaxLength = 3
        TextMarksExternal2.MaxLength = 3
        TextMarksExternal3.MaxLength = 3
        TextMarksExternal4.MaxLength = 3
        TextMarksExternal5.MaxLength = 3
        TextMarksExternal6.MaxLength = 3
        TextMarksExternal7.MaxLength = 3
        TextMarksExternal8.MaxLength = 3
        TextMarksExternal9.MaxLength = 3
        TextMarksExternal10.MaxLength = 3
    End Sub

    Private Sub FillData()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            TextSession.Text = SessionID
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM semesters WHERE SEMESTER_ID='{SemesterID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextSemester.Text = Reader.GetString(column:="SEMESTER")
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub FillColleges()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT COLLEGE_NAME FROM collegewise_courses, colleges WHERE collegewise_courses.COURSE_ID='{CourseID}' AND
collegewise_courses.COLLEGE_ID=colleges.COLLEGE_ID;;"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountCollege = CountCollege + 1
                ComboBoxCollege.Items.Add(Reader.GetString(column:="COLLEGE_NAME"))
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

    Private Sub ComboBoxCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCollege.SelectedIndexChanged
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM colleges WHERE COLLEGE_NAME = '{ComboBoxCollege.SelectedItem}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim CollegeID As String = Reader.GetString(column:="COLLEGE_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM students WHERE COLLEGE_ID='{CollegeID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountStudent = CountStudent + 1
                ComboBoxRoll.Items.Add(Reader.GetString(column:="UNIVERSITY_ROLL_NUMBER"))
            End While
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxRoll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoll.SelectedIndexChanged
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM students WHERE UNIVERSITY_ROLL_NUMBER='{ComboBoxRoll.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextName.Text = Reader.GetString(column:="FIRST_NAME") & " " & Reader.GetString(column:="LAST_NAME")
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class