
dicc_archivo = {}

try:

    #Abrimos en modo solo lectura
    archivo = open("archivos/listado-comunidades-indigenas.csv", "r", encoding="UTF-8")
    contenido = archivo.read()
    filas = contenido.split("\n")
    
    #procesarlo y obtener cuantas comunidades 
    #se registran por provincia, cada registro corresponde a una
    #comunidad. Tenga precaución en la elección del separador ya que la coma también
    #está incluida dentro de uno de los campos.
    
    encabezado = filas[0][2 : len(filas[0]) - 1].split('","')
    
    
    for fila in filas:
        comunidad_provincia = fila[2 : len(fila) - 1].split('","')[encabezado.index('comunidad_provincia')]
        
        #Me fijo si la provincia esta definida ya.
        if dicc_archivo.get(comunidad_provincia) == None:
            dicc_archivo[comunidad_provincia] = 1
        
        #Si esta definida le agrego una comunidad, porque en esta fila figura esa provincia otra vez.
        else:    
            dicc_archivo[comunidad_provincia] = dicc_archivo[comunidad_provincia] + 1 
        
    archivo.close()

except FileNotFoundError:
    print("No existe el archivo")
except UnicodeDecodeError:
    print("Hubo un error, no se pudo decodificar un byte en una posición")

    