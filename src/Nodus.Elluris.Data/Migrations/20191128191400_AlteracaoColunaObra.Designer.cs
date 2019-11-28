﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nodus.Elluris.Data.ORM;

namespace Nodus.Elluris.Data.Migrations
{
    [DbContext(typeof(NodusArtDbContext))]
    [Migration("20191128191400_AlteracaoColunaObra")]
    partial class AlteracaoColunaObra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.Beacon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BeaconCode")
                        .HasColumnName("BeaconCode")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataAtualizacao");

                    b.HasKey("Id");

                    b.ToTable("Beacons");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.BeaconObra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BeaconId");

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<Guid?>("ObraId");

                    b.HasKey("Id");

                    b.HasIndex("BeaconId");

                    b.HasIndex("ObraId");

                    b.ToTable("BeaconObras");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.Evento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("EventoPeriodoId");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EventoPeriodoId");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.EventoPeriodo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnName("DataFinal");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnName("DataInicial");

                    b.HasKey("Id");

                    b.ToTable("EventoPeriodo");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.ObraEvento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<int>("Id_Evento");

                    b.Property<int>("Id_Obra");

                    b.HasKey("Id");

                    b.ToTable("ObraEventos");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.Obras", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<string>("Descricao")
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Observacao")
                        .HasColumnName("Observacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrlFoto")
                        .HasColumnName("UrlFoto")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Obras");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.BeaconObra", b =>
                {
                    b.HasOne("Nodus.Elluris.Domain.Models.Beacon", "Beacon")
                        .WithMany()
                        .HasForeignKey("BeaconId");

                    b.HasOne("Nodus.Elluris.Domain.Models.Obras", "Obra")
                        .WithMany()
                        .HasForeignKey("ObraId");
                });

            modelBuilder.Entity("Nodus.Elluris.Domain.Models.Evento", b =>
                {
                    b.HasOne("Nodus.Elluris.Domain.Models.EventoPeriodo", "EventoPeriodo")
                        .WithMany()
                        .HasForeignKey("EventoPeriodoId");
                });
#pragma warning restore 612, 618
        }
    }
}
