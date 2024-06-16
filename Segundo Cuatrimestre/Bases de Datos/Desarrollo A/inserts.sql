USE alquileres_canchas;
-- Inserción de datos en la tabla Ciudades
INSERT INTO Ciudades (provincia, ciudad) VALUES 
('Buenos Aires', 'La Plata'),
('Córdoba', 'Córdoba'),
('Santa Fe', 'Rosario');

-- Inserción de datos en la tabla Tipos (Tipos de Predio)
INSERT INTO Tipos (nombre) VALUES 
('Club'),
('Cancha'),
('Polideportivo'),
('Box'),
('Pista de Patinaje'),
('Pista de Motocicletas');

-- Inserción de datos en la tabla Predios
INSERT INTO Predios (nombre, ubicacion, telefono, instagram, horario_apertura, horario_cierre, id_ciudad) VALUES 
('Club Deportivo La Plata', 'Calle 123', '123456789', '@clubdeportivo', '08:00:00', '22:00:00', 1),
('Cancha de Fútbol Córdoba', 'Avenida Siempre Viva 742', '987654321', '@canchafutbol', '09:00:00', '21:00:00', 2),
('Polideportivo Rosario', 'Boulevard Oroño 123', '456789123', '@polideportivo', '10:00:00', '20:00:00', 3),
('Box de Entrenamiento', 'Calle Falsa 123', '789456123', '@boxentrenamiento', '06:00:00', '22:00:00', 1),
('Pista de Patinaje La Plata', 'Avenida del Libertador 456', '321654987', '@pistapatinaje', '10:00:00', '18:00:00', 1),
('Pista de Motocicletas Rosario', 'Camino de los Remedios 789', '654987321', '@pistamotocicletas', '08:00:00', '20:00:00', 3);

-- Inserción de datos en la tabla Clasificacion
INSERT INTO Tipos_predios (id_predio, id_tipo) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6);

-- Inserción de datos en la tabla Canchas
INSERT INTO Canchas (nombre, sub_nombre, id_predio) VALUES 
('Cancha 1', 'Fútbol 11', 2),
('Cancha 2', 'Básquet', 3),
('Cancha 3', 'Vóley', 3),
('Cancha 4', 'Tenis', 1),
('Cancha 5', 'Boxeo', 4),
('Cancha 6', 'Patinaje', 5),
('Cancha 7', 'Motocross', 6);

-- Inserción de datos en la tabla Actividades (Tipos de Deporte)
INSERT INTO Actividades (nombre) VALUES 
('Fútbol'),
('Básquet'),
('Vóley'),
('Tenis'),
('Boxeo'),
('Patinaje'),
('Motocross');

-- Inserción de datos en la tabla Realizacion (Canchas y Actividades)
INSERT INTO Actividades_canchas (id_cancha, id_actividad) VALUES 
(1, 1), -- Cancha de Fútbol 11 realiza Fútbol
(2, 2), -- Cancha de Básquet realiza Básquet
(3, 3), -- Cancha de Vóley realiza Vóley
(4, 4), -- Cancha de Tenis realiza Tenis
(5, 5), -- Cancha de Boxeo realiza Boxeo
(6, 6), -- Pista de Patinaje realiza Patinaje
(7, 7), -- Pista de Motocross realiza Motocross
(4, 7),
(2, 5),
(6, 3)
;
-- Inserción de datos en la tabla Turnos
INSERT INTO Turnos (dni, fecha, hora, id_cancha) VALUES 
('12345678', '2024-06-10', '15:00:00', 1),
('12345678', '2024-06-10', '16:00:00', 1),
('12345678', '2024-06-10', '17:00:00', 1),
('87654321', '2024-06-11', '16:00:00', 2),
('87654321', '2024-06-11', '18:00:00', 2),
('45678912', '2024-06-12', '17:00:00', 3),
('23456789', '2024-06-13', '18:00:00', 4),
('34567890', '2024-06-14', '19:00:00', 5),
('98765432', '2024-06-15', '20:00:00', 6),
('87654320', '2024-06-16', '21:00:00', 7);

INSERT INTO Turnos (dni, fecha, hora, id_cancha) VALUES
("", '2024-06-10', '18:00:00', 1),
("", '2024-06-10', '19:00:00', 1),
("", '2024-06-10', '20:00:00', 1);