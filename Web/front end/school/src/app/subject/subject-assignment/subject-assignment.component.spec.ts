import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SubjectAssignmentComponent } from './subject-assignment.component';

describe('SubjectAssignmentComponent', () => {
  let component: SubjectAssignmentComponent;
  let fixture: ComponentFixture<SubjectAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SubjectAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SubjectAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
