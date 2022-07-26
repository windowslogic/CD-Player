Public Class Prefs

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim f As Font = New Font(Font.FontFamily, 8.0F, FontStyle.Bold)
        Dim c As Color = Color.OliveDrab
        Label2.Show()
        Label3.Show()
        Label4.Hide()
        Label5.Hide()
        CDPlayer.TrackS.Font = f
        CDPlayer.TrackS.ForeColor = c
        CDPlayer.Colon1S.Font = f
        CDPlayer.Colon1S.ForeColor = c
        CDPlayer.Colon2S.Font = f
        CDPlayer.Colon2S.ForeColor = c
        CDPlayer.MillisecondsS.Font = f
        CDPlayer.MillisecondsS.ForeColor = c
        CDPlayer.SecondsS.Font = f
        CDPlayer.SecondsS.ForeColor = c
        CDPlayer.MinutesS.Font = f
        CDPlayer.MinutesS.ForeColor = c
        My.Settings.Font = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim f As Font = New Font(Font.FontFamily, 12.0F, FontStyle.Bold)
        Dim c As Color = Color.OliveDrab
        Label2.Hide()
        Label3.Hide()
        Label4.Show()
        Label5.Show()
        CDPlayer.TrackS.Font = f
        CDPlayer.TrackS.ForeColor = c
        CDPlayer.Colon1S.Font = f
        CDPlayer.Colon1S.ForeColor = c
        CDPlayer.Colon2S.Font = f
        CDPlayer.Colon2S.ForeColor = c
        CDPlayer.MillisecondsS.Font = f
        CDPlayer.MillisecondsS.ForeColor = c
        CDPlayer.SecondsS.Font = f
        CDPlayer.SecondsS.ForeColor = c
        CDPlayer.MinutesS.Font = f
        CDPlayer.MinutesS.ForeColor = c
        My.Settings.Font = 2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If CheckBox2.Checked = True Then
            My.Settings.Save()
            Me.Close()
            My.Settings.settingssave = 1
        End If
        If CheckBox2.Checked = False Then
            Me.Close()
            My.Settings.settingssave = 2
        End If
    End Sub

    Private Sub Prefs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Settings for changing the display font size.
        If My.Settings.Font = 1 Then
            RadioButton1.Checked = True
        End If
        If My.Settings.Font = 2 Then
            RadioButton2.Checked = True
        End If
        'Settings for whether to save the settings or not.
        If My.Settings.settingssave = 1 Then
            CheckBox2.Checked = True
        End If
        If My.Settings.settingssave = 2 Then
            CheckBox2.Checked = False
        End If
        'Settings for showing tooltips.
        If My.Settings.tooltips = 1 Then
            CheckBox3.Checked = True
        End If
        If My.Settings.tooltips = 2 Then
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CDPlayer.ToolTip1.Active = True
            My.Settings.tooltips = 1
        End If
        If CheckBox3.Checked = False Then
            CDPlayer.ToolTip1.Active = False
            My.Settings.tooltips = 2
        End If
    End Sub
End Class