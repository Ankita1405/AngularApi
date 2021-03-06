﻿// <auto-generated />
using System;
using CustomerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerApi.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20200410065306_firstmig")]
    partial class firstmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerApi.Models.Customer", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDob")
                        .HasColumnType("datetime2");

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CPIN")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.HasKey("CId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CId = 1,
                            CDob = new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CName = "sam",
                            CPIN = 1234
                        },
                        new
                        {
                            CId = 2,
                            CDob = new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CName = "sami",
                            CPIN = 4562
                        },
                        new
                        {
                            CId = 3,
                            CDob = new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CName = "sameer",
                            CPIN = 7894
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
