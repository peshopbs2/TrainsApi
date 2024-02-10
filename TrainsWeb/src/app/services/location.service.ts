import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LocationModel } from '../models/location.model';

@Injectable({
  providedIn: 'root'
})
export class LocationService {
    private apiUrl = 'https://localhost:7028/api/Locations';
  
    constructor(private http: HttpClient) { }
  
    // CREATE
    createLocation(location: LocationModel): Observable<LocationModel> {
      return this.http.post<LocationModel>(this.apiUrl, location);
    }
  
    // READ
    getLocations(): Observable<LocationModel[]> {
      return this.http.get<LocationModel[]>(this.apiUrl);
    }
  
    getLocationById(id: number): Observable<LocationModel> {
      const url = `${this.apiUrl}/${id}`;
      return this.http.get<LocationModel>(url);
    }
  
    // UPDATE
    updateLocation(location: LocationModel): Observable<LocationModel> {
      const url = `${this.apiUrl}/${location.id}`;
      return this.http.put<LocationModel>(url, location);
    }
  
    // DELETE
    deleteLocation(id: number): Observable<LocationModel> {
      const url = `${this.apiUrl}/${id}`;
      return this.http.delete<LocationModel>(url);
    }
  }