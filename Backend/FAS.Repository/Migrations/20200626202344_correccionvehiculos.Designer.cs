﻿// <auto-generated />
using System;
using FAS.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAS.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200626202344_correccionvehiculos")]
    partial class correccionvehiculos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAS.Entity.Asistencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fecha");

                    b.Property<double>("posX");

                    b.Property<double>("posY");

                    b.HasKey("Id");

                    b.ToTable("Asistencias");
                });

            modelBuilder.Entity("FAS.Entity.Brevete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatBreveteId");

                    b.Property<int>("IdcatBrevete");

                    b.Property<DateTime>("fechaExpi");

                    b.Property<string>("numero");

                    b.HasKey("Id");

                    b.HasIndex("CatBreveteId");

                    b.ToTable("Brevetes");
                });

            modelBuilder.Entity("FAS.Entity.CatBrevete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("catbrevete");

                    b.HasKey("Id");

                    b.ToTable("CatBrevetes");
                });

            modelBuilder.Entity("FAS.Entity.Conductor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BreveteId");

                    b.Property<int>("IdBrevete");

                    b.Property<int>("IdTrabajador");

                    b.Property<int?>("TrabajadorId");

                    b.HasKey("Id");

                    b.HasIndex("BreveteId");

                    b.HasIndex("TrabajadorId");

                    b.ToTable("Conductores");
                });

            modelBuilder.Entity("FAS.Entity.DetalleViaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AsistenciaId");

                    b.Property<int>("IdAsistencia");

                    b.Property<int>("IdViaje");

                    b.Property<int?>("ViajeId");

                    b.HasKey("Id");

                    b.HasIndex("AsistenciaId");

                    b.HasIndex("ViajeId");

                    b.ToTable("DetalleViajes");
                });

            modelBuilder.Entity("FAS.Entity.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cargamax");

                    b.Property<string>("modelo");

                    b.Property<string>("nrollantas");

                    b.HasKey("Id");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("FAS.Entity.Trabajador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos");

                    b.Property<string>("Celular");

                    b.Property<string>("Correo");

                    b.Property<string>("DNI");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("Nombres");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Trbajadores");
                });

            modelBuilder.Entity("FAS.Entity.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contraseña");

                    b.Property<string>("usuario");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FAS.Entity.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdModelo");

                    b.Property<int?>("ModeloId");

                    b.Property<bool>("estadomotor");

                    b.Property<string>("nromotor");

                    b.Property<string>("placa");

                    b.HasKey("Id");

                    b.HasIndex("ModeloId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("FAS.Entity.Viaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConductorId");

                    b.Property<int>("IdConductor");

                    b.Property<int>("IdVehiculo");

                    b.Property<string>("TipoCarga");

                    b.Property<int?>("VehiculoId");

                    b.Property<DateTime>("fechaviaje");

                    b.Property<int>("nroViaje");

                    b.HasKey("Id");

                    b.HasIndex("ConductorId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Viaje");
                });

            modelBuilder.Entity("FAS.Entity.Brevete", b =>
                {
                    b.HasOne("FAS.Entity.CatBrevete", "CatBrevete")
                        .WithMany()
                        .HasForeignKey("CatBreveteId");
                });

            modelBuilder.Entity("FAS.Entity.Conductor", b =>
                {
                    b.HasOne("FAS.Entity.Brevete", "Brevete")
                        .WithMany()
                        .HasForeignKey("BreveteId");

                    b.HasOne("FAS.Entity.Trabajador", "Trabajador")
                        .WithMany()
                        .HasForeignKey("TrabajadorId");
                });

            modelBuilder.Entity("FAS.Entity.DetalleViaje", b =>
                {
                    b.HasOne("FAS.Entity.Asistencia", "Asistencia")
                        .WithMany()
                        .HasForeignKey("AsistenciaId");

                    b.HasOne("FAS.Entity.Viaje", "Viaje")
                        .WithMany("DetalleViaje")
                        .HasForeignKey("ViajeId");
                });

            modelBuilder.Entity("FAS.Entity.Trabajador", b =>
                {
                    b.HasOne("FAS.Entity.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("FAS.Entity.Vehiculo", b =>
                {
                    b.HasOne("FAS.Entity.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId");
                });

            modelBuilder.Entity("FAS.Entity.Viaje", b =>
                {
                    b.HasOne("FAS.Entity.Conductor", "Conductor")
                        .WithMany()
                        .HasForeignKey("ConductorId");

                    b.HasOne("FAS.Entity.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}
