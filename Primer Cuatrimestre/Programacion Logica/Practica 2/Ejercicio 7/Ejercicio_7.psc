//Entrada: Tres numeros
//Salida: los tres numeros ordenados de menor a mayor y decir si el tercero es el resto de la division de los dos primeros
Algoritmo Ejercicio_7
	Escribir "Ingrese un primer numero: "
	Leer num1
	Escribir "Ingrese un segundo numero: "
	Leer num2
	Escribir "Ingrese un tercer numero: "
	Leer num3
	Si num1 >= num2
		// num1 >= num2 >= num3
		Si num2 >= num3
			Escribir "Los numeros ordenados de menor a mayor serian: ", num3, ", " , num2, ", " , num1
		Sino
			// num3 >= num1 >= num2 
			Si num3 >= num1
				Escribir "Los numeros ordenados de menor a mayor serian: ", num2, ", " , num1, ", " , num3
			// num1 > num3 > num2   
			Sino	
				Escribir "Los numeros ordenados de menor a mayor serian: ", num2, ", " , num3, ", " , num1
			FinSi
		FinSi
	SiNo
		// num3 <= num1 < num2 
		Si num1 >= num3
			Escribir "Los numeros ordenados de menor a mayor serian: ", num3, ", " , num1, ", " , num2
		Sino
			// 2 >= 3 > 1 
			Si num2 >= num3
				Escribir "Los numeros ordenados de menor a mayor serian: ", num1, ", " , num3, ", " , num2
				// num3 > num2 > num1
			Sino	
				Escribir "Los numeros ordenados de menor a mayor serian: ", num1, ", " , num2, ", " , num3
			FinSi
		FinSi
	FinSi
	
	resto <- num1 MOD num2
	Si resto = num3
		Escribir "El resto de hacer ", num1, " Mod ", num2 ," es igual a ", num3
	SiNo
		Escribir  "El resto de hacer ", num1, " Mod ", num2, " no es igual a ", num3
	FinSi
FinAlgoritmo
