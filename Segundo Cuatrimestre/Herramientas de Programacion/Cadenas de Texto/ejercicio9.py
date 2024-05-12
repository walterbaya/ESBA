#Realizar una función que reciba tres cadenas de texto y devuelva la primera cadena
#con cada aparición del segundo argumento sustituido por el tercer argumento, por
#ejemplo en el texto “nitrico, sulfurico, ” sustituir “ico” por “ato”, se obtiene “nitrato,
#sulfurato, ”.

def reemplazo(cad, pri, seg):
    return cad.replace(pri, seg)
    
    
print(reemplazo("nitrico, sulfurico, ", "ico", "ato"))