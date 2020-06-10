Imports System.ComponentModel

Public Class ExamenIP
    Dim pruebasatlantida, pruebascholuteca, pruebascolon, pruebascomayagua, pruebascopan, pruebascortes, pruebasocotepeque, pruebasolancho As Integer
    Dim pruebasfrancisco, pruebasparaiso, pruebasgracias, pruebasintibuca, pruebasislas, pruebaslapaz, pruebaslempira, pruebassantabar, pruebasvalle, pruebasyoro, leactivo, lemuertos, lerecuperados, oactivo, omuertos, orecuperados, olactivo, olmuertos, olrecuperados, sactivo, smuertos, srecuperados, vactivo, vmuertos, vrecuperados, yactivo, ymuertos, yrecuperados As Integer

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Labelp.Click

    End Sub

    Dim cactivo, cmuertos, crecuperados, aactivo, amuertos, arecuperados, chactivo, chmuertos, chrecuperados As Integer

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub Labelpp_Click(sender As Object, e As EventArgs) Handles Labelpp.Click

    End Sub

    Dim coactivo, comuertos, corecuperados, copactivo, copmuertos, coprecuperados, coractivo, cormuertos, correcuperados, pactivo, pmuertos, precuperados, factivo, fmuertos, frecuperados, gactivo, gmuertos, grecuperados, iactivo, imuertos, irecuperados, isactivo, ismuertos, isrecuperados, lactivo, lmuertos, lrecuperados As Integer
    Dim activom, muertosm, recuperadosm As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdepartamento.SelectedIndexChanged

    End Sub

    Private Sub chbpositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbpositivo.CheckedChanged
        If chbpositivo.Checked = True Then
            chbnegativo.Enabled = False
        Else
            chbnegativo.Enabled = True
        End If
    End Sub

    Private Sub chbnegativo_CheckedChanged(sender As Object, e As EventArgs) Handles chbnegativo.CheckedChanged
        If chbnegativo.Checked = True Then
            chbpositivo.Enabled = False
            chbactivo.Enabled = False
            chbmuerto.Enabled = False
            chbrecuperado.Enabled = False
        Else
            chbpositivo.Enabled = True
            chbactivo.Enabled = True
            chbmuerto.Enabled = True
            chbrecuperado.Enabled = True
        End If
    End Sub

    Private Sub chbactivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbactivo.CheckedChanged
        If chbactivo.Checked = True Then
            chbmuerto.Enabled = False
            chbrecuperado.Enabled = False
        Else
            chbmuerto.Enabled = True
            chbrecuperado.Enabled = True
        End If
    End Sub

    Private Sub chbmuerto_CheckedChanged(sender As Object, e As EventArgs) Handles chbmuerto.CheckedChanged
        If chbmuerto.Checked = True Then
            chbactivo.Enabled = False
            chbrecuperado.Enabled = False

        Else
            chbactivo.Enabled = True
            chbrecuperado.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbhistorial.SelectedIndexChanged
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.Errorvalidating.SetError(sender, "")
        Else
            Me.Errorvalidating.SetError(sender, "Es campo obligatorio, Seleccione un departamento")
        End If

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtnombre.Clear()
        txtedad.Clear()
        cmbdepartamento.ResetText()
        cmbmunicipios.ResetText()
        chbpositivo.Checked = False
        chbnegativo.Checked = False
        chbactivo.Checked = False
        chbrecuperado.Checked = False
        chbmuerto.Checked = False
        txtdescripcion.Clear()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Desea salir del programa", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        txtnombre.Focus()

    End Sub

    Private Sub ExamenIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnombre.Focus()

        Timer1.Start()
    End Sub

    Private Sub txtedad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtedad.MaskInputRejected

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalidating.SetError(sender, "")
        Else
            Me.Errorvalidating.SetError(sender, "Es campo obligatorio, ingrese su nombre")
        End If
    End Sub

    Private Sub cmbmunicipios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmunicipios.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbrecuperado.CheckedChanged
        If chbrecuperado.Checked = True Then
            chbactivo.Enabled = False
            chbmuerto.Enabled = False

        Else
            chbactivo.Enabled = True
            chbmuerto.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Paciente registrado")
        Select Case cmbdepartamento.SelectedIndex
            Case 0
                If chbpositivo.Checked = True Then
                    pruebasatlantida += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasatlantida += 1


                End If
                If chbactivo.Checked = True Then
                    aactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    amuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    arecuperados += 1
                End If
            Case 1
                If chbpositivo.Checked = True Then
                    pruebascholuteca += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebascholuteca += 1


                End If
                If chbactivo.Checked = True Then
                    chactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    chmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    chrecuperados += 1
                End If

            Case 2
                If chbpositivo.Checked = True Then
                    pruebascolon += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebascolon += 1


                End If
                If chbactivo.Checked = True Then
                    coactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    comuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    corecuperados += 1
                End If

            Case 3
                If chbpositivo.Checked = True Then
                    pruebascomayagua += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebascomayagua += 1


                End If
                If chbactivo.Checked = True Then
                    cactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    cmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    crecuperados += 1
                End If
            Case 4
                If chbpositivo.Checked = True Then
                    pruebascopan += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebascopan += 1


                End If
                If chbactivo.Checked = True Then
                    copactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    copmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    coprecuperados += 1
                End If

            Case 5
                If chbpositivo.Checked = True Then
                    pruebascortes += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebascortes += 1


                End If
                If chbactivo.Checked = True Then
                    coractivo += 1
                ElseIf chbmuerto.Checked = True Then
                    cormuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    correcuperados += 1
                End If

            Case 6
                If chbpositivo.Checked = True Then
                    pruebasparaiso += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasparaiso += 1


                End If
                If chbactivo.Checked = True Then
                    pactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    pmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    precuperados += 1
                End If

            Case 7
                If chbpositivo.Checked = True Then
                    pruebasfrancisco += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasfrancisco += 1


                End If
                If chbactivo.Checked = True Then
                    factivo += 1
                ElseIf chbmuerto.Checked = True Then
                    fmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    frecuperados += 1
                End If

            Case 8
                If chbpositivo.Checked = True Then
                    pruebasgracias += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasgracias += 1


                End If
                If chbactivo.Checked = True Then
                    gactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    gmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    grecuperados += 1
                End If

            Case 9
                If chbpositivo.Checked = True Then
                    pruebasintibuca += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasintibuca += 1


                End If
                If chbactivo.Checked = True Then
                    iactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    imuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    irecuperados += 1
                End If

            Case 10
                If chbpositivo.Checked = True Then
                    pruebasislas += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasislas += 1


                End If
                If chbactivo.Checked = True Then
                    isactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    ismuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    isrecuperados += 1
                End If

            Case 11
                If chbpositivo.Checked = True Then
                    pruebaslapaz += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebaslapaz += 1


                End If
                If chbactivo.Checked = True Then
                    lactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    lmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    lrecuperados += 1
                End If

            Case 12
                If chbpositivo.Checked = True Then
                    pruebaslempira += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebaslempira += 1


                End If
                If chbactivo.Checked = True Then
                    leactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    lemuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    lerecuperados += 1
                End If

            Case 13
                If chbpositivo.Checked = True Then
                    pruebasocotepeque += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasocotepeque += 1


                End If
                If chbactivo.Checked = True Then
                    oactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    omuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    orecuperados += 1
                End If

            Case 14
                If chbpositivo.Checked = True Then
                    pruebasolancho += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasolancho += 1


                End If
                If chbactivo.Checked = True Then
                    olactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    olmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    olrecuperados += 1
                End If

            Case 15
                If chbpositivo.Checked = True Then
                    pruebassantabar += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebassantabar += 1


                End If
                If chbactivo.Checked = True Then
                    sactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    smuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    srecuperados += 1
                End If

            Case 16
                If chbpositivo.Checked = True Then
                    pruebasvalle += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasvalle += 1


                End If
                If chbactivo.Checked = True Then
                    vactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    vmuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    vrecuperados += 1
                End If

            Case 17
                If chbpositivo.Checked = True Then
                    pruebasyoro += 1

                ElseIf chbnegativo.Checked = True Then
                    pruebasyoro += 1


                End If
                If chbactivo.Checked = True Then
                    yactivo += 1
                ElseIf chbmuerto.Checked = True Then
                    ymuertos += 1
                ElseIf chbrecuperado.Checked = True Then
                    yrecuperados += 1
                End If

        End Select

        If chbactivo.Checked = True Then
            activom += 1
            txtactivos.Text = activom
            txtmuertos.Text = muertosm
            txtrecuperados.Text = recuperadosm
        ElseIf chbmuerto.Checked = True Then
            muertosm += 1
            txtmuertos.Text = muertosm
            txtmuertos.Text = muertosm
            txtrecuperados.Text = recuperadosm
        ElseIf chbrecuperado.Checked = True Then
            recuperadosm += 1
            txtrecuperados.Text = recuperadosm
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txthistorial_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbdepartamento_Click(sender As Object, e As EventArgs) Handles cmbdepartamento.Click

    End Sub

    Private Sub cmbdepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cmbdepartamento.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.Errorvalidating.SetError(sender, "")
        Else
            Me.Errorvalidating.SetError(sender, "Es campo obligatorio, Seleccione un departamento")
        End If
    End Sub

    Private Sub cmbmunicipios_Validating(sender As Object, e As CancelEventArgs) Handles cmbmunicipios.Validating

    End Sub

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating

    End Sub

    Private Sub txttotalesd_TextChanged(sender As Object, e As EventArgs) Handles txttotalesd.TextChanged

    End Sub

    Private Sub txtpruebasd_TextChanged(sender As Object, e As EventArgs) Handles txtpruebasd.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnhistorial_Click(sender As Object, e As EventArgs) Handles btnhistorial.Click
        Select Case cmbhistorial.SelectedIndex
            Case 0
                txttotalesd.Text = aactivo
                txtfallecidosd.Text = amuertos
                txtrecuperadosd.Text = arecuperados
                txtpruebasd.Text = pruebasatlantida

            Case 1
                txttotalesd.Text = chactivo
                txtfallecidosd.Text = chmuertos
                txtrecuperadosd.Text = chrecuperados
                txtpruebasd.Text = pruebascholuteca

            Case 2
                txttotalesd.Text = coactivo
                txtfallecidosd.Text = comuertos
                txtrecuperadosd.Text = corecuperados
                txtpruebasd.Text = pruebascolon

            Case 3
                txttotalesd.Text = cactivo
                txtfallecidosd.Text = cmuertos
                txtrecuperadosd.Text = crecuperados
                txtpruebasd.Text = pruebascomayagua

            Case 4
                txttotalesd.Text = copactivo
                txtfallecidosd.Text = copmuertos
                txtrecuperadosd.Text = coprecuperados
                txtpruebasd.Text = pruebascopan

            Case 5
                txttotalesd.Text = coractivo
                txtfallecidosd.Text = cormuertos
                txtrecuperadosd.Text = correcuperados
                txtpruebasd.Text = pruebascortes

            Case 6
                txttotalesd.Text = pactivo
                txtfallecidosd.Text = pmuertos
                txtrecuperadosd.Text = precuperados
                txtpruebasd.Text = pruebasparaiso

            Case 7
                txttotalesd.Text = factivo
                txtfallecidosd.Text = fmuertos
                txtrecuperadosd.Text = frecuperados
                txtpruebasd.Text = pruebasfrancisco

            Case 8
                txttotalesd.Text = gactivo
                txtfallecidosd.Text = gmuertos
                txtrecuperadosd.Text = grecuperados
                txtpruebasd.Text = pruebasgracias

            Case 9
                txttotalesd.Text = iactivo
                txtfallecidosd.Text = imuertos
                txtrecuperadosd.Text = irecuperados
                txtpruebasd.Text = pruebasintibuca

            Case 10
                txttotalesd.Text = isactivo
                txtfallecidosd.Text = ismuertos
                txtrecuperadosd.Text = isrecuperados
                txtpruebasd.Text = pruebasislas

            Case 11
                txttotalesd.Text = lactivo
                txtfallecidosd.Text = lmuertos
                txtrecuperadosd.Text = lrecuperados
                txtpruebasd.Text = pruebaslapaz

            Case 12
                txttotalesd.Text = leactivo
                txtfallecidosd.Text = lemuertos
                txtrecuperadosd.Text = lerecuperados
                txtpruebasd.Text = pruebaslempira

            Case 13
                txttotalesd.Text = oactivo
                txtfallecidosd.Text = omuertos
                txtrecuperadosd.Text = orecuperados
                txtpruebasd.Text = pruebasocotepeque

            Case 14
                txttotalesd.Text = olactivo
                txtfallecidosd.Text = olmuertos
                txtrecuperadosd.Text = olrecuperados
                txtpruebasd.Text = pruebasolancho

            Case 15
                txttotalesd.Text = sactivo
                txtfallecidosd.Text = smuertos
                txtrecuperadosd.Text = srecuperados
                txtpruebasd.Text = pruebassantabar

            Case 16
                txttotalesd.Text = vactivo
                txtfallecidosd.Text = vmuertos
                txtrecuperadosd.Text = vrecuperados
                txtpruebasd.Text = pruebasvalle

            Case 17
                txttotalesd.Text = yactivo
                txtfallecidosd.Text = ymuertos
                txtrecuperadosd.Text = yrecuperados
                txtpruebasd.Text = pruebasyoro
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label14.Text = DateString
        Label15.Text = TimeOfDay


    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        Toolmsj.SetToolTip(txtnombre, "Debe ingresar su nombre")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        Toolmsj.SetToolTip(txtedad, "Debe ingresar su edad")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbdepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbdepartamento.MouseHover
        Toolmsj.SetToolTip(cmbdepartamento, "Debe seleccionar un departamento")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbmunicipios_MouseHover(sender As Object, e As EventArgs) Handles cmbmunicipios.MouseHover
        Toolmsj.SetToolTip(cmbmunicipios, "Debe seleccionar su municipio")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Labelp.MouseHover
        Toolmsj.SetToolTip(Labelp, "Debe dar click en la opcion corecta")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Labelpp_MouseHover(sender As Object, e As EventArgs) Handles Labelpp.MouseHover
        Toolmsj.SetToolTip(Labelpp, "Debe dar click en la opcion corecta")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtdescripcion.MouseHover
        Toolmsj.SetToolTip(txtdescripcion, "Debe ingresar una breve descripcion")
        Toolmsj.ToolTipTitle = "Paciente"
        Toolmsj.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class