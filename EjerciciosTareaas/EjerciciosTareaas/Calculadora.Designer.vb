<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.btnmulti = New System.Windows.Forms.Button()
        Me.btndivision = New System.Windows.Forms.Button()
        Me.btnp = New System.Windows.Forms.Button()
        Me.btnr = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtlista = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 71)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(21, 20)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(122, 56)
        Me.txtResultado.TabIndex = 0
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnsuma
        '
        Me.btnsuma.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsuma.Location = New System.Drawing.Point(115, 98)
        Me.btnsuma.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(28, 31)
        Me.btnsuma.TabIndex = 16
        Me.btnsuma.Text = "+"
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'btnresta
        '
        Me.btnresta.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresta.Location = New System.Drawing.Point(115, 135)
        Me.btnresta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(28, 31)
        Me.btnresta.TabIndex = 15
        Me.btnresta.Text = "-"
        Me.btnresta.UseVisualStyleBackColor = True
        '
        'btnmulti
        '
        Me.btnmulti.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmulti.Location = New System.Drawing.Point(115, 172)
        Me.btnmulti.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(28, 31)
        Me.btnmulti.TabIndex = 14
        Me.btnmulti.Text = "*"
        Me.btnmulti.UseVisualStyleBackColor = True
        '
        'btndivision
        '
        Me.btndivision.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivision.Location = New System.Drawing.Point(115, 209)
        Me.btndivision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btndivision.Name = "btndivision"
        Me.btndivision.Size = New System.Drawing.Size(28, 31)
        Me.btndivision.TabIndex = 13
        Me.btndivision.Text = "/"
        Me.btndivision.UseVisualStyleBackColor = True
        '
        'btnp
        '
        Me.btnp.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnp.Location = New System.Drawing.Point(49, 209)
        Me.btnp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(28, 31)
        Me.btnp.TabIndex = 12
        Me.btnp.Text = "."
        Me.btnp.UseVisualStyleBackColor = True
        '
        'btnr
        '
        Me.btnr.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnr.Location = New System.Drawing.Point(85, 209)
        Me.btnr.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnr.Name = "btnr"
        Me.btnr.Size = New System.Drawing.Size(28, 31)
        Me.btnr.TabIndex = 11
        Me.btnr.Text = "="
        Me.btnr.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(85, 98)
        Me.btn9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(28, 31)
        Me.btn9.TabIndex = 10
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(49, 98)
        Me.btn8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(28, 31)
        Me.btn8.TabIndex = 9
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(19, 98)
        Me.btn7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(28, 31)
        Me.btn7.TabIndex = 8
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(49, 135)
        Me.btn5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(28, 31)
        Me.btn5.TabIndex = 7
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(85, 135)
        Me.btn6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(28, 31)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(19, 135)
        Me.btn4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(28, 31)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(49, 172)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(28, 31)
        Me.btn2.TabIndex = 4
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(85, 172)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(28, 31)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(19, 171)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(28, 31)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(19, 209)
        Me.btn0.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(28, 31)
        Me.btn0.TabIndex = 1
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtlista)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(194, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(128, 258)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial de Resultados"
        '
        'txtlista
        '
        Me.txtlista.CausesValidation = False
        Me.txtlista.Enabled = False
        Me.txtlista.Location = New System.Drawing.Point(23, 33)
        Me.txtlista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtlista.Multiline = True
        Me.txtlista.Name = "txtlista"
        Me.txtlista.Size = New System.Drawing.Size(71, 207)
        Me.txtlista.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(194, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Regresar Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.EjerciciosTareaas.My.Resources.Resources.ff
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtResultado)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn5)
        Me.GroupBox1.Controls.Add(Me.btn7)
        Me.GroupBox1.Controls.Add(Me.btn6)
        Me.GroupBox1.Controls.Add(Me.btnsuma)
        Me.GroupBox1.Controls.Add(Me.btn8)
        Me.GroupBox1.Controls.Add(Me.btn4)
        Me.GroupBox1.Controls.Add(Me.btnresta)
        Me.GroupBox1.Controls.Add(Me.btn9)
        Me.GroupBox1.Controls.Add(Me.btnmulti)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Controls.Add(Me.btn0)
        Me.GroupBox1.Controls.Add(Me.btnr)
        Me.GroupBox1.Controls.Add(Me.btndivision)
        Me.GroupBox1.Controls.Add(Me.btn3)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.btnp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 258)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EjerciciosTareaas.My.Resources.Resources._11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(343, 304)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btn0 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnsuma As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btndivision As Button
    Friend WithEvents btnp As Button
    Friend WithEvents btnr As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents txtlista As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
