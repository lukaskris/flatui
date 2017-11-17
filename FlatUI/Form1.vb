Imports System.Threading
Imports Limilabs.FTP.Client
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim username As String
    Private m_SyncContext As System.Threading.SynchronizationContext
    Dim url As String = "127.0.0.1"
    Dim usernameFtp As String = "lukas"
    Dim passwordFtp As String = "admin"
    Dim threadForConnectTFTP As Thread
    Dim newThread As Thread
    Dim isConnect As Boolean
    Dim ListComment As List(Of Comments)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.m_SyncContext = System.Threading.SynchronizationContext.Current
        threadForConnectTFTP = New Thread(AddressOf TestAsynrhonus)
        'threadForConnectTFTP.IsBackground = True
        isConnect = False
        threadForConnectTFTP.Start()

        newThread = New Thread(AddressOf printThread)
        newThread.Start()
    End Sub

    Sub printThread()
        While (True)
            loadComments()
            If (Not IsNothing(ListComment)) Then
                If (ListComment.Count > 0) Then
                    TestAsynrhonus()
                End If

            End If
            Thread.Sleep(10000)
        End While
    End Sub

    Sub TestAsynrhonus()
        Thread.Sleep(1000)

        postSavedComment()
        If Not isConnect Then
            Try
                Using serverFtp As New Ftp
                    Me.m_SyncContext.Post(AddressOf UpdateTextBox, "Connecting...")
                    serverFtp.Connect(url)
                    serverFtp.Login(usernameFtp, passwordFtp)
                    Me.m_SyncContext.Post(AddressOf UpdateTextBox, "Connected")
                    serverFtp.Close()
                    isConnect = True
                End Using
            Catch ex As Exception
                isConnect = False
                Me.m_SyncContext.Post(AddressOf UpdateTextBox, "Not Connected to Ftp")
                Console.WriteLine("Error in ServiceFTP : ", ex.ToString)
            End Try
            'TestAsynrhonus()
        End If
    End Sub

    Sub loadComments()
        If (System.IO.File.Exists("Comment.bin")) Then
            Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim s As IO.Stream

            f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            s = New IO.FileStream("Comment.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)

            ListComment = New List(Of Comments)
            ListComment = DirectCast(f.Deserialize(s), Object)
            If (ListComment Is Nothing) Then
                ListComment = New List(Of Comments)
            End If
            s.Close()
        End If
    End Sub

    Sub postSavedComment()
        Try
            If System.IO.File.Exists("Comment.bin") Then
                Dim mydb As New mySqlDB
                Dim result As String = ""

                loadComments()
                'f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                's = New IO.FileStream("LoginInfo.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)

                'ListComment = New List(Of Comments)
                'ListComment = DirectCast(f.Deserialize(s), Object)
                's.Close()

                For Each comment As Comments In ListComment
                    Dim sqlCommand As New MySqlCommand
                    sqlCommand.Parameters.AddWithValue("@userid", comment.Foreuserid)
                    sqlCommand.Parameters.AddWithValue("@id", comment.Foreid)
                    sqlCommand.Parameters.AddWithValue("@comment", comment.Forecomment)
                    sqlCommand.Parameters.AddWithValue("@date", comment.Foredate)
                    mydb.executeDMLSQL("INSERT INTO COMMENT (USER_ID, LESSON_ID, COMMENT, DATE) values (@userid, @id, @comment, @date) ", sqlCommand, result)
                    If (result = "SUCCESS") Then
                        System.IO.File.Delete("Comment.bin")
                        Console.WriteLine("Sukses add comment")
                    End If
                Next

            End If
        Catch ex As Exception


        End Try

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Dashboard1.Visible = False
        Dashboard1.BringToFront()
        BunifuTransition1.ShowSync(Dashboard1)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        CategoryList1.Visible = False
        CategoryList1.BringToFront()
        BunifuTransition1.ShowSync(CategoryList1)
    End Sub

    Public Sub ShowVideoList(type As Integer)
        VideoList1.Visible = False
        VideoList1.BringToFront()
        VideoList1.SetVideoType(type)
        BunifuTransition1.ShowSync(VideoList1)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        SavedCourseList1.Visible = False
        SavedCourseList1.BringToFront()
        BunifuTransition1.ShowSync(SavedCourseList1)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

    End Sub

    Public Sub SetUsername(user As String)
        username = user
        nameLabel.Text = username
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            BunifuElipse1.ElipseRadius = 0
        Else
            Me.WindowState = FormWindowState.Normal
            BunifuElipse1.ElipseRadius = 7
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateTextBox(param As Object)
        If (TypeOf (param) Is String) Then
            Me.Status.Text = CStr(param)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        newThread.Abort()
    End Sub
End Class
