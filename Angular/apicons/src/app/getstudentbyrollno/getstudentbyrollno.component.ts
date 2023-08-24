import { Component } from '@angular/core';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-getstudentbyrollno',
  templateUrl: './getstudentbyrollno.component.html',
  styleUrls: ['./getstudentbyrollno.component.css']
})
export class GetstudentbyrollnoComponent {
  public student: any;
  id!:number;

  constructor(private studentService: StudentService,
    ) { }

  ngOnInit(): void {
  }
  
  public GetStudentById(){
      return this.studentService.getStudentById(this.id)
      .subscribe(result => this.student = result );
    
  }
}
