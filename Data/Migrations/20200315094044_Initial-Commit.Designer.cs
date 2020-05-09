﻿// <auto-generated />
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Migrations
{
    [DbContext(typeof(YPInvoiceAppDbContext))]
    [Migration("20200315094044_Initial-Commit")]
    partial class InitialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("EMail")
                        .HasMaxLength(100);

                    b.Property<string>("GSTIN")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PAN")
                        .HasMaxLength(10);

                    b.Property<string>("Phone")
                        .HasMaxLength(13);

                    b.Property<string>("TIN")
                        .HasMaxLength(20);

                    b.Property<int>("VendorID");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CleanArch.Domain.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
