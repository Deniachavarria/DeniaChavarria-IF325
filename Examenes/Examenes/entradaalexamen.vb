Imports System.ComponentModel

Public Class entradaalexamen
    Dim usuarioc As String
    Dim contraseñac As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnusuarioo.Click
        If txtusuario.Text = "" Or txtcontraseña.Text = "" Then
            MsgBox("Debe verificar que su usuario y contraseña no se encuentren vacios", vbInformation)
        Else
            usuarioc = txtusuario.Text
            contraseñac = txtcontraseña.Text
            grbiniciar.Visible = True
            grbcrearusuario.Visible = False
            txtusuarioco.Focus()
            btnnuevo.Visible = True
        End If
        If txtcontraseña.Text <> txtconfirmo.Text Then
            MsgBox("Debe confirmar con la misma contraseña", vbInformation)
            grbcrearusuario.Visible = True
            grbiniciar.Visible = False
        ElseIf txtconfirmo.Text = "" Then
            MsgBox("La contraseña de confirmacion no puede quedar vacia")
            grbcrearusuario.Visible = True
            grbiniciar.Visible = False
        End If

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        Toolmsj.SetToolTip(txtusuario, "Debe ingresar su nuevo usuario")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        grbcrearusuario.Visible = True
        grbiniciar.Visible = False
        txtusuario.Focus()
        btnnuevo.Visible = False
        txtcontraseña.Clear()
        txtusuario.Clear()
        txtconfirmo.Clear()

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        If txtusuarioco.Text = usuarioc And txtcontraseñaco.Text = contraseñac Then
            Me.Hide()
            ExamenIP.Show()

        ElseIf txtusuarioco.Text = "" And txtcontraseñaco.Text = "" Then
            MsgBox("Debe ingresar lo solicitado", vbInformation)
        Else
            MsgBox("Usuario o contraseña incorrecta", vbInformation)
            txtusuarioco.Clear()
            txtusuario.Focus()
        End If
    End Sub

    Private Sub txtusuarioco_TextChanged(sender As Object, e As EventArgs) Handles txtusuarioco.TextChanged
        txtusuario.Focus()

    End Sub

    Private Sub grbcrearusuario_Enter(sender As Object, e As EventArgs) Handles grbcrearusuario.Enter

    End Sub

    Private Sub btnusuario_Click(sender As Object, e As EventArgs)
        grbiniciar.Visible = True
        grbcrearusuario.Visible = False
    End Sub

    Private Sub grbiniciar_Enter(sender As Object, e As EventArgs) Handles grbiniciar.Enter

    End Sub

    Private Sub txtusuarioco_Validating(sender As Object, e As CancelEventArgs) Handles txtusuarioco.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalidating.SetError(sender, "")
        Else
            Me.Errorvalidating.SetError(sender, "Es un campo obligatorio, Ingrese su usuario")
        End If
    End Sub

    Private Sub txtcontraseñaco_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseñaco.TextChanged

    End Sub

    Private Sub txtcontraseñaco_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseñaco.Validating

    End Sub

    Private Sub txtusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalidating.SetError(sender, "")
        Else
            Me.Errorvalidating.SetError(sender, "Es un campo obligatorio, ingrese su nuevo usuario")
        End If
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged

    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalidating.SetError(sender, "")
        Else
            Me.Errorvalidating.SetError(sender, "Es un campo obligatorio, ingrese su nueva contraseña")
        End If
    End Sub

    Private Sub btnnuevo_MouseHover(sender As Object, e As EventArgs) Handles btnnuevo.MouseHover
        Toolmsj.SetToolTip(btnnuevo, "Crea un nuevo usuario")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btniniciar_MouseHover(sender As Object, e As EventArgs) Handles btniniciar.MouseHover
        Toolmsj.SetToolTip(btniniciar, "Inicia seccion")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtusuarioco_MouseHover(sender As Object, e As EventArgs) Handles txtusuarioco.MouseHover
        Toolmsj.SetToolTip(txtusuarioco, "Debe ingresar su usuario")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseñaco_MouseHover(sender As Object, e As EventArgs) Handles txtcontraseñaco.MouseHover
        Toolmsj.SetToolTip(txtcontraseñaco, "Debe ingresar su contraseña")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseña_MouseHover(sender As Object, e As EventArgs) Handles txtcontraseña.MouseHover
        Toolmsj.SetToolTip(txtcontraseña, "Crea su contraseña")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtconfirmo_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmo.TextChanged

    End Sub

    Private Sub txtconfirmo_MouseHover(sender As Object, e As EventArgs) Handles txtconfirmo.MouseHover
        Toolmsj.SetToolTip(txtconfirmo, "Confirme su contraseña")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnusuarioo.MouseHover
        Toolmsj.SetToolTip(btnusuarioo, "Guardas su usuario")
        Toolmsj.ToolTipTitle = "Entrada"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
