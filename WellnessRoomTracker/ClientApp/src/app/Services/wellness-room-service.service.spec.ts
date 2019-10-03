import { TestBed } from '@angular/core/testing';

import { WellnessRoomServiceService } from './wellness-room-service.service';

describe('WellnessRoomServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: WellnessRoomServiceService = TestBed.get(WellnessRoomServiceService);
    expect(service).toBeTruthy();
  });
});
