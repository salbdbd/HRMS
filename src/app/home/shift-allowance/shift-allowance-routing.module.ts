import { ManualPaymentComponent } from './manual-payment/manual-payment.component';
import { AutoPaymentComponent } from './auto-payment/auto-payment.component';
import { AssignComponent } from './assign/assign.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SetupComponent } from './setup/setup.component';
import { ShiftAllowanceReportComponent } from './shift-allowance-report/shift-allowance-report.component';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
      {path: 'setup', component: SetupComponent },
      {path: 'assign', component: AssignComponent },
      {path: 'auto-payment', component: AutoPaymentComponent },
      {path: 'manual-payment', component: ManualPaymentComponent },
      {path: 'shift-allowance-report', component: ShiftAllowanceReportComponent }
    ]),
    CommonModule
  ]
})
export class ShiftAllowanceRoutingModule { }
