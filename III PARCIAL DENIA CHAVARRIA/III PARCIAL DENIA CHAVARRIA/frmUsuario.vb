Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FrmUsuario
    Dim conexion As New conexion()

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()

    End Sub
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z09-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUserName.Clear()
        txtCorreo.Clear()
        txtPsw.Clear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo  no valido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuario()
            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.conexion.Close()

        End If


    End Sub
    Private Sub insertarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, nombre, apellido, userName, psw, rol, estado, correo) Then
                MessageBox.Show(" Usuario Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al guardar Usuario", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String
        idUsuario = txtCodigo.Text
        rol = cmbRol.Text
        Try
            If (conexion.eliminarUsuario(idUsuario, rol)) Then
                MsgBox("Usuario Dado de baja")

            Else
                MsgBox("Error al dar de baja usuario")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub modificarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, pws, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUserName.Text
        pws = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.modificarUsuario(idUsuario, nombre, apellido, userName, pws, rol, estado, correo) Then
                MessageBox.Show("El Usuario fue Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al modificar usuario", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BuscarUsuario()
        Dim Username As String
        Username = txtUserName.Text
        Try

            Datagrid = conexion.BuscarUsuario(Username)
            If Datagrid.Rows.Count <> 0 Then
                MessageBox.Show("Usuario ha sido encontrado ", "Buscando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Datagrid.DataSource = Datagrid
                txtUserName.Text = ""
            Else
                MessageBox.Show("El Usuario no ha sido  encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Datagrid.DataSource = Nothing
                txtUserName.Text = ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuario()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuario()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarUsuario()

    End Sub

    Private Sub chbencriptar_CheckedChanged(sender As Object, e As EventArgs) Handles chbencriptar.CheckedChanged
        Dim cadena, encriptar As String
        cadena = UCase(txtPsw.Text)

        If chbencriptar.Checked = True Then
            txtencriptar.Visible = True
            txtPsw.Visible = False
            For i = 1 To Len(cadena)
                encriptar = encriptar & "O" & Asc(Mid(cadena, i, 1))
            Next i
            txtencriptar.Text = encriptar
        Else
            txtencriptar.Visible = False
            txtPsw.Visible = True
        End If
    End Sub


    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function
    Private Sub ordenar()
        Me.txtNombre.Text = cambia(Me.txtNombre.Text)
        Me.txtApellido.Text = cambia(Me.txtApellido.Text)
    End Sub

    Private Sub minuscula()
        Dim minus As String
        minus = LCase(txtCorreo.Text)
        txtCorreo.Text = minus
    End Sub
    Private Sub btnordenar_Click(sender As Object, e As EventArgs) Handles btnordenar.Click
        ordenar()
        minuscula()

    End Sub
    Private Sub Datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles Datagrid.SelectionChanged


        'Obtén el número de la fila que se seleccionó en el Datagridview
        Dim FilaActual As Integer
        FilaActual = Datagrid.CurrentRow.Index

        txtCodigo.Text = Datagrid.Rows(FilaActual).Cells(0).Value
        txtNombre.Text = Datagrid.Rows(FilaActual).Cells(1).Value
        txtApellido.Text = Datagrid.Rows(FilaActual).Cells(2).Value
        txtPsw.Text = Datagrid.Rows(FilaActual).Cells(3).Value
        cmbRol.Text = Datagrid.Rows(FilaActual).Cells(4).Value
        txtUserName.Text = Datagrid.Rows(FilaActual).Cells(5).Value
        txtCorreo.Text = Datagrid.Rows(FilaActual).Cells(6).Value
    End Sub
End Class
