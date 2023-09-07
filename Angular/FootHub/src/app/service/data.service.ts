import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn:'root'
})

export class DataService
{

    
    constructor(private http: HttpClient)
    {

    }

    getOccasions()
    {
        return this.http.get("http://localhost:5068/api/CRUD/OcassionTable")
    }

    getProductType()
    {
        return this.http.get("http://localhost:5068/api/CRUD/ProductType")
    }

    getBrand()
    {
        return this.http.get("http://localhost:5068/api/CRUD/BrandTable")
    }

    getProduct()
    {
        return this.http.get("http://localhost:5068/api/CRUD/ProductTable")
    }

//     public getProductById(id:number):Observable<any>
//   {
//     return this.http.get(`http://localhost:5172/api/Student/${id}`);                       //.pipe(retry(0), catchError(this.handleError));
//   }

    getDashboard()
    {
        return this.http.get("http://localhost")
    }

}