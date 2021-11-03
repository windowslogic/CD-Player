<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediaPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediaPlayer))
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(-1, 27)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(635, 384)
        Me.AxWindowsMediaPlayer2.TabIndex = 15
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMediaToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenMediaToolStripMenuItem
        '
        Me.OpenMediaToolStripMenuItem.Name = "OpenMediaToolStripMenuItem"
        Me.OpenMediaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OpenMediaToolStripMenuItem.Text = "Open media..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(518, 417)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.TrackBar1, "Volume")
        Me.TrackBar1.Value = 50
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.CD_Player.My.Resources.Resources.Mute
        Me.Button6.Location = New System.Drawing.Point(486, 417)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(26, 23)
        Me.Button6.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button6, "Mute")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.CD_Player.My.Resources.Resources.Unmute
        Me.Button5.Location = New System.Drawing.Point(486, 417)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 23)
        Me.Button5.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Button5, "Unmute")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.CD_Player.My.Resources.Resources.NextTrack
        Me.Button4.Location = New System.Drawing.Point(108, 417)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(26, 23)
        Me.Button4.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Button4, "Next")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.CD_Player.My.Resources.Resources.PreviousTrack
        Me.Button3.Location = New System.Drawing.Point(76, 417)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Button3, "Previous")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.CD_Player.My.Resources.Resources._Stop
        Me.Button2.Location = New System.Drawing.Point(44, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Button2, "Stop")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.CD_Player.My.Resources.Resources.Play
        Me.Button1.Location = New System.Drawing.Point(12, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Button1, "Play")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.CD_Player.My.Resources.Resources.Pause
        Me.Button13.Location = New System.Drawing.Point(12, 417)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(26, 23)
        Me.Button13.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Button13, "Pause")
        Me.Button13.UseVisualStyleBackColor = True
        '
        'MediaPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 452)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MediaPlayer"
        Me.Text = "WLP Media Suite - Media Player"
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenMediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
