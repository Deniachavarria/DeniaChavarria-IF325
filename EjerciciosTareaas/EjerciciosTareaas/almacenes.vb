Public Class almacenes
    Private Sub cmbalmacenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbalmacenes.SelectedIndexChanged
        Select Case cmbalmacenes.SelectedIndex
            Case 0
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 1
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 2
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 3
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 4
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 5
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 6
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 7
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 8
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
            Case 9
                grbvalores.Visible = True
                txtcantidad.Focus()
                For Each obj In Me.grbvalores.Controls
                    If TypeOf (obj) Is TextBox Then
                        obj.Text = ""
                        CType(obj, TextBox).ReadOnly = False
                    End If
                Next
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor, i As Integer
        Dim ventamedio As Integer
        Dim cantidad, Ventas, promedio As Double
        ventamedio = 10000
        If txtcantidad.Text = "" Then
            MsgBox("Debe ingresar la cantidad de ventas mensuales que desea ingresar")
            txtcantidad.Focus()
        Else
            For i = 1 To txtcantidad.Text
                cantidad = txtcantidad.Text
                valor = InputBox("Ingrese la venta mensual", "Ingresada")
                txtventas.Text = valor
                Ventas = Ventas + valor
                promedio = Ventas / cantidad

            Next
            txtventas.Text = Ventas
            txtpromedio.Text = promedio
        End If
        If cmbalmacenes.Text = "Almacen Tela" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Tela"

        ElseIf cmbalmacenes.Text = "Almacen Valle" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Valle"

        ElseIf cmbalmacenes.Text = "Almacen Taulabe" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Taulabe"

        ElseIf cmbalmacenes.Text = "Almacen La Ceiba" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen La Ceiba"

        ElseIf cmbalmacenes.Text = "Almacen San Pedro" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen San Pedro"

        ElseIf cmbalmacenes.Text = "Almacen Choluteca" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Choluteca"

        ElseIf cmbalmacenes.Text = "Almacen Tegucigalpa" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Tegucigalpa"

        ElseIf cmbalmacenes.Text = "Almacen Comayagua" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Comayagua"

        ElseIf cmbalmacenes.Text = "Almacen Ocotepeque" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Ocotepeque"

        ElseIf cmbalmacenes.Text = "Almacen Siguatepeque" And txtpromedio.Text >= ventamedio Then
            txtlistado.Text += "
Almacen Siguatepeque"
        End If



    End Sub

    Private Sub txtpromedio_TextChanged(sender As Object, e As EventArgs) Handles txtpromedio.TextChanged

    End Sub

    Private Sub txtlistado_TextChanged(sender As Object, e As EventArgs) Handles txtlistado.TextChanged

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        cmbalmacenes.ResetText()
        txtcantidad.Clear()
        txtpromedio.Clear()
        txtventas.Clear()
        txtlistado.Clear()


    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        txtcantidad.Clear()
        txtpromedio.Clear()
        txtventas.Clear()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Toolmsj.SetToolTip(btnsalir, "Click para salir de la aplicacion")
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnterminar_MouseHover(sender As Object, e As EventArgs) Handles btnterminar.MouseHover
        Toolmsj.SetToolTip(btnterminar, "Termina de agragar al listado")
        Toolmsj.ToolTipTitle = "Ventas"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnnuevo_MouseHover(sender As Object, e As EventArgs) Handles btnnuevo.MouseHover
        Toolmsj.SetToolTip(btnnuevo, "Click para crear un nuevo listado")
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbalmacenes_MouseHover(sender As Object, e As EventArgs) Handles cmbalmacenes.MouseHover
        Toolmsj.SetToolTip(cmbalmacenes, "Debe elegir un almacen")
        Toolmsj.ToolTipTitle = "Almacenes"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Entradaguia.Show()
    End Sub
End Class