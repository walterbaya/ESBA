Funcion cargarVector(lista, tam)
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		Escribir "Ingrese valor: ", i
		Leer val
		lista[i] <- val
	Fin Para
FinFuncion

Funcion prom <- promedioEdadesPares(lista, tam)
	suma <- 0
	cantPares <- 0
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		Si lista[i] MOD 2 = 0
			suma <- suma + lista[i]
			cantPares <- cantPares + 1
		FinSi
	Fin Para
	prom <- suma / cantPares
FinFuncion

Funcion prom <- promedio(lista, tam)
	suma <- 0
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		suma <- suma + lista[i]
	Fin Para
	prom <- suma / tam
FinFuncion


Funcion personasConEdadMenorAlPromedio(listaEdades, listaNombres, tamaño, prom)
	Para i <- 1 Hasta tam - 1 Con Paso 1 Hacer
		Si listaEdades[i] < prom Entonces
			Escribir listaNombres[i], " tiene edad menor al promedio."
		Fin Si
	FinPara
FinFuncion


Funcion personasConMayorEdad(listaEdades, listaNombres, tamaño)
	//Calculo la edad maxima
	max <- 0
	Para i <- 1 Hasta tam - 1 Con Paso 1 Hacer
		Si listaEdades[i] >= max Entonces
			max <- listaEdades[i]
		Fin Si
	FinPara
	
	//Ahora me fijo cuales son 
	
FinFuncion



Algoritmo ejercicioVinculacionVectores
	
	Dimension nombres[5]
	Dimension edades[5]
	
	Escribir "Ingresaremos los nombres: "
	cargarVector(nombres, 5)
	
	Escribir "Ingresaremos las edades asociadas: "
	cargarVector(edades, 5)
	
	prom <- promedioEdadesPares(edades, 5)
	Escribir "El promedio de las edades pares es: ", prome
	
	personasConEdadMenorAlPromedio(edades, nombres, 5, prom)
	personasConMayorEdad(edades, nombres, 5)
	
FinAlgoritmo
