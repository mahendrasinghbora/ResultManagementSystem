Imports MySql.Data.MySqlClient

Public Class FormAddMarksII
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountCollege As Integer = 0
    Dim CountStudent As Integer = 0
    Dim MaximumInternalMarks As Integer
    Dim MaximumExternalMarks As Integer
    Dim PassingMarks As Integer
    Dim PassingMarksTheory As Integer
    Dim TotalSubjects As Integer

    Private Sub FormAddMarksII_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Marks Information")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddMarksPanel.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddMarksLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelAddMarks.ForeColor = Color.FromArgb(255, 255, 255)
        LabelCourse.ForeColor = Color.FromArgb(255, 255, 255)
        FillColleges()   ' To fill combobox with colleges
        FillData()   ' To fill session and semester
        SetMaximum()   ' To set maximum length of textboxes
        FillSubjects()   ' To fill subjects
        GetResultCriteria()   ' To get result criteria
    End Sub

    Private Sub GetResultCriteria()
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM result_criteria WHERE UNIVERSITYWISE_COURSE_ID = '{UniversitywiseCourseID}' 
AND SESSIONWISE_SEMESTER_ID = '{SessionwiseSemesterID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            MaximumInternalMarks = Reader.GetInt16(column:="MAXIMUM_INTERNAL_MARKS")
            MaximumExternalMarks = Reader.GetInt16(column:="MAXIMUM_EXTERNAL_MARKS")
            PassingMarks = Reader.GetInt16("PASSING_MARKS")
            PassingMarksTheory = Reader.GetInt16("PASSING_MARKS_THEORY")
            Con.Close()
            Reader.Dispose()
            TextInternal1.Text = MaximumInternalMarks
            TextInternal2.Text = MaximumInternalMarks
            TextInternal3.Text = MaximumInternalMarks
            TextInternal4.Text = MaximumInternalMarks
            TextInternal5.Text = MaximumInternalMarks
            TextInternal6.Text = MaximumInternalMarks
            TextInternal7.Text = MaximumInternalMarks
            TextInternal8.Text = MaximumInternalMarks
            TextInternal9.Text = MaximumInternalMarks
            TextInternal10.Text = MaximumInternalMarks
            TextExternal1.Text = MaximumExternalMarks
            TextExternal2.Text = MaximumExternalMarks
            TextExternal3.Text = MaximumExternalMarks
            TextExternal4.Text = MaximumExternalMarks
            TextExternal5.Text = MaximumExternalMarks
            TextExternal6.Text = MaximumExternalMarks
            TextExternal7.Text = MaximumExternalMarks
            TextExternal8.Text = MaximumExternalMarks
            TextExternal9.Text = MaximumExternalMarks
            TextExternal10.Text = MaximumExternalMarks
        Catch ex As Exception
            MessageBox.Show(text:="No result criteria set for the current session and semester. Please, set a criteria.",
                            caption:="No Result Criteria alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
            ButtonAddMarks.Enabled = False
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
            Query = $"SELECT COUNT(SUBJECT_NAME) FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            TotalSubjects = Reader.GetString(column:="COUNT(SUBJECT_NAME)")
            Reader.Dispose()
            If TotalSubjects = 1 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
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
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject3.Visible = False
                LabelSubject4.Visible = False
                LabelSubject5.Visible = False
                LabelSubject6.Visible = False
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal3.Visible = False
                TextInternal4.Visible = False
                TextInternal5.Visible = False
                TextInternal6.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal3.Visible = False
                TextExternal4.Visible = False
                TextExternal5.Visible = False
                TextExternal6.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal3.Visible = False
                TextMarksInternal4.Visible = False
                TextMarksInternal5.Visible = False
                TextMarksInternal6.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal3.Visible = False
                TextMarksExternal4.Visible = False
                TextMarksExternal5.Visible = False
                TextMarksExternal6.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks3.Visible = False
                TextTotalMarks4.Visible = False
                TextTotalMarks5.Visible = False
                TextTotalMarks6.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult3.Visible = False
                TextResult4.Visible = False
                TextResult5.Visible = False
                TextResult6.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 3 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject4.Visible = False
                LabelSubject5.Visible = False
                LabelSubject6.Visible = False
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal4.Visible = False
                TextInternal5.Visible = False
                TextInternal6.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal4.Visible = False
                TextExternal5.Visible = False
                TextExternal6.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal4.Visible = False
                TextMarksInternal5.Visible = False
                TextMarksInternal6.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal4.Visible = False
                TextMarksExternal5.Visible = False
                TextMarksExternal6.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks4.Visible = False
                TextTotalMarks5.Visible = False
                TextTotalMarks6.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult4.Visible = False
                TextResult5.Visible = False
                TextResult6.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 4 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject5.Visible = False
                LabelSubject6.Visible = False
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal5.Visible = False
                TextInternal6.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal5.Visible = False
                TextExternal6.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal5.Visible = False
                TextMarksInternal6.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal5.Visible = False
                TextMarksExternal6.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks5.Visible = False
                TextTotalMarks6.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult5.Visible = False
                TextResult6.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 5 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject5.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject6.Visible = False
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal6.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal6.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal6.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal6.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks6.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult6.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 6 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject5.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject6.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 7 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject5.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject6.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject7.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 8 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject5.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject6.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject7.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject8.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 9 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject5.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject6.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject7.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject8.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject9.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
                LabelSubject10.Visible = False
                TextInternal10.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks10.Visible = False
                TextResult10.Visible = False
            ElseIf TotalSubjects = 10 Then
                Query = $"SELECT SUBJECT_NAME FROM coursewise_subjects, subjects WHERE
coursewise_subjects.SUBJECT_ID=subjects.SUBJECT_ID AND coursewise_subjects.UNIVERSITYWISE_COURSE_ID='{UniversitywiseCourseID}' AND 
coursewise_subjects.SESSIONWISE_SEMESTER_ID='{SessionwiseSemesterID}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                LabelSubject1.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject2.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject3.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject4.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject5.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject6.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject7.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject8.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject9.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Read()
                LabelSubject10.Text = Reader.GetString("SUBJECT_NAME")
                Reader.Dispose()
            Else
                LabelSubject1.Visible = False
                LabelSubject2.Visible = False
                LabelSubject3.Visible = False
                LabelSubject4.Visible = False
                LabelSubject5.Visible = False
                LabelSubject6.Visible = False
                LabelSubject7.Visible = False
                LabelSubject8.Visible = False
                LabelSubject9.Visible = False
                LabelSubject10.Visible = False
                TextInternal1.Visible = False
                TextInternal2.Visible = False
                TextInternal3.Visible = False
                TextInternal4.Visible = False
                TextInternal5.Visible = False
                TextInternal6.Visible = False
                TextInternal7.Visible = False
                TextInternal8.Visible = False
                TextInternal9.Visible = False
                TextInternal10.Visible = False
                TextExternal1.Visible = False
                TextExternal2.Visible = False
                TextExternal3.Visible = False
                TextExternal4.Visible = False
                TextExternal5.Visible = False
                TextExternal6.Visible = False
                TextExternal7.Visible = False
                TextExternal8.Visible = False
                TextExternal9.Visible = False
                TextExternal10.Visible = False
                TextMarksInternal1.Visible = False
                TextMarksInternal2.Visible = False
                TextMarksInternal3.Visible = False
                TextMarksInternal4.Visible = False
                TextMarksInternal5.Visible = False
                TextMarksInternal6.Visible = False
                TextMarksInternal7.Visible = False
                TextMarksInternal8.Visible = False
                TextMarksInternal9.Visible = False
                TextMarksInternal10.Visible = False
                TextMarksExternal1.Visible = False
                TextMarksExternal2.Visible = False
                TextMarksExternal3.Visible = False
                TextMarksExternal4.Visible = False
                TextMarksExternal5.Visible = False
                TextMarksExternal6.Visible = False
                TextMarksExternal7.Visible = False
                TextMarksExternal8.Visible = False
                TextMarksExternal9.Visible = False
                TextMarksExternal10.Visible = False
                TextTotalMarks1.Visible = False
                TextTotalMarks2.Visible = False
                TextTotalMarks3.Visible = False
                TextTotalMarks4.Visible = False
                TextTotalMarks5.Visible = False
                TextTotalMarks6.Visible = False
                TextTotalMarks7.Visible = False
                TextTotalMarks8.Visible = False
                TextTotalMarks9.Visible = False
                TextTotalMarks10.Visible = False
                TextResult1.Visible = False
                TextResult2.Visible = False
                TextResult3.Visible = False
                TextResult4.Visible = False
                TextResult5.Visible = False
                TextResult6.Visible = False
                TextResult7.Visible = False
                TextResult8.Visible = False
                TextResult9.Visible = False
                TextResult10.Visible = False
                ButtonAddMarks.Enabled = False
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
            Reader.Dispose()
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
        ComboBoxRoll.Items.Clear()   ' To clear the combobox
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

    Private Sub TextMarksInternal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal1.Text.Insert(TextMarksInternal1.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal2.Text.Insert(TextMarksInternal2.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal3.Text.Insert(TextMarksInternal3.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal4.Text.Insert(TextMarksInternal4.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal5.Text.Insert(TextMarksInternal5.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal6.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal6.Text.Insert(TextMarksInternal6.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal7.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal7.Text.Insert(TextMarksInternal7.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal8.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal8.Text.Insert(TextMarksInternal8.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal9.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal9.Text.Insert(TextMarksInternal9.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksInternal10.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksInternal10.Text.Insert(TextMarksInternal10.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumInternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal1.Text.Insert(TextMarksExternal1.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal2.Text.Insert(TextMarksExternal2.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal3.Text.Insert(TextMarksExternal3.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal4.Text.Insert(TextMarksExternal4.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal5.Text.Insert(TextMarksExternal5.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal6.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal6.Text.Insert(TextMarksExternal6.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal7.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal7.Text.Insert(TextMarksExternal7.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal8.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal8.Text.Insert(TextMarksExternal8.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal9.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal9.Text.Insert(TextMarksExternal9.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksExternal10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMarksExternal10.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsNumber(e.KeyChar) Then
            Dim MarksText As String = TextMarksExternal10.Text.Insert(TextMarksExternal10.SelectionStart, e.KeyChar.ToString)
            If Not IsNumeric(MarksText) OrElse CInt(MarksText) > MaximumExternalMarks OrElse CInt(MarksText) < 0 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextMarksInternal1_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal1.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal2_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal2.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal3_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal3.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal4_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal4.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal5_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal5.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal6_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal6.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal7_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal7.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal8_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal8.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal9_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal9.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal10_Enter(sender As Object, e As EventArgs) Handles TextMarksInternal10.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal1_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal1.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal2_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal2.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal3_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal3.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal4_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal4.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal5_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal5.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal6_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal6.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal7_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal7.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal8_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal8.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal9_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal9.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksExternal10_Enter(sender As Object, e As EventArgs) Handles TextMarksExternal10.Enter
        Clipboard.Clear()
    End Sub

    Private Sub TextMarksInternal1_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal1.TextChanged
        If TextMarksInternal1.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal2_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal2.TextChanged
        If TextMarksInternal2.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal3_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal3.TextChanged
        If TextMarksInternal3.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal4_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal4.TextChanged
        If TextMarksInternal4.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal5_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal5.TextChanged
        If TextMarksInternal5.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal6_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal6.TextChanged
        If TextMarksInternal6.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal7_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal7.TextChanged
        If TextMarksInternal7.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal8_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal8.TextChanged
        If TextMarksInternal8.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal9_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal9.TextChanged
        If TextMarksInternal9.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksInternal10_TextChanged(sender As Object, e As EventArgs) Handles TextMarksInternal10.TextChanged
        If TextMarksInternal10.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal1_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal1.TextChanged
        If TextMarksExternal1.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal2_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal2.TextChanged
        If TextMarksExternal2.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal3_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal3.TextChanged
        If TextMarksExternal3.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal4_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal4.TextChanged
        If TextMarksExternal4.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal5_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal5.TextChanged
        If TextMarksExternal5.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal6_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal6.TextChanged
        If TextMarksExternal6.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal7_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal7.TextChanged
        If TextMarksExternal7.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal8_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal8.TextChanged
        If TextMarksExternal8.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal9_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal9.TextChanged
        If TextMarksExternal9.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub TextMarksExternal10_TextChanged(sender As Object, e As EventArgs) Handles TextMarksExternal10.TextChanged
        If TextMarksExternal10.Text <> "" Then
            ErrorProviderAddInformation.Dispose()
        End If
    End Sub

    Private Sub ButtonAddMarks_Click(sender As Object, e As EventArgs) Handles ButtonAddMarks.Click
        If TotalSubjects = 1 Then
            If TextMarksInternal1.Text = "" Then
                ErrorProviderAddInformation.SetError(control:=TextMarksInternal1, value:="Marks can't be empty.")
                TextMarksInternal1.Focus()
            ElseIf TextMarksExternal1.Text = "" Then
                ErrorProviderAddInformation.SetError(control:=TextMarksExternal1, value:="Marks can't be empty.")
                TextMarksExternal1.Focus()
            End If
        ElseIf TotalSubjects = 2 Then
            If TextMarksInternal1.Text = "" Then
                ErrorProviderAddInformation.SetError(control:=TextMarksInternal1, value:="Marks can't be empty.")
                TextMarksInternal1.Focus()
            ElseIf TextMarksExternal1.Text = "" Then
                ErrorProviderAddInformation.SetError(control:=TextMarksExternal1, value:="Marks can't be empty.")
                TextMarksExternal1.Focus()
            ElseIf TextMarksInternal2.Text = "" Then
                ErrorProviderAddInformation.SetError(control:=TextMarksInternal2, value:="Marks can't be empty.")
                TextMarksInternal2.Focus()
            ElseIf TextMarksExternal2.Text = "" Then
                ErrorProviderAddInformation.SetError(control:=TextMarksExternal2, value:="Marks can't be empty.")
                TextMarksExternal2.Focus()
            End If
        End If
    End Sub
End Class