<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class almacenes
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbalmacenes = New System.Windows.Forms.ComboBox()
        Me.grbvalores = New System.Windows.Forms.GroupBox()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.txtpromedio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtventas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlistado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Toolmsj = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.grbvalores.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacenes"
        '
        'cmbalmacenes
        '
        Me.cmbalmacenes.FormattingEnabled = True
        Me.cmbalmacenes.Items.AddRange(New Object() {"Almacen Tela", "Almacen Valle", "Almacen Taulabe", "Almacen La Ceiba", "Almacen San Pedro", "Almacen Choluteca", "Almacen Tegucigalpa", "Almacen Comayagua", "Almacen Ocotepeque", "Almacen Siguatepeque", "", ""})
        Me.cmbalmacenes.Location = New System.Drawing.Point(77, 17)
        Me.cmbalmacenes.Name = "cmbalmacenes"
        Me.cmbalmacenes.Size = New System.Drawing.Size(121, 21)
        Me.cmbalmacenes.TabIndex = 1
        '
        'grbvalores
        '
        Me.grbvalores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grbvalores.Controls.Add(Me.btnterminar)
        Me.grbvalores.Controls.Add(Me.txtpromedio)
        Me.grbvalores.Controls.Add(Me.Label3)
        Me.grbvalores.Controls.Add(Me.txtventas)
        Me.grbvalores.Controls.Add(Me.Button1)
        Me.grbvalores.Controls.Add(Me.txtcantidad)
        Me.grbvalores.Controls.Add(Me.Label2)
        Me.grbvalores.Location = New System.Drawing.Point(12, 58)
        Me.grbvalores.Name = "grbvalores"
        Me.grbvalores.Size = New System.Drawing.Size(172, 165)
        Me.grbvalores.TabIndex = 2
        Me.grbvalores.TabStop = False
        Me.grbvalores.Text = "Ingreso ventas mensuales"
        Me.grbvalores.Visible = False
        '
        'btnterminar
        '
        Me.btnterminar.BackColor = System.Drawing.Color.RosyBrown
        Me.btnterminar.Location = New System.Drawing.Point(91, 132)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(75, 23)
        Me.btnterminar.TabIndex = 6
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = False
        '
        'txtpromedio
        '
        Me.txtpromedio.Enabled = False
        Me.txtpromedio.Location = New System.Drawing.Point(86, 106)
        Me.txtpromedio.Name = "txtpromedio"
        Me.txtpromedio.Size = New System.Drawing.Size(76, 20)
        Me.txtpromedio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Venta Media"
        '
        'txtventas
        '
        Me.txtventas.Enabled = False
        Me.txtventas.Location = New System.Drawing.Point(86, 48)
        Me.txtventas.Multiline = True
        Me.txtventas.Name = "txtventas"
        Me.txtventas.Size = New System.Drawing.Size(76, 52)
        Me.txtventas.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.Location = New System.Drawing.Point(5, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(65, 22)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(38, 20)
        Me.txtcantidad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "C. ventas"
        '
        'txtlistado
        '
        Me.txtlistado.Location = New System.Drawing.Point(190, 70)
        Me.txtlistado.Multiline = True
        Me.txtlistado.Name = "txtlistado"
        Me.txtlistado.Size = New System.Drawing.Size(81, 153)
        Me.txtlistado.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Listado de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "venta > 10000"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.RosyBrown
        Me.btnnuevo.Location = New System.Drawing.Point(107, 229)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 5
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.RosyBrown
        Me.btnsalir.Location = New System.Drawing.Point(188, 229)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 6
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.RosyBrown
        Me.btnregresar.Location = New System.Drawing.Point(15, 229)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(88, 23)
        Me.btnregresar.TabIndex = 7
        Me.btnregresar.Text = "Regresar Menu"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(281, 261)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlistado)
        Me.Controls.Add(Me.grbvalores)
        Me.Controls.Add(Me.cmbalmacenes)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "almacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "almacenes"
        Me.grbvalores.ResumeLayout(False)
        Me.grbvalores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbalmacenes As ComboBox
    Friend WithEvents grbvalores As GroupBox
    Friend WithEvents txtpromedio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtventas As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlistado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnterminar As Button
    Friend WithEvents Toolmsj As ToolTip
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnregresar As Button
End Class
