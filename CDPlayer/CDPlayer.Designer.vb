<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDPlayer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DiscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackS = New System.Windows.Forms.Label()
        Me.ScreenBack = New System.Windows.Forms.Label()
        Me.MillisecondsS = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CDStatus = New System.Windows.Forms.Label()
        Me.SecondsS = New System.Windows.Forms.Label()
        Me.MinutesS = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Colon1S = New System.Windows.Forms.Label()
        Me.Colon2S = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PTrackButton = New System.Windows.Forms.Button()
        Me.FTrackButton = New System.Windows.Forms.Button()
        Me.EjectButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCDPlayer20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DiscToolStripMenuItem
        '
        Me.DiscToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.DiscToolStripMenuItem.Name = "DiscToolStripMenuItem"
        Me.DiscToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.DiscToolStripMenuItem.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.OptionsToolStripMenuItem.Text = "Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCDPlayer20ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TrackS
        '
        Me.TrackS.AutoSize = True
        Me.TrackS.BackColor = System.Drawing.Color.Black
        Me.TrackS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackS.ForeColor = System.Drawing.Color.OliveDrab
        Me.TrackS.Location = New System.Drawing.Point(50, 29)
        Me.TrackS.Name = "TrackS"
        Me.TrackS.Size = New System.Drawing.Size(44, 13)
        Me.TrackS.TabIndex = 9
        Me.TrackS.Text = "[00/00]"
        '
        'ScreenBack
        '
        Me.ScreenBack.BackColor = System.Drawing.Color.Black
        Me.ScreenBack.Location = New System.Drawing.Point(12, 26)
        Me.ScreenBack.Name = "ScreenBack"
        Me.ScreenBack.Size = New System.Drawing.Size(128, 45)
        Me.ScreenBack.TabIndex = 10
        '
        'MillisecondsS
        '
        Me.MillisecondsS.AutoSize = True
        Me.MillisecondsS.BackColor = System.Drawing.Color.Black
        Me.MillisecondsS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MillisecondsS.ForeColor = System.Drawing.Color.OliveDrab
        Me.MillisecondsS.Location = New System.Drawing.Point(111, 50)
        Me.MillisecondsS.Name = "MillisecondsS"
        Me.MillisecondsS.Size = New System.Drawing.Size(19, 13)
        Me.MillisecondsS.TabIndex = 11
        Me.MillisecondsS.Text = "00"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NumericUpDown1.Location = New System.Drawing.Point(15, 74)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(167, 22)
        Me.NumericUpDown1.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "Track Selector" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select a track out of the total on the current CD.")
        Me.NumericUpDown1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CDStatus
        '
        Me.CDStatus.AutoSize = True
        Me.CDStatus.BackColor = System.Drawing.Color.Transparent
        Me.CDStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CDStatus.Location = New System.Drawing.Point(12, 78)
        Me.CDStatus.Name = "CDStatus"
        Me.CDStatus.Size = New System.Drawing.Size(145, 13)
        Me.CDStatus.TabIndex = 15
        Me.CDStatus.Text = "CD Status: Please Insert CD"
        '
        'SecondsS
        '
        Me.SecondsS.AutoSize = True
        Me.SecondsS.BackColor = System.Drawing.Color.Black
        Me.SecondsS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsS.ForeColor = System.Drawing.Color.OliveDrab
        Me.SecondsS.Location = New System.Drawing.Point(64, 50)
        Me.SecondsS.Name = "SecondsS"
        Me.SecondsS.Size = New System.Drawing.Size(19, 13)
        Me.SecondsS.TabIndex = 21
        Me.SecondsS.Text = "00"
        '
        'MinutesS
        '
        Me.MinutesS.AutoSize = True
        Me.MinutesS.BackColor = System.Drawing.Color.Black
        Me.MinutesS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesS.ForeColor = System.Drawing.Color.OliveDrab
        Me.MinutesS.Location = New System.Drawing.Point(19, 50)
        Me.MinutesS.Name = "MinutesS"
        Me.MinutesS.Size = New System.Drawing.Size(19, 13)
        Me.MinutesS.TabIndex = 22
        Me.MinutesS.Text = "00"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'Colon1S
        '
        Me.Colon1S.AutoSize = True
        Me.Colon1S.BackColor = System.Drawing.Color.Black
        Me.Colon1S.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon1S.ForeColor = System.Drawing.Color.OliveDrab
        Me.Colon1S.Location = New System.Drawing.Point(44, 50)
        Me.Colon1S.Name = "Colon1S"
        Me.Colon1S.Size = New System.Drawing.Size(10, 13)
        Me.Colon1S.TabIndex = 23
        Me.Colon1S.Text = ":"
        '
        'Colon2S
        '
        Me.Colon2S.AutoSize = True
        Me.Colon2S.BackColor = System.Drawing.Color.Black
        Me.Colon2S.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon2S.ForeColor = System.Drawing.Color.OliveDrab
        Me.Colon2S.Location = New System.Drawing.Point(94, 50)
        Me.Colon2S.Name = "Colon2S"
        Me.Colon2S.Size = New System.Drawing.Size(10, 13)
        Me.Colon2S.TabIndex = 24
        Me.Colon2S.Text = ":"
        '
        'PlayButton
        '
        Me.PlayButton.Image = Global.CD_Player.My.Resources.Resources.Play
        Me.PlayButton.Location = New System.Drawing.Point(146, 27)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(76, 23)
        Me.PlayButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.PlayButton, "Play" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plays the current CD.")
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'PTrackButton
        '
        Me.PTrackButton.Image = Global.CD_Player.My.Resources.Resources.PreviousTrack
        Me.PTrackButton.Location = New System.Drawing.Point(146, 49)
        Me.PTrackButton.Name = "PTrackButton"
        Me.PTrackButton.Size = New System.Drawing.Size(50, 23)
        Me.PTrackButton.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.PTrackButton, "Skip Backward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Skip back a track on the current CD.")
        Me.PTrackButton.UseVisualStyleBackColor = True
        '
        'FTrackButton
        '
        Me.FTrackButton.Image = Global.CD_Player.My.Resources.Resources.NextTrack
        Me.FTrackButton.Location = New System.Drawing.Point(195, 49)
        Me.FTrackButton.Name = "FTrackButton"
        Me.FTrackButton.Size = New System.Drawing.Size(52, 23)
        Me.FTrackButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.FTrackButton, "Skip Forward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Skip forward a track on the current CD.")
        Me.FTrackButton.UseVisualStyleBackColor = True
        '
        'EjectButton
        '
        Me.EjectButton.Image = CType(resources.GetObject("EjectButton.Image"), System.Drawing.Image)
        Me.EjectButton.Location = New System.Drawing.Point(246, 49)
        Me.EjectButton.Name = "EjectButton"
        Me.EjectButton.Size = New System.Drawing.Size(26, 23)
        Me.EjectButton.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.EjectButton, "Eject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Opens the CD drive so that you can change the CD.")
        Me.EjectButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.Image = Global.CD_Player.My.Resources.Resources.Pause
        Me.PauseButton.Location = New System.Drawing.Point(221, 27)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(26, 23)
        Me.PauseButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.PauseButton, "Pause" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pauses the current CD.")
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Image = Global.CD_Player.My.Resources.Resources._Stop
        Me.StopButton.Location = New System.Drawing.Point(246, 27)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(26, 23)
        Me.StopButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.StopButton, "Stop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stops the CD.")
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.CD_Player.My.Resources.Resources._Exit
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Image = Global.CD_Player.My.Resources.Resources.Settings
        Me.PreferencesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.PreferencesToolStripMenuItem.Text = "Settings"
        '
        'AboutCDPlayer20ToolStripMenuItem
        '
        Me.AboutCDPlayer20ToolStripMenuItem.Image = Global.CD_Player.My.Resources.Resources.Information
        Me.AboutCDPlayer20ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutCDPlayer20ToolStripMenuItem.Name = "AboutCDPlayer20ToolStripMenuItem"
        Me.AboutCDPlayer20ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutCDPlayer20ToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.AboutCDPlayer20ToolStripMenuItem.Text = "About"
        '
        'CDPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 100)
        Me.Controls.Add(Me.Colon2S)
        Me.Controls.Add(Me.Colon1S)
        Me.Controls.Add(Me.MinutesS)
        Me.Controls.Add(Me.SecondsS)
        Me.Controls.Add(Me.CDStatus)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.MillisecondsS)
        Me.Controls.Add(Me.TrackS)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.PTrackButton)
        Me.Controls.Add(Me.FTrackButton)
        Me.Controls.Add(Me.EjectButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ScreenBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "CDPlayer"
        Me.Text = "CD Player"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DiscToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutCDPlayer20ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents PauseButton As System.Windows.Forms.Button
    Friend WithEvents EjectButton As System.Windows.Forms.Button
    Friend WithEvents FTrackButton As System.Windows.Forms.Button
    Friend WithEvents PTrackButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents TrackS As System.Windows.Forms.Label
    Friend WithEvents ScreenBack As System.Windows.Forms.Label
    Friend WithEvents MillisecondsS As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CDStatus As System.Windows.Forms.Label
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondsS As System.Windows.Forms.Label
    Friend WithEvents MinutesS As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Colon1S As System.Windows.Forms.Label
    Friend WithEvents Colon2S As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
