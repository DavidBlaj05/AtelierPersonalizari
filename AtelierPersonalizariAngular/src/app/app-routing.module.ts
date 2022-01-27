import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ProductTypeProviderComponent } from './pages/product-type-provider/product-type-provider.component';
import { ProductTypeComponent } from './pages/product-type/product-type.component';
import { ProductComponent } from './pages/product/product.component';

const routes: Routes = [
  {path:'ProductTypeProvider',component:ProductTypeProviderComponent},
  {path:'ProductType',component:ProductTypeComponent},
  {path:'Product',component:ProductComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
