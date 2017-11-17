Public Class Player
    Dim firstVideo As String = ""
    Dim lessonKey As String = ""
    Dim oldVideo As New VideoView
    Dim curtop = 10
    Dim mydb As New mySqlDB
    Dim result As String = ""
    Dim lesson As Lesson
    Dim dataset As New DataTable
    Dim SUCCESS As String = "SUCCESS"
    Dim SERROR As String = "ERROR"

    Public Sub fillLeftPanel(Key As String)
        clearView()
        lessonKey = Key
        dataset = mydb.executeSQL("select * from sub_lesson where lesson_id=" + Key, result)
        If (result = SUCCESS) Then

            If dataset.Rows.Count > 0 Then
                For Each row As DataRow In dataset.Rows
                    If (curtop = 10) Then
                        firstVideo = row("id")
                        lesson = New Lesson
                        lesson.Foreid = row("id")
                        showVideo()
                    End If
                    addLastView(row("title"), row("thumbnail"), row("id"))
                Next
            End If
        Else

            Dim list As New List(Of Lesson)

            Dim F As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim s As IO.Stream

            If System.IO.File.Exists("Lesson.bin") Then
                s = New IO.FileStream("Lesson.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                list = DirectCast(F.Deserialize(s), Object)
                s.Close()
                Dim i As Integer = 0
                For Each item As Lesson In list
                    If (item.Foreid = Key) Then
                        For Each row As SubLesson In item.Foresublesson
                            If (i = 0) Then
                                firstVideo = row.Foreid
                                lesson = New Lesson
                                lesson.Foreid = row.Foreid
                                showVideo()
                            End If
                            addLastView(row.Foretitle, row.Forethumbnail, row.Foreid)
                            i += 1
                        Next
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub showVideo()
        PlayerMain1.loadVideo(firstVideo, lessonKey)

        Comment1.LoadComment(lessonKey)
    End Sub

    Private Sub clearView()
        LeftPanel.Controls.Clear()
        curtop = 10
    End Sub

    Private Sub addLastView(Title As String, Thumbnail As String, Id As String)
        Dim coba1 As VideoView = New VideoView()
        coba1.Top = curtop
        coba1.Left = 25
        coba1.Key = Integer.Parse(Id)
        coba1.BunifuCustomLabel1.Text = Title
        coba1.PictureBox1.ImageLocation = Thumbnail

        AddHandler coba1.PictureBox1.Click, AddressOf Me.VideoViewClick
        AddHandler coba1.BunifuCustomLabel1.Click, AddressOf Me.VideoViewClick
        LeftPanel.Controls.Add(coba1)
        curtop = coba1.Bottom + 10
    End Sub

    Private Sub VideoViewClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Handle your Button clicks here
        If TypeOf sender Is PictureBox Then
            Dim pic As PictureBox = sender
            For i As Integer = 0 To LeftPanel.Controls.Count Step 1
                If TypeOf LeftPanel.Controls.Item(i) Is VideoView Then
                    Dim video As VideoView = LeftPanel.Controls.Item(i)
                    If (video.PictureBox1.ImageLocation = pic.ImageLocation) Then
                        PlayerMain1.loadVideo(video.Key, lessonKey)
                        Comment1.LoadComment(video.Key)
                        Exit For
                    End If
                End If
                'PlayerMain1.loadVideo()
            Next

        Else
            Dim label As Label = sender
            For i As Integer = 0 To LeftPanel.Controls.Count Step 1
                If TypeOf LeftPanel.Controls.Item(i) Is VideoView Then
                    Dim video As VideoView = LeftPanel.Controls.Item(i)
                    If (video.BunifuCustomLabel1.Text = label.Text) Then
                        PlayerMain1.loadVideo(video.Key, lessonKey)
                        Comment1.LoadComment(video.Key)
                        Exit For
                    End If
                End If
                'PlayerMain1.loadVideo()
            Next
        End If

    End Sub

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.AutoScrollPosition = New Point(0, 0)
    End Sub
End Class
