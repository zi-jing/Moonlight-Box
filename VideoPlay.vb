﻿Public Class VideoPlay


    Private Sub VidPlaySrc_Explore_Click(sender As Object, e As EventArgs) Handles VidPlaySrc_Explore.Click
        VidPlay_Explore.ShowDialog()
        VidPlay_Src.Text = VidPlay_Explore.FileName

    End Sub

    '播放
    Private Sub VidPlay_Play_Click(sender As Object, e As EventArgs) Handles VidPlay_Play.Click

        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp


        Shell(temp + "/MoonLight_Box/ffplay " + VidPlay_Src.Text, AppWinStyle.NormalFocus)
    End Sub



End Class