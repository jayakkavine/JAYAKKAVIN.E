import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { NgxPaginationModule } from 'ngx-pagination';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FundsdisplayComponent } from './fundsdisplay/fundsdisplay.component';
import { FunddetailsComponent } from './funddetails/funddetails.component';

@NgModule({
  declarations: [
    AppComponent,
    FundsdisplayComponent,
    FunddetailsComponent
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
