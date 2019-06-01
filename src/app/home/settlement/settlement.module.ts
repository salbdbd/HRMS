import { SettlementRoutingModule } from './settlement-routing';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NoticeDaySetupComponent } from './notice-day-setup/notice-day-setup.component';
import { NoticePayAmountComponent } from './notice-pay-amount/notice-pay-amount.component';
import { GratuitySetupComponent } from './gratuity-setup/gratuity-setup.component';
import { GratuityYearSetupComponent } from './gratuity-year-setup/gratuity-year-setup.component';
import { FinalSettlementComponent } from './final-settlement/final-settlement.component';
import { SettlementReportComponent } from './settlement-report/settlement-report.component';

@NgModule({
  declarations: [
    NoticeDaySetupComponent,
    NoticePayAmountComponent,
    GratuitySetupComponent,
    GratuityYearSetupComponent,
    FinalSettlementComponent,
    SettlementReportComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    SettlementRoutingModule
  ]
})
export class SettlementModule { }
