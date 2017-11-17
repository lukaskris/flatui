Imports System.Threading
Imports Limilabs.FTP.Client
Public NotInheritable Class ServiceFTP
    Private Shared ReadOnly _instance As New Lazy(Of ServiceFTP)(Function() New ServiceFTP(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    WithEvents serverFtp As New Ftp
    Dim url As String = "127.0.0.1"
    Dim username As String = "lukas"
    Dim password As String = "admin"
    Dim connect As Boolean

    Public Sub New()
        serverFtp = New Ftp
        connect = False
        Connecting()
    End Sub

    Public Shared ReadOnly Property Instance() As ServiceFTP
        Get
            Return _instance.Value
        End Get
    End Property

    Public Function GetFtp() As Ftp
        Return serverFtp
    End Function

    Public Function GetUrl() As String
        Return url
    End Function

    Public Function IsConnect() As Boolean
        Return connect
    End Function

    Public Sub Reconnect()
        Connecting()
    End Sub

    Private Sub Connecting()
        Dim thread As New Thread(
            Sub()
                Try
                    serverFtp.Connect(url)
                    serverFtp.Login(username, password)
                    connect = True
                Catch ex As Exception
                    Console.WriteLine("Error in ServiceFTP : ", ex.ToString)
                End Try

            End Sub
        )
        thread.Start()

    End Sub


End Class
