Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class FormReportII
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountSession As Integer = 0
    Dim CountSemester As Integer = 0
    Dim CountSubject As Integer = 0
    Dim CountCourse As Integer = 0
    Dim CountCollege As Integer = 0

    Private Sub FormReportII_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Collegewise Back Report in a Particular Subject")   ' Form Styles
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
        FillColleges()   ' To fill combobox with Colleges
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

    Private Sub FillColleges()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = "SELECT * FROM colleges;"
            Command = New MySqlCommand(Query, Con)
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

    Private Sub ComboBoxCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCollege.SelectedIndexChanged
        ComboBoxCourse.Items.Clear()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM colleges WHERE COLLEGE_NAME = '{ComboBoxCollege.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim CollegeID As String = Reader.GetString(column:="COLLEGE_ID")
            Reader.Dispose()
            Query = $"SELECT COURSE_NAME FROM collegewise_courses, courses, universitywise_courses WHERE universitywise_courses.COURSE_ID=courses.COURSE_ID AND
collegewise_courses.UNIVERSITYWISE_COURSE_ID=universitywise_courses.UNIVERSITYWISE_COURSE_ID AND collegewise_courses.COLLEGE_ID='{CollegeID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
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
        If CountCollege <> 0 And CountSession <> 0 And CountSemester <> 0 And ComboBoxCollege.SelectedItem <> Nothing And ComboBoxSession.SelectedItem <> Nothing And
                ComboBoxSemester.SelectedItem <> Nothing And CountSubject <> 0 And ComboBoxSubject.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If ComboBoxCourse.SelectedItem <> Nothing And CountCourse <> 0 Then
            FillSubjects()
        End If
        If CountCollege <> 0 And CountCourse <> 0 And CountSemester <> 0 And ComboBoxCollege.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
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
        If CountCollege <> 0 And CountCourse <> 0 And CountSession <> 0 And ComboBoxCollege.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing And CountSubject <> 0 And ComboBoxSubject.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSubject.SelectedIndexChanged
        If CountCollege <> 0 And CountCourse <> 0 And CountSession <> 0 And ComboBoxCollege.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing And CountSemester <> 0 And ComboBoxSemester.SelectedItem <> Nothing Then
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
            Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND
coursewise_subjects.UNIVERSITYWISE_COURSE_ID=(SELECT UNIVERSITYWISE_COURSE_ID FROM universitywise_courses
WHERE UNIVERSITY_ID = (SELECT UNIVERSITY_ID FROM colleges WHERE COLLEGE_NAME = '{ComboBoxCollege.SelectedItem}') AND
COURSE_ID = (SELECT COURSE_ID FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}')) AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters
WHERE SESSION_ID = '{ComboBoxSession.SelectedItem}' AND SEMESTER_ID = (SELECT SEMESTER_ID FROM semesters WHERE SEMESTER = '{ComboBoxSemester.SelectedItem}'));"
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

    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Click
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }
        Dim Reader As MySqlDataReader
        Dim Flag As Integer
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT COUNT(UNIVERSITY_ROLL_NUMBER) FROM students, colleges WHERE UNIVERSITY_ROLL_NUMBER IN (SELECT UNIVERSITY_ROLL_NUMBER
FROM marksheets WHERE SUBJECT_ID = (SELECT SUBJECT_ID FROM subjects WHERE subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND SUBJECT_NAME =
'{ComboBoxSubject.SelectedItem}') AND COURSE_ID = (SELECT COURSE_ID FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}') AND
RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status WHERE RESULT_STATUS='Back') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM
sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND
SESSION_ID='{ComboBoxSession.SelectedItem}')) AND colleges.COLLEGE_ID=students.COLLEGE_ID AND COLLEGE_NAME = '{ComboBoxCollege.SelectedItem}';"
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

            cmd.CommandText = $"SELECT UNIVERSITY_ROLL_NUMBER AS 'ROLL NUMBER', CONCAT(FIRST_NAME, ' ', LAST_NAME) AS 'NAME OF THE STUDENT'
FROM students, colleges WHERE UNIVERSITY_ROLL_NUMBER IN (SELECT UNIVERSITY_ROLL_NUMBER FROM marksheets WHERE SUBJECT_ID =
(SELECT SUBJECT_ID FROM subjects WHERE subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND SUBJECT_NAME = '{ComboBoxSubject.SelectedItem}')
AND COURSE_ID = (SELECT COURSE_ID FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}') AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID
FROM result_status WHERE RESULT_STATUS='Back') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE 
SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID='{ComboBoxSession.SelectedItem}')) AND
colleges.COLLEGE_ID=students.COLLEGE_ID AND COLLEGE_NAME = '{ComboBoxCollege.SelectedItem}' ORDER BY UNIVERSITY_ROLL_NUMBER;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myReport.Load("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\CrystalReport2.rpt")
            myReport.SetDataSource(myData)

            myReport.SetParameterValue(name:="college", val:=$"{ComboBoxCollege.SelectedItem}")
            myReport.SetParameterValue(name:="course", val:=$"{ComboBoxCourse.SelectedItem}")
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
            cmd.CommandText = $"SELECT UNIVERSITY_ROLL_NUMBER AS 'ROLL NUMBER', CONCAT(FIRST_NAME, ' ', LAST_NAME) AS 'NAME OF THE STUDENT'
FROM students, colleges WHERE UNIVERSITY_ROLL_NUMBER IN (SELECT UNIVERSITY_ROLL_NUMBER FROM marksheets WHERE SUBJECT_ID =
(SELECT SUBJECT_ID FROM subjects WHERE subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND SUBJECT_NAME = '{ComboBoxSubject.SelectedItem}')
AND COURSE_ID = (SELECT COURSE_ID FROM courses WHERE COURSE_NAME = '{ComboBoxCourse.SelectedItem}') AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID
FROM result_status WHERE RESULT_STATUS='Back') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE 
SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID='{ComboBoxSession.SelectedItem}')) AND
colleges.COLLEGE_ID=students.COLLEGE_ID AND COLLEGE_NAME = '{ComboBoxCollege.SelectedItem}' ORDER BY UNIVERSITY_ROLL_NUMBER;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myData.WriteXml("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\dataset2.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message, caption:="Report could not be created.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub
End Class