Public Class libretadeahorro
    Private monto As Double
    'Procedimientos
    Private Sub activarControles()
        txtNombre.Enabled = False
        txtMonto.Enabled = False
        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    Private Sub desactivarControles()
        txtNombre.Enabled = True
        txtMonto.Enabled = True
        btnaperturar.Enabled = True
        btnretirar.Enabled = False
        btndepositar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtNombre.Clear()
        txtSaldo.Clear()
        txtMonto.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    Private Sub frmLibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnretirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo()
        End If
    End Sub

    Private Sub ejercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaperturar.Click
        Dim cliente As String
        cliente = txtnombre.Text
        monto = Val(txtmonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operación")
        mostrarSaldo()
        Return cantidad
    End Function
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtsaldo.TextChanged

    End Sub

    Private Sub btndepositar_Click(sender As Object, e As EventArgs) Handles btndepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub
End Class