#Es requerido desactivar el modo seguro
SET SQL_SAFE_UPDATES = 0;

#Insertamos 10 predios
USE sistema_alquileres;

INSERT INTO predios (nombre, red_instagram, red_facebook, red_whatsapp, red_tik_tok, horario_apertura, horario_cierre, ubic_localidad, ubic_codigo_postal, ubic_provincia)
VALUES 
('Club Deportivo Los Pinos', 'club_deportivo_lp', 'ClubDeportivoLosPinos', '+5491122334455', 'clubdep_los_pinos', '08:00:00', '22:00:00', 'La Plata', 1900, 'BA'),
('Complejo Deportivo Las Palmeras', 'complejolaspalmeras', 'ComplejoLasPalmeras', '+5491122334456', 'complejolaspalmeras', '09:00:00', '20:00:00', 'Córdoba', 5000, 'CD'),
('Club Atlético del Este', 'atleticoeste', 'ClubAtleticoDelEste', '+5491122334457', 'atletico_este', '10:00:00', '23:00:00', 'San Miguel de Tucumán', 4000, 'TU'),
('Polideportivo La Costa', 'polila_costa', 'PolideportivoLaCosta', '+5491122334458', 'polila_costa', '07:30:00', '21:00:00', 'Mar del Plata', 7600, 'BA'),
('Complejo Deportivo El Arenal', 'elarenal_deportivo', 'ComplejoDeportivoElArenal', '+5491122334459', 'elarenal_deportivo', '08:00:00', '19:30:00', 'Córdoba', 5000, 'CD'),
('Club Social y Deportivo El Sauce', 'el_sauce_lp', 'ClubElSauceLP', '+5491122334460', 'el_sauce_lp', '09:00:00', '22:00:00', 'La Plata', 1900, 'BA'),
('Complejo Deportivo Los Tilos', 'complejo_los_tilos', 'ComplejoDeportivoLosTilos', '+5491122334461', 'complejo_los_tilos', '08:30:00', '20:30:00', 'Buenos Aires', 1600, 'BA'),
('Polideportivo Los Cerezos', 'poli_los_cerezos', 'PolideportivoLosCerezos', '+5491122334462', 'poli_los_cerezos', '10:00:00', '21:30:00', 'Córdoba', 5000, 'CD'),
('Club Deportivo Las Acacias', 'club_deportivo_lasacacias', 'ClubDeportivoLasAcacias', '+5491122334463', 'club_deportivo_lasacacias', '08:00:00', '22:00:00', 'San Miguel de Tucumán', 4000, 'TU'),
('Complejo Deportivo Los Robles', 'complejo_los_robles', 'ComplejoDeportivoLosRobles', '+5491122334464', 'complejo_los_robles', '09:30:00', '21:00:00', 'Rosario', 2000, 'SF');


-- Inserciones para la tabla "canchas"
INSERT INTO canchas (id_cancha, id_predio, capacidad) VALUES 
(1, 1, 50),
(2, 1, 40),
(3, 2, 60),
(4, 3, 30),
(5, 3, 25),
(6, 4, 35),
(7, 5, 45),
(8, 6, 55),
(9, 6, 60),
(10, 7, 40);

-- Inserciones para la tabla "actividades"
INSERT INTO actividades (nombre) VALUES 
('Fútbol'),
('Tenis'),
('Natación'),
('Baloncesto'),
('Voleibol');

-- Inserciones para la tabla "turnos"
INSERT INTO turnos (id_predio, nombre_actividad, id_cancha, id_cliente, hora_inicio, hora_fin, fecha) VALUES 
(1, 'Fútbol', 1, 12345678, '09:00:00', '11:00:00', '2024-06-09'),
(2, 'Tenis', 3, 23456789, '10:00:00', '12:00:00', '2024-06-09'),
(3, 'Natación', 5, 34567890, '12:00:00', '13:00:00', '2024-06-09'),
(5, 'Baloncesto', 7, 45678901, '14:00:00', '16:00:00', '2024-06-09'),
(6, 'Voleibol', 9, NULL, '16:00:00', '18:00:00', '2024-06-09');

-- Inserciones para la tabla "clientes"
INSERT INTO clientes (nombre, apellido, dni, dir_localidad, dir_codigo_postal, dir_provincia) VALUES 
('Juan', 'Pérez', 12345678, 'La Plata', 1900, 'BA'),
('María', 'González', 23456789, 'Córdoba', 5000, 'CD'),
('Carlos', 'Rodríguez', 34567890, 'San Miguel de Tucumán', 4000, 'TU'),
('Laura', 'López', 45678901, 'Mar del Plata', 7600, 'BA');

-- Inserciones para la tabla "telefonos"
INSERT INTO telefonos (numero, dni_cliente, id_predio) VALUES 
('+5491122334455', 12345678, 1),
('+5491122334456', 23456789, 2),
('+5491122334457', 34567890, 3),
('+5491122334458', 45678901, 4);

-- Inserciones para la tabla "direcciones"
INSERT INTO direcciones (localidad, codigo_postal, provincia, dni_cliente) VALUES 
('La Plata', 1900, 'BA', 12345678),
('Córdoba', 5000, 'CD', 23456789),
('San Miguel de Tucumán', 4000, 'TU', 34567890),
('Mar del Plata', 7600, 'BA', 45678901);

-- Inserciones para la tabla "direcciones_clientes"
INSERT INTO direcciones_clientes (dni_cliente, localidad, codigo_postal, provincia) VALUES 
(12345678, 'La Plata', 1900, 'BA'),
(23456789, 'Córdoba', 5000, 'CD'),
(34567890, 'San Miguel de Tucumán', 4000, 'TU'),
(45678901, 'Mar del Plata', 7600, 'BA');

-- Asignar turnos a clientes
INSERT INTO clientes_turnos (dni, id_turno) VALUES 
(12345678, 1),  -- Asignar el turno con ID 1 al cliente con DNI 12345678
(23456789, 2),  -- Asignar el turno con ID 2 al cliente con DNI 23456789
(34567890, 3);  -- Asignar el turno con ID 3 al cliente con DNI 34567890

-- Asignar actividades a canchas
INSERT INTO canchas_actividades (id_cancha, id_predio, nombre_actividad)
VALUES 
(1, 1, 'Fútbol'),       -- Asignar la actividad 'Fútbol' a la cancha con ID 1 y predio con ID 1
(1, 1, 'Baloncesto'),   -- Asignar la actividad 'Baloncesto' a la cancha con ID 1 y predio con ID 1
(2, 1, 'Tenis'),        -- Asignar la actividad 'Tenis' a la cancha con ID 2 y predio con ID 1
(3, 2, 'Natación'),     -- Asignar la actividad 'Natación' a la cancha con ID 3 y predio con ID 2
(4, 3, 'Baloncesto'),   -- Asignar la actividad 'Baloncesto' a la cancha con ID 4 y predio con ID 3
(5, 3, 'Voleibol'),     -- Asignar la actividad 'Voleibol' a la cancha con ID 5 y predio con ID 4
(7, 5, 'Fútbol')       -- Asignar la actividad 'Fútbol' a la cancha con ID 6 y predio con ID 5


