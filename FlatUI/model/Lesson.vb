<Serializable()>
Public Class Lesson
    Private mId As Integer = -1
    Public Property Foreid() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property
    Private mTitle As String = ""
    Public Property Foretitle() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            mTitle = value
        End Set
    End Property
    Private mThumbnail As String = ""
    Public Property Forethumbnail() As String
        Get
            Return mThumbnail
        End Get
        Set(ByVal value As String)
            mThumbnail = value
        End Set
    End Property
    Private mDescription As String = ""
    Public Property Foredescription() As String
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            mDescription = value
        End Set
    End Property
    Private mLength As Integer = 0
    Public Property Forelength() As Integer
        Get
            Return mLength
        End Get
        Set(ByVal value As Integer)
            mLength = value
        End Set
    End Property
    Private mView As Integer = 0
    Public Property Foreview() As Integer
        Get
            Return mView
        End Get
        Set(ByVal value As Integer)
            mView = value
        End Set
    End Property
    Private mTotal As Integer = 0
    Public Property Foretotal() As Integer
        Get
            Return mTotal
        End Get
        Set(ByVal value As Integer)
            mTotal = value
        End Set
    End Property
    Private watch As Integer = 0
    Public Property Forewatch() As Integer
        Get
            Return watch
        End Get
        Set(ByVal value As Integer)
            watch = value
        End Set
    End Property
    Private filesize As Integer = 0
    Public Property Forefilesize() As Integer
        Get
            Return filesize
        End Get
        Set(ByVal value As Integer)
            filesize = value
        End Set
    End Property
    Private sub_lessons As List(Of SubLesson)
    Public Property Foresublesson() As List(Of SubLesson)
        Get
            Return sub_lessons
        End Get
        Set(ByVal value As List(Of SubLesson))
            sub_lessons = value
        End Set
    End Property
End Class