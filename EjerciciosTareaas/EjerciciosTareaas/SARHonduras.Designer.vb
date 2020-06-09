<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SARHonduras
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtneto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbimp = New System.Windows.Forms.CheckBox()
        Me.chbexcento = New System.Windows.Forms.CheckBox()
        Me.txtsueldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btncalcular)
        Me.GroupBox1.Controls.Add(Me.txtneto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chbimp)
        Me.GroupBox1.Controls.Add(Me.chbexcento)
        Me.GroupBox1.Controls.Add(Me.txtsueldo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sueldo"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button1.Location = New System.Drawing.Point(24, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btncalcular.Location = New System.Drawing.Point(105, 122)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 6
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'txtneto
        '
        Me.txtneto.Location = New System.Drawing.Point(80, 96)
        Me.txtneto.Name = "txtneto"
        Me.txtneto.Size = New System.Drawing.Size(100, 20)
        Me.txtneto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sueldo Neto"
        '
        'chbimp
        '
        Me.chbimp.AutoSize = True
        Me.chbimp.Enabled = False
        Me.chbimp.Location = New System.Drawing.Point(111, 61)
        Me.chbimp.Name = "chbimp"
        Me.chbimp.Size = New System.Drawing.Size(82, 17)
        Me.chbimp.TabIndex = 3
        Me.chbimp.Text = "IMPUESTO"
        Me.chbimp.UseVisualStyleBackColor = True
        '
        'chbexcento
        '
        Me.chbexcento.AutoSize = True
        Me.chbexcento.Enabled = False
        Me.chbexcento.Location = New System.Drawing.Point(6, 61)
        Me.chbexcento.Name = "chbexcento"
        Me.chbexcento.Size = New System.Drawing.Size(99, 17)
        Me.chbexcento.TabIndex = 2
        Me.chbexcento.Text = "EXCENTO IMP"
        Me.chbexcento.UseVisualStyleBackColor = True
        '
        'txtsueldo
        '
        Me.txtsueldo.Location = New System.Drawing.Point(63, 26)
        Me.txtsueldo.Name = "txtsueldo"
        Me.txtsueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtsueldo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sueldo"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button2.Location = New System.Drawing.Point(130, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnregresar.Location = New System.Drawing.Point(33, 179)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(95, 23)
        Me.btnregresar.TabIndex = 2
        Me.btnregresar.Text = "Regresar Menu"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'SARHonduras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EjerciciosTareaas.My.Resources.Resources.f
        Me.ClientSize = New System.Drawing.Size(224, 224)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SARHonduras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SARHonduras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chbimp As CheckBox
    Friend WithEvents chbexcento As CheckBox
    Friend WithEvents txtsueldo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents txtneto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnregresar As Button
End Class
