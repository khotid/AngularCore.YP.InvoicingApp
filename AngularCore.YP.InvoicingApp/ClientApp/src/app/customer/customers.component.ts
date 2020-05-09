import { Component } from "@angular/core";
import { HttpService } from "../shared/services/http-service.service";
import { CustomerModel } from "./customer";

@Component({
  templateUrl: './customers.component.html',
  selector: 'app-customers'
})
export class CustomersComponent {
  constructor(private _http: HttpService) {
    this.getCustomers();
  }
  customers: CustomerModel[];
  getCustomers() {
    this._http.get("api/customer/customers")
      .subscribe(
        data => {
          this.customers = <CustomerModel[]>data["customers"];
          console.log(this.customers);
        },
        err => console.log(err)

      );

  }
}
