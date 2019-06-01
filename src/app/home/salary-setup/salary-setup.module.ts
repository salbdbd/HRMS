import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OtherAllowanceComponent } from './other-allowance/other-allowance.component';
import { SalarySetupRoutingModule } from './salary-setup-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { SalaryYearSetupComponent } from './salary-year-setup/salary-year-setup.component';
import { SalaryPeriodComponent } from './salary-period/salary-period.component';
import { SalaryHeadComponent } from './salary-head/salary-head.component';
import { SalaryGradeComponent } from './salary-grade/salary-grade.component';
import { PayscaleGradeComponent } from './payscale-grade/payscale-grade.component';
import { PayscalSetupComponent } from './payscal-setup/payscal-setup.component';

@NgModule({
  declarations: [
    OtherAllowanceComponent,
    SalaryYearSetupComponent,
    SalaryPeriodComponent,
    SalaryHeadComponent,
    SalaryGradeComponent,
    PayscaleGradeComponent,
    PayscalSetupComponent
  ],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    SalarySetupRoutingModule
  ]
})
export class SalarySetupModule { }
