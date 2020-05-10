using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AngularCore.YP.InvoicingApp.Domain.Models
{
    public class InvoiceHeader
    {

        [Key]
        public int InvoiceHeaderID { get; set; }
        [Required]
        [MaxLength(20)]
        public string InvoiceNumber { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? CGST { get; set; }
        public decimal? SGST { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
    public class InvoiceDetail
    {

        [Key]
        public int InvoiceDetailID { get; set; }
        [MaxLength(200)]
        public string HSNNo { get; set; }
        [MaxLength(200)]
        public string PO { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string WGTrate { get; set; }
        public decimal Amount { get; set; }
        public int GSTPercentage { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        [Required]
        public int InvoiceHeaderID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
