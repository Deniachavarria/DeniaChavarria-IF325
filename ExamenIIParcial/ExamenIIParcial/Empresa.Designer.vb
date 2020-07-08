<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empresa
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnventa = New System.Windows.Forms.Button()
        Me.btnproducto = New System.Windows.Forms.Button()
        Me.btncliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnminimizar = New System.Windows.Forms.PictureBox()
        Me.btnmaximizar = New System.Windows.Forms.PictureBox()
        Me.btnsalir = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ExamenIIParcial.My.Resources.Resources.APPLE
        Me.PictureBox1.Location = New System.Drawing.Point(78, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnventa)
        Me.GroupBox1.Controls.Add(Me.btnproducto)
        Me.GroupBox1.Controls.Add(Me.btncliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(59, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acceso"
        '
        'btnventa
        '
        Me.btnventa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnventa.Location = New System.Drawing.Point(57, 94)
        Me.btnventa.Name = "btnventa"
        Me.btnventa.Size = New System.Drawing.Size(106, 32)
        Me.btnventa.TabIndex = 2
        Me.btnventa.Text = "Venta"
        Me.btnventa.UseVisualStyleBackColor = False
        '
        'btnproducto
        '
        Me.btnproducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnproducto.Location = New System.Drawing.Point(57, 56)
        Me.btnproducto.Name = "btnproducto"
        Me.btnproducto.Size = New System.Drawing.Size(106, 32)
        Me.btnproducto.TabIndex = 1
        Me.btnproducto.Text = "Producto"
        Me.btnproducto.UseVisualStyleBackColor = False
        '
        'btncliente
        '
        Me.btncliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncliente.Location = New System.Drawing.Point(57, 18)
        Me.btncliente.Name = "btncliente"
        Me.btncliente.Size = New System.Drawing.Size(106, 32)
        Me.btncliente.TabIndex = 0
        Me.btncliente.Text = "Cliente"
        Me.btncliente.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.btnminimizar)
        Me.Panel1.Controls.Add(Me.btnmaximizar)
        Me.Panel1.Controls.Add(Me.btnsalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 26)
        Me.Panel1.TabIndex = 2
        '
        'btnminimizar
        '
        Me.btnminimizar.Image = Global.ExamenIIParcial.My.Resources.Resources.min
        Me.btnminimizar.Location = New System.Drawing.Point(219, 3)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(28, 20)
        Me.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnminimizar.TabIndex = 4
        Me.btnminimizar.TabStop = False
        '
        'btnmaximizar
        '
        Me.btnmaximizar.Image = Global.ExamenIIParcial.My.Resources.Resources.m
        Me.btnmaximizar.Location = New System.Drawing.Point(253, 3)
        Me.btnmaximizar.Name = "btnmaximizar"
        Me.btnmaximizar.Size = New System.Drawing.Size(28, 20)
        Me.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnmaximizar.TabIndex = 5
        Me.btnmaximizar.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Image = Global.ExamenIIParcial.My.Resources.Resources.x
        Me.btnsalir.Location = New System.Drawing.Point(287, 3)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(28, 20)
        Me.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.TabStop = False
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ExamenIIParcial.My.Resources.Resources.APPLE1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(323, 273)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnventa As Button
    Friend WithEvents btnproducto As Button
    Friend WithEvents btncliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnminimizar As PictureBox
    Friend WithEvents btnmaximizar As PictureBox
    Friend WithEvents btnsalir As PictureBox
    Friend WithEvents ToolTip As ToolTip
End Class
