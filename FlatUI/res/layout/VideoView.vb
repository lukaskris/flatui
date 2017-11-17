Public Class VideoView
    Public Key As Integer

    Private Sub VideoView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VideoView_MouseEnter(sender As Object, e As EventArgs)
        BunifuCards1.color = Color.Red
    End Sub

    Private Sub VideoView_MouseLeave(sender As Object, e As EventArgs)
        BunifuCards1.color = Color.MediumTurquoise
    End Sub

    Private Sub BunifuCards1_MouseHover(sender As Object, e As EventArgs) Handles BunifuCards1.MouseHover
        Console.WriteLine("Here")
    End Sub

    Public Sub SetId(id As Integer)
        Key = id
    End Sub


End Class
