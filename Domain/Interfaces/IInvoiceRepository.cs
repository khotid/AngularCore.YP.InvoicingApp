using AngularCore.YP.InvoicingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Domain.Interfaces
{
    public interface IInvoiceRepository
    {
        IEnumerable<InvoiceHeader> GetInvoices(int PageNumber, int PageSize, out int TotalRecords);
        InvoiceHeader GetInvoiceDetail(int InvoiceHeaderID);
        int SaveInvoice(InvoiceHeader invoice);
    }
}
