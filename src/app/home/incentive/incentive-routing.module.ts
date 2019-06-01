import { ArrearPaymentManualComponent } from './arrear-payment-manual/arrear-payment-manual.component';
import { ArrearPaymentAutoComponent } from './arrear-payment-auto/arrear-payment-auto.component';
import { LeavePaymentComponent } from './leave-payment/leave-payment.component';
import { LeaveTypeSetupComponent } from './leave-type-setup/leave-type-setup.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LeaveAmountSetupComponent } from './leave-amount-setup/leave-amount-setup.component';
import { SalesCommissionComponent } from './sales-commission/sales-commission.component';
import { EncashmentPaymentComponent } from './encashment-payment/encashment-payment.component';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
        {path: 'leave-type-setup', component: LeaveTypeSetupComponent},
        {path: 'leave-amount-setup', component: LeaveAmountSetupComponent},
        {path: 'leave-payment', component: LeavePaymentComponent},
        {path: 'sales-commission', component: SalesCommissionComponent},
        {path: 'encashment-payment', component: EncashmentPaymentComponent},
        {path: 'arrear-payment-auto', component: ArrearPaymentAutoComponent},
        {path: 'arrear-payment-manual', component: ArrearPaymentManualComponent}
    ]),
    CommonModule
  ],
  exports: [RouterModule]
})
export class IncentiveRoutingModule { }
