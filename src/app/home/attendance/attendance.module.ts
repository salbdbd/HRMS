import { FormsModule } from '@angular/forms';
import { AttendanceRoutingModule } from './attendance-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationComponent } from './application/application.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ApproveComponent } from './approve/approve.component';
import { WeekendSetupComponent } from './weekend-setup/weekend-setup.component';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { WeekendUpdateComponent } from './weekend-update/weekend-update.component';
import { DutyHoursSetupComponent } from './duty-hours-setup/duty-hours-setup.component';
import { ManualAttendanceComponent } from './manual-attendance/manual-attendance.component';
import { MonthlyAttendanceComponent } from './monthly-attendance/monthly-attendance.component';
import { ProcessAttendanceComponent } from './process-attendance/process-attendance.component';
import { SummeryComponent } from './summery/summery.component';
import { ShiftSetupComponent } from './shift-setup/shift-setup.component';
import { AssignShiftComponent } from './assign-shift/assign-shift.component';
import { MonthlyDataProcessComponent } from './monthly-data-process/monthly-data-process.component';
import { ImportComponent } from './import/import.component';

@NgModule({
  declarations: [
    ApplicationComponent,
    ApproveComponent,
    WeekendSetupComponent,
    WeekendUpdateComponent,
    DutyHoursSetupComponent,
    ManualAttendanceComponent,
    MonthlyAttendanceComponent,
    ProcessAttendanceComponent,
    SummeryComponent,
    ShiftSetupComponent,
    AssignShiftComponent,
    MonthlyDataProcessComponent,
    ImportComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    NgxDatatableModule,
    AttendanceRoutingModule
  ]
})
export class AttendanceModule { }
