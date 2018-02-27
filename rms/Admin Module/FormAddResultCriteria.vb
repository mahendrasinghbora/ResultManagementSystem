Imports MySql.Data.MySqlClient

Public Class FormAddResultCriteria
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountSemester As Integer = 0
    Dim CountSession As Integer = 0
    Dim CountUniversity As Integer = 0

    Private Sub FormAddResultCriteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Students")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddResultCriteria.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddResultCriteriaLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelResultCriteria.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddResultCriteria.Enabled = False
        FillSemesters()   ' To fill combobox with semesters
        FillSessions()   ' To fill combobox with sessions
        FillUniversities()   ' To fill combobox with universities
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

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddResultCriteria.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextInternalMarks_TextChanged(sender As Object, e As EventArgs) Handles TextInternalMarks.TextChanged
        If TextInternalMarks.Text = "" Then
            ErrorProviderCriteria.SetError(control:=TextInternalMarks, value:="Internal marks can't be empty.")
            ButtonAddResultCriteria.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(TextInternalMarks.Text, "^(\d)+$") Then
                ErrorProviderCriteria.SetError(control:=TextInternalMarks, value:="Internal marks can only contain digits.")
                ButtonAddResultCriteria.Enabled = False
            Else
                If CountSemester <> 0 And CountSession <> 0 And CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And
                    ComboBoxSession.SelectedItem <> Nothing And ComboBoxSemester.SelectedItem <> Nothing And TextExternalMarks.Text <> "" And
                    TextPassingMarks.Text <> "" Then
                    ButtonAddResultCriteria.Enabled = True
                End If
                ErrorProviderCriteria.Dispose()
            End If
        End If
    End Sub

    Private Sub TextInternalMarks_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextInternalMarks.Validating
        If TextInternalMarks.Text = "" Then
            ErrorProviderCriteria.SetError(control:=TextInternalMarks, value:="Internal marks can't be empty.")
            ButtonAddResultCriteria.Enabled = False
            TextInternalMarks.Focus()
        End If
    End Sub

    Private Sub TextExternalMarks_TextChanged(sender As Object, e As EventArgs) Handles TextExternalMarks.TextChanged
        If TextExternalMarks.Text = "" Then
            ErrorProviderCriteria.SetError(control:=TextExternalMarks, value:="External marks can't be empty.")
            ButtonAddResultCriteria.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(TextExternalMarks.Text, "^(\d)+$") Then
                ErrorProviderCriteria.SetError(control:=TextExternalMarks, value:="External marks can only contain digits.")
                ButtonAddResultCriteria.Enabled = False
            Else
                If CountSemester <> 0 And CountSession <> 0 And CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And
                    ComboBoxSession.SelectedItem <> Nothing And ComboBoxSemester.SelectedItem <> Nothing And TextInternalMarks.Text <> "" And
                    TextPassingMarks.Text <> "" Then
                    ButtonAddResultCriteria.Enabled = True
                End If
                ErrorProviderCriteria.Dispose()
            End If
        End If
    End Sub

    Private Sub TextExternalMarks_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextExternalMarks.Validating
        If TextExternalMarks.Text = "" Then
            ErrorProviderCriteria.SetError(control:=TextExternalMarks, value:="External marks can't be empty.")
            ButtonAddResultCriteria.Enabled = False
            TextExternalMarks.Focus()
        End If
    End Sub

    Private Sub TextPassingMarks_TextChanged(sender As Object, e As EventArgs) Handles TextPassingMarks.TextChanged
        If TextPassingMarks.Text = "" Then
            ErrorProviderCriteria.SetError(control:=TextPassingMarks, value:="Passing marks can't be empty.")
            ButtonAddResultCriteria.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextPassingMarks.Text, pattern:="^(\d)+$") Then
                ErrorProviderCriteria.SetError(control:=TextPassingMarks, value:="Passing marks can only contain digits.")
                ButtonAddResultCriteria.Enabled = False
            Else
                If TextInternalMarks.Text <> "" And TextExternalMarks.Text <> "" Then
                    If CType(TextPassingMarks.Text, Integer) >= (CType(TextInternalMarks.Text, Integer) + CType(TextExternalMarks.Text, Integer)) Then
                        ErrorProviderCriteria.SetError(control:=TextPassingMarks, value:="Passing marks must be less than total marks.")
                        ButtonAddResultCriteria.Enabled = False
                    Else
                        If CountSemester <> 0 And CountSession <> 0 And CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And
                    ComboBoxSession.SelectedItem <> Nothing And ComboBoxSemester.SelectedItem <> Nothing And TextInternalMarks.Text <> "" And
                    TextExternalMarks.Text <> "" Then
                            ButtonAddResultCriteria.Enabled = True
                        End If
                        ErrorProviderCriteria.Dispose()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TextPassingMarks_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextPassingMarks.Validating
        If TextPassingMarks.Text = "" Then
            ErrorProviderCriteria.SetError(control:=TextPassingMarks, value:="Passing marks can't be empty.")
            ButtonAddResultCriteria.Enabled = False
            TextPassingMarks.Focus()
        End If
        If TextInternalMarks.Text <> "" And TextExternalMarks.Text <> "" And TextPassingMarks.Text <> "" Then
            If CType(TextPassingMarks.Text, Integer) >= (CType(TextInternalMarks.Text, Integer) + CType(TextExternalMarks.Text, Integer)) Then
                ErrorProviderCriteria.SetError(control:=TextPassingMarks, value:="Passing marks must be less than total marks.")
                ButtonAddResultCriteria.Enabled = False
                TextPassingMarks.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBoxUniversity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUniversity.SelectedIndexChanged
        If CountSemester <> 0 And CountSession <> 0 And CountUniversity <> 0 And TextPassingMarks.Text <> "" And
        ComboBoxSession.SelectedItem <> Nothing And ComboBoxSemester.SelectedItem <> Nothing And TextInternalMarks.Text <> "" And
        TextExternalMarks.Text <> "" Then
            ButtonAddResultCriteria.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxSession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSession.SelectedIndexChanged
        If CountSemester <> 0 And CountSession <> 0 And CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And
        TextPassingMarks.Text <> "" And ComboBoxSemester.SelectedItem <> Nothing And TextInternalMarks.Text <> "" And
        TextExternalMarks.Text <> "" Then
            ButtonAddResultCriteria.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSemester.SelectedIndexChanged
        If CountSemester <> 0 And CountSession <> 0 And CountUniversity <> 0 And ComboBoxUniversity.SelectedItem <> Nothing And
        ComboBoxSession.SelectedItem <> Nothing And TextPassingMarks.Text <> "" And TextInternalMarks.Text <> "" And
        TextExternalMarks.Text <> "" Then
            ButtonAddResultCriteria.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddResultCriteria_Click(sender As Object, e As EventArgs) Handles ButtonAddResultCriteria.Click
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
            Query = $"SELECT * FROM semesters WHERE SEMESTER = '{ComboBoxSemester.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim SemesterID As String = Reader.GetString(column:="SEMESTER_ID")
            Reader.Dispose()
            Query = $"SELECT * FROM sessionwise_semesters WHERE SESSION_ID = '{ComboBoxSession.SelectedItem}' AND SEMESTER_ID = '{SemesterID}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            Dim SessionwiseSemesterID As String = Reader.GetString(column:="SESSIONWISE_SEMESTER_ID")
            Reader.Dispose()
            Query = $"INSERT INTO result_criteria (`MAXIMUM_INTERNAL_MARKS`, `MAXIMUM_EXTERNAL_MARKS`, `PASSING_MARKS`, `UNIVERSITY_ID`,
`SESSIONWISE_SEMESTER_ID`, `USERNAME`) VALUES ('{TextInternalMarks.Text}', '{TextExternalMarks.Text}', '{TextPassingMarks.Text}',
'{UniversityID}', '{SessionwiseSemesterID}', '{Username}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormAddResultCriteria As FormAddResultCriteria
            NewFormAddResultCriteria = New FormAddResultCriteria()
            NewFormAddResultCriteria.Show()
            Dispose()
            MessageBox.Show(text:="Criteria successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Criteria already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class