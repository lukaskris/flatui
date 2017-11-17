<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Downloader
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
        Me.hidebutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.progressbar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.filesize = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.filedownload = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.percentage = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.speed = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hidebutton
        '
        Me.hidebutton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.hidebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.hidebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hidebutton.BorderRadius = 0
        Me.hidebutton.ButtonText = "Hide"
        Me.hidebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hidebutton.DisabledColor = System.Drawing.Color.Gray
        Me.hidebutton.Dock = System.Windows.Forms.DockStyle.Right
        Me.hidebutton.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!)
        Me.hidebutton.Iconcolor = System.Drawing.Color.Transparent
        Me.hidebutton.Iconimage = Nothing
        Me.hidebutton.Iconimage_right = Nothing
        Me.hidebutton.Iconimage_right_Selected = Nothing
        Me.hidebutton.Iconimage_Selected = Nothing
        Me.hidebutton.IconMarginLeft = 0
        Me.hidebutton.IconMarginRight = 0
        Me.hidebutton.IconRightVisible = True
        Me.hidebutton.IconRightZoom = 0R
        Me.hidebutton.IconVisible = True
        Me.hidebutton.IconZoom = 90.0R
        Me.hidebutton.IsTab = True
        Me.hidebutton.Location = New System.Drawing.Point(223, 0)
        Me.hidebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.hidebutton.Name = "hidebutton"
        Me.hidebutton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.hidebutton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hidebutton.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.hidebutton.selected = False
        Me.hidebutton.Size = New System.Drawing.Size(110, 51)
        Me.hidebutton.TabIndex = 4
        Me.hidebutton.Text = "Hide"
        Me.hidebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hidebutton.Textcolor = System.Drawing.Color.White
        Me.hidebutton.TextFont = New System.Drawing.Font("Segoe UI", 9.75!)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.hidebutton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 51)
        Me.Panel1.TabIndex = 5
        '
        'progressbar
        '
        Me.progressbar.BackColor = System.Drawing.Color.Silver
        Me.progressbar.BorderRadius = 5
        Me.progressbar.Location = New System.Drawing.Point(24, 116)
        Me.progressbar.MaximumValue = 100
        Me.progressbar.Name = "progressbar"
        Me.progressbar.ProgressColor = System.Drawing.Color.Teal
        Me.progressbar.Size = New System.Drawing.Size(286, 10)
        Me.progressbar.TabIndex = 6
        Me.progressbar.Value = 0
        '
        'filesize
        '
        Me.filesize.AutoSize = True
        Me.filesize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filesize.Location = New System.Drawing.Point(113, 31)
        Me.filesize.Name = "filesize"
        Me.filesize.Size = New System.Drawing.Size(62, 13)
        Me.filesize.TabIndex = 7
        Me.filesize.Text = "100000 MB"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(21, 31)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(46, 13)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "File Size"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(21, 56)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(67, 13)
        Me.BunifuCustomLabel3.TabIndex = 9
        Me.BunifuCustomLabel3.Text = "Downloaded"
        '
        'filedownload
        '
        Me.filedownload.AutoSize = True
        Me.filedownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.filedownload.Location = New System.Drawing.Point(113, 56)
        Me.filedownload.Name = "filedownload"
        Me.filedownload.Size = New System.Drawing.Size(62, 13)
        Me.filedownload.TabIndex = 10
        Me.filedownload.Text = "100000 MB"
        '
        'percentage
        '
        Me.percentage.AutoSize = True
        Me.percentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.percentage.Location = New System.Drawing.Point(181, 56)
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(39, 13)
        Me.percentage.TabIndex = 11
        Me.percentage.Text = "( 10% )"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(21, 87)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(38, 13)
        Me.BunifuCustomLabel6.TabIndex = 12
        Me.BunifuCustomLabel6.Text = "Speed"
        '
        'speed
        '
        Me.speed.AutoSize = True
        Me.speed.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.speed.Location = New System.Drawing.Point(113, 87)
        Me.speed.Name = "speed"
        Me.speed.Size = New System.Drawing.Size(38, 13)
        Me.speed.TabIndex = 13
        Me.speed.Text = "0 kb/s"
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(333, 205)
        Me.Controls.Add(Me.speed)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.percentage)
        Me.Controls.Add(Me.filedownload)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.filesize)
        Me.Controls.Add(Me.progressbar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Downloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloader"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hidebutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents filesize As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents filedownload As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents percentage As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents speed As Bunifu.Framework.UI.BunifuCustomLabel
    Protected WithEvents progressbar As Bunifu.Framework.UI.BunifuProgressBar
End Class
