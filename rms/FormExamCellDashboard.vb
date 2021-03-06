﻿Public Class FormExamCellDashboard
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

    Private Sub ButtonOption3_Click(sender As Object, e As EventArgs) Handles ButtonOption3.Click
        Dim NewFormReportI As FormReportI
        NewFormReportI = New FormReportI()
        NewFormReportI.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption4_Click(sender As Object, e As EventArgs) Handles ButtonOption4.Click
        Dim NewFormReportII As FormReportII
        NewFormReportII = New FormReportII()
        NewFormReportII.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption5_Click(sender As Object, e As EventArgs) Handles ButtonOption5.Click
        Dim NewFormReportIII As FormReportIII
        NewFormReportIII = New FormReportIII()
        NewFormReportIII.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption6_Click(sender As Object, e As EventArgs) Handles ButtonOption6.Click
        Dim NewFormReportIV As FormReportIV
        NewFormReportIV = New FormReportIV()
        NewFormReportIV.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption7_Click(sender As Object, e As EventArgs) Handles ButtonOption7.Click
        Dim NewFormReportV As FormReportV
        NewFormReportV = New FormReportV()
        NewFormReportV.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption8_Click(sender As Object, e As EventArgs) Handles ButtonOption8.Click
        Dim NewFormReportVI As FormReportVI
        NewFormReportVI = New FormReportVI()
        NewFormReportVI.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption9_Click(sender As Object, e As EventArgs) Handles ButtonOption9.Click
        Dim NewFormCompleteList As FormCompleteList
        NewFormCompleteList = New FormCompleteList()
        NewFormCompleteList.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption10_Click(sender As Object, e As EventArgs) Handles ButtonOption10.Click
        Dim NewFormReportVIII As FormReportVIII
        NewFormReportVIII = New FormReportVIII()
        NewFormReportVIII.Show()
        Dispose()
    End Sub

    Private Sub ButtonOption11_Click(sender As Object, e As EventArgs) Handles ButtonOption11.Click
        Dim NewFormAddBackInformation As FormAddBackInformation
        NewFormAddBackInformation = New FormAddBackInformation()
        NewFormAddBackInformation.Show()
        Dispose()
    End Sub
End Class