import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShiftAllowanceRoutingModule } from './shift-allowance-routing.module';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SetupComponent } from './setup/setup.component';
import { AssignComponent } from './assign/assign.component';
import { AutoPaymentComponent } from './auto-payment/auto-payment.component';
import { ManualPaymentComponent } from './manual-payment/manual-payment.component';
import { ShiftAllowanceReportComponent } from './shift-allowance-report/shift-allowance-report.component';

@NgModule({
  declarations: [
    SetupComponent,
    AssignComponent,
    AutoPaymentComponent,
    ManualPaymentComponent,
    ShiftAllowanceReportComponent
  ],
  imports: [
    CommonModule,
    ShiftAllowanceRoutingModule,
    FormsModule,
    NgbModule
  ]
})
export class ShiftAllowanceModule { }
