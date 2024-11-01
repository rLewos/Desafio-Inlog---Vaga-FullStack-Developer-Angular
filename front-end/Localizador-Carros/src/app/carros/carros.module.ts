import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CarrosComponent } from './carros.component';
import { NovoComponent } from './novo/novo.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [CarrosComponent, NovoComponent],
  imports: [CommonModule],
  exports: [CarrosComponent],
})
export class CarrosModule {}
