//Una empresa debe registrar los pedidos recibidos de cada uno de sus 10 productos a lo largo del
//día. Por cada pedido se recibe:
//	a. Código de producto (1 a 10)
//	b. Cantidad de unidades solicitadas
//	Se puede recibir más de un pedido por producto. La carga finaliza cuando se ingresa un producto
//	con código igual a cero
//	Al finalizar se debe emitir un listado con código y cantidad de unidades solicitadas de cada
//	producto.

Funcion CargaProducto (productos ,codigo, cantidad)
	productos[codigo-1] <- cantidad
FinFuncion

Funcion mostrarVector(lista, tam)
	Para i <- 0 Hasta tam - 1 Con Paso 1 Hacer
		Escribir "El codigo: ", i + 1, " Tuvo solicitadas: ", lista[i], " Unidades."
	Fin Para
FinFuncion

Algoritmo ejercicio2
	Dimension productos[10]
	
	Escribir "Ingrese codigo de producto: "
	Leer codigo
	
	Mientras (codigo <> 0)
		Escribir "Ingrese cantidad de producto: "
		Leer cantidad		
		CargaProducto(productos, codigo, cantidad)
		Escribir "Ingrese codigo de producto: "
		Leer codigo
	FinMientras

	mostrarVector(productos, 10)
	
FinAlgoritmo
