import { DriverBonusComponent } from './driver-bonus/driver-bonus.component';
import { EmployeeAllowanceComponent } from './employee-allowance/employee-allowance.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { DriverAllowanceComponent } from './driver-allowance/driver-allowance.component';
import { ImportAdditionComponent } from './import-addition/import-addition.component';
import { ProcessImportComponent } from './process-import/process-import.component';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
        {path: 'employee-allowance', component: EmployeeAllowanceComponent},
        {path: 'driver-allowance', component: DriverAllowanceComponent},
        {path: 'driver-bonus', component: DriverBonusComponent},
        {path: 'import-addition', component: ImportAdditionComponent},
        {path: 'process-import', component: ProcessImportComponent},
    ]),
    CommonModule
  ],
  exports: [RouterModule]
})
export class AdditionRoutingModule { }
