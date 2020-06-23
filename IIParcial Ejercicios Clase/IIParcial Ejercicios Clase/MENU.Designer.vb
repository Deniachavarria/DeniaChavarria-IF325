<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Me.Panelopciones = New System.Windows.Forms.Panel()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnejercicio1 = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.Timerocultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLateral.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelopciones
        '
        Me.Panelopciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelopciones.Location = New System.Drawing.Point(0, 0)
        Me.Panelopciones.Name = "Panelopciones"
        Me.Panelopciones.Size = New System.Drawing.Size(532, 35)
        Me.Panelopciones.TabIndex = 0
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
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.btnejercicio1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 1
        '
        'btnejercicio1
        '
        Me.btnejercicio1.BackColor = System.Drawing.Color.White
        Me.btnejercicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnejercicio1.Location = New System.Drawing.Point(12, 6)
        Me.btnejercicio1.Name = "btnejercicio1"
        Me.btnejercicio1.Size = New System.Drawing.Size(75, 23)
        Me.btnejercicio1.TabIndex = 0
        Me.btnejercicio1.Text = "ejercicio N1"
        Me.btnejercicio1.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmenu.Location = New System.Drawing.Point(0, 0)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(200, 23)
        Me.btnmenu.TabIndex = 0
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = False
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
        'Timerocultarmenu
        '
        '
        'TimerMostrar
        '
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
End Class
