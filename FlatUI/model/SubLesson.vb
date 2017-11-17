<Serializable()>
Public Class SubLesson
    Private id As Integer
    Public Property Foreid() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Private lesson_id As Integer
    Public Property Forelessonid() As Integer
        Get
            Return lesson_id
        End Get
        Set(ByVal value As Integer)
            lesson_id = value
        End Set
    End Property
    Private title As String
    Public Property Foretitle() As String
        Get
            Return title
        End Get
        Set(ByVal value As String)
            title = value
        End Set
    End Property
    Private thumbnail As String
    Public Property Forethumbnail() As String
        Get
            Return thumbnail
        End Get
        Set(ByVal value As String)
            thumbnail = value
        End Set
    End Property
    Private src As String
    Public Property Foresrc() As String
        Get
            Return src
        End Get
        Set(ByVal value As String)
            src = value
        End Set
    End Property
End Class
