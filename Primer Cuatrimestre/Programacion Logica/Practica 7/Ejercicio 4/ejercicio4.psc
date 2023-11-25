//Ingresar el nombre del estudiante, en un vector ingresar 10 asignaturas, en otro vector
//ingresar las calificaciones (1 a 10) de las 10 asignaturas ingresadas en el primer vector, el
//programa deberá mostrar un gráfico de barras horizontal con asteriscos tomando como
//serie las calificaciones

Funcion cargarVector(lista, tam, valueIn)
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		Escribir "Ingrese ", valueIn, ": ", i
		Leer value
		lista[i] <- value
	Fin Para
FinFuncion

Funcion asteriscos <- obtenerAsteriscos(calificacion)
	Para i <- 1 Hasta calificacion Con Paso 1 Hacer
		asteriscos <- asteriscos + "*"	
	Fin Para
FinFuncion

Funcion generarGrafico(asignaturas, calificaciones, tamaño)
	asteriscos <- ""
	Para i <- 0 Hasta tamaño - 1 Con Paso 1 Hacer
		asteriscos <- obtenerAsteriscos(calificaciones[i])
		Escribir asignaturas[i], ": ", asteriscos
	Fin Para
FinFuncion

Algoritmo ejercicio4
	
	Escribir "Ingrese nombre del estudiante: "
	Leer nombre
	
	Dimension asignaturas[3]
	Dimension calificaciones[3]
	
	cargarVector(asignaturas, 3, "asignatura")
	cargarVector(calificaciones, 3, "calificacion")
	
	Escribir "Calificaciones del alumno: ", nombre
	
	generarGrafico(asignaturas, calificaciones, 3)
	
FinAlgoritmo
