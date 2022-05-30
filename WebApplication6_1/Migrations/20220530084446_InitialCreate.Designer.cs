﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication6_1.Data;

#nullable disable

namespace WebApplication6_1.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220530084446_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("WebApplication6_1.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebApplication6_1.Models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("readerTicketsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("readerTicketsId");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("WebApplication6_1.Models.ReaderTickets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ReadersTickets");
                });

            modelBuilder.Entity("WebApplication6_1.Models.Reader", b =>
                {
                    b.HasOne("WebApplication6_1.Models.ReaderTickets", "readerTickets")
                        .WithMany()
                        .HasForeignKey("readerTicketsId");

                    b.Navigation("readerTickets");
                });
#pragma warning restore 612, 618
        }
    }
}