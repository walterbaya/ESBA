DROP DATABASE IF EXISTS sistema_alquileres;
CREATE DATABASE sistema_alquileres; 
USE sistema_alquileres; 

#Crear Tabla predio

CREATE TABLE predios (
					 #Parece recomendable usar un identificador para cada uno.
                     id_predio INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
					 nombre VARCHAR(100), 
					
                    #Redes sociales
                    red_instagram VARCHAR(100), 
                    red_facebook VARCHAR(100), 
                    red_whatsapp VARCHAR(100), 
                    red_tik_tok VARCHAR(100),
                    
                    #Horario
					horario_apertura TIME NOT NULL, 
                    horario_cierre TIME NOT NULL,
                    
                    #Ubicacion
                    ubic_localidad VARCHAR(100), 
					ubic_codigo_postal INT NOT NULL, 
					ubic_provincia ENUM('BA','CT','CH', 'CB', 'CD', 'CR', 'ER', 'FO', 'JU', 'LP', 'LR', 'MZ', 'MI', 'NQ', 'RN', 'SA', 'SJ', 'SL', 'SC', 'SF', 'SE', 'TF', 'TU' ) NOT NULL
);

#Se crea tabla cancha
#No tiene clave primaria, es débil, pero tiene una compuesta
CREATE TABLE canchas(
	id_cancha INT NOT NULL, 
	id_predio INT NOT NULL,
    capacidad INT NOT NULL,
    PRIMARY KEY(id_predio, id_cancha)
);

#Se crea tabla actividad
CREATE TABLE actividades(
    nombre VARCHAR(100) NOT NULL PRIMARY KEY
);


CREATE TABLE turnos(
    id_turno INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_predio INT NOT NULL,
    nombre_actividad VARCHAR(100), 
    id_cancha INT NOT NULL,
	id_cliente INT,  #podría estar null hasta que alguien lo saque.
	hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    fecha DATE NOT NULL
);

CREATE TABLE clientes(
	nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    dni INT NOT NULL PRIMARY KEY,
    dir_localidad VARCHAR(100) NOT NULL,
    dir_codigo_postal INT NOT NULL,
    dir_provincia ENUM('BA','CT','CH', 'CB', 'CD', 'CR', 'ER', 'FO', 'JU', 'LP', 'LR', 'MZ', 'MI', 'NQ', 'RN', 'SA', 'SJ', 'SL', 'SC', 'SF', 'SE', 'TF', 'TU' ) NOT NULL
);

#Establecemos los atributos multivalorados


#Creamos la tabla de telefonos

CREATE TABLE telefonos (
    numero VARCHAR(15) NOT NULL PRIMARY KEY,
    dni_cliente INT NOT NULL,
    id_predio INT NOT NULL
);

#Un predio puede tener muchos telefonos

ALTER TABLE telefonos ADD CONSTRAINT fk_predio_id_telefono FOREIGN KEY (id_predio) REFERENCES predios(id_predio); 

#Un cliente puede tener muchos telefonos 

ALTER TABLE telefonos ADD CONSTRAINT fk_cliente_dni_telefono FOREIGN KEY (dni_cliente) REFERENCES clientes(dni); 

#Creo tabla direcciones

CREATE TABLE direcciones (
    localidad VARCHAR(100), 
	codigo_postal INT NOT NULL, 
	provincia ENUM('BA','CT','CH', 'CB', 'CD', 'CR', 'ER', 'FO', 'JU', 'LP', 'LR', 'MZ', 'MI', 'NQ', 'RN', 'SA', 'SJ', 'SL', 'SC', 'SF', 'SE', 'TF', 'TU' ) NOT NULL,
    dni_cliente INT NOT NULL,
    PRIMARY KEY(localidad, codigo_postal, provincia)
);

#Cada cliente puede tener varias direcciones pero a su vez cada direccion puede estar asociada a varios clientes
#Creo tabla intermedia

CREATE TABLE direcciones_clientes(
	dni_cliente INT NOT NULL,
	localidad VARCHAR(100), 
	codigo_postal INT NOT NULL, 
	provincia ENUM('BA','CT','CH', 'CB', 'CD', 'CR', 'ER', 'FO', 'JU', 'LP', 'LR', 'MZ', 'MI', 'NQ', 'RN', 'SA', 'SJ', 'SL', 'SC', 'SF', 'SE', 'TF', 'TU' ) NOT NULL,
    FOREIGN KEY (dni_cliente) REFERENCES clientes(dni),
	FOREIGN KEY (localidad, codigo_postal, provincia) REFERENCES direcciones (localidad, codigo_postal, provincia)
);



#Establecemos las relaciones

#Relación un predio tiene mucha canchas

ALTER TABLE canchas ADD CONSTRAINT fk_id_predio FOREIGN KEY (id_predio) REFERENCES predios(id_predio);

#Relación una cancha puede tener varios turnos 

ALTER TABLE turnos ADD CONSTRAINT fk_id_cancha FOREIGN KEY (id_predio, id_cancha) REFERENCES canchas(id_predio, id_cancha);

#Relación un cliente puede sacar muchos turnos y un turno puede ser para varios clientes

CREATE TABLE clientes_turnos (
    dni INT,
    id_turno INT,
    PRIMARY KEY (dni, id_turno),
    CONSTRAINT fk_cliente_dni FOREIGN KEY (dni) REFERENCES clientes(dni),
    CONSTRAINT fk_turno FOREIGN KEY (id_turno) REFERENCES turnos(id_turno)
);

#Relación en cada cancha se pueden realizar multiples actividades y cada actividad se puede realizar en multiples canchas.

CREATE TABLE canchas_actividades (
    id_cancha INT,
    id_predio INT,
    nombre_actividad VARCHAR(100),
    PRIMARY KEY (id_cancha, nombre_actividad),
    CONSTRAINT fk_cancha FOREIGN KEY (id_predio, id_cancha) REFERENCES canchas(id_predio ,id_cancha),
    CONSTRAINT fk_actividad FOREIGN KEY (nombre_actividad) REFERENCES actividades(nombre)
);








