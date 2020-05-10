using AngularCore.YP.InvoicingApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.Interfaces
{
    public interface IInvoiceService
    {
        InvoicesViewModel GetInvoices(int PageNumber, int PageSize);
        InvoiceViewModel GetInvoiceDetail(int InvoiceHeaderID);
        int SaveInvoice(InvoiceViewModel Invoice);
    }
}
