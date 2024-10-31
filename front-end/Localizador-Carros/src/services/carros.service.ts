import { Injectable } from '@angular/core';
import { Carro } from '../models/Carro';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class CarrosService {
  constructor(private http: HttpClient) {}
  getCarrosList() {
    return [
      {
        identifier: 'Vehicle 1',
        license_plate: 'AAA-9A99',
        tracker_serial_number: 'A0000000',
        coordinates: {
          latitude: -25.43247,
          longitude: -49.27845,
        },
      },
      {
        identifier: 'Vehicle 1',
        license_plate: 'AAA-9A99v2',
        tracker_serial_number: 'A0000000',
        coordinates: {
          latitude: -25.43247,
          longitude: -49.27845,
        },
      },
    ];
  }

  saveCarro(carro: Carro) {}
}
