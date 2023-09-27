//Entrada: notas de los alumnos
//Salida: cuantos alumnos aprobaron y cuantos desaprobaron, porcentaje y mayor y menor nota

Algoritmo ejercicio_11
	Para i <- 1 Hasta 10 Hacer
		Escribir "Ingresar la nota del alumno: "
		Leer nota
		
		Si i = 1 Entonces
			menorNota <- nota
			mayorNota <- nota 
		Sino 
			Si nota < menorNota
				menorNota <- nota
			FinSi
			Si nota > mayorNota
				mayorNota <- nota
			FinSi
		FinSi
		
		
		
		
		Si nota < 4 Entonces
			desaprobados <- desaprobados + 1
		SiNo
			aprobados <- aprobados + 1
		FinSi
	FinPara
	
	Escribir "La cantidad de alumnos aprobados es: ", aprobados
	Escribir "La cantidad de alumnos desaprobados es: ", desaprobados
	Escribir "La cantidad de alumnos mayorNota es: ", mayorNota
	Escribir "La cantidad de alumnos menorNota es: ", menorNota
	Escribir "El porcentaje de aprobados es: ", aprobados * 100 / (aprobados + desaprobados)
	
FinAlgoritmo
