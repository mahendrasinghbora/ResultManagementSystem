Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormSignIn
    Dim Con As MySqlConnection   ' Connection Variable
    Dim Command As MySqlCommand   ' Command Variable

    Private Sub FormSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Result Management System")   ' Form Styles
        LabelCopyright.Text = "© " & Year(Now) & " Result Management System (rms.)"   ' Copyright text
        TextPassword.MaxLength = 20   ' Maximum Length of Password
        TextUsername.MaxLength = 20   ' Maximum Length of Username
        PanelRms.BackColor = Color.FromArgb(52, 58, 64)   ' Top Panel Color
        LabelRmsFull.ForeColor = Color.FromArgb(255, 255, 255)
        LabelSignIn.ForeColor = Color.FromArgb(255, 255, 255)
        PanelSignInLabel.BackColor = Color.FromArgb(44, 150, 118)
        PanelCopyright.BorderStyle = BorderStyle.FixedSingle
        ButtonSignIn.Enabled = False   ' Sign in button- disabled by default.
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
            Query = $"SELECT * FROM users WHERE USERNAME='{TextUsername.Text}' AND PASSWORD='{TextPassword.Text}' AND STATUS='1';"
            Command = New MySqlCommand(cmdText:=Query, connection:=Con)
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
                Query = $"INSERT INTO users_log (`USERNAME`, `LOG_IN_TIME`) VALUES ('{Username}', now());"
                Command = New MySqlCommand(cmdText:=Query, connection:=Con)
                Reader = Command.ExecuteReader()
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
                MessageBox.Show(text:="Incorrect username or password.", caption:="Sign In Error", buttons:=MessageBoxButtons.OKCancel, icon:=MessageBoxIcon.Error)
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
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[^a-zA-Z0-9\._]") Then
            ErrorProviderSignIn.SetError(TextUsername, "Username can only contain letters, digits, dot and underscore.")
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
            ErrorProviderSignIn.Dispose()
            ButtonSignIn.Enabled = True
        Else
            ErrorProviderSignIn.SetError(control:=TextPassword, value:="Password can't be empty.")
            ButtonSignIn.Enabled = False
        End If
    End Sub

    Private Sub TextUsername_TextChanged(sender As Object, e As EventArgs) Handles TextUsername.TextChanged
        If TextUsername.Text = "" Then
            ErrorProviderSignIn.SetError(TextUsername, "Username can't be empty.")
            TextUsername.Focus()
            ButtonSignIn.Enabled = False
        Else
            If System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[^a-zA-Z0-9\._]") Then
                ErrorProviderSignIn.SetError(TextUsername, "Username can only contain letters, digits, dot and underscore.")
                ButtonSignIn.Enabled = False
                TextUsername.Focus()
            Else
                If Not System.Text.RegularExpressions.Regex.IsMatch(input:=TextUsername.Text, pattern:="[a-zA-Z]+[0-9\._]*") Then
                    ErrorProviderSignIn.SetError(TextUsername, "Username must contain atleast one letter.")
                    ButtonSignIn.Enabled = False
                    TextUsername.Focus()
                Else
                    ErrorProviderSignIn.Dispose()
                    If TextPassword.Text <> "" Then
                        ButtonSignIn.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub
End Class