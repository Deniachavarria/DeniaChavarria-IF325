Imports System.Runtime.InteropServices
Public Class MENU
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If PanelLateral.Width = 165 Then
            Timerocultarmenu.Enabled = True
        ElseIf PanelLateral.Width = 45 Then
            TimerMostrar.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timerocultarmenu.Tick
        If PanelLateral.Width <= 45 Then
            Me.Timerocultarmenu.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelLateral.Width >= 165 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width + 20
        End If
    End Sub

    Private Sub btnejercicio1_Click(sender As Object, e As EventArgs) Handles btnejercicio1.Click
        abrirFormulario(empleado)
    End Sub

    Private Sub PanelForms_Paint(sender As Object, e As PaintEventArgs) Handles PanelForms.Paint

    End Sub
    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelForms.Controls.Count > 0 Then
            Me.PanelForms.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelForms.Controls.Add(frm)
        Me.PanelForms.Tag = frm
        frm.Show()
    End Sub

    Private Sub Panelopciones_Paint(sender As Object, e As PaintEventArgs) Handles Panelopciones.Paint

    End Sub

    Private Sub Panelopciones_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelopciones.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        End
    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click
        btnmaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnmaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(productos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormulario(clientes)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirFormulario(Arreglos)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        abrirFormulario(libretadeahorro)

    End Sub

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class