using Microsoft.EntityFrameworkCore;

namespace ProyectosAPI.Models
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Siembra de datos para la tabla Equipos

            modelBuilder.Entity<Equipo>().HasData(
                new Equipo
                {
                    Id = 1,
                    Nombre = "Desarrollo",
                    Descripcion = "Equipo encargado de la programación y desarrollo de software."
                },
                new Equipo
                {
                    Id = 2,
                    Nombre = "Diseño",
                    Descripcion = "Equipo encargado del diseño gráfico y experiencia de usuario."
                },
                new Equipo
                {
                    Id = 3,
                    Nombre = "Operaciones",
                    Descripcion = "Equipo encargado de la infraestructura y soporte operativo."
                }
            );

            // Siembra de datos para la tabla Proyectos

            //PROYECTOS PARA LOS DESARROLLADORES

            modelBuilder.Entity<Proyecto>().HasData(
                new Proyecto
                {
                    Id = 1,
                    Nombre = "Plataforma Interna",
                    FechaDeInicio = new DateOnly(2024, 1, 15),
                    FechaDeFin = new DateOnly(2024, 5, 30),
                    EquipoId = 1
                },
                new Proyecto
                {
                    Id = 2,
                    Nombre = "Sistema de Automatización",
                    FechaDeInicio = new DateOnly(2024, 3, 1),
                    FechaDeFin = new DateOnly(2024, 8, 15),
                    EquipoId = 1
                },
                new Proyecto
                {
                    Id = 3,
                    Nombre = "Migración de Plataforma",
                    FechaDeInicio = new DateOnly(2024, 2, 10),
                    FechaDeFin = new DateOnly(2024, 7, 10),
                    EquipoId = 1
                },
                new Proyecto
                {
                    Id = 4,
                    Nombre = "Migración de Plataforma",
                    FechaDeInicio = new DateOnly(2024, 2, 10),
                    FechaDeFin = new DateOnly(2024, 7, 10),
                    EquipoId = 1
                }
            );

            //PROYECTOS PARA LOS DISEÑADORS

            modelBuilder.Entity<Proyecto>().HasData(
                new Proyecto
                {
                    Id = 5,
                    Nombre = "Rediseño Web Corporativo",
                    FechaDeInicio = new DateOnly(2024, 4, 1),
                    FechaDeFin = new DateOnly(2024, 9, 15),
                    EquipoId = 2
                },
                new Proyecto
                {
                    Id = 6,
                    Nombre = "Identidad Visual Nueva Marca",
                    FechaDeInicio = new DateOnly(2024, 2, 20),
                    FechaDeFin = new DateOnly(2024, 6, 30),
                    EquipoId = 2
                },
                new Proyecto
                {
                    Id = 7,
                    Nombre = "Diseño de Aplicación Móvil",
                    FechaDeInicio = new DateOnly(2024, 3, 5),
                    FechaDeFin = new DateOnly(2024, 8, 20),
                    EquipoId = 2
                }
            );

            //PROYECTOS PARA LAS OPERACIONES

            modelBuilder.Entity<Proyecto>().HasData(
                new Proyecto
                {
                    Id = 8,
                    Nombre = "Optimización de Redes",
                    FechaDeInicio = new DateOnly(2024, 1, 10),
                    FechaDeFin = new DateOnly(2024, 6, 15),
                    EquipoId = 3
                },
                new Proyecto
                {
                    Id = 9,
                    Nombre = "Automatización de Servidores",
                    FechaDeInicio = new DateOnly(2024, 3, 25),
                    FechaDeFin = new DateOnly(2024, 7, 5),
                    EquipoId = 3
                },
                new Proyecto
                {
                    Id = 10,
                    Nombre = "Migración de Datos a Nube",
                    FechaDeInicio = new DateOnly(2024, 2, 15),
                    FechaDeFin = new DateOnly(2024, 7, 1),
                    EquipoId = 3
                }
            );

            // Siembra de datos para la tabla Tareas

            //TAREAS PARA PROYECTO 1

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 1,
                    Descripcion = "Planificación inicial",
                    Estado = 1,
                    ProyectoId = 1,
                    
                },
                new Tarea
                {
                    Id = 2,
                    Descripcion = "Desarrollo de prototipos",
                    Estado = 2,
                    ProyectoId = 1,

                },
                new Tarea
                {
                    Id = 3,
                    Descripcion = "Implementación de módulos",
                    Estado = 1,
                    ProyectoId = 1,
                },
                new Tarea
                {
                    Id = 4,
                    Descripcion = "Pruebas de integración",
                    Estado = 1,
                    ProyectoId = 1,
                },
                new Tarea
                {
                    Id = 5,
                    Descripcion = "Despliegue inicial",
                    Estado = 1,
                    ProyectoId = 1,
                }
            );

            //TAREAS PARA PROYECTO 2

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 6,
                    Descripcion = "Recolección de requerimientos",
                    Estado = 1,
                    ProyectoId = 2,

                },
                new Tarea
                {
                    Id = 7,
                    Descripcion = "Diseño del sistema",
                    Estado = 1,
                    ProyectoId = 2,

                },
                new Tarea
                {
                    Id = 8,
                    Descripcion = "Configuración de servidores",
                    Estado = 2,
                    ProyectoId = 2,
                },
                new Tarea
                {
                    Id = 9,
                    Descripcion = "Pruebas de rendimiento",
                    Estado = 1,
                    ProyectoId = 2,
                },
                new Tarea
                {
                    Id = 10,
                    Descripcion = "Lanzamiento del sistema",
                    Estado = 1,
                    ProyectoId = 2,
                }
            );

            //TAREAS PARA PROYECTO 3

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 11,
                    Descripcion = "Evaluación de la plataforma actual",
                    Estado = 1,
                    ProyectoId = 3,

                },
                new Tarea
                {
                    Id = 12,
                    Descripcion = "Planificación de migración",
                    Estado = 2,
                    ProyectoId = 3,

                },
                new Tarea
                {
                    Id = 13,
                    Descripcion = "Implementación del nuevo sistema",
                    Estado = 1,
                    ProyectoId = 3,
                },
                new Tarea
                {
                    Id = 14,
                    Descripcion = "Transferencia de datos",
                    Estado = 1,
                    ProyectoId = 3,
                },
                new Tarea
                {
                    Id = 15,
                    Descripcion = "Pruebas finales",
                    Estado = 1,
                    ProyectoId = 3,
                }
            );
        }
    }
}
