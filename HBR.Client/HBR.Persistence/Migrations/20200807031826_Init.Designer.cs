﻿// <auto-generated />
using System;
using HBR.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HBR.Persistence.Migrations
{
    [DbContext(typeof(HbrContext))]
    [Migration("20200807031826_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HBR.Persistence.Models.Categories", b =>
                {
                    b.Property<int>("id_Categories")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Categories");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HBR.Persistence.Models.Product", b =>
                {
                    b.Property<int>("id_Product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expiration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idCategoriesid_Categories")
                        .HasColumnType("int");

                    b.HasKey("id_Product");

                    b.HasIndex("idCategoriesid_Categories");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("HBR.Persistence.Models.Users", b =>
                {
                    b.Property<int>("id_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_User");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HBR.Persistence.Models.Product", b =>
                {
                    b.HasOne("HBR.Persistence.Models.Categories", "idCategories")
                        .WithMany("product")
                        .HasForeignKey("idCategoriesid_Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
