import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuetionsComponent } from './quetions.component';

describe('QuetionsComponent', () => {
  let component: QuetionsComponent;
  let fixture: ComponentFixture<QuetionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuetionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuetionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
