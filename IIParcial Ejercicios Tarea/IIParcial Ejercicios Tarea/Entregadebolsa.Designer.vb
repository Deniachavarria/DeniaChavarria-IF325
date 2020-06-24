<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entregadebolsa
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.lbdireccion = New System.Windows.Forms.Label()
        Me.txtmunicipio = New System.Windows.Forms.TextBox()
        Me.lbmunicipio = New System.Windows.Forms.Label()
        Me.txtdepartamento = New System.Windows.Forms.TextBox()
        Me.lbdepartamento = New System.Windows.Forms.Label()
        Me.lbbolsa = New System.Windows.Forms.Label()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.lbestado = New System.Windows.Forms.Label()
        Me.lbintegrantes = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lbnombre = New System.Windows.Forms.Label()
        Me.txtidentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataRegistro = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtintegrantes = New System.Windows.Forms.TextBox()
        Me.chbbasica = New System.Windows.Forms.CheckBox()
        Me.chbregular = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chbregular)
        Me.GroupBox1.Controls.Add(Me.chbbasica)
        Me.GroupBox1.Controls.Add(Me.txtintegrantes)
        Me.GroupBox1.Controls.Add(Me.btnEntregar)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.lbdireccion)
        Me.GroupBox1.Controls.Add(Me.txtmunicipio)
        Me.GroupBox1.Controls.Add(Me.lbmunicipio)
        Me.GroupBox1.Controls.Add(Me.txtdepartamento)
        Me.GroupBox1.Controls.Add(Me.lbdepartamento)
        Me.GroupBox1.Controls.Add(Me.lbbolsa)
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.lbestado)
        Me.GroupBox1.Controls.Add(Me.lbintegrantes)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.lbnombre)
        Me.GroupBox1.Controls.Add(Me.txtidentidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 353)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(82, 310)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(122, 34)
        Me.btnEntregar.TabIndex = 18
        Me.btnEntregar.Text = "Entregar Bolsa Solidaria"
        Me.btnEntregar.UseVisualStyleBackColor = True
        Me.btnEntregar.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(82, 143)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 17
        Me.txtdireccion.Visible = False
        '
        'lbdireccion
        '
        Me.lbdireccion.AutoSize = True
        Me.lbdireccion.Location = New System.Drawing.Point(6, 146)
        Me.lbdireccion.Name = "lbdireccion"
        Me.lbdireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbdireccion.TabIndex = 16
        Me.lbdireccion.Text = "Direccion"
        Me.lbdireccion.Visible = False
        '
        'txtmunicipio
        '
        Me.txtmunicipio.Location = New System.Drawing.Point(82, 112)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(100, 20)
        Me.txtmunicipio.TabIndex = 15
        Me.txtmunicipio.Visible = False
        '
        'lbmunicipio
        '
        Me.lbmunicipio.AutoSize = True
        Me.lbmunicipio.Location = New System.Drawing.Point(6, 115)
        Me.lbmunicipio.Name = "lbmunicipio"
        Me.lbmunicipio.Size = New System.Drawing.Size(52, 13)
        Me.lbmunicipio.TabIndex = 14
        Me.lbmunicipio.Text = "Municipio"
        Me.lbmunicipio.Visible = False
        '
        'txtdepartamento
        '
        Me.txtdepartamento.Location = New System.Drawing.Point(82, 80)
        Me.txtdepartamento.Name = "txtdepartamento"
        Me.txtdepartamento.Size = New System.Drawing.Size(100, 20)
        Me.txtdepartamento.TabIndex = 13
        Me.txtdepartamento.Visible = False
        '
        'lbdepartamento
        '
        Me.lbdepartamento.AutoSize = True
        Me.lbdepartamento.Location = New System.Drawing.Point(6, 83)
        Me.lbdepartamento.Name = "lbdepartamento"
        Me.lbdepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lbdepartamento.TabIndex = 12
        Me.lbdepartamento.Text = "Departamento"
        Me.lbdepartamento.Visible = False
        '
        'lbbolsa
        '
        Me.lbbolsa.AutoSize = True
        Me.lbbolsa.Location = New System.Drawing.Point(5, 236)
        Me.lbbolsa.Name = "lbbolsa"
        Me.lbbolsa.Size = New System.Drawing.Size(71, 13)
        Me.lbbolsa.TabIndex = 8
        Me.lbbolsa.Text = "Tipo de bolsa"
        Me.lbbolsa.Visible = False
        '
        'cmbestado
        '
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Pobreza", "Extrema Pobreza"})
        Me.cmbestado.Location = New System.Drawing.Point(82, 174)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(102, 21)
        Me.cmbestado.TabIndex = 7
        Me.cmbestado.Visible = False
        '
        'lbestado
        '
        Me.lbestado.AutoSize = True
        Me.lbestado.Location = New System.Drawing.Point(5, 177)
        Me.lbestado.Name = "lbestado"
        Me.lbestado.Size = New System.Drawing.Size(40, 13)
        Me.lbestado.TabIndex = 6
        Me.lbestado.Text = "Estado"
        Me.lbestado.Visible = False
        '
        'lbintegrantes
        '
        Me.lbintegrantes.AutoSize = True
        Me.lbintegrantes.Location = New System.Drawing.Point(5, 207)
        Me.lbintegrantes.Name = "lbintegrantes"
        Me.lbintegrantes.Size = New System.Drawing.Size(118, 13)
        Me.lbintegrantes.TabIndex = 4
        Me.lbintegrantes.Text = "Integrantes de la familia"
        Me.lbintegrantes.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(63, 48)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(141, 20)
        Me.txtnombre.TabIndex = 3
        Me.txtnombre.Visible = False
        '
        'lbnombre
        '
        Me.lbnombre.AutoSize = True
        Me.lbnombre.Location = New System.Drawing.Point(6, 51)
        Me.lbnombre.Name = "lbnombre"
        Me.lbnombre.Size = New System.Drawing.Size(44, 13)
        Me.lbnombre.TabIndex = 2
        Me.lbnombre.Text = "Nombre"
        Me.lbnombre.Visible = False
        '
        'txtidentidad
        '
        Me.txtidentidad.Location = New System.Drawing.Point(63, 22)
        Me.txtidentidad.Mask = "0000-0000-00000"
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Size = New System.Drawing.Size(92, 20)
        Me.txtidentidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'dataRegistro
        '
        Me.dataRegistro.BackgroundColor = System.Drawing.Color.White
        Me.dataRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataRegistro.Location = New System.Drawing.Point(16, 22)
        Me.dataRegistro.Name = "dataRegistro"
        Me.dataRegistro.Size = New System.Drawing.Size(140, 293)
        Me.dataRegistro.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.dataRegistro)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 353)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(97, 324)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtintegrantes
        '
        Me.txtintegrantes.Location = New System.Drawing.Point(129, 204)
        Me.txtintegrantes.Name = "txtintegrantes"
        Me.txtintegrantes.Size = New System.Drawing.Size(42, 20)
        Me.txtintegrantes.TabIndex = 19
        Me.txtintegrantes.Visible = False
        '
        'chbbasica
        '
        Me.chbbasica.AutoSize = True
        Me.chbbasica.Enabled = False
        Me.chbbasica.Location = New System.Drawing.Point(90, 236)
        Me.chbbasica.Name = "chbbasica"
        Me.chbbasica.Size = New System.Drawing.Size(57, 17)
        Me.chbbasica.TabIndex = 20
        Me.chbbasica.Text = "basica"
        Me.chbbasica.UseVisualStyleBackColor = True
        Me.chbbasica.Visible = False
        '
        'chbregular
        '
        Me.chbregular.AutoSize = True
        Me.chbregular.Enabled = False
        Me.chbregular.Location = New System.Drawing.Point(91, 268)
        Me.chbregular.Name = "chbregular"
        Me.chbregular.Size = New System.Drawing.Size(63, 17)
        Me.chbregular.TabIndex = 21
        Me.chbregular.Text = "Regular"
        Me.chbregular.UseVisualStyleBackColor = True
        Me.chbregular.Visible = False
        '
        'Entregadebolsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.IIParcial_Ejercicios_Tarea.My.Resources.Resources.bol
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 372)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Entregadebolsa"
        Me.Text = "Entregadebolsa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidentidad As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEntregar As Button
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents lbdireccion As Label
    Friend WithEvents txtmunicipio As TextBox
    Friend WithEvents lbmunicipio As Label
    Friend WithEvents txtdepartamento As TextBox
    Friend WithEvents lbdepartamento As Label
    Friend WithEvents lbbolsa As Label
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents lbestado As Label
    Friend WithEvents lbintegrantes As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lbnombre As Label
    Friend WithEvents dataRegistro As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtintegrantes As TextBox
    Friend WithEvents chbregular As CheckBox
    Friend WithEvents chbbasica As CheckBox
End Class
