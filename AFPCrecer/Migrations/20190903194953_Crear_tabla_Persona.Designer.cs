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
    [Migration("20190903194953_Crear_tabla_Persona")]
    partial class Crear_tabla_Persona
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}
