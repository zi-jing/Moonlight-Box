﻿Public Class MainScreen

    '移动窗口
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Start_Screen_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Start_Screen_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Start_Screen_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    '显示贴图
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Main_Close.Image = My.Resources.close_0
    End Sub
    '鼠标移动到关闭按钮时
    Private Sub Main_Close_MouseMove(sender As Object, e As MouseEventArgs) Handles Main_Close.MouseMove
        Main_Close.Image = My.Resources.close_1
    End Sub
    '关闭
    Private Sub Main_Close_MouseDown(sender As Object, e As MouseEventArgs) Handles Main_Close.MouseDown
        Main_Close.Image = My.Resources.close_2
        Close()
    End Sub
    '恢复贴图
    Private Sub Main_Close_MouseLeave(sender As Object, e As EventArgs) Handles Main_Close.MouseLeave
        Main_Close.Image = My.Resources.close_0
    End Sub




    '-----------------------------主界面-----------------------------

    '分组1
    Private Sub Icon_Win_Click(sender As Object, e As EventArgs) Handles Icon_Win.Click
        Group_MMedia.Hide()
        Group_Others.Hide()
        Group_Win.Show()
    End Sub

    Private Sub Icon_MMedia_Click(sender As Object, e As EventArgs) Handles Icon_MMedia.Click
        Group_Win.Hide()
        Group_Others.Hide()
        Group_MMedia.Show()
    End Sub

    Private Sub Icon_Others_Click(sender As Object, e As EventArgs) Handles Icon_Others.Click
        Group_Win.Hide()
        Group_MMedia.Hide()
        Group_Others.Show()
    End Sub
End Class