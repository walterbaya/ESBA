#Estudiante: Walter Ariel Baya
#Dni: 39749587
#Turno: Noche

class instituto:
    __info_alumno_curso = None  #debe ser privado no queremos que puedan tocarlo desde el exterior, quizas verlo solamente
    
    def __init__(self):
        print("Iniciando nuevo instituto")
        #Cargamos el diccionario
        self.__info_alumno_curso = None
        self.__info_alumno_curso = self.cargar_archivo()
        
        if self.__info_alumno_curso != None:
            print("Carga de archivo exitosa")
        
    def ver_info_alumnos(self):
        print(self.__info_alumno_curso)   
        
    #METODOS PUBLICOS
    
    #Ejercicio 1 carga de archivo, la funcion es publica, por si queremos volver a cargar el archivo, no necesitamos crear el instituto otra vez.
    #Se puede ejecutar dejando el diccionario cargado
    def cargar_archivo(self):
        dicc = None
        try:
            archivo = open("archivo.txt", 'r', encoding="UTF-8")
            lineas = archivo.read().split("\n")
            dicc = {}
            
            for linea in lineas:
                info_alumno = linea.split(",")
        
                if  dicc.get(info_alumno[0]):
                    dicc[info_alumno[0]][info_alumno[1]] = float(info_alumno[2]) 
                else:
                    dicc[info_alumno[0]] = {info_alumno[1] : float(info_alumno[2])}
            
            archivo.close()
        
        #Frente a cualquier excepcion debemos anular el diccionario, de esta manera no tendremos estados invalidos de diccionarios cargados por la mitad por ejemplo     
        except FileNotFoundError:
            dicc = None
            print("Error, no se encontró el archivo con las notas por alumno en materia.")
        except IndexError:
            dicc = None
            print("Error, alguno de los campos presenta un error, revise el archivo y asegurese de tener en cada campo dni alumno, nombre materia, nota materia sin dejar espacios en blanco al final del mismo.")
        except ValueError:
            dicc = None
            print("Error, asegurese de que las notas sean de tipo numerico y que esten cargadas correctamente")
        except Exception as e:
            dicc = None
            print("Error, descripcion del mismo: ", e)
        
        print(dicc)
        return dicc
        
    #Ejercicio 2 devolver tupla con materias sin repeticiones
    
    def devolver_materias(self):
        dicc = {}
        
        try:
            for registro in self.__info_alumno_curso.values():
                #registro.values() es un diccionario, donde las claves son las materias por cada alumno
                #defino al diccionario con todas esas claves
                for clave in registro.keys():
                    dicc[clave] = 1
            #una vez creado este diccionario solamente tengo que obtener sus claves que sabemos que no se repiten y pasarlas a una tupla
        except Exception as e:
            print("Error", e)

        return tuple(dicc.keys())

    #Ejercicio 3 calcular promedio por materia
    
    def promedio(self):
        dicc = {}
        dicc_count = {}
        
        try:
            for registro in self.__info_alumno_curso.values():
                #registro.values() es un diccionario, donde las claves son las materias por cada alumno
                #los valores son las notas
                #defino al diccionario con todas esas claves y le asigno la suma de lo que obtuvieron los alumnos
                for clave in registro.keys():
                    if dicc.get(clave):
                        dicc[clave] += registro.get(clave) #nota alumno
                        dicc_count[clave] += 1              #incremento el contador de materias en 1
                    else: 
                        dicc[clave] = registro.get(clave)
                        dicc_count[clave] = 1
            
            #Una vez tenidos ambos diccionarios solo queda poner en dicc lo mismo pero dividido la cantidad de materias
            
            for clave in dicc.keys():
                dicc[clave] = dicc[clave] / dicc_count[clave]   
        
        except Exception as e:
            print("Error", e)

        return dicc
        
    #Ejercicio 4 devolver las materias donde le falta calificacion al alumno
    #Habia supuesto que era obligatorio que estuvieran cargadas las calificaciones
    #ya que sino a la hora de leer el archivo iba a tener un error y se complica realizar los demas calculos. 
    #Asi que para este ejercicio voy a suponer que las notas pueden no estar cargadas y volver a cargar el archivo de forma temporal
    #para a modo de aviso presentar cuales son las calificaciones que debieran ser cargadas
    
    def materias_incompletas(self):
        dicc = None
        res = []
        try:
            archivo = open("archivo.txt", 'r', encoding="UTF-8")
            lineas = archivo.read().split("\n")
            dicc = {}
            
            for linea in lineas:
                info_alumno = linea.split(",")
                if  dicc.get(info_alumno[0]):
                    #Cargo todo como texto esta vez
                    dicc[info_alumno[0]][info_alumno[1]] = info_alumno[2] 
                else:
                    dicc[info_alumno[0]] = {info_alumno[1] : info_alumno[2]}
            
            archivo.close()
            
            
            #Comienzo del procesamiento del ejercicio en si
        
            #Itero los dnis de los alumnos
            for dni in dicc:              
                #Acá tengo que iterar todas las materias con las notas de los alumnos
                lista_tupla = [] 
                for materia in dicc.get(dni):
                    #Si esta definido el valor no hago nada
                    if dicc.get(dni).get(materia):
                        pass
                    #En otro caso voy directamente a agregarlo a la lista tupla
                    else:
                        lista_tupla.append(materia)
                res.append([dni, tuple(lista_tupla)])
                
        #Frente a cualquier excepcion debemos anular el res, de esta manera no tendremos estados invalidos de diccionarios cargados por la mitad por ejemplo     
        except FileNotFoundError:
            res = None
            print("Error, no se encontró el archivo con las notas por alumno en materia.")
        except IndexError:
            res = None
            print("Error, alguno de los campos presenta un error, revise el archivo y asegurese de tener en cada campo dni alumno, nombre materia, nota materia sin dejar espacios en blanco al final del mismo.")
        #Elimino la excepcion de valor.
        except Exception as e:
            res = None
            print("Error, descripcion del mismo: ", e)
        
        return res
    

#SECCION DE PRUEBAS
    
#PRUEBAS EJERCICIO 1
    
#Creacion de instituto
instituto1 = instituto()

#La unica manera de probar el primer metodo es en base a cargar el archivo con errores diferentes o con diferentes entradas
#eso mismo va a producir errores en la carga del archivo

#Camino feliz

#34567890,Matemáticas,85
#34567890,Programación Orientada a Objetos,45
#34567890,Programación I,75
#29012345,Programación Orientada a Objetos,60
#29012345,Filosofía,100        

#Error tipo flotante de materia

#34567890,Matemáticas,85
#34567890,Programación Orientada a Objetos,45
#34567890,Programación I,75
#29012345,Programación Orientada a Objetos,60
#29012345,Filosofía,n

# error en cantidad de indices causada por tener espacio en blanco al final

#34567890,Matemáticas,85
#34567890,Programación Orientada a Objetos,45
#34567890,Programación I,75
#29012345,Programación Orientada a Objetos,60
#29012345,Filosofía,100        
#

#Si el archivo no esta o esta en otra direccion va a tirar file not found.

#Esta funcion la hice para ver que se pudiera ver la info de los alumnos
instituto1.ver_info_alumnos()

# PRUEBAS EJERCICIO 2 nuevamente las pruebas se realizan con archivos al igual que antes

print(instituto1.devolver_materias())

#Camino feliz

#34567890,Matemáticas,85
#34567890,Física,45
#34567890,Química,75

#Ninguna materia, deberia tirar error, ya que no hay atributos y devolver la tupla vacia

#

#Una materia, devuelve la misma ('Matematicas',)

#34567890,Programación Orientada a Objetos,45

#Ejercicio 3

print(instituto1.promedio())

#Las pruebas que realice

#34567890,Matemáticas,85
#34567890,Matemáticas,45
#34567890,Matemáticas,75

#34567890,Física,85
#34567890,Matemáticas,45
#34567890,Matemáticas,75

#34567890,Matemáticas,85
#34567890,Geografia,45
#34567890,Literatura,75

#Si no tiene lineas obviamente me tira error y me dice que es vacio, supongo que tenemos que tener al menos 1 elemento cargado en el archivo
#para el correcto empleo de estas funciones

#


#Ejercicio 4

print(instituto1.materias_incompletas())
#Supongo el siguiente archivo, al que le falta una para ese alumno

#34567890,Matemáticas,
#34567890,Geografia,45
#39567890,Literatura,75
#39567890,Biologia,
#39567890,Arte,

#Me devuelve correctamente un vector vacio.

#34567890,Matemáticas,44
#34567890,Geografia,45
#39567890,Literatura,75
#39567890,Biologia,44
#39567890,Arte,44
