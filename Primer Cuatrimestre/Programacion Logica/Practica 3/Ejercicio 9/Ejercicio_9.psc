Algoritmo Ejercicio_9
	Escribir "Ingrese un numero: "
	Leer num	
	minimo <- num
	maximo <- num
	ordenMaximo <- 1
	ordenMinimo <- 1
	
	Para i <- 1 Hasta 4 Con Paso 1 Hacer
		Escribir "Ingrese un numero: "
		Leer num	
		
		Si num > maximo 
			maximo <- num
			ordenMaximo <- i + 1
		FinSi
		Si num < minimo 
			minimo <- num 
			ordenMinimo <- i + 1
		FinSi
	FinPara
	
	Escribir "El máximo es: ", maximo, " el número de orden es: ", ordenMaximo
	Escribir "El mínimo es: ", minimo, " el número de orden es: ", ordenMinimo
	
	
FinAlgoritmo
