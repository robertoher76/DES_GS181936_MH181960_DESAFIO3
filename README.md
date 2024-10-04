##  Desafio 2 DES 104 GS181936 - MH181960
Una organización está desarrollando un sistema para gestionar equipos, proyectos y tareas asignadas. Se requiere una aplicación que permita gestionar estas entidades, implementando autenticación y autorización con ASP.NET Core Identity. También se debe permitir la generación de reportes utilizando SQL Server Reporting Services (SSRS).

REQUERIMIENTOS

Aplicación API
Crear una API usando .NET Core 8.0 que incluya operaciones CRUD para las siguientes entidades:
• Equipos: ID único, Nombre del equipo (campo obligatorio, longitud mínima de 3 caracteres y máxima de 50), Descripción.
• Proyectos: ID único, Nombre del proyecto (campo obligatorio, longitud mínima de 3 caracteres y máxima de 100), Fecha de inicio, Fecha de fin, Equipo asociado.
• Tareas: ID único, Descripción de la tarea (campo obligatorio, longitud mínima de 5 caracteres), Proyecto asociado, Estado de la tarea (Pendiente, En Progreso, Completada).

Implementar autenticación y autorización usando ASP.NET Core Identity:
• Crear roles para "Administrador" y "Usuario".
• Los usuarios autenticados pueden ver información básica, pero solo los usuarios con rol "Administrador" pueden modificar o eliminar datos.

Utilizar Entity Framework Core para la gestión de datos, incluyendo dataseed para las entidades

Reportes con SSRS
• Implementar SQL Server Reporting Services (SSRS) para generar reportes sobre los datos de equipos y proyectos: 
  o Reporte 1: Lista de todos los equipos y proyectos asociados, filtrados por fecha de inicio. 
  o Reporte 2: Estado de tareas por proyecto, mostrando cuántas tareas están en cada estado.
• Los reportes deben estar accesibles desde la aplicación web mediante el visor de reportes de SSRS.
