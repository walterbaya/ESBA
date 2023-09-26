Algoritmo Ejercicio_2
	
	Escribir "Ingresar un número: "
	Leer num
	masGrande <- num

	Para i <- 1 Hasta 14 Hacer
		Escribir "Ingresar un número: "
		Leer num
		Si num > masGrande
			masGrande <- num  
		FinSi
	FinPara
	
	Escribir "El número más grande es: ", masGrande
	
FinAlgoritmo
