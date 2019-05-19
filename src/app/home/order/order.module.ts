
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SweetAlert2Module } from '@toverux/ngx-sweetalert2';
import { NgSelectModule } from '@ng-select/ng-select';
import { OrderRoutingModule } from './order-routing.module';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { LaddaModule } from 'angular2-ladda';
import { BlockUIModule } from 'ng-block-ui';
import { OrderPlaceComponent } from './order-place/order-place.component';
import { OrderListComponent } from './order-list/order-list.component';
import { OrderApprovalComponent } from './order-approval/order-approval.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    SweetAlert2Module,
    LaddaModule,
    BlockUIModule,
    NgSelectModule,
    NgxDatatableModule,
    OrderRoutingModule
  ],
  declarations: [
    OrderPlaceComponent,
    OrderListComponent,
    OrderApprovalComponent
  ],
})
export class OrderModule { }
