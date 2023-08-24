import { Component } from '@angular/core';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-getallstudents',
  templateUrl: './getallstudents.component.html',
  styleUrls: ['./getallstudents.component.css']
})
export class GetallstudentsComponent {
  public students: any;
  
  constructor(private service: StudentService) { }

  ngOnInit(): void {
    this.getStudents();
  }

  public getStudents(): void 
  {
    this.service.getAllStudents().subscribe(result => {
      this.students = result;
      console.log(this.students);
    });
  }
}
