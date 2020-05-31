Public Class ingresotextoventanaemergente
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim valor As Integer

        valor = InputBox("ingrese numero", "ingreso")
        txtValor.Text = valor
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim suma, resta, Multiplicacion, valor As Integer
        Dim Division As Double

        valor = Val(txtValor.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            Multiplicacion = valor * i
            Division = (valor / i)
            'Items.Add agregar de forma automatica nuestros items
            '&(concatenar)
            cmbsuma.Items.Add(valor & "+" & i & "=" & suma)
            cmbresta.Items.Add(valor & "-" & i & "=" & resta)
            cmbmultiplicacion.Items.Add(valor & "x" & i & "=" & Multiplicacion)
            cmbdivision.Items.Add(valor & "/" & i & "=" & Division)


        Next
    End Sub
End Class