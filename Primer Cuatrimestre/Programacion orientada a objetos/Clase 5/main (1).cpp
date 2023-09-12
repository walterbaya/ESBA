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
1

Factura:
  Pastafrola dos pisos  	12.00
  Envío      		7.00
  Total         		19.00*/
#include <iostream>

using namespace std;

int main()
{
    string producto;
    float precio;
    float envio;
    float total;
    int despuesMedianoche;
    
    cout<<"Ingrese producto: "<<endl;
    cin>>producto;
    
    cout<<"Ingrese precio: "<<endl;
    cin>>precio;
    
    cout<<"Despues de medianoche (0==no, 1==yes)"<<endl;
    cin>>despuesMedianoche;
    
    if(precio < 20){
        envio = 2;
    }
    else{
        envio = 3;
    }
    
    total = precio + envio;
    
    if(despuesMedianoche == 1){
        total = total + 5;
    }

    cout<<"Factura: "<<endl;
    cout<<producto<<": "<<precio<<endl;
    cout<<"Envio: "<<envio<<endl;
    cout<<"Total: "<<total<<endl;
    
    return 0;
}