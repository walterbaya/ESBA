#Se necesita un programa en Python para ver cuales son los alumnos más
#recomendables para ofrecerle una beca de estudios para rellenar un curso
#que va a comenzar y no se completó el cupo.

#El proceso debe revisar entre los alumnos que nunca hicieron ese curso
#y mostrar un listado con: el cuit, el nombre, el promedio de dias de atraso y la
#cantidad total de cuotas que pagaron.

#Se valorará si se puede mostrar solo los primeros 10 que tengan el menor
#valor en el promedio de atraso, y si el listado sale ordenado por el promedio.
#Para ordenar, si se posee un diccionario de alumnos que contiene
#diccionarios con la clave “promedio” se puede utilizar la función
#orden= sorted(alumnos.items(), key= lambda x: x[1][“promedio”],
#reversed=True)
#Si se utiliza en forma correcta el paradigma de programación orientado a
#objetos en la codificación se considerarán 3 puntos de la nota.'

class alumno:
    cuit: "" 
    usuario: ""
    codcurso: ""
    numcuota: 0
    importe: 0
    fecha: ""
    atraso: 0
    
    def __init__(self):
        pass
    

class instituto:
    __alumnos: {}

    def cargar_alumnos(self):
        try:
            #Abrimos en modo solo lectura
            archivo = open("archivos/notas.csv", "r")
            contenido = archivo.read()
            filas = contenido.split("\n")
            #Recorremos y mostramos cada línea
            for fila in filas:
                nombre, nota = fila.split(",")
                print(f"Nombre: {nombre} - Nota: {nota}")
            contenido.close()
        except FileNotFoundError:
            print("No existe el archivo")

        
        
    def __init__(self):
        cargar_alumnos(self)
        
                
    
    
     