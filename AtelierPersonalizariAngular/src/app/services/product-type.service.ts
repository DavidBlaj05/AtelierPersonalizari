import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductTypeService {
  readonly APIUrl = 'https://localhost:44310/api';
  constructor(private http: HttpClient) {}

  getProductTypes():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/ProductType');
  }
  addProductType(val:any){
    return this.http.post(this.APIUrl+'/ProductType', val);
  }
  updateProductType(val:any, id:any){
    return this.http.put(this.APIUrl+'/ProductType/'+id, val);
  }
  deleteProductType(val:any){
    return this.http.delete(this.APIUrl+'/ProductType/'+val);
  }
}
