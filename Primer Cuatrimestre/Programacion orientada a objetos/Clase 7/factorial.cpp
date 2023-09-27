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
    int numero;
    int res = 1;
    cout<<"Ingrese el número: ";
    cin >> numero;
    
    for(int i = 1; i <= numero; i++){
        res = res * i;       
    } 
    
    cout<<"El factorial del número es : "<<res;

    return 0;
}