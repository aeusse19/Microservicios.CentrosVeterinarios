﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using User.Microservice.DBContexts;

namespace User.Microservice.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("User.Microservice.Models.PetCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PetCenters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Av Del centro # 18 - 22",
                            City = "Manizales",
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(5433),
                            Description = "Hospital veterinario, peluqueria y accesorios",
                            Latitude = "5.069677694253585",
                            Longitude = "-75.51960687804086",
                            Name = "Los Galgos",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cra 23 # 15 05",
                            City = "Manizales",
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(5849),
                            Description = "Cnetro veterinario, peluqueria y accesorios",
                            Latitude = "5.0707867012057015",
                            Longitude = "-75.51997221219987",
                            Name = "Maranata Mundo Animal",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Alcazares Calle 5 # 20-04",
                            City = "Manizales",
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(5869),
                            Description = "Hospital veterinario, peluqueria y accesorios",
                            Latitude = "5.070783128280658",
                            Longitude = "-75.52664335097862",
                            Name = "Huella Amiga",
                            Status = "Activo"
                        });
                });

            modelBuilder.Entity("User.Microservice.Models.TypeDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TypeDocuments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 22, DateTimeKind.Local).AddTicks(9943),
                            Description = "CC",
                            Name = "Cédula de ciudadania",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 23, DateTimeKind.Local).AddTicks(8715),
                            Description = "CE",
                            Name = "Cédula de extranjeria",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 23, DateTimeKind.Local).AddTicks(8740),
                            Description = "TI",
                            Name = "Tarjeta de identidad",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 23, DateTimeKind.Local).AddTicks(8787),
                            Description = "RC",
                            Name = "Registro civil",
                            Status = "Activo"
                        });
                });

            modelBuilder.Entity("User.Microservice.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(2072),
                            Description = "Admin",
                            Name = "Administrador",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(2504),
                            Description = "Cliente",
                            Name = "Cliente",
                            Status = "Activo"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 5, 23, 22, 57, 30, 25, DateTimeKind.Local).AddTicks(2518),
                            Description = "Médico veterinario",
                            Name = "Médico veterinario",
                            Status = "Activo"
                        });
                });

            modelBuilder.Entity("User.Microservice.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetCenterID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeDocumentID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserProfileID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetCenterID");

                    b.HasIndex("TypeDocumentID");

                    b.HasIndex("UserProfileID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("User.Microservice.Models.Users", b =>
                {
                    b.HasOne("User.Microservice.Models.PetCenter", "PetCenter")
                        .WithMany()
                        .HasForeignKey("PetCenterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User.Microservice.Models.TypeDocument", "TypeDocument")
                        .WithMany()
                        .HasForeignKey("TypeDocumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User.Microservice.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
