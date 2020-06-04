<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class donante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(donante))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbrvivo = New System.Windows.Forms.GroupBox()
        Me.gbrmuerto = New System.Windows.Forms.GroupBox()
        Me.chbvivo = New System.Windows.Forms.CheckBox()
        Me.chbmuerto = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.cedula = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.MaskedTextBox()
        Me.organo = New System.Windows.Forms.Label()
        Me.cmborgano = New System.Windows.Forms.ComboBox()
        Me.fecha = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtencargado = New System.Windows.Forms.TextBox()
        Me.encargado = New System.Windows.Forms.Label()
        Me.txtfecha1 = New System.Windows.Forms.MaskedTextBox()
        Me.fecha1 = New System.Windows.Forms.Label()
        Me.cmborgano1 = New System.Windows.Forms.ComboBox()
        Me.organo1 = New System.Windows.Forms.Label()
        Me.txtcedula1 = New System.Windows.Forms.MaskedTextBox()
        Me.cedula1 = New System.Windows.Forms.Label()
        Me.txtnombre1 = New System.Windows.Forms.TextBox()
        Me.nombre1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnend = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.gbrvivo.SuspendLayout()
        Me.gbrmuerto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donante"
        '
        'gbrvivo
        '
        Me.gbrvivo.BackColor = System.Drawing.Color.Transparent
        Me.gbrvivo.BackgroundImage = CType(resources.GetObject("gbrvivo.BackgroundImage"), System.Drawing.Image)
        Me.gbrvivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbrvivo.Controls.Add(Me.Button3)
        Me.gbrvivo.Controls.Add(Me.txtfecha)
        Me.gbrvivo.Controls.Add(Me.fecha)
        Me.gbrvivo.Controls.Add(Me.cmborgano)
        Me.gbrvivo.Controls.Add(Me.organo)
        Me.gbrvivo.Controls.Add(Me.txtcedula)
        Me.gbrvivo.Controls.Add(Me.cedula)
        Me.gbrvivo.Controls.Add(Me.txtnombre)
        Me.gbrvivo.Controls.Add(Me.Label2)
        Me.gbrvivo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbrvivo.Location = New System.Drawing.Point(16, 61)
        Me.gbrvivo.Name = "gbrvivo"
        Me.gbrvivo.Size = New System.Drawing.Size(273, 269)
        Me.gbrvivo.TabIndex = 2
        Me.gbrvivo.TabStop = False
        Me.gbrvivo.Text = "Donador Vivo"
        Me.gbrvivo.Visible = False
        '
        'gbrmuerto
        '
        Me.gbrmuerto.BackColor = System.Drawing.Color.Transparent
        Me.gbrmuerto.BackgroundImage = CType(resources.GetObject("gbrmuerto.BackgroundImage"), System.Drawing.Image)
        Me.gbrmuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbrmuerto.Controls.Add(Me.Button2)
        Me.gbrmuerto.Controls.Add(Me.txtencargado)
        Me.gbrmuerto.Controls.Add(Me.encargado)
        Me.gbrmuerto.Controls.Add(Me.txtfecha1)
        Me.gbrmuerto.Controls.Add(Me.fecha1)
        Me.gbrmuerto.Controls.Add(Me.cmborgano1)
        Me.gbrmuerto.Controls.Add(Me.organo1)
        Me.gbrmuerto.Controls.Add(Me.txtcedula1)
        Me.gbrmuerto.Controls.Add(Me.cedula1)
        Me.gbrmuerto.Controls.Add(Me.txtnombre1)
        Me.gbrmuerto.Controls.Add(Me.nombre1)
        Me.gbrmuerto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbrmuerto.Location = New System.Drawing.Point(295, 61)
        Me.gbrmuerto.Name = "gbrmuerto"
        Me.gbrmuerto.Size = New System.Drawing.Size(272, 269)
        Me.gbrmuerto.TabIndex = 3
        Me.gbrmuerto.TabStop = False
        Me.gbrmuerto.Text = "Donador Cadaverico"
        Me.gbrmuerto.Visible = False
        '
        'chbvivo
        '
        Me.chbvivo.AutoSize = True
        Me.chbvivo.BackColor = System.Drawing.Color.Transparent
        Me.chbvivo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbvivo.Location = New System.Drawing.Point(110, 8)
        Me.chbvivo.Name = "chbvivo"
        Me.chbvivo.Size = New System.Drawing.Size(57, 22)
        Me.chbvivo.TabIndex = 4
        Me.chbvivo.Text = "Vivo"
        Me.chbvivo.UseVisualStyleBackColor = False
        '
        'chbmuerto
        '
        Me.chbmuerto.AutoSize = True
        Me.chbmuerto.BackColor = System.Drawing.Color.Transparent
        Me.chbmuerto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbmuerto.Location = New System.Drawing.Point(110, 33)
        Me.chbmuerto.Name = "chbmuerto"
        Me.chbmuerto.Size = New System.Drawing.Size(95, 22)
        Me.chbmuerto.TabIndex = 5
        Me.chbmuerto.Text = "Cadaverico"
        Me.chbmuerto.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(98, 55)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(164, 25)
        Me.txtnombre.TabIndex = 1
        '
        'cedula
        '
        Me.cedula.AutoSize = True
        Me.cedula.Location = New System.Drawing.Point(17, 99)
        Me.cedula.Name = "cedula"
        Me.cedula.Size = New System.Drawing.Size(91, 18)
        Me.cedula.TabIndex = 2
        Me.cedula.Text = "Núm. Cédula"
        Me.cedula.Visible = False
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(123, 96)
        Me.txtcedula.Mask = "0000-0000-00000"
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(139, 25)
        Me.txtcedula.TabIndex = 3
        Me.txtcedula.Visible = False
        '
        'organo
        '
        Me.organo.AutoSize = True
        Me.organo.Location = New System.Drawing.Point(17, 140)
        Me.organo.Name = "organo"
        Me.organo.Size = New System.Drawing.Size(108, 18)
        Me.organo.TabIndex = 4
        Me.organo.Text = "Organo a donar"
        Me.organo.Visible = False
        '
        'cmborgano
        '
        Me.cmborgano.FormattingEnabled = True
        Me.cmborgano.Items.AddRange(New Object() {"Riñon", "Hueso", "Sangre", "Pulmon", "Pancreas", "Medula ósea", "Segmento de higado"})
        Me.cmborgano.Location = New System.Drawing.Point(140, 137)
        Me.cmborgano.Name = "cmborgano"
        Me.cmborgano.Size = New System.Drawing.Size(121, 26)
        Me.cmborgano.TabIndex = 5
        Me.cmborgano.Visible = False
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Location = New System.Drawing.Point(17, 187)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(146, 18)
        Me.fecha.TabIndex = 6
        Me.fecha.Text = "Fecha y hora a donar"
        Me.fecha.Visible = False
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(162, 184)
        Me.txtfecha.Mask = "00/00/0000 00:00"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 25)
        Me.txtfecha.TabIndex = 7
        Me.txtfecha.ValidatingType = GetType(Date)
        Me.txtfecha.Visible = False
        '
        'txtencargado
        '
        Me.txtencargado.Location = New System.Drawing.Point(95, 38)
        Me.txtencargado.Name = "txtencargado"
        Me.txtencargado.Size = New System.Drawing.Size(164, 25)
        Me.txtencargado.TabIndex = 27
        '
        'encargado
        '
        Me.encargado.AutoSize = True
        Me.encargado.Location = New System.Drawing.Point(16, 41)
        Me.encargado.Name = "encargado"
        Me.encargado.Size = New System.Drawing.Size(76, 18)
        Me.encargado.TabIndex = 26
        Me.encargado.Text = "Encargado"
        '
        'txtfecha1
        '
        Me.txtfecha1.Location = New System.Drawing.Point(161, 197)
        Me.txtfecha1.Mask = "00/00/0000 00:00"
        Me.txtfecha1.Name = "txtfecha1"
        Me.txtfecha1.Size = New System.Drawing.Size(100, 25)
        Me.txtfecha1.TabIndex = 25
        Me.txtfecha1.ValidatingType = GetType(Date)
        Me.txtfecha1.Visible = False
        '
        'fecha1
        '
        Me.fecha1.AutoSize = True
        Me.fecha1.Location = New System.Drawing.Point(16, 200)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(146, 18)
        Me.fecha1.TabIndex = 24
        Me.fecha1.Text = "Fecha y hora a donar"
        Me.fecha1.Visible = False
        '
        'cmborgano1
        '
        Me.cmborgano1.FormattingEnabled = True
        Me.cmborgano1.Items.AddRange(New Object() {"Piel", "Hueso", "Higado", "Riñones", "Corneas", "Valvulas", "Intestino", "Corazon", "Tendones", "Pulmones", "Pancreas", "Cartilagos", "Todos los organos"})
        Me.cmborgano1.Location = New System.Drawing.Point(137, 153)
        Me.cmborgano1.Name = "cmborgano1"
        Me.cmborgano1.Size = New System.Drawing.Size(121, 26)
        Me.cmborgano1.TabIndex = 23
        Me.cmborgano1.Visible = False
        '
        'organo1
        '
        Me.organo1.AutoSize = True
        Me.organo1.Location = New System.Drawing.Point(14, 156)
        Me.organo1.Name = "organo1"
        Me.organo1.Size = New System.Drawing.Size(108, 18)
        Me.organo1.TabIndex = 22
        Me.organo1.Text = "Organo a donar"
        Me.organo1.Visible = False
        '
        'txtcedula1
        '
        Me.txtcedula1.Location = New System.Drawing.Point(120, 112)
        Me.txtcedula1.Mask = "0000-0000-00000"
        Me.txtcedula1.Name = "txtcedula1"
        Me.txtcedula1.Size = New System.Drawing.Size(139, 25)
        Me.txtcedula1.TabIndex = 21
        Me.txtcedula1.Visible = False
        '
        'cedula1
        '
        Me.cedula1.AutoSize = True
        Me.cedula1.Location = New System.Drawing.Point(14, 115)
        Me.cedula1.Name = "cedula1"
        Me.cedula1.Size = New System.Drawing.Size(91, 18)
        Me.cedula1.TabIndex = 20
        Me.cedula1.Text = "Núm. Cédula"
        Me.cedula1.Visible = False
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(95, 71)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(164, 25)
        Me.txtnombre1.TabIndex = 19
        Me.txtnombre1.Visible = False
        '
        'nombre1
        '
        Me.nombre1.AutoSize = True
        Me.nombre1.Location = New System.Drawing.Point(14, 74)
        Me.nombre1.Name = "nombre1"
        Me.nombre1.Size = New System.Drawing.Size(58, 18)
        Me.nombre1.TabIndex = 18
        Me.nombre1.Text = "Nombre"
        Me.nombre1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(106, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnend
        '
        Me.btnend.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnend.Location = New System.Drawing.Point(354, 336)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(118, 29)
        Me.btnend.TabIndex = 8
        Me.btnend.Text = "End App"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(143, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Guardar Donate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(149, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 29)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Guardar Donate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(230, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 29)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Cerra Seción"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'donante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(588, 373)
        Me.Controls.Add(Me.gbrmuerto)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chbmuerto)
        Me.Controls.Add(Me.chbvivo)
        Me.Controls.Add(Me.gbrvivo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "donante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donantedeorgano"
        Me.gbrvivo.ResumeLayout(False)
        Me.gbrvivo.PerformLayout()
        Me.gbrmuerto.ResumeLayout(False)
        Me.gbrmuerto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbrvivo As GroupBox
    Friend WithEvents gbrmuerto As GroupBox
    Friend WithEvents chbvivo As CheckBox
    Friend WithEvents chbmuerto As CheckBox
    Friend WithEvents cedula As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcedula As MaskedTextBox
    Friend WithEvents txtfecha As MaskedTextBox
    Friend WithEvents fecha As Label
    Friend WithEvents cmborgano As ComboBox
    Friend WithEvents organo As Label
    Friend WithEvents txtencargado As TextBox
    Friend WithEvents encargado As Label
    Friend WithEvents txtfecha1 As MaskedTextBox
    Friend WithEvents fecha1 As Label
    Friend WithEvents cmborgano1 As ComboBox
    Friend WithEvents organo1 As Label
    Friend WithEvents txtcedula1 As MaskedTextBox
    Friend WithEvents cedula1 As Label
    Friend WithEvents txtnombre1 As TextBox
    Friend WithEvents nombre1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnend As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
