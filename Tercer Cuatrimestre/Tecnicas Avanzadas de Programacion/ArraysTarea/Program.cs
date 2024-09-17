using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace WalterBaya
{
    class Program
    {
        //Ejercicio 1
        static int arraySum(int[] array)
        {
            int acum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                acum += array[i];
            }

            Console.WriteLine("Sum: " + acum);
            return acum;
        }
        static void biggest(int[] array)
        {
            int biggest = array[0];


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= biggest)
                {
                    biggest = array[i];
                }
            }

            Console.WriteLine("The biggest element is: " + biggest);
        }

        static void smallest(int[] array)
        {
            int smallest = array[0];


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= smallest)
                {
                    smallest = array[i];
                }
            }

            Console.WriteLine("The smallest element is: " + smallest);
        }

        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] loadArray()
        {
            int[] array = new int[10];
            //Cargar el arreglo

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el elemento " + (i + 1) + " del arreglo: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;

        }

        //Ejercicio 2

        static void printTable(int[,] table) {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void mainDiagonal(int[,] table) {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.Write(table[i, i] + " ");
            }
            Console.WriteLine();
        }

        static void secondaryDiagonal(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.Write(table[i, table.GetLength(0) - i - 1] + " ");
            }
            Console.WriteLine();
        }

        static void findElement(int[,] table)
        {
            int value = 0;
            bool encontrado = false;
            Console.Write("Ingrese el valor: ");
            value = int.Parse(Console.ReadLine());

            for (int i = 0; i < table.GetLength(0) && !encontrado; i++)
            {
                for (int j = 0; j < table.GetLength(1) && !encontrado; j++)
                {
                    if (table[i, j] == value)
                    {
                        encontrado = true;
                        Console.WriteLine("Valor encontrado en posición: " + i + " " + j);
                    } 
                }
            }

            if (!encontrado) {
                Console.WriteLine("Valor no encontrado en el arreglo.");
            }
        }

        //Ejercicio 3
        static string mixChains(string cadena1, string cadena2) {
            StringBuilder chain = new StringBuilder();

            int i = 0;
            int j = 0;
            while (i + j < cadena1.Length + cadena2.Length) {
                if ( i < cadena1.Length) {
                    chain.Append(cadena1[i]);
                }
                if (j < cadena2.Length) {
                    chain.Append(cadena2[j]);
                }

                i++;
                j++;
            }

            Console.WriteLine("Resultado: " + chain.ToString());

            return chain.ToString();
        }

        //Ejercicio 4

        static bool isPrime(int a) {
            bool res = true;
            if (a > 1) {
                for (int i = 2; i < Math.Sqrt(a); i++)
                {
                    if (a % i == 0) {
                        res = false;
                    }
                }   
             }
            return res;
        }

        static int[] firstNPrimes(int n) {
            int primeCounter = 0;
            int[] res = new int[n];

            int i = 2;
            while (primeCounter < n) {
                if (isPrime(i)) {
                    res[primeCounter] = i;
                    primeCounter++;
                }
                i++;
            }

            return res;
        } 
        /*
         4- En la Clase “Program” del Namespace “Apellido_Nombre” (escriban su apellido y su nombre):
        Crear el método bool esPrimo(int a) que devuelve true si un número es primo y false si no lo es.
        En el main, buscar los primeros 50 números primos.
        Guardar todos los números en un array de 50 posiciones.
        Mostrar el contenido del array resultante.
        Mostrar en pantalla la suma (acumulación) de todos los números del array.
        Mostrar en pantalla el promedio de todos los números del array.

        Puntos extra por:
        Validar en la función bool esPrimo(int a), que la variable ‘a’ sea mayor a 1.
        Utilizar while, for y foreach cuando se debe.
        Uso de constantes.
        Utilizar métodos de System.Array y System.Math. (En la medida que sea posible).
         */



        static void Main(string[] args)
        {
            //Ejercicio 1

            //int[] array = load_array();

            //printArray(array);

            //int sum = arraySum(array);

            //biggest(array);

            //smallest(array);

            //Ejercicio 2

            //int[,] table = new int[3, 3] { { 3, 4, 5 }, { 4, 5, 6 }, { 3, 4, 2 } };

            //printTable(table);

            //mainDiagonal(table);

            //secondaryDiagonal(table);

            //findElement(table);

            //string chain1 = "Hola";
            //string chain2 = "Mundo";

            //mixChains(chain1, chain2);

            //Ejercicio 4

            //const int primosRequeridos = 50;
            //int[] first50Primes = firstNPrimes(primosRequeridos);

            //printArray(first50Primes);
            //int sum = arraySum(first50Primes);
            //Console.WriteLine("El promedio es de: " + ((float)sum / (float)50));
            
        }
    }
}
