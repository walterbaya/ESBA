Imports MySql.Data.MySqlClient

Module Consultas

    'Permite saber si hay algun usuario registrado con ese nombre'
    Public Function existe_usuario(ByVal nombre As String) As Boolean

        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, en existe usuario: " & ex.Message)
        End Try


        Dim query As String = "SELECT * FROM jugadores WHERE BINARY nombre = @nombre"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@nombre", nombre)

        Dim table As New DataTable()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim encontrado As Boolean = False
        reader.Read()
        reader.Close()

        ' Ejecuta la consulta y obtiene el resultado
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' Verifica si el registro existe
        If count > 0 Then
            encontrado = True
        End If

        connection.Close()
        Return encontrado
    End Function

    'Devuelve True en caso de que el usuario y la contraseña pasadas sean correctas'
    Public Function login(ByVal nombre As String, ByVal contraseña As String) As Boolean
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, en login: " & ex.Message)
        End Try


        Dim query As String = "SELECT * FROM jugadores WHERE BINARY nombre = @nombre AND BINARY contraseña = @contraseña"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@contraseña", contraseña)

        Dim table As New DataTable()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim encontrado As Boolean = False
        reader.Read()
        reader.Close()

        ' Ejecuta la consulta y obtiene el resultado
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' Verifica si el registro existe
        If count > 0 Then
            encontrado = True
        End If

        connection.Close()
        Return encontrado
    End Function

    'obtiene el id del usuario que posea cierto nombre'
    Public Function obtener_id_usuario(ByVal nombre As String) As Integer
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, en obtener id usuario: " & ex.Message)
        End Try

        Dim query As String = "SELECT id_jugador FROM jugadores WHERE BINARY nombre = @nombre"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@nombre", nombre)

        Dim id = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()
        Return id
    End Function


    'Crea un usuario y devuelve el id con el que fue registrado en la base de datos'
    Public Function crear_usuario(ByVal nombre As String, ByVal contraseña As String) As Integer
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al crear usuario: " & ex.Message)
        End Try

        Dim query As String = "INSERT INTO jugadores (nombre, contraseña) VALUES (@nombre, @contraseña)"
        Dim cmd As New MySqlCommand(query, connection)

        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@contraseña", contraseña)

        cmd.ExecuteNonQuery()
        connection.Close()

        Return obtener_id_usuario(nombre)

    End Function

    Public Function obtener_puntaje_usuario(ByVal id As Integer) As Integer
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al obtener puntaje usuario: " & ex.Message)
        End Try
        Dim query As String = "SELECT puntaje FROM jugadores WHERE BINARY id_jugador = @id"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@id", id)

        Dim puntaje = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()
        Return puntaje
    End Function

    Public Sub actualizar_puntaje_usuario(ByVal id As Integer, ByVal puntaje As Integer)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al actualizar puntaje usuario: " & ex.Message)
        End Try
        Dim query As String = "UPDATE jugadores SET puntaje = @puntaje WHERE BINARY id_jugador = @id;"

        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@puntaje", puntaje)

        cmd.ExecuteNonQuery()

        connection.Close()

    End Sub

    Public Function obtener_puntajes() As List(Of Integer)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al obtener puntajes: " & ex.Message)
        End Try
        ' Lista para almacenar las preguntas obtenidas
        Dim puntajes As New List(Of Integer)()

        ' Consulta SQL para seleccionar las preguntas según la dificultad
        Dim query As String = "SELECT puntaje FROM jugadores ORDER BY id_jugador ASC"

        ' Crear el comando MySqlCommand
        Dim cmd As New MySqlCommand(query, connection)

        ' Ejecutar la consulta y obtener un lector de datos
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Leer los resultados y agregar las preguntas a la lista
        While reader.Read()
            puntajes.Add(reader.GetInt32("puntaje"))
        End While

        ' Cerrar el lector de datos
        reader.Close()
        connection.Close()

        ' Retornar la lista de preguntas
        Return puntajes
    End Function


    Public Function obtener_usuarios() As List(Of String)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al obtener usuarios: " & ex.Message)
        End Try
        ' Lista para almacenar las preguntas obtenidas
        Dim usuarios As New List(Of String)()

        ' Consulta SQL para seleccionar las preguntas según la dificultad
        Dim query As String = "SELECT nombre FROM jugadores ORDER BY id_jugador ASC"

        ' Crear el comando MySqlCommand
        Dim cmd As New MySqlCommand(query, connection)

        ' Ejecutar la consulta y obtener un lector de datos
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Leer los resultados y agregar las preguntas a la lista
        While reader.Read()
            usuarios.Add(reader.GetString("nombre"))
        End While

        ' Cerrar el lector de datos
        reader.Close()
        connection.Close()

        ' Retornar la lista de preguntas
        Return usuarios
    End Function



    'Obtiene las preguntas dada una dificultad'

    Public Function obtener_preguntas(ByVal dificultad As Integer) As List(Of String)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al obtener preguntas: " & ex.Message)
        End Try
        ' Lista para almacenar las preguntas obtenidas
        Dim preguntas As New List(Of String)()

        ' Consulta SQL para seleccionar las preguntas según la dificultad
        Dim query As String = "SELECT pregunta FROM preguntas WHERE dificultad_pregunta = @dificultad ORDER BY id_pregunta ASC"

        ' Crear el comando MySqlCommand
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@dificultad", dificultad)

        ' Ejecutar la consulta y obtener un lector de datos
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Leer los resultados y agregar las preguntas a la lista
        While reader.Read()
            preguntas.Add(reader.GetString("pregunta"))
        End While

        ' Cerrar el lector de datos
        reader.Close()
        connection.Close()

        ' Retornar la lista de preguntas
        Return preguntas
    End Function

    'Obtiene las respuestas dada una dificultad'
    Public Function obtener_respuestas(ByVal dificultad As Integer) As List(Of String)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al obtener respuestas: " & ex.Message)
        End Try
        ' Lista para almacenar las preguntas obtenidas
        Dim preguntas As New List(Of String)()

        ' Consulta SQL para seleccionar las preguntas según la dificultad
        Dim query As String = "SELECT *  FROM respuestas r JOIN preguntas p WHERE r.id_pregunta = p.id_pregunta AND p.dificultad_pregunta = @dificultad ORDER BY p.id_pregunta ASC"

        ' Crear el comando MySqlCommand
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@dificultad", dificultad)

        ' Ejecutar la consulta y obtener un lector de datos
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Leer los resultados y agregar las preguntas a la lista
        While reader.Read()
            preguntas.Add(reader.GetString("respuesta"))
        End While

        ' Cerrar el lector de datos
        reader.Close()
        connection.Close()

        ' Retornar la lista de preguntas
        Return preguntas
    End Function

    'Obtiene las respuestas dada una dificultad'
    Public Function obtener_opciones(ByVal dificultad As Integer) As List(Of String)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al obtener opciones: " & ex.Message)
        End Try
        ' Lista para almacenar las preguntas obtenidas
        Dim preguntas As New List(Of String)()

        ' Consulta SQL para seleccionar las preguntas según la dificultad
        Dim query As String = "SELECT *  FROM opciones o JOIN preguntas p WHERE p.id_pregunta = o.id_pregunta AND p.dificultad_pregunta = @dificultad ORDER BY p.id_pregunta ASC"

        ' Crear el comando MySqlCommand
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@dificultad", dificultad)

        ' Ejecutar la consulta y obtener un lector de datos
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Leer los resultados y agregar las preguntas a la lista
        While reader.Read()
            preguntas.Add(reader.GetString("opcion"))
        End While

        ' Cerrar el lector de datos
        reader.Close()
        connection.Close()
        ' Retornar la lista de preguntas

        Return preguntas
    End Function


    Public Sub setear_tiempo_limite(ByRef tiempoLimite As Integer)
        Dim connection As MySqlConnection = New MySqlConnection("Server=localhost;Database=kajut;Uid=root;Pwd=;")

        Try
            connection.Open()

        Catch ex As Exception
            Console.WriteLine("Error, al setear tiempo limite: " & ex.Message)
        End Try

        Dim query As String = "SELECT tiempo_limite FROM propiedades_juego"
        Dim cmd As New MySqlCommand(query, connection)
        tiempoLimite = Convert.ToInt32(cmd.ExecuteScalar())
        connection.Close()

    End Sub

End Module
