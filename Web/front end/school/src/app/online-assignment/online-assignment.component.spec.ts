import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OnlineAssignmentComponent } from './online-assignment.component';

describe('OnlineAssignmentComponent', () => {
  let component: OnlineAssignmentComponent;
  let fixture: ComponentFixture<OnlineAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OnlineAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OnlineAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
