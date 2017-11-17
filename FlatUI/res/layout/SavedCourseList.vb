Public Class SavedCourseList
    Private Sub SavedCourseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists("Lesson.bin") Then
            Using s As IO.Stream = New IO.FileStream("Lesson.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                Dim list As New List(Of Lesson)
                Dim F As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

                list = DirectCast(F.Deserialize(s), Object)
                s.Close()

                For Each item As Lesson In list
                    Dim row As SavedCourseRow = New SavedCourseRow()
                    row.SavedCourseRowTitle.Text = item.Foretitle
                    row.SavedCourseRowDescription.Text = item.Foredescription
                    row.lesson = item
                    row.Dock = DockStyle.Top
                    Panel1.Controls.Add(row)
                Next
            End Using
        End If
    End Sub
End Class
