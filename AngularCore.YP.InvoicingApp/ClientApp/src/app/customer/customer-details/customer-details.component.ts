import { Component, OnInit } from '@angular/core';
import { RouterState, Router, ActivatedRoute } from '@angular/router';
import { } from 'rxjs';
import { CustomerModel } from '../customer';
import { HttpService } from '../../shared/services/http-service.service';


@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.css']
})
export class CustomerDetailsComponent implements OnInit {

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
}
