import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductTypeProviderService {
  readonly APIUrl = 'https://localhost:44310/api';
  constructor(private http: HttpClient) {}

  getProductTypeProviders():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/ProductTypeProvider');
  }
  addProductTypeProvider(val:any){
    return this.http.post(this.APIUrl+'/ProductTypeProvider', val);
  }
  updateProductTypeProvider(val:any, id:any){
    return this.http.put(this.APIUrl+'/ProductTypeProvider/'+id, val);
  }
  deleteProductTypeProvider(val:any){
    return this.http.delete(this.APIUrl+'/ProductTypeProvider/'+val);
  }
}
