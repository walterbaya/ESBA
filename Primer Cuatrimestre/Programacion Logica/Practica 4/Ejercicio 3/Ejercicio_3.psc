Algoritmo Ejercicio_3
	Para i<-1 Hasta 20 Hacer
		Escribir 'Ingresar un número: '
		Leer num
		Si num>0 Entonces
			pos <- pos+1
		SiNo
			Si num<0 Entonces
				neg <- neg+1
			SiNo
				cer <- cer+1
			FinSi
		FinSi
	FinPara
	Escribir 'La cantidad de positivos: ', pos
	Escribir 'La cantidad de negativos: ', neg
	Escribir 'La cantidad de ceros: ', cer
FinAlgoritmo
