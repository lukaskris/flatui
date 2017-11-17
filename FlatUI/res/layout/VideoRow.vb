Public Class VideoRow
    Public Key As String = ""

    Private Sub VideoRow_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        Dim Parent As Form1 = Me.Parent.Parent.Parent.Parent
        Parent.Visible = False
        Dim form As New Form2
        form.ShowVideo(Key)
        form.ShowDialog()
        Parent.Visible = True
    End Sub
End Class
