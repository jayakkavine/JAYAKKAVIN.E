import { Component } from '@angular/core';
import { DataService } from '../service/data.service';
import { Output, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent 
{

  public data: any = [];
  temp: any =[];
  

  constructor(private dataService : DataService)
  {

  }
  ngOnInit(): void{
    this.getProduct();
    
  }

  getProduct()
  {
    this.dataService.getProduct().subscribe(response=>
      {
          this.data = response;
          console.log(this.data);
          this.assignProducts();
      });
      
      
  }

  assignProducts()
  {
    for(let i=this.data.length - 1;i>=(this.data.length - 3);i--)
    {
      this.temp.push(this.data[i]);
    }
    console.log(this.temp);
  }
  
}