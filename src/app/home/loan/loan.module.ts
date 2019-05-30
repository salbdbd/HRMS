import { LoanRoutingModule } from './loan-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LoanInfoComponent } from './loan-info/loan-info.component';
import { CashReceiveComponent } from './cash-receive/cash-receive.component';
import { StopDeductionComponent } from './stop-deduction/stop-deduction.component';
import { LoanReportComponent } from './loan-report/loan-report.component';

@NgModule({
  declarations: [
    LoanInfoComponent,
    CashReceiveComponent,
    StopDeductionComponent,
    LoanReportComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    LoanRoutingModule
  ]
})
export class LoanModule { }
