//Entrada: dos notas
//Salida: el estado en el que quedo el estudiante segun sus dos notas
Algoritmo ejercicio_4
	Escribir "Ingrese la primer nota: "
	Leer nota1
	
	Escribir "Ingrese la segunda nota: "
	Leer nota2
	
	promedio <- (nota1 + nota2)/2 
	
	//Nos pide que digamos si hay alguna, pero no necesriamente mostrar cual.
	
	//Realizar un algoritmo en el cual el usuario ingrese 2 notas de un estudiante,
	//si el promedio es menor a 2, imprimir que reprobó, si esta entre 2 y 3, imprimir "posibilidad de recuperatorio", y si es mayor a 3 colocar aprobó.
	
	Si promedio < 2
		Escribir "El alumno reprobó"
	FinSi
	
	Si  2 <= promedio Y promedio <=  3
		Escribir "El alumno tiene posibilidad de recuperatorio"
	FinSi
	
	Si promedio >  3
		Escribir "El alumno aprobó"
	FinSi
	
FinAlgoritmo
