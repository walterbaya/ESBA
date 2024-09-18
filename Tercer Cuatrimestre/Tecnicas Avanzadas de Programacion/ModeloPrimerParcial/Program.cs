using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace WalterBaya
{
    class Program
    {
        //Lo pongo static porque supongo que no requiere de una instancia de la clase en este caso.
        static int[] obtenerMultiplos(int n, int m)
        {
            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                res[i] = m * (i + 1);
            }

            return res;
        }

        static void mostrar(int[] array)
        {
            foreach (int elem in array)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();
        }

        static void mostrarDivisiblesPor3(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (Math.DivRem(array[i], 3).Remainder == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
        }


        static void mostrarMayoresA50(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] > 50)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();

        }

        static void solicitarIngreso(ref int n, ref int m)
        {

            Console.Write("Ingrese numero 1: ");

            //Valido que efectivamente sean numeros lo que se esta ingresando
            //No vimos TryParse creo igual es bastante similar a parse, nomas que devuelve un booleano indicando si efectivamente se pudo parsear a entero o a lo que sea, dependiendo
            //del tipo sobre el que se aplique.
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error, el primer numero ingresado no es un valor numerico.");
            }
            else
            {
                Console.Write("Ingrese numero 2: ");

                if (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Error, el segundo numero ingresado no es un valor numerico.");
                }
            }
        }

        static void validacion(ref bool validado, int n, int m)
        {
            validado = true;
            if (n <= 0 || m <= 0)
            {
                validado = false;
                Console.WriteLine("Error, ambos numeros deben ser mayores a 0.");
            }
        }

        static void mostrarMenuPrincipal(ref int n, ref int m, ref bool salir)
        {
            bool correcto = false;

            Console.WriteLine("Ingrese alguna de las tres opciones: ");
            Console.WriteLine("1. Mostrar los multiplos");
            Console.WriteLine("2. Mostrar solo los multiplos divisibles por 3");
            Console.WriteLine("3. Mostrar solo los multiplos mayores a 50");
            Console.WriteLine("4. salir");

            int respuesta = 0;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out respuesta))
                {
                    Console.WriteLine("Error, ingrese una opcion valida");
                }
                else
                {
                    if (respuesta > 4 || respuesta < 1)
                    {
                        Console.WriteLine("Error, ingrese una opcion valida");
                    }
                    else
                    {
                        correcto = true;
                    }

                }
            }
            while (correcto == false);

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Estos son " + n + " multiplos de " + m);
                    mostrar(obtenerMultiplos(n, m));
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Estos son los divisibles por 3 ");
                    mostrarDivisiblesPor3(obtenerMultiplos(n, m));
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Estos son los divisibles por 50 ");
                    mostrarMayoresA50(obtenerMultiplos(n, m));
                    Console.WriteLine();
                    break;
                default:
                    salir = true;
                    break;
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            bool validado = false;
            bool salir = false;

            do
            {
                solicitarIngreso(ref n, ref m);
                validacion(ref validado, n, m);
            }
            while (validado == false);

            while (!salir)
            {
                mostrarMenuPrincipal(ref n, ref m, ref salir);
            }


        }

    }
}
