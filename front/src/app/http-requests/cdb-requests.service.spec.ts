import { TestBed } from '@angular/core/testing';

import { CdbRequestsService } from './cdb-requests.service';

describe('CdbRequestsService', () => {
  let service: CdbRequestsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CdbRequestsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
