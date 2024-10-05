﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectosAPI.Models;

#nullable disable

namespace ProyectosAPI.Migrations
{
    [DbContext(typeof(ProyectoContext))]
    partial class ProyectoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Planificación inicial",
                            Estado = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Desarrollo de prototipos",
                            Estado = 2,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Implementación de módulos",
                            Estado = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Pruebas de integración",
                            Estado = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Despliegue inicial",
                            Estado = 1,
                            ProyectoId = 1
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Recolección de requerimientos",
                            Estado = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 7,
                            Descripcion = "Diseño del sistema",
                            Estado = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 8,
                            Descripcion = "Configuración de servidores",
                            Estado = 2,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 9,
                            Descripcion = "Pruebas de rendimiento",
                            Estado = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 10,
                            Descripcion = "Lanzamiento del sistema",
                            Estado = 1,
                            ProyectoId = 2
                        },
                        new
                        {
                            Id = 11,
                            Descripcion = "Evaluación de la plataforma actual",
                            Estado = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 12,
                            Descripcion = "Planificación de migración",
                            Estado = 2,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 13,
                            Descripcion = "Implementación del nuevo sistema",
                            Estado = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 14,
                            Descripcion = "Transferencia de datos",
                            Estado = 1,
                            ProyectoId = 3
                        },
                        new
                        {
                            Id = 15,
                            Descripcion = "Pruebas finales",
                            Estado = 1,
                            ProyectoId = 3
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
                    b.HasOne("ProyectosAPI.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId");

                    b.Navigation("Proyecto");
                });
#pragma warning restore 612, 618
        }
    }
}
