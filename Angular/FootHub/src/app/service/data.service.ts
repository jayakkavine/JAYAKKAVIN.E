import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

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

    getProducts()
    {
        return this.http.get("http://localhost:5172/api/Student")
    }

    getFilteredProducts(data: any)
    {
        return this.http.post(`http://localhost:5172/api/Student/Get`,data);
    }

    getDashboard()
    {
        return this.http.get("http://localhost")
    }

}