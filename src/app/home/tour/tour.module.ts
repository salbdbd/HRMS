import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TourRoutingModule } from './tour-routing.module';
import { TourApplyComponent } from './tour-apply/tour-apply.component';
import { TourApproveComponent } from './tour-approve/tour-approve.component';
import { TourApproveHrComponent } from './tour-approve-hr/tour-approve-hr.component';

@NgModule({
  declarations: [TourApplyComponent, TourApproveComponent, TourApproveHrComponent],
  imports: [
    CommonModule,
    FormsModule,
    NgbModule,
    TourRoutingModule
  ]
})
export class TourModule { }
