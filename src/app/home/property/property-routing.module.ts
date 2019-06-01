import { VehicleTaxAssaginComponent } from './vehicle-tax-assagin/vehicle-tax-assagin.component';
import { PropertyNameComponent } from './property-name/property-name.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { PropertyCategoryComponent} from './property-category/property-category.component';
import { AssetAdditionComponent } from './asset-addition/asset-addition.component';
import { PropertyAssaignComponent } from './property-assaign/property-assaign.component';
import { PropertyDisposalComponent } from './property-disposal/property-disposal.component';
import { ReportComponent } from './report/report.component';



@NgModule({
  imports: [RouterModule.forChild([
    { path: 'property-category', component: PropertyCategoryComponent },
    { path: 'property-name', component: PropertyNameComponent },
    { path: 'vehicle-tax-assagin', component: VehicleTaxAssaginComponent },
    { path: 'asset-addition', component: AssetAdditionComponent },
    { path: 'property-assaign', component: PropertyAssaignComponent },
    { path: 'property-disposal', component: PropertyDisposalComponent },
    { path: 'report', component: ReportComponent },
  ])],
  exports: [RouterModule]
})
export class PropertyRoutingModule { }
