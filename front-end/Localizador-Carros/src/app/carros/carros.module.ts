import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CarrosComponent } from './carros.component';
import { ListarComponent } from './listar/listar.component';
import { NovoComponent } from './novo/novo.component';

@NgModule({
  declarations: [CarrosComponent, ListarComponent, NovoComponent],
  imports: [CommonModule],
  exports: [CarrosComponent],
})
export class CarrosModule {}
