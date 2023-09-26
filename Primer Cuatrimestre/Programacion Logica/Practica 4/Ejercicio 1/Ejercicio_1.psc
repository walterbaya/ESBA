//Entrada: los 50 numeros
//Salida: el promedio de los numeros pares
Algoritmo Ejercicio_1
	Para i <- 1 Hasta 5 Con Paso 1 Hacer
		Escribir "Ingrese un número: "
		Leer num
		Si num MOD 2 = 0
			suma <- suma + num
			cantidadPares <- cantidadPares + 1
		FinSi
	Fin Para
	
	promedio <- suma / cantidadPares
	
	Escribir "El promedio de los numeros pares es: ", promedio
	
FinAlgoritmo
