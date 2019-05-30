import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BankBranchComponent } from './bank-branch/bank-branch.component';
import { SetupRoutingModule } from './setup-routing.module';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { ChartsModule as Ng2ChartsModule } from 'ng2-charts/ng2-charts';
import { DivisionComponent } from './division/division.component';
import { GroupComponent } from './group/group.component';
import { HolydayCalenderComponent } from './holyday-calender/holyday-calender.component';
import { AssignDeptGlComponent } from './assign-dept-gl/assign-dept-gl.component';
import { ProductionUnitComponent } from './production-unit/production-unit.component';
import { ProductionFloorComponent } from './production-floor/production-floor.component';
import { ProductionLineComponent } from './production-line/production-line.component';
import { ProductionMachineComponent } from './production-machine/production-machine.component';

@NgModule({
  imports: [
    CommonModule,
    CommonModule,
    FormsModule,
    NgbModule,
    Ng2ChartsModule,
    PerfectScrollbarModule,
    SetupRoutingModule
  ],
  declarations: [
    BankBranchComponent,
    DivisionComponent,
    GroupComponent,
    HolydayCalenderComponent,
    AssignDeptGlComponent,
    ProductionUnitComponent,
    ProductionFloorComponent,
    ProductionLineComponent,
    ProductionMachineComponent
  ]
})
export class SetupModule { }
