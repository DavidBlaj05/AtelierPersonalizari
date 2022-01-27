import { Component, OnInit, Input } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-add-edit-product',
  templateUrl: './add-edit-product.component.html',
  styleUrls: ['./add-edit-product.component.scss']
})
export class AddEditProductComponent implements OnInit {

  constructor(private service:ProductService) { }

  @Input() product:any;
  productId:string="";
  productName:string="";
  productDescription:string="";
  productPrice:string="";
  productQuantity:string="";
  productTypeId:string="";

  ngOnInit(): void {
    this.productId=this.product.id;
    this.productName=this.product.name;
    this.productDescription=this.product.description;
    this.productPrice=this.product.price;
    this.productQuantity=this.product.quantity;
    this.productTypeId=this.product.productTypeId;
  }

  addProduct(){
    var val = {
                name:this.productName,
                description:this.productDescription,
                price:this.productPrice,
                quantity:this.productQuantity,
                productTypeId:this.productTypeId
              };
    this.service.addProduct(val).subscribe(res=>{
      alert(val.name+" adăugat!");
    });
  }
  updateProduct(){
    var val = {
      name:this.productName,
      description:this.productDescription,
      price:this.productPrice,
      quantity:this.productQuantity,
      productTypeId:this.productTypeId
    };
    this.service.updateProduct(val, this.productId).subscribe(res=>{
      alert(val.name+" a fost editat!");
    });
  }
}
