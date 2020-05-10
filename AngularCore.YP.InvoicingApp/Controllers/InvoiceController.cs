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
    public class InvoiceController : Controller
    {
        private IInvoiceService _service;
        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }
        [HttpPost("[action]")]
        public InvoicesViewModel List([FromBody]GetInvoiceViewModel param)
        {
            return _service.GetInvoices(param.PageNumber, param.PageSize);
        }
        [HttpGet("[action]/{InvoiceHeaderID}")]
        public InvoiceViewModel Detail([FromRoute]int InvoiceHeaderID)
        {
            return _service.GetInvoiceDetail(InvoiceHeaderID);
        }
        [HttpPost("[action]")]
        public int Save([FromBody]InvoiceViewModel invoice)
        {
            return _service.SaveInvoice(invoice);
        }
    }
}