import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NoteboaredComponent } from './noteboared.component';

describe('NoteboaredComponent', () => {
  let component: NoteboaredComponent;
  let fixture: ComponentFixture<NoteboaredComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NoteboaredComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NoteboaredComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
