Public Class Empresa
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnproducto.Click
        Me.Hide()
        producto.Show()
    End Sub

    Private Sub btncliente_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        Me.Hide()
        cliente.Show()
    End Sub

    Private Sub btnventa_Click(sender As Object, e As EventArgs) Handles btnventa.Click
        Me.Hide()
        Venta.Show()
    End Sub

    Private Sub btncliente_MouseHover(sender As Object, e As EventArgs) Handles btncliente.MouseHover
        ToolTip.SetToolTip(btncliente, "Lo dirige a registrar o ver cliente")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnproducto_MouseHover(sender As Object, e As EventArgs) Handles btnproducto.MouseHover
        ToolTip.SetToolTip(btnproducto, "Lo dirige al registrar un producto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnventa_MouseHover(sender As Object, e As EventArgs) Handles btnventa.MouseHover
        ToolTip.SetToolTip(btnventa, "Lo dirige a realizar una venta")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnsalir_MouseHover(sender As Object, e As EventArgs) Handles btnsalir.MouseHover
        ToolTip.SetToolTip(btnsalir, "Abandona el programa")
        ToolTip.ToolTipTitle = "Precaucion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click
        btnmaximizar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnregistro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnminimizar_MouseHover(sender As Object, e As EventArgs) Handles btnminimizar.MouseHover
        ToolTip.SetToolTip(btnminimizar, "Minimiza el programa")
        ToolTip.ToolTipTitle = "Precaucion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmaximizar_MouseHover(sender As Object, e As EventArgs) Handles btnmaximizar.MouseHover
        ToolTip.SetToolTip(btnmaximizar, "Maximiza el programa")
        ToolTip.ToolTipTitle = "Precaucion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class