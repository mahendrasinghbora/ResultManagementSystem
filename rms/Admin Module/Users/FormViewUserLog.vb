﻿Public Class FormViewUserLog
    Private Sub FormViewUserLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStyles(CallingForm:=Me, Text:="RMS | View Users' Log")   ' Form Styles
        PanelNavigation.BackColor = Color.FromArgb(52, 58, 64)   ' Navigation Panel Color
        LabelViewUserLog.ForeColor = Color.FromArgb(255, 255, 255)
        UserImage(PictureBoxUser:=PictureBoxUser, LabelUsername:=LabelUsername)   ' User's Thumbnail and Name
        LabelUsername.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub LabelUsername_Click(sender As Object, e As EventArgs) Handles LabelUsername.Click
        ContextMenuStripViewUserLog.Show(LabelUsername, x:=0, y:=LabelUsername.Height)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogOut(CallingForm:=Me)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        AdminDashboard(CallingForm:=Me)
    End Sub
End Class