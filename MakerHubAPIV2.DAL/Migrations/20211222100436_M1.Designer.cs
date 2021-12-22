﻿// <auto-generated />
using System;
using MakerHubAPIV2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MakerHubAPIV2.DAL.Migrations
{
    [DbContext(typeof(CTTDBContext))]
    [Migration("20211222100436_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakerHubAPIV2.DAL.Entities.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeureDepartDames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeureDepartHommes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdAFTT")
                        .HasColumnType("int");

                    b.Property<int?>("IdEquipeDames")
                        .HasColumnType("int");

                    b.Property<int?>("IdEquipeHommes")
                        .HasColumnType("int");

                    b.Property<string>("IdentifiantConnexion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Joueur");
                });

            modelBuilder.Entity("MakerHubAPIV2.DAL.Entities.JoueurSouper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdJoueur")
                        .HasColumnType("int");

                    b.Property<int>("IdSouper")
                        .HasColumnType("int");

                    b.Property<int>("NbReservations")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdJoueur");

                    b.HasIndex("IdSouper");

                    b.ToTable("JoueurSouper");
                });

            modelBuilder.Entity("MakerHubAPIV2.DAL.Entities.Souper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int>("NombreMax")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixAffilies")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrixExternes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeSouper")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Souper");
                });

            modelBuilder.Entity("MakerHubAPIV2.DAL.Entities.JoueurSouper", b =>
                {
                    b.HasOne("MakerHubAPIV2.DAL.Entities.Joueur", "Joueur")
                        .WithMany("JoueurSoupers")
                        .HasForeignKey("IdJoueur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakerHubAPIV2.DAL.Entities.Souper", "Souper")
                        .WithMany("JoueurSoupers")
                        .HasForeignKey("IdSouper")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Joueur");

                    b.Navigation("Souper");
                });

            modelBuilder.Entity("MakerHubAPIV2.DAL.Entities.Joueur", b =>
                {
                    b.Navigation("JoueurSoupers");
                });

            modelBuilder.Entity("MakerHubAPIV2.DAL.Entities.Souper", b =>
                {
                    b.Navigation("JoueurSoupers");
                });
#pragma warning restore 612, 618
        }
    }
}