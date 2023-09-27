/******************************************************************************
Escribí un programa que permita al usuario ingresar 10 números positivos . 
Una vez terminada la lectura de números, 
informar la suma total, el promedio el mas grande y el mas chico.

el profe prefiere el if == 1
*******************************************************************************/
#include <iostream>

using namespace std;

int main()
{
    int numero;
    int suma;
    int mayor;
    int menor;
    float promedio;

    cout<<"Ingrese número: ";
    cin >> numero;
    suma = numero;
    mayor = numero;
    menor = numero;
    promedio = numero;
    
    for(int i = 1; i <= 9; i++){
        cout<<"Ingrese número: ";
        cin >> numero;
        suma += numero;
        
        if(numero > mayor){
            mayor = numero;
        }
        if(numero < menor){
            menor = numero;
        }
        
    } 
    
    promedio = ((float)suma / 10);
    
    cout<<"La suma es: "<<suma<<endl;
    cout<<"El promedio es: "<<promedio<<endl;
    cout<<"El mayor es: "<<mayor<<endl;
    cout<<"El menor es: "<<menor<<endl;

    return 0;
}