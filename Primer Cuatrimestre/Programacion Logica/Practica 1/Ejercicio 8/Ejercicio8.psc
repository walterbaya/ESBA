Algoritmo Ejercicio6
	Escribir 'Ingresar el precio de un pasaje en clase turista: '
	Leer precio_clase_turista
	Escribir 'Ingresar la cantidad de pasajes de clase turista vendidos: '
	Leer cantidad_pasajes_turista
	Escribir 'Ingresar la cantidad de pasajes de primara clase vendidos: '
	Leer cantidad_pasajes_primera
	precio_primera_clase <- (precio_clase_turista * 30/100) +  precio_clase_turista
	recaudacion_total <- cantidad_pasajes_primera * precio_primera_clase + cantidad_pasajes_turista * precio_clase_turista 
	Escribir 'La recaudacion total es: ', recaudacion_total
FinAlgoritmo
