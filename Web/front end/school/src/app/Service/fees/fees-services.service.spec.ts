import { TestBed } from '@angular/core/testing';

import { FeesServicesService } from './fees-services.service';

describe('FeesServicesService', () => {
  let service: FeesServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FeesServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
