import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ObtenerArticulosService } from './obtener-articulos.service';

@Injectable({
  providedIn: 'root'
})
export class ObtenerArticulosResolverService {

  constructor(
    private service: ObtenerArticulosService
  ) { }

  resolve(): Observable<any> {
    return this.service.obtener();
  }
}
