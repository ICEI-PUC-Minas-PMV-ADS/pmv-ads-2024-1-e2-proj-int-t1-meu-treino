﻿// <auto-generated />
using BackEndMeutreino.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEndMeutreino.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240417033343_First-Migration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BackEndMeutreino.Models.Avaliacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("avaliacao")
                        .HasColumnType("integer")
                        .HasColumnName("avaliacao");

                    b.Property<int>("idExercicio")
                        .HasColumnType("integer")
                        .HasColumnName("id_exercicio");

                    b.Property<int>("idUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("id_usuario");

                    b.HasKey("id");

                    b.HasIndex("idExercicio");

                    b.HasIndex("idUsuario");

                    b.ToTable("avaliacao", (string)null);
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Exercicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<int>("dificuldade")
                        .HasColumnType("integer")
                        .HasColumnName("dificuldade");

                    b.Property<string>("grupoMuscular")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("grupoMuscular");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("exercicio", (string)null);
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Favoritos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("idExercicio")
                        .HasColumnType("integer")
                        .HasColumnName("id_exercicio");

                    b.Property<int>("idUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("id_usuario");

                    b.HasKey("id");

                    b.HasIndex("idExercicio");

                    b.HasIndex("idUsuario");

                    b.ToTable("favoritos", (string)null);
                });

            modelBuilder.Entity("BackEndMeutreino.Models.HistoricoPeso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data");

                    b.Property<int>("idUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("id_usuario");

                    b.Property<double>("peso")
                        .HasColumnType("double precision")
                        .HasColumnName("peso");

                    b.HasKey("id");

                    b.HasIndex("idUsuario");

                    b.ToTable("historicoPeso", (string)null);
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<double>("altura")
                        .HasColumnType("double precision")
                        .HasColumnName("altura");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<double>("peso")
                        .HasColumnType("double precision")
                        .HasColumnName("peso");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senha");

                    b.HasKey("id");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Avaliacao", b =>
                {
                    b.HasOne("BackEndMeutreino.Models.Exercicio", "exercicio")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("idExercicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEndMeutreino.Models.Usuario", "usuario")
                        .WithMany("Avaliacao")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exercicio");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Favoritos", b =>
                {
                    b.HasOne("BackEndMeutreino.Models.Exercicio", "exercicio")
                        .WithMany("Favoritos")
                        .HasForeignKey("idExercicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEndMeutreino.Models.Usuario", "usuario")
                        .WithMany("Favoritos")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exercicio");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("BackEndMeutreino.Models.HistoricoPeso", b =>
                {
                    b.HasOne("BackEndMeutreino.Models.Usuario", "usuario")
                        .WithMany("HistoricoPeso")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Exercicio", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Favoritos");
                });

            modelBuilder.Entity("BackEndMeutreino.Models.Usuario", b =>
                {
                    b.Navigation("Avaliacao");

                    b.Navigation("Favoritos");

                    b.Navigation("HistoricoPeso");
                });
#pragma warning restore 612, 618
        }
    }
}
