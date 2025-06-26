CREATE SCHEMA tech_solutions;

use tech_solutions;

CREATE TABLE `postulaciones` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `educacion` text NOT NULL,
  `experiencia` text NOT NULL,
  `proyectos` text DEFAULT NULL,
  `mensaje` text DEFAULT NULL,
  `cv_nombre` varchar(255) DEFAULT NULL,
  `cv_contenido` longblob DEFAULT NULL,
  `fecha_postulacion` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `email` (`email`),
  KEY `fecha_postulacion` (`fecha_postulacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;