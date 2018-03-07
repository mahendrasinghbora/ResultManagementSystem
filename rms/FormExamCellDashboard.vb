Public Class FormExamCellDashboard
    Private Sub FormExamCellDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | Exam Cell's Dashboard")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelDashboard.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripUser.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        EditProfileExamCell(CallingForm:=Me)
    End Sub

    Private Sub ButtonOption1_Click(sender As Object, e As EventArgs) Handles ButtonOption1.Click
        Dim NewFromAddMarks As FormAddMarks
        NewFromAddMarks = New FormAddMarks()
        NewFromAddMarks.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption2_Click(sender As Object, e As EventArgs) Handles ButtonOption2.Click
        Dim NewFormPrintMarksheets As FormPrintMarksheets
        NewFormPrintMarksheets = New FormPrintMarksheets()
        NewFormPrintMarksheets.Show()
        Dispose()
    End Sub
End Class