Imports MySql.Data.MySqlClient

Public Class FormAddCourses
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormAddCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Courses")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddCourses.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddCourseLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelCourses.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddCourse.Enabled = False
        TextCourse.MaxLength = 100   ' Maximum Length of Course name
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddCourses.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextCourse_TextChanged(sender As Object, e As EventArgs) Handles TextCourse.TextChanged
        If TextCourse.Text = "" Then
            ErrorProviderCourse.SetError(control:=TextCourse, value:="Course name can't be empty.")
            TextCourse.Focus()
            ButtonAddCourse.Enabled = False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextCourse.Text, pattern:="[a-zA-Z]+[0-9\._\s]*") Then
            ErrorProviderCourse.SetError(control:=TextCourse, value:="Course name must contain atleast one letter.")
            TextCourse.Focus()
            ButtonAddCourse.Enabled = False
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(input:=TextCourse.Text, pattern:="[^a-zA-Z\.,\s-]") Then
            ErrorProviderCourse.SetError(control:=TextCourse, value:="Course name can't contain digits or special characters other than a dot (.), hyphen (-) and a comma (,).")
            TextCourse.Focus()
            ButtonAddCourse.Enabled = False
        End If
        If TextCourse.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextCourse.Text, "[^a-zA-Z\.,\s-]") And
            System.Text.RegularExpressions.Regex.IsMatch(input:=TextCourse.Text, pattern:="[a-zA-Z]+[0-9\._\s]*") Then
            ButtonAddCourse.Enabled = True
            ErrorProviderCourse.Dispose()
        End If
    End Sub

    Private Sub ButtonAddCourse_Click(sender As Object, e As EventArgs) Handles ButtonAddCourse.Click
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }

        Try
            Con.Open()
            Dim Query As String
            Query = $"INSERT INTO courses (`COURSE_NAME`, `USERNAME`) VALUES ('{TextCourse.Text}', '{Username}');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddCourses As FormAddCourses
            NewFormAddCourses = New FormAddCourses()
            NewFormAddCourses.Show()
            Dispose()
            MessageBox.Show(text:="Course successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Course already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub

    Private Sub ButtonAddCollegewiseCourses_Click(sender As Object, e As EventArgs) Handles ButtonAddCollegewiseCourses.Click
        Dim NewFormAddCollegewiseCourses As FormAddCollegewiseCourses
        NewFormAddCollegewiseCourses = New FormAddCollegewiseCourses()
        NewFormAddCollegewiseCourses.Show()
        Dispose()
    End Sub
End Class