import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { CostHeadComponent } from './cost-head/cost-head.component';
import { GlIntegrationRoutingModule } from './gl-integration-routing.module';
import { GlCodeComponent } from './gl-code/gl-code.component';
import { SalaryHeadAssignComponent } from './salary-head-assign/salary-head-assign.component';
import { GlReportComponent } from './gl-report/gl-report.component';

@NgModule({
  declarations: [
  CostHeadComponent,
  GlCodeComponent,
  SalaryHeadAssignComponent,
  GlReportComponent
],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    GlIntegrationRoutingModule
  ]
})
export class GlIntegrationModule { }
