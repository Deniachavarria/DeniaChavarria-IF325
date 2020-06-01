<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturasencilla
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.chbdescuento = New System.Windows.Forms.CheckBox()
        Me.chbisv = New System.Windows.Forms.CheckBox()
        Me.cmbdescuento = New System.Windows.Forms.ComboBox()
        Me.cmbisv = New System.Windows.Forms.ComboBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtisv = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.cmbisv)
        Me.GroupBox1.Controls.Add(Me.cmbdescuento)
        Me.GroupBox1.Controls.Add(Me.chbisv)
        Me.GroupBox1.Controls.Add(Me.chbdescuento)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.txtisv)
        Me.GroupBox2.Controls.Add(Me.txtdescuento)
        Me.GroupBox2.Controls.Add(Me.txtsubtotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox2.Location = New System.Drawing.Point(354, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txtprecio.Location = New System.Drawing.Point(123, 22)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(77, 20)
        Me.txtprecio.TabIndex = 2
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txtcantidad.Location = New System.Drawing.Point(123, 53)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(77, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'chbdescuento
        '
        Me.chbdescuento.AutoSize = True
        Me.chbdescuento.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.chbdescuento.Location = New System.Drawing.Point(6, 78)
        Me.chbdescuento.Name = "chbdescuento"
        Me.chbdescuento.Size = New System.Drawing.Size(111, 17)
        Me.chbdescuento.TabIndex = 4
        Me.chbdescuento.Text = "Aplicar descuento"
        Me.chbdescuento.UseVisualStyleBackColor = False
        '
        'chbisv
        '
        Me.chbisv.AutoSize = True
        Me.chbisv.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.chbisv.Location = New System.Drawing.Point(123, 78)
        Me.chbisv.Name = "chbisv"
        Me.chbisv.Size = New System.Drawing.Size(126, 17)
        Me.chbisv.TabIndex = 5
        Me.chbisv.Text = "Aplicar Impuesto S/V"
        Me.chbisv.UseVisualStyleBackColor = False
        '
        'cmbdescuento
        '
        Me.cmbdescuento.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.cmbdescuento.Enabled = False
        Me.cmbdescuento.FormattingEnabled = True
        Me.cmbdescuento.Items.AddRange(New Object() {"10%", "15%", "20%", "25%", "30%", "35%"})
        Me.cmbdescuento.Location = New System.Drawing.Point(33, 101)
        Me.cmbdescuento.Name = "cmbdescuento"
        Me.cmbdescuento.Size = New System.Drawing.Size(51, 21)
        Me.cmbdescuento.TabIndex = 6
        '
        'cmbisv
        '
        Me.cmbisv.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.cmbisv.Enabled = False
        Me.cmbisv.FormattingEnabled = True
        Me.cmbisv.Items.AddRange(New Object() {"15%", "17%"})
        Me.cmbisv.Location = New System.Drawing.Point(150, 101)
        Me.cmbisv.Name = "cmbisv"
        Me.cmbisv.Size = New System.Drawing.Size(51, 21)
        Me.cmbisv.TabIndex = 7
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncalcular.Location = New System.Drawing.Point(273, 37)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 2
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnnuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnuevo.Location = New System.Drawing.Point(273, 68)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 3
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.Location = New System.Drawing.Point(273, 97)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Impuesto S/V"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Location = New System.Drawing.Point(84, 22)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 4
        '
        'txtdescuento
        '
        Me.txtdescuento.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Location = New System.Drawing.Point(84, 49)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 5
        '
        'txtisv
        '
        Me.txtisv.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txtisv.Enabled = False
        Me.txtisv.Location = New System.Drawing.Point(84, 76)
        Me.txtisv.Name = "txtisv"
        Me.txtisv.Size = New System.Drawing.Size(100, 20)
        Me.txtisv.TabIndex = 6
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(84, 102)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 7
        '
        'Facturasencilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(567, 160)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Facturasencilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturasencilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbisv As ComboBox
    Friend WithEvents cmbdescuento As ComboBox
    Friend WithEvents chbisv As CheckBox
    Friend WithEvents chbdescuento As CheckBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtisv As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
End Class
