import { Routes } from '@angular/router';

import { CarrosComponent } from './carros/carros.component';
import { HomeComponent } from './home/home.component';
import { ListarComponent } from './carros/listar/listar.component';
import { NovoComponent } from './carros/novo/novo.component';

export const ROUTES: Routes = [
  { path: '', component: HomeComponent },
  { path: 'carros', component: CarrosComponent },
  { path: 'carros/listar', component: ListarComponent },
  { path: 'carros/novo', component: NovoComponent },
];
