Public Class Variables
    Public Shared ver As String = My.Application.Info.Version.ToString & " (July 2022)"
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName
    Public Shared appname As String = "CD Player"
    'Public Shared vertext As String = "http://u.windowslogic.co.uk/TWEETER/TWEETER.txt"
    'Public Shared setup As String = "http://u.windowslogic.co.uk/TWEETER/Tweeter%20Setup.exe"

    Public Shared Sub ParseVariables(input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user).Replace("%appname%", Variables.appname)
    End Sub
End Class
