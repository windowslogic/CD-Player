Public Class MediaPlayer

    Private Sub OpenMediaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenMediaToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer2.URL = OpenFileDialog1.FileName
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        Button1.Hide()
        Button13.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Prefs.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        Button1.Hide()
        Button13.Show()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        AxWindowsMediaPlayer2.Ctlcontrols.pause()
        Button13.Hide()
        Button1.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        Button13.Hide()
        Button1.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer2.Ctlcontrols.previous()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer2.Ctlcontrols.next()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value = 0
        Button5.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value
        Button5.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value
    End Sub
End Class