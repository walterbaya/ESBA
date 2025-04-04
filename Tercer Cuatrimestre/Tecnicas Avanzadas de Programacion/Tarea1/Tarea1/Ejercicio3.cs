﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Una estación de servicio se encuentra ubicada en la ruta 51. No existe otra estación expendedora de combustible en 200 km a la redonda. 
 * Escriba un programa que permita averiguar si un vehículo necesita combustible para llegar a la próxima estación. El programa pide la siguiente información:

La capacidad de combustible del tanque.
Cuánto indica la aguja del marcador de combustible en porcentaje.
Los kilómetros por cada litro de consumo.

El programa debe imprimir en pantalla “Necesita combustible” o “Combustible suficiente” dependiendo 
si el auto puede o no transitar los 200 km con el combustible existente en el tanque.
**/

namespace Tarea1
{
    internal class Ejercicio3
    {
        public static void solucion() {
            Console.Write("Ingrese la capacidad de su tanque: ");
            double capacidad= double.Parse(Console.ReadLine());
            Console.Write("Ingrese cuanta cantidad marca la aguja: ");
            double cantidadActual = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de kilometros que se recorrer por cada litro");
            double kmPorLitro = double.Parse(Console.ReadLine());

            double litrosRestantes = capacidad * (cantidadActual / 100.0);
            if ((litrosRestantes * kmPorLitro) >= 200.0)
            {
                Console.WriteLine("Combustible suficiente");
            }
            else {
                Console.WriteLine("Necesita combustible");
            }
            
        }
    }
}
