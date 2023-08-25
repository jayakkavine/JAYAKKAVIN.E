import { Component } from '@angular/core';
import { DataService } from '../service/data.service';
import { ActivatedRoute } from '@angular/router';

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
  
  cat_id: any;

  constructor(private dataService : DataService, private activatedRoute: ActivatedRoute)
  {

  }
  ngOnInit(): void{
    
    this.getProduct();


    this.cat_id = this.activatedRoute.snapshot.paramMap.get('id');
  }

  getOccasions()
  {
    this.dataService.getOccasions().subscribe(response=>
      {
          this.occasion = response;
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
        this.getOccasions();
        this.getBrand();
        this.getProductType();
          this.data = response;
          this.assignProducts();
          console.log(this.data);
          // this.temp = response;
          // console.log(this.temp);
      });
  }

  assignProducts()
  {
    for(let i=0;i<this.data.length;i++)
    {
      if(this.data[i].categoryName == this.cat_id)
      {
        this.temp.push(this.data[i]);
        console.log(this.temp);
      }
      console.log(this.temp);
      console.log(this.cat_id);
    }
  }


  getFilterData()
  {
    const pars = this.select_categories.map((str: any) =>
    {
      return parseInt(str);
    });
    const data = {
      select_categories : pars
    }
      
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
          if(this.select_categories[j] == this.data[i].oId && this.data[i].categoryName == this.cat_id)
          {
          this.temp.push(this.data[i]);
          }
        }
        else
        {
          if(this.select_categories[j] == this.data[i].oId && this.data[i].categoryName == this.cat_id)
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
            
            this.temp.push(this.data[i]);
          }
        }
        }
      }
      for(let j=0;j<this.select_categories.length;j++)
      {
        if(this.temp.length == 0)
        {
          if(this.select_categories[j] == this.data[i].bId && this.data[i].categoryName == this.cat_id)
          {
          this.temp.push(this.data[i]);
          }
        }
        else
        {
          if(this.select_categories[j] == this.data[i].bId && this.data[i].categoryName == this.cat_id)
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
            
            this.temp.push(this.data[i]);
          }
        }
        }
      }
      for(let j=0;j<this.select_categories.length;j++)
      {
        if(this.temp.length == 0)
        {
          if(this.select_categories[j] == this.data[i].tId && this.data[i].categoryName == this.cat_id)
          {
          this.temp.push(this.data[i]);
          }
        }
        else
        {
          if(this.select_categories[j] == this.data[i].tId && this.data[i].categoryName == this.cat_id)
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
