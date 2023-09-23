//Entrada:Cantidad de minutos hablados
//Salida: Total a Pagar por el cliente

Algoritmo algoritmo_6
	Escribir "Ingrese la cantidad de minutos usados: "
	Leer cantMinutos
	Si cantMinutos < 200
		monto <- cantMinutos * 0.20
	SiNo
		Si cantiMinutos < 400
			monto <- cantMinutos * 0.18
		SiNo
			monto <- cantMinutos * 0.15
		FinSi
	FinSi
	
	Escribir "El total a pagar por el cliente es de: ", monto
	
FinAlgoritmo
