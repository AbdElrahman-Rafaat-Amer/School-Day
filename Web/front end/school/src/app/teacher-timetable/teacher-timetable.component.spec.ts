import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TeacherTimetableComponent } from './teacher-timetable.component';

describe('TeacherTimetableComponent', () => {
  let component: TeacherTimetableComponent;
  let fixture: ComponentFixture<TeacherTimetableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TeacherTimetableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TeacherTimetableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
