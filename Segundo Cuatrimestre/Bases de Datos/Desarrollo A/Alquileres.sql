#Borramos la base si ya existe
DROP DATABASE IF EXISTS alquileres_canchas;

#La creamos nuevamente
CREATE DATABASE alquileres_canchas;

#La seleccionamos

USE alquileres_canchas;

#Definicion de tablas

-- Tabla Ciudades
CREATE TABLE Ciudades (
    id_ciudad INT PRIMARY KEY AUTO_INCREMENT,
    provincia VARCHAR(255),
    ciudad VARCHAR(255)
);

-- Tabla Predios
CREATE TABLE Predios (
    id_predio INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255),
    ubicacion VARCHAR(255),
    telefono VARCHAR(20),
    instagram VARCHAR(255),
    horario_apertura TIME,
    horario_cierre TIME,
    id_ciudad INT
);

-- Tabla Tipos
CREATE TABLE Tipos (
    id_tipo INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255)
);

-- Tabla Tipos_predios
CREATE TABLE Tipos_predios (
    id_predio INT,
    id_tipo INT,
    PRIMARY KEY (id_predio, id_tipo)
);

-- Tabla Canchas

CREATE TABLE Canchas (
    id_cancha INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255),
    sub_nombre VARCHAR(255),
    id_predio INT
);

-- Tabla Actividades
CREATE TABLE Actividades (
    id_actividad INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255)
);

-- Tabla  (Actividades_Canchas)
CREATE TABLE Actividades_canchas (
    id_cancha INT,
    id_actividad INT,
    PRIMARY KEY (id_cancha, id_actividad)
);


-- Tabla Turnos
CREATE TABLE Turnos (
    id_turno INT PRIMARY KEY AUTO_INCREMENT,
    dni VARCHAR(20),
    fecha DATE,
    hora TIME,
    id_cancha INT
);


#Relaciones

#En una ciudad puede haber localizados multiples predios
ALTER TABLE Predios
ADD CONSTRAINT fk_predios_ciudades
FOREIGN KEY (id_ciudad) REFERENCES Ciudades(id_ciudad);

#Un predio puede tener muchos tipos
ALTER TABLE Tipos_predios
ADD CONSTRAINT fk_tipos_predios_predios
FOREIGN KEY (id_predio) REFERENCES Predios(id_predio);

#Un tipo puede tener muchos predios
ALTER TABLE Tipos_predios
ADD CONSTRAINT fk_tipos_predios_tipos
FOREIGN KEY (id_tipo) REFERENCES Tipos(id_tipo);

#Un predio tiene muchas canchas
ALTER TABLE Canchas
ADD CONSTRAINT fk_canchas_predios
FOREIGN KEY (id_predio) REFERENCES Predios(id_predio);

#En una cancha se pueden realizar muchas actividades 
ALTER TABLE Actividades_canchas
ADD CONSTRAINT fk_actividades_canchas_canchas
FOREIGN KEY (id_cancha) REFERENCES Canchas(id_cancha);

#Una actividad puede ser realizada en multiples canchas
ALTER TABLE Actividades_canchas
ADD CONSTRAINT fk_actividades_canchas_actividades
FOREIGN KEY (id_actividad) REFERENCES Actividades(id_actividad);

#Una cancha puede dar muchos turnos
ALTER TABLE Turnos
ADD CONSTRAINT fk_turnos_canchas
FOREIGN KEY (id_cancha) REFERENCES Canchas(id_cancha);