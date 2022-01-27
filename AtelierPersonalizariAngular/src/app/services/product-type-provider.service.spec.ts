import { TestBed } from '@angular/core/testing';

import { ProductTypeProviderService } from './product-type-provider.service';

describe('ProductTypeProviderService', () => {
  let service: ProductTypeProviderService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProductTypeProviderService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
