﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TennisDbLib;

namespace TennisDbLib.Migrations
{
    [DbContext(typeof(TennisContext))]
    partial class TennisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TennisDbLib.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("Hour")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("Week")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DayOfWeek = 1,
                            Hour = 12,
                            PersonId = 1,
                            Week = 22
                        },
                        new
                        {
                            Id = 2,
                            DayOfWeek = 4,
                            Hour = 12,
                            PersonId = 3,
                            Week = 22
                        },
                        new
                        {
                            Id = 3,
                            DayOfWeek = 2,
                            Hour = 14,
                            PersonId = 2,
                            Week = 22
                        },
                        new
                        {
                            Id = 4,
                            DayOfWeek = 2,
                            Hour = 11,
                            PersonId = 2,
                            Week = 22
                        });
                });

            modelBuilder.Entity("TennisDbLib.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 66,
                            Firstname = "Hans",
                            Lastname = "Huber"
                        },
                        new
                        {
                            Id = 2,
                            Age = 55,
                            Firstname = "Kurt",
                            Lastname = "Mayr"
                        },
                        new
                        {
                            Id = 3,
                            Age = 44,
                            Firstname = "Susi",
                            Lastname = "Berger"
                        });
                });

            modelBuilder.Entity("TennisDbLib.Booking", b =>
                {
                    b.HasOne("TennisDbLib.Person", "Person")
                        .WithMany("Bookings")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("TennisDbLib.Person", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
