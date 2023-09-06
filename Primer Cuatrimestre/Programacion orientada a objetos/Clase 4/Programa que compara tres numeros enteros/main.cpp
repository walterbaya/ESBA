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
    int x,y,z,max;
    cout<<"Ingrese un numero entero: "<<endl;
    cin>>x;
    cout<<"Ingrese un segundo numero entero: "<<endl;
    cin>>y;
    cout<<"Ingrese un tercer numero entero: "<<endl;
    cin>>z;
    
    if(x > y)
    {
        if(x > z){
            max = x;
        }
        else{
            max = z;
        }
    }
    else
    {
        if(y > z){
            max = y;
        }else{
            max = z;
        }
    } 
    
    cout<<"El maximo es: "<<max<<endl;
    return 0;
}