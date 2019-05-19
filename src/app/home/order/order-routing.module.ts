import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OrderPlaceComponent } from './order-place/order-place.component';
import { OrderListComponent } from './order-list/order-list.component';
import { OrderApprovalComponent } from './order-approval/order-approval.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'order-place', component: OrderPlaceComponent },
    { path: 'order-list', component: OrderListComponent },
    { path: 'order-approval', component: OrderApprovalComponent },
  ])],
  exports: [RouterModule]
})
export class OrderRoutingModule { }
