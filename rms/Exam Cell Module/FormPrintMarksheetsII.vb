Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class FormPrintMarksheetsII
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountCollege As Integer = 0
    Dim CountStudent As Integer = 0
    Dim CollegeName As String
    Dim CourseName As String
    Dim StudentName As String
    Dim Session As String
    Dim Serial As String
    Dim Semester As String
    Dim University As String
    Dim Total As String
    Dim Result As String
    Dim PassingTheory As String
    Dim Passing As String

    Private Sub FormPrintMarksheetsII_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Print Marksheets")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        LabelPrintMarksheetsPanel.ForeColor = Color.FromArgb(255, 255, 255)
        LabelCourse.ForeColor = Color.FromArgb(255, 255, 255)
        LabelCourse.BackColor = Color.FromArgb(44, 150, 118)
        FillColleges()   ' To fill combobox with colleges
        FillLabel()
        ButtonGenerateMarksheet.Enabled = False
        CrystalReportViewer1.Visible = False
    End Sub

    Private Sub FillLabel()
        Con = New MySqlConnection With {
                    .ConnectionString = "server=localhost;userid=root;database=rms"
                }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM courses WHERE COURSE_ID='{CourseID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim Course As String = Reader.GetString(column:="COURSE_NAME")
            Reader.Dispose()
            Query = $"SELECT * FROM universities WHERE UNIVERSITY_ID='{UniversityID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim University As String = Reader.GetString(column:="UNIVERSITY_NAME")
            Con.Close()
            LabelCourse.Text = Course & " (" & University & ")"
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

    Private Sub FillColleges()
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT COLLEGE_NAME FROM collegewise_courses, colleges WHERE
collegewise_courses.COLLEGE_ID=colleges.COLLEGE_ID AND collegewise_courses.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}';"
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

    Private Sub ComboBoxCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCollege.SelectedIndexChanged
        ComboBoxRoll.Items.Clear()   ' To clear the combobox
        CountStudent = 0
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
            Query = $"SELECT * FROM collegewise_courses WHERE COLLEGE_ID = '{CollegeID}' AND UNIVERSITYWISE_COURSE_ID = '{UniversitywiseCourseID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim CollegewiseCourseID As String = Reader.GetString(column:="COLLEGEWISE_COURSE_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM students WHERE COLLEGE_ID = '{CollegeID}' AND COLLEGEWISE_COURSE_ID = '{CollegewiseCourseID}';"
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
        If CountStudent <> 0 And ComboBoxRoll.SelectedItem <> Nothing Then
            ButtonGenerateMarksheet.Enabled = True
        Else
            ButtonGenerateMarksheet.Enabled = False
        End If
    End Sub
    Private Sub ButtonGenerateMarksheet_Click(sender As Object, e As EventArgs) Handles ButtonGenerateMarksheet.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Dim Flag As Integer
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT COUNT(marksheets.UNIVERSITY_ROLL_NUMBER) FROM students,
    colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND
subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}' AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND
students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND
sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND marksheets.UNIVERSITY_ROLL_NUMBER='{ComboBoxRoll.SelectedItem}' AND universities.UNIVERSITY_ID=
result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID=result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND
courses.COURSE_ID=marksheets.COURSE_ID AND marksheets.STATUS='1';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Flag = Reader.GetInt16(column:="COUNT(marksheets.UNIVERSITY_ROLL_NUMBER)")
            Reader.Dispose()
            If Flag <> 0 Then
                Query = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME)), UPPER(SUBJECT_NAME), INTERNAL_MARKS, EXTERNAL_MARKS,
TOTAL, SEMESTER, SESSION_ID, UPPER(COLLEGE_NAME), MAXIMUM_INTERNAL_MARKS, MAXIMUM_EXTERNAL_MARKS, PASSING_MARKS, PASSING_MARKS_THEORY, UPPER(COURSE_NAME) FROM
students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID And
subjects.SUBJECT_ID = marksheets.SUBJECT_ID And marksheets.SESSIONWISE_SEMESTER_ID ='{SessionwiseSemesterID}' AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND
students.UNIVERSITY_ROLL_NUMBER = marksheets.UNIVERSITY_ROLL_NUMBER And sessionwise_semesters.SESSIONWISE_SEMESTER_ID = marksheets.SESSIONWISE_SEMESTER_ID And
sessionwise_semesters.SEMESTER_ID = semesters.SEMESTER_ID And marksheets.UNIVERSITY_ROLL_NUMBER ='{ComboBoxRoll.SelectedItem}' AND universities.UNIVERSITY_ID=
result_criteria.UNIVERSITY_ID And marksheets.SESSIONWISE_SEMESTER_ID = result_criteria.SESSIONWISE_SEMESTER_ID And result_criteria.COURSE_ID = marksheets.COURSE_ID And
courses.COURSE_ID = marksheets.COURSE_ID AND marksheets.STATUS='1' ORDER BY SUBJECT_NAME;"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                CollegeName = Reader.GetString(column:="UPPER(COLLEGE_NAME)")
                CourseName = Reader.GetString(column:="UPPER(COURSE_NAME)")
                StudentName = Reader.GetString(column:="UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME))")
                Session = Reader.GetString(column:="SESSION_ID")
                Semester = Reader.GetString(column:="SEMESTER")
                Reader.Dispose()
                Query = $"SELECT MARKSHEET_ID FROM studentwise_marksheets WHERE UNIVERSITY_ROLL_NUMBER={ComboBoxRoll.SelectedItem} AND
SESSIONWISE_SEMESTER_ID={SessionwiseSemesterID};"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Serial = Reader.GetString(column:="MARKSHEET_ID")
                Reader.Dispose()
                Query = $"SELECT SUM((EXTERNAL_MARKS+INTERNAL_MARKS)) FROM students,
    colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND
subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}' AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND
students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND
sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND marksheets.UNIVERSITY_ROLL_NUMBER='{ComboBoxRoll.SelectedItem}' AND universities.UNIVERSITY_ID=
result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID=result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND
courses.COURSE_ID=marksheets.COURSE_ID AND marksheets.STATUS='1' GROUP BY marksheets.UNIVERSITY_ROLL_NUMBER;"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Total = Reader.GetString(column:="SUM((EXTERNAL_MARKS+INTERNAL_MARKS))")
                Reader.Dispose()
                Query = $"SELECT UPPER(UNIVERSITY_NAME) FROM universities WHERE UNIVERSITY_ID={UniversityID};"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                University = Reader.GetString(column:="UPPER(UNIVERSITY_NAME)")
                Reader.Dispose()
                Query = $"SELECT PASSING_MARKS, PASSING_MARKS_THEORY FROM result_criteria WHERE UNIVERSITY_ID={UniversityID} AND 
SESSIONWISE_SEMESTER_ID={SessionwiseSemesterID} AND COURSE_ID={CourseID};"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Passing = Reader.GetString(column:="PASSING_MARKS")
                PassingTheory = Reader.GetString(column:="PASSING_MARKS_THEORY")
                Reader.Dispose()
                Query = $"SELECT COUNT(marksheets.UNIVERSITY_ROLL_NUMBER) FROM students,
    colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND
subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}' AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND
students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND
sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND marksheets.UNIVERSITY_ROLL_NUMBER='{ComboBoxRoll.SelectedItem}' AND universities.UNIVERSITY_ID=
result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID=result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND
courses.COURSE_ID=marksheets.COURSE_ID AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status WHERE RESULT_STATUS='Back') AND marksheets.STATUS='1';"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Dim Signal As Integer = Reader.GetInt16("COUNT(marksheets.UNIVERSITY_ROLL_NUMBER)")
                Reader.Dispose()
                Con.Close()
                If Signal = 0 Then
                    Result = "PASS"
                Else
                    Result = "BACK"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Con.Dispose()
        End Try
        If Flag = 0 Then
            MessageBox.Show(text:="No marks information available for the selected student. Please add marks information.", caption:="No information alert",
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

            cmd.CommandText = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME)), UPPER(SUBJECT_NAME), INTERNAL_MARKS, EXTERNAL_MARKS,
TOTAL, SEMESTER, SESSION_ID, UPPER(COLLEGE_NAME), MAXIMUM_INTERNAL_MARKS, MAXIMUM_EXTERNAL_MARKS, (MAXIMUM_INTERNAL_MARKS + MAXIMUM_EXTERNAL_MARKS) AS 'MAXIMUM MARKS',
PASSING_MARKS, PASSING_MARKS_THEORY, UPPER(COURSE_NAME) FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria,
courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}'
AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
marksheets.UNIVERSITY_ROLL_NUMBER='{ComboBoxRoll.SelectedItem}' AND universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID
=result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID AND marksheets.STATUS='1'
ORDER BY SUBJECT_NAME;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myReport.Load("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\CrystalReportMarksheet.rpt")
            myReport.SetDataSource(myData)

            myReport.SetParameterValue(name:="college", val:=$"{CollegeName}")
            myReport.SetParameterValue(name:="course", val:=$"{CourseName}")
            myReport.SetParameterValue(name:="header", val:=$"STATEMENT OF MARKS")
            myReport.SetParameterValue(name:="serial", val:=$"{Serial}")
            myReport.SetParameterValue(name:="name", val:=$"{StudentName}")
            myReport.SetParameterValue(name:="roll", val:=$"{ComboBoxRoll.SelectedItem}")
            myReport.SetParameterValue(name:="total", val:=$"{Total}")
            myReport.SetParameterValue(name:="university", val:=$"{University}")
            myReport.SetParameterValue(name:="passing", val:=$"{Passing}")
            myReport.SetParameterValue(name:="theory", val:=$"{PassingTheory}")
            myReport.SetParameterValue(name:="session", val:=$"{Session} ({Semester}-SEMESTER)")
            myReport.SetParameterValue(name:="result", val:=$"{Result}")

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
            cmd.CommandText = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME)), UPPER(SUBJECT_NAME), INTERNAL_MARKS, EXTERNAL_MARKS,
TOTAL, SEMESTER, SESSION_ID, UPPER(COLLEGE_NAME), MAXIMUM_INTERNAL_MARKS, MAXIMUM_EXTERNAL_MARKS, (MAXIMUM_INTERNAL_MARKS + MAXIMUM_EXTERNAL_MARKS) AS 'MAXIMUM MARKS',
PASSING_MARKS, PASSING_MARKS_THEORY, UPPER(COURSE_NAME) FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria,
courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}'
AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
marksheets.UNIVERSITY_ROLL_NUMBER='{ComboBoxRoll.SelectedItem}' AND universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID
=result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID AND marksheets.STATUS='1'
ORDER BY SUBJECT_NAME;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myData.WriteXml("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\datasetMarksheet.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message, caption:="Report could not be created.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBoxRoll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoll.SelectedIndexChanged
        If CountCollege <> 0 And ComboBoxCollege.SelectedItem <> Nothing Then
            ButtonGenerateMarksheet.Enabled = True
        Else
            ButtonGenerateMarksheet.Enabled = False
        End If
    End Sub
End Class