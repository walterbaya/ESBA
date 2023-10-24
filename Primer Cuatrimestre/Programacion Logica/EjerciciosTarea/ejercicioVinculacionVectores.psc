Funcion cargarVector(lista, tam)
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		Escribir "Ingrese valor: ", i
		Leer val
		lista[i] <- val
	Fin Para
FinFuncion

//Tiene que tener al menos un valor para que funcione

Funcion indice <- indiceMayor(lista, tam)
	res <- lista[0]
	indice <- 0
	Para i <- 1 Hasta tam - 1 Con Paso 1 Hacer
		Si lista[i] > res Entonces
			res <- lista[i]
			indice <- i
		Fin Si
	FinPara
FinFuncion


Algoritmo ejercicioVinculacionVectores
	
	Dimension nombres[5]
	Dimension edades[5]
	
	Escribir "Ingresaremos los nombres: "
	cargarVector(nombres, 5)
	
	Escribir "Ingresaremos las edades asociadas: "
	cargarVector(edades, 5)
	
	iEdadMaxima <- indiceMayor(edades, 5)
	Escribir "La persona de mayor edad es ", nombres[iEdadMaxima], " y tiene ", edades[iEdadMaxima], " años" 
	
FinAlgoritmo
