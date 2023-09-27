/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>

using namespace std;

int main()
{
    float base;
    int potencia;
    float res = 1;
    cout<<"Ingrese la base: ";
    cin >> base;
    cout<<"Ingrese la potencia: ";
    cin >> potencia;
    
    for(int i = 1; i <= potencia; i++){
        res = res * base;       
    } 
    
    cout<<"a^b es igual a: "<<res;

    return 0;
}