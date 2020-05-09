using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCore.YP.InvoicingApp.Application.Interfaces;
using AngularCore.YP.InvoicingApp.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AngularCore.YP.InvoicingApp.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        [HttpGet("[action]")]
        public CustomersViewModel Customers()
        {
            return _service.GetCustomers();
        }
        [HttpGet("[action]/{CustomerID}")]
        public CustomerViewModel Customer(int CustomerID)
        {
            return _service.GetCustomer(CustomerID);
        }
        [HttpPost("[action]")]
        public int AddEditCustomer(CustomerViewModel customer)
        {
            return _service.AddEditCustomer(customer);
        }
    }
}
