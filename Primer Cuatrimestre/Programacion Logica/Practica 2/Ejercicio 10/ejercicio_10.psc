//Entrada: Nombre de materia, nota en el sistema argentino de esa materia
//Salida: Nombre de materia con su nota equivalente en el sistema estadounidense
Algoritmo ejercicio_10
	Escribir "Ingrese el nombre de la materia: "
	Leer nombreMateria
	Escribir "Ingrese la nota numerica final en sistema argentino: "
	Leer notaFinal
	Si notaFinal >= 0 Y notaFinal < 4  
		Escribir "La nota de la materia: ", nombreMateria, " es en el sistema estadounidense una F"  
	FinSi
	Si notaFinal >= 4 Y notaFinal < 5
		Escribir "La nota de la materia: ", nombreMateria, " es en el sistema estadounidense una C"  
	FinSi
	Si notaFinal >= 5 Y notaFinal < 7
		Escribir "La nota de la materia: ", nombreMateria, " es en el sistema estadounidense una B-"  
	FinSi
	Si notaFinal >= 7 Y notaFinal < 9 
		Escribir "La nota de la materia: ", nombreMateria, " es en el sistema estadounidense una B+"  
	FinSi
	Si notaFinal >= 9 Y notaFinal < 10 
		Escribir "La nota de la materia: ", nombreMateria, " es en el sistema estadounidense una A-"  
	FinSi
	Si notaFinal = 10 
		Escribir "La nota de la materia: ", nombreMateria, " es en el sistema estadounidense una A"  
	FinSi
	
FinAlgoritmo
