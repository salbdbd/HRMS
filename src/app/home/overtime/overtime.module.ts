import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OvertimeRoutingModule } from './overtime-routing.module';
import { OvertimeSupervisorComponent } from './overtime-supervisor/overtime-supervisor.component';
import { ApplicationForOvertimeComponent } from './application-for-overtime/application-for-overtime.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { OvertimeApproveComponent } from './overtime-approve/overtime-approve.component';
import { OvertimeApproveByHrComponent } from './overtime-approve-by-hr/overtime-approve-by-hr.component';
import { OtMethodComponent } from './ot-method/ot-method.component';
import { EntitleOverTimeComponent } from './entitle-over-time/entitle-over-time.component';
import { UpdateOverTimeAllowanceComponent } from './update-over-time-allowance/update-over-time-allowance.component';
import { AssignOverTimeRequisitionComponent } from './assign-over-time-requisition/assign-over-time-requisition.component';
import { UpdateOverTimeRequisitionComponent } from './update-over-time-requisition/update-over-time-requisition.component';
import { OverTimeRequisitionApproveComponent } from './over-time-requisition-approve/over-time-requisition-approve.component';
import { OverTimeConditionSetupComponent } from './over-time-condition-setup/over-time-condition-setup.component';
import { OverTimeSetupComponent } from './over-time-setup/over-time-setup.component';
import { AssignOverTimeComponent } from './assign-over-time/assign-over-time.component';
import { OverTimeAutoComponent } from './over-time-auto/over-time-auto.component';
import { OverTimeMenualComponent } from './over-time-menual/over-time-menual.component';
import { OverTimePaymentAutoComponent } from './over-time-payment-auto/over-time-payment-auto.component';
import { OverTimePaymentManualComponent } from './over-time-payment-manual/over-time-payment-manual.component';
import { OverTimeReportComponent } from './over-time-report/over-time-report.component';

@NgModule({
  declarations: [
    OvertimeSupervisorComponent,
    ApplicationForOvertimeComponent,
    OvertimeApproveComponent,
    OvertimeApproveByHrComponent,
    OtMethodComponent,
    EntitleOverTimeComponent,
    UpdateOverTimeAllowanceComponent,
    AssignOverTimeRequisitionComponent,

    UpdateOverTimeRequisitionComponent,
    OverTimeRequisitionApproveComponent,
    OverTimeConditionSetupComponent,
    OverTimeSetupComponent,
    AssignOverTimeComponent,
    OverTimeAutoComponent,
    OverTimeMenualComponent,
    OverTimePaymentAutoComponent,
    OverTimePaymentManualComponent,
    OverTimeReportComponent
  ],
  imports: [
    CommonModule,
    OvertimeRoutingModule,
    NgbModule,
    FormsModule
  ]
})
export class OvertimeModule { }
