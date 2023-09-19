/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>

/**
3)	Una estación de servicio se encuentra ubicada en la ruta 51. 
No existe otra estación expendedora de combustible en 200 km a la redonda. 
Escriba un programa que permita averiguar si un vehículo necesita combustible para llegar a la próxima estación. 
El programa pide la siguiente información:

-	La capacidad de combustible del tanque.
-	Cuánto indica la aguja del marcador de combustible en porcentaje.
-	Los kilómetros por cada litro de consumo.

El programa debe imprimir en pantalla “Necesita combustible” o 
“Combustible suficiente” dependiendo si el auto puede o no transitar los 200 km 
con el combustible existente en el tanque.

*/
using namespace std;

int main()
{
    unsigned km = 200;
    //Segun la investigacion deberia ser un entero sin signo
    unsigned capacidadTanque = 0;
    //Parece ser que a veces se manda con una coma al final en el reloj
    float porcentaje = 0;
    //Segun la investigacion deberia ser un float
    float kmsPorLitro = 0;
    float litrosRestantes = 0;
    float litrosNecesarios = 0;
    string mensaje = "Necesita Combustible";
    
    cout<<"Ingrese la capacidad de combustible del tanque: "<<endl;
    cin>>capacidadTanque;
    cout<<"Ingrese cuanto marca la aguja del marcador de combustible(porcentaje): "<<endl;
    cin>>porcentaje;
    cout<<"Ingrese cuantos kilometros se pueden recorrer por cada litro de consumo: "<<endl;
    cin>>kmsPorLitro;
        
    //Litros que quedan en el tanque.
    litrosRestantes = (porcentaje * capacidadTanque / 100);
    litrosNecesarios = km / kmsPorLitro;
    
    cout<<litrosRestantes<<endl;
    cout<<litrosNecesarios<<endl;
    
    if( litrosRestantes >= litrosNecesarios){
        mensaje = "Combustible suficiente";
    }
    
    cout<<mensaje<<endl;
    
    return 0;
}