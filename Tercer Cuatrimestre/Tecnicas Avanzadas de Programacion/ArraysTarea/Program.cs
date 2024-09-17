using System;

namespace WalterBaya
{
    class Program
    {
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
                Console.WriteLine("Array[" + i + "] = " + array[i]);
            }
        }

        static int[] load_array()
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

        static void Main(string[] args)
        {
            //Ejercicio 1

            int[] array = load_array();

            printArray(array);

            arraySum(array);

            biggest(array);

            smallest(array);
        }
    }
}
