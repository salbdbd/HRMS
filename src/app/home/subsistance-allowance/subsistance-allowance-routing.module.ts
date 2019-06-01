import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AllowanceReportComponent } from './allowance-report/allowance-report.component';
import { AllowanceManualComponent } from './allowance-manual/allowance-manual.component';
import { AllowanceAutoComponent } from './allowance-auto/allowance-auto.component';
import { AmountSetupComponent } from './amount-setup/amount-setup.component';




@NgModule({
  imports: [RouterModule.forChild([
   {path: 'amount-setup',component: AmountSetupComponent},
   {path: 'allowance-auto',component:AllowanceAutoComponent},
   { path: 'allowance-manual', component:AllowanceManualComponent },
   { path: 'allowance-report', component:AllowanceReportComponent }

  
  ])],
  exports: [RouterModule]
})
export class SubsistanceAllowanceRoutingModule { }
