
import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { ChartsModule as Ng2ChartsModule } from 'ng2-charts/ng2-charts';
import { HomeRoutingModule } from './home-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { StartupComponent } from './startup/startup.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    Ng2ChartsModule,
    PerfectScrollbarModule,
    HomeRoutingModule,
    

  ],
  declarations: [
    DashboardComponent,
    StartupComponent
  ],
  providers:[DatePipe]
})
export class HomeModule { }
