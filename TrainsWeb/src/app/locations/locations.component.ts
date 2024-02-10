import { Component } from '@angular/core';
import { LocationModel } from '../models/location.model';
import { CommonModule } from '@angular/common';
import { LocationService } from '../services/location.service';

@Component({
  selector: 'app-locations',
  standalone: true,
  imports: [CommonModule ],
  templateUrl: './locations.component.html',
  styleUrl: './locations.component.css'
})
export class LocationsComponent {
  locations: LocationModel[] = [];

  constructor(private locationService: LocationService) { }

  ngOnInit(): void {
    this.getLocations();
  }

  getLocations(): void {
    this.locationService.getLocations()
      .subscribe(locations => this.locations = locations);
  }

}
