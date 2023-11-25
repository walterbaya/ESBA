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
    int multiplosDeTres = 0;
    
    cout<<endl<<"Ingrese un numero entero positivo ";
    cin>>numero;
    
    while(numero != -1){
        
        if(numero % 3 == 0){
            multiplosDeTres++;
        }
        
        
        int temp = numero;
        int cantidadPares = 0;
        int cantidadImpares = 0;
        int digito = 0;
        
        while(temp != 0){
            
            digito = int(10*(float(temp)/10 - temp/10)); 
            
            if(digito % 2 == 0){
                cantidadPares++;
            }
            else{
                cantidadImpares++;    
            }
            
            temp = temp / 10;
        }
        
        cout<<"La cantidad de cifras pares del numero son: "<<cantidadPares<<endl;
        cout<<"La cantidad de cifras impares del numero son: "<<cantidadImpares<<endl; 
        cout<<endl<<"Ingrese un numero entero positivo ";
        cin>>numero;
    }    
    
    cout<<"La cantidad de multiplos de tres es de: "<<multiplosDeTres;
    
    return 0;
}
