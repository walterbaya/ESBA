Funcion mostrarMenu
	Escribir "1. Suma"
	Escribir "2. Resta"
	Escribir "3. Multiplicación"
	Escribir "4. División"
	Escribir "5. Salir"
	Escribir "Introducir una opción (1-5)"
Fin Funcion

Funcion realizarOperacion(operacion)
	Escribir "Ingrese primer operando: "
	Leer a
	Escribir "Ingrese segundo operando: "
	Leer b
	
	Segun operacion
		1:
			resultado <- a + b
		2:
			resultado <- a - b
		3:
			resultado <- a * b
		4:
			resultado <- a / b
	FinSegun
	
	Escribir resultado
FinFuncion


Algoritmo calculadora
	mostrarMenu()
	Leer operacion
	
	Mientras operacion <> 5
		realizarOperacion(operacion)
		mostrarMenu()
		Leer operacion
	FinMientras
	
FinAlgoritmo
