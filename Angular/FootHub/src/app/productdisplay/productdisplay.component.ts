import { Component } from '@angular/core';
import { DataService } from '../service/data.service';

@Component({
  selector: 'app-productdisplay',
  templateUrl: './productdisplay.component.html',
  styleUrls: ['./productdisplay.component.css']
})
export class ProductdisplayComponent 
{
  occasion: any = [];
  brand: any =[];
  productType: any = [];
  temp: any =[];
  data: any=[];
  select_categories: any = [];
  filter_data: any =[];
  

  constructor(private dataService : DataService)
  {

  }
  ngOnInit(): void{
    this.getOccasions();
    this.getBrand();
    this.getProductType();
    this.getProduct();
  }

  getOccasions()
  {
    this.dataService.getOccasions().subscribe(response=>
      {
          this.occasion = response;
          console.log(this.occasion);
      });
  }

  getBrand()
  {
    this.dataService.getBrand().subscribe(response =>
      {
          this.brand = response;
          
      });
  }

  getProductType()
  {
    this.dataService.getProductType().subscribe(response =>
      {
          this.productType = response;
      });
  }

  getProduct()
  {
    this.dataService.getProduct().subscribe(response =>
      {
          this.data = response;
          this.temp = response;
          console.log(this.data);
      });
  }

  // assignOccasions()
  // {
  //   for(let i=0;i<this.occasion.length;i++)
  //   {
  //     this.temp.push(this.occasion[i]);
  //   }
  // }


  getFilterData()
  {
    const pars = this.select_categories.map((str: any) =>
    {
      return parseInt(str);
    });
    const data = {
      select_categories : pars
    }
      console.log(this.select_categories);
    this.dataService.getFilteredProducts(data).subscribe(response =>
      {
          this.filter_data = response;
      });
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
        }
      }
    }
  }

  getFilterDatas()
  {
    console.log(this.select_categories);
    this.temp = [];
    for(let i=0;i<this.data.length;i++)
    {
      for(let j=0;j<this.select_categories.length;j++)
      {
        if(this.temp.length == 0)
        {
          if(this.select_categories[j] == this.data[i].oId)
          {
          this.temp.push(this.data[i]);
          }
        }
        else
        {
          if(this.select_categories[j] == this.data[i].oId)
          {
          let a = 0;
          for(let k=0;k<this.temp.length;k++)
          {
              if(this.temp[k].pId == this.data[i].pId)
              {
                a=1;
              }
          }
          if(a==0)
          {
            console.log("a is 2");
            this.temp.push(this.data[i]);
          }
        }
        }
      }
      for(let j=0;j<this.select_categories.length;j++)
      {
        if(this.temp.length == 0)
        {
          if(this.select_categories[j] == this.data[i].bId)
          {
          this.temp.push(this.data[i]);
          }
        }
        else
        {
          if(this.select_categories[j] == this.data[i].bId)
          {
          let a = 0;
          for(let k=0;k<this.temp.length;k++)
          {
              if(this.temp[k].pId == this.data[i].pId)
              {
                a=1;
              }
          }
          if(a==0)
          {
            console.log("a is 2");
            this.temp.push(this.data[i]);
          }
        }
        }
      }
      for(let j=0;j<this.select_categories.length;j++)
      {
        if(this.temp.length == 0)
        {
          if(this.select_categories[j] == this.data[i].tId)
          {
          this.temp.push(this.data[i]);
          }
        }
        else
        {
          if(this.select_categories[j] == this.data[i].tId)
          {
          let a = 0;
          for(let k=0;k<this.temp.length;k++)
          {
              if(this.temp[k].pId == this.data[i].pId)
              {
                a=1;
              }
          }
          if(a==0)
          {
            console.log("a is 2");
            this.temp.push(this.data[i]);
          }
        }
        }
      }




      // for(let j=0;j<this.select_categories.length;j++)
      // {
      //   if(this.select_categories[j] == this.data[i].pId)
      //   {
      //     this.temp.push(this.data[i]);
      //   }
      // }

    }
    console.log(this.temp);
}



}
