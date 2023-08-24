import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddstudentComponent } from './addstudent/addstudent.component';
import { UpdatestudentComponent } from './updatestudent/updatestudent.component';
import { DeletestudentComponent } from './deletestudent/deletestudent.component';
import { GetstudentbyrollnoComponent } from './getstudentbyrollno/getstudentbyrollno.component';
import { GetallstudentsComponent } from './getallstudents/getallstudents.component';

const routes: Routes = [
  { path : "addstudent" , component:AddstudentComponent   },
  { path : "updatestudent" , component:UpdatestudentComponent   },
  { path : "deletestudent" , component:DeletestudentComponent   },
  { path : "studentbyid" , component:GetstudentbyrollnoComponent  },
  { path : "allstudent" , component:GetallstudentsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
