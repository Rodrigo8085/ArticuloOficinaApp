import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ArticulosService {

  constructor() { }

  articulo = new Subject<any>();
  articuloEmmiter$ = this.articulo.asObservable();

  notifyAdd(articulo: any) {
    this.articulo.next(articulo);
  }

  notifyMin(articulo: any) {
    this.articulo.next(articulo);
  }
}
