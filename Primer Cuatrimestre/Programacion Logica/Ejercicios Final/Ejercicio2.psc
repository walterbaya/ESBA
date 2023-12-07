Funcion  llenarcat(cat)
	cat[0] <- "A"
	cat[1] <- "B"
	cat[2] <- "C"
	cat[3] <- "D"
Fin Funcion

Funcion  iniciarPre(PRE, cat)
	Para i <- 0 Hasta 3 Con Paso 1 Hacer
		Escribir "Ingrese el importe para la categoria: ", cat[i]
		Leer PRE[i]
	Fin Para
Fin Funcion

Funcion llenarNombres(NOMB)
	Para i <- 0 Hasta 49 Con Paso 1 Hacer
		Escribir "Ingrese el nombre del empleado numero :", i
		Leer NOMB[i]
	Fin Para
FinFuncion

Funcion llenarCategorias(NOMB, CAT)
	Para i <- 0 Hasta 49 Con Paso 1 Hacer
		Escribir "Ingrese la categoria a la que pertenece el empleado :", NOMB[i]
		Leer CAT[i]
	Fin Para
FinFuncion

Funcion cargarHorasTrabajadas(EMP, NOMB)
	Para i <- 0 Hasta 49 Con Paso 1 Hacer
		Para j <- 0 Hasta 30 Con Paso 1 Hacer
			Escribir "Ingrese la cantidad de Horas trabajadas por el empleado de nombre: ", NOMB[i], " en el día", i + 1
			Leer cantidad
			Si cantidad <= 10 y cantidad >= 0
				EMP[i,j] <- cantidad
			SiNo
				Escribir "Error, la cantidad tienen que estar entre 0 y 10, intente nuevamente."
				j <- j - 1
			FinSi
		Fin Para
	Fin Para
FinFuncion

Funcion mostrarTotalHorasTrabajadaPorDia(EMP)
	Para j <- 0 Hasta 30 Con Paso 1 Hacer
		horasTrabajadas <- 0
		Para i <- 0 Hasta 49 Con Paso 1 Hacer
			horasTrabajadas <- horasTrabajadas + EMP[i,j]
		Fin Para
		Escribir "La cantidad de Horas trabajadas el día: ", i, " fue de ", horasTrabajadas 
	Fin Para
FinFuncion


Funcion mostrarTotalHorasTrabajadaPorEmpleado(EMP, NOMB, TH)
	Para i <- 0 Hasta 49 Con Paso 1 Hacer
		horasTrabajadas <- 0
		Para j <- 0 Hasta 30  Con Paso 1 Hacer
			horasTrabajadas <- horasTrabajadas + EMP[i,j]
		Fin Para
		Escribir "La cantidad de Horas trabajadas por el empleado de nombre: ", NOMB[i], " fue de ", horasTrabajadas 
		TH[i] <- horasTrabajadas
	Fin Para
FinFuncion

Funcion mostrarNombreEImporte(TH, CAT, PRE, NOMB)
	Para i <- 0 Hasta 49 Con Paso 1 Hacer
		Escribir "El importe a cobrar por el empleado de nombre: ", NOMB[i], " es de: ", TH[i] * PRE[CAT[i]]
	Fin Para
FinFuncion

Funcion empleadoQueMasCobra(TH, CAT, PRE, NOMB)
	maximo <- TH[0] * PRE[CAT[0]] 
	quienMasCobra <- 0
	Para i <- 1 Hasta 49 Con Paso 1 Hacer
		Si maximo < TH[i] * PRE[CAT[i]] 
			maximo <- TH[i] * PRE[CAT[i]]
			quienMasCobra <- i
		FinSi
	Fin Para
	
	Escribir "El importe empleado que mas cobra es: ", NOMB[quienMasCobra], " y cobra: ", maximo
FinFuncion

Funcion promedioHorasTrabajadasPorDia(EMP)
	Para j <- 0 Hasta 30 Con Paso 1 Hacer
		promedio <- 0
		Para i <- 0 Hasta 49 Con Paso 1 Hacer
			promedio <- promedio + EMP[i,j]
		Fin Para
		Escribir "La cantidad promedio de Horas trabajadas el día: ", i, " fue de ", promedio / 50
	Fin Para
FinFuncion

Algoritmo Ejercicio2
	Dimension PRE[4]
	Dimension EMP[50, 31]
	Dimension NOMB[50]
	Dimension CAT[50]
	Dimension TH[50]
	Dimension cat[4]
	
	llenarcat(cat)
	iniciarPre(PRE, cat)
	llenarNombres(NOMB)
	llenarCategorias(NOMB, CAT)
	
	//a
	
	cargarHorasTrabajadas(EMP, NOMB)
	
	//b mostrar total de horas trabajadas por dia
	
	mostrarTotalHorasTrabajadaPorDia(EMP)
	
	//c mostrar total de hs trabajadas por cada empleado
	
	mostrarTotalHorasTrabajadaPorEmpleado(EMP, NOMB, TH)
	
	//d mostrar nombre e importe a cobrar por cada empleado
	
	mostrarNombreEImporte(TH, CAT, PRE, NOMB)
	
	// e mostrar el empleado que mas sueldo cobra junto con su valor
	
	
FinAlgoritmo


