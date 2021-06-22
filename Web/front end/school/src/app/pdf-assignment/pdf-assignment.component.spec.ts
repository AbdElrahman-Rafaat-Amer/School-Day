import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PDFAssignmentComponent } from './pdf-assignment.component';

describe('PDFAssignmentComponent', () => {
  let component: PDFAssignmentComponent;
  let fixture: ComponentFixture<PDFAssignmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PDFAssignmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PDFAssignmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
