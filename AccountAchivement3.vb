Public Class AccountAchivement3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = My.Settings.UserName
        TextBox2.Text = My.Settings.PassWord
        MessageBox.Show("Vous pouvez dès maintenant aller chercher votre succès !")
        AchivementTab.Success3.Enabled = True
        AchivementTab.LinkLabel2.Enabled = True
        AchivementTab.Show()
        Me.Close()
    End Sub
End Class