import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SecurityRoutingModule } from './security-routing.module';
import { CreateUserComponent } from './create-user/create-user.component';
import { LogHistoryComponent } from './log-history/log-history.component';
import { AssignPageAccessComponent } from './assign-page-access/assign-page-access.component';
import { CreateUserTypeComponent } from './create-user-type/create-user-type.component';
import { CreateCompanyComponent } from './create-company/create-company.component';
import { ChangePasswordComponent } from './change-password/change-password.component';
import { LockUnlockSalaryComponent } from './lock-unlock-salary/lock-unlock-salary.component';
import { WebPortalPageAccessComponent } from './web-portal-page-access/web-portal-page-access.component';
import { AssignCompanyComponent } from './assign-company/assign-company.component';
import { AssignBranchComponent } from './assign-branch/assign-branch.component';
import { PasswordShowComponent } from './password-show/password-show.component';

@NgModule({
  declarations: [CreateUserComponent, LogHistoryComponent, AssignPageAccessComponent, CreateUserTypeComponent, CreateCompanyComponent, ChangePasswordComponent, LockUnlockSalaryComponent, WebPortalPageAccessComponent, AssignCompanyComponent, AssignBranchComponent, PasswordShowComponent],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    SecurityRoutingModule
  ]
})
export class SecurityModule { }
