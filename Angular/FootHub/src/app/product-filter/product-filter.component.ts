import { Component, OnInit } from '@angular/core';
import { Product } from 'src/Models/Product';

@Component({
  selector: 'app-product-filter',
  templateUrl: './product-filter.component.html',
  styleUrls: ['./product-filter.component.css']
})
export class ProductFilterComponent implements OnInit{
  products!: Product[];

  select_category:any = [];

  ngOnInit() : void
  {
    this.getProducts()
  }

  public getProducts() {
   this.products = [
      new Product('Memory Card'),
      new Product('Pen Drive'),
      new Product('Power Bank'),
    ];
    return this.products;
  }
  // public getProduct(id: number) {
  //   let products: Product[] = this.getProducts();
  //   return products.find((p) => p.productID == id);
  // }

  public getFilterData()
  {
    const pars = this.select_category.map((str:any) =>
    {
      return parseInt(str);
    });
  }

  public filterProducts(event:any)
  {
    if(event.target.checked)
    {
        this.select_category.push(event.target.id);
    }
    else
    {
      const id = event.target.id;
      for(let data of this.select_category)
      {
        if(data==id)
        {
          const index = this.select_category.indexof(data);
          this.select_category.splice(index,1);
        }
      }
    }
  }

}
