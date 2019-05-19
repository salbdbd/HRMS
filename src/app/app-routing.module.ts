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
  { path: 'module1', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/module1/module1.module#Module1Module' },
  { path: 'module2', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/module2/module2.module#Module2Module' },
  { path: 'module3', component: Layout2Component, canActivate: [HomeGuard], loadChildren: './home/module3/module3.module#Module3Module' },
  { path: 'error', component: AppErrorComponent },
  { path: '**', component: NoPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
