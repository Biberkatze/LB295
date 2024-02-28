﻿// <auto-generated />
using System;
using LB295_Cedric.Controllers.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LB295Cedric.Migrations
{
    [DbContext(typeof(JetDb))]
    [Migration("20240228160432_DB")]
    partial class DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LB295_Cedric.Controllers.DataModel.ProductDataModel", b =>
                {
                    b.Property<Guid>("jet_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Erstflug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hersteller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modellname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jet_id");

                    b.ToTable("Jets");
                });
#pragma warning restore 612, 618
        }
    }
}
