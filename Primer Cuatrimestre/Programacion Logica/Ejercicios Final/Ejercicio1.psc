Funcion produccionTotal(produccionDiaria, dias)
	Para j <- 0 Hasta 6 Con Paso 1 Hacer
		produccionDiaria <- 0
		Para i <- 6 Hasta 6 Con Paso 1 Hacer
			produccionDiaria <- produccionDiaria + produccionDiaria[j, i]
		Fin Para
		Escribir "La producción en el día: ", dias[j], " Fue de: ", produccionDiaria[j,i], " litros de leche."
	Fin Para
Fin Funcion

Funcion produccionPromedioSemanal(produccionDiaria, vacas)
	Para i <- 0 Hasta 6 Con Paso 1 Hacer
		produccionDiaria <- 0
		Para j <- 6 Hasta 6 Con Paso 1 Hacer
			produccionDiaria <- produccionDiaria + produccionDiaria[j, i]
		Fin Para
		Escribir "La producción promedio de la vaca de nombre: ", vacas[j], " Fue de: ", produccionDiaria[j,i], " litros de leche."
	Fin Para
Fin Funcion

Funcion  guardarProduccion(produccionDiaria, vacas, dias)
	Para i <- 0 Hasta 6 Con Paso 1 Hacer
		Para j <- 0 Hasta 6 Con Paso 1 Hacer
			Escribir "Ingrese la producción del día: ", dias[j], " para la vaca de nombre: ", vacas[i]
			Leer produccion
			Si produccion < 0
				Escribir "Error, no puede ser negativa la cantidad de leche producida, ingrese nuevamente"
				//Seteo aca asi vuelve a intentar
				j <- j - 1
			SiNo
				produccionDiaria[i,j] <- produccion
			FinSi
		Fin Para
	Fin Para
Fin Funcion



Funcion cargarNombresVacas(vacas)
	vacas[0] <- "Jose"
	vacas[1] <- "Luis"
	vacas[2] <- "German"
	vacas[3] <- "Pablo"
	vacas[4] <- "Ted"
	vacas[5] <- "Emerson"
	vacas[6] <- "Gary"
FinFuncion

Funcion llenarDias(dias)
	dias[0] <- "Lunes"
	dias[1] <- "Martes"
	dias[2] <- "Miercoles"
	dias[3] <- "Jueves"
	dias[4] <- "Viernes"
	dias[5] <- "Sabado"
	dias[6] <- "Domingo"
FinFuncion




Algoritmo Ejercicio1
	Dimension vacas[7]
	Dimension dias[7]
	Dimension produccionDiaria[7, 7]
	
	llenarDias(dias)
	cargarNombresVacas(vacas)
	guardarProduccion(produccionDiaria, vacas, dias)
	produccionTotal(produccionDiaria, dias)
	produccionPromedioSemanal(produccionDiaria, vacas)
	
FinAlgoritmo
