import { Component } from '@angular/core';
import { HttpService } from '../shared/services/http-service.service';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  public customers: any;

  constructor(private _http: HttpService) {
  }

  public incrementCounter() {
    this.currentCount++;
    this.getData();
  }
  getData() {
    this._http.get("api/customer/GetCustomers")
      .subscribe(
        data => console.log(data),
        err => console.log(err)

      );

  }
}
