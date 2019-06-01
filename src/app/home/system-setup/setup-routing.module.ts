import { ProductionFloorComponent } from './production-floor/production-floor.component';
import { AssignDeptGlComponent } from './assign-dept-gl/assign-dept-gl.component';

import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BankBranchComponent } from './bank-branch/bank-branch.component';
import { DivisionComponent } from './division/division.component';
import { GroupComponent } from './group/group.component';
import { HolydayCalenderComponent } from './holyday-calender/holyday-calender.component';
import { ProductionUnitComponent } from './production-unit/production-unit.component';
import { ProductionLineComponent } from './production-line/production-line.component';
import { ProductionMachineComponent } from './production-machine/production-machine.component';



@NgModule({
  imports: [RouterModule.forChild([
    { path: 'bank-branch', component: BankBranchComponent },
    { path: 'division', component: DivisionComponent },
    { path: 'group', component: GroupComponent },
    { path: 'holyday-calender', component: HolydayCalenderComponent },
    { path: 'assign-dept-gl', component: AssignDeptGlComponent },
    { path: 'production-unit', component: ProductionUnitComponent },
    { path: 'production-floor', component: ProductionFloorComponent },
    { path: 'production-line', component: ProductionLineComponent },
    { path: 'production-machine', component: ProductionMachineComponent }
  ])],

  exports: [RouterModule]
})
export class SetupRoutingModule { }
