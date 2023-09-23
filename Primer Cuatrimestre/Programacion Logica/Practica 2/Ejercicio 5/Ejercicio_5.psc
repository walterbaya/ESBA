Algoritmo Ejercicio_8
	Escribir 'Ingrese el numero de identificación del PC: '
	Leer id1
	Escribir 'Ingrese el tiempo de reparación: '
	Leer tiempo1
	Escribir "Ingrese la causa de mantenimiento: "
	Leer causa1
	Escribir 'Ingrese el numero de identificación del PC: '
	Leer id2
	Escribir 'Ingrese el tiempo de reparación: '
	Leer tiempo2
	Escribir "Ingrese la causa de mantenimiento: "
	Leer causa2
	Escribir 'Ingrese el numero de identificación del PC: '
	Leer id3
	Escribir 'Ingrese el tiempo de reparación: '
	Leer tiempo3
	Escribir "Ingrese la causa de mantenimiento: "
	Leer causa3
	
	tiempoTotal <- tiempo1 + tiempo2 + tiempo3 
	tiempoPromedio <- tiempoTotal / 3
	
	Escribir 'El tiempo total de reparación es de: ', tiempoTotal
	Escribir 'El tiempo promedio de reparación es de: ', tiempoPromedio
	
	//tenemos el caso en el que todos son iguales no interesa porque todos tardaron lo mismo, tampoco el caso en el que haya dos que tardaron lo mismo
	
	Si tiempo1 > tiempo2 Y  tiempo1 > tiempo3
		Escribir 'El que tardo más tiempo fue: ', id1
	SiNo
		Si tiempo2 > tiempo1 Y  tiempo2 > tiempo3
			Escribir 'El que tardo más tiempo fue: ', id2
		SiNo
			Si tiempo3 > tiempo1 Y  tiempo3 > tiempo2
				Escribir 'El que tardo más tiempo fue: ', id3
			FinSi 
		FinSi 
	FinSi 
	
	Si causa1 = 1 Y causa2 = 1 Y causa3 = 1 Entonces
		Escribir 'Todas tuvieron problemas de hardware'
	FinSi
	
FinAlgoritmo
