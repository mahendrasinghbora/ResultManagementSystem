Imports MySql.Data.MySqlClient

Public Class FormAddSessions
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormAddSessions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Add Sessions")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelAddSessions.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        PanelAddSessionLabel.BackColor = Color.FromArgb(44, 150, 118)
        LabelSessions.ForeColor = Color.FromArgb(255, 255, 255)
        ButtonAddSession.Enabled = False
        TextStartYear.MaxLength = 4   ' Maximum Length of Start Year
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripAddSessions.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub

    Private Sub TextStartYear_TextChanged(sender As Object, e As EventArgs) Handles TextStartYear.TextChanged
        If TextStartYear.Text = "" Then
            ErrorProviderSession.SetError(TextStartYear, "Session start year can't be empty.")
            TextStartYear.Focus()
            ButtonAddSession.Enabled = False
        Else
            If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextStartYear.Text, pattern:="^(20)\d{2}$") Then
                ErrorProviderSession.SetError(TextStartYear, "Session start year must be a valid year between 2000 to 2099.")
                TextStartYear.Focus()
                ButtonAddSession.Enabled = False
            Else
                ErrorProviderSession.Dispose()
                TextEndYear.Text = CType(CInt(TextStartYear.Text) + 1, String)
                ButtonAddSession.Enabled = True
            End If
        End If
    End Sub

    Private Sub ButtonAddSession_Click(sender As Object, e As EventArgs) Handles ButtonAddSession.Click
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }

        Dim SessionID As String = TextStartYear.Text & "-" & TextEndYear.Text.Substring(2)   'Session ID (2017-18)
        Try
            Con.Open()
            Dim Query As String
            Query = $"INSERT INTO sessions (`SESSION_ID`, `START_YEAR`, `END_YEAR`, `USERNAME`) VALUES 
('{SessionID}', '{TextStartYear.Text}', '{TextEndYear.Text}', '{Username}');"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim NewFormAddSessions As FormAddSessions
            NewFormAddSessions = New FormAddSessions()
            NewFormAddSessions.Show()
            Dispose()
            MessageBox.Show(text:="Session successfully added.", caption:="Success alert", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(text:="Session already added.", caption:="Duplicate entry alert", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfile(CallingForm:=Me)
    End Sub
End Class