import { Component, OnInit } from '@angular/core';
import { DataService } from '../service/data.service';
import { Output, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product-filter',
  templateUrl: './product-filter.component.html',
  styleUrls: ['./product-filter.component.css']
})
export class ProductFilterComponent {
  
  data: any = [];
  select_categories: any = [];
  filter_data: any =[];
  temp: any =[];
  

  constructor(private dataService : DataService)
  {

  }
  ngOnInit(): void{
    //this.getProducts();
  }

  // getProducts()
  // {
  //   this.dataService.getProducts().subscribe(response=>
  //     {
  //         this.data = response;
  //         console.log(this.data);
  //     });
  // }


  getFilterData()
  {
    console.log('clicked');
    const pars = this.select_categories.map((str: any) =>
    {
      return parseInt(str);
    });
    const data = {
      select_categories : pars
    }
    
      console.log(data);
    // this.dataService.getFilteredProducts(data).subscribe(response =>
    //   {
    //       this.filter_data = response;
    //   });
  }

  productCheck()
  {
    for(let p of this.select_categories)
    {
      for(let d of this.data)
      {
        if(p === d.roll_No)
        {
          console.log(d);
        }
      }
    }
  }

  filterProducts(event : any)
  {
    if(event.target.checked)
    {
      this.select_categories.push(event.target.id);
    }
    else{
      const id = event.target.id;
      for(let data of this.select_categories)
      {
        if(data === id)
        {
          const index = this.select_categories.indexOf(data);
          console.log(index);
          this.select_categories.splice(index, 1); 
          // this.temp.splice(index, 1); 
        }
      }
    }
    // for(let i=0;i<this.select_categories.length;i++)
    // {
    //   for(let j=0;j<this.data.length;j++)
    //   {
    //     if(this.select_categories[i] == this.data[j].roll_No)
    //     {
    //         this.temp.push(this.data[j]);
    //     }
    //   }
    // }
  }

  getFilterDatas()
  {
    this.temp = [];
    for(let i=0;i<this.select_categories.length;i++)
    {
      for(let j=0;j<this.data.length;j++)
      {
        if(this.select_categories[i] == this.data[j].roll_No)
        {
          this.temp.push(this.data[j]);
        }
      }
    }
    
}

}

