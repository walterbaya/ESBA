Algoritmo ejercicio_5
	
	Para i <- 1 Hasta 10 Con Paso 1 Hacer
		Escribir "Ingrese un número: "
		Leer num 
		
		Si num < 15
			menoresA15 <- menoresA15 + 1 
		FinSi
		
		Si num > 50
			mayoresA50 <- mayoresA50 + 1
		FinSi
		
		Si num < 40 Y num > 25
			entre25y40 <- entre25y40 + 1
		FinSi
	FinPara
	
	Escribir "Son menores a 15: ", menoresA15
	Escribir "Son mayores a 50: ", mayoresA50
	Escribir "Entre 25 y 40: ", entre25y40
	
FinAlgoritmo
