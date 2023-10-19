//Vamos a suponer 1 dolares, 2 libras, 3 yenes.
Función resultado <- convertirMoneda(moneda, tipo)
tipoMinusculas <- Minusculas(tipo)
Segun tipoMinusculas Hacer
		"dolares":
			resultado <- moneda / 349.98
		"libras":
			resultado <- moneda / 425.18
		"yenes":
			resultado <- moneda / 2.34
	Fin Segun
FinFunción

Algoritmo principal
	Escribir 'Ingrese la cantidad de pesos que desea convertir: '
	Leer moneda
	Escribir 'Ingrese el tipo de moneda al que desea convertir: '
	Leer tipo
	resultado <- convertirMoneda(moneda, tipo)
	Escribir moneda, ' Pesos equivalen a: ', resultado, " ", Minusculas(tipo)
FinAlgoritmo
