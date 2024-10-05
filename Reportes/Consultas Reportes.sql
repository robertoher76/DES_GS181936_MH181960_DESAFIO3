--Implementar SQL Server Reporting Services (SSRS) para generar reportes sobre los datos de equipos y proyectos: 

--    Reporte 1: Lista de todos los equipos y proyectos asociados, filtrados por fecha de inicio. 
  
--    Reporte 2: Estado de tareas por proyecto, mostrando cuántas tareas están en cada estado.

USE ProyectosBDD
GO

SELECT 
ta.Descripcion as 'Tarea',
pr.Nombre as 'Proyecto',
eq.Nombre as 'Equipo',
pr.FechaDeFin as 'Inicio',
pr.FechaDeInicio as 'Fin'
FROM 
Tareas ta 
Inner Join Proyectos pr on pr.Id = ta.ProyectoId
Inner Join Equipos eq on eq.Id = pr.EquipoId
GO