﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VRBike.Data;

#nullable disable

namespace VRBike.Migrations
{
    [DbContext(typeof(VRBikeContext))]
    [Migration("20230907182650_SmallFix")]
    partial class SmallFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VRBike.Models.Bikeapp", b =>
                {
                    b.Property<int>("BikeappID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BikeappID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TourCollectionID")
                        .HasColumnType("int");

                    b.Property<int>("TourID")
                        .HasColumnType("int");

                    b.HasKey("BikeappID");

                    b.HasIndex("TourCollectionID");

                    b.HasIndex("TourID");

                    b.ToTable("Bikeapp", (string)null);
                });

            modelBuilder.Entity("VRBike.Models.Tour", b =>
                {
                    b.Property<int>("TourID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Difficulty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discesa")
                        .HasColumnType("int");

                    b.Property<int>("Distanza")
                        .HasColumnType("int");

                    b.Property<string>("GeoJsonFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapZoom")
                        .HasColumnType("int");

                    b.Property<string>("PageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percorso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raccolta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Risorse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salita")
                        .HasColumnType("int");

                    b.Property<int>("TourCollectionID")
                        .HasColumnType("int");

                    b.Property<string>("TumbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourID");

                    b.HasIndex("TourCollectionID");

                    b.ToTable("Tour", (string)null);
                });

            modelBuilder.Entity("VRBike.Models.TourCollection", b =>
                {
                    b.Property<int>("TourCollectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourCollectionID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percorso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raccolta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Risorse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourCollectionID");

                    b.ToTable("ToursCollection", (string)null);
                });

            modelBuilder.Entity("VRBike.Models.TourMarker", b =>
                {
                    b.Property<int>("TourMarkerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourMarkerID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Classname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Html")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tooltip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TourID")
                        .HasColumnType("int");

                    b.HasKey("TourMarkerID");

                    b.HasIndex("TourID");

                    b.ToTable("TourMarker", (string)null);
                });

            modelBuilder.Entity("VRBike.Models.Video", b =>
                {
                    b.Property<int>("VideoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VideoID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TourCollectionID")
                        .HasColumnType("int");

                    b.Property<int>("TourID")
                        .HasColumnType("int");

                    b.HasKey("VideoID");

                    b.HasIndex("TourCollectionID");

                    b.HasIndex("TourID");

                    b.ToTable("Video", (string)null);
                });

            modelBuilder.Entity("VRBike.Models.Bikeapp", b =>
                {
                    b.HasOne("VRBike.Models.TourCollection", null)
                        .WithMany("Bikeapps")
                        .HasForeignKey("TourCollectionID");

                    b.HasOne("VRBike.Models.Tour", null)
                        .WithMany("Bikeapps")
                        .HasForeignKey("TourID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VRBike.Models.Tour", b =>
                {
                    b.HasOne("VRBike.Models.TourCollection", null)
                        .WithMany("Tours")
                        .HasForeignKey("TourCollectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VRBike.Models.TourMarker", b =>
                {
                    b.HasOne("VRBike.Models.Tour", null)
                        .WithMany("TourMarkers")
                        .HasForeignKey("TourID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VRBike.Models.Video", b =>
                {
                    b.HasOne("VRBike.Models.TourCollection", null)
                        .WithMany("Videos")
                        .HasForeignKey("TourCollectionID");

                    b.HasOne("VRBike.Models.Tour", null)
                        .WithMany("Videos")
                        .HasForeignKey("TourID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VRBike.Models.Tour", b =>
                {
                    b.Navigation("Bikeapps");

                    b.Navigation("TourMarkers");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("VRBike.Models.TourCollection", b =>
                {
                    b.Navigation("Bikeapps");

                    b.Navigation("Tours");

                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
