import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OnlineQustionsComponent } from './online-qustions.component';

describe('OnlineQustionsComponent', () => {
  let component: OnlineQustionsComponent;
  let fixture: ComponentFixture<OnlineQustionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OnlineQustionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OnlineQustionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
