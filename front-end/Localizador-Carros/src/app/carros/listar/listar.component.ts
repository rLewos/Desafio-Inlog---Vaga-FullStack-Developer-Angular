import { Component } from '@angular/core';
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
}
