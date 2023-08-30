#include <stdio.h>
#include <iostream>
using namespace std;

int main()
{
    int edad1;
    int edad2;
    int edad3;
    int total;
    cout <<"Ingrese edad 1: ";
    cin >>edad1;
    cout <<"Ingrese edad 2: ";
    cin >>edad2;
    cout <<"Ingrese edad 3: ";
    cin >>edad3;
    total = edad1 + edad2 + edad3;
    //Acaramos que queremos un float adelante, ya que sino el lenguaje supone que son enteros.
    float promedio = (float)total/3;
    cout << "El promedio de edades es:" << promedio; 
    return 0;
}
