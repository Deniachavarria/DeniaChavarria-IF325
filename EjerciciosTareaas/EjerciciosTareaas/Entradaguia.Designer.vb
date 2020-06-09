<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entradaguia
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
        Me.cmbentrada = New System.Windows.Forms.ComboBox()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbentrada
        '
        Me.cmbentrada.FormattingEnabled = True
        Me.cmbentrada.Items.AddRange(New Object() {"Ejercicio1", "Ejercicio2", "Ejercicio3", "Ejercicio4", "Ejercicio5"})
        Me.cmbentrada.Location = New System.Drawing.Point(50, 129)
        Me.cmbentrada.Name = "cmbentrada"
        Me.cmbentrada.Size = New System.Drawing.Size(248, 21)
        Me.cmbentrada.TabIndex = 0
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(315, 129)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 1
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.EjerciciosTareaas.My.Resources.Resources.BIENVENIDO
        Me.PictureBox1.Location = New System.Drawing.Point(54, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(355, 247)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Entradaguia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.EjerciciosTareaas.My.Resources.Resources.ff
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(442, 282)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.cmbentrada)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Entradaguia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradaguia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbentrada As ComboBox
    Friend WithEvents btnmostrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnsalir As Button
End Class
