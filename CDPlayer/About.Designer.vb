<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MoreButton = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VerInfo = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 127)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(121, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Licenced under GPL v3"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 150)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Contribute on GitHub"
        '
        'MoreButton
        '
        Me.MoreButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoreButton.Location = New System.Drawing.Point(360, 138)
        Me.MoreButton.Name = "MoreButton"
        Me.MoreButton.Size = New System.Drawing.Size(75, 23)
        Me.MoreButton.TabIndex = 8
        Me.MoreButton.Text = "More..."
        Me.MoreButton.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel3.LinkColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel3.Location = New System.Drawing.Point(247, 90)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(112, 13)
        Me.LinkLabel3.TabIndex = 10
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Software Agreement"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Copyright.Location = New System.Drawing.Point(21, 64)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(405, 52)
        Me.Copyright.TabIndex = 9
        Me.Copyright.Text = "CD Player is Copyright © 2022 WindowsLogic Productions. All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" &
    "his product is licensed under the                                      to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%use" &
    "r%"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.VerInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 53)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CD_Player.My.Resources.Resources.CDPlayer
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'VerInfo
        '
        Me.VerInfo.AutoSize = True
        Me.VerInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerInfo.Location = New System.Drawing.Point(50, 11)
        Me.VerInfo.Name = "VerInfo"
        Me.VerInfo.Size = New System.Drawing.Size(202, 30)
        Me.VerInfo.TabIndex = 2
        Me.VerInfo.Text = "%appname% %ver%"
        Me.VerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(279, 138)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 173)
        Me.Controls.Add(Me.MoreButton)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About CD Player"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents MoreButton As Button
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Copyright As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents VerInfo As Label
    Friend WithEvents OKButton As Button
End Class
