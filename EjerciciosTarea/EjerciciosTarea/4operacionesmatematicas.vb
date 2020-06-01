Public Class _4operacionesmatematicas
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim valor1, valor2 As Integer
        Dim resultado As Double

        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Debe Ingresar un valor")
        ElseIf Not IsNumeric(txtvalor1.Text) Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("Debe ingresar valores numericos")
        ElseIf IsNumeric(txtvalor1.Text) Or IsNumeric(txtvalor2.Text) Then
            valor1 = Val(txtvalor1.Text)
            valor2 = Val(txtvalor2.Text)
            If txtvalor1.Text < 0 And txtvalor2.Text Then
                MsgBox("No se aceptan numeros negativos")
            End If
            If chbsuma.Checked = True Then
                resultado = valor1 + valor2
                txtresultado.Text = resultado
            ElseIf chbresta.Checked = True Then
                resultado = valor1 - valor2
                txtresultado.Text = resultado
            ElseIf chbdivision.Checked = True Then
                resultado = valor1 / valor2
                txtresultado.Text = resultado
            ElseIf chbmultiplicacion.Checked = True Then
                resultado = valor1 * valor2
                txtresultado.Text = resultado
            End If
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtvalor1.Clear()
        txtvalor2.Clear()
        txtresultado.Clear()
        chbsuma.Checked = False
        chbresta.Checked = False
        chbmultiplicacion.Checked = False
        chbdivision.Checked = False
        chbsuma.Enabled = True
        chbresta.Enabled = True
        chbmultiplicacion.Enabled = True
        chbdivision.Enabled = True
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub chbsuma_CheckedChanged(sender As Object, e As EventArgs) Handles chbsuma.CheckedChanged
        If chbsuma.Checked = True Then
            chbresta.Enabled = False
            chbdivision.Enabled = False
            chbmultiplicacion.Enabled = False
        Else
            chbresta.Enabled = True
            chbdivision.Enabled = True
            chbmultiplicacion.Enabled = True
        End If
    End Sub

    Private Sub chbresta_CheckedChanged(sender As Object, e As EventArgs) Handles chbresta.CheckedChanged
        If chbresta.Checked = True Then
            chbsuma.Enabled = False
            chbdivision.Enabled = False
            chbmultiplicacion.Enabled = False
        Else
            chbsuma.Enabled = True
            chbdivision.Enabled = True
            chbmultiplicacion.Enabled = True
        End If
    End Sub

    Private Sub chbmultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles chbmultiplicacion.CheckedChanged
        If chbmultiplicacion.Checked = True Then
            chbresta.Enabled = False
            chbdivision.Enabled = False
            chbsuma.Enabled = False
        Else
            chbresta.Enabled = True
            chbdivision.Enabled = True
            chbsuma.Enabled = True
        End If
    End Sub

    Private Sub chbdivision_CheckedChanged(sender As Object, e As EventArgs) Handles chbdivision.CheckedChanged
        If chbdivision.Checked = True Then
            chbsuma.Enabled = False
            chbresta.Enabled = False
            chbmultiplicacion.Enabled = False
        Else
            chbsuma.Enabled = True
            chbresta.Enabled = True
            chbmultiplicacion.Enabled = True
        End If
    End Sub
End Class