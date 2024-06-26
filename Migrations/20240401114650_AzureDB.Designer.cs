﻿// <auto-generated />
using KhumaloCraft.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KhumaloCraft.Migrations
{
    [DbContext(typeof(CraftDbContext))]
    [Migration("20240401114650_AzureDB")]
    partial class AzureDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KhumaloCraft.Entity.CraftDetailsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CraftCost")
                        .HasColumnType("float");

                    b.Property<string>("CraftData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CraftName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CraftDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
