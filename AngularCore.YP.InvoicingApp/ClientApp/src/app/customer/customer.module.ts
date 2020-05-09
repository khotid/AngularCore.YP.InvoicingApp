import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CustomersComponent } from './Customers.component';
import { CommonModule } from '@angular/common';
import {CustomerDetailsComponent  } from "./customer-details/customer-details.component";
export const routes: Routes = [
    { path: '', component: CustomersComponent },
    { path: 'details/:id', component: CustomerDetailsComponent },
    { path: 'edit/:id', component: CustomersComponent },
    { path: 'new', component: CustomersComponent }
]
@NgModule({
    imports: [
        RouterModule.forChild(routes),
        CommonModule
    ],
    exports: [],
    declarations: [CustomersComponent,CustomerDetailsComponent],
    providers: [],
})

export class CustomerModule { }
