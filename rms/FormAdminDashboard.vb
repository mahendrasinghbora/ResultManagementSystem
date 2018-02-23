Public Class FormAdminDashboard
    Private Sub FormAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "RMS | Admin's Dashboard"
        MinimizeBox = True
        MaximizeBox = True
        Size = New Size(1366, 768)   ' Default Size- 1368x768 px
        MaximumSize = New Size(1366, 768)   ' Maximum Size- 1366x768 px
        MinimumSize = New Size(1366, 768)   ' Minimum Size- 1366x768 px
        StartPosition = FormStartPosition.CenterScreen   ' Default Start Position- CenterScreen
        WindowState = FormWindowState.Normal   ' Default Window State- Normal
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelDashboard.ForeColor = Color.FromArgb(255, 255, 255)
        LabelUsername.Text = FullUsername & "    "   ' Extra spaces to accomodate the dropdown arrow.
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser)
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripUser.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonOption1_Click(sender As Object, e As EventArgs) Handles ButtonOption1.Click
        Dim NewFormAddUsers As FormAddUsers
        NewFormAddUsers = New FormAddUsers()
        NewFormAddUsers.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption2_Click(sender As Object, e As EventArgs) Handles ButtonOption2.Click
        Dim NewFormAddUniversities As FormAddUniversities
        NewFormAddUniversities = New FormAddUniversities()
        NewFormAddUniversities.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption3_Click(sender As Object, e As EventArgs) Handles ButtonOption3.Click
        Dim NewFormAddColleges As FormAddColleges
        NewFormAddColleges = New FormAddColleges()
        NewFormAddColleges.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption4_Click(sender As Object, e As EventArgs) Handles ButtonOption4.Click
        Dim NewFormAddSessions As FormAddSessions
        NewFormAddSessions = New FormAddSessions()
        NewFormAddSessions.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption5_Click(sender As Object, e As EventArgs) Handles ButtonOption5.Click
        Dim NewFormAddSemesters As FormAddSemesters
        NewFormAddSemesters = New FormAddSemesters()
        NewFormAddSemesters.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption6_Click(sender As Object, e As EventArgs) Handles ButtonOption6.Click
        Dim NewFormAddSessionwiseSemesters As FormAddSessionwiseSemesters
        NewFormAddSessionwiseSemesters = New FormAddSessionwiseSemesters()
        NewFormAddSessionwiseSemesters.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption7_Click(sender As Object, e As EventArgs) Handles ButtonOption7.Click
        Dim NewFormAddCourses As FormAddCourses
        NewFormAddCourses = New FormAddCourses()
        NewFormAddCourses.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption8_Click(sender As Object, e As EventArgs) Handles ButtonOption8.Click
        Dim NewFormAddSubjects As FormAddSubjects
        NewFormAddSubjects = New FormAddSubjects()
        NewFormAddSubjects.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption9_Click(sender As Object, e As EventArgs) Handles ButtonOption9.Click
        Dim NewFormAddCoursewiseSubjects As FormAddCoursewiseSubjects
        NewFormAddCoursewiseSubjects = New FormAddCoursewiseSubjects()
        NewFormAddCoursewiseSubjects.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption10_Click(sender As Object, e As EventArgs) Handles ButtonOption10.Click
        Dim NewFormAddStudents As FormAddStudents
        NewFormAddStudents = New FormAddStudents()
        NewFormAddStudents.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption11_Click(sender As Object, e As EventArgs) Handles ButtonOption11.Click
        Dim NewFormAddResultCriteria As FormAddResultCriteria
        NewFormAddResultCriteria = New FormAddResultCriteria()
        NewFormAddResultCriteria.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption12_Click(sender As Object, e As EventArgs) Handles ButtonOption12.Click
        Dim NewFormViewUserLog As FormViewUserLog
        NewFormViewUserLog = New FormViewUserLog()
        NewFormViewUserLog.Show()
        Dispose()
    End Sub
End Class