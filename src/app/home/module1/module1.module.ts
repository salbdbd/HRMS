
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { Module1RoutingModule } from './module1-routing.module';

import { Section1Component } from './section1/section1.component';
import { Section2Component } from './section2/section2.component';
import { Section3Component } from './section3/section3.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    Module1RoutingModule
  ],
  declarations: [
    Section1Component,
    Section2Component,
    Section3Component
  ]
})
export class Module1Module { }
