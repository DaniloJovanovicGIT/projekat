﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Data.Migrations
{
    [DbContext(typeof(FlightSystemContext))]
    [Migration("20240324154238_SeedCities")]
    partial class SeedCities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Backend.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Beograd"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Niš"
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Kraljevo"
                        },
                        new
                        {
                            CityId = 4,
                            Name = "Priština"
                        });
                });

            modelBuilder.Entity("Backend.Entities.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArrivalCityID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvailableSeatsCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartureCityID")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DepartureDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfConnections")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightId");

                    b.HasIndex("ArrivalCityID");

                    b.HasIndex("DepartureCityID");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Backend.Entities.Flight", b =>
                {
                    b.HasOne("Backend.Entities.City", "ArrivalCity")
                        .WithMany()
                        .HasForeignKey("ArrivalCityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Entities.City", "DepartureCity")
                        .WithMany()
                        .HasForeignKey("DepartureCityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArrivalCity");

                    b.Navigation("DepartureCity");
                });
#pragma warning restore 612, 618
        }
    }
}
