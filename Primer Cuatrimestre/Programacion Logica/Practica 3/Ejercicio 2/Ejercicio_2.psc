// Entrada: dia, mes
// Salida: fecha del a�o
Algoritmo Ejercicio_2
	Escribir 'Ingresar dia: '
	Leer dia
	Escribir 'Ingresar mes: '
	Leer mes
	Seg�n mes Hacer
		1:
			estacion <- "Verano"
		2:
			estacion <- "Verano"
		3:
			Si dia <= 20 Entonces
				estacion <- "Verano"
			Sino 
				estacion <- "Oto�o"
			FinSi
		4:
			estacion <- "Oto�o"
		5:
			estacion <- "Oto�o"
		6:
			Si dia <= 20 Entonces
				estacion <- "Oto�o"
			Sino 
				estacion <- "Invierno"
			FinSi
		7:
			estacion <- "Invierno"
		8:
			estacion <- "Invierno"
		9:
			Si dia <= 20 Entonces
				estacion <- "Invierno"
			Sino 
				estacion <- "Verano"
			FinSi
		10:
			estacion <- "Verano"
		11:
			estacion <- "Verano"
		De Otro Modo:
			Si dia <= 20 Entonces
				estacion <- "Primavera"
			Sino 
				estacion <- "Verano"
			FinSi
	FinSeg�n
	
	Escribir "La estacion del a�o: ", estacion
	
FinAlgoritmo
