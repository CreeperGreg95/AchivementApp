Public Class AchivementTab
    Private Sub Success1_Click(sender As Object, e As EventArgs) Handles Success1.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon1.ShowBalloonTip(1000, "Le Commencement !", "Vous avez appuyé sur le bouton 'Succès n°1' !", ToolTipIcon.Info)
    End Sub

    Private Sub Success2_Click(sender As Object, e As EventArgs) Handles Success2.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
        NotifyIcon2.ShowBalloonTip(1000, "Qui le connaît ?", "Vous avez trouvé le nom secret (qui pourrait servir dans quelques temps)", ToolTipIcon.Info)
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "success_enabled" Then
            Success2.Enabled = True
        End If
        If TextBox1.Text = "Grégory" Then
            Success2.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        AccountAchivement3.Show()
    End Sub

    Private Sub Success3_Click(sender As Object, e As EventArgs) Handles Success3.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon2.ShowBalloonTip(1000, "Les bases d'une application (1/2)", "Vous avez crée votre compte temporaire", ToolTipIcon.Info)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        AccountAchivement4.Show()
    End Sub

    Private Sub Success4_Click(sender As Object, e As EventArgs) Handles Success4.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
        NotifyIcon2.ShowBalloonTip(1000, "Les bases d'une application (2/2)", "Vous vous êtes connecté à votre compte temporaire", ToolTipIcon.Info)
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckBox1.Checked = True Then
            My.Settings.SaveCheckBoxHome = True
        Else
            My.Settings.SaveCheckBoxHome = False
        End If

    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.SaveCheckBoxHome = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Success5_Click(sender As Object, e As EventArgs) Handles Success5.Click
        If CheckBox1.Checked = True Then
            MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
            NotifyIcon2.ShowBalloonTip(1000, "Etes vous vraiment sûr que vous n'oubliez pas un truc ?", "Vous avez coché la boite, mais...", ToolTipIcon.Info)
        Else
            MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
            NotifyIcon2.ShowBalloonTip(1000, "Que vous êtes intélligent(e) !", "Vous avez trouvé la manipulation secrète.", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Success6.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
        NotifyIcon2.ShowBalloonTip(1000, "Etes vous un(e) aventurier(ière) ?", "Vous avez toruvé le bouton caché !", ToolTipIcon.Info)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Hide()
        Achivement6.Show()
    End Sub

    Private Sub SecretSuccess1_Click(sender As Object, e As EventArgs) Handles SecretSuccess1.Click
        MessageBox.Show("Succès Déverouillé !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
        NotifyIcon2.ShowBalloonTip(1000, "Sherlock Holmes ?", "Vous avez trouvé le 1er succès caché !", ToolTipIcon.Info)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class
