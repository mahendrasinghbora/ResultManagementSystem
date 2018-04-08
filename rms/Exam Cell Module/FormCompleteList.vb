Imports MySql.Data.MySqlClient

Public Class FormCompleteList
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim file As IO.StreamWriter
    Dim CountSession As Integer = 0
    Dim CountSemester As Integer = 0
    Dim CountCourse As Integer = 0
    Dim CountCollege As Integer = 0
    Dim Result As String
    Dim Marks As Integer

    Private Sub FormCompleteList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Collegewise statement of marks")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelPrintMarksheets.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelReportLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelReport.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonGenerateReport.Enabled = False
        WebBrowser1.Visible = False
        PanelBrowser.Visible = False
        ButtonPrintReport.Visible = False
        FillSessions()   ' To fill combobox with sessions
        FillSemesters()   ' To fill combobox with semesters
        FillColleges()   ' To fill combobox with colleges
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
                ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If CountCollege <> 0 And CountCourse <> 0 And CountSemester <> 0 And ComboBoxCollege.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
              ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemester.SelectedIndexChanged
        If CountCollege <> 0 And CountCourse <> 0 And CountSession <> 0 And ComboBoxCollege.SelectedItem <> Nothing And ComboBoxCourse.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse.SelectedIndexChanged
        If CountCollege <> 0 And CountSession <> 0 And ComboBoxCollege.SelectedItem <> Nothing And
             ComboBoxSession.SelectedItem <> Nothing And CountSemester <> 0 And ComboBoxSemester.SelectedItem <> Nothing Then
            ButtonGenerateReport.Enabled = True
        Else
            ButtonGenerateReport.Enabled = False
        End If
    End Sub

    Private Sub WriteNewDocument()
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\Marksheets.html", False)
        file.WriteLine($"
        <!doctype html>
        <html lang='en'>

        <head>
            <!-- Required meta tags -->
            <meta charset='utf-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
            <meta http-equiv='X-UA-Compatible' content='IE=edge' />
            <!-- Bootstrap CSS -->
            <link rel='stylesheet' href='C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\bootstrap.css'>

            <title>Collegewise-Marksheets</title>
        </head>

        <body>
            <blockquote class='blockquote text-center'>
                <p class='mb-0'><strong>{ComboBoxCollege.SelectedItem}</strong></p>
                <p class='mb-0'>{ComboBoxCourse.SelectedItem}</p>
                <p class='mb-0'>{ComboBoxSession.SelectedItem} ({ComboBoxSemester.SelectedItem}-Semester)</p>
        ")
        Con = New MySqlConnection With {
                    .ConnectionString = "server=localhost;userid=root;database=rms"
                }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME)), UPPER(SUBJECT_NAME), INTERNAL_MARKS, EXTERNAL_MARKS,
TOTAL, SEMESTER, SESSION_ID, UPPER(COLLEGE_NAME), MAXIMUM_INTERNAL_MARKS, MAXIMUM_EXTERNAL_MARKS, PASSING_MARKS, PASSING_MARKS_THEORY, UPPER(COURSE_NAME) FROM
students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID And
subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID =(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID
=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID='{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID
=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER = marksheets.UNIVERSITY_ROLL_NUMBER AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=
marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID = semesters.SEMESTER_ID AND universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND
marksheets.SESSIONWISE_SEMESTER_ID = result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID = marksheets.COURSE_ID AND courses.COURSE_ID=
marksheets.COURSE_ID AND COURSE_NAME='{ComboBoxCourse.SelectedItem}' AND COLLEGE_NAME='{ComboBoxCollege.SelectedItem}' ORDER BY marksheets.UNIVERSITY_ROLL_NUMBER,
SUBJECT_NAME;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim External As Integer = Reader.GetInt16(column:="MAXIMUM_EXTERNAL_MARKS")
            Dim Internal As Integer = Reader.GetInt16(column:="MAXIMUM_INTERNAL_MARKS")
            Dim PassingMarks As Integer = Reader.GetInt16(column:="PASSING_MARKS")
            Dim PassingMarksTheory As Integer = Reader.GetInt16(column:="PASSING_MARKS_THEORY")
            file.WriteLine($"
                <p class='mb-0'>Maximum External Marks: <strong>{External}</strong> | Maximum Internal Marks: <strong>{Internal}</strong>
| Passing Marks: <strong>{PassingMarks}</strong> | Passing Marks Theory: <strong>{PassingMarksTheory}</strong></p>
                <p class='mb-5'>{DateTime.Today.ToString("d")}</p>
            </blockquote>
            <div class='container-fluid mt-5'>
            ")
            Reader.Dispose()
            Query = $"SELECT COUNT(DISTINCT marksheets.UNIVERSITY_ROLL_NUMBER) FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters,
result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID=
(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND
SESSION_ID='{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER
AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID = result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=
marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID AND COURSE_NAME='{ComboBoxCourse.SelectedItem}' AND COLLEGE_NAME='{ComboBoxCollege.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim Len As Integer = Reader.GetInt16(column:="COUNT(DISTINCT marksheets.UNIVERSITY_ROLL_NUMBER)")
            Reader.Dispose()
            Dim RollNumbers(Len - 1) As Integer
            Dim Flag As Integer = 0
            Query = $"SELECT DISTINCT marksheets.UNIVERSITY_ROLL_NUMBER FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters,
result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID=
(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND
SESSION_ID='{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER
AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID = result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=
marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID AND COURSE_NAME='{ComboBoxCourse.SelectedItem}' AND COLLEGE_NAME='{ComboBoxCollege.SelectedItem}'
ORDER BY marksheets.UNIVERSITY_ROLL_NUMBER;"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            While Reader.Read()
                RollNumbers(Flag) = Reader.GetInt64(column:="UNIVERSITY_ROLL_NUMBER")
                Flag = Flag + 1
            End While
            Reader.Dispose()
            For Each Roll As Integer In RollNumbers
                Query = $"SELECT UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME)) FROM students WHERE UNIVERSITY_ROLL_NUMBER='{Roll}'"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Dim StudentName As String = Reader.GetString(column:="UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME))")
                Reader.Dispose()
                file.WriteLine($"
                <div class='row'>
                    <div class='col-sm-1'></div>
                    <div class='col-sm-10'>
                        ROLL NUMBER:
                        <strong>{Roll}</strong>
                    </div>
                    <div class='col-sm-1'></div>
                </div>
                <div class='row'>
                    <div class='col-sm-1'></div>
                    <div class='col-sm-10'>
                        <div class='row'>
                            <div class='col'>
                                NAME OF THE STUDENT:
                                <strong>{StudentName}</strong>
                            </div>
                    </div>
                    <table class='table table-bordered border-dark mb-5 mt-3'>
                    <thead class='thead-dark'>
                        <tr>
                            <th scope='col'>SUBJECTS/PAPERS</th>
                            <th scope='col text-center'>EXT. MARKS</th>
                            <th scope='col text-center'>INT. MARKS</th>
                            <th scope='col text-center'>TOTAL</th>
                            <th scope='col text-center'>RESULT</th>
                        </tr>
                    </thead>
                    <tbody>
                ")
                Query = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, UPPER(CONCAT(FIRST_NAME, ' ', LAST_NAME)), UPPER(SUBJECT_NAME), INTERNAL_MARKS, EXTERNAL_MARKS,
TOTAL, SEMESTER, SESSION_ID, UPPER(COLLEGE_NAME), MAXIMUM_INTERNAL_MARKS, MAXIMUM_EXTERNAL_MARKS, PASSING_MARKS, PASSING_MARKS_THEORY, UPPER(COURSE_NAME),
UPPER(RESULT_STATUS) FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses, result_status
WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID =(SELECT SESSIONWISE_SEMESTER_ID
FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID=
'{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID = result_criteria.SESSIONWISE_SEMESTER_ID AND
result_criteria.COURSE_ID=marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID AND COURSE_NAME='{ComboBoxCourse.SelectedItem}' AND
COLLEGE_NAME='{ComboBoxCollege.SelectedItem}' AND marksheets.RESULT_STATUS_ID=result_status.RESULT_STATUS_ID AND marksheets.UNIVERSITY_ROLL_NUMBER=
'{Roll}' ORDER BY marksheets.UNIVERSITY_ROLL_NUMBER, SUBJECT_NAME;"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                While Reader.Read()
                    Dim SubjectName As String = Reader.GetString(column:="UPPER(SUBJECT_NAME)")
                    Dim InternalMarks As Integer = Reader.GetInt16(column:="INTERNAL_MARKS")
                    Dim ExternalMarks As Integer = Reader.GetInt16(column:="EXTERNAL_MARKS")
                    Dim TotalMarks As Integer = Reader.GetInt16(column:="TOTAL")
                    Dim ResultStatus As String = Reader.GetString(column:="UPPER(RESULT_STATUS)")
                    file.WriteLine($"
                     <tr>
                        <th scope ='row'>{SubjectName}</th>
                        <td>{ExternalMarks}</td>
                        <td>{InternalMarks}</td>
                        <td>{TotalMarks}</td>
                        <td>{ResultStatus}</td>
                    </tr>
                    ")
                End While
                Reader.Dispose()
                Query = $"SELECT COUNT(marksheets.UNIVERSITY_ROLL_NUMBER) FROM students,
                    colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND
                subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID
FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID=
'{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND
                students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND
                sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND marksheets.UNIVERSITY_ROLL_NUMBER='{Roll}' AND universities.UNIVERSITY_ID=
                result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID=result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND
                courses.COURSE_ID=marksheets.COURSE_ID AND RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status WHERE RESULT_STATUS='Back');"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Dim Signal As Integer = Reader.GetInt16(column:="COUNT(marksheets.UNIVERSITY_ROLL_NUMBER)")
                If Signal = 0 Then
                    Result = "PASS"
                Else
                    Result = "BACK"
                End If
                Reader.Dispose()
                Query = $"SELECT SUM(TOTAL) FROM students,
                    colleges, universities, subjects, marksheets, semesters, sessionwise_semesters, result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND
                subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID
FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND SESSION_ID=
'{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
marksheets.UNIVERSITY_ROLL_NUMBER='{Roll}' AND universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID=
result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID;"
                Command = New MySqlCommand(Query, Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                Marks = Reader.GetInt16(column:="SUM(TOTAL)")
                Reader.Dispose()
                file.WriteLine($"
                                    <tr>
                                        <td></td>
                                        <th scope='row'>RESULT</th>
                                        <td>{Result}</td>
                                        <th scope='row'>TOTAL</th>
                                        <td>{Marks}</td>
                                    </tr>
                                </tbody>
                            </table>
                            <hr class='my-5'>
                        </div>
                        <div class='col-sm-1'></div>
                    </div>
                ")
            Next
            file.WriteLine("
                    <script src=''></script>
                </body>

            </html>
            ")
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        file.Close()
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
            Query = $"SELECT COUNT(DISTINCT marksheets.UNIVERSITY_ROLL_NUMBER) FROM students, colleges, universities, subjects, marksheets, semesters, sessionwise_semesters,
result_criteria, courses WHERE colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID = marksheets.SUBJECT_ID AND marksheets.SESSIONWISE_SEMESTER_ID=
(SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{ComboBoxSemester.SelectedItem}') AND
SESSION_ID='{ComboBoxSession.SelectedItem}') AND universities.UNIVERSITY_ID=colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER=marksheets.UNIVERSITY_ROLL_NUMBER
AND sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND sessionwise_semesters.SEMESTER_ID=semesters.SEMESTER_ID AND
universities.UNIVERSITY_ID=result_criteria.UNIVERSITY_ID AND marksheets.SESSIONWISE_SEMESTER_ID = result_criteria.SESSIONWISE_SEMESTER_ID AND result_criteria.COURSE_ID=
marksheets.COURSE_ID AND courses.COURSE_ID=marksheets.COURSE_ID AND COURSE_NAME='{ComboBoxCourse.SelectedItem}' AND COLLEGE_NAME='{ComboBoxCollege.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Flag = Reader.GetInt16(column:="COUNT(DISTINCT marksheets.UNIVERSITY_ROLL_NUMBER)")
            Reader.Dispose()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
        If Flag = 0 Then
            PanelBrowser.Visible = False
            WebBrowser1.Visible = False
            ButtonPrintReport.Visible = False
            MessageBox.Show(text:="No marks information available for selected course in the selected session and semester.", caption:="No information alert",
                            buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Else
            PanelBrowser.Visible = True
            WebBrowser1.Visible = True
            ButtonPrintReport.Visible = True
            WriteNewDocument()
            WebBrowser1.Navigate("C:\Users\Mahendra Singh Bora\Documents\VBprojects\rms\rms\Reports\Marksheets.html")
        End If
    End Sub

    Private Sub ButtonPrintReport_Click(sender As Object, e As EventArgs) Handles ButtonPrintReport.Click
        WebBrowser1.Print()
    End Sub
End Class