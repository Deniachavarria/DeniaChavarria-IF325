Public Class bienvenida
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnlogin_MouseHover(sender As Object, e As EventArgs) Handles btnlogin.MouseHover
        Toolmsj.SetToolTip(btnlogin, "Presione LOGIN para ingresar su usuario")
        Toolmsj.ToolTipTitle = "Atencion"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
