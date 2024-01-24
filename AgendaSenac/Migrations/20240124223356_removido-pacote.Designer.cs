﻿// <auto-generated />
using System;
using AgendaSenac;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaSenac.Migrations
{
    [DbContext(typeof(BancoDeDados))]
    [Migration("20240124223356_removido-pacote")]
    partial class removidopacote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("AgendaSenac.AgendaCurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dias")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("TEXT");

                    b.Property<string>("Horario")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Meta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Realizado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sala")
                        .HasColumnType("TEXT");

                    b.Property<string>("Turma")
                        .HasColumnType("TEXT");

                    b.Property<string>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AgendaCursos");
                });

            modelBuilder.Entity("AgendaSenac.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("AgendaSenac.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alteracao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Detalhes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Historicos");
                });

            modelBuilder.Entity("AgendaSenac.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Administrador")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
