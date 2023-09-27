//Entrada: si quiere almuerzo con postre o sin postre la persona
//Salida: la cantidad de personas que prefieren con postre, la cantidad de dinero facturado
Algoritmo ejercicio_10
	Para i <- 1 Hasta  6 Con Paso 1 Hacer
		Escribir "¿La persona quiere almuerzo con postre?"
		Leer postre 
		Si postre 
			cantQuierenPostre <- cantQuierenPostre + 1
		FinSi
	FinPara
	gananciasConPostre <- cantQuierenPostre * 1250
	gananciasSinPostre <- (6 - cantQuierenPostre) * 1000
	ganancia <- gananciasConPostre + gananciasSinPostre
	Escribir "Quieren almuerzo con postre: ", cantQuierenPostre, " personas"
	Escribir "La ganancia total es: ", ganancia
	
FinAlgoritmo
