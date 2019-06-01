import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AllowanceSetupComponent } from './allowance-setup/allowance-setup.component';
import { BonusSetupComponent } from './bonus-setup/bonus-setup.component';
import { EmpFestivalBonusComponent } from './emp-festival-bonus/emp-festival-bonus.component';
import { EmpPerformanceBonusComponent } from './emp-performance-bonus/emp-performance-bonus.component';
import { UpdateBonusComponent } from './update-bonus/update-bonus.component';
import { ProcessImportBonusComponent } from './process-import-bonus/process-import-bonus.component';
import { UploadEmpPaymentComponent } from './upload-emp-payment/upload-emp-payment.component';




@NgModule({
  imports: [RouterModule.forChild([
   // { path: 'emp-gen-info', component: EmpGenInfoComponent },
   {path: 'allowance-setup',component:AllowanceSetupComponent},
   {path:'bonus-setup',component:BonusSetupComponent},
   {path:'emp-festival-bonus',component: EmpFestivalBonusComponent},
   {path:'emp-performance-bonus',component:EmpPerformanceBonusComponent},
   {path:'update-bonus',component: UpdateBonusComponent},
   {path:'upload-emp-payment',component:UploadEmpPaymentComponent},
   {path:'process-import-bonus',component:ProcessImportBonusComponent}
  
  ])],
  exports: [RouterModule]
})
export class BonusRoutingModule { }
