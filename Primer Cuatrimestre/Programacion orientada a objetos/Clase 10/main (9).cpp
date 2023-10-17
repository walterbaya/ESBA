/******************************************************************************

3)
Escribí un programa para solicitar al usuario que ingrese números enteros positivos 
(la cantidad que ingresará no se conoce y la decide el usuario). 
La lectura de números finalizará cuando el usuario ingrese el número -1. 
Por cada número ingresado, mostrar la cantidad de dígitos pares y la cantidad de dígitos impares que tiene. 
Al finalizar, mostrar cuántos números múltiplos de 3 ingresó el usuario.

*******************************************************************************/
#include <iostream>

using namespace std;

int main()
{
    int numero = 0;
    
    do {
        cout<<endl<<"Ingrese un numero entero positivo ";
        cin>>numero;
        
        
        int temp = numero;
        int cantidadPares = 0;
        int cantidadImpares = 0;
        int digito = 0;
        
        while(temp != 0){
            
            cout <<"temp es: " <<temp<<endl;
            
            digito = int(10*(float(temp)/10 - temp/10)); 
            
            cout<<"el digito a contar es: "<<digito<<endl;
            
            if(digito % 2 == 0){
                cantidadPares++;
            }
            else{
                cantidadImpares++;    
            }
            
            temp = temp / 10;
            cout<<"La cantidad de numeros pares son: "<<cantidadPares<<endl;
            cout<<"La cantidad de numeros impares son: "<<cantidadImpares<<endl;
        }
        
        
    }
    while(numero != -1);

    return 0;
}