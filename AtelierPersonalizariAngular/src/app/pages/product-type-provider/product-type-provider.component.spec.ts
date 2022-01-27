import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductTypeProviderComponent } from './product-type-provider.component';

describe('ProductTypeProviderComponent', () => {
  let component: ProductTypeProviderComponent;
  let fixture: ComponentFixture<ProductTypeProviderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductTypeProviderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductTypeProviderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
