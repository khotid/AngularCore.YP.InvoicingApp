using AngularCore.YP.InvoicingApp.Domain.Models;
using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class YPInvoiceAppDbContext : DbContext
    {
        public YPInvoiceAppDbContext(DbContextOptions options):base(options) { 
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
