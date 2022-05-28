Public Class AccountAchivement4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.UserName And TextBox2.Text = My.Settings.PassWord Then
            MessageBox.Show("Bienvenue ' ' !")
            MessageBox.Show("Vous pouvez dès maintenant aller chercher votre succès !")
            AchivementTab.Success4.Enabled = True
            AchivementTab.Show()
            Me.Close()
        End If
    End Sub
End Class