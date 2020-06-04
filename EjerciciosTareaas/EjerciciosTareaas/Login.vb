Imports System.ComponentModel

Public Class login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        If txtusuario.Text = "" Then
            txtcontraseña.Enabled = False
            lbcontraseña.Visible = False
            txtcontraseña.Visible = False
        Else
            txtcontraseña.Enabled = True
            lbcontraseña.Visible = True
            txtcontraseña.Visible = True
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Hide()
        bienvenida.Show()
    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        End
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged

    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        Dim usuario As String
        Dim contraseña, intentos As Integer
        Try
            If Me.ValidateChildren And txtusuario.Text <> String.Empty Then
                usuario = txtusuario.Text
                contraseña = txtcontraseña.Text
                If (usuario = "Julissa Chavarria") And (contraseña = "12345") Then
                    Me.Hide()
                    donante.Show()
                Else
                    MsgBox("Usuario o contraseña incorecto, verifique")
                    txtusuario.Clear()
                    txtcontraseña.Clear()
                    txtusuario.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalidacion.SetError(sender, "")
        Else
            Me.Errorvalidacion.SetError(sender, "Es campo obligatorio, ingrese el Usuario")
        End If
    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalidacion.SetError(sender, "")
        Else
            Me.Errorvalidacion.SetError(sender, "Es campo obligatorio, ingrese su contraseña")
        End If
    End Sub

    Private Sub btnver_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnver_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class