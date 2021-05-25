﻿// <auto-generated />
using AndenSemesterProjekt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AndenSemesterProjekt.Migrations
{
    [DbContext(typeof(UsersdbContext))]
    [Migration("20210521092230_myFirstMigration")]
    partial class myFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AndenSemesterProjekt.Models.Admin", b =>
                {
                    b.Property<int>("adminID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasColumnName("adminID")
                        .IsFixedLength(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adminFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("adminLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("adminPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("adminUsername")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.HasKey("adminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.Attendant", b =>
                {
                    b.Property<string>("AttendantId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("AttendantID")
                        .IsFixedLength(true);

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AttendantId");

                    b.ToTable("Attendants");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.Driver", b =>
                {
                    b.Property<string>("DriverId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("DriverID")
                        .IsFixedLength(true);

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.PickupPoint", b =>
                {
                    b.Property<string>("PickupPointId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("PickupPointID")
                        .IsFixedLength(true);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("PickupTime")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.HasKey("PickupPointId");

                    b.ToTable("PickupPoints");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RouteID")
                        .IsFixedLength(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttendantId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("AttendantID")
                        .IsFixedLength(true);

                    b.Property<string>("DriverId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("DriverID")
                        .IsFixedLength(true);

                    b.Property<string>("EndAdress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("Eta")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ETA");

                    b.Property<string>("NrOfSeats")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("PickupPoints")
                        .HasColumnType("nchar")
                        .IsFixedLength(true);

                    b.Property<string>("StartAdress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.HasKey("RouteId");

                    b.HasIndex("AttendantId");

                    b.HasIndex("DriverId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .HasColumnName("UserID")
                        .IsFixedLength(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.Route", b =>
                {
                    b.HasOne("AndenSemesterProjekt.Models.Attendant", "Attendant")
                        .WithMany("Routes")
                        .HasForeignKey("AttendantId")
                        .HasConstraintName("FK__Routes__Attendan__2C3393D0");

                    b.HasOne("AndenSemesterProjekt.Models.Driver", "Driver")
                        .WithMany("Routes")
                        .HasForeignKey("DriverId")
                        .HasConstraintName("FK__Routes__DriverID__2B3F6F97");

                    b.Navigation("Attendant");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.Attendant", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("AndenSemesterProjekt.Models.Driver", b =>
                {
                    b.Navigation("Routes");
                });
#pragma warning restore 612, 618
        }
    }
}
