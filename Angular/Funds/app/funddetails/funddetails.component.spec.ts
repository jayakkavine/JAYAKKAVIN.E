import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FunddetailsComponent } from './funddetails.component';

describe('FunddetailsComponent', () => {
  let component: FunddetailsComponent;
  let fixture: ComponentFixture<FunddetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FunddetailsComponent]
    });
    fixture = TestBed.createComponent(FunddetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
