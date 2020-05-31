Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim numero As Integer
        Dim i As Integer

        If txtnumero.Text = "" Then
            MsgBox("Debe ingresar un valor numerico", vbInformation)
            txtnumero.Focus()
        End If

        numero = Val(txtnumero.Text)
        If txtnumero.Text < 1 Then
            MsgBox("Debe ingresar un valor mayor a cero", vbInformation)
            txtnumero.Clear()
            txtnumero.Focus()
        ElseIf txtnumero.Text > 0 Then
            For i = 1 To 10
                MsgBox(numero & "*" & i & "=" & numero * i)
            Next i
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnumero.Clear()
        txtnumero.Focus()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class
