Imports MySql.Data.MySqlClient

Public Class FormAddSubjects
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormAddSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Subjects")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddSubjects.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddSubjectLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelSubjects.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddSubject.Enabled = False
        TextSubject.MaxLength = 100   ' Maximum Length of Subject name
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddSubjects.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub ButtonAddSubject_Click(sender As Object, e As EventArgs) Handles ButtonAddSubject.Click
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }

        Try
            Con.Open()
            Dim Query As String
            Query = $"INSERT INTO subjects (`SUBJECT_NAME`, `USERNAME`) VALUES ('{TextSubject.Text}', '{Username}');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddSubjects As FormAddSubjects
            NewFormAddSubjects = New FormAddSubjects()
            NewFormAddSubjects.Show()
            Dispose()
            MessageBox.Show(text:="Subject successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Subject already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub TextSubject_TextChanged(sender As Object, e As EventArgs) Handles TextSubject.TextChanged
        If TextSubject.Text = "" Then
            ErrorProviderSubject.SetError(control:=TextSubject, value:="Subject name can't be empty.")
            TextSubject.Focus()
            ButtonAddSubject.Enabled = False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextSubject.Text, pattern:="[a-zA-Z]+[0-9\._\s]*") Then
            ErrorProviderSubject.SetError(control:=TextSubject, value:="Subject name must contain atleast one letter.")
            TextSubject.Focus()
            ButtonAddSubject.Enabled = False
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(input:=TextSubject.Text, pattern:="[^a-zA-Z\.,\s-]") Then
            ErrorProviderSubject.SetError(control:=TextSubject, value:="Subject name can't contain digits or special characters other than a dot (.), hyphen (-) and a comma (,).")
            TextSubject.Focus()
            ButtonAddSubject.Enabled = False
        End If
        If TextSubject.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextSubject.Text, "[^a-zA-Z\.,\s-]") And
            System.Text.RegularExpressions.Regex.IsMatch(input:=TextSubject.Text, pattern:="[a-zA-Z]+[0-9\._\s]*") Then
            ButtonAddSubject.Enabled = True
            ErrorProviderSubject.Dispose()
        End If
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub
End Class