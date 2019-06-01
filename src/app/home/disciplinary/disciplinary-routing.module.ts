import { DisciplinaryReportComponent } from './disciplinary-report/disciplinary-report.component';
import { PunishmentComponent } from './punishment/punishment.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ShowCauseComponent } from './show-cause/show-cause.component';
import { NoticeEnquiryComponent } from './notice-enquiry/notice-enquiry.component';
import { ShowCauseResultComponent } from './show-cause-result/show-cause-result.component';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
      {path: 'show-cause', component: ShowCauseComponent},
      {path: 'notice-enquiry', component: NoticeEnquiryComponent},
      {path: 'punishment', component: PunishmentComponent},
      {path: 'show-cause-result', component: ShowCauseResultComponent},
      {path: 'disciplinary-report', component: DisciplinaryReportComponent}
    ]),
    CommonModule
  ]
})
export class DisciplinaryRoutingModule { }
