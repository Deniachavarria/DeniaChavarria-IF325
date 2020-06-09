Public Class Entradaguia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Select Case cmbentrada.SelectedIndex
            Case 0
                Me.Hide()
                Calculadora.Show()
            Case 1
                Me.Hide()
                formulageneralcuadratica.Show()
            Case 2
                Me.Hide()
                almacenes.Show()
            Case 3
                Me.Hide()
                xnumeros.Show()
            Case 4
                Me.Hide()
                SARHonduras.Show()
        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Entradaguia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class