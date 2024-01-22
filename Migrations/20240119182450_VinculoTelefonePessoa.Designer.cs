﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webAPI.Data;

#nullable disable

namespace webAPI.Migrations
{
    [DbContext(typeof(CadastroPessosasDBContex))]
    [Migration("20240119182450_VinculoTelefonePessoa")]
    partial class VinculoTelefonePessoa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webAPI.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PessoaID"));

                    b.Property<DateTime>("PessoaAniversario")
                        .HasMaxLength(12)
                        .HasColumnType("datetime2");

                    b.Property<string>("PessoaAtivo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("PessoaCPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("PessoaNome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PessoaID");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("webAPI.Models.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TelefoneId"));

                    b.Property<int>("PessoaID")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("TelefoneDescricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelefoneNumero")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("TelefoneId");

                    b.HasIndex("PessoaID");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("webAPI.Models.Telefone", b =>
                {
                    b.HasOne("webAPI.Models.Pessoa", "pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
