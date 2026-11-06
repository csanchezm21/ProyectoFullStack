
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

// Definimos la estructura de cada producto
export interface Producto {
  id: number;
  nombre: string;
  precio: number;
  stock: number;
}

// Definimos la estructura de respuesta que devuelve el Backend
export interface ApiResponse<T> {
  success: boolean;
  message: string;
  data: T;
}

@Injectable({
  providedIn: 'root',
})
export class Api {

  // Dirección base de nuestra API desarrollada en .NET
  private apiUrl = 'https://localhost:7281/api';

  constructor(private http: HttpClient) {}

  // Solicitamos los productos y especificamos el tipo de respuesta
  getProductos(): Observable<ApiResponse<Producto[]>> {
    return this.http.get<ApiResponse<Producto[]>>(
      `${this.apiUrl}/Productos`
    );
  }

}
