Imports MySql.Data.MySqlClient

Public Class FormAddBackInformation
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim MaximumMarks As Integer
    Dim CountSubject As Integer = 0
    Dim PassingMarks As Integer = 0
    Dim PassingMarksTheory As Integer = 0
    Dim MarksInternal As Integer

    Private Sub FormAddBackInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Studentwise Back Report")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelBackPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelBackLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelBack.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddBackInformation.Enabled = False
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripUsers.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfileExamCell(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        ExamCellDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextRollNumber_TextChanged(sender As Object, e As EventArgs) Handles TextRollNumber.TextChanged
        If TextRollNumber.Text = "" Then
            ErrorProviderBackInformation.SetError(control:=TextRollNumber, value:="University Roll Number can't be empty.")
            ButtonAddBackInformation.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(TextRollNumber.Text, "^(\d)+$") Then
                ErrorProviderBackInformation.SetError(control:=TextRollNumber, value:="University Roll Number can only contain digits.")
                ButtonAddBackInformation.Enabled = False
            Else
                ErrorProviderBackInformation.Dispose()
            End If
        End If
    End Sub

    Private Sub TextNewMarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNewMarks.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextNewMarks.Text.Insert(TextNewMarks.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextRollNumber_Leave(sender As Object, e As EventArgs) Handles TextRollNumber.Leave
        ComboBoxSubject.Items.Clear()
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT marksheets.UNIVERSITY_ROLL_NUMBER, CONCAT(FIRST_NAME, ' ', LAST_NAME), SUBJECT_NAME, SESSION_ID, SEMESTER FROM students,
colleges, universities, subjects, marksheets, semesters, sessionwise_semesters WHERE marksheets.RESULT_STATUS_ID=(SELECT RESULT_STATUS_ID FROM result_status 
WHERE RESULT_STATUS='Back') AND colleges.COLLEGE_ID=students.COLLEGE_ID AND subjects.SUBJECT_ID=marksheets.SUBJECT_ID AND marksheets.UNIVERSITY_ROLL_NUMBER=
'{TextRollNumber.Text}' AND universities.UNIVERSITY_ID = colleges.UNIVERSITY_ID AND students.UNIVERSITY_ROLL_NUMBER = marksheets.UNIVERSITY_ROLL_NUMBER AND
sessionwise_semesters.SESSIONWISE_SEMESTER_ID=marksheets.SESSIONWISE_SEMESTER_ID AND semesters.SEMESTER_ID=sessionwise_semesters.SEMESTER_ID AND marksheets.STATUS='1'
ORDER BY SESSION_ID, SEMESTER, SUBJECT_NAME, students.UNIVERSITY_ROLL_NUMBER;"
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

    Private Sub TextRollNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextRollNumber.Validating
        If TextRollNumber.Text = "" Then
            ErrorProviderBackInformation.SetError(control:=TextRollNumber, value:="University Roll Number can't be empty.")
            TextRollNumber.Focus()
        End If
    End Sub

    Private Sub ComboBoxSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSubject.SelectedIndexChanged
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT SESSION_ID, SEMESTER_ID FROM sessionwise_semesters WHERE SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM marksheets
WHERE SUBJECT_ID=(SELECT SUBJECT_ID FROM subjects WHERE SUBJECT_NAME='{ComboBoxSubject.SelectedItem}') AND UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextSession.Text = Reader.GetString(column:="SESSION_ID")
            Dim SemesterID As String = Reader.GetString(column:="SEMESTER_ID")
            Reader.Dispose()
            Query = $"SELECT SEMESTER FROM semesters WHERE SEMESTER_ID='{SemesterID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TextSemester.Text = Reader.GetString(column:="SEMESTER")
            Reader.Dispose()
            Query = $"SELECT * FROM result_criteria WHERE UNIVERSITY_ID = (SELECT UNIVERSITY_ID FROM colleges WHERE COLLEGE_ID=
(SELECT COLLEGE_ID FROM students WHERE UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}')) AND COURSE_ID = (SELECT DISTINCT COURSE_ID
FROM marksheets WHERE UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}') AND SESSIONWISE_SEMESTER_ID=(SELECT SESSIONWISE_SEMESTER_ID FROM marksheets
WHERE SUBJECT_ID=(SELECT SUBJECT_ID FROM subjects WHERE SUBJECT_NAME='{ComboBoxSubject.SelectedItem}') AND UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            MaximumMarks = Reader.GetInt16(column:="MAXIMUM_EXTERNAL_MARKS")
            PassingMarks = Reader.GetInt16("PASSING_MARKS")
            PassingMarksTheory = Reader.GetInt16("PASSING_MARKS_THEORY")
            Reader.Dispose()
            Query = $"SELECT INTERNAL_MARKS FROM marksheets WHERE UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}' AND SUBJECT_ID=(SELECT SUBJECT_ID FROM subjects
WHERE SUBJECT_NAME='{ComboBoxSubject.SelectedItem}') AND STATUS='1';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            MarksInternal = Reader.GetInt16(column:="INTERNAL_MARKS")
            Reader.Dispose()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:="No result criteria set for the selected course for the current session and semester. Please, set a criteria.",
                            caption:="No Result Criteria alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
            ButtonAddBackInformation.Enabled = False
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub TextNewMarks_TextChanged(sender As Object, e As EventArgs) Handles TextNewMarks.TextChanged
        If TextNewMarks.Text <> "" And CountSubject <> 0 And TextSession.Text <> "" And TextSemester.Text <> "" And ComboBoxSubject.SelectedItem IsNot Nothing Then
            ButtonAddBackInformation.Enabled = True
        Else
            ButtonAddBackInformation.Enabled = False
        End If
    End Sub

    Private Sub ButtonAddBackInformation_Click(sender As Object, e As EventArgs) Handles ButtonAddBackInformation.Click
        Dim Result As String
        If TextNewMarks.Text >= PassingMarksTheory And (TextNewMarks.Text + MarksInternal) >= PassingMarks Then
            Result = "Pass"
        Else
            Result = "Back"
        End If
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"UPDATE marksheets SET STATUS='0' WHERE UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}' AND SESSIONWISE_SEMESTER_ID=
            (SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID=(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{TextSemester.Text}')
            AND SESSION_ID='{TextSession.Text}') AND SUBJECT_ID=(SELECT SUBJECT_ID FROM subjects WHERE SUBJECT_NAME='{ComboBoxSubject.SelectedItem}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Dispose()
            Query = $"SELECT DISTINCT COURSE_ID FROM marksheets WHERE UNIVERSITY_ROLL_NUMBER='{TextRollNumber.Text}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            CourseID = Reader.GetString(column:="COURSE_ID")
            Reader.Dispose()
            Query = $"INSERT INTO marksheets (`UNIVERSITY_ROLL_NUMBER`, `SUBJECT_ID`, `COURSE_ID`, `SESSIONWISE_SEMESTER_ID`,
            `INTERNAL_MARKS`, `EXTERNAL_MARKS`, `TOTAL`, `RESULT_STATUS_ID`, `USERNAME`) VALUES('{TextRollNumber.Text}', (SELECT SUBJECT_ID FROM subjects
            WHERE SUBJECT_NAME='{ComboBoxSubject.SelectedItem}'), '{CourseID}', (SELECT SESSIONWISE_SEMESTER_ID FROM sessionwise_semesters WHERE SEMESTER_ID
            =(SELECT SEMESTER_ID FROM semesters WHERE SEMESTER='{TextSemester.Text}') AND SESSION_ID='{TextSession.Text}'), '{MarksInternal}', '{TextNewMarks.Text}',
            '{MarksInternal + TextNewMarks.Text}', (SELECT RESULT_STATUS_ID FROM result_status WHERE RESULT_STATUS='{Result}'), '{Username}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Reader.Dispose()
            Dim NewFormAddBackInformation As FormAddBackInformation
            NewFormAddBackInformation = New FormAddBackInformation()
            NewFormAddBackInformation.Show()
            Dispose()
            MessageBox.Show(text:="Information successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class