import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IArticulo } from '../interfaces/IArticulo';

@Injectable({
  providedIn: 'root'
})
export class ComprarService {

  constructor(
    private http: HttpClient
  ) { }

  shop(data: IArticulo[]): Observable<any> {
    return this.http.post<any>("/api/venta/comprar", data);
  }
}
