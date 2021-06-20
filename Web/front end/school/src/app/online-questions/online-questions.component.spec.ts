import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OnlineQuestionsComponent } from './online-questions.component';

describe('OnlineQuestionsComponent', () => {
  let component: OnlineQuestionsComponent;
  let fixture: ComponentFixture<OnlineQuestionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OnlineQuestionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OnlineQuestionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
