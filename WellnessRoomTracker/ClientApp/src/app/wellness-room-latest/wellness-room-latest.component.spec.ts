import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WellnessRoomLatestComponent } from './wellness-room-latest.component';

describe('WellnessRoomLatestComponent', () => {
  let component: WellnessRoomLatestComponent;
  let fixture: ComponentFixture<WellnessRoomLatestComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WellnessRoomLatestComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WellnessRoomLatestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
