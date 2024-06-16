USE alquileres_canchas;

-- Como dueño puedo crear nuevas Predios
INSERT INTO Predios (
	id_predio,
	nombre,
	ubicacion,
	telefono,
	instagram,
	horario_apertura,
	horario_cierre,
	id_ciudad
	) 
VALUES (
	12,
	'Central Cordoba',
	'Granadero Saavedra 260',
	'385-2222-3333',
	'@central_cordoba',
	'08:00:00',
	'21:00:00',
	1
	);
	
-- Como dueño puedo crear canchas
INSERT INTO Canchas
	(id_cancha, nombre, sub_nombre, id_predio)
VALUES
    (100,'Cancha 1', 'Principal', 12),
    (101,'Cancha 2', 'Auxiliar', 12),
    (102,'Cancha 3', 'Entrenamiento', 12);
    
-- Como dueño puedo crear turnos para siertas canchas
INSERT INTO Turnos 
	(id_turno, fecha, hora, id_cancha)
VALUES 	
	(200, '2024-10-7', "08:00:00", 100),
	(201, '2024-10-7', "09:00:00", 101),
	(202, '2024-10-7', "08:00:00", 102);
    
	
-- Como dueño puedo colocarle una actividad disponible dentro de la cancha
INSERT INTO Actividades_canchas (
	id_cancha,
	id_actividad)
VALUES
	(100,1),
	(101,2),
	(102,3);


#CONSULTAS

-- Como dueño quiero ver todas las reservas que tengo hechas

-- Consulta general

SELECT t.id_turno, t.dni, t.hora , c.nombre, c.sub_nombre  FROM Turnos t 
JOIN 
	Canchas c ON t.id_cancha = c.id_cancha 
JOIN 
	Predios p ON c.id_predio = p.id_predio 
WHERE 
	(t.dni IS NOT NULL OR t.dni != '') AND p.id_predio = <ID_DEL_PREDIO>;

#Donde ID_DEL_PREDIO es el identificador del predio para el cual queremos conocer las reservas.

#Ejemplo práctico, dueño de predio de id = 1

SELECT t.id_turno, t.dni, t.hora , c.nombre, c.sub_nombre  FROM Turnos t 
JOIN 
	Canchas c ON t.id_cancha = c.id_cancha 
JOIN 
	Predios p ON c.id_predio = p.id_predio 
WHERE 
	(t.dni IS NOT NULL OR t.dni != '') AND p.id_predio = 1;


-- Como dueño quiero ver todos los turnos disponibles

-- Consulta general

SELECT t.id_turno, t.dni, t.hora , c.nombre, c.sub_nombre  FROM Turnos t 
JOIN 
	Canchas c ON t.id_cancha = c.id_cancha 
JOIN 
	Predios p ON c.id_predio = p.id_predio 
WHERE 
	(t.dni IS NULL OR t.dni = '') AND p.id_predio = <ID_DEL_PREDIO>;

-- Consulta particular, dueño de predio de id = 12

SELECT t.id_turno, t.dni, t.hora , c.nombre, c.sub_nombre  FROM Turnos t 
JOIN 
	Canchas c ON t.id_cancha = c.id_cancha 
JOIN 
	Predios p ON c.id_predio = p.id_predio 
WHERE 
	(t.dni IS NULL OR t.dni = '') AND p.id_predio = 12;
    
    
-- Como cliente puedo ver el listado de turnos disponibles, los turnos tienen información de la cancha y el predio
SELECT
    t.fecha, 
    t.hora,
    c2.provincia,
    c2.ciudad,
    p.nombre AS Predio, 
    c.nombre AS Cancha, 
    GROUP_CONCAT(a.nombre SEPARATOR ', ') AS Actividades
FROM
    Turnos t
JOIN 
    Canchas c ON t.id_cancha = c.id_cancha
INNER JOIN 
    Actividades_canchas r ON c.id_cancha = r.id_cancha
JOIN 
    Predios p ON c.id_predio = p.id_predio
JOIN 
    Actividades a ON r.id_actividad = a.id_actividad
JOIN 
	Ciudades c2 ON p.id_ciudad = c2.id_ciudad 
WHERE 
    t.dni IS NULL OR t.dni = ""
GROUP BY 
    t.fecha, 
    t.hora, 
    p.nombre,
    c2.provincia,
    c2.ciudad,
    c.nombre;
    
-- Como cliente quiero filtrar los turnos por actividades
SELECT
    t.fecha, 
    t.hora, 
    p.nombre AS Predio, 
    c.nombre AS Cancha, 
    GROUP_CONCAT(a.nombre SEPARATOR ', ') AS Actividades
FROM 
    Turnos t
JOIN 
    Canchas c ON t.id_cancha = c.id_cancha
INNER JOIN 
    Actividades_canchas r ON c.id_cancha = r.id_cancha
JOIN 
    Predios p ON c.id_predio = p.id_predio
JOIN 
    Actividades a ON r.id_actividad = a.id_actividad
JOIN 
	Ciudades c2 ON p.id_ciudad = c2.id_ciudad 
JOIN
	Turnos t ON c.id_cancha = t.id_cancha 
WHERE 
    (t.dni IS NULL OR t.dni = "") AND a.id_actividad = <ID_DE_LA_ACTIVIDAD>
GROUP BY 
    t.fecha, 
    t.hora, 
    p.nombre,
    c2.provincia,
    c2.ciudad,
    c.nombre;
    
-- Como cliente quiero filtrar las canchas que se encuentran disponibles en un municipio
SELECT
    t.fecha, 
    t.hora, 
    p.nombre AS Predio, 
    c.nombre AS Cancha, 
    GROUP_CONCAT(a.nombre SEPARATOR ', ') AS Actividades
FROM 
    Canchas c 
INNER JOIN 
    Actividades_canchas r ON c.id_cancha = r.id_cancha
JOIN 
    Predios p ON c.id_predio = p.id_predio
JOIN 
    Actividades a ON r.id_actividad = a.id_actividad
JOIN
	Ciudades c2 ON p.id_ciudad = c2.id_ciudad 
JOIN
	Turnos t ON c.id_cancha = t.id_cancha 
WHERE 
    (t.dni IS NULL OR t.dni = "") AND c2.id_ciudad = <ID_DE_LA_CIUDAD>
GROUP BY 
    t.fecha, 
    t.hora, 
    p.nombre,
    c2.provincia,
    c2.ciudad,
    c.nombre;
    
-- Como cliente puedo saber donde queda la cancha y a que predio pertenece
SELECT 
	p.nombre AS Predio,
	c.nombre AS Cancha,
	c.sub_nombre AS Alias,
	c2.provincia AS Provincia,
	c2.ciudad AS Ciudades
FROM Canchas c 
	JOIN Predios p ON c.id_predio = p.id_predio
	JOIN Ciudades c2 ON p.id_ciudad = c2.id_ciudad;
    

-- Interesa conocer cuantos turnos fueron reservados en un lapso determinado de tiempo.

SELECT COUNT(*) FROM turnos WHERE fecha BETWEEN {FECHA_INICIO} AND {FECHA_FIN};

-- Interesa conocer cuáles son las canchas mas utilizadas a fin de mes para así revisar si requiere realizarle mantenimiento,
-- de manera que podemos obtener el ranking de canchas, segun turnos sacados en los ultimos 30 dias.

SELECT 
    COUNT(*) AS total_turnos,
    c.nombre,
    c.sub_nombre
FROM 
    turnos t
    JOIN canchas c ON t.id_cancha = c.id_cancha
WHERE 
    t.fecha >= DATE_SUB(CURRENT_DATE(), INTERVAL 30 DAY)
    AND t.fecha <= CURRENT_DATE()
    AND (t.dni IS NOT NULL AND t.dni != "")
    AND c.id_predio = {ID_PREDIO}
GROUP BY 
    c.id_cancha
ORDER BY 
    total_turnos DESC;


-- Interesa conocer cuál es el predio que esta danto mas turnos y usando menos las canchas, para así poder ocupar esas canchas posiblemente derivando personas de un predio a otro.
-- Vamos a querer tener por cada cancha el procentaje de turnos que se sacaron, es decir de todos los turnos que tenia cada cancha cuantos turnos se efectivizaron   
-- Y tambien las actividades que se realizan en las canchas, para ver si podemos realizar una mejor redistribucion de las mismas

SELECT 
    c.id_cancha, 
    c.nombre, 
    a.nombre AS actividades_realizables, 
    COUNT(*) / (
        SELECT COUNT(*)
        FROM turnos t
        JOIN canchas c ON t.id_cancha = c.id_cancha
        JOIN predios p ON c.id_predio = p.id_predio
        WHERE t.dni IS NOT NULL AND t.dni != ""
        AND p.id_predio = {ID_PREDIO}
    ) AS coeficiente_turnos_cancha
FROM 
    canchas c
JOIN turnos t ON c.id_cancha = t.id_cancha
JOIN predios p ON c.id_predio = p.id_predio
JOIN actividades_canchas ac ON c.id_cancha = ac.id_cancha
JOIN actividades a ON a.id_actividad = ac.id_actividad
WHERE 
    p.id_predio = {ID_PREDIO}
GROUP BY 
    c.id_cancha, 
    c.nombre, 
    a.nombre
ORDER BY 
    coeficiente_turnos_cancha DESC;


-- Quiero conocer el rango en el que se solicitan más turnos generalmente, para eso mostramos el ranking.

SELECT  
    COUNT(*) AS total_turnos,
	t.hora 
	FROM 
    turnos t
    JOIN canchas c ON t.id_cancha = c.id_cancha

WHERE 
    (t.dni IS NOT NULL AND t.dni != "")
    AND c.id_predio = {ID_PREDIO}
GROUP BY 
    t.hora
ORDER BY 
    total_turnos DESC;
    
    
    
