﻿// <auto-generated />
using System;
using ControleGlicemia_002.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleGlicemia_002.Migrations
{
    [DbContext(typeof(GlicemiaContext))]
    partial class GlicemiaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ControleGlicemia_002.Models.Glicemia", b =>
                {
                    b.Property<int>("GlicemiaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlicemiaID"), 1L, 1);

                    b.Property<DateTime>("DataAplicacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataMedicao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoseAjuste")
                        .HasColumnType("int");

                    b.Property<int?>("DoseRegular")
                        .HasColumnType("int");

                    b.Property<int>("GlicemiaMedida")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraAplicacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraMedicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GlicemiaID");

                    b.ToTable("GLICEMIAS");
                });
#pragma warning restore 612, 618
        }
    }
}
