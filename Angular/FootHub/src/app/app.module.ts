import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductFilterComponent } from './product-filter/product-filter.component';
import { ProductDetailsFilterComponent } from './product-details-filter/product-details-filter.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FootersComponent } from './footers/footers.component';
import { ProductdisplayComponent } from './productdisplay/productdisplay.component';
import { ProductComponent } from './product/product.component';

const routes: Routes = [
  {path:'',component:DashboardComponent },
  {path:'product',component:ProductComponent },
  {path:'product/:id',component:ProductComponent },
  {path:'productdisplay',component:ProductdisplayComponent },
  {path:'filter',component:ProductFilterComponent },
  {path:'product-details',component:ProductDetailsFilterComponent },
  {path:'productdisplay/:id',component:ProductdisplayComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    ProductFilterComponent,
    ProductDetailsFilterComponent,
    NavbarComponent,
    DashboardComponent,
    FootersComponent,
    ProductdisplayComponent,
    ProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
