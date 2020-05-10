using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using AngularCore.YP.InvoicingApp.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private YPInvoiceAppDbContext _ctx;
        public InvoiceRepository(YPInvoiceAppDbContext ctx)
        {
            _ctx = ctx;
        }
        public InvoiceHeader GetInvoiceDetail(int InvoiceHeaderID)
        {
            var invoice = _ctx.InvoiceHeaders.Find(InvoiceHeaderID);
            _ctx.Entry(invoice).Reference(inv => inv.Customer).Load();
            _ctx.Entry(invoice).Collection(inv => inv.InvoiceDetails).Load();
            return invoice;
        }

        public IEnumerable<InvoiceHeader> GetInvoices(int PageNumber, int PageSize, out int TotalRecords)
        {
            TotalRecords = _ctx.InvoiceHeaders.Count();
            if (TotalRecords > ((PageNumber - 1) * PageSize))
                return _ctx.InvoiceHeaders.OrderBy(inv => inv.Created).Skip((PageNumber - 1) * PageSize).Take(PageSize).AsEnumerable();
            else
                return null;
        }

        public int SaveInvoice(InvoiceHeader invoice)
        {
            if (invoice.InvoiceHeaderID > 0)
            {
                invoice.Updated = DateTime.Now;
                return _ctx.InvoiceHeaders.Update(invoice).Entity.InvoiceHeaderID;
            }
            else
            {
                invoice.Created = DateTime.Now;
                return _ctx.InvoiceHeaders.Add(invoice).Entity.InvoiceHeaderID;
            }
        }
    }
}
