import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductTypeProviderComponent } from './pages/product-type-provider/product-type-provider.component';
import { ProductTypeComponent } from './pages/product-type/product-type.component';
import { ProductComponent } from './pages/product/product.component';
import { ShowProductComponent } from './pages/product/show-product/show-product.component';
import { AddEditProductComponent } from './pages/product/add-edit-product/add-edit-product.component';
import { ProductTypeProviderService } from './services/product-type-provider.service';
import { ProductTypeService } from './services/product-type.service';
import { ProductService } from './services/product.service';
import { ShowProductTypeComponent } from './pages/product-type/show-product-type/show-product-type.component';
import { AddEditProductTypeComponent } from './pages/product-type/add-edit-product-type/add-edit-product-type.component';
import { ShowProductTypeProviderComponent } from './pages/product-type-provider/show-product-type-provider/show-product-type-provider.component';
import { AddEditProductTypeProviderComponent } from './pages/product-type-provider/add-edit-product-type-provider/add-edit-product-type-provider.component';



@NgModule({
  declarations: [
    AppComponent,
    ProductTypeProviderComponent,
    ProductTypeComponent,
    ProductComponent,
    ShowProductComponent,
    AddEditProductComponent,
    ShowProductTypeComponent,
    AddEditProductTypeComponent,
    ShowProductTypeProviderComponent,
    AddEditProductTypeProviderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ProductTypeProviderService, ProductTypeService, ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
