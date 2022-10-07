Public Class About

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/windowslogic/CD-Player/blob/main/LICENSE")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.github.com/windowslogic/cd-player")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load version number and licence.
        Variables.ParseVariables(VerInfo)
        Variables.ParseVariables(Copyright)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://windowslogic.co.uk/appagreement.php")
    End Sub
End Class