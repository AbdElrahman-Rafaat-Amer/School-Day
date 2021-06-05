import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NoteboardComponent } from './noteboard.component';

describe('NoteboardComponent', () => {
  let component: NoteboardComponent;
  let fixture: ComponentFixture<NoteboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NoteboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NoteboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
