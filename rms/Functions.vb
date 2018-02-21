Module Functions
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
End Module
