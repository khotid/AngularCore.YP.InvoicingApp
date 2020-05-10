using AngularCore.YP.InvoicingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.ViewModels
{
    public class InvoicesViewModel
    {
        public IEnumerable<InvoiceHeader> Invoices;
        public int TotalRecords { get; set; }
    }
    public class InvoiceViewModel
    {
        public InvoiceHeader Invoice;
    }
    public class GetInvoiceViewModel {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
