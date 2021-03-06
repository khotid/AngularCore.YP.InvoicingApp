﻿// <auto-generated />
using System;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Migrations
{
    [DbContext(typeof(YPInvoiceAppDbContext))]
    [Migration("20200510053856_Added Invoice Entities")]
    partial class AddedInvoiceEntities
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

                    b.HasIndex("VendorID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("InvoiceDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<decimal>("CGST");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<int>("GSTPercentage");

                    b.Property<string>("HSNNo")
                        .HasMaxLength(200);

                    b.Property<int>("InvoiceHeaderID");

                    b.Property<string>("PO")
                        .HasMaxLength(200);

                    b.Property<decimal>("SGST");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("WGTrate")
                        .HasMaxLength(200);

                    b.HasKey("InvoiceDetailID");

                    b.HasIndex("InvoiceHeaderID");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.InvoiceHeader", b =>
                {
                    b.Property<int>("InvoiceHeaderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("CGST");

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerID");

                    b.Property<decimal?>("InvoiceAmount");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal?>("SGST");

                    b.Property<DateTime>("Updated");

                    b.HasKey("InvoiceHeaderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("InvoiceHeaders");
                });

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("BankAccountNo")
                        .HasMaxLength(20);

                    b.Property<string>("BankBranch")
                        .HasMaxLength(100);

                    b.Property<string>("BankIFSCCode")
                        .HasMaxLength(10);

                    b.Property<string>("EMail")
                        .HasMaxLength(100);

                    b.Property<string>("GSTIN")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PAN")
                        .HasMaxLength(10);

                    b.Property<string>("Phone")
                        .HasMaxLength(13);

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("VendorID");

                    b.ToTable("Vendors");
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

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.Customer", b =>
                {
                    b.HasOne("AngularCore.YP.InvoicingApp.Domain.Models.Vendor")
                        .WithMany("Customers")
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.InvoiceDetail", b =>
                {
                    b.HasOne("AngularCore.YP.InvoicingApp.Domain.Models.InvoiceHeader")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceHeaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngularCore.YP.InvoicingApp.Domain.Models.InvoiceHeader", b =>
                {
                    b.HasOne("AngularCore.YP.InvoicingApp.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
