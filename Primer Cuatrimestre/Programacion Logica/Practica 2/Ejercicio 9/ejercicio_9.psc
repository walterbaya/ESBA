//Entrada: una letra y un numero 
//Salida: Un mensaje mostrando de que color es la casilla que se corresponde con la letra y numero indicados, si es una posicion invalida indicarlo.
Algoritmo ejercicio_9
	Escribir "Ingrese un numero: "
	Leer num
	Escribir "Ingrese una letra: "
	Leer letra
	//Creo que la expresion podria reemplazarse por a <= letra Y letra <= h tomando en cuenta que las letras se codifican como ASCII, habria que preguntar como se comparan las cadenas, pero parece complejo.
	//En principio parece seguir orden lexicografico, el tema es que no podemos limitar a que ingrese una letra y en su lugar ingrese una cadena de caracteres.
	//Si aseguramos que el usuario esta ingresando un caracter entonces podriamos reducir, deberia estar como pactado y asegurado eso.
	Si num <= 8 Y num >= 1 Y (letra = "a" O letra = "b" O letra = "c"  o letra = "d" O letra ="e" O letra = "f" O letra ="g" O letra = "h")
		Si (num MOD 2 <> 0 Y (etra = "b" O letra = "d" O letra = "f" O letra = "h")) O (num MOD 2 = 0 Y (letra = "a" O letra = "c" O letra = "e" O letra = "g"))
			Escribir "La casilla correspondiente a la posicion indicada es blanca." 
		Sino 
			Escribir "La casilla correspondiente a la posicion indicada es negra."
		FinSi
	SiNo
		Escribir  "La posicion indicada es invalida"
	FinSi
FinAlgoritmo
