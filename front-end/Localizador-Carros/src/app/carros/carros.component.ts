import { Component } from '@angular/core';
import { NovoComponent } from './novo/novo.component';
import { ListarComponent } from './listar/listar.component';

@Component({
  selector: 'app-carros',
  standalone: true,
  imports: [ListarComponent],
  templateUrl: './carros.component.html',
  styleUrl: './carros.component.css',
})
export class CarrosComponent {
  constructor() {}

  listAllCars() {
    console.log('Click listAllCars');
  }
}
