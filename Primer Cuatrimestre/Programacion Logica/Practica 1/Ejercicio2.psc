Algoritmo Ejercicio2
	Escribir 'Ingrese el ancho del terreno'
	Leer ancho
	Escribir 'Ingrese el largo del terreno'
	Leer largo
	superficiePileta <- PI*(largo/4)^2
	superficieAParquizar <- (ancho*largo)-superficiePileta
	Escribir 'La superficie del fondo de la pileta a cubrir es: ', superficiePileta
	Escribir 'La superficie de los alrededores de la pileta, a parquizar es: ', superficieAParquizar
FinAlgoritmo
