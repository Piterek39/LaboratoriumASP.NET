﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostData;

#nullable disable

namespace PostData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("PostData.Entities.PostEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("postdate");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Autor = "adam@wsei.edu.pl",
                            Comment = "ciekawy post",
                            Content = "Pierwszy post",
                            PostDate = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "#pierwszypost"
                        },
                        new
                        {
                            Id = 2,
                            Autor = "elon@wsei.edu.pl",
                            Comment = "nudny post",
                            Content = "Drugi post",
                            PostDate = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "#drugipost"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
