﻿// <auto-generated />
using System;
using API_01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_01.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210224031729_AjustesNoBancoDeDados")]
    partial class AjustesNoBancoDeDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API_01.Models.ContaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DataDoPagamento");

                    b.Property<DateTime>("DataDoVencimento");

                    b.Property<string>("NomeDoCredor")
                        .HasMaxLength(100);

                    b.Property<decimal>("ValorAPagar")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Conta");
                });
#pragma warning restore 612, 618
        }
    }
}