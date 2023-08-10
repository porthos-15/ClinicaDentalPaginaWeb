﻿// <auto-generated />
using System;
using ClinicaDental01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicaDental01.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230722034130_ModificarTablaConsulta")]
    partial class ModificarTablaConsulta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClinicaDental01.Models.Domain.Cita", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"), 1L, 1);

                    b.Property<string>("DescripcionCita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCita");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("ClinicaDental01.Models.Domain.Consulta", b =>
                {
                    b.Property<int>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConsulta"), 1L, 1);

                    b.Property<string>("AntecedentesAlergicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AntecedentesPatologicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AntecedentesQuirurjicos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergenciaLlamar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamenExtraoral")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaConsulta")
                        .HasColumnType("datetime2");

                    b.Property<string>("FrecuenciaRespiratoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HistorialDental")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicamentosToma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicoCabecera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PacienteConsulta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanTratamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresionArterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pulso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuejaPrincipal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TejidosBlandos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoSangre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdConsulta");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ClinicaDental01.Models.Domain.Dentista", b =>
                {
                    b.Property<int>("IdDentista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDentista"), 1L, 1);

                    b.Property<string>("CorreoDentista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDentista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellidoDentista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellidoDentista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoDentista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDentista");

                    b.ToTable("Dentistas");
                });

            modelBuilder.Entity("ClinicaDental01.Models.Domain.Paciente", b =>
                {
                    b.Property<int>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPaciente"), 1L, 1);

                    b.Property<bool>("Alergia")
                        .HasColumnType("bit");

                    b.Property<bool>("AparicionDeEquimosisOMoretes")
                        .HasColumnType("bit");

                    b.Property<bool>("ApoyalaManoSobreLaBarbilla")
                        .HasColumnType("bit");

                    b.Property<int>("CedulaPaciente")
                        .HasColumnType("int");

                    b.Property<bool>("ChuponOChupeta")
                        .HasColumnType("bit");

                    b.Property<bool>("ComeMuerdeObjetos")
                        .HasColumnType("bit");

                    b.Property<string>("CorreoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DiabetesTipo1")
                        .HasColumnType("bit");

                    b.Property<bool>("DiabetesTipo2")
                        .HasColumnType("bit");

                    b.Property<string>("DireccionPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DueleAlAbrirOCerrarLaBoca")
                        .HasColumnType("bit");

                    b.Property<bool>("DuermeConBocaAbiertaOCerrada")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadDeTransmisionSexual")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadesCardiacas")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadesRespiratorias")
                        .HasColumnType("bit");

                    b.Property<bool>("EpilepsiaDesmayoConvulsiones")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaOcreeEstarEmbarazada")
                        .HasColumnType("bit");

                    b.Property<string>("EstadoCivilPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimientoPaciente")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FiebreReumAtica")
                        .HasColumnType("bit");

                    b.Property<bool>("Fuma")
                        .HasColumnType("bit");

                    b.Property<bool>("Hepatitis")
                        .HasColumnType("bit");

                    b.Property<string>("NombrePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Osteoporosis")
                        .HasColumnType("bit");

                    b.Property<string>("PrimerApellidoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProblemasDeLaPresionArterial")
                        .HasColumnType("bit");

                    b.Property<bool>("ProblemasDeLaTiroides")
                        .HasColumnType("bit");

                    b.Property<bool>("ProblemasDeMareos")
                        .HasColumnType("bit");

                    b.Property<bool>("ProblemasDeVision")
                        .HasColumnType("bit");

                    b.Property<bool>("ProblemasEnLosRinones")
                        .HasColumnType("bit");

                    b.Property<bool>("ProblemasGastrointestinales")
                        .HasColumnType("bit");

                    b.Property<bool>("RastrillaLosDientes")
                        .HasColumnType("bit");

                    b.Property<bool>("SacaLaLenguaOTieneLenguaProtractil")
                        .HasColumnType("bit");

                    b.Property<string>("SegundoApellidoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShockAnafilactico")
                        .HasColumnType("bit");

                    b.Property<bool>("SuccionDeDedo")
                        .HasColumnType("bit");

                    b.Property<string>("TelefonoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TomaLicor")
                        .HasColumnType("bit");

                    b.Property<bool>("TratamientoAnticonceptivo")
                        .HasColumnType("bit");

                    b.Property<bool>("TratamientoPsiquiatrico")
                        .HasColumnType("bit");

                    b.Property<bool>("VIHOSIDA")
                        .HasColumnType("bit");

                    b.Property<bool>("VirusDelHerpes")
                        .HasColumnType("bit");

                    b.HasKey("IdPaciente");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("ClinicaDental01.Models.Domain.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServicio"), 1L, 1);

                    b.Property<long>("CostoServicio")
                        .HasColumnType("bigint");

                    b.Property<string>("DescripcionServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdServicio");

                    b.ToTable("Servicios");
                });

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
