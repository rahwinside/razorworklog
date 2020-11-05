﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RazorWorklog.Migrations
{
    [DbContext(typeof(WorkContext))]
    [Migration("20201105183546_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("RazorWorklog.Models.Work", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Hours")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WorkDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Work");
                });
#pragma warning restore 612, 618
        }
    }
}
