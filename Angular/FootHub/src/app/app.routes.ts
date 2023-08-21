import { Routes } from "@angular/router";
import { ProductDetailsFilterComponent } from "./product-details-filter/product-details-filter.component";
import { ProductFilterComponent } from "./product-filter/product-filter.component";

export const appRoutes: Routes =
[
    {path:'productdetails',component:ProductDetailsFilterComponent},
    {path:'product',component:ProductFilterComponent}
];