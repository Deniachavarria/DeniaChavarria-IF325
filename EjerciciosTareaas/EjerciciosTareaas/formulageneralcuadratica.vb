Public Class formulageneralcuadratica
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, c, d As Double
        If txta.Text < 1 Then
            MsgBox(" >a< debe ser diferente de cero", vbInformation)
            txta.Text = ""
        Else
            a = Val(txta.Text)
            b = Val(txtb.Text)
            c = Val(txtc.Text)

            d = ((b ^ 2) - 4 * a * c)
        End If

        If a <> 0 Then
            If d < 0 Then
                MsgBox(" No existe una solucion real para la ecuacion", vbInformation)
                txta.Clear()
                txtb.Clear()
                txtc.Clear()
            Else
                txtx1.Text = (-b + (d) ^ (1 / 2)) / (2 * a)
                txtx2.Text = (-b - (d) ^ (1 / 2)) / (2 * a)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txta.Clear()
        txtb.Clear()
        txtc.Clear()
        txtx1.Clear()
        txtx2.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtb.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Entradaguia.Show()
    End Sub
End Class