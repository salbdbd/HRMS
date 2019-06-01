import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { IncomeTaxRoutingModule } from './income-tax-routing.module';
import { TaxYearInfoComponent } from './tax-year-info/tax-year-info.component';
import { IncomeTaxSlabComponent } from './income-tax-slab/income-tax-slab.component';
import { IncomeTaxSetupComponent } from './income-tax-setup/income-tax-setup.component';
import { MinimumTaxSetupComponent } from './minimum-tax-setup/minimum-tax-setup.component';
import { SurchargeAssignComponent } from './surcharge-assign/surcharge-assign.component';
import { SearchChargeSetupComponent } from './search-charge-setup/search-charge-setup.component';
import { BlockTaxCalculationComponent } from './block-tax-calculation/block-tax-calculation.component';
import { TaxChallanComponent } from './tax-challan/tax-challan.component';
import { AdditionalTaxInfoComponent } from './additional-tax-info/additional-tax-info.component';
import { OtherTaxCalculationComponent } from './other-tax-calculation/other-tax-calculation.component';
import { ChallanPrepareComponent } from './challan-prepare/challan-prepare.component';
import { ChallanNumberAssignComponent } from './challan-number-assign/challan-number-assign.component';
import { TxtCardReportComponent } from './txt-card-report/txt-card-report.component';
import { TaxReportComponent } from './tax-report/tax-report.component';
import { TaxPaidPayrollComponent } from './tax-paid-payroll/tax-paid-payroll.component';
import { TaxAdjustComponent } from './tax-adjust/tax-adjust.component';
import { ProcessIncomeTaxComponent } from './process-income-tax/process-income-tax.component';

@NgModule({
  declarations: [

  TaxYearInfoComponent,

  IncomeTaxSlabComponent,

  IncomeTaxSetupComponent,

  MinimumTaxSetupComponent,

  SurchargeAssignComponent,

  SearchChargeSetupComponent,

  BlockTaxCalculationComponent,

  TaxChallanComponent,

  AdditionalTaxInfoComponent,

  OtherTaxCalculationComponent,

  ChallanPrepareComponent,

  ChallanNumberAssignComponent,

  TxtCardReportComponent,

  TaxReportComponent,

  TaxPaidPayrollComponent,

  TaxAdjustComponent,

  ProcessIncomeTaxComponent
]
  ,
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    IncomeTaxRoutingModule
    
  ]
})
export class IncomeTaxModule { }
