Algoritmo ejercicio_6
	
	Para i <- 1 Hasta 10 Con Paso 1
		Escribir "Ingrese una letra: "
		Leer letra
		
		Segun letra Hacer
			'a', 'A':
				vocales <- vocales + 1
			'e', 'E':
				vocales <- vocales + 1
			'i', 'I':
				vocales <- vocales + 1
			'o', 'O':
				vocales <- vocales + 1
			'u', 'U':
				vocales <- vocales + 1
		FinSegun
	FinPara
	
	Escribir "La cantidad de vocales ingresadas es de: ", vocales
	

	
	
FinAlgoritmo
