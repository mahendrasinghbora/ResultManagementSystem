Imports MySql.Data.MySqlClient

Public Class FormAddUniversities
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormAddUniversities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Universities")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddUniversities.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddUniversityLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelUniversities.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddUniversity.Enabled = False
        TextUniversity.MaxLength = 100   ' Maximum Length of University name
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddUniversities.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextUniversity_TextChanged(sender As Object, e As EventArgs) Handles TextUniversity.TextChanged
        If TextUniversity.Text = "" Then
            ErrorProviderUniversity.SetError(control:=TextUniversity, value:="University name can't be empty.")
            TextUniversity.Focus()
            ButtonAddUniversity.Enabled = False
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(input:=TextUniversity.Text, pattern:="[^a-zA-Z\.,\s]") Then
            ErrorProviderUniversity.SetError(control:=TextUniversity, value:="University name can't contain digits or special characters other than a dot (.) and a comma (,).")
            TextUniversity.Focus()
            ButtonAddUniversity.Enabled = False
        End If
        If TextUniversity.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextUniversity.Text, "[^a-zA-Z\.,\s]") Then
            ButtonAddUniversity.Enabled = True
            ErrorProviderUniversity.Dispose()
        End If
    End Sub

    Private Sub ButtonAddUniversity_Click(sender As Object, e As EventArgs) Handles ButtonAddUniversity.Click
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }

        Try
            Con.Open()
            Dim Query As String
            Query = $"INSERT INTO universities (`UNIVERSITY_NAME`, `USERNAME`) VALUES ('{TextUniversity.Text}', '{Username}');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddUniversities As FormAddUniversities
            NewFormAddUniversities = New FormAddUniversities()
            NewFormAddUniversities.Show()
            Dispose()
            MessageBox.Show(text:="University successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="University already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub
End Class