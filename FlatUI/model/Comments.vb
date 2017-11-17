<Serializable()>
Public Class Comments
    Private mIdLesson As Integer = -1
    Public Property Foreid() As Integer
        Get
            Return mIdLesson
        End Get
        Set(ByVal value As Integer)
            mIdLesson = value
        End Set
    End Property

    Private mComment As String = ""
    Public Property Forecomment() As String
        Get
            Return mComment
        End Get
        Set(value As String)
            mComment = value
        End Set
    End Property

    Private mDate As New Date
    Public Property Foredate() As Date
        Get
            Return mDate
        End Get
        Set(value As Date)
            mDate = value
        End Set
    End Property

    Private mUserId As String = ""
    Public Property Foreuserid As String
        Get
            Return mUserId
        End Get
        Set(value As String)
            mUserId = value
        End Set
    End Property
End Class
