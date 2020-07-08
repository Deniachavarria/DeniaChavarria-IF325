Imports System.ComponentModel

Public Class cliente
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtidcliente.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_MouseHover(sender As Object, e As EventArgs) Handles txtidcliente.MouseHover
        ToolTip.SetToolTip(txtidcliente, "Ingrese el id del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        ToolTip.SetToolTip(txtnombre, "Ingrese el nombre del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged

    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        ToolTip.SetToolTip(txtapellido, "Ingrese el apellido del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtireccion_TextChanged(sender As Object, e As EventArgs) Handles txtdireccion.TextChanged

    End Sub

    Private Sub txtireccion_MouseHover(sender As Object, e As EventArgs) Handles txtdireccion.MouseHover
        ToolTip.SetToolTip(txtdireccion, "Ingrese el direccion del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidcliente_Validating(sender As Object, e As CancelEventArgs) Handles txtidcliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click

    End Sub

    Private Sub btnregistrar_MouseHover(sender As Object, e As EventArgs) Handles btnregistrar.MouseHover
        ToolTip.SetToolTip(btnregistrar, "Registra el cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Empresa.Show()
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles btnregresar.MouseHover
        ToolTip.SetToolTip(btnregresar, "Regresa al inicio")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click
        btnmaximizar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        ToolTip.SetToolTip(btnsalir, "Abandona el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmaximizar_MouseHover(sender As Object, e As EventArgs) Handles btnmaximizar.MouseHover
        ToolTip.SetToolTip(btnmaximizar, "Maximizar el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnminimizar_MouseHover(sender As Object, e As EventArgs) Handles btnminimizar.MouseHover
        ToolTip.SetToolTip(btnminimizar, "Minimizar el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class