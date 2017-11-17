<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.errorNotif = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.loginBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.remember = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.password)
        Me.Panel2.Controls.Add(Me.ExitBtn)
        Me.Panel2.Controls.Add(Me.errorNotif)
        Me.Panel2.Controls.Add(Me.loginBtn)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Controls.Add(Me.remember)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.username)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(391, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 334)
        Me.Panel2.TabIndex = 6
        '
        'errorNotif
        '
        Me.errorNotif.AutoSize = True
        Me.errorNotif.ForeColor = System.Drawing.Color.Red
        Me.errorNotif.Location = New System.Drawing.Point(27, 119)
        Me.errorNotif.Name = "errorNotif"
        Me.errorNotif.Size = New System.Drawing.Size(0, 13)
        Me.errorNotif.TabIndex = 11
        '
        'loginBtn
        '
        Me.loginBtn.ActiveBorderThickness = 1
        Me.loginBtn.ActiveCornerRadius = 30
        Me.loginBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.loginBtn.ActiveForecolor = System.Drawing.Color.White
        Me.loginBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.loginBtn.BackColor = System.Drawing.SystemColors.Control
        Me.loginBtn.BackgroundImage = CType(resources.GetObject("loginBtn.BackgroundImage"), System.Drawing.Image)
        Me.loginBtn.ButtonText = "Login"
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.loginBtn.IdleBorderThickness = 1
        Me.loginBtn.IdleCornerRadius = 30
        Me.loginBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.loginBtn.IdleForecolor = System.Drawing.Color.White
        Me.loginBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.loginBtn.Location = New System.Drawing.Point(205, 261)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(88, 50)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(48, 244)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(92, 15)
        Me.BunifuCustomLabel2.TabIndex = 9
        Me.BunifuCustomLabel2.Text = "Rembember Me"
        '
        'remember
        '
        Me.remember.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.remember.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.remember.Checked = True
        Me.remember.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.remember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remember.ForeColor = System.Drawing.Color.White
        Me.remember.Location = New System.Drawing.Point(22, 241)
        Me.remember.Name = "remember"
        Me.remember.Size = New System.Drawing.Size(20, 20)
        Me.remember.TabIndex = 3
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(19, 31)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(137, 61)
        Me.BunifuCustomLabel1.TabIndex = 7
        Me.BunifuCustomLabel1.Text = "Login"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.HintText = "Username"
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.username.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.username.LineThickness = 3
        Me.username.Location = New System.Drawing.Point(22, 136)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(271, 33)
        Me.username.TabIndex = 1
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 334)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.FlatUI.My.Resources.Resources._20141031174145_15_free_online_learning_sites
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(391, 334)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageActive = Nothing
        Me.ExitBtn.Location = New System.Drawing.Point(277, 3)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(30, 27)
        Me.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitBtn.TabIndex = 8
        Me.ExitBtn.TabStop = False
        Me.ExitBtn.Zoom = 10
        '
        'password
        '
        Me.password.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.HintText = "Password"
        Me.password.isPassword = True
        Me.password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.password.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.password.LineThickness = 3
        Me.password.Location = New System.Drawing.Point(22, 186)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(271, 33)
        Me.password.TabIndex = 2
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 334)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents remember As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents loginBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents errorNotif As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ExitBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
