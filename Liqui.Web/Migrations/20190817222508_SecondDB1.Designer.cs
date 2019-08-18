﻿// <auto-generated />
using System;
using Liqui.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Liqui.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190817222508_SecondDB1")]
    partial class SecondDB1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Liqui.Web.Data.Entities.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Local");
                });

            modelBuilder.Entity("Liqui.Web.Data.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("UsuarioLocalId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioLocalId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Liqui.Web.Data.Entities.UsuarioLocal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocalId");

                    b.HasKey("Id");

                    b.HasIndex("LocalId");

                    b.ToTable("UsuarioLocal");
                });

            modelBuilder.Entity("Liqui.Web.Data.Entities.Usuario", b =>
                {
                    b.HasOne("Liqui.Web.Data.Entities.UsuarioLocal", "UsuarioLocal")
                        .WithMany()
                        .HasForeignKey("UsuarioLocalId");
                });

            modelBuilder.Entity("Liqui.Web.Data.Entities.UsuarioLocal", b =>
                {
                    b.HasOne("Liqui.Web.Data.Entities.Local", "Local")
                        .WithMany("UsuarioLocales")
                        .HasForeignKey("LocalId");
                });
#pragma warning restore 612, 618
        }
    }
}
