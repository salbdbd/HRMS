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
  { path: 'error', component: AppErrorComponent },
  { path: '**', component: NoPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
