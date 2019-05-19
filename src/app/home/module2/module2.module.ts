
 
import { Module2RoutingModule } from './module2-routing.module';

import { Section1Component } from './section1/section1.component';
import { Section2Component } from './section2/section2.component';
import { Section3Component } from './section3/section3.component';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    Module2RoutingModule
  ],
  declarations: [
    Section1Component,
    Section2Component,
    Section3Component
  ]
})
export class Module2Module { }
