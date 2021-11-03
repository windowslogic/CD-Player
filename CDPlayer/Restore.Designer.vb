<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NormalButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.FTrackButton = New System.Windows.Forms.Button()
        Me.PTrackButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CD Player is currently open or playing a CD."
        '
        'NormalButton
        '
        Me.NormalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NormalButton.Location = New System.Drawing.Point(12, 19)
        Me.NormalButton.Name = "NormalButton"
        Me.NormalButton.Size = New System.Drawing.Size(239, 23)
        Me.NormalButton.TabIndex = 1
        Me.NormalButton.Text = "Normal Player"
        Me.NormalButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PauseButton.Image = Global.CD_Player.My.Resources.Resources.Pause
        Me.PauseButton.Location = New System.Drawing.Point(58, 48)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(47, 23)
        Me.PauseButton.TabIndex = 6
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'FTrackButton
        '
        Me.FTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FTrackButton.Image = Global.CD_Player.My.Resources.Resources.NextTrack
        Me.FTrackButton.Location = New System.Drawing.Point(204, 48)
        Me.FTrackButton.Name = "FTrackButton"
        Me.FTrackButton.Size = New System.Drawing.Size(47, 23)
        Me.FTrackButton.TabIndex = 5
        Me.FTrackButton.UseVisualStyleBackColor = True
        '
        'PTrackButton
        '
        Me.PTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PTrackButton.Image = Global.CD_Player.My.Resources.Resources.PreviousTrack
        Me.PTrackButton.Location = New System.Drawing.Point(158, 48)
        Me.PTrackButton.Name = "PTrackButton"
        Me.PTrackButton.Size = New System.Drawing.Size(47, 23)
        Me.PTrackButton.TabIndex = 4
        Me.PTrackButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Image = Global.CD_Player.My.Resources.Resources._Stop
        Me.StopButton.Location = New System.Drawing.Point(108, 48)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(47, 23)
        Me.StopButton.TabIndex = 3
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Image = Global.CD_Player.My.Resources.Resources.Play
        Me.PlayButton.Location = New System.Drawing.Point(12, 48)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(47, 23)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 78)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.FTrackButton)
        Me.Controls.Add(Me.PTrackButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.NormalButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Restore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compact CD Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NormalButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents PTrackButton As System.Windows.Forms.Button
    Friend WithEvents FTrackButton As System.Windows.Forms.Button
    Friend WithEvents PauseButton As System.Windows.Forms.Button
End Class
