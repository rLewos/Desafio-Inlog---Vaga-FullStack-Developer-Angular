import { Component } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { CarrosService } from '../../../services/carros.service';

@Component({
  selector: 'app-novo',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './novo.component.html',
  styleUrl: './novo.component.css',
})
export class NovoComponent {
  formulario = new FormGroup({
    identificador: new FormControl('', Validators.required),
    placa: new FormControl('', Validators.required),
    numeroRastreio: new FormControl(''),
    longitude: new FormControl('', Validators.required),
    latitude: new FormControl('', Validators.required),
    cor: new FormControl('', Validators.required),
    chassi: new FormControl('', Validators.required),
  });

  constructor(private carrosService: CarrosService) {}

  salvar() {
    console.log(this.formulario);
    if (this.formulario.valid) {
      this.carrosService.saveCarro(this.formulario.value);
    } else {
      alert('Há campos que não foram preenchidos');
    }
  }
}
