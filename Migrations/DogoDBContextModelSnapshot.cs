﻿// <auto-generated />
using System;
using Dogo.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dogo.Migrations
{
    [DbContext(typeof(DogoDBContext))]
    partial class DogoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dogo.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFrom")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shelter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShelterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("Dogo.Models.Dog_Shelter", b =>
                {
                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<int>("ShelterId")
                        .HasColumnType("int");

                    b.HasKey("DogId", "ShelterId");

                    b.HasIndex("ShelterId");

                    b.ToTable("Dog_Shelter");
                });

            modelBuilder.Entity("Dogo.Models.Shelter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Decsription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shelter");
                });

            modelBuilder.Entity("Dogo.Models.Dog", b =>
                {
                    b.HasOne("Dogo.Models.Shelter", null)
                        .WithMany("Dogs")
                        .HasForeignKey("ShelterId");
                });

            modelBuilder.Entity("Dogo.Models.Dog_Shelter", b =>
                {
                    b.HasOne("Dogo.Models.Dog", "Dog")
                        .WithMany()
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dogo.Models.Shelter", "Shelter")
                        .WithMany()
                        .HasForeignKey("ShelterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("Dogo.Models.Shelter", b =>
                {
                    b.Navigation("Dogs");
                });
#pragma warning restore 612, 618
        }
    }
}
