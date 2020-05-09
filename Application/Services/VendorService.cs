using AngularCore.YP.InvoicingApp.Application.Interfaces;
using AngularCore.YP.InvoicingApp.Application.ViewModels;
using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.Services
{
    public class VendorService : IVendorService
    {
        IVendorRepository _repository;
        public VendorService(IVendorRepository repository)
        {
            _repository = repository;
        }
        public VendorViewModel GetVendor(int id)
        {
            return new VendorViewModel()
            {
                vendor = _repository.GetVendor(id)
            };

        }
    }
}
