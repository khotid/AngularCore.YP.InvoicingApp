export class CustomerModel {
  customerID: number;
  customerName: string;
  address: string;
  gstin: string;
  phone: string;
  eMail: string;
  pan: string;
  tin: string;
  vendorID: number;
}
/*
    [Key]
    public int CustomerID { get; set; }
  [Required]
  [MaxLength(100)]
        public string CustomerName { get; set; }
  [Required]
  [MaxLength(500)]
        public string Address { get; set; }
  [Required]
  [MaxLength(20)]
        public string GSTIN { get; set; }
  [MaxLength(13)]
        public string Phone { get; set; }
  [MaxLength(100)]
        public string EMail { get; set; }
  [MaxLength(10)]
        public string PAN { get; set; }
  [MaxLength(20)]
        public string TIN { get; set; }
  [Required]
        public int VendorID { get; set; }
*/
