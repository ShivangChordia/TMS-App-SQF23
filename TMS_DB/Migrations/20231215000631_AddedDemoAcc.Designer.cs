﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMS_DB.Context;

#nullable disable

namespace TMS_DB.Migrations
{
    [DbContext(typeof(TMS_DB_Connect))]
    [Migration("20231215000631_AddedDemoAcc")]
    partial class AddedDemoAcc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TMS_DB.Model.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AdminDOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            AdminDOB = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AdminEmail = "admin1@example.com",
                            AdminName = "Admin1",
                            AdminPassword = "Password1",
                            AdminPhone = "1234567890"
                        },
                        new
                        {
                            AdminId = 2,
                            AdminDOB = new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AdminEmail = "admin2@example.com",
                            AdminName = "Admin2",
                            AdminPassword = "Password2",
                            AdminPhone = "2345678901"
                        },
                        new
                        {
                            AdminId = 3,
                            AdminDOB = new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AdminEmail = "admin3@example.com",
                            AdminName = "Admin3",
                            AdminPassword = "Password3",
                            AdminPhone = "7890123456"
                        });
                });

            modelBuilder.Entity("TMS_DB.Model.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BuyerDOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BuyerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("BuyerPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("BuyerPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("BuyerId");

                    b.ToTable("Buyer");

                    b.HasData(
                        new
                        {
                            BuyerId = 1,
                            BuyerDOB = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BuyerEmail = "Buyer1@example.com",
                            BuyerName = "Buyer1",
                            BuyerPassword = "Password1",
                            BuyerPhone = "1234567890"
                        },
                        new
                        {
                            BuyerId = 2,
                            BuyerDOB = new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BuyerEmail = "Buyer2@example.com",
                            BuyerName = "Buyer2",
                            BuyerPassword = "Password2",
                            BuyerPhone = "2345678901"
                        },
                        new
                        {
                            BuyerId = 3,
                            BuyerDOB = new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BuyerEmail = "Buyer3@example.com",
                            BuyerName = "Buyer3",
                            BuyerPassword = "Password3",
                            BuyerPhone = "7890123456"
                        });
                });

            modelBuilder.Entity("TMS_DB.Model.Carrier", b =>
                {
                    b.Property<int>("CarrierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CarrierID");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("TMS_DB.Model.ContractMarketplace", b =>
                {
                    b.Property<int>("MarketPlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MarketPlaceCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MarketPlaceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("MarketPlaceId");

                    b.ToTable("ContractMarketplace");
                });

            modelBuilder.Entity("TMS_DB.Model.Customer", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("UserDOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("UserId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("TMS_DB.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BuyerID")
                        .HasColumnType("int");

                    b.Property<bool>("InvoiceGenerated")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("OrderID");

                    b.HasIndex("BuyerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TMS_DB.Model.Planner", b =>
                {
                    b.Property<int>("PlannerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("PlannerDOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PlannerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PlannerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PlannerPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PlannerPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("PlannerId");

                    b.ToTable("Planner");

                    b.HasData(
                        new
                        {
                            PlannerId = 1,
                            PlannerDOB = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannerEmail = "Planner1@example.com",
                            PlannerName = "Planner1",
                            PlannerPassword = "Password1",
                            PlannerPhone = "1234567890"
                        },
                        new
                        {
                            PlannerId = 2,
                            PlannerDOB = new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannerEmail = "Planner2@example.com",
                            PlannerName = "Planner2",
                            PlannerPassword = "Password2",
                            PlannerPhone = "2345678901"
                        },
                        new
                        {
                            PlannerId = 3,
                            PlannerDOB = new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlannerEmail = "Planner3@example.com",
                            PlannerName = "Planner3",
                            PlannerPassword = "Password3",
                            PlannerPhone = "7890123456"
                        });
                });

            modelBuilder.Entity("TMS_DB.Model.RateFee", b =>
                {
                    b.Property<int>("RateFeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("FeeAmount")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("RateFeeID");

                    b.ToTable("RateFee");
                });

            modelBuilder.Entity("TMS_DB.Model.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("RouteID");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("TMS_DB.Model.Trips", b =>
                {
                    b.Property<int>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarrierID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("TripID");

                    b.HasIndex("CarrierID");

                    b.HasIndex("OrderID");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TMS_DB.Model.Order", b =>
                {
                    b.HasOne("TMS_DB.Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("BuyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("TMS_DB.Model.Trips", b =>
                {
                    b.HasOne("TMS_DB.Model.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("CarrierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS_DB.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrier");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
