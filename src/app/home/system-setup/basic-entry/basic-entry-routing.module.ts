import { UnitComponent } from './unit/unit.component';
import { SignatoryComponent } from './signatory/signatory.component';
import { SectionComponent } from './section/section.component';
import { OccupationComponent } from './occupation/occupation.component';
import { MisconductComponent } from './misconduct/misconduct.component';
import { LocationComponent } from './location/location.component';
import { JobTypeComponent } from './job-type/job-type.component';
import { InstituteComponent } from './institute/institute.component';
import { DesignationComponent } from './designation/designation.component';
import { DepartmentGlComponent } from './department-gl/department-gl.component';
import { CountryComponent } from './country/country.component';
import { BranchComponent } from './branch/branch.component';
import { BloodGroupComponent } from './blood-group/blood-group.component';
import { BankComponent } from './bank/bank.component';
import { DepartmentComponent } from './department/department.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { EmpInfoComponent } from './emp-info/emp-info.component';
import { EducationBoardComponent } from './education-board/education-board.component';
import { EducationLevelComponent } from './education-level/education-level.component';
import { ExperienceTypeComponent } from './experience-type/experience-type.component';
import { GenderComponent } from './gender/gender.component';
import { NationalityComponent } from './nationality/nationality.component';
import { PassingYearComponent } from './passing-year/passing-year.component';
import { PrefixComponent } from './prefix/prefix.component';
import { SuffixComponent } from './suffix/suffix.component';
import { ProjectComponent } from './project/project.component';
import { PublicationTypeComponent } from './publication-type/publication-type.component';
import { PunishmentComponent } from './punishment/punishment.component';
import { ReligionComponent } from './religion/religion.component';
import { ResultComponent } from './result/result.component';
import { TrainingCountryComponent } from './training-country/training-country.component';
import { TrainingInstituteComponent } from './training-institute/training-institute.component';
import { TrainingNatureComponent } from './training-nature/training-nature.component';
import { TrainingSponsorByComponent } from './training-sponsor-by/training-sponsor-by.component';
import { TrainingTypeComponent } from './training-type/training-type.component';

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild([
    {path:'bank', component: BankComponent},
    {path:'blood-group', component: BloodGroupComponent},
    {path:'branch', component: BranchComponent},
    {path:'country', component: CountryComponent},
    {path:'department', component: DepartmentComponent},
    {path:'department-gl', component: DepartmentGlComponent},
    {path:'designation', component: DesignationComponent},
    {path:'education-board', component: EducationBoardComponent },
    {path:'education-level', component: EducationLevelComponent},
    {path:'emp-info', component: EmpInfoComponent},
    {path:'experience-type', component: ExperienceTypeComponent},
    {path:'gender', component: GenderComponent},
    {path:'institute', component: InstituteComponent},
    {path:'job-type', component: JobTypeComponent},
    {path:'location', component: LocationComponent},
    {path:'misconduct', component: MisconductComponent},
    {path:'nationality', component: NationalityComponent},
    {path:'occupation', component: OccupationComponent},
    {path:'passing-year', component: PassingYearComponent},
    {path:'prefix', component: PrefixComponent},
    {path:'project', component: ProjectComponent},
    {path:'publication-type', component: PublicationTypeComponent},
    {path:'punishment', component: PunishmentComponent},
    {path:'religion', component: ReligionComponent},
    {path:'result', component: ResultComponent},
    {path:'section', component: SectionComponent},
    {path:'signatory', component: SignatoryComponent},
    {path:'suffix', component: SuffixComponent},
    {path:'training-country', component: TrainingCountryComponent},
    {path:'training-institute', component: TrainingInstituteComponent},
    {path:'training-nature', component: TrainingNatureComponent},
    {path:'training-sponsor-by', component: TrainingSponsorByComponent},
    {path:'training-type', component: TrainingTypeComponent},
    {path:'unit', component: UnitComponent}
  ])],
exports:[RouterModule]
})
export class BasicEntryRoutingModule { }
