import random

def obtener_numeros():
    numeros = []
    for i in range(0, 3):
        numeros.append(random.randint(1, 5))
    return numeros

def apostar(apuesta, fichas):

    numeros = obtener_numeros()

    print("Obtuviste los siguientes numeros: ")
    for num in numeros:
        print(num)
    
    if numeros[0] == numeros[1] and numeros[1] == numeros[2]:
        print("Genial obtuviste 5 X", apuesta)
        fichas = fichas + 5 * apuesta
        
    elif numeros[0] == numeros[1] or numeros[1] == numeros[2] or numeros[0] == numeros[2]: 
        print("Bien obtuviste 2 X", apuesta)
        fichas = 2 * apuesta + fichas

    else:
        print("Lastima, intenta de nuevo")
        fichas = fichas - apuesta
        
    print("Tenes", fichas, "fichas")

    return fichas

def jugar():

    fichas = 1000
    retirado = False
    
    while not(retirado) and fichas > 0:
        
        apuesta = int(input("ingrese la cantidad de fichas a apostar, para retirarse presione 0: "))
        
        if(apuesta == 0):
           retirado = True     
           
        elif (apuesta <= fichas):
            print("Estas apostando: ", apuesta, " fichas")
            fichas = apostar(apuesta, fichas)
        
        else:
            print("Error, no contas con esa cantidad de fichas, intenta nuevamente")
 
    print("Juego finalizado, buena suerte!")    