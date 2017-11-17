<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryRow
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CategoryRowDescription = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CategoryRowTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CategoryRowImage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CategoryRowImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CategoryRowImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(20, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 108)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CategoryRowDescription)
        Me.Panel2.Controls.Add(Me.CategoryRowTitle)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(133, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 108)
        Me.Panel2.TabIndex = 1
        '
        'CategoryRowDescription
        '
        Me.CategoryRowDescription.AutoSize = True
        Me.CategoryRowDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryRowDescription.ForeColor = System.Drawing.SystemColors.Control
        Me.CategoryRowDescription.Location = New System.Drawing.Point(15, 44)
        Me.CategoryRowDescription.Name = "CategoryRowDescription"
        Me.CategoryRowDescription.Size = New System.Drawing.Size(70, 15)
        Me.CategoryRowDescription.TabIndex = 1
        Me.CategoryRowDescription.Text = "12 Lessons"
        '
        'CategoryRowTitle
        '
        Me.CategoryRowTitle.AutoSize = True
        Me.CategoryRowTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryRowTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.CategoryRowTitle.Location = New System.Drawing.Point(15, 12)
        Me.CategoryRowTitle.Name = "CategoryRowTitle"
        Me.CategoryRowTitle.Size = New System.Drawing.Size(39, 16)
        Me.CategoryRowTitle.TabIndex = 0
        Me.CategoryRowTitle.Text = "Title"
        '
        'CategoryRowImage
        '
        Me.CategoryRowImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CategoryRowImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryRowImage.Image = Global.FlatUI.My.Resources.Resources._20141031174145_15_free_online_learning_sites
        Me.CategoryRowImage.Location = New System.Drawing.Point(0, 0)
        Me.CategoryRowImage.Name = "CategoryRowImage"
        Me.CategoryRowImage.Size = New System.Drawing.Size(113, 108)
        Me.CategoryRowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CategoryRowImage.TabIndex = 0
        Me.CategoryRowImage.TabStop = False
        Me.CategoryRowImage.WaitOnLoad = True
        '
        'CategoryRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "CategoryRow"
        Me.Padding = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.Size = New System.Drawing.Size(558, 128)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CategoryRowImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CategoryRowTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CategoryRowDescription As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CategoryRowImage As PictureBox
End Class
