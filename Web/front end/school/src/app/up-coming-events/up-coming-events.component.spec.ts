import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpComingEventsComponent } from './up-coming-events.component';

describe('UpComingEventsComponent', () => {
  let component: UpComingEventsComponent;
  let fixture: ComponentFixture<UpComingEventsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpComingEventsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpComingEventsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
