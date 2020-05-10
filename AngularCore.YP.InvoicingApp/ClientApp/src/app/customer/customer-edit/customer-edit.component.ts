import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CustomerModel } from '../customer';
import { HttpService } from '../../shared/services/http-service.service';


@Component({
  selector: 'app-customer-edit',
  templateUrl: './customer-edit.component.html',
  styleUrls: ['./customer-edit.component.css']
})
export class CustomerEditComponent implements OnInit {
  constructor(private route: ActivatedRoute, private _http: HttpService) { }
  customerID;
  customer: CustomerModel = new CustomerModel();

  ngOnInit() {
    this.customerID = this.route.snapshot.paramMap.get("id");
    this.getCustomerDetails();
  }
  getCustomerDetails() {
    this._http.get("api/customer/customer/"+this.customerID)
      .subscribe(
        data => {
          this.customer = <CustomerModel>data["customer"];
          console.log(this.customer);
        },
        err => console.log(err)

      );
  }
  customerSave(){
    this._http.post("api/customer/AddEditCustomer",this.customer)
      .subscribe(
        data => {
          const response = <CustomerModel>data["customer"];
          console.log(response);
        },
        err => console.log(err)

      );
  }
}
