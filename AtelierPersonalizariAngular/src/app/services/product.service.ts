import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  readonly APIUrl = 'https://localhost:44310/api';
  constructor(private http: HttpClient) {}

  getProducts():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Product');
  }
  addProduct(val:any){
    return this.http.post(this.APIUrl+'/Product', val);
  }
  updateProduct(val:any, id:any){
    return this.http.put(this.APIUrl+'/Product/'+id, val);
  }
  deleteProduct(val:any){
    return this.http.delete(this.APIUrl+'/Product/'+val);
  }
}
