Algoritmo Ejercicio_2
	
	Escribir "Ingresar un n�mero: "
	Leer num
	masGrande <- num

	Para i <- 1 Hasta 14 Hacer
		Escribir "Ingresar un n�mero: "
		Leer num
		Si num > masGrande
			masGrande <- num  
		FinSi
	FinPara
	
	Escribir "El n�mero m�s grande es: ", masGrande
	
FinAlgoritmo
