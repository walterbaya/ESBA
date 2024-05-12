<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Menu1 = New System.Windows.Forms.CheckBox
        Me.Menu2 = New System.Windows.Forms.CheckBox
        Me.Menu3 = New System.Windows.Forms.CheckBox
        Me.Menu4 = New System.Windows.Forms.CheckBox
        Me.Tipos_menues = New System.Windows.Forms.GroupBox
        Me.metodo_pago = New System.Windows.Forms.GroupBox
        Me.Credito = New System.Windows.Forms.RadioButton
        Me.Efectivo = New System.Windows.Forms.RadioButton
        Me.Calcular_precio_final = New System.Windows.Forms.Button
        Me.label_titulo = New System.Windows.Forms.Label
        Me.Resultado = New System.Windows.Forms.TextBox
        Me.Label_precio_final = New System.Windows.Forms.Label
        Me.Tipos_menues.SuspendLayout()
        Me.metodo_pago.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.AutoSize = True
        Me.Menu1.Location = New System.Drawing.Point(20, 59)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(81, 24)
        Me.Menu1.TabIndex = 0
        Me.Menu1.Text = "Menu 1"
        Me.Menu1.UseVisualStyleBackColor = True
        '
        'Menu2
        '
        Me.Menu2.AutoSize = True
        Me.Menu2.Location = New System.Drawing.Point(20, 104)
        Me.Menu2.Name = "Menu2"
        Me.Menu2.Size = New System.Drawing.Size(81, 24)
        Me.Menu2.TabIndex = 1
        Me.Menu2.Text = "Menu 2"
        Me.Menu2.UseVisualStyleBackColor = True
        '
        'Menu3
        '
        Me.Menu3.AutoSize = True
        Me.Menu3.Location = New System.Drawing.Point(20, 146)
        Me.Menu3.Name = "Menu3"
        Me.Menu3.Size = New System.Drawing.Size(81, 24)
        Me.Menu3.TabIndex = 2
        Me.Menu3.Text = "Menu 3"
        Me.Menu3.UseVisualStyleBackColor = True
        '
        'Menu4
        '
        Me.Menu4.AutoSize = True
        Me.Menu4.Location = New System.Drawing.Point(20, 193)
        Me.Menu4.Name = "Menu4"
        Me.Menu4.Size = New System.Drawing.Size(81, 24)
        Me.Menu4.TabIndex = 3
        Me.Menu4.Text = "Menu 4"
        Me.Menu4.UseVisualStyleBackColor = True
        '
        'Tipos_menues
        '
        Me.Tipos_menues.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tipos_menues.Controls.Add(Me.Menu2)
        Me.Tipos_menues.Controls.Add(Me.Menu4)
        Me.Tipos_menues.Controls.Add(Me.Menu1)
        Me.Tipos_menues.Controls.Add(Me.Menu3)
        Me.Tipos_menues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipos_menues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Tipos_menues.Location = New System.Drawing.Point(29, 88)
        Me.Tipos_menues.Name = "Tipos_menues"
        Me.Tipos_menues.Size = New System.Drawing.Size(209, 229)
        Me.Tipos_menues.TabIndex = 4
        Me.Tipos_menues.TabStop = False
        Me.Tipos_menues.Text = "Indique los tipos de menú "
        '
        'metodo_pago
        '
        Me.metodo_pago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.metodo_pago.Controls.Add(Me.Credito)
        Me.metodo_pago.Controls.Add(Me.Efectivo)
        Me.metodo_pago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.metodo_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metodo_pago.ForeColor = System.Drawing.SystemColors.ControlText
        Me.metodo_pago.Location = New System.Drawing.Point(287, 88)
        Me.metodo_pago.Name = "metodo_pago"
        Me.metodo_pago.Size = New System.Drawing.Size(256, 107)
        Me.metodo_pago.TabIndex = 5
        Me.metodo_pago.TabStop = False
        Me.metodo_pago.Text = "Seleccione Método de Pago"
        '
        'Credito
        '
        Me.Credito.AutoSize = True
        Me.Credito.Location = New System.Drawing.Point(17, 72)
        Me.Credito.Name = "Credito"
        Me.Credito.Size = New System.Drawing.Size(78, 24)
        Me.Credito.TabIndex = 1
        Me.Credito.Text = "Credito"
        Me.Credito.UseVisualStyleBackColor = True
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Checked = True
        Me.Efectivo.Location = New System.Drawing.Point(17, 28)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(84, 24)
        Me.Efectivo.TabIndex = 0
        Me.Efectivo.TabStop = True
        Me.Efectivo.Text = "Efectivo"
        Me.Efectivo.UseVisualStyleBackColor = True
        '
        'Calcular_precio_final
        '
        Me.Calcular_precio_final.BackColor = System.Drawing.Color.SeaGreen
        Me.Calcular_precio_final.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Calcular_precio_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular_precio_final.ForeColor = System.Drawing.SystemColors.Menu
        Me.Calcular_precio_final.Location = New System.Drawing.Point(29, 340)
        Me.Calcular_precio_final.Name = "Calcular_precio_final"
        Me.Calcular_precio_final.Size = New System.Drawing.Size(175, 37)
        Me.Calcular_precio_final.TabIndex = 6
        Me.Calcular_precio_final.Text = "Calcular Precio Final"
        Me.Calcular_precio_final.UseVisualStyleBackColor = False
        '
        'label_titulo
        '
        Me.label_titulo.AutoSize = True
        Me.label_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_titulo.ForeColor = System.Drawing.Color.Black
        Me.label_titulo.Location = New System.Drawing.Point(23, 9)
        Me.label_titulo.Name = "label_titulo"
        Me.label_titulo.Size = New System.Drawing.Size(373, 31)
        Me.label_titulo.TabIndex = 7
        Me.label_titulo.Text = "Calculadora de Precio Final"
        '
        'Resultado
        '
        Me.Resultado.Enabled = False
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(380, 222)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(163, 26)
        Me.Resultado.TabIndex = 8
        '
        'Label_precio_final
        '
        Me.Label_precio_final.AutoSize = True
        Me.Label_precio_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_precio_final.Location = New System.Drawing.Point(283, 225)
        Me.Label_precio_final.Name = "Label_precio_final"
        Me.Label_precio_final.Size = New System.Drawing.Size(91, 20)
        Me.Label_precio_final.TabIndex = 9
        Me.Label_precio_final.Text = "Precio Final"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(603, 413)
        Me.Controls.Add(Me.Label_precio_final)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.label_titulo)
        Me.Controls.Add(Me.Calcular_precio_final)
        Me.Controls.Add(Me.metodo_pago)
        Me.Controls.Add(Me.Tipos_menues)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Tipos_menues.ResumeLayout(False)
        Me.Tipos_menues.PerformLayout()
        Me.metodo_pago.ResumeLayout(False)
        Me.metodo_pago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu1 As System.Windows.Forms.CheckBox
    Friend WithEvents Menu2 As System.Windows.Forms.CheckBox
    Friend WithEvents Menu3 As System.Windows.Forms.CheckBox
    Friend WithEvents Menu4 As System.Windows.Forms.CheckBox
    Friend WithEvents Tipos_menues As System.Windows.Forms.GroupBox
    Friend WithEvents metodo_pago As System.Windows.Forms.GroupBox
    Friend WithEvents Credito As System.Windows.Forms.RadioButton
    Friend WithEvents Efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents Calcular_precio_final As System.Windows.Forms.Button
    Friend WithEvents label_titulo As System.Windows.Forms.Label
    Friend WithEvents Resultado As System.Windows.Forms.TextBox
    Friend WithEvents Label_precio_final As System.Windows.Forms.Label

End Class
