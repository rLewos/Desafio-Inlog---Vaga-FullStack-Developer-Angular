import { Carro } from '../models/Carro';

export class CarrosService {
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
    ];
  }

  saveCarro(carro: Carro) {}
}
