using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using AngularCore.YP.InvoicingApp.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Repository
{
    public class VendorRepository : IVendorRepository
    {
        private YPInvoiceAppDbContext _ctx;
        public VendorRepository(YPInvoiceAppDbContext context)
        {
            _ctx = context;
        }
        public Vendor GetVendor(int id)
        {
            return _ctx.Vendors.Find(id);
        }
    }
}
