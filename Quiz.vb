Public Class Quiz
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Quiz2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon1.ShowBalloonTip(1000, "L'abandon du joueur français !", "Vous avez quitté le quiz par pur abandon...", ToolTipIcon.Info)
        Me.Close()
        AchivementTab.Show()
    End Sub
End Class