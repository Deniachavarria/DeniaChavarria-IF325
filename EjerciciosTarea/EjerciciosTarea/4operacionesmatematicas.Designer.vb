﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4operacionesmatematicas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvalor1 = New System.Windows.Forms.TextBox()
        Me.txtvalor2 = New System.Windows.Forms.TextBox()
        Me.chbsuma = New System.Windows.Forms.CheckBox()
        Me.chbmultiplicacion = New System.Windows.Forms.CheckBox()
        Me.chbresta = New System.Windows.Forms.CheckBox()
        Me.chbdivision = New System.Windows.Forms.CheckBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.HotPink
        Me.GroupBox1.Controls.Add(Me.txtresultado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btncalcular)
        Me.GroupBox1.Controls.Add(Me.chbdivision)
        Me.GroupBox1.Controls.Add(Me.chbresta)
        Me.GroupBox1.Controls.Add(Me.chbmultiplicacion)
        Me.GroupBox1.Controls.Add(Me.chbsuma)
        Me.GroupBox1.Controls.Add(Me.txtvalor2)
        Me.GroupBox1.Controls.Add(Me.txtvalor1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuatro operaciones basicas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor2"
        '
        'txtvalor1
        '
        Me.txtvalor1.BackColor = System.Drawing.Color.Thistle
        Me.txtvalor1.Location = New System.Drawing.Point(50, 22)
        Me.txtvalor1.Name = "txtvalor1"
        Me.txtvalor1.Size = New System.Drawing.Size(61, 20)
        Me.txtvalor1.TabIndex = 2
        '
        'txtvalor2
        '
        Me.txtvalor2.BackColor = System.Drawing.Color.Thistle
        Me.txtvalor2.Location = New System.Drawing.Point(172, 22)
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(61, 20)
        Me.txtvalor2.TabIndex = 3
        '
        'chbsuma
        '
        Me.chbsuma.AutoSize = True
        Me.chbsuma.BackColor = System.Drawing.Color.Thistle
        Me.chbsuma.Location = New System.Drawing.Point(41, 61)
        Me.chbsuma.Name = "chbsuma"
        Me.chbsuma.Size = New System.Drawing.Size(53, 17)
        Me.chbsuma.TabIndex = 4
        Me.chbsuma.Text = "Suma"
        Me.chbsuma.UseVisualStyleBackColor = False
        '
        'chbmultiplicacion
        '
        Me.chbmultiplicacion.AutoSize = True
        Me.chbmultiplicacion.BackColor = System.Drawing.Color.Thistle
        Me.chbmultiplicacion.Location = New System.Drawing.Point(41, 84)
        Me.chbmultiplicacion.Name = "chbmultiplicacion"
        Me.chbmultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.chbmultiplicacion.TabIndex = 5
        Me.chbmultiplicacion.Text = "Multiplicacion"
        Me.chbmultiplicacion.UseVisualStyleBackColor = False
        '
        'chbresta
        '
        Me.chbresta.AutoSize = True
        Me.chbresta.BackColor = System.Drawing.Color.Thistle
        Me.chbresta.Location = New System.Drawing.Point(141, 61)
        Me.chbresta.Name = "chbresta"
        Me.chbresta.Size = New System.Drawing.Size(54, 17)
        Me.chbresta.TabIndex = 6
        Me.chbresta.Text = "Resta"
        Me.chbresta.UseVisualStyleBackColor = False
        '
        'chbdivision
        '
        Me.chbdivision.AutoSize = True
        Me.chbdivision.BackColor = System.Drawing.Color.Thistle
        Me.chbdivision.Location = New System.Drawing.Point(141, 84)
        Me.chbdivision.Name = "chbdivision"
        Me.chbdivision.Size = New System.Drawing.Size(63, 17)
        Me.chbdivision.TabIndex = 7
        Me.chbdivision.Text = "Division"
        Me.chbdivision.UseVisualStyleBackColor = False
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.Thistle
        Me.btncalcular.Location = New System.Drawing.Point(29, 144)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(58, 23)
        Me.btncalcular.TabIndex = 8
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Thistle
        Me.btnnuevo.Location = New System.Drawing.Point(93, 144)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(58, 23)
        Me.btnnuevo.TabIndex = 9
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Thistle
        Me.btnsalir.Location = New System.Drawing.Point(157, 144)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(58, 23)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Resultado"
        '
        'txtresultado
        '
        Me.txtresultado.BackColor = System.Drawing.Color.Thistle
        Me.txtresultado.Enabled = False
        Me.txtresultado.Location = New System.Drawing.Point(120, 112)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(61, 20)
        Me.txtresultado.TabIndex = 12
        '
        '_4operacionesmatematicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(268, 203)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "_4operacionesmatematicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_4operacionesmatematicas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtresultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents chbdivision As CheckBox
    Friend WithEvents chbresta As CheckBox
    Friend WithEvents chbmultiplicacion As CheckBox
    Friend WithEvents chbsuma As CheckBox
    Friend WithEvents txtvalor2 As TextBox
    Friend WithEvents txtvalor1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
