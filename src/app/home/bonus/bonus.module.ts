import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BonusRoutingModule } from './bonus-routing.module';
import { AllowanceSetupComponent } from './allowance-setup/allowance-setup.component';
import { BonusSetupComponent } from './bonus-setup/bonus-setup.component';
import { NgbModal, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { EmpFestivalBonusComponent } from './emp-festival-bonus/emp-festival-bonus.component';
import { EmpPerformanceBonusComponent } from './emp-performance-bonus/emp-performance-bonus.component';
import { UpdateBonusComponent } from './update-bonus/update-bonus.component';
import { UploadEmpPaymentComponent } from './upload-emp-payment/upload-emp-payment.component';
import { ProcessImportBonusComponent } from './process-import-bonus/process-import-bonus.component';

@NgModule({
  declarations: [

  AllowanceSetupComponent,

  BonusSetupComponent,

  EmpFestivalBonusComponent,

  EmpPerformanceBonusComponent,

  UpdateBonusComponent,

  UploadEmpPaymentComponent,

  ProcessImportBonusComponent
],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    BonusRoutingModule
  ]
})
export class BonusModule { }
