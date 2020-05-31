Imports System.ComponentModel

Public Class validacionconerrorprovider
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtproducto_TextChanged(sender As Object, e As EventArgs) Handles txtproducto.TextChanged

    End Sub

    Private Sub txtproducto_Validating(sender As Object, e As CancelEventArgs) Handles txtproducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorvalidacion.SetError(sender, "")
        Else
            Me.errorvalidacion.SetError(sender, "Es campo obligatorio, ingrese el produco")
        End If
    End Sub

    Private Sub btnvalidar_Click(sender As Object, e As EventArgs) Handles btnvalidar.Click
        'Try Catch 
        'validateChildren bottom
        'valideting cajas de texto

        Try
            If Me.ValidateChildren And txtproducto.Text <> String.Empty And txtprecio.Text <> String.Empty And Val(txtcantidad.Text) And Val(txtprecio.Text) Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtprecio_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorvalidacion.SetError(sender, "")
        Else
            Me.errorvalidacion.SetError(sender, "Es campo obligatorio, ingrse el precio")
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorvalidacion.SetError(sender, "")
        Else
            Me.errorvalidacion.SetError(sender, "Es campo obligatorio, ingrese la cantidad")
        End If
    End Sub

    Private Sub txtproducto_MouseHover(sender As Object, e As EventArgs) Handles txtproducto.MouseHover
        toolmsj.SetToolTip(txtproducto, "Ingrese un producto")
        toolmsj.ToolTipTitle = "Producto"
        toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_MouseHover(sender As Object, e As EventArgs) Handles txtprecio.MouseHover
        toolmsj.SetToolTip(txtprecio, "Ingrese el precio del producto")
        toolmsj.ToolTipTitle = "Precio"
        toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        toolmsj.SetToolTip(txtcantidad, "Ingrese la cantidad de producto")
        toolmsj.ToolTipTitle = "Cantidad"
        toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtdescripcion.MouseHover
        toolmsj.SetToolTip(txtdescripcion, "Ingrese la descripsion del producto")
        toolmsj.ToolTipTitle = "Descripcion"
        toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class