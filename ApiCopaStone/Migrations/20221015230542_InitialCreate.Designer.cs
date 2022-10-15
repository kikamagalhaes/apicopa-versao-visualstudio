﻿// <auto-generated />
using System;
using ApiCopaStone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCopaStone.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221015230542_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ApiCopaStone.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ApiCopaStone.Models.FaseCopa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("FaseCopas");
                });

            modelBuilder.Entity("ApiCopaStone.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GolsSelecaoA")
                        .HasColumnType("int");

                    b.Property<int>("GolsSelecaoB")
                        .HasColumnType("int");

                    b.Property<DateTime>("InicioJogo")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SelecaoAId")
                        .HasColumnType("int");

                    b.Property<int>("SelecaoBId")
                        .HasColumnType("int");

                    b.Property<int?>("jogo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SelecaoAId");

                    b.HasIndex("jogo");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("ApiCopaStone.Models.Selecao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UrlImagemBandeira")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Selecaos");
                });

            modelBuilder.Entity("ApiCopaStone.Models.Jogo", b =>
                {
                    b.HasOne("ApiCopaStone.Models.Selecao", "Selecao")
                        .WithMany()
                        .HasForeignKey("SelecaoAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiCopaStone.Models.FaseCopa", null)
                        .WithMany("Jogos")
                        .HasForeignKey("jogo");

                    b.Navigation("Selecao");
                });

            modelBuilder.Entity("ApiCopaStone.Models.FaseCopa", b =>
                {
                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}