import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Api } from '../../services/api';

@Component({
  selector: 'app-inicio',
  imports: [RouterLink],
  templateUrl: './inicio.html',
  styleUrl: './inicio.css',
})
export class Inicio implements OnInit {

  constructor(private api: Api) {}

  ngOnInit(): void {

    this.api.getProductos().subscribe({

      next: (respuesta) => {
        console.log('Productos recibidos desde la API:', respuesta);
      },

      error: (error) => {
        console.error('Error al consultar productos:', error);
      }

    });

  }

}
