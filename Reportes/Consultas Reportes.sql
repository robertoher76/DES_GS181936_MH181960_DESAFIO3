--Implementar SQL Server Reporting Services (SSRS) para generar reportes sobre los datos de equipos y proyectos: 

--    Reporte 1: Lista de todos los equipos y proyectos asociados, filtrados por fecha de inicio. 
  
--    Reporte 2: Estado de tareas por proyecto, mostrando cu�ntas tareas est�n en cada estado.

USE ProyectosBDD
GO

--Reporte 1

SELECT
*
FROM Proyectos

SELECT
pr.Nombre as 'Proyecto',
eq.Nombre as 'Equipo'
FROM 
Proyectos pr
Inner Join Equipos eq on eq.Id = pr.EquipoId
WHERE DATEDIFF(DAY, pr.FechaDeInicio, '2024-01-15') = 0
GO

--Reporte 2
SELECT 
ta.Descripcion as 'Tarea',
pr.Nombre as 'Proyecto',
eq.Nombre as 'Equipo',
pr.FechaDeFin as 'Fin',
pr.FechaDeInicio as 'Inicio',
et.Nombre as 'Estado'
FROM 
Tareas ta 
Inner Join Proyectos pr on pr.Id = ta.ProyectoId
Inner Join Equipos eq on eq.Id = pr.EquipoId
Inner Join EstadoTareas et on et.Id = ta.EstadoId
ORDER BY et.Id
GO