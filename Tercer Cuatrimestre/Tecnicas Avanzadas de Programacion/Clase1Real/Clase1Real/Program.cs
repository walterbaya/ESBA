using System;
using System.IO;

namespace Baya_Walter
{
    class Program
    {
        static void Main()
        {
            //Manera 1

            int numero1 = 5;
            int numero2 = 10;
            Console.WriteLine("Primer numero: {0}. Segundo numero: {1}", numero1, numero2);

            float numF = (float)numero1;
            //Manera 2

            Console.WriteLine("Primer numero: " + numero1 +  ". Segundo numero: " + numero2);

            //Escribir pero sin /n
            Console.Write("Izquierda -");
            Console.Write("Derecha");

            //Usar el slash para el barra n

            Console.Write("Ahora tengo lo mismo que antes\n");


            string nombre = Console.ReadLine();
            Console.Write("Tu nombre es" + nombre + ".");

            Console.Write("\nIngresa una tecla para continuar...");
            Console.ReadKey();
            Console.Write("Gracias por usar el programa");

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Tenés " + edad + " años.");

            Console.Write(Math.PI);
            
        }
    }
}