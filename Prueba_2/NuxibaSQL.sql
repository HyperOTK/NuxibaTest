CREATE DATABASE PRACTICASQL;

USE PRACTICASQL;

CREATE TABLE usuarios(
    userId INT IDENTITY(1,1),
    Login VARCHAR(100) PRIMARY KEY  NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Paterno VARCHAR(100) NOT NULL,
    Materno VARCHAR(100) NOT NULL
);

CREATE TABLE empleados(
    userId INT IDENTITY(1,1),
	Login VARCHAR(100) PRIMARY KEY NOT NULL,
    Sueldo FLOAT NOT NULL,
    FechaIngreso DATE NOT NULL,
    FOREIGN KEY (Login) REFERENCES usuarios(Login)
);

SELECT * FROM usuarios;

SELECT * FROM empleados;

DELETE FROM usuarios WHERE userId NOT IN (6, 7, 9, 10);

UPDATE empleados SET Sueldo = Sueldo * 1.10 WHERE FechaIngreso BETWEEN '2000-01-01' AND '2001-12-31';
SELECT * FROM empleados;

SELECT u.Nombre, e.FechaIngreso FROM usuarios u JOIN empleados e ON u.userId = e.userId
	WHERE e.Sueldo > 10000 	AND u.Paterno LIKE 'T%' ORDER BY e.FechaIngreso DESC;

SELECT 
    CASE 
        WHEN Sueldo < 1200 
			THEN 'Menos de 1200'
				ELSE '1200 o más'
    END AS GrupoSueldo,
    COUNT(*) AS Cantidad
FROM empleados GROUP BY CASE
	WHEN Sueldo < 1200 
		THEN 'Menos de 1200'
			ELSE '1200 o más'
    END;


