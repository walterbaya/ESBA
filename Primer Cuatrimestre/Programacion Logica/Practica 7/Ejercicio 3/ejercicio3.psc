//Crear un algoritmo que a través de un arreglo unidimensional almacene el número total de
//Kilogramos de Arroz cosechados durante cada mes del año.
//Crear las siguientes funciones
//	Crear un menú que permita al usuario utilizar cada función tantas veces como desee

//1. Ingresar los datos al vector (el total de kg no puede ser inferior a 0)
Funcion ingresarDatosVector(vector, meses)
	i <- 0
	Mientras i < 12 
		Escribir "Ingrese la cantidad de kg cosechados para el mes de: ", meses[i]
		Leer kg
		Si kg = 0 Entonces
			Escribir "Error, la cantidad no puede ser 0"
		SiNo
			vector[i] <- kg	
			i <- i + 1
		FinSi
	Fin Mientras
FinFuncion

//2. Mostrar el total de kg de arroz cosechados en cada mes (Ejemplo Enero ? 120 kg)
Funcion mostrarKgArrozMes(meses, cosechados)
	Escribir "Ingrese el mes del cual desea conocer la cantidad de kg cosechados: "
	Leer mes
	
	encontrado <- Falso
	Mientras i <- 11 Y !encontrado
		Si Minusculas(mes) = Minusculas(meses[i])
			encontrado <- Verdadero
		SiNo
			i <- i + 1
		FinSi		
	FinMientras
	Si encontrado = Verdadero 
		res <- cosechados[i]
	FinSi 
	
	Escribir "Los kg de arroz asociados al mes son: ", res, "kg."
FinFuncion

//3. Mostrar el promedio anual de Kilogramos cosechados.
Funcion promedioAnual(cosechados)
	promedio <- 0
	Para i <- 0 Hasta 11 Con Paso 1 Hacer
		promedio <- promedio + cosechados[i]
	Fin Para
	promedio <- promedio / 12
	Escribir "El promedio anual de kilogramos cosechados fue de: ", promedio
FinFuncion

//4. Promedio de kg cosechados en los meses pares
Funcion promedioKgPares(cosechados)
	promedio <- 0
	cantPares <- 0
	Para i <- 0 Hasta 11 Con Paso 1 Hacer
		Si i MOD 2 = 0
			promedio <- promedio + cosechados[i]
			cantPares <- i + 1
		FinSi
	Fin Para
	promedio <- promedio / cantPares
	Escribir "El promedo de kg de cosecha para los meses pares es de: "
FinFuncion

//5. En cuantos y que meses se obtuvieron cosechas superiores al promedio anual.
Funcion promedio <- obtenerPromedioAnual(cosechados)
	promedio <- 0
	Para i <- 0 Hasta 11 Con Paso 1 Hacer
		promedio <- promedio + cosechados[i]
	Fin Para
	promedio <- promedio / 12
FinFuncion

Funcion cosechasSuperiorAlPromedio(meses, cosechados)
	promAnual <- obtenerPromedioAnual(cosechados)
	Para i <- 0 Hasta 11 Con Paso 1 Hacer
		Si promAnual > cosechados[i]
			Escribir "En el mes de: ", meses[i], " La cosecha fue superior al promedio anual"
		FinSi
	Fin Para
FinFuncion

//6. Qué mes o meses tuvieron la mayor cosecha
Funcion may <- mayorCosecha(cosechados)
	may <- cosechados[0] 
	Para i <- 1 Hasta 11 Con Paso 1 Hacer
		Si may < cosechados[i]
			may <- cosechados[i]
		FinSi
	Fin Para
FinFuncion


Funcion mayoresCosechas(meses, cosechados)
	maxCosecha <- mayorCosecha(cosechados)
	Para i <- 0 Hasta 11 Con Paso 1 Hacer
		Si maxCosecha = cosechados[i]
			Escribir "En el mes de: ", meses[i], " La cosecha fue la mayor."
		FinSi
	Fin Para
FinFuncion



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

Funcion ventasPorTrimestre(meses, cosechados)
	Escribir "PRIMER TRIMESTRE"
	Para i <- 0 Hasta 2 Con Paso 1 Hacer
			Escribir meses[i], ": ", cosechados[i]
	Fin Para
	
	Escribir "SEGUNDO TRIMESTRE"
	Para i <- 3 Hasta 5 Con Paso 1 Hacer
		Escribir meses[i], ": ", cosechados[i]
	Fin Para	
	
	Escribir "TERCER TRIMESTRE"
	Para i <- 6 Hasta 8 Con Paso 1 Hacer
		Escribir meses[i], ": ", cosechados[i]
	Fin Para	
	
	Escribir "CUARTO TRIMESTRE"
	Para i <- 9 Hasta 11 Con Paso 1 Hacer
		Escribir meses[i], ": ", cosechados[i]
	Fin Para	
FinFuncion

Funcion mostrarMenu()
	Escribir "Ingrese el numero relacionado a la función que desea utilizar, para finalizar presione 0."
	Escribir "1. Ingresar los datos al vector (el total de kg no puede ser inferior a 0)"
	Escribir "2. Mostrar el total de kg de arroz cosechados en cada mes (Ejemplo Enero ? 120 kg)"
	Escribir "3. Mostrar el promedio anual de Kilogramos cosechados."
	Escribir "4. Promedio de kg cosechados en los meses pares"
	Escribir "5. En cuantos y que meses se obtuvieron cosechas superiores al promedio anual."
	Escribir "6. Qué mes o meses tuvieron la mayor cosecha."
	Escribir "7. Mostrar las ventas por trimestre."
FinFuncion

Algoritmo ejercicio2
	Dimension arrozCosechado[12]
	Dimension meses[12] 
	meses[0] <- "Enero"
	meses[1] <- "Febrero"
	meses[2] <- "Marzo"
	meses[3] <- "Abril"
	meses[4] <- "Mayo"
	meses[5] <- "Junio"
	meses[6] <- "Julio"
	meses[7] <- "Agosto"
	meses[8] <- "Septiembre"
	meses[9] <- "Octubre"
	meses[10] <- "Noviembre"
	meses[11] <- "Diciembre"
	
	
//	Crear un menú que permita al usuario utilizar cada función tantas veces como desee
	
	
	Leer num 
	Mientras num <> 0 Hacer
		Segun variable_numerica Hacer
			1:
				ingresarDatosVector(arrozCosechado, meses)
			2:
				mostrarKgArrozMes(meses, arrozCosechado)
			3:
				promedioAnual(arrozCosechado)
			4:
				promedioKgPares(arrozCosechado)
			5:
				cosechasSuperiorAlPromedio(meses, arrozCosechado)
			6:
				mayoresCosechas(meses, arrozCosechado)
			
			Escribir "Ingrese el numero relacionado a la función que desea utilizar, para finalizar presione 0."
			Leer num
		Fin Segun
	Fin Mientras
	
FinAlgoritmo
