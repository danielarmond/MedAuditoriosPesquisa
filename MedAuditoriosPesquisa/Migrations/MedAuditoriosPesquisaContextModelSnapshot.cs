﻿// <auto-generated />
using System;
using MedAuditoriosPesquisa.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedAuditoriosPesquisa.Migrations
{
    [DbContext(typeof(MedAuditoriosPesquisaContext))]
    partial class MedAuditoriosPesquisaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MedAuditoriosPesquisa.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("MedAuditoriosPesquisa.Models.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<int>("ContatoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Filial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LinkVisita")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PeDireito")
                        .HasColumnType("int");

                    b.Property<int>("StatusPrimario")
                        .HasColumnType("int");

                    b.Property<int>("StatusSecundario")
                        .HasColumnType("int");

                    b.Property<int>("TipoCadeira")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContatoId");

                    b.ToTable("Local");
                });

            modelBuilder.Entity("MedAuditoriosPesquisa.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Funcao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MedAuditoriosPesquisa.Models.Local", b =>
                {
                    b.HasOne("MedAuditoriosPesquisa.Models.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contato");
                });
#pragma warning restore 612, 618
        }
    }
}
