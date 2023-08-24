import { Component } from '@angular/core';
import { DataService } from '../service/data.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent 
{
  public data: any = [];
  temp: any =[];
  occasion: any = [];
  brand: any = [];
  productType: any = [];
  occasion_name = '';
  brand_name = '';
  product_type = '';
  

  constructor(private dataService : DataService)
  {

  }
  ngOnInit(): void{
    this.getOccasions();
    this.getBrand();
    this.getProductType();
    this.getProduct();
    
  }

  getProduct()
  {
    this.dataService.getProduct().subscribe(response=>
      {
          this.data = response;
          this.assignProducts();
      });
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


  assignProducts()
  {
    for(let i=0;i<this.data.length;i++)
    {
      if(this.data[i].pId == 9)
      {
        this.temp.push(this.data[i]);
      }
    }
    for(let i=0;i<this.occasion.length;i++)
    {
      if(this.occasion[i].oId == this.temp[0].oId)
        this.occasion_name = this.occasion[i].oName;
    }

    for(let i=0;i<this.brand.length;i++)
    {
      if(this.brand[i].bId == this.temp[0].bId)
        this.brand_name = this.brand[i].bName;
    }

    for(let i=0;i<this.productType.length;i++)
    {
      if(this.productType[i].tId == this.temp[0].tId)
        this.product_type = this.productType[i].tName;
      
    }
    console.log(this.temp);
  }
  
}
