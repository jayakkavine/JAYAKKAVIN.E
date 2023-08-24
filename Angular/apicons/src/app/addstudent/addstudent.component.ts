import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { StudentService } from '../services/student.service';


@Component({
  selector: 'app-addstudent',
  templateUrl: './addstudent.component.html',
  styleUrls: ['./addstudent.component.css']
})
export class AddstudentComponent implements OnInit{

  public AddStudentForm! : FormGroup;
 
  constructor(private formBuilder:FormBuilder, 
   private studentService:StudentService ) {}
 
   ngOnInit(): void {
     this.init();
   }
   
   private init() : void
   {
     this.AddStudentForm = this.formBuilder.group({
       roll_No:[],
       student_name:[],
       address:[],
       phone:[]
     });
   }
 
   public AddNewStudent():void
   {
     this.studentService.AddStudent(this.AddStudentForm.value)
     .subscribe(result =>
       {
       alert(" Student Added ");
       });
   }

}