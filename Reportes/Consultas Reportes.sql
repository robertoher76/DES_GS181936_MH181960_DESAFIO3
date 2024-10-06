--Implementar SQL Server Reporting Services (SSRS) para generar reportes sobre los datos de equipos y proyectos: 

--    Reporte 1: Lista de todos los equipos y proyectos asociados, filtrados por fecha de inicio. 
  
--    Reporte 2: Estado de tareas por proyecto, mostrando cuántas tareas están en cada estado.

USE ProyectosBDD
GO

--Reporte 1
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
Inner Join EstadoTareas et on et.Id = ta.EstadoTareasId
WHERE @FechaInicio IS NULL OR pr.FechaDeInicio = @FechaInicio
GO
--@FechaInicio
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
Inner Join EstadoTareas et on et.Id = ta.EstadoTareasId
ORDER BY pr.FechaDeInicio
GO