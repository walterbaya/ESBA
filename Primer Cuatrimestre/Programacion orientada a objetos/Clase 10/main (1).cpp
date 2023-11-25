/******************************************************************************

Ejercicio calcular e^x

*******************************************************************************/
#include <iostream>

using namespace std;

int main()
{
    float x;
    float potenciaUltima;
    float factorial = 1;
    
    cout<<"Ingrese el exponente x: ";
    cin>>x;
    
    acum = x;
    
    float res = 1 + x;

    for(int i = 2; i <= 10; i++){
        
        factorial*=i;
        
        
        potenciaUltima = x * potenciaUltima;
        
        cout<<endl<<"Factorial: "<<factorial;
        cout<<endl<<"X: "<<x;
        
        float coef = x/i; 
        
        res+=coef;
    }

    return 0;
}