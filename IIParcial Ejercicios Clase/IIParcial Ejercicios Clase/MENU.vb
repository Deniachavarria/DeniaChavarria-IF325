Public Class MENU
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

    End Sub
End Class