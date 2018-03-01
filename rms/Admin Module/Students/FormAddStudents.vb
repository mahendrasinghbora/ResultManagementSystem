Imports MySql.Data.MySqlClient

Public Class FormAddStudents
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim CountCollege As Integer = 0


    Private Sub FormAddStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Students")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddStudents.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddStudentsLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelStudents.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddStudent.Enabled = False
        FillColleges()   ' To fill combobox with colleges
        RadioButtonGender1.Select()   ' Male- Selected by default
        TextFirstName.MaxLength = 50   ' Maximum Length of First Name
        TextLastName.MaxLength = 50   ' Maximum Length of Last Name
        TextFather.MaxLength = 100   ' Maximum length of Father's Name
        TextMother.MaxLength = 100   ' Maximum length of Mother's Name
        TextMobile.MaxLength = 10   ' Maximum length of Mobile Number
        TextEmail.MaxLength = 254   ' Maximum length of Email Address
        TextAddress.MaxLength = 200   ' Maximum length of Address
        DateTimePickerDOB.MaxDate = Date.Today()   ' To disable all future dates
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

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddStudents.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextFirstName_Validating(sender As Object, e As EventArgs) Handles TextFirstName.Validating
        If TextFirstName.Text = "" Then
            ErrorProviderStudent.SetError(control:=TextFirstName, value:="First name can't be empty.")
            TextFirstName.Focus()
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderStudent.SetError(control:=TextFirstName, value:="First name can't contain digits.")
            TextFirstName.Focus()
        End If
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") Then
            ErrorProviderStudent.Dispose()
        End If
    End Sub

    Private Sub TextFirstName_TextChanged(sender As Object, e As EventArgs) Handles TextFirstName.TextChanged
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") And
            ComboBoxCollege.SelectedItem <> Nothing And CountCollege <> 0 Then
            ErrorProviderStudent.Dispose()
            ButtonAddStudent.Enabled = True
        Else
            ButtonAddStudent.Enabled = False
        End If
    End Sub

    Private Sub TextLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextLastName.Validating
        If System.Text.RegularExpressions.Regex.IsMatch(TextLastName.Text, "\d+") Then
            ErrorProviderStudent.SetError(control:=TextLastName, value:="Last name can't contain digits.")
            TextLastName.Focus()
        Else
            ErrorProviderStudent.Dispose()
        End If
    End Sub

    Private Sub TextMother_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextMother.Validating
        If System.Text.RegularExpressions.Regex.IsMatch(TextMother.Text, "\d+") Then
            ErrorProviderStudent.SetError(control:=TextMother, value:="Mother's name can't contain digits.")
            TextMother.Focus()
        Else
            ErrorProviderStudent.Dispose()
        End If
    End Sub

    Private Sub TextFather_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextFather.Validating
        If System.Text.RegularExpressions.Regex.IsMatch(TextFather.Text, "\d+") Then
            ErrorProviderStudent.SetError(control:=TextFather, value:="Father's name can't contain digits.")
            TextFather.Focus()
        Else
            ErrorProviderStudent.Dispose()
        End If
    End Sub

    Private Sub TextEmail_Validating(sender As Object, e As EventArgs) Handles TextEmail.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextEmail.Text, pattern:="^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
            ErrorProviderStudent.SetError(control:=TextEmail, value:="Please enter a valid email address.")
            TextEmail.Focus()
        Else
            ErrorProviderStudent.Dispose()
        End If
    End Sub

    Private Sub TextMobile_Validating(sender As Object, e As EventArgs) Handles TextMobile.Validating
        If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextMobile.Text, pattern:="^(\+\d{1,3}[- ]?)?\d{10}$") Then
            ErrorProviderStudent.SetError(control:=TextMobile, value:="Please enter a valid mobile number.")
            TextMobile.Focus()
        Else
            ErrorProviderStudent.Dispose()
        End If
    End Sub

    Private Sub ComboBoxCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCollege.SelectedIndexChanged
        If TextFirstName.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextFirstName.Text, "\d+") And TextFirstName.Text <> "" Then
            ButtonAddStudent.Enabled = True
        End If
    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click
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
            Dim Gender As String
            If RadioButtonGender1.Checked() Then
                Gender = "M"
            ElseIf RadioButtonGender2.Checked() Then
                Gender = "F"
            Else
                Gender = "O"
            End If
            Dim DOB As Date = DateTimePickerDOB.Value.Date()
            Query = $"INSERT INTO students (`COLLEGE_ID`, `FIRST_NAME`, `LAST_NAME`, `GENDER`, `D_O_B`, `FATHER_NAME`,
`MOTHER_NAME`, `ADDRESS`, `EMAIL`, `MOBILE_NUMBER`, `USERNAME`) VALUES ('{CollegeID}', '{TextFirstName.Text}', '{TextLastName.Text}', '{Gender}',
'{DOB.ToString("yyyy-MM-dd")}', '{TextFather.Text}', '{TextMother.Text}', '{TextAddress.Text}', '{TextEmail.Text}', '{TextMobile.Text}', '{Username}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Con.Close()
            Dim NewFormAddStudents As FormAddStudents
            NewFormAddStudents = New FormAddStudents()
            NewFormAddStudents.Show()
            Dispose()
            MessageBox.Show(text:="Student successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class