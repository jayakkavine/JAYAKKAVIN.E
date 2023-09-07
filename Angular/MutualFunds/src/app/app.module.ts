import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FunddetailsComponent } from './funddetails/funddetails.component';
import { FundsdisplayComponent } from './fundsdisplay/fundsdisplay.component';

@NgModule({
  declarations: [
    AppComponent,
    FunddetailsComponent,
    FundsdisplayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgxPaginationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
