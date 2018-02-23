Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormSigIn
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "RMS | Result Management System"
        MinimizeBox = True
        MaximizeBox = True
        Size = New Size(1366, 768)   ' Default Size- 1368x768 px
        MaximumSize = New Size(1366, 768)   ' Maximum Size- 1366x768 px
        MinimumSize = New Size(1366, 768)   ' Minimum Size- 1366x768 px
        StartPosition = FormStartPosition.CenterScreen   ' Default Start Position- CenterScreen
        WindowState = FormWindowState.Normal   ' Default Window State- Normal
        LabelCopyright.Text = "© " & Year(Now) & " Result Management System (rms.)"   ' Copyright text
        TextPassword.MaxLength = 20   ' Maximum Length of Password
        TextUsername.MaxLength = 20   ' Maximum Length of Username
        PanelRms.BackColor = Color.FromArgb(52, 58, 64)   ' Top Panel Color
        LabelRmsFull.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSignIn.ForeColor = Color.FromArgb(255, 255, 255)
        PanelSignInLabel.BackColor = Color.FromArgb(44, 150, 118)
        PanelCopyright.BorderStyle = BorderStyle.FixedSingle
        ButtonSignIn.Enabled = False   ' SIgn in button- disabled by default.
    End Sub

    Private Sub LinkGuideSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGuideSite.LinkClicked
        Process.Start("http://www.onlinegurujee.in/harshvpant/")
    End Sub

    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles ButtonSignIn.Click
        Con = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=rms"
        }

        Try
            Con.Open()
            Dim Query As String
            Dim UserStatus As Integer
            Query = $"SELECT * FROM users WHERE USERNAME='{TextUsername.Text}' AND PASSWORD='{TextPassword.Text}';"
            Command = New MySqlCommand(Query, Con)
            Dim Reader As MySqlDataReader = Command.ExecuteReader()
            Dim Count As Integer = 0
            While Reader.Read()
                Count = Count + 1
            End While
            If Count = 1 Then
                UserStatus = Reader.GetInt16(column:="USER_STATUS_ID")
                FullUsername = Reader.GetString(column:="FIRST_NAME") & " " & Reader.GetString(column:="LAST_NAME")
                Username = Reader.GetString(column:="USERNAME")
                Reader.Dispose()
                Query = $"SELECT * FROM user_status WHERE USER_STATUS_ID='{UserStatus}';"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
                Reader.Read()
                If Reader.GetString(column:="USER_TYPE") = "Admin" Then
                    FormAdminDashboard.Show()
                    Hide()
                Else
                    FormExamCellDashboard.Show()
                    Hide()
                End If
            Else
                MessageBox.Show(text:="Incorrect username or password.", caption:="Sign In Error", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Stop)
            End If
            Reader.Dispose()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Private Sub TextUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextUsername.Validating
        If TextUsername.Text = "" Then
            ErrorProviderSignIn.SetError(control:=TextUsername, value:="Username can't be empty.")
            TextUsername.Focus()
        Else
            ErrorProviderSignIn.Dispose()
        End If
    End Sub

    Private Sub TextPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextPassword.Validating
        If TextPassword.Text = "" Then
            ErrorProviderSignIn.SetError(control:=TextPassword, value:="Password can't be empty.")
        Else
            ErrorProviderSignIn.Dispose()
        End If
    End Sub

    Private Sub TextPassword_TextChanged(sender As Object, e As EventArgs) Handles TextPassword.TextChanged
        If TextPassword.Text <> "" Then
            ButtonSignIn.Enabled = True
        Else
            ButtonSignIn.Enabled = False
        End If
    End Sub
End Class