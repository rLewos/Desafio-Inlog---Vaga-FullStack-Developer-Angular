import { Component, EventEmitter, Output } from '@angular/core';
import { CarrosService } from '../../../services/carros.service';

@Component({
  selector: 'app-listar',
  standalone: true,
  imports: [],
  templateUrl: './listar.component.html',
  styleUrl: './listar.component.css',
})
export class ListarComponent {
  carrosList: any = [];
  codigo: number = 0;
  @Output() emitLinhaSelecionada = new EventEmitter();

  constructor(private carrosService: CarrosService) {}

  ngOnInit() {
    this.loadTodosVeiculos();
  }

  loadTodosVeiculos() {
    console.log('loadTodosVeiculos');

    this.carrosService.getCarrosListv2().subscribe((response) => {
      console.log(response);
      this.carrosList = response;
    });
  }

  selecionarAlvo(codigoCarro: number, latitude: number, longitude: number) {
    this.emitLinhaSelecionada.emit({
      codigo: codigoCarro,
      latitude: latitude,
      longitude: longitude,
    });
  }
}
