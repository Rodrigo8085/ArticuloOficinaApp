import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ObtenerArticulosService {

  constructor(
    private http: HttpClient
  ) { }

  obtener(): Observable<any> {
    return this.http.get<any>("/api/articulos/obtenerTodos");
  }
}
