import { HrMenuRoutingModule } from './hr-menu-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmpGenInfoComponent } from './emp-gen-info/emp-gen-info.component';
import { NgbDateAdapter, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { EmployentInfoComponent } from './employent-info/employent-info.component';
import { AdditionalDutiesComponent } from './additional-duties/additional-duties.component';
import { EmpCompanyTransferComponent } from './emp-company-transfer/emp-company-transfer.component';
import { EmpProInfoComponent } from './emp-pro-info/emp-pro-info.component';
import { HolidayInfoComponent } from './holiday-info/holiday-info.component';
import { CasualJoinDateComponent } from './casual-join-date/casual-join-date.component';
import { EmpBlockInfoComponent } from './emp-block-info/emp-block-info.component';
import { EmpForAttendanceComponent } from './emp-for-attendance/emp-for-attendance.component';
import { ResignationLetterComponent } from './resignation-letter/resignation-letter.component';
import { ResignationLetterApproveComponent } from './resignation-letter-approve/resignation-letter-approve.component';
import { EmpForResignationComponent } from './emp-for-resignation/emp-for-resignation.component';
import { NoticeByCompanyComponent } from './notice-by-company/notice-by-company.component';
import { EmpSeparationInfoComponent } from './emp-separation-info/emp-separation-info.component';
import { EmpObjectiveInfoComponent } from './emp-objective-info/emp-objective-info.component';
import { ProductionPositionInfoComponent } from './production-position-info/production-position-info.component';
import { DownloadCertificateComponent } from './download-certificate/download-certificate.component';
import { UploadFileComponent } from './upload-file/upload-file.component';
import { DownloadImgSignatureComponent } from './download-img-signature/download-img-signature.component';
import { BasicHrReportComponent } from './basic-hr-report/basic-hr-report.component';
import { UploadFilesComponent } from './upload-files/upload-files.component';
import { PersonalFileComponent } from './personal-file/personal-file.component';
import { EmpCertificateUploadComponent } from './emp-certificate-upload/emp-certificate-upload.component';
import { NgbDateCustomParserFormatter } from '../../shared/dateformat';

@NgModule({
  imports: [
    CommonModule,
    HrMenuRoutingModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    NgxDatatableModule
  ],
  declarations: [
    EmpGenInfoComponent,
    EmployentInfoComponent,
    AdditionalDutiesComponent,
    EmpCompanyTransferComponent,
    EmpProInfoComponent,
    HolidayInfoComponent,
    CasualJoinDateComponent,
    EmpBlockInfoComponent,
    EmpForAttendanceComponent,
    ResignationLetterComponent,
    ResignationLetterApproveComponent,
    EmpForResignationComponent,
    NoticeByCompanyComponent,
    EmpSeparationInfoComponent,
    EmpObjectiveInfoComponent,
    ProductionPositionInfoComponent,
    DownloadCertificateComponent,
    UploadFileComponent,
    DownloadImgSignatureComponent,
    BasicHrReportComponent,
    UploadFilesComponent,
    PersonalFileComponent,
    EmpCertificateUploadComponent
  ],
  providers:[NgbDateCustomParserFormatter]
})
export class HrMenuModule { }
