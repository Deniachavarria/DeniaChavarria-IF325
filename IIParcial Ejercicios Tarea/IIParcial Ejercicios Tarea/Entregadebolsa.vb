Public Class Entregadebolsa
    Private Sub ocultar()
        txtnombre.Visible = False
        txtdepartamento.Visible = False
        txtmunicipio.Visible = False
        txtdireccion.Visible = False
        cmbestado.Visible = False
        txtintegrantes.Visible = False
        chbbasica.Visible = False
        chbregular.Visible = False
        lbnombre.Visible = False
        lbdepartamento.Visible = False
        lbmunicipio.Visible = False
        lbdireccion.Visible = False
        lbestado.Visible = False
        lbbolsa.Visible = False
        lbintegrantes.Visible = False
        btnEntregar.Visible = False
    End Sub
    Private Sub mostrar()
        txtnombre.Visible = True
        txtdepartamento.Visible = True
        txtmunicipio.Visible = True
        txtdireccion.Visible = True
        cmbestado.Visible = True
        txtintegrantes.Visible = True
        chbbasica.Visible = True
        chbregular.Visible = True
        lbnombre.Visible = True
        lbdepartamento.Visible = True
        lbmunicipio.Visible = True
        lbdireccion.Visible = True
        lbestado.Visible = True
        lbbolsa.Visible = True
        lbintegrantes.Visible = True
        btnEntregar.Visible = True
    End Sub

    Private Sub txtidentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtidentidad.MaskInputRejected
        If txtidentidad.Text = "" Then
            MsgBox("Debe Ingresar corectamente su numero de identidad, no puede quedar vacio", vbInformation)
            ocultar()
        Else
            mostrar()
        End If
    End Sub




    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                 AndAlso Not Char.IsControl(e.KeyChar) _
                 AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub checkPobreza_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub checkExtrema_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub checkBasica_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub checkRegular_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtidentidad.MouseHover
        ToolTip1.SetToolTip(txtidentidad, "Ingrese numero de Identidad")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click

        Dim existeElDato As Boolean = False
        For Each itm As DataGridViewRow In dataRegistro.Rows
            If itm.Cells(0).Value = txtidentidad.Text Then
                existeElDato = True
            End If
        Next
        If Me.dataRegistro.Rows.Count > 0 AndAlso existeElDato = True Then
            MessageBox.Show("Ya se le entrego a esta persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtidentidad.Text = ""
            txtnombre.Text = ""
            txtintegrantes.Text = ""
            txtdireccion.Text = ""
            chbbasica.Checked = False
            chbregular.Checked = False
            cmbestado.Text = ""
        Else
            dataRegistro.Rows.Add(txtidentidad.Text, txtnombre.Text, txtintegrantes.Text, txtdireccion.Text, cmbestado.Text)
            txtidentidad.Text = ""
            txtnombre.Text = ""
            txtintegrantes.Text = ""
            txtdireccion.Text = ""
            chbbasica.Checked = False
            chbregular.Checked = False
            cmbestado.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub cmbbolsa_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Entregadebolsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtintegrantes_TextChanged(sender As Object, e As EventArgs) Handles txtintegrantes.TextChanged
        If txtintegrantes.Text >= 1 & txtintegrantes.Text <= 3 Then
            chbbasica.Checked = True
            chbbasica.Enabled = True
            chbregular.Enabled = False
        ElseIf txtintegrantes.Text >= 4 Then
            chbregular.Checked = True
            chbregular.Enabled = True
            chbbasica.Enabled = False
        End If
        If txtintegrantes.Text = "" Then
            chbbasica.Enabled = False
            chbregular.Enabled = False
            chbbasica.Checked = False
            chbregular.Checked = False
        End If
    End Sub
End Class