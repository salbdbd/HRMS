import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { LocationSetupComponent } from './location-setup/location-setup.component';
import { ActiveLnactiveComponent } from './active-lnactive/active-lnactive.component';
import { LocationShowComponent } from './location-show/location-show.component';




@NgModule({
  imports: [RouterModule.forChild([
  {path: 'location-setup',component:LocationSetupComponent},
  {path:'location-show',component:LocationShowComponent},
  {path:'active-lnactive',component:ActiveLnactiveComponent}

  ])],
  exports: [RouterModule]
})
export class AppsRoutingModule { }