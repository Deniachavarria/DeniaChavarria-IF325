<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Me.Panelopciones = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnminimizar = New System.Windows.Forms.PictureBox()
        Me.btnmaximizar = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnejercicio1 = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Timerocultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.Panelopciones.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLateral.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelopciones
        '
        Me.Panelopciones.Controls.Add(Me.btnRestaurar)
        Me.Panelopciones.Controls.Add(Me.btnminimizar)
        Me.Panelopciones.Controls.Add(Me.btnmaximizar)
        Me.Panelopciones.Controls.Add(Me.btncerrar)
        Me.Panelopciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelopciones.Location = New System.Drawing.Point(0, 0)
        Me.Panelopciones.Name = "Panelopciones"
        Me.Panelopciones.Size = New System.Drawing.Size(532, 35)
        Me.Panelopciones.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Image = Global.IIParcial_Ejercicios_Clase.My.Resources.Resources.restaurar32px
        Me.btnRestaurar.Location = New System.Drawing.Point(461, 3)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 25)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        '
        'btnminimizar
        '
        Me.btnminimizar.Image = Global.IIParcial_Ejercicios_Clase.My.Resources.Resources.horizontal_line_48px
        Me.btnminimizar.Location = New System.Drawing.Point(429, 4)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(26, 25)
        Me.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnminimizar.TabIndex = 2
        Me.btnminimizar.TabStop = False
        '
        'btnmaximizar
        '
        Me.btnmaximizar.Image = Global.IIParcial_Ejercicios_Clase.My.Resources.Resources.mnimizar_64px
        Me.btnmaximizar.Location = New System.Drawing.Point(461, 4)
        Me.btnmaximizar.Name = "btnmaximizar"
        Me.btnmaximizar.Size = New System.Drawing.Size(30, 25)
        Me.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnmaximizar.TabIndex = 1
        Me.btnmaximizar.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Image = Global.IIParcial_Ejercicios_Clase.My.Resources.Resources.delete_48px
        Me.btncerrar.Location = New System.Drawing.Point(497, 4)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(32, 25)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.TabStop = False
        '
        'PanelLateral
        '
        Me.PanelLateral.Controls.Add(Me.Panel3)
        Me.PanelLateral.Controls.Add(Me.btnmenu)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 35)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(200, 316)
        Me.PanelLateral.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnejercicio1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 175)
        Me.Panel3.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(44, 130)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Libreta de ahorro"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(44, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Arreglos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(44, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Clientes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(44, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Producto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnejercicio1
        '
        Me.btnejercicio1.BackColor = System.Drawing.Color.White
        Me.btnejercicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnejercicio1.Location = New System.Drawing.Point(44, 72)
        Me.btnejercicio1.Name = "btnejercicio1"
        Me.btnejercicio1.Size = New System.Drawing.Size(117, 23)
        Me.btnejercicio1.TabIndex = 0
        Me.btnejercicio1.Text = "Empleado"
        Me.btnejercicio1.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmenu.Location = New System.Drawing.Point(0, 0)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(200, 23)
        Me.btnmenu.TabIndex = 0
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Timerocultarmenu
        '
        '
        'TimerMostrar
        '
        '
        'PanelForms
        '
        Me.PanelForms.BackgroundImage = Global.IIParcial_Ejercicios_Clase.My.Resources.Resources.tra
        Me.PanelForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(200, 35)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(332, 316)
        Me.PanelForms.TabIndex = 2
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 351)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.Panelopciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.Panelopciones.ResumeLayout(False)
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLateral.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panelopciones As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents btnmenu As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnejercicio1 As Button
    Friend WithEvents PanelForms As Panel
    Friend WithEvents Timerocultarmenu As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents btnmaximizar As PictureBox
    Friend WithEvents btnminimizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
