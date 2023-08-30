#include <stdio.h>
#include <iostream>
using namespace std;

//Mini calculadora
int main()
{
    int x;
    int y;
    int suma;
    int resta;
    int multi;
    float divi;
    
    //pido el ingreso de datos
    
    cout <<"Ingrese numero: ";
    cin >>x;
    cout <<"Ingrese otro numero: ";
    cin >>y;
    
    //Realizo las operaciones
    
    
    suma = x + y;
    resta = x - y;
    multi = x * y;
    
    if(y != 0)
    {
        divi = (float) x / y;
        cout << "Division:" << divi<<endl;
    }
    else
    {
        cout << "No, vieja, no podes dividir por 0!!!!!"<<endl;    
    }
    
    
    
    cout << "Suma:" << suma<<endl;
    cout << "Resta:" << resta<<endl;
    cout << "Multiplicacion:" << multi<<endl;

    return 0;
}
