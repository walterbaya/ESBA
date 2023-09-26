// Entrada: dia, mes
// Salida: fecha del año
Algoritmo Ejercicio_2
	Escribir 'Ingresar dia: '
	Leer dia
	Escribir 'Ingresar mes: '
	Leer mes
	Según mes Hacer
		1:
			estacion <- "Verano"
		2:
			estacion <- "Verano"
		3:
			Si dia <= 20 Entonces
				estacion <- "Verano"
			Sino 
				estacion <- "Otoño"
			FinSi
		4:
			estacion <- "Otoño"
		5:
			estacion <- "Otoño"
		6:
			Si dia <= 20 Entonces
				estacion <- "Otoño"
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
	FinSegún
	
	Escribir "La estacion del año: ", estacion
	
FinAlgoritmo
