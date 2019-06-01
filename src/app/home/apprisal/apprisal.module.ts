import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApprisalRoutingModule } from './apprisal-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CompetenciesTypeComponent } from './competencies-type/competencies-type.component';
import { CompetenciesComponent } from './competencies/competencies.component';
import { PointComponent } from './point/point.component';
import { EmpApprisalComponent } from './emp-apprisal/emp-apprisal.component';

@NgModule({
  declarations: [

  CompetenciesTypeComponent,

  CompetenciesComponent,

  PointComponent,

  EmpApprisalComponent],
  imports: [
    CommonModule,
    ApprisalRoutingModule,
    NgbModule,
    FormsModule

  ]
})
export class ApprisalModule { }
