import { Component } from '@angular/core';
import { LocationModel } from '../models/location.model';
import { ActivatedRoute } from '@angular/router';
import { LocationService } from '../services/location.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-locations-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './locations-details.component.html',
  styleUrl: './locations-details.component.css'
})
export class LocationsDetailsComponent {
  id : number | null = 0;
  location: LocationModel = {"id": 0, "name": ""};

  constructor(private route: ActivatedRoute, private locationService: LocationService) {
    
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.getLocation(this.id);
    });
  }

  getLocation(id: number): void {
    this.locationService.getLocationById(id)
      .subscribe(location => this.location = location);
  }
  
}
