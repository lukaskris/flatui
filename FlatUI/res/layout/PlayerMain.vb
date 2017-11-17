Public Class PlayerMain

    Dim mydb As New mySqlDB
    Dim result As String = ""
    Dim dataset As New DataTable
    Dim url As String = ""
    Dim dataDirectory As String
    Dim encrypt As New EncryptionModule
    Dim prefVideo As String = ""
    Dim sublesson As SubLesson

    Dim SUCCESS As String = "SUCCESS"
    Dim SERROR As String = "ERROR"

    Private Sub PlayerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataDirectory = String.Format("{0}\resource\video\", Environment.CurrentDirectory)
    End Sub

    Public Sub loadVideo(Key As String, LessonKey As String)

        dataset = mydb.executeSQL("select * from sub_lesson where id=" + Key, result)
        If (result = SUCCESS) Then
            If dataset.Rows.Count > 0 Then
                For Each row As DataRow In dataset.Rows
                    BunifuCustomLabel2.Text = row("title")
                    url = row("src")
                    sublesson = New SubLesson
                    sublesson.Foreid = row("id")
                    sublesson.Forelessonid = row("lesson_id")
                    sublesson.Foresrc = row("src")
                    sublesson.Forethumbnail = row("thumbnail")
                    sublesson.Foretitle = row("title")
                    If dataDirectory Is Nothing Then
                        dataDirectory = String.Format("{0}\resource\video\", Environment.CurrentDirectory)
                    End If
                    CheckFIleExists(dataDirectory + url)
                    IncrementWatch()
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
                For Each item As Lesson In list
                    If (item.Foreid = LessonKey) Then
                        For Each item2 As SubLesson In item.Foresublesson
                            If (item2.Foreid = Key) Then
                                sublesson = item2
                                If dataDirectory Is Nothing Then
                                    dataDirectory = String.Format("{0}\resource\video\", Environment.CurrentDirectory)
                                End If
                                CheckFIleExists(dataDirectory + sublesson.Foresrc)

                            End If
                        Next
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub IncrementWatch()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveCache(Key As String)
        Try
            Dim list As New List(Of Lesson)

            Dim F As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim s As IO.Stream

            If System.IO.File.Exists("Lesson.bin") Then
                s = New IO.FileStream("Lesson.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                list = DirectCast(F.Deserialize(s), Object)
                s.Close()
                Dim ceksama As Boolean = False
                For Each item As Lesson In list
                    If (item.Foreid = Key) Then
                        ceksama = True
                        item.Foresublesson.Add(sublesson)
                    End If
                Next
                If (Not ceksama) Then
                    dataset = mydb.executeSQL("select * from lesson where id=" + Key, result)

                    If dataset.Rows.Count > 0 Then
                        For Each row As DataRow In dataset.Rows
                            Dim lesson = New Lesson
                            lesson.Foreid = row("id")
                            lesson.Foredescription = row("description")
                            lesson.Forethumbnail = row("thumbnail")
                            lesson.Foreview = row("view")
                            lesson.Forelength = row("length")

                            Dim sublessons As New List(Of SubLesson)
                            sublessons.Add(sublesson)
                            lesson.Foresublesson = sublessons
                            list.Add(lesson)
                        Next
                    End If
                    F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                    s = New IO.FileStream("Lesson.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
                    F.Serialize(s, list)
                    s.Close()
                End If


            Else
                dataset = mydb.executeSQL("select * from lesson where id=" + Key, result)

                If dataset.Rows.Count > 0 Then
                    For Each row As DataRow In dataset.Rows
                        Dim lesson = New Lesson
                        lesson.Foreid = row("id")
                        lesson.Foretitle = row("title")
                        lesson.Foredescription = row("description")
                        lesson.Forethumbnail = row("thumbnail")
                        lesson.Foreview = row("view")
                        lesson.Forelength = row("length")
                        lesson.Foretotal = row("total_sublesson")
                        lesson.Forefilesize = row("filesize")
                        Dim sublessons As New List(Of SubLesson)
                        sublessons.Add(sublesson)
                        lesson.Foresublesson = sublessons
                        list.Add(lesson)
                    Next
                End If
                F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                s = New IO.FileStream("Lesson.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
                F.Serialize(s, list)
                s.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim formDownload As New Downloader
        formDownload.setDownloadFile(url, dataDirectory + url)
        formDownload.ShowDialog()
        MessageBox.Show("Download Complete")

        SaveCache(sublesson.Forelessonid)
        CheckFIleExists(dataDirectory + url)
    End Sub

    Public Sub CheckFIleExists(Url As String)
        Try
            If My.Computer.FileSystem.FileExists(Url) Then
                BunifuThinButton21.Hide()
                Dim key As Byte()
                Dim IV As Byte()
                key = encrypt.CreateKey("arnannata")
                IV = encrypt.CreateIV("arnannata")
                Dim output As String = Url.Replace(".stts", ".mp4")
                encrypt.EncryptOrDecryptFile(Url, output, key, IV, encrypt.CryptoAction.ActionDecrypt)
                Dim path As String = output.Replace("\", "/")
                AxVLCPlugin21.playlist.add("file:///" & path)
                AxVLCPlugin21.AutoPlay = True
            Else
                BunifuThinButton21.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("File not found, please redownload this video again")
        End Try
    End Sub

    Public Sub DeleteFileDecrypt(Url As String)
        If My.Computer.FileSystem.FileExists(Url) Then
            My.Computer.FileSystem.DeleteFile(Url)
        End If
    End Sub
End Class
