﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200526125006_Quinta")]
    partial class Quinta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.AntecedenteEpidemiologicos1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CiudadDelPaisEnQueEstuvo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompañiaDeTransporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DomicilioAlejoEnElQueResidioDomicilioId")
                        .HasColumnType("int");

                    b.Property<bool>("EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaDeIngresoAlPais")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeLlegadaADomicilioAjeno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeLlegadaAlPaisEnQueEstuvo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeSalidaDelDomicilioAjeno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeSalidaDelPaisEnQueEstuvo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeVacunacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDeVencimientoDeLaVacuna")
                        .HasColumnType("datetime2");

                    b.Property<string>("OtroTipoDeOcupacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisEnQueEstuvo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas")
                        .HasColumnType("bit");

                    b.Property<bool>("TieneVacunaAntiGripal")
                        .HasColumnType("bit");

                    b.Property<string>("TipoDeOcupacionDelPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeTransporteUtilizado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DomicilioAlejoEnElQueResidioDomicilioId");

                    b.ToTable("ListaAntecedenteEpidemiologicos1");
                });

            modelBuilder.Entity("Modelo.AntecedenteEpidemiologicos2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoDelCaso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaDelCaso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CiudadDelCentroVisitado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactoConAnimalesPrevioASintomas")
                        .HasColumnType("bit");

                    b.Property<bool>("ContactoConCasosProbablesOConfirmadosPrevioASintomas")
                        .HasColumnType("bit");

                    b.Property<bool>("ContactoConPersonasConIRPrevioASintomas")
                        .HasColumnType("bit");

                    b.Property<string>("DNIDelCaso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeLaVisitaAlCentro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreDelCaso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDelCentroVisitado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtroTipoDeContactoConAnimales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtroTipoDeEntornoDeContacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisDelCaso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeAnimalesConContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeEntornoDeContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VisitoCentroConCasosPositivosPrevioASintomas")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ListaAntecedenteEpidemiologicos2");
                });

            modelBuilder.Entity("Modelo.Domicilio", b =>
                {
                    b.Property<int>("DomicilioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dpto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("NroDeCalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroDeDpto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Piso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DomicilioId");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Domicilio");
                });

            modelBuilder.Entity("Modelo.EnfermedadesPreviasComorbilidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Asma")
                        .HasColumnType("bit");

                    b.Property<bool>("BajoPesoAlNacer")
                        .HasColumnType("bit");

                    b.Property<bool>("BronquitisPrevia")
                        .HasColumnType("bit");

                    b.Property<string>("CantidadDePesoAlNacer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Diabetes")
                        .HasColumnType("bit");

                    b.Property<bool>("EPOC")
                        .HasColumnType("bit");

                    b.Property<bool>("Embarzo")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadHepatica")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadNeurologica")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadOncologica")
                        .HasColumnType("bit");

                    b.Property<bool>("EnfermedadRenalCronica")
                        .HasColumnType("bit");

                    b.Property<bool>("Fumador")
                        .HasColumnType("bit");

                    b.Property<bool>("HipertensionArterial")
                        .HasColumnType("bit");

                    b.Property<bool>("InmunoSupresionCongenitaOAdquirida")
                        .HasColumnType("bit");

                    b.Property<bool>("NAC_Previa")
                        .HasColumnType("bit");

                    b.Property<bool>("NingunaDelasAnteriores")
                        .HasColumnType("bit");

                    b.Property<bool>("Obesidad")
                        .HasColumnType("bit");

                    b.Property<bool>("Otras")
                        .HasColumnType("bit");

                    b.Property<string>("OtrasDetalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Prematuridad")
                        .HasColumnType("bit");

                    b.Property<bool>("PresentaEnfermedadesComorbilidades")
                        .HasColumnType("bit");

                    b.Property<bool>("Puerperio")
                        .HasColumnType("bit");

                    b.Property<string>("SemanasDePrematuridad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tubercolosis")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ListaEnfermedadesPreviasComorbilidades");
                });

            modelBuilder.Entity("Modelo.FormularioParaAnalisis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AntecedenteEpidemiologicos1Id")
                        .HasColumnType("int");

                    b.Property<int>("AntecedenteEpidemiologicos2Id")
                        .HasColumnType("int");

                    b.Property<int>("EnfermedadesPreviasComorbilidadesId")
                        .HasColumnType("int");

                    b.Property<string>("EstadoDelFormulario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("RespuestaMedica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SignosYSintomasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AntecedenteEpidemiologicos1Id");

                    b.HasIndex("AntecedenteEpidemiologicos2Id");

                    b.HasIndex("EnfermedadesPreviasComorbilidadesId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("SignosYSintomasId");

                    b.ToTable("ListaFormularioParaAnalisis");
                });

            modelBuilder.Entity("Modelo.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("ListaLocalidades");
                });

            modelBuilder.Entity("Modelo.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("APIUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroDeDocumento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DomicilioId");

                    b.HasIndex("NroDeDocumento")
                        .IsUnique()
                        .HasFilter("[NroDeDocumento] IS NOT NULL");

                    b.ToTable("ListaPaciente");
                });

            modelBuilder.Entity("Modelo.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ListaProvincias");
                });

            modelBuilder.Entity("Modelo.SignosYSintomas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Artralgias")
                        .HasColumnType("bit");

                    b.Property<bool>("Convulsiones")
                        .HasColumnType("bit");

                    b.Property<bool>("Diarrea")
                        .HasColumnType("bit");

                    b.Property<bool>("DolorAbdominal")
                        .HasColumnType("bit");

                    b.Property<bool>("DolorDeGarganta")
                        .HasColumnType("bit");

                    b.Property<bool>("DolorToracico")
                        .HasColumnType("bit");

                    b.Property<bool>("FiebreMayorA38")
                        .HasColumnType("bit");

                    b.Property<bool>("InsuficienciaRespiratoria")
                        .HasColumnType("bit");

                    b.Property<bool>("IrritabilidadConfusion")
                        .HasColumnType("bit");

                    b.Property<bool>("MalestarEnGenerl")
                        .HasColumnType("bit");

                    b.Property<bool>("Otros")
                        .HasColumnType("bit");

                    b.Property<string>("OtrosDetalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RechazoAlAlimento")
                        .HasColumnType("bit");

                    b.Property<bool>("Taquipnea_Disnea")
                        .HasColumnType("bit");

                    b.Property<bool>("Tos")
                        .HasColumnType("bit");

                    b.Property<bool>("Vomitos")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ListaSignosYSintomas");
                });

            modelBuilder.Entity("Modelo.AntecedenteEpidemiologicos1", b =>
                {
                    b.HasOne("Modelo.Domicilio", "DomicilioAlejoEnElQueResidio")
                        .WithMany()
                        .HasForeignKey("DomicilioAlejoEnElQueResidioDomicilioId");
                });

            modelBuilder.Entity("Modelo.Domicilio", b =>
                {
                    b.HasOne("Modelo.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.FormularioParaAnalisis", b =>
                {
                    b.HasOne("Modelo.AntecedenteEpidemiologicos1", "AntecedenteEpidemiologicos1")
                        .WithMany()
                        .HasForeignKey("AntecedenteEpidemiologicos1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.AntecedenteEpidemiologicos2", "AntecedenteEpidemiologicos2")
                        .WithMany()
                        .HasForeignKey("AntecedenteEpidemiologicos2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.EnfermedadesPreviasComorbilidades", "EnfermedadesPreviasComorbilidades")
                        .WithMany()
                        .HasForeignKey("EnfermedadesPreviasComorbilidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.SignosYSintomas", "SignosYSintomas")
                        .WithMany()
                        .HasForeignKey("SignosYSintomasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.Localidad", b =>
                {
                    b.HasOne("Modelo.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelo.Paciente", b =>
                {
                    b.HasOne("Modelo.Domicilio", "Domicilio")
                        .WithMany()
                        .HasForeignKey("DomicilioId");
                });
#pragma warning restore 612, 618
        }
    }
}
