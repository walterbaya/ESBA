//3. Crear un algoritmo que a través de un arreglo unidimensional almacene el número total de
//Kilogramos de Arroz cosechados durante cada mes del año.
//Crear las siguientes funciones
//1. Ingresar los datos al vector (el total de kg no puede ser inferior a 0)
//2. Mostrar el total de kg de arroz cosechados en cada mes (Ejemplo Enero ? 120 kg)
//3. Mostrar el promedio anual de Kilogramos cosechados.
//4. Promedio de kg cosechados en los meses pares
//5. En cuantos y que meses se obtuvieron cosechas superiores al promedio anual.
//6. Qué mes o meses tuvieron la mayor cosecha
//7. Mostrar las ventas por trimestre
//Por ejemplo
//PRIMER TRIMESTRE
//Enero: 120 kg
//Febrero: 130 kg
//Marzo: 200 kg
//Total: 450 kg
//	SEGUNDO TRIMESTRE
//Abril: 290 kg
//Mayo: 135 kg
//Junio: 180 kg
//Total: 605 kg
//	Crear un menú que permita al usuario utilizar cada función tantas veces como desee
Funcion ingresarDatosVector(vector)
	Para i <- 0 Hasta 11 Con Paso 1 Hacer
		Escribir "Ingrese la cantidad de kg cosechados para el mes de numero: ", i + 1
		Leer vector[i]
	Fin Para
FinFuncion

Algoritmo ejercicio2
	Dimension arrozCosechado[12]
	
FinAlgoritmo
