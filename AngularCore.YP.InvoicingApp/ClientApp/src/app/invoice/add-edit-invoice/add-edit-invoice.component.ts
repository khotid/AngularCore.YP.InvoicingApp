import { Component, OnInit } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpService } from '../../shared/services/http-service.service';
import { CustomerModel } from '../../customer/customer';
import { InvoiceHeader, InvoiceDetail } from '../invoice.model';

@Component({
  selector: 'app-add-edit-invoice',
  templateUrl: './add-edit-invoice.component.html',
  styleUrls: ['./add-edit-invoice.component.css']  
})
export class AddEditInvoiceComponent implements OnInit {
  _loadComplete:number = 1;
  invoice:InvoiceHeader=new InvoiceHeader();

  constructor(private _http: HttpService) {
    this.getCustomers();
  }
  customers: CustomerModel[];
  getCustomers() {
    this._http.get("api/customer/customers")
      .subscribe(
        data => {
          this.customers = <CustomerModel[]>data["customers"];
          this._loadComplete--;
          console.log(this.customers);
        },
        err => console.log(err)

      );
  }

  ngOnInit() {
  }
  addRow(){
    this.invoice.invoiceDetails.push(new InvoiceDetail());
  }

}
