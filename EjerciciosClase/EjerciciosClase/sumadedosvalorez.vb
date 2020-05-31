Public Class Form1
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)

        If txtvalor1.Text = "" Or txtvalor2.Text = "" Then
            MsgBox("Debe ingresar un valor", vbInformation)
        End If

        suma = valor1 + valor2

        txtresultado.Text = suma
    End Sub
End Class
