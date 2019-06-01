import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
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
  imports: [RouterModule.forChild([
    { path: 'salary-report', component: SalaryReportComponent },
    { path: 'bank-advice', component: BankAdviceComponent },
    { path: 'salary-reconciliation', component: SalaryReconciliationComponent },
    { path: 'salary-summary', component: SalarySummaryComponent },
    { path: 'basic-information', component: BasicInformationComponent },
    { path: 'payslip', component: PayslipComponent },
    { path: 'employee-cv', component: EmployeeCvComponent },
    { path: 'provident-fund', component: ProvidentFundComponent },
    { path: 'fooding-own', component: FoodingOwnComponent },
    { path: 'in-out-own', component: InOutOwnComponent },
    { path: 'asset-under-emp', component: AssetUnderEmpComponent },
    { path: 'bank-account', component: BankAccountComponent },
    { path: 'salary-yearly-detail', component: SalaryYearlyDetailComponent },
    { path: 'yearly-summary', component: YearlySummaryComponent },
    { path: 'employee-loan', component: EmployeeLoanComponent },
    { path: 'single-emp-salary', component: SingleEmpSalaryComponent },
    { path: 'single-emp-leave', component: SingleEmpLeaveComponent },
    { path: 'single-emp-increment', component: SingleEmpIncrementComponent },
    { path: 'single-emp-income-tax', component: SingleEmpIncomeTaxComponent },

  ])],
  exports: [RouterModule]
})
export class ReportsRoutingModule { }
