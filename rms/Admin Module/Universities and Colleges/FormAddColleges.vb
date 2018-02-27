Imports MySql.Data.MySqlClient

Public Class FormAddColleges
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable
    Dim Count As Integer = 0

    Private Sub FormAddColleges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Colleges")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddColleges.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddCollegesLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelColleges.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddCollege.Enabled = False
        FillUniversities()   ' To fill combobox with universities
        TextCollege.MaxLength = 100   ' Maximum Length of Colleges
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
                Count = Count + 1
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
        ContextMenuStripAddColleges.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextCollege_TextChanged(sender As Object, e As EventArgs) Handles TextCollege.TextChanged
        If TextCollege.Text = "" Then
            ErrorProviderCollege.SetError(control:=TextCollege, value:="College name can't be empty.")
            TextCollege.Focus()
            ButtonAddCollege.Enabled = False
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(TextCollege.Text, "[^a-zA-Z\.,\s]") Then
            ErrorProviderCollege.SetError(control:=TextCollege, value:="College name can't contain digits or special characters other than a dot(.) and a comma(,).")
            TextCollege.Focus()
            ButtonAddCollege.Enabled = False
        End If
        If TextCollege.Text <> "" And Not System.Text.RegularExpressions.Regex.IsMatch(TextCollege.Text, "[^a-zA-Z\.,\s]") Then
            ErrorProviderCollege.Dispose()
            If Count <> 0 And ComboBoxUniversity.SelectedItem <> Nothing Then
                ButtonAddCollege.Enabled = True
            End If
        End If
    End Sub

    Private Sub TextCollege_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextCollege.Validating
        If TextCollege.Text = "" Then
            ErrorProviderCollege.SetError(control:=TextCollege, value:="College name can't be empty.")
            TextCollege.Focus()
            ButtonAddCollege.Enabled = False
        End If
    End Sub

    Private Sub ButtonAddCollege_Click(sender As Object, e As EventArgs) Handles ButtonAddCollege.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }
        Dim UniversityID As Integer
        Dim Reader As MySqlDataReader
        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM universities WHERE UNIVERSITY_NAME = '{ComboBoxUniversity.SelectedItem}';"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Reader.Read()
            UniversityID = Reader.GetInt64(column:="UNIVERSITY_ID")
            Reader.Dispose()
            Query = $"INSERT INTO colleges (`COLLEGE_NAME`, `UNIVERSITY_ID`, `USERNAME`) VALUES ('{TextCollege.Text}', '{UniversityID}', '{Username}');"
            Command = New MySqlCommand(Query, Con)
            Reader = Command.ExecuteReader()
            Dim NewFormAddColleges As FormAddColleges
            NewFormAddColleges = New FormAddColleges()
            NewFormAddColleges.Show()
            Dispose()
            MessageBox.Show(text:="College successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="College already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxUniversity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUniversity.SelectedIndexChanged
        If TextCollege.Text <> "" And Count <> 0 Then
            ButtonAddCollege.Enabled = True
        End If
    End Sub
End Class