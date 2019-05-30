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
  { path: 'hr-menu', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/hr-menu/hr-menu.module#HrMenuModule' },
  { path: 'overtime', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/overtime/overtime.module#OvertimeModule' },
  { path: 'bonus', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/bonus/bonus.module#BonusModule' },
  { path: 'subsistance-allowance', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/subsistance-allowance/subsistance-allowance.module#SubsistanceAllowanceModule' },
  { path: 'income-tax', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/income-tax/income-tax.module#IncomeTaxModule' },
  { path: 'apprisal', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/apprisal/apprisal.module#ApprisalModule' },
  { path: 'apps', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/apps/apps.module#AppsModule' },
  { path: 'error', component: AppErrorComponent },
  { path: '**', component: NoPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
