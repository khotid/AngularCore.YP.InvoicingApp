import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CustomersComponent } from './customers.component';
import { CommonModule } from '@angular/common';
import {CustomerDetailsComponent  } from "./customer-details/customer-details.component";
import { CustomerEditComponent } from './customer-edit/customer-edit.component';
import { FormsModule } from "@angular/forms";

export const routes: Routes = [
    { path: '', component: CustomersComponent },
    { path: 'details/:id', component: CustomerDetailsComponent },
    { path: 'edit/:id', component: CustomerEditComponent },
    { path: 'new', component: CustomersComponent }
]
@NgModule({
    imports: [
        RouterModule.forChild(routes),
        CommonModule,
        FormsModule
    ],
    exports: [],
    declarations: [ CustomerDetailsComponent,CustomerEditComponent,CustomersComponent],
    providers: [],
    bootstrap:[]
})

export class CustomerModule { }
