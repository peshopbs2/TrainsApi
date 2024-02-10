import { Routes } from '@angular/router';
import { LocationsComponent } from './locations/locations.component';
import { LocationsDetailsComponent } from './locations-details/locations-details.component';
import { LocationsAddComponent } from './locations-add/locations-add.component';
import { LocationsEditComponent } from './locations-edit/locations-edit.component';
import { LocationsDeleteComponent } from './locations-delete/locations-delete.component';

export const routes: Routes = [
    { path: 'locations', component: LocationsComponent },
    { path: 'locations/add', component: LocationsAddComponent},
    { path: 'locations/edit/:id', component: LocationsEditComponent},
    { path: 'locations/delete/:id', component: LocationsDeleteComponent},
    { path: 'locations/:id', component: LocationsDetailsComponent}
];
