import { FormsModule } from '@angular/forms';
import { BasicEntryRoutingModule } from './basic-entry-routing.module';
import { DepartmentComponent } from './department/department.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { EmpInfoComponent } from './emp-info/emp-info.component';
import { DesignationComponent } from './designation/designation.component';
import { BloodGroupComponent } from './blood-group/blood-group.component';
import { NationalityComponent } from './nationality/nationality.component';
import { JobTypeComponent } from './job-type/job-type.component';
import { BranchComponent } from './branch/branch.component';
import { SectionComponent } from './section/section.component';
import { LocationComponent } from './location/location.component';
import { UnitComponent } from './unit/unit.component';
import { GenderComponent } from './gender/gender.component';
import { ReligionComponent } from './religion/religion.component';
import { BankComponent } from './bank/bank.component';
import { InstituteComponent } from './institute/institute.component';
import { OccupationComponent } from './occupation/occupation.component';
import { EducationLevelComponent } from './education-level/education-level.component';
import { PassingYearComponent } from './passing-year/passing-year.component';
import { ProjectComponent } from './project/project.component';
import { ResultComponent } from './result/result.component';
import { TrainingCountryComponent } from './training-country/training-country.component';
import { TrainingInstituteComponent } from './training-institute/training-institute.component';
import { TrainingNatureComponent } from './training-nature/training-nature.component';
import { TrainingSponsorByComponent } from './training-sponsor-by/training-sponsor-by.component';
import { TrainingTypeComponent } from './training-type/training-type.component';
import { SignatoryComponent } from './signatory/signatory.component';
import { MisconductComponent } from './misconduct/misconduct.component';
import { DepartmentGlComponent } from './department-gl/department-gl.component';
import { PunishmentComponent } from './punishment/punishment.component';
import { PrefixComponent } from './prefix/prefix.component';
import { SuffixComponent } from './suffix/suffix.component';
import { CountryComponent } from './country/country.component';
import { EducationBoardComponent } from './education-board/education-board.component';
import { PublicationTypeComponent } from './publication-type/publication-type.component';
import { ExperienceTypeComponent } from './experience-type/experience-type.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    EmpInfoComponent,
    DepartmentComponent,
    DepartmentGlComponent,
    SectionComponent,
    LocationComponent,
    CountryComponent,
    NationalityComponent,
    GenderComponent,
    ReligionComponent,
    BloodGroupComponent,
    EducationLevelComponent,
    EducationBoardComponent,
    InstituteComponent,
    ResultComponent,
    PassingYearComponent,
    TrainingTypeComponent,
    TrainingCountryComponent,
    TrainingInstituteComponent,
    TrainingNatureComponent,
    TrainingSponsorByComponent,
    ProjectComponent,
    JobTypeComponent,
    DesignationComponent,
    OccupationComponent,
    ExperienceTypeComponent,
    PunishmentComponent,
    BankComponent,
    BranchComponent,
    UnitComponent,
    SignatoryComponent,
    MisconductComponent,
    PrefixComponent,
    SuffixComponent,
    PublicationTypeComponent
  ],
  imports: [
    CommonModule,
    BasicEntryRoutingModule,
    NgxDatatableModule,
    FormsModule,
    NgbModule
  ]
})
export class BasicEntryModule { }
