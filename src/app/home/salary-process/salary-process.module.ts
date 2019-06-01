import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { SalaryProcessRoutingModule } from './salary-process-routing.module';
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
  declarations: [
  EnrolmentInformationComponent,
  AllowanceAddDeductComponent,
  ConfirmOrIncComponent,
  SalaryIncComponent,
  SalaryViewComponent,
  SalaryStructureComponent,
  EmpSalaryStructureComponent,
  EditEmpSalaryStructureComponent,
  SalaryProcessComponent,
  UndoSalaryProcessComponent,
  BlockSalaryProcessComponent,
  UpdateSalaryComponent,
  PaySlipEmailComponent,
  NewJoinComponent,
  ChangeReportComponent,
  ExtraSalaryComponent
],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    SalaryProcessRoutingModule
  ]
})
export class SalaryProcessModule { }
