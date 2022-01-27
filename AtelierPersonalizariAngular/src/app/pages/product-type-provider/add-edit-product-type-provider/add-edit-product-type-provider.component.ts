import { Component, OnInit, Input } from '@angular/core';
import { ProductTypeProviderService } from 'src/app/services/product-type-provider.service';

@Component({
  selector: 'app-add-edit-product-type-provider',
  templateUrl: './add-edit-product-type-provider.component.html',
  styleUrls: ['./add-edit-product-type-provider.component.scss']
})
export class AddEditProductTypeProviderComponent implements OnInit {

  constructor(private service:ProductTypeProviderService) { }

  @Input() productTypeProvider:any;
  productTypeProviderId:string="";
  productTypeProviderName:string="";

  ngOnInit(): void {
    this.productTypeProviderId=this.productTypeProvider.id;
    this.productTypeProviderName=this.productTypeProvider.name;
  }

  addProductTypeProvider(){
    var val = {
                name:this.productTypeProviderName
              };
    this.service.addProductTypeProvider(val).subscribe(res=>{
      alert(val.name+" adăugat!");
    });
  }
  updateProductTypeProvider(){
    var val = {
      name:this.productTypeProviderName
    };
    this.service.updateProductTypeProvider(val, this.productTypeProviderId).subscribe(res=>{
      alert(val.name+" a fost editat!");
    });
  }
}
