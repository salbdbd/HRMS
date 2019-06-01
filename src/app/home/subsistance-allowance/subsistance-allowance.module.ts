import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SubsistanceAllowanceRoutingModule } from './subsistance-allowance-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AmountSetupComponent } from './amount-setup/amount-setup.component';
import { AllowanceAutoComponent } from './allowance-auto/allowance-auto.component';
import { AllowanceManualComponent } from './allowance-manual/allowance-manual.component';
import { AllowanceReportComponent } from './allowance-report/allowance-report.component';

@NgModule({
  declarations: [
    
  AmountSetupComponent,
    
  AllowanceAutoComponent,
    
  AllowanceManualComponent,
    
  AllowanceReportComponent
],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    SubsistanceAllowanceRoutingModule
    
  ]
})
export class SubsistanceAllowanceModule { }
