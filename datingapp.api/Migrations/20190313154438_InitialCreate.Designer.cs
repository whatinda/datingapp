﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using datingapp.api.Data;

namespace datingapp.api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190313154438_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("datingapp.api.models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
