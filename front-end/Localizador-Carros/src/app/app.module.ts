import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CarrosModule } from './carros/carros.module';
import { CarrosComponent } from './carros/carros.component';

@NgModule({
  declarations: [AppComponent, HomeComponent, CarrosComponent],
  imports: [BrowserModule, CarrosModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
