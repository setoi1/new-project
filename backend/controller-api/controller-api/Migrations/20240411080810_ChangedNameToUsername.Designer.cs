﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using controller_api.Models;

#nullable disable

namespace controller_api.Migrations
{
    [DbContext(typeof(AutofastContext))]
    [Migration("20240411080810_ChangedNameToUsername")]
    partial class ChangedNameToUsername
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("controller_api.Models.Invoices", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<double>("Labor")
                        .HasColumnType("double precision");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("text");

                    b.Property<double>("Other")
                        .HasColumnType("double precision");

                    b.Property<double>("Parts")
                        .HasColumnType("double precision");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<double>("Profit")
                        .HasColumnType("double precision");

                    b.Property<double>("Tax")
                        .HasColumnType("double precision");

                    b.Property<double>("Total")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("controller_api.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
