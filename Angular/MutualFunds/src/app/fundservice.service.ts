import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FundserviceService {

  constructor(public httpclient:HttpClient) {
   }
   private url='https://localhost:7169/api/Display';
  public displayfund():Observable<any>{
    return this.httpclient.get(`${this.url}/Display`);
  }
  public displayspfund(value:number):Observable<any>{
    return this.httpclient.get(`${this.url}/GetDisplay?value=${value}`);
  }
   
}
