Public Class SARHonduras
    Private Sub txtsueldo_TextChanged(sender As Object, e As EventArgs) Handles txtsueldo.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim si, excento, imp1, imp2, sueldo As Double
        excento = 16582.92
        imp1 = 23536.61
        imp2 = 50317.69

        If txtsueldo.Text <= excento Then
            sueldo = txtsueldo.Text
            chbexcento.Checked = True
            chbimp.Checked = False
            MsgBox(" Usted esta excento del impuesto")
        ElseIf txtsueldo.Text >= 16528.93 Or txtsueldo.Text <= imp1 Then
            chbexcento.Checked = False
            chbimp.Checked = True
            MsgBox(" Usted no esta excento al impuesto de 15%")
            sueldo = txtsueldo.Text * 0.15
        ElseIf txtsueldo.Text > imp1 Or txtsueldo.Text <= imp2 Then
            chbexcento.Checked = False
            chbimp.Checked = True
            MsgBox(" Usted no esta excento al impuesto de 20%")
            sueldo = txtsueldo.Text * 0.2
        Else
            chbexcento.Checked = False
            chbimp.Checked = True
            MsgBox(" Usted no esta excento al impuesto de 25%")
            sueldo = txtsueldo.Text * 0.25
        End If
        txtneto.Text = sueldo + txtsueldo.Text
    End Sub

    Private Sub SARHonduras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtsueldo.Clear()
        txtneto.Clear()
        chbexcento.Checked = False
        chbimp.Checked = False
        txtsueldo.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Entradaguia.Show()
    End Sub
End Class