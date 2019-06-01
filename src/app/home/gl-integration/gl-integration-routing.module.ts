import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CostHeadComponent } from './cost-head/cost-head.component';
import { GlCodeComponent } from './gl-code/gl-code.component';
import { SalaryHeadAssignComponent } from './salary-head-assign/salary-head-assign.component';
import { GlReportComponent } from './gl-report/gl-report.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'cost-head', component: CostHeadComponent },
    { path: 'gl-code', component: GlCodeComponent },
    { path: 'salary-head-assign', component: SalaryHeadAssignComponent },
    { path: 'gl-report', component: GlReportComponent },


  ])],
  exports: [RouterModule]
})
export class GlIntegrationRoutingModule { }
