Module GameFunctions
    Public Sub borrar_pregunta(ByRef PREGUNTAS_GENERAL As List(Of String), ByRef RESPUESTAS_GENERAL As List(Of String), ByRef OPCIONES_GENERAL As List(Of String), ByVal numeroPregunta As Integer)
        PREGUNTAS_GENERAL.RemoveAt(numeroPregunta)
        RESPUESTAS_GENERAL.RemoveAt(numeroPregunta)

        For i As Integer = 1 To 4
            OPCIONES_GENERAL.RemoveAt(4 * numeroPregunta)
        Next

    End Sub

    Public Function calcular_puntos(ByVal RESPUESTAS_GENERAL As List(Of String), ByVal OPCIONES_GENERAL As List(Of String), ByVal numeroPregunta As Integer, ByVal limit As Integer, ByVal time As Integer, ByVal desplazamiento As Integer)
        Dim puntos As Integer = 0
        If RESPUESTAS_GENERAL(numeroPregunta) = OPCIONES_GENERAL(4 * numeroPregunta + desplazamiento) Then
            Dim recompensa As Integer = 5 * (limit - time)
            puntos += 50 + recompensa
        End If
        Return puntos
    End Function

    Public Function obtener_maximos_puntajes(ByVal puntajes As List(Of Integer), ByVal jugadores As List(Of String)) As List(Of String)
        Dim res As New List(Of String)()

        Dim copiaPuntajes As New List(Of Integer)(puntajes)

        While (copiaPuntajes.Max() <> -1)
            Dim indiceMaximo As Integer = copiaPuntajes.IndexOf(copiaPuntajes.Max())
            res.Add(jugadores(indiceMaximo) & ": " & copiaPuntajes(indiceMaximo))
            copiaPuntajes(indiceMaximo) = -1
        End While

        Return res
    End Function
End Module
