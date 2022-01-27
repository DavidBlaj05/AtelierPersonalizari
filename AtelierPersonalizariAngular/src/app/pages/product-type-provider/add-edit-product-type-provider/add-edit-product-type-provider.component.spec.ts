import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditProductTypeProviderComponent } from './add-edit-product-type-provider.component';

describe('AddEditProductTypeProviderComponent', () => {
  let component: AddEditProductTypeProviderComponent;
  let fixture: ComponentFixture<AddEditProductTypeProviderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditProductTypeProviderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditProductTypeProviderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
