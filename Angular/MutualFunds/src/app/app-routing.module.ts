

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FunddetailsComponent } from './funddetails/funddetails.component';
import { FundsdisplayComponent } from './fundsdisplay/fundsdisplay.component';

const routes: Routes = [
  {path:'',component:FundsdisplayComponent},
{path:'details/:schemeCode',component:FunddetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
