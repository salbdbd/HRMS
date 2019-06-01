import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TourApplyComponent } from './tour-apply/tour-apply.component';
import { TourApproveComponent } from './tour-approve/tour-approve.component';
import { TourApproveHrComponent } from './tour-approve-hr/tour-approve-hr.component';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild([
        {path: 'tour-apply', component: TourApplyComponent},
        {path: 'tour-approve', component: TourApproveComponent},
        {path: 'tour-approve-hr', component: TourApproveHrComponent},
    ])
  ],
  exports: [RouterModule]
})
export class TourRoutingModule { }
