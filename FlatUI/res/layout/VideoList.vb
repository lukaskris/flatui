Public Class VideoList
    Dim curtop = 0
    Dim mydb As New mySqlDB
    Dim result As String = ""
    Dim dataset As New DataTable
    Private Sub VideoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetVideoType(type As Integer)
        If type = 0 Then
            'load dari last played
        ElseIf type = 1 Then
            'load dari saved course
        ElseIf type = 2 Then
            dataset = mydb.executeSQL("select * from lesson order by title desc", result)
            Panel1.Controls.Clear()
            If dataset.Rows.Count > 0 Then
                For Each row As DataRow In dataset.Rows
                    Dim rowcat As VideoRow = New VideoRow()
                    rowcat.Title.Text = row("title")
                    rowcat.totalView.Text = row("view").ToString + " Viewed"
                    Dim length As Integer = row("length")
                    rowcat.lengthText.Text = (length / 60).ToString + " Minutes"
                    rowcat.Dock = DockStyle.Top

                    AddHandler rowcat.Panel2.Click, AddressOf Me.VideoViewClick
                    Panel1.Controls.Add(rowcat)
                Next
            End If
        End If
    End Sub

    Private Sub VideoViewClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("here")
    End Sub
End Class
