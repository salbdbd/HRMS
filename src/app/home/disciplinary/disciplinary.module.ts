import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DisciplinaryRoutingModule } from './disciplinary-routing.module';
import { ShowCauseComponent } from './show-cause/show-cause.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {NoticeEnquiryComponent } from './notice-enquiry/notice-enquiry.component';
import { PunishmentComponent } from './punishment/punishment.component';
import { ShowCauseResultComponent } from './show-cause-result/show-cause-result.component';
import { DisciplinaryReportComponent } from './disciplinary-report/disciplinary-report.component';

@NgModule({
  declarations: [
    ShowCauseComponent,
    NoticeEnquiryComponent,
    PunishmentComponent,
    ShowCauseResultComponent,
    DisciplinaryReportComponent
  ],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    DisciplinaryRoutingModule
  ]
})
export class DisciplinaryModule { }
