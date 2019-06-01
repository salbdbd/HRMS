import { HomeGuard } from './guards/home.guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { Layout2Component } from './layout/layout-2/layout-2.component';
import { LayoutBlankComponent } from './layout/layout-blank/layout-blank.component';

import { NoPageComponent } from './error/no-page/no-page.component';
import { AppErrorComponent } from './error/app-error/app-error.component';

const routes: Routes = [
  { path: '', component:  Layout2Component,  canActivate: [HomeGuard], loadChildren: './home/home.module#HomeModule' },
  { path: 'user', component: LayoutBlankComponent, loadChildren: './user/user.module#UserModule' },
  { path: 'property', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/property/property.module#PropertyModule' },
  { path: 'leave', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/leave/leave.module#LeaveModule' },
  { path: 'salary-setup', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/salary-setup/salary-setup.module#SalarySetupModule' },
  { path: 'salary-process', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/salary-process/salary-process.module#SalaryProcessModule' },
  { path: 'reports', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/reports/reports.module#ReportsModule' },
  { path: 'gl-integration', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/gl-integration/gl-integration.module#GlIntegrationModule' },
  { path: 'recruitment', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/recruitment/recruitment.module#RecruitmentModule' },
  { path: 'hr-menu', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/hr-menu/hr-menu.module#HrMenuModule' },
  { path: 'overtime', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/overtime/overtime.module#OvertimeModule' },
  { path: 'bonus', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/bonus/bonus.module#BonusModule' },
  { path: 'subsistance-allowance', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/subsistance-allowance/subsistance-allowance.module#SubsistanceAllowanceModule' },
  { path: 'income-tax', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/income-tax/income-tax.module#IncomeTaxModule' },
  { path: 'apprisal', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/apprisal/apprisal.module#ApprisalModule' },
  { path: 'apps', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/apps/apps.module#AppsModule' },
  { path: 'home', component: LayoutBlankComponent, loadChildren: './home/home.module#HomeModule' },
  { path: 'system-setup', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/system-setup/setup.module#SetupModule' },
  { path: 'system-setup/basic-entry', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/system-setup/basic-entry/basic-entry.module#BasicEntryModule' },
  { path: 'attendance', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/attendance/attendance.module#AttendanceModule' },
  { path: 'shift-allowance', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/shift-allowance/shift-allowance.module#ShiftAllowanceModule' },
  { path: 'disciplinary', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/disciplinary/disciplinary.module#DisciplinaryModule' },
  { path: 'loan', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/loan/loan.module#LoanModule' },
  { path: 'addition', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/addition/addition.module#AdditionModule' },
  { path: 'deduction', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/deduction/deduction.module#DeductionModule' },
  { path: 'incentive', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/incentive/incentive.module#IncentiveModule' },
  { path: 'settlement', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/settlement/settlement.module#SettlementModule' },
  { path: 'security', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/security/security.module#SecurityModule' },
  { path: 'tour', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/tour/tour.module#TourModule' },
  { path: 'error', component: AppErrorComponent },
  { path: '**', component: NoPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
