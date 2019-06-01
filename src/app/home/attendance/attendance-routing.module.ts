import { AssignShiftComponent } from './assign-shift/assign-shift.component';
import { MonthlyAttendanceComponent } from './monthly-attendance/monthly-attendance.component';
import { ManualAttendanceComponent } from './manual-attendance/manual-attendance.component';
import { DutyHoursSetupComponent } from './duty-hours-setup/duty-hours-setup.component';
import { WeekendUpdateComponent } from './weekend-update/weekend-update.component';
import { WeekendSetupComponent } from './weekend-setup/weekend-setup.component';
import { ApproveComponent } from './approve/approve.component';
import { ApplicationComponent } from './application/application.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ProcessAttendanceComponent } from './process-attendance/process-attendance.component';
import { SummeryComponent } from './summery/summery.component';
import { ShiftSetupComponent } from './shift-setup/shift-setup.component';
import { MonthlyDataProcessComponent } from './monthly-data-process/monthly-data-process.component';
import { ImportComponent } from './import/import.component';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
      {path: 'application', component: ApplicationComponent},
      {path: 'approve', component: ApproveComponent},
      {path: 'weekend-setup', component: WeekendSetupComponent},
      {path: 'weekend-update', component: WeekendUpdateComponent},
      {path: 'duty-hours-setup', component: DutyHoursSetupComponent},
      {path: 'manual-attendance', component: ManualAttendanceComponent},
      {path: 'monthly-attendance', component: MonthlyAttendanceComponent},
      {path: 'process-attendance', component: ProcessAttendanceComponent},
      {path: 'summery', component: SummeryComponent},
      {path: 'shift-setup', component: ShiftSetupComponent},
      {path: 'assign-shift', component: AssignShiftComponent},
      {path: 'monthly-data-process', component: MonthlyDataProcessComponent},
      {path: 'import', component: ImportComponent},
    ]),
    CommonModule
  ],
  exports: [RouterModule]
})
export class AttendanceRoutingModule { }
