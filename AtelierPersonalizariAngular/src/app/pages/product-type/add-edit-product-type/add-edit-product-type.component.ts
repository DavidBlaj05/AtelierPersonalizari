import { Component, OnInit, Input } from '@angular/core';
import { ProductTypeService } from 'src/app/services/product-type.service';

@Component({
  selector: 'app-add-edit-product-type',
  templateUrl: './add-edit-product-type.component.html',
  styleUrls: ['./add-edit-product-type.component.scss']
})
export class AddEditProductTypeComponent implements OnInit {

  constructor(private service:ProductTypeService) { }

  @Input() productType:any;
  productTypeId:string="";
  productTypeName:string="";
  productTypeProviderId:string="";

  ngOnInit(): void {
    this.productTypeId=this.productType.id;
    this.productTypeName=this.productType.name;
    this.productTypeProviderId=this.productType.productTypeProviderId;
  }

  addProductType(){
    var val = {
                name:this.productTypeName,
                productTypeProviderId:this.productTypeProviderId
              };
    this.service.addProductType(val).subscribe(res=>{
      alert(val.name+" adăugat!");
    });
  }
  updateProductType(){
    var val = {
      name:this.productTypeName,
      productTypeProviderId:this.productTypeProviderId
    };
    this.service.updateProductType(val, this.productTypeId).subscribe(res=>{
      alert(val.name+" a fost editat!");
    });
  }
}
