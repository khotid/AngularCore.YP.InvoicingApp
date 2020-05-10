using AngularCore.YP.InvoicingApp.Application.Interfaces;
using AngularCore.YP.InvoicingApp.Application.ViewModels;
using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private IInvoiceRepository _repo;
        public InvoiceService(IInvoiceRepository repo)
        {
            _repo = repo;
        }
        public InvoiceViewModel GetInvoiceDetail(int InvoiceHeaderID)
        {
            return new InvoiceViewModel()
            {
                Invoice = _repo.GetInvoiceDetail(InvoiceHeaderID)
            };
        }

        public InvoicesViewModel GetInvoices(int PageNumber, int PageSize)
        {
            int TotalRecords = 0;
            var Invoices = _repo.GetInvoices(PageNumber, PageSize, out TotalRecords);
            return new InvoicesViewModel()
            {
                Invoices = Invoices,
                TotalRecords = TotalRecords
            };
        }

        public int SaveInvoice(InvoiceViewModel Invoice)
        {
            return _repo.SaveInvoice(Invoice.Invoice);
        }
    }
}
