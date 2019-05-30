import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OvertimeSupervisorComponent } from './overtime-supervisor/overtime-supervisor.component';
import { ApplicationForOvertimeComponent } from './application-for-overtime/application-for-overtime.component';
import { OvertimeApproveByHrComponent } from './overtime-approve-by-hr/overtime-approve-by-hr.component';
import { OvertimeApproveComponent } from './overtime-approve/overtime-approve.component';
import { OtMethodComponent } from './ot-method/ot-method.component';
import { EntitleOverTimeComponent } from './entitle-over-time/entitle-over-time.component';
import { UpdateOverTimeAllowanceComponent } from './update-over-time-allowance/update-over-time-allowance.component';
import { AssignOverTimeRequisitionComponent } from './assign-over-time-requisition/assign-over-time-requisition.component';
import { UpdateOverTimeRequisitionComponent } from './update-over-time-requisition/update-over-time-requisition.component';
import { OverTimeReportComponent } from './over-time-report/over-time-report.component';
import { OverTimePaymentManualComponent } from './over-time-payment-manual/over-time-payment-manual.component';
import { OverTimePaymentAutoComponent } from './over-time-payment-auto/over-time-payment-auto.component';
import { OverTimeAutoComponent } from './over-time-auto/over-time-auto.component';
import { AssignOverTimeComponent } from './assign-over-time/assign-over-time.component';
import { OverTimeSetupComponent } from './over-time-setup/over-time-setup.component';
import { OverTimeConditionSetupComponent } from './over-time-condition-setup/over-time-condition-setup.component';
import { OverTimeRequisitionApproveComponent } from './over-time-requisition-approve/over-time-requisition-approve.component';
import { OverTimeMenualComponent } from './over-time-menual/over-time-menual.component';



@NgModule({
  imports: [RouterModule.forChild([
 { path: 'overtime-supervisor', component: OvertimeSupervisorComponent },
 {path:'application-for-overtime',component: ApplicationForOvertimeComponent},
 {path:'overtime-approve',component:OvertimeApproveComponent},
 {path:'overtime-approve-by-hr',component:OvertimeApproveByHrComponent},
 {path:'ot-method',component:OtMethodComponent},
 {path:'entitle-over-time',component:EntitleOverTimeComponent},
{path:'update-over-time-allowance',component:UpdateOverTimeAllowanceComponent},
{path:'assign-over-time-requisition',component:AssignOverTimeRequisitionComponent},

 {path:'update-over-time-requisition',component:UpdateOverTimeRequisitionComponent},
 {path:'over-time-requisition-approve',component: OverTimeRequisitionApproveComponent},
 {path:'Over-time-condition-setup',component:OverTimeConditionSetupComponent},
 {path:'Over-time-setup',component:OverTimeSetupComponent},
 {path:'assign-over-time',component:AssignOverTimeComponent},
 {path:'over-time-auto',component:OverTimeAutoComponent},
 {path:'over-time-menual',component:OverTimeMenualComponent},
 {path:'over-time-payment-auto',component: OverTimePaymentAutoComponent},
 {path:'over-time-payment-manual',component:  OverTimePaymentManualComponent},
 {path:'over-time-report',component: OverTimeReportComponent}
  ])],
  exports: [RouterModule]
})
export class OvertimeRoutingModule { }
