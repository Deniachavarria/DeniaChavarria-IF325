<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xnumeros
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
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.cmbnumero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.grbresultado = New System.Windows.Forms.GroupBox()
        Me.txtingresados = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtimpar = New System.Windows.Forms.TextBox()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtpar = New System.Windows.Forms.TextBox()
        Me.txtnegativo = New System.Windows.Forms.TextBox()
        Me.txtpositivo = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Toolmsj = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grbresultado.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(87, 28)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 1
        '
        'cmbnumero
        '
        Me.cmbnumero.FormattingEnabled = True
        Me.cmbnumero.Location = New System.Drawing.Point(87, 63)
        Me.cmbnumero.Name = "cmbnumero"
        Me.cmbnumero.Size = New System.Drawing.Size(100, 21)
        Me.cmbnumero.TabIndex = 2
        Me.cmbnumero.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N. Positivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "N. Negativo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Impar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Suma"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btningresar)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.cmbnumero)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de valores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "C. de numeros"
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btningresar.Location = New System.Drawing.Point(24, 61)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(57, 23)
        Me.btningresar.TabIndex = 3
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'grbresultado
        '
        Me.grbresultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grbresultado.Controls.Add(Me.txtingresados)
        Me.grbresultado.Controls.Add(Me.Label7)
        Me.grbresultado.Controls.Add(Me.txtimpar)
        Me.grbresultado.Controls.Add(Me.txtsuma)
        Me.grbresultado.Controls.Add(Me.txtpar)
        Me.grbresultado.Controls.Add(Me.txtnegativo)
        Me.grbresultado.Controls.Add(Me.txtpositivo)
        Me.grbresultado.Controls.Add(Me.Label2)
        Me.grbresultado.Controls.Add(Me.Label3)
        Me.grbresultado.Controls.Add(Me.Label6)
        Me.grbresultado.Controls.Add(Me.Label4)
        Me.grbresultado.Controls.Add(Me.Label5)
        Me.grbresultado.Location = New System.Drawing.Point(218, 12)
        Me.grbresultado.Name = "grbresultado"
        Me.grbresultado.Size = New System.Drawing.Size(250, 100)
        Me.grbresultado.TabIndex = 9
        Me.grbresultado.TabStop = False
        Me.grbresultado.Text = "Resultado"
        '
        'txtingresados
        '
        Me.txtingresados.Location = New System.Drawing.Point(190, 68)
        Me.txtingresados.Name = "txtingresados"
        Me.txtingresados.Size = New System.Drawing.Size(42, 20)
        Me.txtingresados.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "N. Ingresados"
        '
        'txtimpar
        '
        Me.txtimpar.Location = New System.Drawing.Point(178, 39)
        Me.txtimpar.Name = "txtimpar"
        Me.txtimpar.Size = New System.Drawing.Size(54, 20)
        Me.txtimpar.TabIndex = 12
        '
        'txtsuma
        '
        Me.txtsuma.Location = New System.Drawing.Point(54, 68)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(54, 20)
        Me.txtsuma.TabIndex = 11
        '
        'txtpar
        '
        Me.txtpar.Location = New System.Drawing.Point(178, 13)
        Me.txtpar.Name = "txtpar"
        Me.txtpar.Size = New System.Drawing.Size(54, 20)
        Me.txtpar.TabIndex = 10
        '
        'txtnegativo
        '
        Me.txtnegativo.Location = New System.Drawing.Point(68, 39)
        Me.txtnegativo.Name = "txtnegativo"
        Me.txtnegativo.Size = New System.Drawing.Size(54, 20)
        Me.txtnegativo.TabIndex = 9
        '
        'txtpositivo
        '
        Me.txtpositivo.Location = New System.Drawing.Point(68, 13)
        Me.txtpositivo.Name = "txtpositivo"
        Me.txtpositivo.Size = New System.Drawing.Size(54, 20)
        Me.txtpositivo.TabIndex = 8
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnnuevo.Location = New System.Drawing.Point(205, 114)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 11
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsalir.Location = New System.Drawing.Point(286, 114)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnregresar.Location = New System.Drawing.Point(110, 114)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(89, 23)
        Me.btnregresar.TabIndex = 13
        Me.btnregresar.Text = "Regresar Menu"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'xnumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 149)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.grbresultado)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "xnumeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "xnumeros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbresultado.ResumeLayout(False)
        Me.grbresultado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents cmbnumero As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grbresultado As GroupBox
    Friend WithEvents txtimpar As TextBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtpar As TextBox
    Friend WithEvents txtnegativo As TextBox
    Friend WithEvents txtpositivo As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btningresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Toolmsj As ToolTip
    Friend WithEvents txtingresados As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnregresar As Button
End Class
