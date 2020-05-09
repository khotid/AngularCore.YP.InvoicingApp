using AngularCore.YP.InvoicingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Domain.Interfaces
{
    public interface IVendorRepository
    {
        Vendor GetVendor(int id);
    }
}
