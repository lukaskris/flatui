Imports Limilabs.FTP.Client
Imports MySql.Data.MySqlClient

Public Class Comment
    Dim lastObj As Bubble
    Dim mydb As New mySqlDB
    Dim lesson_id As String = ""
    Dim result As String = ""
    Dim user_id As String = ""
    Dim url As String = "127.0.0.1"
    Dim usernameFtp As String = "lukas"
    Dim passwordFtp As String = "admin"
    Dim dataset As New DataTable
    Private Sub Comment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Dim curtop As Integer = 10

    Sub addMessage(text As String, time As Date)
        Dim buble As Bubble = New Bubble()
        buble.build(text, time.ToString)
        If (lastObj Is Nothing) Then
            buble.Top = 10
        Else
            buble.Top = lastObj.Bottom + 10
        End If
        buble.Left = 10
        bottom_pic.Top = buble.Bottom + 10
        lastObj = buble
        curtop = buble.Bottom + 10
        Panel2.Controls.Add(buble)

        Panel2.VerticalScroll.Value = Panel2.VerticalScroll.Maximum
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        AddComment(BunifuMetroTextbox1.Text)
    End Sub

    Public Sub LoadComment(Key As String)
        Panel2.Controls.Clear()
        Try
            lesson_id = Key
            lastObj = Nothing
            If System.IO.File.Exists("LoginInfo.bin") Then
                Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
                Dim s As IO.Stream
                f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                s = New IO.FileStream("LoginInfo.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                Dim LoginInfo As LoginInfo = DirectCast(f.Deserialize(s), Object)
                s.Close()

                user_id = LoginInfo.Foreusername
            End If
            dataset = mydb.executeSQL("select * from comment where lesson_id=" + Key, result)
            If dataset.Rows.Count > 0 Then
                For Each row As DataRow In dataset.Rows
                    If row IsNot Nothing Then
                        addMessage(row("comment"), row("date"))
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AddComment(text As String)

        Dim newComment As New Comments
        newComment.Forecomment = text
        newComment.Foreuserid = user_id
        newComment.Foreid = Int(lesson_id)
        newComment.Foredate = Date.Now
        BunifuMetroTextbox1.Text = ""
        Try
            Using serverFtp As New Ftp
                serverFtp.Connect(url)
                serverFtp.Login(usernameFtp, passwordFtp)
                Dim sqlCommand As New MySqlCommand
                sqlCommand.Parameters.AddWithValue("@userid", newComment.Foreuserid)
                sqlCommand.Parameters.AddWithValue("@id", newComment.Foreid)
                sqlCommand.Parameters.AddWithValue("@comment", newComment.Forecomment)
                sqlCommand.Parameters.AddWithValue("@date", newComment.Foredate)
                mydb.executeDMLSQL("INSERT INTO COMMENT (USER_ID, LESSON_ID, COMMENT, DATE) values (@userid, @id, @comment, @date) ", sqlCommand, result)
                If (result = "SUCCESS") Then
                    addMessage(newComment.Forecomment, newComment.Foredate)
                    Console.WriteLine("Sukses add comment")
                Else
                    MessageBox.Show("Trouble adding comment, make sure your connection work")
                End If
                serverFtp.Close()

            End Using
        Catch ex As Exception
            Dim list As New List(Of Comments)

            Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim s As IO.Stream

            If System.IO.File.Exists("Comment.bin") Then
                F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                s = New IO.FileStream("Comment.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                list = DirectCast(F.Deserialize(s), Object)
                s.Close()
            End If


            list.Add(newComment)

            F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            s = New IO.FileStream("Comment.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
            F.Serialize(s, list)
            s.Close()
            MessageBox.Show("Komentar anda akan ditambahkan otomatis jika terhubung dengan jaringan lokal")
        End Try
    End Sub

    Private Sub BunifuMetroTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuMetroTextbox1.KeyDown
        If (e.KeyCode = 13 And Not BunifuMetroTextbox1.Text.ToString = "") Then
            AddComment(BunifuMetroTextbox1.Text)
        End If
    End Sub
End Class
