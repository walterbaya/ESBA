DROP DATABASE IF EXISTS kajut;
CREATE DATABASE kajut;
USE kajut;

CREATE TABLE jugadores(
    id_jugador INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	nombre VARCHAR(60),
    contraseña VARCHAR(60) NOT NULL,
	puntaje INT NOT NULL
);

#Son de solo lectura porque el usuario del juego no las carga, sino que deben ser cargadas manualmente 
#por el administrador del juego

CREATE TABLE preguntas(
	id_pregunta INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	pregunta VARCHAR(150) NOT NULL
);

CREATE TABLE respuestas(
	id_respuesta INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_pregunta INT NOT NULL,
	respuesta VARCHAR(150) NOT NULL
);

CREATE TABLE opciones(
	id_opcion INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_pregunta INT NOT NULL,
    opcion VARCHAR(150) NOT NULL
);

CREATE TABLE propiedades_juego(
	id_propiedad_juego INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	tiempo_limite INT NOT NULL
);

ALTER TABLE opciones ADD CONSTRAINT fk_opcion FOREIGN KEY (id_pregunta) REFERENCES preguntas(id_pregunta);

ALTER TABLE respuestas ADD CONSTRAINT fk_pregunta FOREIGN KEY (id_pregunta) REFERENCES preguntas(id_pregunta);



