<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresotextoventanaemergente
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbsuma = New System.Windows.Forms.ComboBox()
        Me.cmbresta = New System.Windows.Forms.ComboBox()
        Me.cmbmultiplicacion = New System.Windows.Forms.ComboBox()
        Me.cmbdivision = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtvalor)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar valor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.btncalcular)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 54)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbdivision)
        Me.GroupBox3.Controls.Add(Me.cmbmultiplicacion)
        Me.GroupBox3.Controls.Add(Me.cmbresta)
        Me.GroupBox3.Controls.Add(Me.cmbsuma)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 123)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(24, 19)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 0
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'txtvalor
        '
        Me.txtvalor.Enabled = False
        Me.txtvalor.Location = New System.Drawing.Point(105, 19)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 1
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(42, 19)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 0
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(123, 19)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 1
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Multiplicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Division"
        '
        'cmbsuma
        '
        Me.cmbsuma.FormattingEnabled = True
        Me.cmbsuma.Location = New System.Drawing.Point(6, 32)
        Me.cmbsuma.Name = "cmbsuma"
        Me.cmbsuma.Size = New System.Drawing.Size(91, 21)
        Me.cmbsuma.TabIndex = 4
        Me.cmbsuma.Text = "Mostrar suma"
        '
        'cmbresta
        '
        Me.cmbresta.FormattingEnabled = True
        Me.cmbresta.Location = New System.Drawing.Point(125, 32)
        Me.cmbresta.Name = "cmbresta"
        Me.cmbresta.Size = New System.Drawing.Size(101, 21)
        Me.cmbresta.TabIndex = 5
        Me.cmbresta.Text = "Mostrar Resta"
        '
        'cmbmultiplicacion
        '
        Me.cmbmultiplicacion.FormattingEnabled = True
        Me.cmbmultiplicacion.Location = New System.Drawing.Point(6, 81)
        Me.cmbmultiplicacion.Name = "cmbmultiplicacion"
        Me.cmbmultiplicacion.Size = New System.Drawing.Size(93, 21)
        Me.cmbmultiplicacion.TabIndex = 6
        Me.cmbmultiplicacion.Text = "Mostrar multiplicacion"
        '
        'cmbdivision
        '
        Me.cmbdivision.FormattingEnabled = True
        Me.cmbdivision.Location = New System.Drawing.Point(125, 81)
        Me.cmbdivision.Name = "cmbdivision"
        Me.cmbdivision.Size = New System.Drawing.Size(101, 21)
        Me.cmbdivision.TabIndex = 7
        Me.cmbdivision.Text = "Mostrar division"
        '
        'ingresotextoventanaemergente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 282)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ingresotextoventanaemergente"
        Me.Text = "ingresotextoventanaemergente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents btningresar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbdivision As ComboBox
    Friend WithEvents cmbmultiplicacion As ComboBox
    Friend WithEvents cmbresta As ComboBox
    Friend WithEvents cmbsuma As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
