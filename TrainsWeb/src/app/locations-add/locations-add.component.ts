import { Component } from '@angular/core';
import { LocationModel } from '../models/location.model';
import { LocationService } from '../services/location.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-locations-add',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './locations-add.component.html',
  styleUrl: './locations-add.component.css'
})
export class LocationsAddComponent {
  location: LocationModel = {
    id: 0,
    name: ''
  };

  constructor(private locationService: LocationService,
    private router: Router) { }

  createLocation(): void {
    this.locationService.createLocation(this.location)
      .subscribe(() => {
        this.router.navigate(['/locations'])
      });
  }
}
