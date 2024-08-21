/*
 * Descripcion:
Escribir un programa que pida el ingreso de tres nombres de personas y sus edades. El programa debe mostrar el promedio de edad de las personas ingresadas.
*/

using System;
namespace Baya_Walter {
    class Ejercicio1 {

        static void Main() {
            float suma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese nombre: ");
                Console.ReadLine();
                Console.Write("Ingrese edad: ");
                suma += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("El promedio de edades es: " + suma / 3.0);
        }
    }
}