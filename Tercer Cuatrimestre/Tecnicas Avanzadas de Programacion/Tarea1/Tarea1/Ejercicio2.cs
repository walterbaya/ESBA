using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que calcule el área de un circulo. Se ingresa el radio del circulo por teclado. Puede usar la constante PI de la clase Math, haciendo Math.Pi.

La formula del área de un circulo es: PI x (Radio)2 

Para calcular el cuadrado del radio pueden hacer Radio x Radio o bien usar el método Pow de Math, haciendo:
Math.Pow(Radio, 2) 🡪 devuelve el resultado de Radio elevado al cuadrado.

 **/

namespace Tarea1
{
    internal class Ejercicio2
    {
        public static void solucion() {

            double res = Math.PI;


            Console.Write("Ingrese radio: ");
            double radio = double.Parse(Console.ReadLine());
            res = res* Math.Pow(radio, 2);
            Console.Write("El area del circulo es: " + res);
        
        }
    }
}
