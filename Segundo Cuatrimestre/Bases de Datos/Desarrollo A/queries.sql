USE alquileres_canchas;
-- Como cliente puedo ver el listado de turnos disponibles, los turnos tienen información de la cancha y el predio

SELECT
    t.fecha, 
    t.hora, 
    p.nombre AS Predio, 
    c.nombre AS Cancha, 
    GROUP_CONCAT(a.nombre SEPARATOR ', ') AS Actividades
FROM 
    Turnos_canchas d 
JOIN 
    Turnos t ON d.id_turno = t.id_turno
JOIN 
    Canchas c ON d.id_cancha = c.id_cancha
INNER JOIN 
    Actividades_canchas r ON c.id_cancha = r.id_cancha
JOIN 
    Predios p ON c.id_predio = p.id_predio
JOIN 
    Actividades a ON r.id_actividad = a.id_actividad
WHERE 
    t.dni IS NULL OR t.dni = ""
GROUP BY 
    t.fecha, 
    t.hora, 
    p.nombre, 
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
