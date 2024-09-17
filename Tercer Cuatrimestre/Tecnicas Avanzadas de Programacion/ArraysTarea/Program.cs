using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace WalterBaya
{
    class Program
    {
        //Ejercicio 1
        static void arraySum(int[] array)
        {
            int acum = 0;

            for (int i = 0; i < 10; i++)
            {
                acum += array[i];
            }

            Console.WriteLine("Sum: " + acum);
        }
        static void biggest(int[] array)
        {
            int biggest = array[0];


            for (int i = 1; i < 10; i++)
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


            for (int i = 1; i < 10; i++)
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
            for (int i = 0; i < 10; i++)
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
                for (int j = 0; j < 3; j++)
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

        static void Main(string[] args)
        {
            //Ejercicio 1

            //int[] array = load_array();

            //printArray(array);

            //arraySum(array);

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
        }
    }
}
