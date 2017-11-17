<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Player
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Comment1 = New FlatUI.Comment()
        Me.PlayerMain1 = New FlatUI.PlayerMain()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LeftPanel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 315)
        Me.Panel1.TabIndex = 0
        '
        'LeftPanel
        '
        Me.LeftPanel.AutoScroll = True
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftPanel.Location = New System.Drawing.Point(0, 56)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(215, 259)
        Me.LeftPanel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 56)
        Me.Panel2.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(16, 18)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(170, 20)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Continous Watching"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.MainPanel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(215, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 315)
        Me.Panel4.TabIndex = 1
        '
        'MainPanel
        '
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.Comment1)
        Me.MainPanel.Controls.Add(Me.PlayerMain1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.MainPanel.Size = New System.Drawing.Size(322, 315)
        Me.MainPanel.TabIndex = 1
        '
        'Comment1
        '
        Me.Comment1.AutoSize = True
        Me.Comment1.BackColor = System.Drawing.Color.Transparent
        Me.Comment1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Comment1.Location = New System.Drawing.Point(0, 630)
        Me.Comment1.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.Comment1.Name = "Comment1"
        Me.Comment1.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Comment1.Size = New System.Drawing.Size(305, 581)
        Me.Comment1.TabIndex = 2
        '
        'PlayerMain1
        '
        Me.PlayerMain1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PlayerMain1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PlayerMain1.Location = New System.Drawing.Point(0, 30)
        Me.PlayerMain1.MaximumSize = New System.Drawing.Size(0, 750)
        Me.PlayerMain1.Name = "PlayerMain1"
        Me.PlayerMain1.Size = New System.Drawing.Size(305, 600)
        Me.PlayerMain1.TabIndex = 1
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Player"
        Me.Size = New System.Drawing.Size(537, 315)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents PlayerMain1 As PlayerMain
    Friend WithEvents Comment1 As Comment
End Class
