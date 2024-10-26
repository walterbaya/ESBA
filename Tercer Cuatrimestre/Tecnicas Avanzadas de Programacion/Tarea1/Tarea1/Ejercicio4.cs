using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/**
“Cacho y Marta Delicatessen” (altas confituras) desean un programa para tomar pedidos. El programa pide por un producto y su precio.
Además se cobra envío de acuerdo a la siguiente consideración: pedidos menores a $20 es de $2, superiores a $20 el costo es de $3. Si el pedido se realiza después de medianoche se le suman $5 más.
Ejemplo de ejecución del programa:

Ingrese producto:
Pastafrola de dos pisos.
Precio:
12.00
Despues de medianoche (0==no, 1==yes)
1

Factura:
  Pastafrola dos pisos  	12.00
  Envío      		7.00
  Total         		11.50
**/

namespace Tarea1
{
    internal class Ejercicio4
    {  
        public static void solucion() {
            string nombreProducto = "";
            float precio = 0;
            float envio = 0;
            int despues = 0;

            Console.WriteLine("Ingrese Producto: ");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Precio: ");
            //Al parecer hay un problema con el tema de que en la cultura nuestra se usa la , como separador, pero en el ejercicio figura con punto.
            precio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Despues de medianoche (0==no, 1==yes)");
            despues = int.Parse(Console.ReadLine());

            if (precio < 20) {
                envio = 2;
            }else {
                envio = 3;
            }

            if (despues == 1) {
                envio += 5;
            }

            
            
            Console.WriteLine("\nFactura:");
            Console.WriteLine("\t" + nombreProducto + "\t" + precio);
            Console.WriteLine("\tEnvío\t" + envio);
            Console.WriteLine("\tTotal\t" + (envio + precio));
        }
        
    }
}
