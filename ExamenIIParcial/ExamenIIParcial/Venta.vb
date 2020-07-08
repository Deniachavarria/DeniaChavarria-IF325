Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Venta
    Dim conexion As conexion = New conexion()
    Dim dataT As New DataTable
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Empresa.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvlistar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistar.CellContentClick

    End Sub

    Private Sub txtidventa_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtidventa.MaskInputRejected

    End Sub

    Private Sub txtidventa_MouseHover(sender As Object, e As EventArgs) Handles txtidventa.MouseHover
        ToolTip.SetToolTip(txtidventa, "Ingrese el id venta")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtfecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtfecha.MaskInputRejected

    End Sub

    Private Sub txtfecha_MouseHover(sender As Object, e As EventArgs) Handles txtfecha.MouseHover
        ToolTip.SetToolTip(txtfecha, "Ingrese la fecha actual")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtprecio_MouseHover(sender As Object, e As EventArgs) Handles txtprecio.MouseHover
        ToolTip.SetToolTip(txtprecio, "Debe ingresar el precio unitario")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        ToolTip.SetToolTip(txtcantidad, "Debe ingresar la cantidad de productos")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidcliente_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtidcliente.MaskInputRejected

    End Sub

    Private Sub txtidcliente_MouseHover(sender As Object, e As EventArgs) Handles txtidcliente.MouseHover
        ToolTip.SetToolTip(txtidcliente, "Ingresar el id del cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidproduc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtidproduc.MaskInputRejected

    End Sub



    Private Sub btncrear_MouseHover(sender As Object, e As EventArgs) Handles btncrear.MouseHover
        ToolTip.SetToolTip(btncrear, "Crea una venta")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnleer_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

    End Sub

    Private Sub btnleer_MouseHover(sender As Object, e As EventArgs) Handles btnmodificar.MouseHover
        ToolTip.SetToolTip(btnmodificar, "lee una venta registrada")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnactualizar_MouseHover(sender As Object, e As EventArgs) Handles btnbuscar.MouseHover
        ToolTip.SetToolTip(btnbuscar, "Actualiza")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

    End Sub

    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs) Handles btneliminar.MouseHover
        ToolTip.SetToolTip(btneliminar, "Elimina una venta")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnregrsar_MouseHover(sender As Object, e As EventArgs) Handles btnregresar.MouseHover
        ToolTip.SetToolTip(btnregresar, "Regresa al inicio")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub dgvlistar_MouseHover(sender As Object, e As EventArgs) Handles dgvlistar.MouseHover
        ToolTip.SetToolTip(dgvlistar, "Muestra Los registros")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidventa_Validating(sender As Object, e As CancelEventArgs) Handles txtidventa.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtfecha_Validating(sender As Object, e As CancelEventArgs) Handles txtfecha.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtprecio_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtidproduc_Validating(sender As Object, e As CancelEventArgs) Handles txtidproduc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, " Campo es obligatorio")
        End If
    End Sub

    Private Sub txtidproduc_MouseHover(sender As Object, e As EventArgs) Handles txtidproduc.MouseHover
        ToolTip.SetToolTip(txtidproduc, "Ingrese el id del producto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_Click_1(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click
        btnmaximizar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        ToolTip.SetToolTip(btnsalir, "Abandona el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmaximizar_MouseHover(sender As Object, e As EventArgs) Handles btnmaximizar.MouseHover
        ToolTip.SetToolTip(btnmaximizar, "Maximiza el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnminimizar_MouseHover(sender As Object, e As EventArgs) Handles btnminimizar.MouseHover
        ToolTip.SetToolTip(btnminimizar, "Minimiza el programa")
        ToolTip.ToolTipTitle = "Precausion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Try
            Dim guardar As String =
          " insert into tienda.sql values(" + txtidventa.Text + "','" + txtfecha.Text + " ','" + txtprecio.Text + "','" + txtcantidad.Text +
           "','" + txtidcliente.Text + "','" + txtidproduc.Text + "')"
            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Producto guardado")

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Guardar Producto")
                conexion.conexion.Close()

            End If
            If txtidventa.Text = "" Or txtfecha.Text = "" Or txtprecio.Text = "" Or txtcantidad.Text = "" Or txtidcliente.Text = "" Or txtidproduc.Text = "" Then
                MsgBox("Debe de llenar cada campo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
