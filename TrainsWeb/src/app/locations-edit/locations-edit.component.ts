import { Component } from '@angular/core';
import { LocationModel } from '../models/location.model';
import { ActivatedRoute, Router } from '@angular/router';
import { LocationService } from '../services/location.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-locations-edit',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './locations-edit.component.html',
  styleUrl: './locations-edit.component.css'
})
export class LocationsEditComponent {
  id : number | null = 0;
  location: LocationModel = {"id": 0, "name": ""};

  constructor(private route: ActivatedRoute,
     private locationService: LocationService,
     private router : Router) {
    
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

  saveLocation() : void {
    this.locationService.updateLocation(this.location)
    .subscribe(() => {
      this.router.navigate(['/locations'])
    });
  }
}
