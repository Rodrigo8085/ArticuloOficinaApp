import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LayoutRoutingModule } from './layout-routing.module';
import { BannerComponent } from './components/banner/banner.component';
import { HomeComponent } from './home/home.component';
import { NgbCarouselModule } from '@ng-bootstrap/ng-bootstrap';
import { ArticulosComponent } from './components/articulos/articulos.component';


@NgModule({
  declarations: [
    BannerComponent,
    HomeComponent,
    ArticulosComponent
  ],
  imports: [
    CommonModule,
    LayoutRoutingModule,
    NgbCarouselModule
  ]
})
export class LayoutModule { }
