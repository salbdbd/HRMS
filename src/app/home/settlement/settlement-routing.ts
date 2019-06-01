import { FinalSettlementComponent } from './final-settlement/final-settlement.component';
import { GratuitySetupComponent } from './gratuity-setup/gratuity-setup.component';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { NoticeDaySetupComponent } from './notice-day-setup/notice-day-setup.component';
import { NoticePayAmountComponent } from './notice-pay-amount/notice-pay-amount.component';
import { GratuityYearSetupComponent } from './gratuity-year-setup/gratuity-year-setup.component';
import { SettlementReportComponent } from './settlement-report/settlement-report.component';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
        {path:'notice-day-setup', component:NoticeDaySetupComponent},
        {path:'notice-pay-amount', component:NoticePayAmountComponent},
        {path:'gratuity-setup', component:GratuitySetupComponent},
        {path:'gratuity-year-setup', component:GratuityYearSetupComponent},
        {path:'final-settlement', component:FinalSettlementComponent},
        {path:'settlement-report', component:SettlementReportComponent},
    ])
  ],
  exports:[RouterModule]
})
export class SettlementRoutingModule { }
