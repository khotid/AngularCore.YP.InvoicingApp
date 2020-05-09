using AngularCore.YP.InvoicingApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.Interfaces
{
    public interface IVendorService
    {
        VendorViewModel GetVendor(int id);
    }
}
