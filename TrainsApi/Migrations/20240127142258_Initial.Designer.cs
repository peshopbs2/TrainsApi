﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TrainsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240127142258_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeTrain", b =>
                {
                    b.Property<int>("BrigadeId")
                        .HasColumnType("int");

                    b.Property<int>("BrigadeTrainsId")
                        .HasColumnType("int");

                    b.HasKey("BrigadeId", "BrigadeTrainsId");

                    b.HasIndex("BrigadeTrainsId");

                    b.ToTable("TrainEmployeeBrigade", (string)null);
                });

            modelBuilder.Entity("EmployeeTrain1", b =>
                {
                    b.Property<int>("ConductorTrainsId")
                        .HasColumnType("int");

                    b.Property<int>("ConductorsId")
                        .HasColumnType("int");

                    b.HasKey("ConductorTrainsId", "ConductorsId");

                    b.HasIndex("ConductorsId");

                    b.ToTable("TrainEmployeeConductor", (string)null);
                });

            modelBuilder.Entity("LocomotiveTrain", b =>
                {
                    b.Property<int>("LocomotivesId")
                        .HasColumnType("int");

                    b.Property<int>("TrainsId")
                        .HasColumnType("int");

                    b.HasKey("LocomotivesId", "TrainsId");

                    b.HasIndex("TrainsId");

                    b.ToTable("LocomotiveTrain");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Locomotive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locomotive");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Timetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainId");

                    b.ToTable("Timetables");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.TimetableEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Arrive")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Depart")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("TimetableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("TimetableId");

                    b.ToTable("TimetableEntries");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Wagon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SittingCapacity")
                        .HasColumnType("int");

                    b.Property<int>("StandingCapacity")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Wagons");
                });

            modelBuilder.Entity("TrainWagon", b =>
                {
                    b.Property<int>("TrainsId")
                        .HasColumnType("int");

                    b.Property<int>("WagonsId")
                        .HasColumnType("int");

                    b.HasKey("TrainsId", "WagonsId");

                    b.HasIndex("WagonsId");

                    b.ToTable("TrainWagon");
                });

            modelBuilder.Entity("EmployeeTrain", b =>
                {
                    b.HasOne("TrainsApi.Data.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("BrigadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainsApi.Data.Entities.Train", null)
                        .WithMany()
                        .HasForeignKey("BrigadeTrainsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeTrain1", b =>
                {
                    b.HasOne("TrainsApi.Data.Entities.Train", null)
                        .WithMany()
                        .HasForeignKey("ConductorTrainsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainsApi.Data.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("ConductorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocomotiveTrain", b =>
                {
                    b.HasOne("TrainsApi.Data.Entities.Locomotive", null)
                        .WithMany()
                        .HasForeignKey("LocomotivesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainsApi.Data.Entities.Train", null)
                        .WithMany()
                        .HasForeignKey("TrainsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Timetable", b =>
                {
                    b.HasOne("TrainsApi.Data.Entities.Train", "Train")
                        .WithMany()
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Train");
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.TimetableEntry", b =>
                {
                    b.HasOne("TrainsApi.Data.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainsApi.Data.Entities.Timetable", "Timetable")
                        .WithMany("Entries")
                        .HasForeignKey("TimetableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Timetable");
                });

            modelBuilder.Entity("TrainWagon", b =>
                {
                    b.HasOne("TrainsApi.Data.Entities.Train", null)
                        .WithMany()
                        .HasForeignKey("TrainsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainsApi.Data.Entities.Wagon", null)
                        .WithMany()
                        .HasForeignKey("WagonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainsApi.Data.Entities.Timetable", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
