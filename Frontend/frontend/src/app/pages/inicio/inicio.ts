
import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Api, Producto } from '../../services/api';

// Configuración del componente Inicio
@Component({
  selector: 'app-inicio',
  imports: [RouterLink],
  templateUrl: './inicio.html',
  styleUrl: './inicio.css',
})
export class Inicio implements OnInit {

  // Variable donde almacenaremos los productos recibidos del Backend
  productos: Producto[] = [];

  // Inyectamos el servicio Api para comunicarnos con .NET
  constructor(private api: Api) {}

  // Se ejecuta automáticamente cuando Angular inicia el componente
  ngOnInit(): void {

    // Solicitamos los productos al Backend
    this.api.getProductos().subscribe({

      // Se ejecuta cuando recibimos una respuesta correcta
      next: (respuesta) => {

        // Guardamos los productos recibidos en nuestra variable
        this.productos = respuesta.data;

        // Comprobamos los productos recibidos
        console.log('Productos recibidos desde la API:', this.productos);
      },

      // Se ejecuta si ocurre algún error en la solicitud
      error: (error) => {
        console.error('Error al consultar productos:', error);
      }

    });

  }

}
