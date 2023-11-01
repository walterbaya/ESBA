//Se requiere de un algoritmo para obtener un vector (C) de n elementos que contenga la suma de los
//elementos correspondientes a otros dos vectores (A, B). (Los vectores A y B Se deben cargar
//previamente con números generados al azar)

Funcion cargarVector(lista, tam)
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		lista[i] <- Azar(99) + 1
	Fin Para
FinFuncion

Funcion sumarVectores(a, b, c, tam)
	Para i <- 0 Hasta n - 1 Con Paso 1 Hacer
		c[i] <- b[i] + a[i]
	Fin Para
FinFuncion

Funcion mostrarVector(c, tam)
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		Escribir "valor de c en posicion: ", i, " es: ", c[i] 
	Fin Para
FinFuncion

Algoritmo ejercicio1
	Escribir "Ingrese tamaño de vector A y B: "
	Leer n
	Dimension a[n]
	Dimension b[n]
	Dimension c[n]
	
	cargarVector(a, n)
	cargarVector(b, n)
	
	sumarVectores(a, b, c, n)
	
	mostrarVector(c, n)
	
FinAlgoritmo
