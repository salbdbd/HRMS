import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Section1Component } from './section1/section1.component';
import { Section2Component } from './section2/section2.component';
import { Section3Component } from './section3/section3.component';


@NgModule({
  imports: [RouterModule.forChild([
    { path: 'section1', component: Section1Component },
    { path: 'section2', component: Section2Component },
    { path: 'section3', component: Section3Component }
  ])],
  exports: [RouterModule]
})
export class Module3RoutingModule { }
