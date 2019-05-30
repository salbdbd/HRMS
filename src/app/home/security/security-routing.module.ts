import { PasswordShowComponent } from './password-show/password-show.component';
import { AssignBranchComponent } from './assign-branch/assign-branch.component';
import { AssignCompanyComponent } from './assign-company/assign-company.component';
import { WebPortalPageAccessComponent } from './web-portal-page-access/web-portal-page-access.component';
import { LockUnlockSalaryComponent } from './lock-unlock-salary/lock-unlock-salary.component';
import { ChangePasswordComponent } from './change-password/change-password.component';
import { CreateCompanyComponent } from './create-company/create-company.component';
import { CreateUserTypeComponent } from './create-user-type/create-user-type.component';
import { AssignPageAccessComponent } from './assign-page-access/assign-page-access.component';
import { CreateUserComponent } from './create-user/create-user.component';
import { RouterModule } from '@angular/router';
import { NgModule } from "@angular/core";
import { LogHistoryComponent } from './log-history/log-history.component';

@NgModule({
    declarations:[

    ],
    imports:[
        RouterModule.forChild([
            {path: 'create-user', component: CreateUserComponent},
            {path: 'create-user-type', component: CreateUserTypeComponent},
            {path: 'create-company', component: CreateCompanyComponent},
            {path: 'log-history', component: LogHistoryComponent},
            {path: 'assign-page-access', component: AssignPageAccessComponent},
            {path: 'change-password', component: ChangePasswordComponent},
            {path: 'lock-unlock-salary', component: LockUnlockSalaryComponent},
            {path: 'web-portal-page-access', component: WebPortalPageAccessComponent},
            {path: 'assign-company', component: AssignCompanyComponent},
            {path: 'assign-branch', component: AssignBranchComponent},
            {path: 'password-show', component: PasswordShowComponent},
        ])
    ],
    exports:[RouterModule]
})
export class SecurityRoutingModule{}