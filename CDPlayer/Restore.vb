Public Class Restore

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    'Drives.
    Dim Edrive As String = "E:\" 'Some CD/DVD drives have E as the letter.
    Dim Ddrive As String = "D:\" 'D is the default CD/DVD drive letter.
    'Other things.
    Dim retVal As Integer
    Dim buf As String = Space(128)
    Dim buf2 As String = Space(128)
    Dim buf3 As String = Space(128)
    Dim trackCount As Integer
    Dim currentTrack As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CDPlayer.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        retVal = mciSendString("play cd", vbNullString, 0, 0) 'Tell the system to play the CD.
        CDPlayer.CDStatus.Text = "CD Status: Playing"
        Form1_Load(Nothing, Nothing)
        CDPlayer.Timer2.Start()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ddrive = Chr(34) & Ddrive & Chr(34)
        Edrive = Chr(34) & Edrive & Chr(34)
        retVal = mciSendString("open " & Ddrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("open " & Edrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("set cd time format tmsf", vbNullString, 0, 0) 'This will set it so the tracks are recognized as 1 2 3 4...
        retVal = mciSendString("status cd number of tracks", buf, 128, 0) 'Get Num. Of Tracks
        retVal = mciSendString("status cd current track", buf2, 128, 0) 'Get Current Track
        trackCount = CInt(Val(buf)) 'This Will Get the Number Of Tracks (Convert it Into 1 2 3 4...)
        currentTrack = CInt(Val(buf2)) 'This Will get the Current Track (Convert it Into 1 2 3 4...)
        CDPlayer.TrackS.Text = "[" & currentTrack & "/" & trackCount & "]"
        CDPlayer.NumericUpDown1.Maximum = trackCount + 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        retVal = mciSendString("stop cd", vbNullString, 0, 0) 'Tell the system to stop the CD.
        CDPlayer.Timer2.Stop()
        CDPlayer.MillisecondsS.Text = "00"
        CDPlayer.SecondsS.Text = "00"
        CDPlayer.MinutesS.Text = "00"
        CDPlayer.CDStatus.Text = "CD Status: Stopped"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CDPlayer.NumericUpDown1.DownButton()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CDPlayer.NumericUpDown1.UpButton()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        retVal = mciSendString("pause cd", vbNullString, 0, 0) 'Tell the system to pause the CD.
        CDPlayer.Timer2.Stop()
        CDPlayer.CDStatus.Text = "CD Status: Paused"
    End Sub
End Class