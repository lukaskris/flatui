Imports Limilabs.FTP.Client
Imports System.Threading
Public Class Downloader

    Private m_SyncContext As System.Threading.SynchronizationContext
    Dim url As String = "127.0.0.1"
    Dim usernameFtp As String = "lukas"
    Dim passwordFtp As String = "admin"

    Dim kilobyte As Double = 2 ^ 10
    Dim megabyte As Double = 2 ^ 20
    Dim gigabyte As Double = 2 ^ 30
    Dim speedPerSecond As Double
    Dim lastTransferByte As Double
    Dim countThread As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lastTransferByte = 0
        speedPerSecond = 0
        countThread = 0
        Me.m_SyncContext = System.Threading.SynchronizationContext.Current
    End Sub

    Private Sub hidebutton_Click(sender As Object, e As EventArgs) Handles hidebutton.Click
        Me.Hide()
    End Sub

    Private Sub Downloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub handlerDownload(sender As Object, e As ProgressEventArgs)
        Me.m_SyncContext.Post(AddressOf UpdatePercentage, e.Percentage)
        Me.m_SyncContext.Post(AddressOf UpdateFilesize, e.TotalBytesToTransfer)
        Me.m_SyncContext.Post(AddressOf UpdateFiledownload, e.TotalBytesTransferred)
        Thread.Sleep(10)
        'Me.BeginInvoke(DirectCast(
        '   Sub()
        'percentage.Text = "( " + e.Percentage.ToString + " )"


        'filesize.Text = translateByteToString(e.TotalBytesToTransfer)
        'filedownload.Text = translateByteToString(e.TotalBytesTransferred)
        'lastTransferByte = e.TotalBytesToTransfer - lastTransferByte
        'speed.Text = translateByteToString(lastTransferByte)
        'If (percentage.Equals(100)) Then
        'lastTransferByte = 0
        'End If

        'End Sub, MethodInvoker))

    End Sub

    Public Sub setDownloadFile(url As String, path As String)
        Dim thread As New Thread(
            Sub()
                Try
                    Using serverFtp As New Ftp
                        serverFtp.Connect(Me.url)
                        serverFtp.Login(usernameFtp, passwordFtp)
                        AddHandler serverFtp.Progress, AddressOf Me.handlerDownload
                        serverFtp.Download(url, path)
                        serverFtp.Close()
                    End Using
                Catch ex As Exception
                    Console.WriteLine("Error in ServiceFTP : ", ex.ToString)
                    'MessageBox.Show("Not Connected")
                End Try

            End Sub
        )
        thread.Start()
    End Sub

    Private Sub UpdatePercentage(param As Object)
        Me.progressbar.Value = CInt(param)
        Me.percentage.Text = "( " + CStr(CDbl(param)) + "% )"
        If (CInt(param).Equals(100)) Then
            lastTransferByte = 0
            Me.Close()
        End If
    End Sub

    Private Sub UpdateFilesize(param As Object)
        Me.filesize.Text = translateByteToString(CDbl(param))
    End Sub

    Private Sub UpdateFiledownload(param As Object)
        countThread += 1
        speedPerSecond = CDbl(param) - lastTransferByte + speedPerSecond
        lastTransferByte = CDbl(param)
        Me.filedownload.Text = translateByteToString(CDbl(param))

        If countThread = 10 Then
            Me.speed.Text = translateByteToString(speedPerSecond)
            countThread = 0
            speedPerSecond = 0
        End If
    End Sub

    Private Function translateByteToString(data As Double)
        If data >= gigabyte Then
            Dim temp As Double = data / gigabyte
            Return temp.ToString + " Gb"
        ElseIf data >= megabyte Then
            Dim temp As Double = data / megabyte
            Return temp.ToString + " Mb"
        ElseIf data >= kilobyte Then
            Dim temp As Double = data / kilobyte
            Return temp.ToString + " Kb"
        Else
            Return data.ToString + " byte"
        End If
    End Function

End Class