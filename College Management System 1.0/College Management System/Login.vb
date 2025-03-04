Public Class Login
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Enter Username & Password")
        ElseIf txtUsername.Text = "Admin" And txtPassword.Text = "Password" Then
            Dim Obj = New Dashboard
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username & Password")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If

    End Sub
End Class