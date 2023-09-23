Algoritmo ejercicio_3
	Escribir "Ingrese una temperatura: "
	Leer temp1
	
	Escribir "Ingrese otra temperatura: "
	Leer temp2
	
	Escribir "Ingrese otra temperatura: "
	Leer temp3
	
	promedio <- (temp1 + temp2 + temp3)/3
	Escribir "El promedio es: ", promedio 
	
	//Nos pide que digamos si hay alguna, pero no necesriamente mostrar cual.
	
	Si temp1 > promedio O temp2 > promedio O temp3 > promedio
		Escribir "Hay una temperatura superior al promedio"
	FinSi
	
FinAlgoritmo
