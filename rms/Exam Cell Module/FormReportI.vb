Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class FormReportI
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountSession As Integer = 0
    Dim CountSemester As Integer = 0
    Dim CountSubject As Integer = 0
    Dim CountCourse As Integer = 0
    Dim CountUniversity As Integer = 0
    Dim CourseID As String
    Dim SemesterID As String
    Dim UniversityID As String
    Dim SessionID As String
    Dim SessionwiseSemesterID As String
    Dim UniversitywiseCourseID As String

    Private Sub ShowReport()
        Dim myReport As New ReportDocument
        Dim myData As New DataSet
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        conn = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms;Allow User Variables=True"
        }
        Try
            conn.Open()

            cmd.CommandText = $"SELECT UNIVERSITY_ROLL_NUMBER AS 'ROLL NUMBER', CONCAT(FIRST_NAME, ' ', LAST_NAME) AS 'NAME OF THE STUDENT',
COLLEGE_NAME AS 'NAME OF THE COLLEGE' FROM students, colleges, universities WHERE UNIVERSITY_ROLL_NUMBER IN (SELECT UNIVERSITY_ROLL_NUMBER FROM marksheets
WHERE SUBJECT_ID = (SELECT SUBJECT_ID FROM subjects WHERE marksheets.SUBJECT_ID = subjects.SUBJECT_ID AND SUBJECT_NAME = '{ComboBoxSubject.SelectedItem}')
AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status WHERE RESULT_STATUS='Back') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID
FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND 
SESSION_ID='{ComboBoxSession.SelectedItem}')) AND colleges.COLLEGE_ID=students.COLLEGE_ID AND UNIVERSITY_NAME='{ComboBoxUniversity.SelectedItem}' AND
universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID ORDER BY COLLEGE_NAME, UNIVERSITY_ROLL_NUMBER;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myReport.Load("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\CrystalReport1.rpt")
            myReport.SetDataSource(myData)

            myReport.SetParameterValue(name:="university", val:=$"{ComboBoxCourse.SelectedItem} ({ComboBoxUniversity.SelectedItem})")
            myReport.SetParameterValue(name:="session", val:=$"{ComboBoxSession.SelectedItem} ({ComboBoxSemester.SelectedItem}-Semester)")
            myReport.SetParameterValue(name:="date", val:=$"({DateTime.Today.ToString("d")})")
            myReport.SetParameterValue(name:="header", val:=$"List of students with back in {ComboBoxSubject.SelectedItem}")

            CrystalReportViewer1.ReportSource = myReport
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message, caption:="Report could not be created.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateDataSet()
        Dim myData As New DataSet
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter

        conn = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms;Allow User Variables=True"
        }

        Try
            conn.Open()
            cmd.CommandText = $"SELECT UNIVERSITY_ROLL_NUMBER AS 'ROLL NUMBER', CONCAT(FIRST_NAME, ' ', LAST_NAME) AS 'NAME OF THE STUDENT',
COLLEGE_NAME AS 'NAME OF THE COLLEGE' FROM students, colleges, universities WHERE UNIVERSITY_ROLL_NUMBER IN (SELECT UNIVERSITY_ROLL_NUMBER FROM marksheets
WHERE SUBJECT_ID = (SELECT SUBJECT_ID FROM subjects WHERE marksheets.SUBJECT_ID = subjects.SUBJECT_ID AND SUBJECT_NAME = '{ComboBoxSubject.SelectedItem}')
AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status WHERE RESULT_STATUS='Back') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID
FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND 
SESSION_ID='{ComboBoxSession.SelectedItem}')) AND colleges.COLLEGE_ID=students.COLLEGE_ID AND UNIVERSITY_NAME='{ComboBoxUniversity.SelectedItem}' AND
universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID ORDER BY COLLEGE_NAME, UNIVERSITY_ROLL_NUMBER;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myData.WriteXml("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\dataset1.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message, caption:="Report could not be created.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FormReportI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Universitywise Back Report in a Particular Subject")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelPrintMarksheets.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelReportLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelReport.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonGenerateReport.Enabled = False
        CrystalReportViewer1.Visible = False
        FillSessions()   ' To fill combobox with sessions
        FillSemesters()   ' To fill combobox with semesters
        FillUniversities()   ' To fill combobox with universities
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
                ComboBoxSemester.SelectedItem <> Nothing And CountSubject <> 0 And ComboBoxSubject.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse.SelectedIndexChanged
        FillSubjects()
        If CountUniversity <> 0 And CountSession <> 0 And CountSemester <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
                ComboBoxSemester.SelectedItem <> Nothing And CountSubject <> 0 And ComboBoxSubject.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub FillSubjects()
        CountSubject = 0
        ComboBoxSubject.Items.Clear()
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
            Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                CountSubject = CountSubject + 1
                ComboBoxSubject.Items.Add(Reader.GetString(column:="SUBJECT_NAME"))
            End While
            Con.Close()
            Reader.Dispose()
        Catch ex As Exception
            MessageBox.Show(text:="Selected semester is not available for selected session. Please, add the semester to the session.",
                            caption:="Semester unavailable alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If ComboBoxCourse.SelectedItem <> Nothing And CountCourse <> 0 Then
            FillSubjects()
        End If
        If CountUniversity <> 0 And CountCourse <> 0 And CountSemester <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
              ComboBoxSemester.SelectedItem <> Nothing And CountSubject <> 0 And ComboBoxSubject.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemester.SelectedIndexChanged
        If ComboBoxCourse.SelectedItem <> Nothing And CountCourse <> 0 Then
            FillSubjects()
        End If
        If CountUniversity <> 0 And CountCourse <> 0 And CountSession <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing And CountSubject <> 0 And ComboBoxSubject.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSubject.SelectedIndexChanged
        If CountUniversity <> 0 And CountCourse <> 0 And CountSession <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing And CountSemester <> 0 And ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Dim Flag As Integer
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT COUNT(UNIVERSITY_ROLL_NUMBER) FROM students, colleges, universities WHERE UNIVERSITY_ROLL_NUMBER IN
(SELECT UNIVERSITY_ROLL_NUMBER FROM marksheets WHERE SUBJECT_ID = (SELECT SUBJECT_ID FROM subjects WHERE marksheets.SUBJECT_ID
= subjects.SUBJECT_ID AND SUBJECT_NAME = '{ComboBoxSubject.SelectedItem}') AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status
WHERE RESULT_STATUS='Back') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID
FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID='{ComboBoxSession.SelectedItem}')) AND colleges.COLLEGE_ID=students.COLLEGE_ID AND
UNIVERSITY_NAME='{ComboBoxUniversity.SelectedItem}' AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Flag = Reader.GetInt16(column:="COUNT(UNIVERSITY_ROLL_NUMBER)")
            Reader.Dispose()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        If Flag = 0 Then
            MessageBox.Show(text:="No students have back in the selected subject.", caption:="No Students alert",
                            buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
            CrystalReportViewer1.Visible = False
        Else
            CrystalReportViewer1.Visible = True
            CreateDataSet()   ' To create a dataset on which the report will be based.
            ShowReport()   ' To show the report.
        End If
    End Sub
End Class