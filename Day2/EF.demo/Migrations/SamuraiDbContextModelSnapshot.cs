﻿// <auto-generated />
using System;
using EF.demo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF.demo.Migrations
{
    [DbContext(typeof(SamuraiDbContext))]
    partial class SamuraiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("EF.demo.Model.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SamuraiId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("EF.demo.Model.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("EF.demo.Model.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EF.demo.Model.Battle", b =>
                {
                    b.HasOne("EF.demo.Model.Samurai", "Samurai")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiId");

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("EF.demo.Model.Quote", b =>
                {
                    b.HasOne("EF.demo.Model.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Samurai");
                });

            modelBuilder.Entity("EF.demo.Model.Samurai", b =>
                {
                    b.Navigation("Quotes");

                    b.Navigation("SamuraiBattles");
                });
#pragma warning restore 612, 618
        }
    }
}
