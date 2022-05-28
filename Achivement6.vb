Public Class Achivement6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Vous pouvez dès maintenant aller chercher votre succès !")
        AchivementTab.Success6.Enabled = True
        AchivementTab.Show()
        Me.Close()
    End Sub
End Class