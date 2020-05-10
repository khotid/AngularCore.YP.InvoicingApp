import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InvoiceListComponent } from './invoice-list/invoice-list.component';
import { InvoiceDetailComponent } from './invoice-detail/invoice-detail.component';
import { AddEditInvoiceComponent } from './add-edit-invoice/add-edit-invoice.component';

import { Routes, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

export const routes: Routes = [
  {
    path:'',
    component: InvoiceListComponent
  },
  {
    path:'add',
    component:AddEditInvoiceComponent
  },
  {
    path:'edit',
    component:AddEditInvoiceComponent
  },
  {
    path:"detail",
    component:InvoiceDetailComponent
  }
  
]
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    CommonModule,
    FormsModule
  ],
  declarations: [InvoiceListComponent, InvoiceDetailComponent, AddEditInvoiceComponent]
})
export class InvoiceModule { }
