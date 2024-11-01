import { Component } from '@angular/core';
import { ListarComponent } from './listar/listar.component';
import { CarrosService } from '../../services/carros.service';
import * as L from 'leaflet';

@Component({
  selector: 'app-carros',
  standalone: true,
  imports: [ListarComponent],
  templateUrl: './carros.component.html',
  styleUrl: './carros.component.css',
})
export class CarrosComponent {
  private map: any;

  constructor(private carrosService: CarrosService) {}

  ngAfterViewInit() {
    this.loadMapa();
  }

  loadMapa() {
    this.map = L.map('map', {
      center: [-23.533773, -46.62529], // SP Coordenates
      zoom: 12,
    });

    const tiles = L.tileLayer(
      'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
      {
        maxZoom: 18,
        minZoom: 3,
        attribution:
          '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>',
      }
    );

    tiles.addTo(this.map);

    this.carrosService.getCarrosListv2().subscribe((res) => {
      console.log(res);

      res.forEach((e) => {
        this.addMarcadorMapa(e.latitude, e.longitude);
      });
    });
  }

  addMarcadorMapa(cLongitude: string, cLatitude: string) {
    const longitude = parseFloat(cLongitude);
    const latitude = parseFloat(cLatitude);
    L.marker([longitude, latitude]).addTo(this.map);
  }
}
