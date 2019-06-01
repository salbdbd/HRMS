import { ArrearPaymentAutoComponent } from './arrear-payment-auto/arrear-payment-auto.component';

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { IncentiveRoutingModule } from './incentive-routing.module';
import { LeaveTypeSetupComponent } from './leave-type-setup/leave-type-setup.component';
import { LeaveAmountSetupComponent } from './leave-amount-setup/leave-amount-setup.component';
import { LeavePaymentComponent } from './leave-payment/leave-payment.component';
import { SalesCommissionComponent } from './sales-commission/sales-commission.component';
import { EncashmentPaymentComponent } from './encashment-payment/encashment-payment.component';
import { ArrearPaymentManualComponent } from './arrear-payment-manual/arrear-payment-manual.component';

@NgModule({
  declarations: [
    LeaveTypeSetupComponent,
    LeaveAmountSetupComponent,
    LeavePaymentComponent,
    SalesCommissionComponent,
    EncashmentPaymentComponent,
    ArrearPaymentAutoComponent,
    ArrearPaymentManualComponent,
    ],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    IncentiveRoutingModule
  ]
})
export class IncentiveModule { }
