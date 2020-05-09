using AngularCore.YP.InvoicingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.ViewModels
{
    public class CustomersViewModel
    {

        public IEnumerable<Customer> Customers { get; set; }
    }
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
    }
}
