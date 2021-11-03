Public Class Chooser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CDPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MediaPlayer.Show()
        Me.Close()
    End Sub
End Class