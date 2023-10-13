#include <iostream>

using namespace std;

int main()
{
    int n;
    int contador = 0;
    int max; 
    
    cout << "Ingrese numero: ";
    cin >> n;
    
    while(n!=0)
    {
        contador++;
        
        if(contador == 1)
        {
            max = n;
        }
        else if(n>max)
        {
            max = n;
        }
        
        cout << "Ingrese numero: ";
        cin >> n;
    }
if(contador > 0)
    {
        cout << endl << "Mayor numero ingresado: " << max;
    }

    return 0;
}