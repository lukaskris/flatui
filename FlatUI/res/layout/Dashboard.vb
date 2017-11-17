Public Class Dashboard
    Dim oldVideo As VideoView = New VideoView()
    Dim curleft = 10
    Dim ListNewVideo As New ArrayList
    Dim ListSavedCourse As New ArrayList
    Dim mydb As New mySqlDB
    Dim result As String = ""
    Dim dataset As New DataTable

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataset = mydb.executeSQL("select * from lesson order by id desc Limit 5", result)
        If dataset.Rows.Count > 0 Then
            For Each row As DataRow In dataset.Rows
                Dim lesson As New Lesson
                lesson.Foreid = row("id")
                lesson.Forethumbnail = row("thumbnail")
                lesson.Foretitle = row("title")
                ListNewVideo.Add(lesson)
                addLastView(Panel6, row("id"), row("title"), row("thumbnail"), ListNewVideo.Count)
            Next
        End If


        If System.IO.File.Exists("Lesson.bin") Then
            Using s As IO.Stream = New IO.FileStream("Lesson.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                Dim list As New List(Of Lesson)
                Dim F As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

                list = DirectCast(F.Deserialize(s), Object)
                s.Close()

                For Each item As Lesson In list

                    Dim lesson As New Lesson
                    lesson.Foreid = item.Foreid
                    lesson.Forethumbnail = item.Forethumbnail
                    lesson.Foretitle = item.Foretitle
                    ListSavedCourse.Add(lesson)
                    addLastView(Panel4, item.Foreid, item.Foretitle, item.Forethumbnail, ListSavedCourse.Count)
                Next
            End Using
        End If
    End Sub

    Private Sub addLastView(Panel As Panel, LessonId As Integer, Title As String, Thumbnail As String, Size As Integer)
        Dim coba1 As VideoView = New VideoView()
        coba1.Location = oldVideo.Location
        coba1.Anchor = AnchorStyles.Left
        coba1.SetId(LessonId)
        coba1.BunifuCustomLabel1.Text = Title
        coba1.PictureBox1.ImageLocation = Thumbnail
        coba1.Top = 20
        If (Size >= 1) Then
            coba1.Left = 10
        End If
        coba1.Left += (Size - 1) * coba1.Width + (Size * 10)

        curleft = coba1.Right + 10
        AddHandler coba1.PictureBox1.Click, AddressOf Me.PictureVideoViewClick
        AddHandler coba1.BunifuCustomLabel1.Click, AddressOf Me.VideoViewClick
        Panel.Controls.Add(coba1)
        oldVideo = coba1
    End Sub

    Private Sub PictureVideoViewClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim picturebox As PictureBox = sender

        For Each row As Lesson In ListNewVideo
            If (row.Forethumbnail = picturebox.ImageLocation) Then

                Dim Parent As Form1 = Me.Parent.Parent
                Parent.Visible = False

                Dim form As New Form2
                form.ShowVideo(row.Foreid)
                form.ShowDialog()
                Parent.Visible = True
            End If
        Next


        For Each row As Lesson In ListSavedCourse
            If (row.Forethumbnail = picturebox.ImageLocation) Then

                Dim Parent As Form1 = Me.Parent.Parent
                Parent.Visible = False
                Dim form As New Form2
                form.ShowVideo(row.Foreid)
                form.ShowDialog()
                Parent.Visible = True
            End If
        Next
    End Sub

    Private Sub VideoViewClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Handle your Button clicks here
        Dim label As Label = sender
        For Each row As Lesson In ListNewVideo
            If (row.Foretitle = label.Text) Then

                Dim Parent As Form1 = Me.Parent.Parent
                Parent.Visible = False
                Dim form As New Form2
                form.ShowVideo(row.Foreid)
                form.ShowDialog()
                Parent.Visible = True
            End If
        Next

    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click
        My.Forms.Form1.ShowVideoList(0)
    End Sub

    Private Sub BunifuCustomLabel6_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.Click
        My.Forms.Form1.ShowVideoList(2)
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click
        My.Forms.Form1.ShowVideoList(1)
    End Sub
End Class
