import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BugsComponent } from './bugs/bugs.component';
import { ContactComponent } from './contact/contact.component';
import { ProductComponent } from './product/product.component';
import { appRoutes } from './app.routes';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    BugsComponent,
    ContactComponent,
    ProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes)
      // ,{useHash : true})
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
