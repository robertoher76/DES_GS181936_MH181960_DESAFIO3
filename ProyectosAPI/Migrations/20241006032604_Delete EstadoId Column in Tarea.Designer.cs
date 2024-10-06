﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectosAPI.Models;

#nullable disable

namespace ProyectosAPI.Migrations
{
    [DbContext(typeof(ProyectoContext))]
    [Migration("20241006032604_Delete EstadoId Column in Tarea")]
    partial class DeleteEstadoIdColumninTarea
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProyectosAPI.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Equipo encargado de la programación y desarrollo de software.",
                            Nombre = "Desarrollo"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Equipo encargado del diseño gráfico y experiencia de usuario.",
                            Nombre = "Diseño"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Equipo encargado de la infraestructura y soporte operativo.",
                            Nombre = "Operaciones"
                        });
                });

            modelBuilder.Entity("ProyectosAPI.Models.EstadoTareas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EstadoTareas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Pendiente"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "En Progreso"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Completada"
                        });
                });

            modelBuilder.Entity("ProyectosAPI.Models.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquipoId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaDeFin")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaDeInicio")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Proyectos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EquipoId = 1,
                            FechaDeFin = new DateOnly(2024, 5, 30),
                            FechaDeInicio = new DateOnly(2024, 1, 15),
                            Nombre = "Plataforma Interna"
                        },
                        new
                        {
                            Id = 2,
                            EquipoId = 1,
                            FechaDeFin = new DateOnly(2024, 8, 15),
                            FechaDeInicio = new DateOnly(2024, 3, 1),
                            Nombre = "Sistema de Automatización"
                        },
                        new
                        {
                            Id = 3,
                            EquipoId = 1,
                            FechaDeFin = new DateOnly(2024, 7, 10),
                            FechaDeInicio = new DateOnly(2024, 2, 10),
                            Nombre = "Migración de Plataforma"
                        },
                        new
                        {
                            Id = 4,
                            EquipoId = 1,
                            FechaDeFin = new DateOnly(2024, 7, 10),
                            FechaDeInicio = new DateOnly(2024, 2, 10),
                            Nombre = "Migración de Plataforma"
                        },
                        new
                        {
                            Id = 5,
                            EquipoId = 2,
                            FechaDeFin = new DateOnly(2024, 9, 15),
                            FechaDeInicio = new DateOnly(2024, 4, 1),
                            Nombre = "Rediseño Web Corporativo"
                        },
                        new
                        {
                            Id = 6,
                            EquipoId = 2,
                            FechaDeFin = new DateOnly(2024, 6, 30),
                            FechaDeInicio = new DateOnly(2024, 2, 20),
                            Nombre = "Identidad Visual Nueva Marca"
                        },
                        new
                        {
                            Id = 7,
                            EquipoId = 2,
                            FechaDeFin = new DateOnly(2024, 8, 20),
                            FechaDeInicio = new DateOnly(2024, 3, 5),
                            Nombre = "Diseño de Aplicación Móvil"
                        },
                        new
                        {
                            Id = 8,
                            EquipoId = 3,
                            FechaDeFin = new DateOnly(2024, 6, 15),
                            FechaDeInicio = new DateOnly(2024, 1, 10),
                            Nombre = "Optimización de Redes"
                        },
                        new
                        {
                            Id = 9,
                            EquipoId = 3,
                            FechaDeFin = new DateOnly(2024, 7, 5),
                            FechaDeInicio = new DateOnly(2024, 3, 25),
                            Nombre = "Automatización de Servidores"
                        },
                        new
                        {
                            Id = 10,
                            EquipoId = 3,
                            FechaDeFin = new DateOnly(2024, 7, 1),
                            FechaDeInicio = new DateOnly(2024, 2, 15),
                            Nombre = "Migración de Datos a Nube"
                        });
                });

            modelBuilder.Entity("ProyectosAPI.Models.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstadoTareasId")
                        .HasColumnType("int");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoTareasId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Planificación inicial",
                            EstadoTareasId = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Desarrollo de prototipos",
                            EstadoTareasId = 2,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Implementación de módulos",
                            EstadoTareasId = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Pruebas de integración",
                            EstadoTareasId = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Despliegue inicial",
                            EstadoTareasId = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Recolección de requerimientos",
                            EstadoTareasId = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 7,
                            Descripcion = "Diseño del sistema",
                            EstadoTareasId = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 8,
                            Descripcion = "Configuración de servidores",
                            EstadoTareasId = 2,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 9,
                            Descripcion = "Pruebas de rendimiento",
                            EstadoTareasId = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 10,
                            Descripcion = "Lanzamiento del sistema",
                            EstadoTareasId = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 11,
                            Descripcion = "Evaluación de la plataforma actual",
                            EstadoTareasId = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 12,
                            Descripcion = "Planificación de migración",
                            EstadoTareasId = 2,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 13,
                            Descripcion = "Implementación del nuevo sistema",
                            EstadoTareasId = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 14,
                            Descripcion = "Transferencia de datos",
                            EstadoTareasId = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 15,
                            Descripcion = "Pruebas finales",
                            EstadoTareasId = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 16,
                            Descripcion = "Investigación de usuario",
                            EstadoTareasId = 1,
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 17,
                            Descripcion = "Creación de wireframes",
                            EstadoTareasId = 1,
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 18,
                            Descripcion = "Diseño de interfaz de usuario",
                            EstadoTareasId = 2,
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 19,
                            Descripcion = "Implementación de prototipos",
                            EstadoTareasId = 1,
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 20,
                            Descripcion = "Pruebas de usabilidad",
                            EstadoTareasId = 1,
                            ProyectoId = 4
                        },
                        new
                        {
                            Id = 21,
                            Descripcion = "Desarrollo de conceptos",
                            EstadoTareasId = 1,
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 22,
                            Descripcion = "Diseño de logo",
                            EstadoTareasId = 1,
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 23,
                            Descripcion = "Creación de guías de estilo",
                            EstadoTareasId = 2,
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 24,
                            Descripcion = "Elaboración de material promocional",
                            EstadoTareasId = 1,
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 25,
                            Descripcion = "Presentación al cliente",
                            EstadoTareasId = 1,
                            ProyectoId = 5
                        },
                        new
                        {
                            Id = 26,
                            Descripcion = "Diseño de pantallas",
                            EstadoTareasId = 1,
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 27,
                            Descripcion = "Creación de iconografía",
                            EstadoTareasId = 1,
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 28,
                            Descripcion = "Pruebas de diseño",
                            EstadoTareasId = 1,
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 29,
                            Descripcion = "Adaptación a diferentes dispositivos",
                            EstadoTareasId = 2,
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 30,
                            Descripcion = "Revisión final de diseño",
                            EstadoTareasId = 1,
                            ProyectoId = 6
                        },
                        new
                        {
                            Id = 31,
                            Descripcion = "Auditoría de infraestructura",
                            EstadoTareasId = 1,
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 32,
                            Descripcion = "Revisión de configuraciones actuales",
                            EstadoTareasId = 1,
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 33,
                            Descripcion = "Implementación de mejoras",
                            EstadoTareasId = 2,
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 34,
                            Descripcion = "Pruebas de conectividad",
                            EstadoTareasId = 1,
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 35,
                            Descripcion = "Documentación de cambios",
                            EstadoTareasId = 1,
                            ProyectoId = 7
                        },
                        new
                        {
                            Id = 36,
                            Descripcion = "Configuración de herramientas",
                            EstadoTareasId = 1,
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 37,
                            Descripcion = "Desarrollo de scripts de automatización",
                            EstadoTareasId = 1,
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 38,
                            Descripcion = "Pruebas de integración",
                            EstadoTareasId = 2,
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 39,
                            Descripcion = "Documentación del proceso",
                            EstadoTareasId = 1,
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 40,
                            Descripcion = "Implementación en producción",
                            EstadoTareasId = 1,
                            ProyectoId = 8
                        },
                        new
                        {
                            Id = 41,
                            Descripcion = "Selección de plataforma",
                            EstadoTareasId = 1,
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 42,
                            Descripcion = "Planificación de migración",
                            EstadoTareasId = 1,
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 43,
                            Descripcion = "Transferencia de datos",
                            EstadoTareasId = 2,
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 44,
                            Descripcion = "Configuración de seguridad",
                            EstadoTareasId = 1,
                            ProyectoId = 9
                        },
                        new
                        {
                            Id = 45,
                            Descripcion = "Pruebas y ajustes finales",
                            EstadoTareasId = 1,
                            ProyectoId = 9
                        });
                });

            modelBuilder.Entity("ProyectosAPI.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProyectosAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProyectosAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectosAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProyectosAPI.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectosAPI.Models.Proyecto", b =>
                {
                    b.HasOne("ProyectosAPI.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("ProyectosAPI.Models.Tarea", b =>
                {
                    b.HasOne("ProyectosAPI.Models.EstadoTareas", "EstadoTareas")
                        .WithMany()
                        .HasForeignKey("EstadoTareasId");

                    b.HasOne("ProyectosAPI.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId");

                    b.Navigation("EstadoTareas");

                    b.Navigation("Proyecto");
                });
#pragma warning restore 612, 618
        }
    }
}
