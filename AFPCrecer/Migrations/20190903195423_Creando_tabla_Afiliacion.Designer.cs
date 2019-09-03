﻿// <auto-generated />
using System;
using AFPCrecer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AFPCrecer.Migrations
{
    [DbContext(typeof(AFPCrecerContext))]
    [Migration("20190903195423_Creando_tabla_Afiliacion")]
    partial class Creando_tabla_Afiliacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AFPCrecer.Models.Afiliacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonaId");

                    b.Property<int>("TipoAfiliacionId");

                    b.Property<DateTime>("fecha_afiliacion");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.HasIndex("TipoAfiliacionId");

                    b.ToTable("Afiliacion");
                });

            modelBuilder.Entity("AFPCrecer.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido_Materno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Apellido_Paterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("fecha_nac")
                        .HasMaxLength(50);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("AFPCrecer.Models.TipoAfiliacion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("TipoAfiliacion");
                });

            modelBuilder.Entity("AFPCrecer.Models.Afiliacion", b =>
                {
                    b.HasOne("AFPCrecer.Models.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AFPCrecer.Models.TipoAfiliacion", "TipoAfiliacion")
                        .WithMany()
                        .HasForeignKey("TipoAfiliacionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
