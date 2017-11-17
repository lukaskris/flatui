Public Class Bubble


    Public Sub build(message As String, time As String)
        Label1.Text = message
        Label2.Text = time
        setHeight()
    End Sub

    Sub setHeight()

        Dim g As Graphics = CreateGraphics()
        Dim size As SizeF = g.MeasureString(Label1.Text, Label1.Font, Label1.Width)
        Label1.Height = Integer.Parse(Math.Round(size.Height + 2, 0).ToString)
        Label2.Top = Label1.Bottom
        Me.Height = Label2.Bottom + 10
    End Sub

    Private Sub Bubble_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        setHeight()
    End Sub
End Class
