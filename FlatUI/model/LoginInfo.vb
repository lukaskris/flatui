<Serializable()>
Public Class LoginInfo
    Private mUsername As String = ""
    Public Property Foreusername() As String
        Get
            Return mUsername
        End Get
        Set(ByVal value As String)
            mUsername = value
        End Set
    End Property
    Private mPassword As String = ""
    Public Property Forepassword() As String
        Get
            Return mPassword
        End Get
        Set(ByVal value As String)
            mPassword = value
        End Set
    End Property
End Class
