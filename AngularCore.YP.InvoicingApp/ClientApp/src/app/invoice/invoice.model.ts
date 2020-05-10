import { CustomerModel } from "../customer/customer";
export class InvoiceHeader {
    constructor(){
        this.invoiceDetails=[];
    }
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
    constructor(){        
    }
    invoiceDetailID: number=-1;
    hsnNo: string;
    po: string;
    description: string;
    wgTrate: string;
    rate:number;
    amount: number;
    gstPercentage: number;
    cgst: number=9;
    sgst: number=9;
    invoiceHeaderID: number;
    created: Date;
    updated: Date;
}