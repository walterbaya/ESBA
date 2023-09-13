/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
/*4)	“Cacho y Marta Delicatessen” (altas confituras) desean un programa para tomar pedidos por Internet. 
El programa pide por un producto y su precio. Además, 
se cobra envío de acuerdo a la siguiente consideración: 
pedidos menores a $20 es de $2, superiores a $20 el costo es de $3.
Si el pedido se realiza después de medianoche se le suman $5 más.
Ejemplo de ejecución del programa:
Ingrese producto:
Pastafrola de dos pisos.
Precio:
12.00
Despues de medianoche (0==no, 1==yes)
#include <iostream>

using namespace std;

int main()
{
    string producto;
    float precio;
    char medianoche; //s o un n 
    float total;
    float adicional;
    cout << "Ingrese producto: ";
    cin >> producto;
    cout << endl << "Precio: "<< precio;
    cin >> precio;
    cout << endl << "Despues de medianoche (0=NO 1=SI): ";
    cin >> medianoche;
if(precio < 20)
    {
        adicional = 2;
    }
    else
    {
        adicional = 3;
    }
    
    if(medianoche == 's')
    {
        adicional += 5; //Operador interesante para usar
    }
    
    total = precio + adicional;
    
    cout << endl << "Factura: ";
    cout << endl << "\t" << producto << "\t\t" << precio;
    cout << endl << "\tEnvio " << "\t\t" << adicional;
    cout << endl << "\tTotal " << "\t\t" << total; 
            
            
    return 0;
}