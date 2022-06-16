Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon3.ShowBalloonTip(1000, "Retour aux affaires !", "Vous revenez à la page des succès.", ToolTipIcon.Info)
        Me.Close()
        AchivementTab.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/CreeperGreg95/AchivementApp/releases/v.1.3.0")
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
        NotifyIcon3.ShowBalloonTip(1000, "Vous êtes un bon !", "Soutenir le créateur.", ToolTipIcon.Info)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon1.ShowBalloonTip(1000, "Les paramètres !", "Regarder les informations 'cachées'", ToolTipIcon.Info)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon2.ShowBalloonTip(1000, "Internet au bon vieux temps !", "Utliser la version minime d'Internet Explorer dans les paramètres de l'application.", ToolTipIcon.Info)
        WebBrowser1.Navigate("https://github.com/CreeperGreg95/AchivementApp/releases/v.1.3.0")
        NotifyIcon4.ShowBalloonTip(1000, "La où la décision à été prise...", "Internet Explorer est définitivement mort le 15 juin. Repose en Paix !", ToolTipIcon.Info)
        WebBrowser1.Navigate("https://www.microsoft.com/fr-fr/download/internet-explorer.aspx")
    End Sub
End Class