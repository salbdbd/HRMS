import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OtherAllowanceComponent } from './other-allowance/other-allowance.component';
import { SalaryYearSetupComponent } from './salary-year-setup/salary-year-setup.component';
import { SalaryPeriodComponent } from './salary-period/salary-period.component';
import { SalaryHeadComponent } from './salary-head/salary-head.component';
import { SalaryGradeComponent } from './salary-grade/salary-grade.component';
import { PayscaleGradeComponent } from './payscale-grade/payscale-grade.component';
import { PayscalSetupComponent } from './payscal-setup/payscal-setup.component';




@NgModule({
  imports: [RouterModule.forChild([
    { path: 'other-allowance', component: OtherAllowanceComponent },
    { path: 'salary-year-setup', component: SalaryYearSetupComponent },
    { path: 'salary-period', component:  SalaryPeriodComponent},
    { path: 'salary-head', component:  SalaryHeadComponent},
    { path: 'salary-grade', component:  SalaryGradeComponent},
    { path: 'payscale-grade', component:  PayscaleGradeComponent},
    { path: 'payscal-setup', component:  PayscalSetupComponent},
  ])],
  exports: [RouterModule]
})
export class SalarySetupRoutingModule { }
