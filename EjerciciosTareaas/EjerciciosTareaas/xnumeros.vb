Public Class xnumeros
    Private Sub xnumeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnumero.Text = ""
        txtpositivo.Text = ""
        txtnegativo.Text = ""
        txtsuma.Text = ""
        txtpar.Text = ""
        txtimpar.Text = ""
        txtingresados.Text = ""
        txtnumero.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub cmbnumero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnumero.SelectedIndexChanged

    End Sub

    Private Sub txtnumero_TextChanged(sender As Object, e As EventArgs) Handles txtnumero.TextChanged
        If txtnumero.Text = "" Then
            cmbnumero.Visible = False
        Else
            cmbnumero.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim valor, i As Integer
        Dim positivo, negativo, par, impar, suma, ingresado As Integer
        positivo = 0
        negativo = 0
        par = 0
        impar = 0
        suma = 0
        ingresado = 0
        If txtnumero.Text = "" Then
            MsgBox("Debe ingresar la cantidad de numeros que desea ingresar")
            txtnumero.Focus()
        Else
            For i = 1 To txtnumero.Text
                valor = InputBox("Ingrese numero", i, "Ingresado")
                txtnumero.Text = valor
                ingresado = ingresado + 1
                cmbnumero.DropDownStyle = ComboBoxStyle.DropDownList
                cmbnumero.Items.Add(valor)
                If valor > 0 Then
                    positivo = positivo + 1
                ElseIf valor < 0 Then
                    negativo = negativo + 1
                End If
                If valor Mod 2 = 0 Then
                    par = par + 1
                Else
                    impar = impar + 1
                End If
                suma = suma + valor
            Next
        End If
        txtpositivo.Text = positivo
        txtnegativo.Text = negativo
        txtsuma.Text = suma
        txtpar.Text = par
        txtimpar.Text = impar
        txtingresados.Text = ingresado
    End Sub

    Private Sub txtnumero_MouseHover(sender As Object, e As EventArgs) Handles txtnumero.MouseHover
        Toolmsj.SetToolTip(txtnumero, "Debe ingresar la cantidad de numeros que desea agregar")
        Toolmsj.ToolTipTitle = "Valores"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbnumero_MouseHover(sender As Object, e As EventArgs) Handles cmbnumero.MouseHover
        Toolmsj.SetToolTip(cmbnumero, "Muestra los valores ingresados")
        Toolmsj.ToolTipTitle = "Valorez"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles grbresultado.Enter

    End Sub

    Private Sub GroupBox2_MouseHover(sender As Object, e As EventArgs) Handles grbresultado.MouseHover
        Toolmsj.SetToolTip(grbresultado, "Muestra los resultados")
        Toolmsj.ToolTipTitle = "Resultado"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Entradaguia.Show()
    End Sub
End Class