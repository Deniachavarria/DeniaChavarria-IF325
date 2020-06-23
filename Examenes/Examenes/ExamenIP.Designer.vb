<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExamenIP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtrecuperados = New System.Windows.Forms.TextBox()
        Me.txtmuertos = New System.Windows.Forms.TextBox()
        Me.txtactivos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Errorvalidating = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnhistorial = New System.Windows.Forms.Button()
        Me.txtpruebasd = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtfallecidosd = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtrecuperadosd = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txttotalesd = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbhistorial = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbrecuperado = New System.Windows.Forms.CheckBox()
        Me.cmbmunicipios = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chbactivo = New System.Windows.Forms.CheckBox()
        Me.Labelpp = New System.Windows.Forms.Label()
        Me.chbmuerto = New System.Windows.Forms.CheckBox()
        Me.chbnegativo = New System.Windows.Forms.CheckBox()
        Me.chbpositivo = New System.Windows.Forms.CheckBox()
        Me.cmbdepartamento = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.MaskedTextBox()
        Me.Labelp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Toolmsj = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Errorvalidating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Gold
        Me.btnsalir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(387, 357)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Gold
        Me.btnnuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(41, 310)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 3
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtrecuperados
        '
        Me.txtrecuperados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecuperados.Location = New System.Drawing.Point(83, 87)
        Me.txtrecuperados.Name = "txtrecuperados"
        Me.txtrecuperados.Size = New System.Drawing.Size(50, 21)
        Me.txtrecuperados.TabIndex = 4
        '
        'txtmuertos
        '
        Me.txtmuertos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmuertos.Location = New System.Drawing.Point(137, 40)
        Me.txtmuertos.Name = "txtmuertos"
        Me.txtmuertos.Size = New System.Drawing.Size(51, 21)
        Me.txtmuertos.TabIndex = 5
        '
        'txtactivos
        '
        Me.txtactivos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtactivos.Location = New System.Drawing.Point(59, 40)
        Me.txtactivos.Name = "txtactivos"
        Me.txtactivos.Size = New System.Drawing.Size(51, 21)
        Me.txtactivos.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Activos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(80, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 14)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Recuperaddos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(136, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 14)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Muertos"
        '
        'Errorvalidating
        '
        Me.Errorvalidating.ContainerControl = Me
        '
        'Timer1
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.Examenes.My.Resources.Resources.qq
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.txtactivos)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtrecuperados)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtmuertos)
        Me.GroupBox3.Location = New System.Drawing.Point(229, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 116)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial Honduras"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.Examenes.My.Resources.Resources.q
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.btnhistorial)
        Me.GroupBox2.Controls.Add(Me.txtpruebasd)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtfallecidosd)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtrecuperadosd)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txttotalesd)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbhistorial)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(229, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 217)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial por departamento"
        '
        'btnhistorial
        '
        Me.btnhistorial.BackColor = System.Drawing.Color.Gold
        Me.btnhistorial.Location = New System.Drawing.Point(139, 187)
        Me.btnhistorial.Name = "btnhistorial"
        Me.btnhistorial.Size = New System.Drawing.Size(75, 23)
        Me.btnhistorial.TabIndex = 15
        Me.btnhistorial.Text = "Historial"
        Me.btnhistorial.UseVisualStyleBackColor = False
        '
        'txtpruebasd
        '
        Me.txtpruebasd.Location = New System.Drawing.Point(109, 160)
        Me.txtpruebasd.Name = "txtpruebasd"
        Me.txtpruebasd.Size = New System.Drawing.Size(100, 21)
        Me.txtpruebasd.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 163)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 14)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Pruebas totales"
        '
        'txtfallecidosd
        '
        Me.txtfallecidosd.Location = New System.Drawing.Point(109, 104)
        Me.txtfallecidosd.Name = "txtfallecidosd"
        Me.txtfallecidosd.Size = New System.Drawing.Size(100, 21)
        Me.txtfallecidosd.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 107)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 14)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Fallecidos"
        '
        'txtrecuperadosd
        '
        Me.txtrecuperadosd.Location = New System.Drawing.Point(109, 133)
        Me.txtrecuperadosd.Name = "txtrecuperadosd"
        Me.txtrecuperadosd.Size = New System.Drawing.Size(100, 21)
        Me.txtrecuperadosd.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 14)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Recuperados"
        '
        'txttotalesd
        '
        Me.txttotalesd.Location = New System.Drawing.Point(109, 74)
        Me.txttotalesd.Name = "txttotalesd"
        Me.txttotalesd.Size = New System.Drawing.Size(100, 21)
        Me.txttotalesd.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 14)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Casos Activos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(174, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 14)
        Me.Label15.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(60, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 14)
        Me.Label14.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 14)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Fecha"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(133, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 14)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Historial Depto."
        '
        'cmbhistorial
        '
        Me.cmbhistorial.FormattingEnabled = True
        Me.cmbhistorial.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbhistorial.Location = New System.Drawing.Point(109, 20)
        Me.cmbhistorial.Name = "cmbhistorial"
        Me.cmbhistorial.Size = New System.Drawing.Size(113, 22)
        Me.cmbhistorial.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Examenes.My.Resources.Resources.g
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.chbrecuperado)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.cmbmunicipios)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chbactivo)
        Me.GroupBox1.Controls.Add(Me.Labelpp)
        Me.GroupBox1.Controls.Add(Me.chbmuerto)
        Me.GroupBox1.Controls.Add(Me.chbnegativo)
        Me.GroupBox1.Controls.Add(Me.chbpositivo)
        Me.GroupBox1.Controls.Add(Me.cmbdepartamento)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.Labelp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Personal"
        '
        'chbrecuperado
        '
        Me.chbrecuperado.AutoSize = True
        Me.chbrecuperado.BackColor = System.Drawing.Color.Transparent
        Me.chbrecuperado.Location = New System.Drawing.Point(33, 213)
        Me.chbrecuperado.Name = "chbrecuperado"
        Me.chbrecuperado.Size = New System.Drawing.Size(98, 18)
        Me.chbrecuperado.TabIndex = 18
        Me.chbrecuperado.Text = "Recuperado"
        Me.chbrecuperado.UseVisualStyleBackColor = False
        '
        'cmbmunicipios
        '
        Me.cmbmunicipios.FormattingEnabled = True
        Me.cmbmunicipios.Items.AddRange(New Object() {"La Ceiba", "Tela", "Jutiapa", "La Masica", "San Francisco", "Arizona", "Esparta", "El Porvenir", "Trujillo", "Balfate", "Iriona", "Limón", "Sabá", "Santa Fe", "Santa Rosa de Aguán", "Sonaguera", "Tocoa", "Bonito Oriental", "Comayagua", "Ajuterique", "El Rosario", "Esquías", "Humuya", "La libertad", "Lamaní", "La Trinidad", "Lejamani", "Meambar", "Minas de Oro", "Ojos de Agua", "San Jerónimo (Honduras)", "San José de Comayagua", "San José del Potrero", "San Luis", "San Sebastián", "Siguatepeque", "Villa de San Antonio", "Las Lajas", "Taulabé", "Santa Rosa de Copán", "Cabañas", "Concepción", "Copán Ruinas", "Corquín", "Cucuyagua", "Dolores", "Dulce Nombre", "El Paraíso", "Florida", "La Jigua", "La Unión", "Nueva Arcadia", "San Agustín", "San Antonio", "San Jerónimo", "San José", "San Juan de Opoa", "San Nicolás", "San Pedro", "Santa Rita", "Trinidad de Copán", "Veracruz", "San Pedro Sula", "Choloma", "Omoa", "Pimienta", "Potrerillos", "Puerto Cortés", "San Antonio de Cortés", "San Francisco de Yojoa", "San Manuel", "Santa Cruz de Yojoa", "Villanueva", "La Lima", "Choluteca", "Apacilagua", "Concepción de María", "Duyure", "El Corpus", "El Triunfo", "Marcovia", "Morolica", "Namasigue", "Orocuina", "Pespire", "San Antonio de Flores", "San Isidro", "San José", "San Marcos de Colón", "Santa Ana de Yusguare", "Yuscarán", "Alauca", "Danlí", "El Paraíso", "Güinope", "Jacaleapa", "Liure", "Morocelí", "Oropolí", "Potrerillos", "San Antonio de Flores", "San Lucas", "San Matías", "Soledad", "Teupasenti", "Texiguat", "Vado Ancho", "Yauyupe", "Trojes", "Distrito Central", "Alubarén", "Cedros", "Curarén", "El Porvenir", "Guaimaca", "La Libertad", "La Venta", "Lepaterique", "Maraita", "Marale", "Nueva Armenia", "Ojojona", "Orica", "Reitoca", "Sabanagrande", "San Antonio de Oriente", "San Buenaventura", "San Ignacio", "San Juan de Flores", "San Miguelito", "Santa Ana", "Santa Lucía", "Talanga", "Tatumbla", "Valle de Ángeles", "Villa de San Francisco", "Vallecillo", "Puerto Lempira", "Brus Laguna", "Ahuas", "Juan Francisco Bulnes", "Ramón Villeda Morales", "Wampusirpe", "La Esperanza", "Camasca", "Colomoncagua", "Concepción", "Dolores", "Intibucá", "Jesús de Otoro", "Magdalena", "Masaguara", "San Antonio", "San Isidro", "San Juan", "San Marcos de la Sierra", "San Miguel Guancapla", "Santa Lucía", "Yamaranguila", "San Francisco de Opalaca", "Roatán", "Guanaja", "José Santos Guardiola", "Utila", "La Paz", "Aguanqueterique", "Cabañas", "Cane", "Chinacla", "Guajiquiro", "Lauterique", "Marcala", "Mercedes de Oriente", "Opatoro", "San Antonio del Norte", "San José", "San Juan", "San Pedro de Tutule", "Santa Ana", "Santa Elena", "Santa María", "Santiago de Puringla", "Yarula", "Gracias", "Belén", "Candelaria", "Cololaca", "Erandique", "Gualcince", "Guarita", "La Campa", "La Iguala", "Las Flores", "La Unión", "La Virtud", "Lepaera", "Mapulaca", "Piraera", "San Andrés", "San Francisco", "San Juan Guarita", "San Manuel Colohete", "San Rafael", "San Sebastián", "Santa Cruz", "Talgua", "Tambla", "Tomalá", "Valladolid", "Virginia", "San Marcos de Caiquín", "Ocotepeque", "Belén Gualcho", "Concepción", "Dolores Merendón", "Fraternidad", "La Encarnación", "La Labor", "Lucerna", "Mercedes", "San Fernando", "San Francisco del Valle", "San Jorge", "San Marcos", "Santa Fe", "Sensenti", "Sinuapa", "Juticalpa", "Campamento", "Catacamas", "Concordia", "Dulce Nombre de Culmí", "El Rosario", "Esquipulas del Norte", "Gualaco", "Guarizama", "Guata", "Guayape", "Jano", "La Unión", "Mangulile", "Manto", "Salamá", "San Esteban", "San Francisco de Becerra", "San Francisco de la Paz", "Santa María del Real", "Silca", "Yocón", "Patuca", "Santa Bárbara", "Arada", "Atima", "Azacualpa", "Ceguaca", "Concepción del Norte", "Concepción del Sur", "Chinda", "El Níspero", "Gualala", "Ilama", "Las Vegas", "Macuelizo", "Naranjito", "Nuevo Celilac", "Nueva Frontera", "Petoa", "Protección", "Quimistán", "San Francisco de Ojuera", "San José de las Colinas", "San Luis", "San Marcos", "San Nicolás", "San Pedro Zacapa", "San Vicente Centenario", "Santa Rita", "Trinidad", "Nacaome", "Alianza", "Amapala", "Aramecina", "Caridad", "Goascorán", "Langue", "San Francisco de Coray", "San Lorenzo", "Yoro", "Arenal", "El Negrito", "El Progreso", "Jocón", "Morazán", "Olanchito", "Santa Rita", "Sulaco", "Victoria", "Yorito"})
        Me.cmbmunicipios.Location = New System.Drawing.Point(98, 104)
        Me.cmbmunicipios.Name = "cmbmunicipios"
        Me.cmbmunicipios.Size = New System.Drawing.Size(99, 22)
        Me.cmbmunicipios.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(122, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(87, 245)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(110, 60)
        Me.txtdescripcion.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(4, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Descripcion"
        '
        'chbactivo
        '
        Me.chbactivo.AutoSize = True
        Me.chbactivo.BackColor = System.Drawing.Color.Transparent
        Me.chbactivo.Location = New System.Drawing.Point(128, 190)
        Me.chbactivo.Name = "chbactivo"
        Me.chbactivo.Size = New System.Drawing.Size(63, 18)
        Me.chbactivo.TabIndex = 13
        Me.chbactivo.Text = "Activo"
        Me.chbactivo.UseVisualStyleBackColor = False
        '
        'Labelpp
        '
        Me.Labelpp.AutoSize = True
        Me.Labelpp.BackColor = System.Drawing.Color.Transparent
        Me.Labelpp.Location = New System.Drawing.Point(4, 191)
        Me.Labelpp.Name = "Labelpp"
        Me.Labelpp.Size = New System.Drawing.Size(122, 14)
        Me.Labelpp.TabIndex = 12
        Me.Labelpp.Text = "Estado del paciente"
        '
        'chbmuerto
        '
        Me.chbmuerto.AutoSize = True
        Me.chbmuerto.BackColor = System.Drawing.Color.Transparent
        Me.chbmuerto.Location = New System.Drawing.Point(128, 213)
        Me.chbmuerto.Name = "chbmuerto"
        Me.chbmuerto.Size = New System.Drawing.Size(66, 18)
        Me.chbmuerto.TabIndex = 11
        Me.chbmuerto.Text = "Muerto"
        Me.chbmuerto.UseVisualStyleBackColor = False
        '
        'chbnegativo
        '
        Me.chbnegativo.AutoSize = True
        Me.chbnegativo.BackColor = System.Drawing.Color.Transparent
        Me.chbnegativo.Location = New System.Drawing.Point(114, 158)
        Me.chbnegativo.Name = "chbnegativo"
        Me.chbnegativo.Size = New System.Drawing.Size(78, 18)
        Me.chbnegativo.TabIndex = 10
        Me.chbnegativo.Text = "Negativo"
        Me.chbnegativo.UseVisualStyleBackColor = False
        '
        'chbpositivo
        '
        Me.chbpositivo.AutoSize = True
        Me.chbpositivo.BackColor = System.Drawing.Color.Transparent
        Me.chbpositivo.Location = New System.Drawing.Point(114, 135)
        Me.chbpositivo.Name = "chbpositivo"
        Me.chbpositivo.Size = New System.Drawing.Size(72, 18)
        Me.chbpositivo.TabIndex = 9
        Me.chbpositivo.Text = "positivo"
        Me.chbpositivo.UseVisualStyleBackColor = False
        '
        'cmbdepartamento
        '
        Me.cmbdepartamento.FormattingEnabled = True
        Me.cmbdepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbdepartamento.Location = New System.Drawing.Point(98, 77)
        Me.cmbdepartamento.Name = "cmbdepartamento"
        Me.cmbdepartamento.Size = New System.Drawing.Size(99, 22)
        Me.cmbdepartamento.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(69, 25)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 21)
        Me.txtnombre.TabIndex = 6
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(69, 51)
        Me.txtedad.Mask = "00"
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(36, 21)
        Me.txtedad.TabIndex = 5
        '
        'Labelp
        '
        Me.Labelp.AutoSize = True
        Me.Labelp.BackColor = System.Drawing.Color.Transparent
        Me.Labelp.Location = New System.Drawing.Point(7, 135)
        Me.Labelp.Name = "Labelp"
        Me.Labelp.Size = New System.Drawing.Size(111, 14)
        Me.Labelp.TabIndex = 4
        Me.Labelp.Text = "Prueba Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'ExamenIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 386)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExamenIP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExamenIP"
        CType(Me.Errorvalidating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbdepartamento As ComboBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtedad As MaskedTextBox
    Friend WithEvents Labelp As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chbactivo As CheckBox
    Friend WithEvents Labelpp As Label
    Friend WithEvents chbmuerto As CheckBox
    Friend WithEvents chbnegativo As CheckBox
    Friend WithEvents chbpositivo As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbhistorial As ComboBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtrecuperados As TextBox
    Friend WithEvents txtmuertos As TextBox
    Friend WithEvents txtactivos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Errorvalidating As ErrorProvider
    Friend WithEvents cmbmunicipios As ComboBox
    Friend WithEvents chbrecuperado As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label16 As Label
    Friend WithEvents txttotalesd As TextBox
    Friend WithEvents txtfallecidosd As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtrecuperadosd As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtpruebasd As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnhistorial As Button
    Friend WithEvents Toolmsj As ToolTip
End Class
