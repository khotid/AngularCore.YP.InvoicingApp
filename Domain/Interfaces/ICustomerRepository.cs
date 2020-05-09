using AngularCore.YP.InvoicingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int CustomerID);
        int AddEditCustomer(Customer Customer);
    }
}
