import { DeductionRoutingModule } from './deduction-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SalaryDeductComponent } from './salary-deduct/salary-deduct.component';
import { LoanDeductComponent } from './loan-deduct/loan-deduct.component';
import { LwpDeductComponent } from './lwp-deduct/lwp-deduct.component';
import { OtherDeductComponent } from './other-deduct/other-deduct.component';
import { ImportDeductionComponent } from './import-deduction/import-deduction.component';

@NgModule({
  declarations: [SalaryDeductComponent, LoanDeductComponent, LwpDeductComponent, OtherDeductComponent, ImportDeductionComponent],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    DeductionRoutingModule
  ]
})
export class DeductionModule { }
