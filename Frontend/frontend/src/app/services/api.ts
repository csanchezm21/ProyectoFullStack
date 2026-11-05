
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class Api {

  private apiUrl = 'https://localhost:7281/api';

  constructor(private http: HttpClient) {}

  getProductos(): Observable<unknown> {
    return this.http.get<unknown>(`${this.apiUrl}/Productos`);
  }

}
