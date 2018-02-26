Imports MySql.Data.MySqlClient

Public Class FormAddSemesters
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormAddSemesters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Semesters")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddSemesters.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddSemesterLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelSemesters.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddSemester.Enabled = False
        TextSemester.MaxLength = 4   ' Maximum Length of Semester
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddSemesters.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextSemester_TextChanged(sender As Object, e As EventArgs) Handles TextSemester.TextChanged
        If TextSemester.Text = "" Then
            ErrorProviderSemester.SetError(control:=TextSemester, value:="Semester can't be empty.")
            TextSemester.Focus()
            ButtonAddSemester.Enabled = False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextSemester.Text, pattern:="^(I[V]|V?I{0,3})$") Then
            ErrorProviderSemester.SetError(control:=TextSemester, value:="Semester must be in Roman numerals.")
            TextSemester.Focus()
            ButtonAddSemester.Enabled = False
        End If
        If TextSemester.Text <> "" And System.Text.RegularExpressions.Regex.IsMatch(input:=TextSemester.Text, pattern:="^(I[V]|V?I{0,3})$") Then
            ButtonAddSemester.Enabled = True
            ErrorProviderSemester.Dispose()
        End If
    End Sub

    Private Sub ButtonAddSemester_Click(sender As Object, e As EventArgs) Handles ButtonAddSemester.Click
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }

        Try
            Con.Open()
            Dim Query As String
            Query = $"INSERT INTO semesters (`SEMESTER`, `USERNAME`) VALUES ('{TextSemester.Text}', '{Username}');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddSemesters As FormAddSemesters
            NewFormAddSemesters = New FormAddSemesters()
            NewFormAddSemesters.Show()
            Dispose()
            MessageBox.Show(text:="Semester successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Semester already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class