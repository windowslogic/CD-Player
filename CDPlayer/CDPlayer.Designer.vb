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
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCDPlayer20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MillisecondsS = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SecondsS = New System.Windows.Forms.Label()
        Me.MinutesS = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Colon1S = New System.Windows.Forms.Label()
        Me.Colon2S = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCDPlayer20ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutCDPlayer20ToolStripMenuItem
        '
        Me.AboutCDPlayer20ToolStripMenuItem.Name = "AboutCDPlayer20ToolStripMenuItem"
        Me.AboutCDPlayer20ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutCDPlayer20ToolStripMenuItem.Text = "About"
        '
        'TrackS
        '
        Me.TrackS.AutoSize = True
        Me.TrackS.BackColor = System.Drawing.Color.Black
        Me.TrackS.ForeColor = System.Drawing.Color.Lime
        Me.TrackS.Location = New System.Drawing.Point(50, 29)
        Me.TrackS.Name = "TrackS"
        Me.TrackS.Size = New System.Drawing.Size(41, 13)
        Me.TrackS.TabIndex = 9
        Me.TrackS.Text = "[00/00]"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 45)
        Me.Label2.TabIndex = 10
        '
        'MillisecondsS
        '
        Me.MillisecondsS.AutoSize = True
        Me.MillisecondsS.BackColor = System.Drawing.Color.Black
        Me.MillisecondsS.ForeColor = System.Drawing.Color.Lime
        Me.MillisecondsS.Location = New System.Drawing.Point(111, 50)
        Me.MillisecondsS.Name = "MillisecondsS"
        Me.MillisecondsS.Size = New System.Drawing.Size(19, 13)
        Me.MillisecondsS.TabIndex = 11
        Me.MillisecondsS.Text = "00"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(55, 74)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(67, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "CD Status: Please Insert CD"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(146, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Compact Player"
        Me.ToolTip1.SetToolTip(Me.Button5, "Widget" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Change the player to a small widget that can be quickly restored.")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(67, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 18)
        Me.Label7.TabIndex = 19
        '
        'SecondsS
        '
        Me.SecondsS.AutoSize = True
        Me.SecondsS.BackColor = System.Drawing.Color.Black
        Me.SecondsS.ForeColor = System.Drawing.Color.Lime
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
        Me.MinutesS.ForeColor = System.Drawing.Color.Lime
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
        Me.Colon1S.ForeColor = System.Drawing.Color.Lime
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
        Me.Colon2S.ForeColor = System.Drawing.Color.Lime
        Me.Colon2S.Location = New System.Drawing.Point(94, 50)
        Me.Colon2S.Name = "Colon2S"
        Me.Colon2S.Size = New System.Drawing.Size(10, 13)
        Me.Colon2S.TabIndex = 24
        Me.Colon2S.Text = ":"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.CD_Player.My.Resources.Resources.Play
        Me.Button8.Location = New System.Drawing.Point(146, 27)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 23)
        Me.Button8.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Button8, "Play" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plays the current CD.")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.CD_Player.My.Resources.Resources.PreviousTrack
        Me.Button6.Location = New System.Drawing.Point(146, 49)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 23)
        Me.Button6.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button6, "Skip Backward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Skip back a track on the current CD.")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.CD_Player.My.Resources.Resources.NextTrack
        Me.Button4.Location = New System.Drawing.Point(195, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 23)
        Me.Button4.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button4, "Skip Forward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Skip forward a track on the current CD.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(246, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button3, "Eject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Opens the CD drive so that you can change the CD.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.CD_Player.My.Resources.Resources.Pause
        Me.Button2.Location = New System.Drawing.Point(221, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button2, "Pause" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pauses the current CD.")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.CD_Player.My.Resources.Resources._Stop
        Me.Button1.Location = New System.Drawing.Point(246, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button1, "Stop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stops the CD. When on a track other than 1, you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can use the stop button" &
        " to restart the CD or click " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "twice to stop the CD fully.")
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.MillisecondsS)
        Me.Controls.Add(Me.TrackS)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TrackS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MillisecondsS As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SecondsS As System.Windows.Forms.Label
    Friend WithEvents MinutesS As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Colon1S As System.Windows.Forms.Label
    Friend WithEvents Colon2S As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
