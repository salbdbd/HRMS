import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { EnrolmentInformationComponent } from './enrolment-information/enrolment-information.component';
import { AllowanceAddDeductComponent } from './allowance-add-deduct/allowance-add-deduct.component';
import { ConfirmOrIncComponent } from './confirm-or-inc/confirm-or-inc.component';
import { SalaryIncComponent } from './salary-inc/salary-inc.component';
import { SalaryViewComponent } from './salary-view/salary-view.component';
import { SalaryStructureComponent } from './salary-structure/salary-structure.component';
import { EmpSalaryStructureComponent } from './emp-salary-structure/emp-salary-structure.component';
import { EditEmpSalaryStructureComponent } from './edit-emp-salary-structure/edit-emp-salary-structure.component';
import { SalaryProcessComponent } from './salary-process/salary-process.component';
import { UndoSalaryProcessComponent } from './undo-salary-process/undo-salary-process.component';
import { BlockSalaryProcessComponent } from './block-salary-process/block-salary-process.component';
import { UpdateSalaryComponent } from './update-salary/update-salary.component';
import { PaySlipEmailComponent } from './pay-slip-email/pay-slip-email.component';
import { NewJoinComponent } from './new-join/new-join.component';
import { ChangeReportComponent } from './change-report/change-report.component';
import { ExtraSalaryComponent } from './extra-salary/extra-salary.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'enrolment-information', component: EnrolmentInformationComponent },
    { path: 'allowance-add-deduct', component: AllowanceAddDeductComponent },
    { path: 'confirm-or-inc', component: ConfirmOrIncComponent },
    { path: 'salary-Inc', component: SalaryIncComponent },
    { path: 'salary-view', component: SalaryViewComponent },
    { path: 'salary-structure', component: SalaryStructureComponent },
    { path: 'emp-salary-structure', component: EmpSalaryStructureComponent },
    { path: 'edit-emp-salary-structure', component: EditEmpSalaryStructureComponent },
    { path: 'salary-process', component: SalaryProcessComponent },
    { path: 'undo-salary-process', component: UndoSalaryProcessComponent },
    { path: 'block-salary-process', component: BlockSalaryProcessComponent },
    { path: 'update-salary', component: UpdateSalaryComponent },
    { path: 'pay-slip-email', component: PaySlipEmailComponent },
    { path: 'new-join', component: NewJoinComponent },
    { path: 'change-report', component: ChangeReportComponent },
    { path: 'extra-salary', component: ExtraSalaryComponent },
  ])],
  exports: [RouterModule]
})
export class SalaryProcessRoutingModule { }
