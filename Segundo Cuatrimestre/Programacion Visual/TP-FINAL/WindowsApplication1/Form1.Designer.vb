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
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.level = New System.Windows.Forms.GroupBox
        Me.hard = New System.Windows.Forms.RadioButton
        Me.medium = New System.Windows.Forms.RadioButton
        Me.easy = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.password = New System.Windows.Forms.Label
        Me.username = New System.Windows.Forms.Label
        Me.password_tb = New System.Windows.Forms.TextBox
        Me.username_tb = New System.Windows.Forms.TextBox
        Me.top_scorers = New System.Windows.Forms.ListBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.register = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.d = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.points_tb = New System.Windows.Forms.TextBox
        Me.clock = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.option1 = New System.Windows.Forms.Button
        Me.earnedpoints = New System.Windows.Forms.Label
        Me.general_question = New System.Windows.Forms.TextBox
        Me.option2 = New System.Windows.Forms.Button
        Me.option3 = New System.Windows.Forms.Button
        Me.option4 = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.points = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.level.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1309, 817)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.level)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.top_scorers)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.register)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.d)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1301, 788)
        Me.TabPage1.TabIndex = 0
        '
        'level
        '
        Me.level.BackColor = System.Drawing.Color.White
        Me.level.Controls.Add(Me.hard)
        Me.level.Controls.Add(Me.medium)
        Me.level.Controls.Add(Me.easy)
        Me.level.Location = New System.Drawing.Point(233, 222)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(437, 52)
        Me.level.TabIndex = 9
        Me.level.TabStop = False
        '
        'hard
        '
        Me.hard.AutoSize = True
        Me.hard.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold)
        Me.hard.ForeColor = System.Drawing.Color.Black
        Me.hard.Location = New System.Drawing.Point(320, 12)
        Me.hard.Name = "hard"
        Me.hard.Size = New System.Drawing.Size(93, 34)
        Me.hard.TabIndex = 2
        Me.hard.Text = "Difícil"
        Me.hard.UseVisualStyleBackColor = True
        '
        'medium
        '
        Me.medium.AutoSize = True
        Me.medium.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold)
        Me.medium.Location = New System.Drawing.Point(181, 12)
        Me.medium.Name = "medium"
        Me.medium.Size = New System.Drawing.Size(92, 34)
        Me.medium.TabIndex = 1
        Me.medium.Text = "Medio"
        Me.medium.UseVisualStyleBackColor = True
        '
        'easy
        '
        Me.easy.AutoSize = True
        Me.easy.Checked = True
        Me.easy.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold)
        Me.easy.ForeColor = System.Drawing.Color.DarkOrange
        Me.easy.Location = New System.Drawing.Point(38, 12)
        Me.easy.Name = "easy"
        Me.easy.Size = New System.Drawing.Size(82, 34)
        Me.easy.TabIndex = 0
        Me.easy.TabStop = True
        Me.easy.Text = "Fácil"
        Me.easy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(871, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Máximos Puntajes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.password_tb)
        Me.Panel1.Controls.Add(Me.username_tb)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.OliveDrab
        Me.Panel1.Location = New System.Drawing.Point(182, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 153)
        Me.Panel1.TabIndex = 7
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.password.Location = New System.Drawing.Point(72, 96)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(138, 30)
        Me.password.TabIndex = 3
        Me.password.Text = "Contraseña"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.username.Location = New System.Drawing.Point(72, 29)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(221, 30)
        Me.username.TabIndex = 2
        Me.username.Text = "Nombre de Usuario"
        '
        'password_tb
        '
        Me.password_tb.BackColor = System.Drawing.Color.White
        Me.password_tb.ForeColor = System.Drawing.Color.DarkOrange
        Me.password_tb.Location = New System.Drawing.Point(305, 97)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(100, 29)
        Me.password_tb.TabIndex = 1
        '
        'username_tb
        '
        Me.username_tb.BackColor = System.Drawing.Color.White
        Me.username_tb.ForeColor = System.Drawing.Color.DarkOrange
        Me.username_tb.Location = New System.Drawing.Point(305, 29)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(100, 29)
        Me.username_tb.TabIndex = 0
        '
        'top_scorers
        '
        Me.top_scorers.BackColor = System.Drawing.Color.White
        Me.top_scorers.Enabled = False
        Me.top_scorers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top_scorers.ForeColor = System.Drawing.Color.Green
        Me.top_scorers.FormattingEnabled = True
        Me.top_scorers.ItemHeight = 24
        Me.top_scorers.Location = New System.Drawing.Point(871, 172)
        Me.top_scorers.Name = "top_scorers"
        Me.top_scorers.Size = New System.Drawing.Size(304, 388)
        Me.top_scorers.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(182, 197)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(569, 102)
        Me.TextBox2.TabIndex = 3
        '
        'register
        '
        Me.register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.register.Location = New System.Drawing.Point(479, 563)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(272, 45)
        Me.register.TabIndex = 2
        Me.register.Text = "Registrate Como Jugador"
        Me.register.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button5.Location = New System.Drawing.Point(182, 564)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(278, 44)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Inicia Sesión"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.Color.YellowGreen
        Me.d.Location = New System.Drawing.Point(358, 32)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(300, 120)
        Me.d.TabIndex = 0
        Me.d.Text = "Kajut"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1301, 788)
        Me.TabPage3.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.points_tb)
        Me.GroupBox1.Controls.Add(Me.clock)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.option1)
        Me.GroupBox1.Controls.Add(Me.earnedpoints)
        Me.GroupBox1.Controls.Add(Me.general_question)
        Me.GroupBox1.Controls.Add(Me.option2)
        Me.GroupBox1.Controls.Add(Me.option3)
        Me.GroupBox1.Controls.Add(Me.option4)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1183, 717)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'points_tb
        '
        Me.points_tb.BackColor = System.Drawing.Color.White
        Me.points_tb.Enabled = False
        Me.points_tb.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold)
        Me.points_tb.Location = New System.Drawing.Point(369, 47)
        Me.points_tb.Name = "points_tb"
        Me.points_tb.Size = New System.Drawing.Size(148, 37)
        Me.points_tb.TabIndex = 17
        '
        'clock
        '
        Me.clock.BackColor = System.Drawing.Color.White
        Me.clock.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold)
        Me.clock.Location = New System.Drawing.Point(702, 38)
        Me.clock.Multiline = True
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(45, 56)
        Me.clock.TabIndex = 19
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Location = New System.Drawing.Point(702, 126)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(142, 21)
        Me.ProgressBar1.TabIndex = 16
        '
        'option1
        '
        Me.option1.Font = New System.Drawing.Font("Ink Free", 11.0!, System.Drawing.FontStyle.Bold)
        Me.option1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.option1.Location = New System.Drawing.Point(362, 354)
        Me.option1.Name = "option1"
        Me.option1.Size = New System.Drawing.Size(162, 61)
        Me.option1.TabIndex = 10
        Me.option1.Text = "Button10"
        Me.option1.UseVisualStyleBackColor = True
        '
        'earnedpoints
        '
        Me.earnedpoints.AutoSize = True
        Me.earnedpoints.BackColor = System.Drawing.Color.White
        Me.earnedpoints.Font = New System.Drawing.Font("Ink Free", 25.0!, System.Drawing.FontStyle.Bold)
        Me.earnedpoints.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.earnedpoints.Location = New System.Drawing.Point(228, 47)
        Me.earnedpoints.Name = "earnedpoints"
        Me.earnedpoints.Size = New System.Drawing.Size(135, 42)
        Me.earnedpoints.TabIndex = 18
        Me.earnedpoints.Text = "Puntaje"
        '
        'general_question
        '
        Me.general_question.BackColor = System.Drawing.Color.White
        Me.general_question.Enabled = False
        Me.general_question.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold)
        Me.general_question.Location = New System.Drawing.Point(224, 206)
        Me.general_question.Multiline = True
        Me.general_question.Name = "general_question"
        Me.general_question.Size = New System.Drawing.Size(656, 120)
        Me.general_question.TabIndex = 11
        '
        'option2
        '
        Me.option2.Font = New System.Drawing.Font("Ink Free", 11.0!, System.Drawing.FontStyle.Bold)
        Me.option2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.option2.Location = New System.Drawing.Point(555, 354)
        Me.option2.Name = "option2"
        Me.option2.Size = New System.Drawing.Size(162, 61)
        Me.option2.TabIndex = 12
        Me.option2.Text = "Button9"
        Me.option2.UseVisualStyleBackColor = True
        '
        'option3
        '
        Me.option3.Font = New System.Drawing.Font("Ink Free", 11.0!, System.Drawing.FontStyle.Bold)
        Me.option3.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.option3.Location = New System.Drawing.Point(362, 421)
        Me.option3.Name = "option3"
        Me.option3.Size = New System.Drawing.Size(162, 61)
        Me.option3.TabIndex = 13
        Me.option3.Text = "Button8"
        Me.option3.UseVisualStyleBackColor = True
        '
        'option4
        '
        Me.option4.Font = New System.Drawing.Font("Ink Free", 11.0!, System.Drawing.FontStyle.Bold)
        Me.option4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.option4.Location = New System.Drawing.Point(555, 421)
        Me.option4.Name = "option4"
        Me.option4.Size = New System.Drawing.Size(162, 61)
        Me.option4.TabIndex = 14
        Me.option4.Text = "Button7"
        Me.option4.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.points)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1301, 788)
        Me.TabPage2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button1.Location = New System.Drawing.Point(311, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(330, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Volver Al Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'points
        '
        Me.points.AutoSize = True
        Me.points.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold)
        Me.points.ForeColor = System.Drawing.Color.Black
        Me.points.Location = New System.Drawing.Point(307, 159)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(87, 30)
        Me.points.TabIndex = 2
        Me.points.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ink Free", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label4.Location = New System.Drawing.Point(307, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 42)
        Me.Label4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.Location = New System.Drawing.Point(304, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 42)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "¡Juego Finalizado!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.level.ResumeLayout(False)
        Me.level.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents d As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents register As System.Windows.Forms.Button
    Friend WithEvents top_scorers As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents option4 As System.Windows.Forms.Button
    Friend WithEvents option3 As System.Windows.Forms.Button
    Friend WithEvents option2 As System.Windows.Forms.Button
    Friend WithEvents general_question As System.Windows.Forms.TextBox
    Friend WithEvents option1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents points As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents points_tb As System.Windows.Forms.TextBox
    Friend WithEvents earnedpoints As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents level As System.Windows.Forms.GroupBox
    Friend WithEvents medium As System.Windows.Forms.RadioButton
    Friend WithEvents easy As System.Windows.Forms.RadioButton
    Friend WithEvents hard As System.Windows.Forms.RadioButton
    Friend WithEvents clock As System.Windows.Forms.TextBox

End Class
