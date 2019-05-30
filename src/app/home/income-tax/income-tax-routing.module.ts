import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { TaxYearInfoComponent } from './tax-year-info/tax-year-info.component';
import { IncomeTaxSlabComponent } from './income-tax-slab/income-tax-slab.component';
import { IncomeTaxSetupComponent } from './income-tax-setup/income-tax-setup.component';
import { MinimumTaxSetupComponent } from './minimum-tax-setup/minimum-tax-setup.component';
import { SurchargeAssignComponent } from './surcharge-assign/surcharge-assign.component';
import { TaxChallanComponent } from './tax-challan/tax-challan.component';
import { BlockTaxCalculationComponent } from './block-tax-calculation/block-tax-calculation.component';
import { SearchChargeSetupComponent } from './search-charge-setup/search-charge-setup.component';
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
  imports: [RouterModule.forChild([
   {path: 'tax-year-info',component: TaxYearInfoComponent},
   {path: 'income-tax-slab',component: IncomeTaxSlabComponent},
   {path: 'income-tax-setup',component:IncomeTaxSetupComponent},
   {path: 'minimum-tax-setup',component: MinimumTaxSetupComponent},
   {path: 'surcharge-assign',component: SurchargeAssignComponent},
   {path: 'search-charge-setup',component: SearchChargeSetupComponent},
   {path: 'block-tax-calculation',component: BlockTaxCalculationComponent},
   {path: 'tax-challan',component:  TaxChallanComponent},
   {path: 'additional-tax-info',component:  AdditionalTaxInfoComponent},
   {path: 'other-tax-calculation',component: OtherTaxCalculationComponent},
   {path: 'challan-prepare',component:   ChallanPrepareComponent},
   {path: 'challan-number-assign',component:  ChallanNumberAssignComponent},
   {path: 'txt-card-report',component:  TxtCardReportComponent},
   {path: 'tax-report',component:  TaxReportComponent},
   {path: 'tax-paid-payroll',component:  TaxPaidPayrollComponent},
   {path: 'tax-adjust',component:  TaxAdjustComponent},
   {path: 'process-income-tax',component:  ProcessIncomeTaxComponent}

   

  
  ])],
  exports: [RouterModule]
})
export class IncomeTaxRoutingModule { }