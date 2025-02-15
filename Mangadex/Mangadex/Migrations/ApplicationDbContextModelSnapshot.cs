﻿// <auto-generated />
using System;
using Mangadex.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mangadex.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mangadex.Models.Manga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("PublicDate")
                        .HasColumnType("date");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mangas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Until the Gal and I Become a Married Couple",
                            ImageUrl = "https://mangadex.org/covers/cf7b7869-3d9a-4c4d-bd06-249eba113558/72abee3c-5cde-4a6c-bc34-0ea02a1f5148.png",
                            PublicDate = new DateOnly(1, 1, 1),
                            Rating = 8f,
                            Title = "Boku to GAL ga Fufu ni Narumade"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Gal Can’t Be Kind to Otaku!?",
                            ImageUrl = "https://mangadex.org/covers/ee96e2b7-9af2-4864-9656-649f4d3b6fec/61f990f0-103a-4967-ac64-01dc9938cb5c.jpg.512.jpg",
                            PublicDate = new DateOnly(1, 1, 1),
                            Rating = 8f,
                            Title = "Otaku ni Yasashii Gal wa Inai!?"
                        },
                        new
                        {
                            Id = 3,
                            Description = "My Dress-Up Darling",
                            ImageUrl = "https://mangadex.org/covers/aa6c76f7-5f5f-46b6-a800-911145f81b9b/426242c4-b281-4f19-bb79-c4e15ab6bb24.jpg.512.jpg",
                            PublicDate = new DateOnly(1, 1, 1),
                            Rating = 8f,
                            Title = "Sono Bisque Doll wa Koi o Suru"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
