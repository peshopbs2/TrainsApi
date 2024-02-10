import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LocationsDeleteComponent } from './locations-delete.component';

describe('LocationsDeleteComponent', () => {
  let component: LocationsDeleteComponent;
  let fixture: ComponentFixture<LocationsDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LocationsDeleteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LocationsDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
