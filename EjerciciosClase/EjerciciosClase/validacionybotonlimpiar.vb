Public Class validacionybotonlimpiar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtnumero.Clear()
        txtnumero.Focus()

    End Sub

    Private Sub btnvalidar_Click(sender As Object, e As EventArgs) Handles btnvalidar.Click
        Dim valor As Integer

        If txtnumero.Text = "" Then
            MsgBox("Debe ingresar un valor", vbInformation)
        ElseIf Not IsNumeric(txtnumero.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtnumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtnumero.Text)
            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero Positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero Negativo")
            End If
        End If
    End Sub
End Class