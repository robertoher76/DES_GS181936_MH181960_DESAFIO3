
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectosAPI.Models
{
    public class ProyectoContext : IdentityDbContext<Usuario>
    {
        public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<EstadoTareas> EstadoTareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Siembra de datos para la tabla EstadoTareas

            modelBuilder.Entity<EstadoTareas>().HasData(
                new EstadoTareas
                {
                    Id = 1,
                    Nombre = "Pendiente"
                },
                new EstadoTareas
                {
                    Id = 2,
                    Nombre = "En Progreso"
                },
                new EstadoTareas
                {
                    Id = 3,
                    Nombre = "Completada"
                }
            );

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
                    EstadoId = 1,
                    ProyectoId = 1,
                    
                },
                new Tarea
                {
                    Id = 2,
                    Descripcion = "Desarrollo de prototipos",
                    EstadoId = 2,
                    ProyectoId = 1,

                },
                new Tarea
                {
                    Id = 3,
                    Descripcion = "Implementación de módulos",
                    EstadoId = 1,
                    ProyectoId = 1,
                },
                new Tarea
                {
                    Id = 4,
                    Descripcion = "Pruebas de integración",
                    EstadoId = 1,
                    ProyectoId = 1,
                },
                new Tarea
                {
                    Id = 5,
                    Descripcion = "Despliegue inicial",
                    EstadoId = 1,
                    ProyectoId = 1,
                }
            );

            //TAREAS PARA PROYECTO 2

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 6,
                    Descripcion = "Recolección de requerimientos",
                    EstadoId = 1,
                    ProyectoId = 2,

                },
                new Tarea
                {
                    Id = 7,
                    Descripcion = "Diseño del sistema",
                    EstadoId = 1,
                    ProyectoId = 2,

                },
                new Tarea
                {
                    Id = 8,
                    Descripcion = "Configuración de servidores",
                    EstadoId = 2,
                    ProyectoId = 2,
                },
                new Tarea
                {
                    Id = 9,
                    Descripcion = "Pruebas de rendimiento",
                    EstadoId = 1,
                    ProyectoId = 2,
                },
                new Tarea
                {
                    Id = 10,
                    Descripcion = "Lanzamiento del sistema",
                    EstadoId = 1,
                    ProyectoId = 2,
                }
            );

            //TAREAS PARA PROYECTO 3

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 11,
                    Descripcion = "Evaluación de la plataforma actual",
                    EstadoId = 1,
                    ProyectoId = 3,

                },
                new Tarea
                {
                    Id = 12,
                    Descripcion = "Planificación de migración",
                    EstadoId = 2,
                    ProyectoId = 3,

                },
                new Tarea
                {
                    Id = 13,
                    Descripcion = "Implementación del nuevo sistema",
                    EstadoId = 1,
                    ProyectoId = 3,
                },
                new Tarea
                {
                    Id = 14,
                    Descripcion = "Transferencia de datos",
                    EstadoId = 1,
                    ProyectoId = 3,
                },
                new Tarea
                {
                    Id = 15,
                    Descripcion = "Pruebas finales",
                    EstadoId = 1,
                    ProyectoId = 3,
                }
            );

            //TAREAS PARA PROYECTO 4

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 16,
                    Descripcion = "Investigación de usuario",
                    EstadoId = 1,
                    ProyectoId = 4,

                },
                new Tarea
                {
                    Id = 17,
                    Descripcion = "Creación de wireframes",
                    EstadoId = 1,
                    ProyectoId = 4,

                },
                new Tarea
                {
                    Id = 18,
                    Descripcion = "Diseño de interfaz de usuario",
                    EstadoId = 2,
                    ProyectoId = 4,
                },
                new Tarea
                {
                    Id = 19,
                    Descripcion = "Implementación de prototipos",
                    EstadoId = 1,
                    ProyectoId = 4,
                },
                new Tarea
                {
                    Id = 20,
                    Descripcion = "Pruebas de usabilidad",
                    EstadoId = 1,
                    ProyectoId = 4,
                }
            );

            //TAREAS PARA PROYECTO 5

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 21,
                    Descripcion = "Desarrollo de conceptos",
                    EstadoId = 1,
                    ProyectoId = 5,

                },
                new Tarea
                {
                    Id = 22,
                    Descripcion = "Diseño de logo",
                    EstadoId = 1,
                    ProyectoId = 5,

                },
                new Tarea
                {
                    Id = 23,
                    Descripcion = "Creación de guías de estilo",
                    EstadoId = 2,
                    ProyectoId = 5,
                },
                new Tarea
                {
                    Id = 24,
                    Descripcion = "Elaboración de material promocional",
                    EstadoId = 1,
                    ProyectoId = 5,
                },
                new Tarea
                {
                    Id = 25,
                    Descripcion = "Presentación al cliente",
                    EstadoId = 1,
                    ProyectoId = 5,
                }
            );

            //TAREAS PARA PROYECTO 6

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 26,
                    Descripcion = "Diseño de pantallas",
                    EstadoId = 1,
                    ProyectoId = 6,

                },
                new Tarea
                {
                    Id = 27,
                    Descripcion = "Creación de iconografía",
                    EstadoId = 1,
                    ProyectoId = 6,

                },
                new Tarea
                {
                    Id = 28,
                    Descripcion = "Pruebas de diseño",
                    EstadoId = 1,
                    ProyectoId = 6,
                },
                new Tarea
                {
                    Id = 29,
                    Descripcion = "Adaptación a diferentes dispositivos",
                    EstadoId = 2,
                    ProyectoId = 6,
                },
                new Tarea
                {
                    Id = 30,
                    Descripcion = "Revisión final de diseño",
                    EstadoId = 1,
                    ProyectoId = 6,
                }
            );

            //TAREAS PARA PROYECTO 7

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 31,
                    Descripcion = "Auditoría de infraestructura",
                    EstadoId = 1,
                    ProyectoId = 7,

                },
                new Tarea
                {
                    Id = 32,
                    Descripcion = "Revisión de configuraciones actuales",
                    EstadoId = 1,
                    ProyectoId = 7,

                },
                new Tarea
                {
                    Id = 33,
                    Descripcion = "Implementación de mejoras",
                    EstadoId = 2,
                    ProyectoId = 7,
                },
                new Tarea
                {
                    Id = 34,
                    Descripcion = "Pruebas de conectividad",
                    EstadoId = 1,
                    ProyectoId = 7,
                },
                new Tarea
                {
                    Id = 35,
                    Descripcion = "Documentación de cambios",
                    EstadoId = 1,
                    ProyectoId = 7,
                }
            );

            //TAREAS PARA PROYECTO 8

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 36,
                    Descripcion = "Configuración de herramientas",
                    EstadoId = 1,
                    ProyectoId = 8,

                },
                new Tarea
                {
                    Id = 37,
                    Descripcion = "Desarrollo de scripts de automatización",
                    EstadoId = 1,
                    ProyectoId = 8,

                },
                new Tarea
                {
                    Id = 38,
                    Descripcion = "Pruebas de integración",
                    EstadoId = 2,
                    ProyectoId = 8,
                },
                new Tarea
                {
                    Id = 39,
                    Descripcion = "Documentación del proceso",
                    EstadoId = 1,
                    ProyectoId = 8,
                },
                new Tarea
                {
                    Id = 40,
                    Descripcion = "Implementación en producción",
                    EstadoId = 1,
                    ProyectoId = 8,
                }
            );

            //TAREAS PARA PROYECTO 9

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 41,
                    Descripcion = "Selección de plataforma",
                    EstadoId = 1,
                    ProyectoId = 9,

                },
                new Tarea
                {
                    Id = 42,
                    Descripcion = "Planificación de migración",
                    EstadoId = 1,
                    ProyectoId = 9,

                },
                new Tarea
                {
                    Id = 43,
                    Descripcion = "Transferencia de datos",
                    EstadoId = 2,
                    ProyectoId = 9,
                },
                new Tarea
                {
                    Id = 44,
                    Descripcion = "Configuración de seguridad",
                    EstadoId = 1,
                    ProyectoId = 9,
                },
                new Tarea
                {
                    Id = 45,
                    Descripcion = "Pruebas y ajustes finales",
                    EstadoId = 1,
                    ProyectoId = 9,
                }
            );
        }
    }
}
