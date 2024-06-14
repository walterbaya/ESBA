
dicc_archivo = {}

try:

    #Apertura del archivo

    archivo = open("archivos/listado-comunidades-indigenas.csv", "r", encoding="UTF-8")
    contenido = archivo.read()
    filas = contenido.split("\n")
    
    #Procesamiento
    
    #Obtengo el encabezado
    encabezado = filas[0][2 : len(filas[0]) - 1].split('","')

    #Filtramos las filas vacias
    filas.remove("")
    
    #Elimino el encabezado
    filas = filas[1:]
    
    #Cada fila representa una comunidad
    for fila in filas:

        #Obtengo para cada fila, la provincia en la que esta registrada
        comunidad_provincia = fila[2 : len(fila) - 1].split('","')[encabezado.index('comunidad_provincia')]
            
        if dicc_archivo.get(comunidad_provincia) == None:
            dicc_archivo[comunidad_provincia] = 1
        
        else:    
            dicc_archivo[comunidad_provincia] = dicc_archivo[comunidad_provincia] + 1 

    print(dicc_archivo)
            
    archivo.close()

except FileNotFoundError:
    print("No existe el archivo")
except UnicodeDecodeError:
    print("Hubo un error, no se pudo decodificar un byte en una posición")
except  Exception as e:
    print("Error,", e)





    