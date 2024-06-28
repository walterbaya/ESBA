Imports System.Threading

Public Class Form1


    Dim listaUsuarios As New List(Of String)()
    Dim listaContrasenias As New List(Of String)()
    Dim maximosPuntajes As New List(Of Integer)()
    Dim tiempo As Integer
    Dim tiempoLimite As Integer = 5
    Dim elFin As Boolean
    Dim puntos As Integer
    Dim numeroJugador As Integer

    Dim numeroPregunta As Integer
    Dim preguntas As New List(Of String)()
    Dim respuestas As New List(Of String)()
    Dim opciones As New List(Of String)() 'se definen las variables'


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click ''
        If listaUsuarios.Contains(username_tb.Text) And listaContrasenias.Contains(password_tb.Text) Then 'verifica si lista de usuario y lista de contraseña contienen lo ingresado en el texto, es decir que existe el usuario'
            numeroJugador = listaUsuarios.IndexOf(username_tb.Text) 'le asigna a numero de jugador el indice que ocupa en la lista de usuario '
            cargar_preguntas() 'Comienza a cargar las preguntas'
            Timer1.Start() 'Inicia el timer'
        Else
            MsgBox("Error, Ingresa un usuario y contraseña validos") 'cuando no existe el usuario muestra este mensaje'
        End If
    End Sub


    Private Sub cargar_preguntas()

        Randomize()
        numeroPregunta = Int(preguntas.Count * Rnd())
        general_question.Text = preguntas(numeroPregunta)

        option1.Text = opciones(4 * numeroPregunta)
        option2.Text = opciones(4 * numeroPregunta + 1)
        option3.Text = opciones(4 * numeroPregunta + 2)
        option4.Text = opciones(4 * numeroPregunta + 3)

        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles register.Click
        If username_tb.Text.Length = 0 Or password_tb.Text.Length = 0 Then 'verifica si nombre de usurio y contraseña no esten vacios'
            MsgBox("Error, Ingresa un usuario y contraseña no vacios")
        ElseIf listaUsuarios.Contains(username_tb.Text.Trim) Then 'verifica que no se registren dos veces un mismo nombre de usuario'
            MsgBox("Error, Usuario ya registrado, crea uno nuevo o logueate") 'Manda el mensaje cuando encuentra un nombre de usuario repetido'
        Else
            listaContrasenias.Add(password_tb.Text) 'Añade una nueva contraseña'
            listaUsuarios.Add(username_tb.Text) 'añande nombre de usuario a la lista de usuarios'
            maximosPuntajes.Add(0) 'asigna la posicion cero de puntaje maximo al primer usuario VEEERRRRRR'
            puntos = 0 'Asigna al usuario un puntaje minimo de cero'

            numeroJugador = listaUsuarios.Count - 1 'carga en nuemero de jugador la cantidad de elementos lista de usuarios menos uno'

            cargar_preguntas() 'carga las preguntas para comenzar el juego '
            Timer1.Start() 'comienza el timer'
        End If

    End Sub

    Private Sub reiniciarJuego()

        preguntas.AddRange(New String() {"pregunta1", "pregunta2", "pregunta3"})
        respuestas.AddRange(New String() {"op1", "op22", "op33"})
        opciones.AddRange(New String() {"op1", "op2", "op3", "op4", "op21", "op22", "op23", "op24", "op31", "op32", "op33", "op34"})
        'carga el contenido de las listas'

        tiempo = 0
        elFin = False
        ProgressBar1.Value = 0
        puntos = 0
        points_tb.Text = 0
        Timer1.Stop()



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = tiempoLimite

        reiniciarJuego()

    End Sub

    'mientras no se haya llegado al tiempo limite va aincrementando la variable tiempo y llenando la barra de progreso'
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 1

        If tiempo <= tiempoLimite Then
            ProgressBar1.Value = tiempo 'llena la barra de progreso'
            clock.Text = tiempo 'pone la cantidad de segundos que transcurrieron en esa pregunts'
        Else
            Timer1.Stop() 'cuando llega al tiempo limite para el timer'
            tiempo = 0
            ProgressBar1.Value = 0

            'cuando llegamos a la progunta final nos manda la pantalla que muentra los puntos totales obtenidos'

            If preguntas.Count = 1 Then
                TabControl1.SelectedIndex = 2 'cambio a la pantalla 2 de juego finalizado'
                points.Text = "Juego finalizado, Obtuviste " & puntos & " puntos"
            Else
                GameFunctions.borrar_pregunta(preguntas, respuestas, opciones, numeroPregunta)
                cargar_preguntas()

                Timer1.Start()
            End If

        End If
    End Sub


    Private Sub jugar(ByVal desplazamiento As Integer)

        If tiempo <= tiempoLimite Then

            Timer1.Stop()

            puntos += GameFunctions.calcular_puntos(respuestas, opciones, numeroPregunta, tiempoLimite, tiempo, desplazamiento)
            points_tb.Text = puntos

            GameFunctions.borrar_pregunta(preguntas, respuestas, opciones, numeroPregunta)

            If preguntas.Count = 0 Then
                TabControl1.SelectedIndex = 2
                points.Text = "Juego finalizado, Obtuviste " & puntos & " puntos"
            Else
                cargar_preguntas()

                tiempo = 0
                ProgressBar1.Value = 0
                Timer1.Interval = 1000
                option1.Enabled = False
                option2.Enabled = False
                option3.Enabled = False
                option4.Enabled = False
                Thread.Sleep(500)
                Timer1.Start()
                option1.Enabled = True
                option2.Enabled = True
                option3.Enabled = True
                option4.Enabled = True
            End If

        End If

        clock.Text = tiempo

    End Sub

    Private Sub option1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles option1.Click
        jugar(0)
    End Sub

    Private Sub option2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles option2.Click
        jugar(1)
    End Sub

    Private Sub option3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles option3.Click
        jugar(2)
    End Sub

    Private Sub option4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles option4.Click
        jugar(3)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        maximosPuntajes(numeroJugador) = Math.Max(maximosPuntajes(numeroJugador), puntos)

        top_scorers.Items.Clear()

        For Each puntaje In GameFunctions.obtener_maximos_puntajes(maximosPuntajes, listaUsuarios).ToArray()
            top_scorers.Items.Add(puntaje)
        Next

        'top_scorers.Items.AddRange(GameFunctions.obtener_maximos_puntajes(maximosPuntajes, listaUsuarios).ToArray())'

        username_tb.Text = ""
        password_tb.Text = ""
        TabControl1.SelectedIndex = 0
        reiniciarJuego()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub username_tb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username_tb.TextChanged

    End Sub

End Class
