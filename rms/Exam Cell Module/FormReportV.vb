Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class FormReportV
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim StudentCollege As String
    Dim StudentCourse As String
    Dim StudentName As String

    Private Sub FormReportV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Studentwise Back Report")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelPrintMarksheets.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelReportLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelReport.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonGenerateReport.Enabled = False
        CrystalReportViewer1.Visible = False
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

    Private Sub TextRollNumber_TextChanged(sender As Object, e As EventArgs) Handles TextRollNumber.TextChanged
        If TextRollNumber.Text = "" Then
            ErrorProviderReportV.SetError(control:=TextRollNumber, value:="University Roll Number can't be empty.")
            ButtonGenerateReport.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(TextRollNumber.Text, "^(\d)+$") Then
                ErrorProviderReportV.SetError(control:=TextRollNumber, value:="University Roll Number can only contain digits.")
                ButtonGenerateReport.Enabled = False
            Else
                ErrorProviderReportV.Dispose()
                ButtonGenerateReport.Enabled = True
            End If
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
            Query = $"SELECT COUNT(marksheets.UNIVERSITY_ROLL_NUMBER) FROM students,
colleges, universities, subjects, marksheets, semesters, sessionwise_semesters WHERE marksheets.RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status 
WHERE RESULT_STATUS='Back') AND colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.UNIVERSITY_ROLL_NUMBER=
'{TextRollNumber.Text}' AND universities.UNIVERSITY_ID = colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER = marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND semesters.SEMESTER_ID=sessionwise_semesters.SEMESTER_ID AND marksheets.STATUS='1';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Flag = Reader.GetInt16(column:="COUNT(marksheets.UNIVERSITY_ROLL_NUMBER)")
            Reader.Dispose()
            If Flag <> 0 Then
                Query = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, CONCAT(FIRST_NAME, ' ', LAST_NAME), SUBJECT_NAME, SESSION_ID, SEMESTER, COLLEGE_NAME, COURSE_NAME
FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, courses WHERE marksheets.RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID
FROM result_status WHERE RESULT_STATUS='Back') AND colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND
marksheets.UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}' AND universities.UNIVERSITY_ID = colleges.UNIVERSITY_ID AND
students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND
semesters.SEMESTER_ID=sessionwise_semesters.SEMESTER_ID AND courses.COURSE_ID=marksheets.COURSE_ID  AND marksheets.STATUS='1' ORDER BY SESSION_ID, SEMESTER,
SUBJECT_NAME, students.UNIVERSITY_ROLL_NUMBER;"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                StudentCollege = Reader.GetString(column:="COLLEGE_NAME")
                StudentCourse = Reader.GetString(column:="COURSE_NAME")
                StudentName = Reader.GetString(column:="CONCAT(FIRST_NAME, ' ', LAST_NAME)")
                Reader.Dispose()
            End If
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        If Flag = 0 Then
            MessageBox.Show(text:="The selected student has no back-log.", caption:="No back-log alert",
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

            cmd.CommandText = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, CONCAT(FIRST_NAME, ' ', LAST_NAME), SUBJECT_NAME, SESSION_ID, SEMESTER FROM students,
colleges, universities, subjects, marksheets, semesters, sessionwise_semesters WHERE marksheets.RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status 
WHERE RESULT_STATUS='Back') AND colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.UNIVERSITY_ROLL_NUMBER=
'{TextRollNumber.Text}' AND universities.UNIVERSITY_ID = colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER = marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND semesters.SEMESTER_ID=sessionwise_semesters.SEMESTER_ID AND marksheets.STATUS='1'
ORDER BY SESSION_ID, SEMESTER, SUBJECT_NAME, students.UNIVERSITY_ROLL_NUMBER;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myReport.Load("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\CrystalReport5.rpt")
            myReport.SetDataSource(myData)

            myReport.SetParameterValue(name:="college", val:=$"{StudentCollege}")
            myReport.SetParameterValue(name:="course", val:=$"{StudentCourse}")
            myReport.SetParameterValue(name:="date", val:=$"({DateTime.Today.ToString("d")})")
            myReport.SetParameterValue(name:="header", val:=$"Complete back-log of {StudentName} ({TextRollNumber.Text})")

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
            cmd.CommandText = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, CONCAT(FIRST_NAME, ' ', LAST_NAME), SUBJECT_NAME, SESSION_ID, SEMESTER FROM students,
colleges, universities, subjects, marksheets, semesters, sessionwise_semesters WHERE marksheets.RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status 
WHERE RESULT_STATUS='Back') AND colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.UNIVERSITY_ROLL_NUMBER=
'{TextRollNumber.Text}' AND universities.UNIVERSITY_ID = colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER = marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND semesters.SEMESTER_ID=sessionwise_semesters.SEMESTER_ID AND marksheets.STATUS='1'
ORDER BY SESSION_ID, SEMESTER, SUBJECT_NAME, students.UNIVERSITY_ROLL_NUMBER;"
            cmd.Connection = conn

            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)

            myData.WriteXml("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\dataset5.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message, caption:="Report could not be created.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub
End Class