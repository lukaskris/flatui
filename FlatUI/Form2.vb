Public Class Form2

    Dim mydb As New mySqlDB
    Dim result As String = ""
    Dim dataset As New DataTable

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs)
        Process.GetCurrentProcess.Kill()
        Environment.Exit(0)
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            BunifuElipse1.ElipseRadius = 0
        Else
            Me.WindowState = FormWindowState.Normal
            BunifuElipse1.ElipseRadius = 7
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub ShowVideo(Key As String)
        Player1.fillLeftPanel(Key)
    End Sub

    Private Sub BunifuImageButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton7_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Process.GetCurrentProcess.Kill()
    End Sub
End Class