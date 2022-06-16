Public Class Achivement8
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
        NotifyIcon1.ShowBalloonTip(1000, "Perspicace", "Vous avez trouvé 'le faux' bouton :)", ToolTipIcon.Info)
        Me.Close()
        AchivementTab.Show()
    End Sub
End Class