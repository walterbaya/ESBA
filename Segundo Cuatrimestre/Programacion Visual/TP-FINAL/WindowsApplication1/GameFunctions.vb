Module GameFunctions

    Public Sub borrar_pregunta(ByRef PREGUNTAS_GENERAL As List(Of String), ByRef RESPUESTAS_GENERAL As List(Of String), ByRef OPCIONES_GENERAL As List(Of String), ByVal numeroPregunta As Integer)
        PREGUNTAS_GENERAL.RemoveAt(numeroPregunta) 'borra la pregunta de la lista de preguntas segun el numero de indice de la misma'
        RESPUESTAS_GENERAL.RemoveAt(numeroPregunta) 'borra la respuesta asociada a la pregunta de antes'

        'borra todas las opciones de esa pregunta asociada'
        For i As Integer = 1 To 4
            OPCIONES_GENERAL.RemoveAt(4 * numeroPregunta)
        Next

    End Sub

    'Calcula los puntos obtenidos por respuesta, si se contesta bien se agregan ademas 5*(cantidad de segundos restantes) puntos'
    Public Function calcular_puntos(ByVal RESPUESTAS_GENERAL As List(Of String), ByVal OPCIONES_GENERAL As List(Of String), ByVal numeroPregunta As Integer, ByVal limit As Integer, ByVal time As Integer, ByVal desplazamiento As Integer)
        Dim puntos As Integer = 0 'en caso de que no este bien la respuesta le paso 0 puntos'
        If RESPUESTAS_GENERAL(numeroPregunta) = OPCIONES_GENERAL(4 * numeroPregunta + desplazamiento) Then  'Acá me fijo si la respuesta es correcta'
            Dim recompensa As Integer = 5 * (limit - time)  'En caso de ser correcta me fijo cuanta recompensa le tengo que agregar'
            puntos += 50 + recompensa   'le agrego la recompensa'
        End If
        Return puntos
    End Function

    'Obtiene a partir de la lista de puntajes maximos y la lista de jugadores otra lista con el nombre de jugador : puntaje maximo obtenido por el mismo la cual esta ordenada de mayor a menor segun el puntaje'
    Public Function obtener_maximos_puntajes(ByVal puntajes As List(Of Integer), ByVal jugadores As List(Of String)) As List(Of String)
        Dim res As New List(Of String)()

        Dim copiaPuntajes As New List(Of Integer)(puntajes) 'Hago una copia de la lista, porque aunque la pasamos por valor se pisa'

        While (copiaPuntajes.Max() <> -1)   'me fijo que todavia haya numeros en la copia de la lista que no sean -1'
            Dim indiceMaximo As Integer = copiaPuntajes.IndexOf(copiaPuntajes.Max())   'si todavia hay busco el mayor puntaje que va quedando'
            res.Add(jugadores(indiceMaximo) & ": " & copiaPuntajes(indiceMaximo)) 'en ese caso armo el jugador : puntaje'
            copiaPuntajes(indiceMaximo) = -1  'lo pongo en -1 para que no se fije mas en ese'
        End While

        Return res
    End Function

    'Cambia el modo de juego y hace los cambios esteticos en la letra, radio1, radio2 serian los que no estan chequeados luego de seleccionar el seleccionado'
    Public Sub cambiar_modo(ByRef modo As Integer, ByRef seleccionado As RadioButton, ByRef radio1 As RadioButton, ByRef radio2 As RadioButton)

        radio1.ForeColor = Color.Black
        radio2.ForeColor = Color.Black
        seleccionado.ForeColor = Color.DarkOrange

        Select Case seleccionado.Name
            Case "easy"
                modo = 0
            Case "medium"
                modo = 1
            Case "hard"
                modo = 2
        End Select

    End Sub


End Module
