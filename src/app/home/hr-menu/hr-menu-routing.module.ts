import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { EmpGenInfoComponent } from './emp-gen-info/emp-gen-info.component';
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




@NgModule({
  imports: [RouterModule.forChild([
    { path: 'emp-gen-info', component: EmpGenInfoComponent },
    { path: 'employent-info', component: EmployentInfoComponent },
    { path: 'additional-duties', component: AdditionalDutiesComponent },
    {path:'emp-company-transfer',component:EmpCompanyTransferComponent},
    {path:'emp-pro-info',component:EmpProInfoComponent},
    {path:'holiday-info',component:HolidayInfoComponent},
    {path:'casual-join-date',component:CasualJoinDateComponent},
    {path:'emp-block-info',component:EmpBlockInfoComponent},
    {path:'emp-for-attendance',component:EmpForAttendanceComponent},
    {path:'resignation-letter',component:ResignationLetterComponent},
    {path:'resignation-letter-approve',component: ResignationLetterApproveComponent},
    {path:'emp-for-resignation',component:EmpForResignationComponent},
    {path:'notice-by-company',component: NoticeByCompanyComponent},
    {path:'emp-separation-info',component: EmpSeparationInfoComponent},
    {path:'emp-objective-info',component:EmpObjectiveInfoComponent},
    {path:'production-position-info',component:ProductionPositionInfoComponent},
    {path:'download-certificate',component:DownloadCertificateComponent},
    {path:'upload-file',component:UploadFileComponent},
    {path:'download-img-signature',component: DownloadImgSignatureComponent},
    {path:'basic-hr-report',component: BasicHrReportComponent},
    {path:'upload-files',component: UploadFilesComponent},
    {path:'personal-file',component: PersonalFileComponent},
    {path:'emp-certificate-upload',component: EmpCertificateUploadComponent}
  ])],
  exports: [RouterModule]
})
export class HrMenuRoutingModule { }
