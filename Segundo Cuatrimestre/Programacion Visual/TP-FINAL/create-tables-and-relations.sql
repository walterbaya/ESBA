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
	pregunta VARCHAR(150) NOT NULL,
	dificultad_pregunta INT NOT NULL
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


#Inserciones

-- Preguntas de dificultad 0
INSERT INTO preguntas (id_pregunta, pregunta, dificultad_pregunta) VALUES
(1, '¿Cuál es la capital de Francia?', 0),
(2, '¿En qué continente se encuentra Egipto?', 0),
(3, '¿Cuál es el océano más grande del mundo?', 0),
(4, '¿Cuál es la montaña más alta de América del Norte?', 0),
(5, '¿En qué país se encuentra la Gran Muralla China?', 0),
(6, '¿Cuál es la moneda oficial de Japón?', 0),
(7, '¿Qué país europeo es conocido por sus canales y bicicletas?', 0),
(8, '¿Cuál es el animal terrestre más grande del mundo?', 0),
(9, '¿Qué país es conocido como "el país de las mil islas"?', 0),
(10, '¿En qué ciudad se encuentra la famosa ópera de Sidney?', 0);

-- Opciones para las preguntas de dificultad 0
-- Pregunta 1
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(1, 1, 'París'),
(2, 1, 'Londres'),
(3, 1, 'Madrid'),
(4, 1, 'Roma');

-- Pregunta 2
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(5, 2, 'África'),
(6, 2, 'Asia'),
(7, 2, 'Europa'),
(8, 2, 'Oceanía');

-- Pregunta 3
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(9, 3, 'Océano Atlántico'),
(10, 3, 'Océano Pacífico'),
(11, 3, 'Océano Índico'),
(12, 3, 'Océano Ártico');

-- Pregunta 4
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(13, 4, 'Monte McKinley'),
(14, 4, 'Monte Everest'),
(15, 4, 'Monte Kilimanjaro'),
(16, 4, 'Monte Aconcagua');

-- Pregunta 5
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(17, 5, 'China'),
(18, 5, 'Japón'),
(19, 5, 'Corea del Sur'),
(20, 5, 'India');

-- Pregunta 6
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(21, 6, 'Dólar'),
(22, 6, 'Yen'),
(23, 6, 'Euro'),
(24, 6, 'Libra esterlina');

-- Pregunta 7
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(25, 7, 'Países Bajos'),
(26, 7, 'Suecia'),
(27, 7, 'Suiza'),
(28, 7, 'Bélgica');

-- Pregunta 8
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(29, 8, 'Elefante africano'),
(30, 8, 'Ballena azul'),
(31, 8, 'Jirafa'),
(32, 8, 'Oso polar');

-- Pregunta 9
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(33, 9, 'Suecia'),
(34, 9, 'Filipinas'),
(35, 9, 'Indonesia'),
(36, 9, 'Japón');

-- Pregunta 10
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(37, 10, 'Melbourne'),
(38, 10, 'Nueva York'),
(39, 10, 'Tokio'),
(40, 10, 'Sídney');

-- Respuestas correctas para las preguntas de dificultad 0
INSERT INTO respuestas (id_pregunta, respuesta) VALUES
(1, 'París'),
(2, 'África'),
(3, 'Océano Pacífico'),
(4, 'Monte McKinley'),
(5, 'China'),
(6, 'Yen'),
(7, 'Países Bajos'),
(8, 'Ballena azul'),
(9, 'Suecia'),
(10, 'Sídney');

-- Preguntas de dificultad 1
INSERT INTO preguntas (id_pregunta, pregunta, dificultad_pregunta) VALUES
(11, '¿Cuál fue el año de inicio de la Primera Guerra Mundial?', 1),
(12, '¿En qué año comenzó la Revolución Rusa?', 1),
(13, '¿Quién escribió la Ilíada y la Odisea?', 1),
(14, '¿Cuál es el río más largo de Europa?', 1),
(15, '¿En qué año cayó el Muro de Berlín?', 1),
(16, '¿Quién fue el primer emperador de Japón según la leyenda?', 1),
(17, '¿Cuál es el elemento químico más ligero?', 1),
(18, '¿Quién desarrolló la teoría de los arquetipos en psicología?', 1),
(19, '¿En qué país se encuentra el Taj Mahal?', 1),
(20, '¿Quién escribió "El Quijote"?', 1);

-- Opciones para las preguntas de dificultad 1
-- Pregunta 11
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(41, 11, '1914'),
(42, 11, '1918'),
(43, 11, '1939'),
(44, 11, '1945');

-- Pregunta 12
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(45, 12, '1917'),
(46, 12, '1923'),
(47, 12, '1932'),
(48, 12, '1945');

-- Pregunta 13
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(49, 13, 'Homero'),
(50, 13, 'Sófocles'),
(51, 13, 'Platón'),
(52, 13, 'Aristóteles');

-- Pregunta 14
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(53, 14, 'Río Volga'),
(54, 14, 'Río Danubio'),
(55, 14, 'Río Rin'),
(56, 14, 'Río Támesis');

-- Pregunta 15
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(57, 15, '1989'),
(58, 15, '1991'),
(59, 15, '1993'),
(60, 15, '1995');

-- Pregunta 16
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(61, 16, 'Jimmu'),
(62, 16, 'Meiji'),
(63, 16, 'Hirohito'),
(64, 16, 'Akihito');

-- Pregunta 17
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(65, 17, 'Hidrógeno'),
(66, 17, 'Oxígeno'),
(67, 17, 'Helio'),
(68, 17, 'Rodio');

-- Pregunta 18
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(69, 18, 'Carl Gustav Jung'),
(70, 18, 'Sigmund Freud'),
(71, 18, 'Erich Fromm'),
(72, 18, 'Alfred Adler');

-- Pregunta 19
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(73, 19, 'India'),
(74, 19, 'Bangladesh'),
(75, 19, 'Pakistán'),
(76, 19, 'Nepal');

-- Pregunta 20
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(77, 20, 'Miguel de Cervantes'),
(78, 20, 'William Shakespeare'),
(79, 20, 'Dante Alighieri'),
(80, 20, 'Homero');

-- Respuestas correctas para las preguntas de dificultad 1
INSERT INTO respuestas (id_pregunta, respuesta) VALUES
(11, '1914'),
(12, '1917'),
(13, 'Homero'),
(14, 'Río Volga'),
(15, '1989'),
(16, 'Jimmu'),
(17, 'Hidrógeno'),
(18, 'Carl Gustav Jung'),
(19, 'India'),
(20, 'Miguel de Cervantes');

-- Preguntas de dificultad 2
INSERT INTO preguntas (id_pregunta, pregunta, dificultad_pregunta) VALUES
(21, '¿Cuál es el río más largo del mundo?', 2),
(22, '¿Quién fue el líder de la Revolución Rusa?', 2),
(23, '¿En qué desierto se encuentra el Valle de la Muerte?', 2),
(24, '¿En qué ciudad se encuentra la Torre Eiffel?', 2),
(25, '¿Cuál es el idioma más hablado del mundo?', 2),
(26, '¿Quién pintó "La noche estrellada"?', 2),
(27, '¿Cuál es el país con más islas en el mundo?', 2),
(28, '¿Quién fue el primer humano en orbitar la Tierra?', 2),
(29, '¿En qué país se encuentra el lago Baikal?', 2),
(30, '¿Cuál es la montaña más alta del mundo?', 2);

-- Opciones para las preguntas de dificultad 2
-- Pregunta 21
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(81, 21, 'Río Amazonas'),
(82, 21, 'Río Nilo'),
(83, 21, 'Río Yangtsé'),
(84, 21, 'Río Mississippi');

-- Pregunta 22
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(85, 22, 'Vladímir Lenin'),
(86, 22, 'León Trotsky'),
(87, 22, 'Iósif Stalin'),
(88, 22, 'Mijaíl Gorbachov');

-- Pregunta 23
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(89, 23, 'Desierto del Sahara'),
(90, 23, 'Desierto de Kalahari'),
(91, 23, 'Desierto de Gobi'),
(92, 23, 'Desierto de Atacama');

-- Pregunta 24
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(93, 24, 'París'),
(94, 24, 'Londres'),
(95, 24, 'Roma'),
(96, 24, 'Berlín');

-- Pregunta 25
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(97, 25, 'Chino mandarín'),
(98, 25, 'Español'),
(99, 25, 'Inglés'),
(100, 25, 'Hindi');

-- Pregunta 26
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(101, 26, 'Vincent van Gogh'),
(102, 26, 'Pablo Picasso'),
(103, 26, 'Claude Monet'),
(104, 26, 'Leonardo da Vinci');

-- Pregunta 27
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(105, 27, 'Suecia'),
(106, 27, 'Filipinas'),
(107, 27, 'Indonesia'),
(108, 27, 'Japón');

-- Pregunta 28
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(109, 28, 'Yuri Gagarin'),
(110, 28, 'Neil Armstrong'),
(111, 28, 'Buzz Aldrin'),
(112, 28, 'Alan Shepard');

-- Pregunta 29
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(113, 29, 'Rusia'),
(114, 29, 'Ucrania'),
(115, 29, 'Bielorrusia'),
(116, 29, 'Estonia');

-- Pregunta 30
INSERT INTO opciones (id_opcion, id_pregunta, opcion) VALUES
(117, 30, 'Monte Everest'),
(118, 30, 'Monte Kilimanjaro'),
(119, 30, 'Monte Aconcagua'),
(120, 30, 'Monte McKinley');

-- Respuestas correctas para las preguntas de dificultad 2
INSERT INTO respuestas (id_pregunta, respuesta) VALUES
(21, 'Río Amazonas'),
(22, 'Vladímir Lenin'),
(23, 'Desierto del Sahara'),
(24, 'París'),
(25, 'Chino mandarín'),
(26, 'Vincent van Gogh'),
(27, 'Suecia'),
(28, 'Yuri Gagarin'),
(29, 'Rusia'),
(30, 'Monte Everest');

-- Establecemos un tiempo limite de 5 segundos

INSERT INTO propiedades_juego (tiempo_limite) VALUES (5);