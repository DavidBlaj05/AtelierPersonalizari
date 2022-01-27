import { Component, OnInit } from '@angular/core';
import { ProductTypeProviderService } from 'src/app/services/product-type-provider.service';

@Component({
  selector: 'app-show-product-type-provider',
  templateUrl: './show-product-type-provider.component.html',
  styleUrls: ['./show-product-type-provider.component.scss']
})
export class ShowProductTypeProviderComponent implements OnInit {

  constructor(private service:ProductTypeProviderService) { }
  
  productTypeProviders:any=[];
  modalTitle:string="";
  ActivateAddEditProductTypeProviderComp:boolean=false;
  productTypeProvider:any;

  ngOnInit(): void {
    this.refreshProductTypeProviders();
  }

  addClick(){
    this.productTypeProvider={
      id:"",
      name:""
    }
    this.modalTitle="Add ProductTypeProvider";
    this.ActivateAddEditProductTypeProviderComp=true;
  }
  editClick(item:any){
    this.productTypeProvider=item;
    this.modalTitle="Edit ProductTypeProvider";
    this.ActivateAddEditProductTypeProviderComp=true;
  }
  deleteClick(item:any){
    if(confirm("Confirmați dorința de a șterge")){
      this.service.deleteProductTypeProvider(item.id).subscribe(data=>{
        alert(item.name+" a fost șters!");
        this.refreshProductTypeProviders();
      });
    }
  }
  closeClick(){
    this.ActivateAddEditProductTypeProviderComp=false;
    this.refreshProductTypeProviders();
  }

  refreshProductTypeProviders(){
    this.service.getProductTypeProviders().subscribe(data=>{
      this.productTypeProviders = data;
    });
  }
}
