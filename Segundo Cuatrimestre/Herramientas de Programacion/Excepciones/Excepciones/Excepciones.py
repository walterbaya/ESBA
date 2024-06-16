#Ejercicio 2
#Crear un programa que vaya leyendo las frases que el usuario teclea y las guarde en
#un fichero de texto llamado frases.txt. Terminará cuando la frase introducida sea
#fin (esa frase no deberá guardarse en el fichero), a continuación abrir el archivo y
#mostrarlo por pantalla . Utilizar excepciones

frase = input("Ingrese una frase ")

try:
    archivo = open("archivos/frases.txt", "w")        
except Exception as e:
    print("Error ", e)

while not(frase == 'fin'):
    archivo.write(frase + "\n")
    frase = input("Ingrese una frase ")

archivo.close()

#Apertura del  archivo 

try:
    archivo = open("archivos/frases.txt", "r")        
except FileNotFoundError:
    print("Error el archivo no existe")

lineas = archivo.read()
    
print(lineas)

archivo.close()