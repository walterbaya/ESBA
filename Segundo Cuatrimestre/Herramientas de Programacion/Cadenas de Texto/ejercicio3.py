#Crear una función que dada una cadena de texto, devuelva cuántas vocales y
#cuantas consonantes tiene.

'''Dado un texto tex obtiene todos los caracteres que son solo letras'''
def obtener_letras(tex):
    res = ""
    for letra in tex:
        print(letra)
        if letra.isalpha():
           res = res + letra  
    return res

def contar_vocales_consonantes(cad):
    vocales = ["a", "e", "i", "o", "u"]
    
    res = obtener_letras(cad)

    cant_vocales = 0
    cant_consonantes = 0
        
    for letra in res:
        if letra in vocales:
            cant_vocales += 1
        else:
            cant_consonantes += 1
            
    return (cant_vocales, cant_consonantes)
