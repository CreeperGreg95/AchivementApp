Public Class Quiz2
    Private Sub Quiz2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-_-
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AchivementTab.Button3.Enabled = True
        If TextBox1.Text = "3" And TextBox2.Text = "-0.5" And TextBox3.Text = "1er" Then
            My.Computer.Audio.Play(My.Resources.success_rare, AudioPlayMode.Background)
            NotifyIcon1.ShowBalloonTip(1000, "Les matheux !", "Vous avez réussi le quiz (de maths) !", ToolTipIcon.Info)
            Me.Close()
            AchivementTab.Show()
        Else
            MessageBox.Show("Erreur dans les réponses marquées !", "Erreur(s) détectée(s) !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Audio.Play(My.Resources.success, AudioPlayMode.Background)
            NotifyIcon2.ShowBalloonTip(1000, "Coup dur pour Guillaume !", "Vous avez essayé de passer le quiz de maths.", ToolTipIcon.Info)
        End If
    End Sub
End Class