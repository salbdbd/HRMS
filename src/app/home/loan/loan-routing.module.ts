
import { LoanInfoComponent } from './loan-info/loan-info.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CashReceiveComponent } from './cash-receive/cash-receive.component';
import { StopDeductionComponent } from './stop-deduction/stop-deduction.component';
import { LoanReportComponent } from './loan-report/loan-report.component';

@NgModule({
  declarations: [

  ],
  imports: [
    RouterModule.forChild([
      {path:'loan-info', component: LoanInfoComponent},
      {path:'cash-receive', component: CashReceiveComponent},
      {path:'stop-deduction', component: StopDeductionComponent},
      {path:'loan-report', component: LoanReportComponent},
    ]),
    CommonModule
  ]
})
export class LoanRoutingModule { }
