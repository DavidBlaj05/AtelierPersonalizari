import { Component, OnInit } from '@angular/core';
import { ProductTypeService } from 'src/app/services/product-type.service';

@Component({
  selector: 'app-show-product-type',
  templateUrl: './show-product-type.component.html',
  styleUrls: ['./show-product-type.component.scss']
})
export class ShowProductTypeComponent implements OnInit {

  constructor(private service:ProductTypeService) { }
  
  productTypes:any=[];
  modalTitle:string="";
  ActivateAddEditProductTypeComp:boolean=false;
  productType:any;

  ngOnInit(): void {
    this.refreshProductTypes();
  }

  addClick(){
    this.productType={
      id:"",
      name:"",
      productTypeProviderId:""
    }
    this.modalTitle="Add ProductType";
    this.ActivateAddEditProductTypeComp=true;
  }
  editClick(item:any){
    this.productType=item;
    this.modalTitle="Edit ProductType";
    this.ActivateAddEditProductTypeComp=true;
  }
  deleteClick(item:any){
    if(confirm("Confirmați dorința de a șterge")){
      this.service.deleteProductType(item.id).subscribe(data=>{
        alert(item.name+" a fost șters!");
        this.refreshProductTypes();
      });
    }
  }
  closeClick(){
    this.ActivateAddEditProductTypeComp=false;
    this.refreshProductTypes();
  }

  refreshProductTypes(){
    this.service.getProductTypes().subscribe(data=>{
      this.productTypes = data;
    });
  }
}
