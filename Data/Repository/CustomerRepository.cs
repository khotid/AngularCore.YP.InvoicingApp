using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using AngularCore.YP.InvoicingApp.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private YPInvoiceAppDbContext _ctx;
        public CustomerRepository(YPInvoiceAppDbContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _ctx.Customers;
        }
        public Customer GetCustomer(int CustomerID) {
            return _ctx.Customers.Find(CustomerID);
        }

        public int AddEditCustomer(Customer Customer)
        {
            var cust = _ctx.Customers.Find(Customer.CustomerID);
            cust.Address = Customer.Address;
            cust.CustomerName = Customer.Address;
            cust.EMail = Customer.Address;
            cust.GSTIN = Customer.Address;
            cust.PAN = Customer.Address;
            cust.Phone = Customer.Address;
            cust.TIN = Customer.Address;
            if (Customer.CustomerID > 0)
                return _ctx.Customers.Update(cust).Entity.CustomerID; 
            else
                return _ctx.Customers.Add(cust).Entity.CustomerID;
            //cust.VendorID = Customer.Address;
        }
    }
}
