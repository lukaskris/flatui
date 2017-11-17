Public Class LoginForm
    Public LoginInfo As LoginInfo
    Public IsLogin As Boolean
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsLogin = False
        If System.IO.File.Exists("LoginInfo.bin") Then
            Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim s As IO.Stream
            f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            s = New IO.FileStream("LoginInfo.bin", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
            LoginInfo = DirectCast(f.Deserialize(s), Object)
            s.Close()
            IsLogin = True
            username.Text = LoginInfo.Foreusername
            password.Text = LoginInfo.Forepassword
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim mydb As New mySqlDB
        Dim result As String = ""
        Dim dataset As New DataTable

        If username.Text = "" Then
            errorNotif.Text = "Username harus diisi"
        ElseIf password.Text = "" Then
            errorNotif.Text = "Password harus diisi"
        ElseIf IsLogin Then
            Dim form As New Form1
            form.SetUsername(username.Text)
            form.ShowDialog()
            Me.Close()
        ElseIf username.Text <> "" And password.Text <> "" Then
            dataset = mydb.executeSQL("select * from user where username='" + username.Text + "'", result)
            If dataset.Rows.Count > 0 Then
                For Each row As DataRow In dataset.Rows
                    If password.Text <> row("password") Then
                        errorNotif.Text = "Password salah"
                    Else
                        errorNotif.Text = ""
                        Me.Visible = False
                        SaveLogin()
                        Dim form As New Form1
                        form.SetUsername(username.Text)
                        form.ShowDialog()
                        Me.Close()
                    End If
                Next
            Else
                errorNotif.Text = "Username tidak terdaftar"
            End If

        End If
    End Sub

    Private Sub SaveLogin()
        Dim loginData As LoginInfo
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream

        loginData = New LoginInfo()
        loginData.Foreusername = username.Text
        loginData.Forepassword = password.Text

        F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream("LoginInfo.bin", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        F.Serialize(s, loginData)
        s.Close()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Try
            Environment.Exit(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub password_OnValueChanged(sender As Object, e As EventArgs) Handles password.OnValueChanged
        If password.isPassword = False Then
            password.isPassword = True
        End If
    End Sub
End Class