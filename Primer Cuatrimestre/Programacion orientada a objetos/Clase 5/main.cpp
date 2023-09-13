#include <iostream>

using namespace std;

int main()
{
    int a;
    int b;
    int contador = 0;
        
    cout << "Ingrese un numero: ";
    cin >> a;
    cout << endl << "Ingrese otro: ";
    cin >> b;
    
    a += b;  // a = a +b
    
    cout << endl << a;
    cout << endl << contador;
    
    contador++; // contador = contador + 1
    
    cout << endl << contador;
    contador++;
    cout << endl << contador;
            
    return 0;
}