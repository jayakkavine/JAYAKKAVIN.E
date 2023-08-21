import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { ProductComponent } from "./product/product.component";
import { ContactComponent } from "./contact/contact.component";
import { BugsComponent } from "./bugs/bugs.component";

export const appRoutes: Routes = 
[
    { path: 'home', component: HomeComponent },
    { path: 'product', component: ProductComponent },
    { path: 'contact', component: ContactComponent },
    { path: '', redirectTo: 'home', pathMatch: 'full' },  //default route 
    { path: '**', component: BugsComponent }   //wild card route
];