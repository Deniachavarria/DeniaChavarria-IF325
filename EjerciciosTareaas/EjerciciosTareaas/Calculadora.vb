Public Class Calculadora
    Dim DATO As Double
    Dim DATO2 As Double
    Dim RESUL As Double
    Dim OPE As Double
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResultado.Clear()
        txtResultado.Focus()

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResultado.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResultado.Text &= "9"
    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If

    End Sub

    Private Sub txtresultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Entradaguia.Show()
    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        OPE = 1
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()

    End Sub

    Private Sub btnr_Click(sender As Object, e As EventArgs) Handles btnr.Click
        Dim lista As Double

        DATO2 = Val(txtResultado.Text)
        If OPE = 1 Then
            RESUL = DATO + DATO2
            txtResultado.Text = RESUL

        ElseIf OPE = 2 Then
            RESUL = DATO - DATO2
            txtResultado.Text = RESUL
        ElseIf OPE = 3 Then
            RESUL = DATO * DATO2
            txtResultado.Text = RESUL
        ElseIf OPE = 4 Then
            RESUL = DATO / DATO2
            txtResultado.Text = RESUL
        End If
        lista = lista + RESUL
        txtlista.Text = MsgBox(lista)
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        OPE = 3
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        OPE = 2
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        OPE = 4
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    Private Sub txtlista_TextChanged(sender As Object, e As EventArgs) Handles txtlista.TextChanged

    End Sub
End Class


