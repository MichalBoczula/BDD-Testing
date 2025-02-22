﻿// <auto-generated />
using System;
using BDD.API.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BDD.API.Persistance.Migrations
{
    [DbContext(typeof(BddContext))]
    [Migration("20231225191032_AddedSeed")]
    partial class AddedSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BDD.API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Identifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Identifier = new Guid("ac11a00f-cdf0-4be4-b5b4-ddfbc7f2cb97"),
                            Name = "Order1"
                        },
                        new
                        {
                            Id = 2,
                            Identifier = new Guid("fd74bf90-59c6-40d6-a07c-5df3143a7c8e"),
                            Name = "Order2"
                        },
                        new
                        {
                            Id = 3,
                            Identifier = new Guid("79ecceae-9c19-4f42-9bc7-be8ecc83f70a"),
                            Name = "Order3"
                        });
                });

            modelBuilder.Entity("BDD.API.Models.OrderedProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderedProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 2,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            OrderId = 3,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 7,
                            OrderId = 3,
                            ProductId = 4
                        });
                });

            modelBuilder.Entity("BDD.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Prod1",
                            Price = 100
                        },
                        new
                        {
                            Id = 2,
                            Name = "Prod2",
                            Price = 200
                        },
                        new
                        {
                            Id = 3,
                            Name = "Prod3",
                            Price = 300
                        },
                        new
                        {
                            Id = 4,
                            Name = "Prod4",
                            Price = 400
                        });
                });

            modelBuilder.Entity("BDD.API.Models.OrderedProducts", b =>
                {
                    b.HasOne("BDD.API.Models.Order", "OrderRef")
                        .WithMany("OrderedProductsList")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDD.API.Models.Product", "ProductRef")
                        .WithMany("OrderedProductsList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderRef");

                    b.Navigation("ProductRef");
                });

            modelBuilder.Entity("BDD.API.Models.Order", b =>
                {
                    b.Navigation("OrderedProductsList");
                });

            modelBuilder.Entity("BDD.API.Models.Product", b =>
                {
                    b.Navigation("OrderedProductsList");
                });
#pragma warning restore 612, 618
        }
    }
}
