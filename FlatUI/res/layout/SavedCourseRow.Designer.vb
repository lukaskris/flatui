<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SavedCourseRow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SavedCourseRow))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SavedCourseRowDescription = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SavedCourseRowTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SavedCourseImage = New System.Windows.Forms.PictureBox()
        Me.SavedCourseRowDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SavedCourseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedCourseRowDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.SavedCourseRowDelete)
        Me.Panel2.Controls.Add(Me.SavedCourseRowDescription)
        Me.Panel2.Controls.Add(Me.SavedCourseRowTitle)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(133, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 108)
        Me.Panel2.TabIndex = 3
        '
        'SavedCourseRowDescription
        '
        Me.SavedCourseRowDescription.AutoSize = True
        Me.SavedCourseRowDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavedCourseRowDescription.ForeColor = System.Drawing.SystemColors.Control
        Me.SavedCourseRowDescription.Location = New System.Drawing.Point(15, 44)
        Me.SavedCourseRowDescription.Name = "SavedCourseRowDescription"
        Me.SavedCourseRowDescription.Size = New System.Drawing.Size(70, 15)
        Me.SavedCourseRowDescription.TabIndex = 1
        Me.SavedCourseRowDescription.Text = "12 Lessons"
        '
        'SavedCourseRowTitle
        '
        Me.SavedCourseRowTitle.AutoSize = True
        Me.SavedCourseRowTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavedCourseRowTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.SavedCourseRowTitle.Location = New System.Drawing.Point(15, 12)
        Me.SavedCourseRowTitle.Name = "SavedCourseRowTitle"
        Me.SavedCourseRowTitle.Size = New System.Drawing.Size(39, 16)
        Me.SavedCourseRowTitle.TabIndex = 0
        Me.SavedCourseRowTitle.Text = "Title"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SavedCourseImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(20, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 108)
        Me.Panel1.TabIndex = 2
        '
        'SavedCourseImage
        '
        Me.SavedCourseImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SavedCourseImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SavedCourseImage.Image = Global.FlatUI.My.Resources.Resources._20141031174145_15_free_online_learning_sites
        Me.SavedCourseImage.Location = New System.Drawing.Point(0, 0)
        Me.SavedCourseImage.Name = "SavedCourseImage"
        Me.SavedCourseImage.Size = New System.Drawing.Size(113, 108)
        Me.SavedCourseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SavedCourseImage.TabIndex = 1
        Me.SavedCourseImage.TabStop = False
        Me.SavedCourseImage.WaitOnLoad = True
        '
        'SavedCourseRowDelete
        '
        Me.SavedCourseRowDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SavedCourseRowDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.SavedCourseRowDelete.Image = CType(resources.GetObject("SavedCourseRowDelete.Image"), System.Drawing.Image)
        Me.SavedCourseRowDelete.ImageActive = Nothing
        Me.SavedCourseRowDelete.Location = New System.Drawing.Point(377, 0)
        Me.SavedCourseRowDelete.Name = "SavedCourseRowDelete"
        Me.SavedCourseRowDelete.Size = New System.Drawing.Size(38, 108)
        Me.SavedCourseRowDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SavedCourseRowDelete.TabIndex = 3
        Me.SavedCourseRowDelete.TabStop = False
        Me.SavedCourseRowDelete.Zoom = 10
        '
        'SavedCourseRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SavedCourseRow"
        Me.Padding = New System.Windows.Forms.Padding(20, 10, 10, 10)
        Me.Size = New System.Drawing.Size(558, 128)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.SavedCourseImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedCourseRowDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents SavedCourseRowDescription As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SavedCourseRowTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SavedCourseImage As PictureBox
    Friend WithEvents SavedCourseRowDelete As Bunifu.Framework.UI.BunifuImageButton
End Class
