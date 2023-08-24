import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GetallstudentsComponent } from './getallstudents/getallstudents.component';
import { GetstudentbyrollnoComponent } from './getstudentbyrollno/getstudentbyrollno.component';
import { AddstudentComponent } from './addstudent/addstudent.component';
import { UpdatestudentComponent } from './updatestudent/updatestudent.component';
import { DeletestudentComponent } from './deletestudent/deletestudent.component';

@NgModule({
  declarations: [
    AppComponent,
    GetallstudentsComponent,
    GetstudentbyrollnoComponent,
    AddstudentComponent,
    UpdatestudentComponent,
    DeletestudentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
