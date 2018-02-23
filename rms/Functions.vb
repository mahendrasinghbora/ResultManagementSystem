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
        Dim NewFormSignIn As FormSigIn
        NewFormSignIn = New FormSigIn()
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

    Public Sub UserImage(PictureBoxUser As PictureBox)
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
End Module
