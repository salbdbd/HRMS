import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { RecruitmentComponent } from './recruitment/recruitment.component';
import { RecruitmentApprovalComponent } from './recruitment-approval/recruitment-approval.component';
import { ApprovalByHrComponent } from './approval-by-hr/approval-by-hr.component';
import { ApprovalByAccountComponent } from './approval-by-account/approval-by-account.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'recruitment', component: RecruitmentComponent },
    { path: 'recruitment-approval', component: RecruitmentApprovalComponent },
    { path: 'approval-by-hr', component: ApprovalByHrComponent },
    { path: 'approval-by-account', component: ApprovalByAccountComponent },
 
  ])],
  exports: [RouterModule]
})
export class RecruitmentRoutingModule { }
