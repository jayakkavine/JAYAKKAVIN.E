import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private basepath = "http://localhost:5172/api/Student";



  constructor(private http:HttpClient) { }

  public getAllStudents():Observable<any>
  {
    return this.http.get(this.basepath );
  }


  public getStudentById(id:number):Observable<any>
  {
    return this.http.get(`http://localhost:5172/api/Student/${id}`);                       //.pipe(retry(0), catchError(this.handleError));
  }

  public AddStudent(student : any):Observable<any>
  {
    return this.http.post(this.basepath, student);
  }

  public UpdateStudent(id:number, student:any)
  {
    const url = `${this.basepath}?Roll_No=${id}`;
    return this.http.put(url , student);
  }
  
}