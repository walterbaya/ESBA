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
    double num;
    double max;
    double min;
    
    cout<<"Ingrese un numero: ";
    cin>>num;
    max = num;
    min = num;

    for(short i = 0; i < 4; i++){
        cout<<endl<<"Ingrese un numero: ";
        cin>>num;
        if(num > max ){
            max = num;
        }
        if(num < min){
            min = num;
        }
    }
    
    cout<<endl<<"El mayor es: "<<max;
    cout<<endl<<"El menor es: "<<min;
    
    return 0;
}