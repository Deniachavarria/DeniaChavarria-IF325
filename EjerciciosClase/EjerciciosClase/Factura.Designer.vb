<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.chbdescuento = New System.Windows.Forms.CheckBox()
        Me.Cmbdescuento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtisv = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.chbisv = New System.Windows.Forms.CheckBox()
        Me.cmbisv = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbisv)
        Me.GroupBox1.Controls.Add(Me.chbisv)
        Me.GroupBox1.Controls.Add(Me.Cmbdescuento)
        Me.GroupBox1.Controls.Add(Me.chbdescuento)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. Unitario"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(68, 17)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(68, 49)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'chbdescuento
        '
        Me.chbdescuento.AutoSize = True
        Me.chbdescuento.Location = New System.Drawing.Point(9, 84)
        Me.chbdescuento.Name = "chbdescuento"
        Me.chbdescuento.Size = New System.Drawing.Size(113, 17)
        Me.chbdescuento.TabIndex = 4
        Me.chbdescuento.Text = "Aplicar Descuento"
        Me.chbdescuento.UseVisualStyleBackColor = True
        '
        'Cmbdescuento
        '
        Me.Cmbdescuento.FormattingEnabled = True
        Me.Cmbdescuento.Location = New System.Drawing.Point(20, 108)
        Me.Cmbdescuento.Name = "Cmbdescuento"
        Me.Cmbdescuento.Size = New System.Drawing.Size(121, 21)
        Me.Cmbdescuento.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.txtisv)
        Me.GroupBox2.Controls.Add(Me.txtdescuento)
        Me.GroupBox2.Controls.Add(Me.txtsubtotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ISV 15%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(62, 17)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 4
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(62, 49)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 5
        '
        'txtisv
        '
        Me.txtisv.Location = New System.Drawing.Point(62, 82)
        Me.txtisv.Name = "txtisv"
        Me.txtisv.Size = New System.Drawing.Size(100, 20)
        Me.txtisv.TabIndex = 6
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(62, 114)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 7
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(202, 148)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 2
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(202, 178)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 3
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(202, 208)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'chbisv
        '
        Me.chbisv.AutoSize = True
        Me.chbisv.Location = New System.Drawing.Point(7, 136)
        Me.chbisv.Name = "chbisv"
        Me.chbisv.Size = New System.Drawing.Size(78, 17)
        Me.chbisv.TabIndex = 6
        Me.chbisv.Text = "Aplicar ISV"
        Me.chbisv.UseVisualStyleBackColor = True
        '
        'cmbisv
        '
        Me.cmbisv.FormattingEnabled = True
        Me.cmbisv.Location = New System.Drawing.Point(20, 160)
        Me.cmbisv.Name = "cmbisv"
        Me.cmbisv.Size = New System.Drawing.Size(121, 21)
        Me.cmbisv.TabIndex = 7
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(288, 362)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cmbdescuento As ComboBox
    Friend WithEvents chbdescuento As CheckBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents cmbisv As ComboBox
    Friend WithEvents chbisv As CheckBox
End Class
