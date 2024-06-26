import { Component, OnInit } from '@angular/core';
import { IArticulo } from '../../../interfaces/IArticulo';
import { ObtenerArticulosService } from 'src/app/services/obtener-articulos.service';
import { ArticulosService } from 'src/app/services/interaction/articulos.service';

@Component({
  selector: 'app-articulos',
  templateUrl: './articulos.component.html',
  styleUrls: ['./articulos.component.css']
})
export class ArticulosComponent implements OnInit {

  articulos: IArticulo[] = [];

  constructor(
    public articulosService: ObtenerArticulosService,
    public as: ArticulosService,
  ) {}


  ngOnInit() {
		this.articulosService.obtener().subscribe({
			next: (data:  IArticulo[]) => {
				if (Array.isArray(data)){
					this.articulos = data;
				}
			}
		})
	}
}
