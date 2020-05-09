using AngularCore.YP.InvoicingApp.Application.Interfaces;
using AngularCore.YP.InvoicingApp.Application.ViewModels;
using AngularCore.YP.InvoicingApp.Domain.Interfaces;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularCore.YP.InvoicingApp.Application.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo) {
            _repo = repo;
        }

        public int AddEditCustomer(CustomerViewModel Customer)
        {
           return  _repo.AddEditCustomer(Customer.Customer);
           
        }

        public CustomerViewModel GetCustomer(int CustomerID)
        {
            CustomerViewModel _VM = new CustomerViewModel();
            _VM.Customer = _repo.GetCustomer(CustomerID);
            return _VM;
        }

        public CustomersViewModel GetCustomers()
        {
            CustomersViewModel _VM = new CustomersViewModel();
            _VM.Customers = _repo.GetCustomers();
            return _VM;
        }
    }
}
