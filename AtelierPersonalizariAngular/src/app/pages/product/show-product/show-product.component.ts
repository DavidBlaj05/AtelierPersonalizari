import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-show-product',
  templateUrl: './show-product.component.html',
  styleUrls: ['./show-product.component.scss']
})
export class ShowProductComponent implements OnInit {

  constructor(private service:ProductService) { }
  
  products:any=[];
  modalTitle:string="";
  ActivateAddEditProductComp:boolean=false;
  product:any;

  ngOnInit(): void {
    this.refreshProducts();
  }

  addClick(){
    this.product={
      id:"",
      name:"",
      description:"",
      price:"",
      quantity:"",
      productTypeId:""
    }
    this.modalTitle="Add Product";
    this.ActivateAddEditProductComp=true;
  }
  editClick(item:any){
    this.product=item;
    this.modalTitle="Edit Product";
    this.ActivateAddEditProductComp=true;
  }
  deleteClick(item:any){
    if(confirm("Confirmați dorința de a șterge")){
      this.service.deleteProduct(item.id).subscribe(data=>{
        alert(item.name+" a fost șters!");
        this.refreshProducts();
      });
    }
  }
  closeClick(){
    this.ActivateAddEditProductComp=false;
    this.refreshProducts();
  }

  refreshProducts(){
    this.service.getProducts().subscribe(data=>{
      this.products = data;
    });
  }
}
