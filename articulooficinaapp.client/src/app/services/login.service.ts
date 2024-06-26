import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    private http: HttpClient
  ) { }

  obtener(data: { email: string, password: string}): Observable<any> {
    return this.http.post<any>("/api/login/iniciar", data);
  }
}
