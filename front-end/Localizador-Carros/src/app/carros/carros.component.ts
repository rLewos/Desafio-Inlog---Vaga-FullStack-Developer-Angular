import { Component } from '@angular/core';
import { CarrosService } from '../../services/carros.service';

@Component({
  selector: 'app-carros',
  templateUrl: './carros.component.html',
  styleUrl: './carros.component.css',
})
export class CarrosComponent {
  constructor() {}

  listAllCars() {
    console.log('Click listAllCars');
  }
}
