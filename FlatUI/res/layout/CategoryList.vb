Public Class CategoryList

    Dim curtop = 0
    Dim mydb As New mySqlDB
    Dim result As String = ""
    Dim dataset As New DataTable
    Private Sub CategoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataset = mydb.executeSQL("select * from category order by name desc", result)
        If dataset.Rows.Count > 0 Then

            For Each row As DataRow In dataset.Rows
                Dim rowcat As CategoryRow = New CategoryRow()
                rowcat.CategoryRowTitle.Text = row("name")
                rowcat.CategoryRowDescription.Text = "Descriptions "
                rowcat.Dock = DockStyle.Top
                Panel1.Controls.Add(rowcat)
            Next
        End If

        For i As Integer = 0 To 10

        Next

    End Sub
End Class
