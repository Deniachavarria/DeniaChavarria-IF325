Public Class donante
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim donante As Integer
        Select Case donante
            Case 0
                gbrvivo.Visible = True
                gbrmuerto.Visible = False
            Case 1
                gbrmuerto.Visible = True
                gbrvivo.Visible = False
        End Select
    End Sub

    Private Sub gbrvivo_Enter(sender As Object, e As EventArgs) Handles gbrvivo.Enter

    End Sub

    Private Sub gbrmuerto_Enter(sender As Object, e As EventArgs) Handles gbrmuerto.Enter

    End Sub

    Private Sub chbvivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbvivo.CheckedChanged
        If chbvivo.Checked = True Then
            chbmuerto.Enabled = False
            gbrvivo.Visible = True
        Else
            chbmuerto.Enabled = True
            gbrvivo.Visible = False
            txtnombre.Clear()
            txtcedula.Clear()
            cmborgano.ResetText()
            txtfecha.Clear()
        End If
    End Sub

    Private Sub chbmuerto_CheckedChanged(sender As Object, e As EventArgs) Handles chbmuerto.CheckedChanged
        If chbmuerto.Checked = True Then
            chbvivo.Enabled = False
            gbrmuerto.Visible = True
        Else
            chbvivo.Enabled = True
            gbrmuerto.Visible = False
            txtnombre1.Clear()
            txtcedula1.Clear()
            cmborgano1.ResetText()
            txtfecha1.Clear()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If txtnombre.Text = "" Then
            cedula.Visible = False
            organo.Visible = False
            fecha.Visible = False
            txtcedula.Visible = False
            cmborgano.Visible = False
            txtfecha.Visible = False
        ElseIf IsNumeric(txtnombre.Text) Then
            MsgBox("No se aceptan valores numericos", vbInformation)
            txtnombre.Clear()
        Else
            cedula.Visible = True
            txtcedula.Visible = True
            organo.Visible = True
            cmborgano.Visible = True
            fecha.Visible = True
            txtfecha.Visible = True
        End If
    End Sub

    Private Sub txtcedula_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtcedula.MaskInputRejected
        If Not IsNumeric(txtcedula.Text) Then
            MsgBox("No se aceptan letras", vbInformation)
            cmborgano.ResetText()
        End If
    End Sub

    Private Sub cmborgano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmborgano.SelectedIndexChanged

    End Sub

    Private Sub txtfecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtfecha.MaskInputRejected
        If Not IsNumeric(txtfecha.Text) Then
            MsgBox("No se aceptan letras", vbInformation)
            txtfecha.Clear()
        End If
    End Sub

    Private Sub txtencargado_TextChanged(sender As Object, e As EventArgs) Handles txtencargado.TextChanged
        If txtencargado.Text = "" Then
            nombre1.Visible = False
            txtnombre1.Visible = False
            cedula1.Visible = False
            organo1.Visible = False
            fecha1.Visible = False
            txtcedula1.Visible = False
            cmborgano1.Visible = False
            txtfecha1.Visible = False
        ElseIf IsNumeric(txtnombre.Text) Then
            MsgBox("No se aceptan valores numericos", vbInformation)
            txtnombre.Clear()
        Else
            nombre1.Visible = True
            txtnombre1.Visible = True
            cedula1.Visible = True
            txtcedula1.Visible = True
            organo1.Visible = True
            cmborgano1.Visible = True
            fecha1.Visible = True
            txtfecha1.Visible = True
        End If
    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chbmuerto.Checked = False
        chbvivo.Checked = False
        txtnombre.Clear()
        txtnombre1.Clear()
        txtcedula.Clear()
        txtcedula1.Clear()
        cmborgano.ResetText()
        cmborgano1.ResetText()
        txtfecha.Clear()
        txtfecha1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtnombre.Text = "" Or txtcedula.Text = "" Or txtfecha.Text = "" Then
            MsgBox("Debe ingresar todo lo que se le solicita")
        Else
            MsgBox("Donante guardado con exíto. Gracias por donar")
            chbmuerto.Checked = False
            txtnombre1.Clear()
            txtcedula1.Clear()
            cmborgano1.ResetText()
            txtfecha1.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtnombre.Text = "" Or txtcedula.Text = "" Or txtfecha.Text = "" Then
            MsgBox("Debe ingresar todo lo que se le solicita")
        Else
            MsgBox("Donante guardado con exíto. Gracias por donar")
            chbvivo.Checked = False
            txtnombre.Clear()
            txtcedula.Clear()
            cmborgano.ResetText()
            txtfecha.Clear()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        bienvenida.Show()
    End Sub
End Class