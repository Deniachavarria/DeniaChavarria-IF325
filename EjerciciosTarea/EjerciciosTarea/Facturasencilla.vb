Public Class Facturasencilla
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbisv.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtprecio.Clear()
        txtcantidad.Clear()
        txtsubtotal.Clear()
        txtdescuento.Clear()
        txtisv.Clear()
        txttotal.Clear()
        chbdescuento.Checked = False
        chbisv.Checked = False
        cmbdescuento.ResetText()
        cmbisv.ResetText()
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim cantidad As Integer
        Dim descuento, isv, total, subtotal, precio As Double

        If txtprecio.Text = "" Or txtcantidad.Text = "" Then
            MsgBox("Debe ingresar un valor", vbInformation)
        ElseIf txtprecio.Text < 0 Or txtcantidad.Text < 0 Then
            MsgBox("Debe ingresar un valor mayor a cero", vbInformation)
        End If
        precio = Val(txtprecio.Text)
        cantidad = Val(txtcantidad.Text)

        subtotal = precio * cantidad
        Select Case cmbdescuento.SelectedIndex
            Case 0
                descuento = subtotal * 0.1
            Case 1
                descuento = subtotal * 0.15
            Case 2
                descuento = subtotal * 0.2
            Case 3
                descuento = subtotal * 0.25
            Case 4
                descuento = subtotal * 0.3
            Case 5
                descuento = subtotal * 0.35
        End Select
        Select Case cmbisv.SelectedIndex
            Case 0
                isv = subtotal * 0.15
            Case 1
                isv = subtotal * 0.17
        End Select

        total = (subtotal - descuento) + isv
        txtsubtotal.Text = subtotal
        txtdescuento.Text = descuento
        txtisv.Text = isv
        txttotal.Text = total

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub cmbdescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdescuento.SelectedIndexChanged

    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged
        If txtprecio.Text = "" Then
            btnnuevo.Enabled = False
        Else
            btnnuevo.Enabled = True
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        If txtcantidad.Text = "" Then
            btnnuevo.Enabled = False
        Else
            btnnuevo.Enabled = True
        End If
    End Sub

    Private Sub chbdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chbdescuento.CheckedChanged
        If chbdescuento.Checked = True Then
            chbisv.Enabled = False
        Else
            chbisv.Enabled = True
        End If
        If chbdescuento.Checked = True Then
            cmbdescuento.Enabled = True
        ElseIf chbdescuento.Checked = False Then
            cmbdescuento.Enabled = False
            cmbdescuento.ResetText()
        End If

    End Sub

    Private Sub chbisv_CheckedChanged(sender As Object, e As EventArgs) Handles chbisv.CheckedChanged
        If chbisv.Checked = True Then
            chbdescuento.Enabled = False
        Else
            chbdescuento.Enabled = True
        End If
        If chbisv.Checked = True Then
            cmbisv.Enabled = True
        ElseIf chbisv.Checked = False Then
            cmbisv.Enabled = False
            cmbisv.ResetText()
        End If
    End Sub
End Class