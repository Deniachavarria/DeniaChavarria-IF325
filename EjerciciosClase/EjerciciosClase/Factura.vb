Public Class Factura
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtprecio.Clear()
        txtcantidad.Clear()
        chbdescuento.Checked = False
        chbisv.Checked = False
        Cmbdescuento.ResetText()
        cmbisv.ResetText()
        txtsubtotal.Clear()
        txtdescuento.Clear()
        txtisv.Clear()
        txttotal.Clear()

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim precio, cantidad As Integer
        Dim descuento, subtotal, total As Double
        Dim aplicaDescuento As Boolean

        precio = Val(txtprecio.Text)
        cantidad = Val(txtcantidad.Text)
        aplicaDescuento = chbdescuento.Checked
        descuento = 0
        subtotal = precio * cantidad
        If aplicaDescuento = True Then
            descuento = subtotal * 0.05
        End If

        total = subtotal - descuento

        txtsubtotal.Text = subtotal
        txtdescuento.Text = descuento
        txttotal.Text = total
    End Sub
End Class