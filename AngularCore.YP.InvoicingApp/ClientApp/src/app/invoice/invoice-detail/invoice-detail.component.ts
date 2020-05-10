import { Component, OnInit } from '@angular/core';
import { HttpService } from '../../shared/services/http-service.service';
import { ActivatedRoute } from '@angular/router';
import { InvoiceHeader } from '../invoice.model';

@Component({
  selector: 'app-invoice-detail',
  templateUrl: './invoice-detail.component.html',
  styleUrls: ['./invoice-detail.component.css']
})
export class InvoiceDetailComponent implements OnInit {
  _loadComplete: number = 1;
  constructor(private route: ActivatedRoute, private _http: HttpService) { }
  invoiceHeaderID: string;
  invoice:InvoiceHeader;
  ngOnInit() {
    this.invoiceHeaderID = this.route.snapshot.paramMap.get("id");
    this.getInvoice();
  }
  getInvoice() {
    this._http.get("api/invoice/detail/" + this.invoiceHeaderID)
      .subscribe(
        data => {
          this.invoice=data["invoice"];
          this._loadComplete--;
          console.log(data);
        },
        err => console.log(err)

      );
  }
}
