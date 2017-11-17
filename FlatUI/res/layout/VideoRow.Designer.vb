<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoRow
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
        Me.CategoryRowImage = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lengthText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.totalView = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PersentaseWatch = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Descriptions = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Title = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CategoryRowDescription = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CategoryRowTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.CategoryRowImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CategoryRowImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(20, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 117)
        Me.Panel1.TabIndex = 2
        '
        'CategoryRowImage
        '
        Me.CategoryRowImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CategoryRowImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryRowImage.Image = Global.FlatUI.My.Resources.Resources._20141031174145_15_free_online_learning_sites
        Me.CategoryRowImage.Location = New System.Drawing.Point(0, 0)
        Me.CategoryRowImage.Name = "CategoryRowImage"
        Me.CategoryRowImage.Size = New System.Drawing.Size(113, 117)
        Me.CategoryRowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CategoryRowImage.TabIndex = 0
        Me.CategoryRowImage.TabStop = False
        Me.CategoryRowImage.WaitOnLoad = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lengthText)
        Me.Panel2.Controls.Add(Me.totalView)
        Me.Panel2.Controls.Add(Me.PersentaseWatch)
        Me.Panel2.Controls.Add(Me.Descriptions)
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Controls.Add(Me.CategoryRowDescription)
        Me.Panel2.Controls.Add(Me.CategoryRowTitle)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(20, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 117)
        Me.Panel2.TabIndex = 3
        '
        'lengthText
        '
        Me.lengthText.AutoSize = True
        Me.lengthText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lengthText.ForeColor = System.Drawing.SystemColors.Control
        Me.lengthText.Location = New System.Drawing.Point(315, 89)
        Me.lengthText.Name = "lengthText"
        Me.lengthText.Size = New System.Drawing.Size(52, 15)
        Me.lengthText.TabIndex = 6
        Me.lengthText.Text = "120 Min"
        '
        'totalView
        '
        Me.totalView.AutoSize = True
        Me.totalView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalView.ForeColor = System.Drawing.SystemColors.Control
        Me.totalView.Location = New System.Drawing.Point(225, 89)
        Me.totalView.Name = "totalView"
        Me.totalView.Size = New System.Drawing.Size(64, 15)
        Me.totalView.TabIndex = 5
        Me.totalView.Text = "12 Viewed"
        '
        'PersentaseWatch
        '
        Me.PersentaseWatch.AutoSize = True
        Me.PersentaseWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersentaseWatch.ForeColor = System.Drawing.SystemColors.Control
        Me.PersentaseWatch.Location = New System.Drawing.Point(128, 89)
        Me.PersentaseWatch.Name = "PersentaseWatch"
        Me.PersentaseWatch.Size = New System.Drawing.Size(74, 15)
        Me.PersentaseWatch.TabIndex = 4
        Me.PersentaseWatch.Text = "0% watched"
        '
        'Descriptions
        '
        Me.Descriptions.AutoSize = True
        Me.Descriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptions.ForeColor = System.Drawing.SystemColors.Control
        Me.Descriptions.Location = New System.Drawing.Point(128, 44)
        Me.Descriptions.Name = "Descriptions"
        Me.Descriptions.Size = New System.Drawing.Size(70, 15)
        Me.Descriptions.TabIndex = 3
        Me.Descriptions.Text = "12 Lessons"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(128, 12)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(39, 16)
        Me.Title.TabIndex = 2
        Me.Title.Text = "Title"
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
        'VideoRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "VideoRow"
        Me.Padding = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.Size = New System.Drawing.Size(601, 137)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CategoryRowImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CategoryRowImage As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CategoryRowDescription As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CategoryRowTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Descriptions As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Title As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents totalView As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PersentaseWatch As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lengthText As Bunifu.Framework.UI.BunifuCustomLabel
End Class
