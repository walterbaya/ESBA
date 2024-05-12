#Crear una función que reciba como argumento una cadena y devuelva una cadena
#en leet speak intercambiando vocales y algunas consonantes por números (por
#ejemplo tomado como argumento "Herramientas de Programacion" devuelva el
#string "h3rr4m13n745 d3 pr06r4m4c10n").

def leet_speak(cad):
    
    letters = ["a", "e", "g", "i", "o", "s", "t"]   
    dicc = ["4","3","6","1","0","5","7"]

    res = cad.lower()
    
    for i in range(0, len(letters)):
        res = res.replace(letters[i], dicc[i])

    return res

print(leet_speak("Herramientas de Programacion"))