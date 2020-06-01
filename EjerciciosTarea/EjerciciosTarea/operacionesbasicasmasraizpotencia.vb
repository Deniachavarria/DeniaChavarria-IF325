Public Class operacionesbasicasmasraizpotencia
    Private Sub chbsuma_CheckedChanged(sender As Object, e As EventArgs) Handles chbsuma.CheckedChanged
        If chbsuma.Checked = True Then
            chbresta.Enabled = False
            chbdivision.Enabled = False
            chbmultiplicacion.Enabled = False
            chbraiz.Enabled = False
            chbpotencia.Enabled = False
        Else
            chbresta.Enabled = True
            chbdivision.Enabled = True
            chbmultiplicacion.Enabled = True
            chbraiz.Enabled = True
            chbpotencia.Enabled = True
        End If
    End Sub

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
            ElseIf chbresta.Checked = True Then
                resultado = valor1 - valor2
            ElseIf chbdivision.Checked = True Then
                resultado = valor1 / valor2
            ElseIf chbmultiplicacion.Checked = True Then
                resultado = valor1 * valor2
            ElseIf chbraiz.checked = True Then
                MsgBox("La raiz sera solo del primer valor")
                txtvalor2.Text = ""
                resultado = valor1 ^ (1 / 2)
            ElseIf chbpotencia.checked = True Then
                resultado = valor1 ^ valor2
            End If
        End If
        'salida
        txtresultado.Text = resultado
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtvalor1.Clear()
        txtvalor2.Clear()
        txtresultado.Clear()
        chbsuma.Checked = False
        chbresta.Checked = False
        chbmultiplicacion.Checked = False
        chbdivision.Checked = False
        chbraiz.Checked = False
        chbpotencia.Checked = False
        chbsuma.Enabled = True
        chbresta.Enabled = True
        chbmultiplicacion.Enabled = True
        chbdivision.Enabled = True
        chbraiz.Enabled = True
        chbpotencia.Enabled = True
    End Sub

    Private Sub chbmultiplicacion_CheckedChanged(sender As Object, e As EventArgs) Handles chbmultiplicacion.CheckedChanged
        If chbmultiplicacion.Checked = True Then
            chbresta.Enabled = False
            chbdivision.Enabled = False
            chbsuma.Enabled = False
            chbraiz.Enabled = False
            chbpotencia.Enabled = False
        Else
            chbresta.Enabled = True
            chbdivision.Enabled = True
            chbsuma.Enabled = True
            chbraiz.Enabled = True
            chbpotencia.Enabled = True
        End If
    End Sub

    Private Sub chbraiz_CheckedChanged(sender As Object, e As EventArgs) Handles chbraiz.CheckedChanged
        If chbraiz.Checked = True Then
            chbresta.Enabled = False
            chbdivision.Enabled = False
            chbmultiplicacion.Enabled = False
            chbsuma.Enabled = False
            chbpotencia.Enabled = False
        Else
            chbresta.Enabled = True
            chbdivision.Enabled = True
            chbmultiplicacion.Enabled = True
            chbsuma.Enabled = True
            chbpotencia.Enabled = True
        End If
    End Sub

    Private Sub chbresta_CheckedChanged(sender As Object, e As EventArgs) Handles chbresta.CheckedChanged
        If chbresta.Checked = True Then
            chbsuma.Enabled = False
            chbdivision.Enabled = False
            chbmultiplicacion.Enabled = False
            chbraiz.Enabled = False
            chbpotencia.Enabled = False
        Else
            chbsuma.Enabled = True
            chbdivision.Enabled = True
            chbmultiplicacion.Enabled = True
            chbraiz.Enabled = True
            chbpotencia.Enabled = True
        End If
    End Sub

    Private Sub chbdivision_CheckedChanged(sender As Object, e As EventArgs) Handles chbdivision.CheckedChanged
        If chbdivision.Checked = True Then
            chbresta.Enabled = False
            chbsuma.Enabled = False
            chbmultiplicacion.Enabled = False
            chbraiz.Enabled = False
            chbpotencia.Enabled = False
        Else
            chbresta.Enabled = True
            chbsuma.Enabled = True
            chbmultiplicacion.Enabled = True
            chbraiz.Enabled = True
            chbpotencia.Enabled = True
        End If
    End Sub

    Private Sub chbpotencia_CheckedChanged(sender As Object, e As EventArgs) Handles chbpotencia.CheckedChanged
        If chbpotencia.Checked = True Then
            chbresta.Enabled = False
            chbdivision.Enabled = False
            chbmultiplicacion.Enabled = False
            chbraiz.Enabled = False
            chbsuma.Enabled = False
        Else
            chbresta.Enabled = True
            chbdivision.Enabled = True
            chbmultiplicacion.Enabled = True
            chbraiz.Enabled = True
            chbsuma.Enabled = True
        End If
    End Sub
End Class