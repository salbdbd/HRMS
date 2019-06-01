import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { ReportsRoutingModule } from './reports-routing.module';
import { SalaryReportComponent } from './salary-report/salary-report.component';
import { BankAdviceComponent } from './bank-advice/bank-advice.component';
import { SalaryReconciliationComponent } from './salary-reconciliation/salary-reconciliation.component';
import { SalarySummaryComponent } from './salary-summary/salary-summary.component';
import { BasicInformationComponent } from './basic-information/basic-information.component';
import { PayslipComponent } from './payslip/payslip.component';
import { EmployeeCvComponent } from './employee-cv/employee-cv.component';
import { ProvidentFundComponent } from './provident-fund/provident-fund.component';
import { FoodingOwnComponent } from './fooding-own/fooding-own.component';
import { InOutOwnComponent } from './in-out-own/in-out-own.component';
import { AssetUnderEmpComponent } from './asset-under-emp/asset-under-emp.component';
import { BankAccountComponent } from './bank-account/bank-account.component';
import { SalaryYearlyDetailComponent } from './salary-yearly-detail/salary-yearly-detail.component';
import { YearlySummaryComponent } from './yearly-summary/yearly-summary.component';
import { EmployeeLoanComponent } from './employee-loan/employee-loan.component';
import { SingleEmpSalaryComponent } from './single-emp-salary/single-emp-salary.component';
import { SingleEmpLeaveComponent } from './single-emp-leave/single-emp-leave.component';
import { SingleEmpIncrementComponent } from './single-emp-increment/single-emp-increment.component';
import { SingleEmpIncomeTaxComponent } from './single-emp-income-tax/single-emp-income-tax.component';

@NgModule({
  declarations: [
    SalaryReportComponent,
    BankAdviceComponent,
    SalaryReconciliationComponent,
    SalarySummaryComponent,
    BasicInformationComponent,
    PayslipComponent,
    EmployeeCvComponent,
    ProvidentFundComponent,
    FoodingOwnComponent,
    InOutOwnComponent,
    AssetUnderEmpComponent,
    BankAccountComponent,
    SalaryYearlyDetailComponent,
    YearlySummaryComponent,
    EmployeeLoanComponent,
    SingleEmpSalaryComponent,
    SingleEmpLeaveComponent,
    SingleEmpIncrementComponent,
    SingleEmpIncomeTaxComponent
  ],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    ReportsRoutingModule
  ]
})
export class ReportsModule { }
