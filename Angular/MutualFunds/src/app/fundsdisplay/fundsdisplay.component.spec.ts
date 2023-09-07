import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FundsdisplayComponent } from './fundsdisplay.component';

describe('FundsdisplayComponent', () => {
  let component: FundsdisplayComponent;
  let fixture: ComponentFixture<FundsdisplayComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FundsdisplayComponent]
    });
    fixture = TestBed.createComponent(FundsdisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
