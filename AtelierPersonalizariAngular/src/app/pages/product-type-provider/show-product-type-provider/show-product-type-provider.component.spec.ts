import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowProductTypeProviderComponent } from './show-product-type-provider.component';

describe('ShowProductTypeProviderComponent', () => {
  let component: ShowProductTypeProviderComponent;
  let fixture: ComponentFixture<ShowProductTypeProviderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowProductTypeProviderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowProductTypeProviderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
