import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpperBarComponent } from './upper-bar.component';

describe('UpperBarComponent', () => {
  let component: UpperBarComponent;
  let fixture: ComponentFixture<UpperBarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpperBarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpperBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
