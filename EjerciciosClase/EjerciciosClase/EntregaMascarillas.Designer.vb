<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaMascarillas
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
        Me.txtDepartamentos = New System.Windows.Forms.TextBox()
        Me.btnsolicitar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.btnentregar = New System.Windows.Forms.Button()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnsolicitar)
        Me.GroupBox1.Controls.Add(Me.txtDepartamentos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por Departamento"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnentregar)
        Me.GroupBox2.Controls.Add(Me.txtMunicipios)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(227, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 134)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribucion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cant. Departamento"
        '
        'txtDepartamentos
        '
        Me.txtDepartamentos.Location = New System.Drawing.Point(114, 23)
        Me.txtDepartamentos.Name = "txtDepartamentos"
        Me.txtDepartamentos.Size = New System.Drawing.Size(64, 20)
        Me.txtDepartamentos.TabIndex = 1
        '
        'btnsolicitar
        '
        Me.btnsolicitar.Location = New System.Drawing.Point(54, 60)
        Me.btnsolicitar.Name = "btnsolicitar"
        Me.btnsolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnsolicitar.TabIndex = 2
        Me.btnsolicitar.Text = "Solicitar"
        Me.btnsolicitar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cant. por departamento"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(130, 101)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(64, 21)
        Me.cmbDepartamento.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cant. Municipios"
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Location = New System.Drawing.Point(97, 23)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(75, 20)
        Me.txtMunicipios.TabIndex = 1
        '
        'btnentregar
        '
        Me.btnentregar.Location = New System.Drawing.Point(63, 60)
        Me.btnentregar.Name = "btnentregar"
        Me.btnentregar.Size = New System.Drawing.Size(75, 23)
        Me.btnentregar.TabIndex = 2
        Me.btnentregar.Text = "Entregar"
        Me.btnentregar.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(327, 152)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 2
        '
        'EntregaMascarillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 179)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EntregaMascarillas"
        Me.Text = "EntregaMascarillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsolicitar As Button
    Friend WithEvents txtDepartamentos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnentregar As Button
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStock As TextBox
End Class
