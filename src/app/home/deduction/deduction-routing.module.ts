import { LoanDeductComponent } from './loan-deduct/loan-deduct.component';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SalaryDeductComponent } from './salary-deduct/salary-deduct.component';
import { LwpDeductComponent } from './lwp-deduct/lwp-deduct.component';
import { OtherDeductComponent } from './other-deduct/other-deduct.component';
import { ImportDeductionComponent } from './import-deduction/import-deduction.component';

@NgModule({
  declarations: [
  ],
  imports: [
    RouterModule.forChild([
        {path: 'salary-deduct', component: SalaryDeductComponent},
        {path: 'loan-deduct', component: LoanDeductComponent},
        {path: 'lwp-deduct', component: LwpDeductComponent},
        {path: 'other-deduct', component: OtherDeductComponent},
        {path: 'import-deduction', component: ImportDeductionComponent},
    ]),
    CommonModule
  ],
  exports:[RouterModule]
})
export class DeductionRoutingModule { }
