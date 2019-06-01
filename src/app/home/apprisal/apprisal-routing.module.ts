import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { EmpApprisalComponent } from './emp-apprisal/emp-apprisal.component';
import { PointComponent } from './point/point.component';
import { CompetenciesComponent } from './competencies/competencies.component';
import { CompetenciesTypeComponent } from './competencies-type/competencies-type.component';




@NgModule({
  imports: [RouterModule.forChild([
  {path: 'competencies-type',component:CompetenciesTypeComponent},
  {path: 'competencies',component:CompetenciesComponent},
  {path: 'point',component:PointComponent},
  {path: 'emp-apprisal',component:EmpApprisalComponent}

  
  ])],
  exports: [RouterModule]
})
export class ApprisalRoutingModule { }
