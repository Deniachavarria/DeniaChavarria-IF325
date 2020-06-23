<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entradaalexamen
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
        Me.grbcrearusuario = New System.Windows.Forms.GroupBox()
        Me.txtconfirmo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnusuarioo = New System.Windows.Forms.Button()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Toolmsj = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbcontraseña = New System.Windows.Forms.Label()
        Me.txtusuarioco = New System.Windows.Forms.TextBox()
        Me.txtcontraseñaco = New System.Windows.Forms.TextBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grbiniciar = New System.Windows.Forms.GroupBox()
        Me.Errorvalidating = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbcrearusuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbiniciar.SuspendLayout()
        CType(Me.Errorvalidating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbcrearusuario
        '
        Me.grbcrearusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grbcrearusuario.BackgroundImage = Global.Examenes.My.Resources.Resources.en
        Me.grbcrearusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grbcrearusuario.Controls.Add(Me.txtconfirmo)
        Me.grbcrearusuario.Controls.Add(Me.Label4)
        Me.grbcrearusuario.Controls.Add(Me.btnusuarioo)
        Me.grbcrearusuario.Controls.Add(Me.txtcontraseña)
        Me.grbcrearusuario.Controls.Add(Me.Label2)
        Me.grbcrearusuario.Controls.Add(Me.txtusuario)
        Me.grbcrearusuario.Controls.Add(Me.Label1)
        Me.grbcrearusuario.Location = New System.Drawing.Point(295, 83)
        Me.grbcrearusuario.Name = "grbcrearusuario"
        Me.grbcrearusuario.Size = New System.Drawing.Size(207, 181)
        Me.grbcrearusuario.TabIndex = 0
        Me.grbcrearusuario.TabStop = False
        Me.grbcrearusuario.Text = "Crear Usuario"
        Me.grbcrearusuario.Visible = False
        '
        'txtconfirmo
        '
        Me.txtconfirmo.Location = New System.Drawing.Point(107, 86)
        Me.txtconfirmo.Name = "txtconfirmo"
        Me.txtconfirmo.Size = New System.Drawing.Size(88, 20)
        Me.txtconfirmo.TabIndex = 7
        Me.txtconfirmo.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Sitka Subheading", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "C. CONTRASEÑA"
        '
        'btnusuarioo
        '
        Me.btnusuarioo.Location = New System.Drawing.Point(116, 123)
        Me.btnusuarioo.Name = "btnusuarioo"
        Me.btnusuarioo.Size = New System.Drawing.Size(79, 23)
        Me.btnusuarioo.TabIndex = 4
        Me.btnusuarioo.Text = "Confirmar"
        Me.btnusuarioo.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(95, 60)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtcontraseña.TabIndex = 3
        Me.txtcontraseña.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Subheading", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONTRASEÑA"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(95, 34)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtusuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(182, 299)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(107, 23)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "Nuevo Usuario"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Lbcontraseña
        '
        Me.Lbcontraseña.AutoSize = True
        Me.Lbcontraseña.BackColor = System.Drawing.Color.Transparent
        Me.Lbcontraseña.Font = New System.Drawing.Font("Script MT Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbcontraseña.Location = New System.Drawing.Point(36, 191)
        Me.Lbcontraseña.Name = "Lbcontraseña"
        Me.Lbcontraseña.Size = New System.Drawing.Size(94, 23)
        Me.Lbcontraseña.TabIndex = 3
        Me.Lbcontraseña.Text = "Contraseña"
        '
        'txtusuarioco
        '
        Me.txtusuarioco.Location = New System.Drawing.Point(123, 151)
        Me.txtusuarioco.Name = "txtusuarioco"
        Me.txtusuarioco.Size = New System.Drawing.Size(105, 20)
        Me.txtusuarioco.TabIndex = 4
        '
        'txtcontraseñaco
        '
        Me.txtcontraseñaco.Location = New System.Drawing.Point(136, 191)
        Me.txtcontraseñaco.Name = "txtcontraseñaco"
        Me.txtcontraseñaco.Size = New System.Drawing.Size(100, 20)
        Me.txtcontraseñaco.TabIndex = 5
        Me.txtcontraseñaco.UseSystemPasswordChar = True
        '
        'btniniciar
        '
        Me.btniniciar.Location = New System.Drawing.Point(128, 229)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(95, 23)
        Me.btniniciar.TabIndex = 6
        Me.btniniciar.Text = "Iniciar Seccion"
        Me.btniniciar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Examenes.My.Resources.Resources.staygif
        Me.PictureBox1.Location = New System.Drawing.Point(58, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'grbiniciar
        '
        Me.grbiniciar.BackgroundImage = Global.Examenes.My.Resources.Resources.em
        Me.grbiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grbiniciar.Controls.Add(Me.PictureBox1)
        Me.grbiniciar.Controls.Add(Me.Label3)
        Me.grbiniciar.Controls.Add(Me.btniniciar)
        Me.grbiniciar.Controls.Add(Me.Lbcontraseña)
        Me.grbiniciar.Controls.Add(Me.txtcontraseñaco)
        Me.grbiniciar.Controls.Add(Me.txtusuarioco)
        Me.grbiniciar.Location = New System.Drawing.Point(12, 12)
        Me.grbiniciar.Name = "grbiniciar"
        Me.grbiniciar.Size = New System.Drawing.Size(277, 281)
        Me.grbiniciar.TabIndex = 8
        Me.grbiniciar.TabStop = False
        Me.grbiniciar.Text = "Iniciar Seccion"
        '
        'Errorvalidating
        '
        Me.Errorvalidating.ContainerControl = Me
        '
        'entradaalexamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Examenes.My.Resources.Resources.entada
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(511, 339)
        Me.Controls.Add(Me.grbiniciar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.grbcrearusuario)
        Me.Name = "entradaalexamen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.grbcrearusuario.ResumeLayout(False)
        Me.grbcrearusuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbiniciar.ResumeLayout(False)
        Me.grbiniciar.PerformLayout()
        CType(Me.Errorvalidating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbcrearusuario As GroupBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnusuarioo As Button
    Friend WithEvents Toolmsj As ToolTip
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbcontraseña As Label
    Friend WithEvents txtusuarioco As TextBox
    Friend WithEvents txtcontraseñaco As TextBox
    Friend WithEvents btniniciar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grbiniciar As GroupBox
    Friend WithEvents txtconfirmo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Errorvalidating As ErrorProvider
End Class
