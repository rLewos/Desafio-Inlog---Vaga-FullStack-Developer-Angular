import { Routes } from '@angular/router';

import { CarrosComponent } from './carros/carros.component';
import { HomeComponent } from './home/home.component';

export const ROUTES: Routes = [
  { path: '', component: HomeComponent },
  { path: 'carros', component: CarrosComponent },
];
