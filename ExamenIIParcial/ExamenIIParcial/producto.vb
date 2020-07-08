Imports System.ComponentModel

Public Class producto
    Private Sub txtidproducto_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtidproducto.MaskInputRejected

    End Sub

    Private Sub txtidproducto_MouseHover(sender As Object, e As EventArgs) Handles txtidproducto.MouseHover
        ToolTip.SetToolTip(txtidproducto, "Ingrese el id del producto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombreproduc_TextChanged(sender As Object, e As EventArgs) Handles txtnombreproduc.TextChanged

    End Sub

    Private Sub txtnombreproduc_MouseHover(sender As Object, e As EventArgs) Handles txtnombreproduc.MouseHover
        ToolTip.SetToolTip(txtnombreproduc, "Ingrese el nombre del producto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtdescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtdescripcion.MouseHover
        ToolTip.SetToolTip(txtdescripcion, "Ingrese una descripcion del producto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click

    End Sub

    Private Sub btnregistrar_MouseHover(sender As Object, e As EventArgs) Handles btnregistrar.MouseHover
        ToolTip.SetToolTip(btnregistrar, "Registra el producto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidproducto_Validating(sender As Object, e As CancelEventArgs) Handles txtidproducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtnombreproduc_Validating(sender As Object, e As CancelEventArgs) Handles txtnombreproduc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Empresa.Show()
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

    Private Sub producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnregresar_MouseHover(sender As Object, e As EventArgs) Handles btnregresar.MouseHover
        ToolTip.SetToolTip(btnregresar, "Regresa al inicio")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        ToolTip.SetToolTip(btnsalir, "Abandona el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmaximizar_MouseHover(sender As Object, e As EventArgs) Handles btnmaximizar.MouseHover
        ToolTip.SetToolTip(btnmaximizar, "Maximiza el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnminimizar_MouseHover(sender As Object, e As EventArgs) Handles btnminimizar.MouseHover
        ToolTip.SetToolTip(btnminimizar, "Minimiza el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class