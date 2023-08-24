import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetstudentbyrollnoComponent } from './getstudentbyrollno.component';

describe('GetstudentbyrollnoComponent', () => {
  let component: GetstudentbyrollnoComponent;
  let fixture: ComponentFixture<GetstudentbyrollnoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetstudentbyrollnoComponent]
    });
    fixture = TestBed.createComponent(GetstudentbyrollnoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
