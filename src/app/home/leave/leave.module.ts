import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LeaveRoutingModule } from './leave-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { LeaveSetupComponent } from './leave-setup/leave-setup.component';
import { LeaveEntryComponent } from './leave-entry/leave-entry.component';
import { ManualLeaveEntryComponent } from './manual-leave-entry/manual-leave-entry.component';
import { UpdateLeaveEntryComponent } from './update-leave-entry/update-leave-entry.component';
import { LeaveApprovalComponent } from './leave-approval/leave-approval.component';
import { LeaveApprovalByHrComponent } from './leave-approval-by-hr/leave-approval-by-hr.component';
import { EmpLeaveOpeningBalanceComponent } from './emp-leave-opening-balance/emp-leave-opening-balance.component';
import { LeaveCarryForwardComponent } from './leave-carry-forward/leave-carry-forward.component';
import { LeaveEncashmentComponent } from './leave-encashment/leave-encashment.component';
import { RecreationLeaveEncashmentComponent } from './recreation-leave-encashment/recreation-leave-encashment.component';
import { SubstituteLeaveComponent } from './substitute-leave/substitute-leave.component';
import { LeaveReportComponent } from './leave-report/leave-report.component';
import { LeaveInfoDetailsComponent } from './leave-info-details/leave-info-details.component';

@NgModule({
  declarations: [
    LeaveSetupComponent,
    LeaveEntryComponent,
    ManualLeaveEntryComponent,
    UpdateLeaveEntryComponent,
    LeaveApprovalComponent,
    LeaveApprovalByHrComponent,
    EmpLeaveOpeningBalanceComponent,
    LeaveCarryForwardComponent,
    LeaveEncashmentComponent,
    RecreationLeaveEncashmentComponent,
    SubstituteLeaveComponent,
    LeaveReportComponent,
    LeaveInfoDetailsComponent,
  ],
  imports: [
    CommonModule,
    CommonModule,
    LeaveRoutingModule,
    NgbModule,
    FormsModule
  ]
})
export class LeaveModule { }
