Imports System.IO
Imports MySql.Data.MySqlClient

Module Functions
    Public FullUsername As String   ' FullUsername (Global Variable)
    Public Username As String

    ' CallingForm- reference of the form from which the procedure is being called.
    Public Sub LogOut(CallingForm As Form)
        If CallingForm Is Nothing Then
            Throw New ArgumentNullException(NameOf(CallingForm))
        End If
        Dim NewFormSignIn As FormSignIn
        NewFormSignIn = New FormSignIn()
        NewFormSignIn.Show()
        CallingForm.Dispose()
    End Sub

    Public Sub AdminDashboard(CallingForm As Form)
        If CallingForm Is Nothing Then
            Throw New ArgumentNullException(NameOf(CallingForm))
        End If
        Dim NewFormAdminDashboard As FormAdminDashboard
        NewFormAdminDashboard = New FormAdminDashboard()
        NewFormAdminDashboard.Show()
        CallingForm.Dispose()
    End Sub

    Public Sub UserImage(PictureBoxUser As PictureBox, LabelUsername As Label)
        LabelUsername.Text = FullUsername & "    "   ' Extra spaces to accomodate the dropdown arrow.
        Dim Con As MySqlConnection   ' Connection Variable
        Dim Command As MySqlCommand   ' Command Variable
        Dim ImageByte() As Byte
        Dim Stream As MemoryStream
        Dim Adapter As MySqlDataAdapter   ' Data Adapter
        Dim Table As New DataTable()   ' Data Table
        Con = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;database=rms"
       }

        Try
            Con.Open()
            Dim Query As String
            Query = $"SELECT * FROM users WHERE USERNAME='{Username}';"
            Command = New MySqlCommand(Query, Con)
            Adapter = New MySqlDataAdapter(Command)
            Adapter.Fill(Table)
            ImageByte = Table(0)(5)
            Stream = New MemoryStream(ImageByte)
            PictureBoxUser.Image = Image.FromStream(stream:=Stream)
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(text:=ex.Message)
        Finally
            Con.Dispose()
        End Try
    End Sub

    Public Sub FormStyles(CallingForm As Form, Text As String)
        CallingForm.Text = Text
        CallingForm.MinimizeBox = True
        CallingForm.MaximizeBox = True
        CallingForm.Size = New Size(1366, 768)   ' Default Size- 1368x768 px
        CallingForm.MaximumSize = New Size(1366, 768)   ' Maximum Size- 1366x768 px
        CallingForm.MinimumSize = New Size(1366, 768)   ' Minimum Size- 1366x768 px
        CallingForm.StartPosition = FormStartPosition.CenterScreen   ' Default Start Position- CenterScreen
        CallingForm.WindowState = FormWindowState.Maximized   ' Default Window State- Maximized
    End Sub

    Public Sub EditProfile(CallingForm As Form)
        If CallingForm Is Nothing Then
            Throw New ArgumentNullException(NameOf(CallingForm))
        End If
        Dim NewFormEditProfile As FormEditProfile
        NewFormEditProfile = New FormEditProfile()
        NewFormEditProfile.Show()
        CallingForm.Dispose()
    End Sub
End Module
