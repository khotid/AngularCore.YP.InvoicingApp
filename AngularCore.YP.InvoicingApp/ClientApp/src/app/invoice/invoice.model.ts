import { CustomerModel } from "../customer/customer";
export class InvoiceHeader {
    invoiceHeaderID: number;
    invoiceNumber: string;
    customer: CustomerModel;
    customerID: number;
    invoiceDetails: InvoiceDetail[];
    invoiceAmount: number;
    cgst: number;
    sgst: number;
    created: Date;
    updated: Date;
}
export class InvoiceDetail {
    invoiceDetailID: number;
    hsnNo: string;
    po: string;
    description: string;
    wgTrate: string;
    Amount: number;
    gstPercentage: number;
    cgst: number;
    sgst: number;
    invoiceHeaderID: number;
    created: Date;
    updated: Date;
}