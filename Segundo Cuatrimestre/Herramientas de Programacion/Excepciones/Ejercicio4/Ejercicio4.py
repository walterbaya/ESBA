#Crear un programa que maneje un archivo donde se almacena la siguiente
#información de una determinada cantidad personas: Nombre, Apellido, Edad y
#Estatura. El programa presentará un menú las siguientes opciones:
#Agregar datos: Se pide que ingrese los datos de una persona, se validará que
#edad se encuentre entre 18 y 70 y estatura entre 1 y 2.5. En caso de que el
#ingreso sea válido se guardará el registro al final del archivo.
#Resumen: Procesará el archivo completo y mostrará en pantalla:
# -Apellido, nombre y la altura de la personas más alta y más baja
# -Promedio de altura general.
# -El apellido, nombre y la edad de las personas más joven, más adulta.
# -El promedio de edad
# -Cantidad total de registros del archivo.
#Salir: para salir del programa.'

def ingresar_datos():
    try:
        archivo = open("archivos/informacion.txt", "a")
            
        nombre = input("Ingrese Nombre: ")
        apellido = input("Ingrese Apellido: ")
        edad = int(input("Ingrese Edad: "))
        estatura = float(input("Ingrese Estatura: "))
            
        if edad <= 70 and edad >= 18 and estatura <= 2.5 and estatura >= 1:
            informacion = ",".join([nombre, apellido, str(edad), str(estatura)])
            print(informacion, file=archivo)
        else:
            raise Exception("La edad o la altura es incorrecta, revise que la edad este en el rango 18 - 70 años y que la estatura este en el rango 1 - 2.5")
            
        archivo.close()
        
    except FileNotFoundError:
        print("No se encontró el archivo informacion.txt")
    except ValueError:
        print("Se ingreso un dato invalido, recuerde ingresar la estatura con punto como separador ex: 1.5 y la edad como un entero sin coma ni punto, ex: 25")
    except Exception as e:
        print(e)

def obtener_resumen():
    try:
        archivo = open("archivos/informacion.txt", "r")
        #Leo el archivo pero a su vez el encabezado que voy a tener no lo quiero.
        filas = archivo.read().split("\n")[1:]
        #Limpio filas vacias
        filas.remove("")
        
        cantidad_registros = 0
        suma_edad = 0
        suma_estatura = 0
        altura_minima = 100
        altura_maxima = -1
        edad_minima = 100
        edad_maxima = -1
        persona_mas_alta = ""
        persona_mas_baja = ""
        persona_mas_joven = ""
        persona_mas_adulta = ""
        
        
        for fila in filas:    
            nombre, apellido, edad, estatura = fila.split(",")
            cantidad_registros = cantidad_registros + 1
            suma_edad = suma_edad + int(edad)
            suma_estatura = suma_estatura + float(estatura)
            
            info_estatura = ", ".join([apellido, nombre, str(estatura)])
            if(float(estatura) <= altura_minima):
                persona_mas_baja = info_estatura
            if(float(estatura) >= altura_maxima): 
                persona_mas_alta = info_estatura
                
            info_edad = ", ".join([apellido, nombre, str(edad)])
            if(int(edad) <= edad_minima):
                persona_mas_joven = info_edad
            if(int(edad) >= edad_maxima): 
                persona_mas_adulta = info_edad
                
        # El apellido, nombre y la edad de las personas más joven, más adulta.
        
        print("La cantidad de registros es: ", cantidad_registros)
        print("El promedio de edad es: ", suma_edad/cantidad_registros)
        print("El promedio de estatura es: ", suma_estatura/cantidad_registros)    
        print("Información de persona más joven: ", persona_mas_joven)
        print("Información de persona más adulta: ", persona_mas_adulta)
        print("Información de persona más alta: ", persona_mas_alta)
        print("Información de persona más baja: ", persona_mas_baja)    
            
        archivo.close()
        
    except FileNotFoundError:
        print("No se encontró el archivo información.txt")
    except ValueError:
        print("Se intento leer algun valor numérico pero la lectura fallo")
    except Exception as e:
        print("Error,", e)


seleccion = int(input("Seleccione una opción: \n 1. Agregar Datos \n 2. Resumen \n 3. Salir \n"))

while seleccion != 3:  
    try:
            #Ingreso de datos
        if seleccion == 1:
            ingresar_datos()
        else:
            obtener_resumen()
            
        seleccion = int(input("Seleccione una opción: \n 1. Agregar Datos \n 2. Resumen \n 3. Salir \n"))    
    except KeyboardInterrupt:
        print("Saliendo del programa")    
    
        
        
        

        
        