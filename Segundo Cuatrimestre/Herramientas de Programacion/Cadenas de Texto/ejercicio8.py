#Crear una función llamada encripta, que reciba una cadena y retorne la misma
#cadena invertida y con cada carácter sustituido por el carácter siguiente. Crear la
#función inversa que desencripte la cadena encriptada. Por ejemplo "Instituto de
#Estudios Superiores ESBA" se encripta a “BCTF!tfspjsfqvT!tpjevutF!fe!puvujutoJ”.
    
def encripta(cad):
    res = ""
    
    for i in range(1, len(cad) + 1):
        print(i)
        res = res + chr(ord(cad[len(cad) - i]) + 1)
    
    return res
 
encriptado = encripta("Instituto de Estudios Superiores ESBA")       

def desencripta(cad):
    res = ""
    
    for i in range(1, len(cad) + 1):
        res = res + chr(ord(cad[len(cad) - i]) - 1)
    
    return res

print(encriptado)
print(desencripta(encriptado))