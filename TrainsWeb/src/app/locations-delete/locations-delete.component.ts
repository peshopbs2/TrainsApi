import { Component } from '@angular/core';
import { LocationModel } from '../models/location.model';
import { ActivatedRoute, Router } from '@angular/router';
import { LocationService } from '../services/location.service';

@Component({
  selector: 'app-locations-delete',
  standalone: true,
  imports: [],
  templateUrl: './locations-delete.component.html',
  styleUrl: './locations-delete.component.css'
})
export class LocationsDeleteComponent {
  id : number | null = 0;
  location: LocationModel = {"id": 0, "name": ""};

  constructor(private route: ActivatedRoute, 
    private locationService: LocationService,
    private router : Router) {
    
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.deleteLocation(this.id);
    });
  }

  deleteLocation(id: number): void {
    this.locationService.deleteLocation(id)
      .subscribe(() => {
        this.router.navigate(['/locations'])
      });
  }
}
