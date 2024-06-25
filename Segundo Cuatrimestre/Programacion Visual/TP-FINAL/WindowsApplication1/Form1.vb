Imports System.Threading

Public Class Form1


    Dim listaUsuarios As New List(Of String)()
    Dim listaContrasenias As New List(Of String)()
    Dim maximosPuntajes As New List(Of Integer)()
    Dim tiempo As Integer
    Dim tiempoLimite As Integer = 5
    Dim puntos As Integer
    Dim numeroJugador As Integer
    Dim modo As Integer
    Dim indiceAnterior As Integer = 0
    Dim porCodigo As Boolean = False
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


    'Carga las preguntas y las opciones en los botones  y el cuadro de texto'
    Private Sub cargar_preguntas()

        'Inicializa el generador de números aleatorios'
        Randomize()
        numeroPregunta = Int(preguntas.Count * Rnd()) 'Genera la siguiente pregunta de las preguntas que quedaron al azar'
        general_question.Text = preguntas(numeroPregunta) 'Carga la pregunta en el cuadro de texto'

        'Carga las opciones en cada botón'
        option1.Text = opciones(4 * numeroPregunta)
        option2.Text = opciones(4 * numeroPregunta + 1)
        option3.Text = opciones(4 * numeroPregunta + 2)
        option4.Text = opciones(4 * numeroPregunta + 3)

        porCodigo = True
        TabControl1.SelectedIndex = 1  'Mueve a la pagina de juego, donde estan las preguntas'
    End Sub

    Private Sub register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles register.Click
        If username_tb.Text.Length = 0 Or password_tb.Text.Length = 0 Then 'verifica si nombre de usurio y contraseña no esten vacios'
            MsgBox("Error, Ingresa un usuario y contraseña no vacios")
        ElseIf listaUsuarios.Contains(username_tb.Text.Trim) Then 'verifica que no se registren dos veces un mismo nombre de usuario'
            MsgBox("Error, Usuario ya registrado, crea uno nuevo o logueate") 'Manda el mensaje cuando encuentra un nombre de usuario repetido'
        Else
            listaContrasenias.Add(password_tb.Text) 'Añade una nueva contraseña'
            listaUsuarios.Add(username_tb.Text) 'añande nombre de usuario a la lista de usuarios'
            maximosPuntajes.Add(0) 'Asigna cero de puntaje maximo al usuario que recien se registro'
            puntos = 0             'Asigna los  puntos con los que arranca'

            'el numero del jugador va a ser el indice de el ultimo elemento de la lista de usuarios, porque los va agregando al final a medida que se registran'
            numeroJugador = listaUsuarios.Count - 1

            cargar_preguntas() 'carga las preguntas para comenzar el juego '
            Timer1.Start() 'comienza el timer'
        End If

    End Sub

    'Vuelve todo a como estaba inicialmente, salvo las cosas relacionadas a maximos puntajes y usuarios registrados'
    Private Sub reiniciarJuego()

        'limpiamos las listas'
        preguntas.Clear()
        respuestas.Clear()
        opciones.Clear()

        Select Case modo
            'preguntas modo facil'
            Case 0
                preguntas.AddRange(New String() {"¿Cuál es el planeta más grande del sistema solar?", "¿Quién escribió Romeo y Julieta?", "¿Cuál es la capital de Francia?", "¿Cuál es el océano más grande del mundo?", "¿Qué elemento químico tiene el símbolo H?"})
                respuestas.AddRange(New String() {"Júpiter", "William Shakespeare", "París", "Pacífico", "Hidrógeno"})
                opciones.AddRange(New String() {"Marte", "Júpiter", "Venus", "Saturno", "William Shakespeare", "Charles Dickens", "Jane Austen", "Mark Twain", "Berlín", "Madrid", "Roma", "París", "Atlántico", "Índico", "Pacífico", "Ártico", "Hierro", "Hidrógeno", "Helio", "Plomo"})
                'preguntas modo medio'
            Case 1
                preguntas.AddRange(New String() {"¿Cuál es el nombre del fenómeno físico por el cual la luz se descompone en diferentes colores al atravesar un prisma?", "¿Quién descubrió la estructura en forma de doble hélice del ADN en 1953?", "¿En qué año se inauguró la Torre Eiffel en París?", "¿Cuál es el río más largo de África?", "¿Qué científico propuso la teoría de la relatividad?"})
                respuestas.AddRange(New String() {"Descomposición de la luz", "James Watson y Francis Crick", "1889", "Nilo", "Albert Einstein"})
                opciones.AddRange(New String() {"Reflexión", "Refracción", "Dispersión", "Descomposición de la luz", "Albert Einstein", "Isaac Newton", "James Watson y Francis Crick", "Galileo Galilei", "1879", "1889", "1900", "1920", "Amazonas", "Nilo", "Congo", "Zambeze", "Isaac Newton", "Galileo Galilei", "Albert Einstein", "Stephen Hawking"})
                'preguntas modo dificil'
            Case 2
                preguntas.AddRange(New String() {"¿Cuál es la constante matemática que se define como la relación entre la circunferencia de un círculo y su diámetro?", "¿Qué filósofo griego es conocido por su método de enseñanza basado en el diálogo y la pregunta socrática?", "¿En qué año se fundó la Organización de las Naciones Unidas (ONU)?", "¿Cuál es el nombre de la galaxia más cercana a la Vía Láctea?", "¿Cuál es el nombre del compuesto químico con la fórmula H2O2?"})
                respuestas.AddRange(New String() {  "Pi", "Sócrates","1945","Andrómeda","Peróxido de hidrógeno"})
                opciones.AddRange(New String() {"Euler", "Phi", "Pi", "Theta", "Platón", "Aristóteles", "Sócrates", "Heráclito", "1919", "1939", "1945", "1955", "Andrómeda", "Vía Láctea", "Triángulo", "Galaxia Espiral de Barnard", "Ácido clorhídrico", "Peróxido de hidrógeno", "Ácido sulfúrico", "Ácido cítrico"})
        End Select

        'carga el contenido de las listas'

        tiempo = 0
        ProgressBar1.Value = 0
        puntos = 0 'pone puntos a 0'
        points_tb.Text = 0 'Pone el texto de los puntos en 0'
        porCodigo = False
        Timer1.Stop()

    End Sub

    'Establece los valores minimo y maximo de la barra y reinicia el juego'
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = tiempoLimite
        modo = 0
        reiniciarJuego()

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 1 'incrementa el tiempo en 1'

        If tiempo <= tiempoLimite Then 'si el tiempo es menor o igual al tiempo limite ingresa al if'

            ProgressBar1.Value = tiempo 'actualiza la barra con el tiempo, o sea se va llenando en cada tick correspondiente'
            clock.Text = tiempoLimite - tiempo         'Similar a la barra pero en un cuadro de texto llamado clock'
        Else
            Timer1.Stop()  'para el timer'
            tiempo = 0      'asigna la variable tiempo en cero'
            ProgressBar1.Value = 0 'la barra vuelve a estar en 0'
            clock.Text = 5

            'Si se termino el tiempo para la pregunta, nos fijamos si es la ultima pregunta, sino borramos la pregunta, cargamos la siguiente'

            If preguntas.Count = 1 Then
                porCodigo = True
                TabControl1.SelectedIndex = 2 'lleva al usuario a la segunda pagina donde se le brinda el puntaje obtenido y se le avisa que juego finalizo'
                points.Text = "Juego finalizado, Obtuviste " & puntos & " puntos"  'muestra mensaje'
            Else
                GameFunctions.borrar_pregunta(preguntas, respuestas, opciones, numeroPregunta) 'llama a borrar, para borrar la pregunta'
                cargar_preguntas() 'Vuelve a cargar las preguntas'

                Timer1.Start() 'vuelve  a iniciar el timer para la siguiente pregunta'
            End If

        End If
    End Sub


    Private Sub jugar(ByVal desplazamiento As Integer)

        If tiempo <= tiempoLimite Then 'si el tiempo es menor o igual al tiempo limite ingresa al if'

            Timer1.Stop() 'detiene el timer'

            puntos += GameFunctions.calcular_puntos(respuestas, opciones, numeroPregunta, tiempoLimite, tiempo, desplazamiento) 'llama a la funcion calcular puntos y suma el puntaje en puntos'
            points_tb.Text = puntos 'carga los puntos'

            GameFunctions.borrar_pregunta(preguntas, respuestas, opciones, numeroPregunta) 'Borra las preguntas y respuestas que ya fueron jugadas'

            If preguntas.Count = 0 Then 'se fija si ya no quedan mas preguntas'
                porCodigo = True
                TabControl1.SelectedIndex = 2 'lleva al usuario a la pagina 2 y le da los puntos obtenidos y finaliza el juego'
                points.Text = "Juego finalizado, Obtuviste " & puntos & " puntos" 'muestra el mesaje de juego finalizado y los puntos'
            Else
                cargar_preguntas()  'vuelve a cargar las prenguntas'

                tiempo = 0   'pone el tiempo en estado inicial'
                ProgressBar1.Value = 0 'pone a  la barra en estado inicial'
                clock.Text = 5 'pone el numero en 0'
                'Timer1.Interval = 1000' 'reinicio el reloj'
                option1.Enabled = False 'una vez que se contesta la pregunta se desactiva el menu por medio segundo'
                option2.Enabled = False
                option3.Enabled = False
                option4.Enabled = False
                Thread.Sleep(500)
                Timer1.Start()  'se inicia el timer y se las vuelve a activar' 'VERRR'
                option1.Enabled = True
                option2.Enabled = True
                option3.Enabled = True
                option4.Enabled = True
            End If

        End If

        clock.Text = tiempoLimite - tiempo 'Actualiza'

    End Sub

    'Son los metodos para elegir la respuesta'

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
        maximosPuntajes(numeroJugador) = Math.Max(maximosPuntajes(numeroJugador), puntos) 'compara si los puntos que obtuvo el jugador son mas grande que los obtenidos hasta esta hora'

        'Limpia los items de la lista de maximos puntajes'
        top_scorers.Items.Clear()

        For Each puntaje In GameFunctions.obtener_maximos_puntajes(maximosPuntajes, listaUsuarios).ToArray()
            top_scorers.Items.Add(puntaje)
        Next

        'top_scorers.Items.AddRange(GameFunctions.obtener_maximos_puntajes(maximosPuntajes, listaUsuarios).ToArray())'

        porCodigo = True
        TabControl1.SelectedIndex = 0
        modo = 0
        username_tb.Text = ""
        password_tb.Text = ""

        'chequear en facil para volver al por defecto'
        DirectCast(level.Controls("easy"), RadioButton).Checked = True
        reiniciarJuego()
    End Sub

    Private Sub easy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles easy.CheckedChanged
        Dim seleccionado As RadioButton = DirectCast(sender, RadioButton)
        cambiar_modo(modo, seleccionado, medium, hard)
        reiniciarJuego()
    End Sub

    Private Sub medium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles medium.CheckedChanged
        Dim seleccionado As RadioButton = DirectCast(sender, RadioButton)
        cambiar_modo(modo, seleccionado, easy, hard)
        reiniciarJuego()
    End Sub

    Private Sub hard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hard.CheckedChanged
        Dim seleccionado As RadioButton = DirectCast(sender, RadioButton)
        cambiar_modo(modo, seleccionado, easy, medium)
        reiniciarJuego()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If porCodigo = False Then
            TabControl1.SelectedIndex = indiceAnterior
        End If

        If porCodigo Then
            Select Case indiceAnterior
                Case 1
                    TabControl1.SelectedIndex = 2
                Case 2
                    TabControl1.SelectedIndex = 0
            End Select
            porCodigo = False
        End If

        indiceAnterior = TabControl1.SelectedIndex
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        ' Mostrar un cuadro de diálogo de confirmación antes de cerrar el juego
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que queres salir del juego?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario elige "No", cancelar el cierre del formulario
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class
