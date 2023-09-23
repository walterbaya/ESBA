Algoritmo Ejercicio_4
	Escribir "Ingrese el año en el que nacio"
	Leer año
	resto <- año MOD 12
	
	Segun resto Hacer
		0:
			Escribir "Mono"
		1: 
			Escribir "Gallo"
		2:
			Escribir "Perro"
		3:
			Escribir "Cerdo"
		4:
			Escribir "Rata"
		5:
			Escribir "Buey"
		6:
			Escribir "Tigre"
		7:
			Escribir "Conejo"
		8:
			Escribir "Dragón"
		9:
			Escribir "Serpiente"
		10:
			Escribir "Caballo"
		De Otro Modo:
			Escribir "Cabra"
	FinSegun
FinAlgoritmo
