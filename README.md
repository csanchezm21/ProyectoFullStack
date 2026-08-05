# 🚀 Proyecto Full Stack - ASP.NET Core + SQL Server + Angular

Proyecto desarrollado con el objetivo de construir una aplicación Full Stack utilizando buenas prácticas de desarrollo, arquitectura por capas y tecnologías ampliamente utilizadas en el entorno profesional.

Actualmente el proyecto se encuentra en desarrollo, implementando progresivamente funcionalidades del backend antes de iniciar el frontend con Angular.

---

## 🛠️ Tecnologías utilizadas

### Backend
- ASP.NET Core Web API (.NET 8)
- C#
- Entity Framework Core
- SQL Server
- AutoMapper

### Base de Datos
- SQL Server
- Entity Framework Core (Code First)

### Control de versiones
- Git
- GitHub

### Frontend (Próximamente)
- Angular
- TypeScript
- HTML5
- CSS3
- Bootstrap

---

# 📂 Arquitectura del proyecto

```
ProyectoFullStack
│
├── Backend
│   └── ProyectoFullStack.API
│
├── Frontend
│
├── BaseDatos
│
└── Documentacion
```

El backend está organizado siguiendo una arquitectura por capas para mantener una separación clara de responsabilidades.

```
Controllers
│
├── Services
│
├── Interfaces
│
├── DTOs
│
├── Mapping
│
├── Data
│
└── Models
```

---

# ✅ Funcionalidades implementadas

## Base del proyecto

- ✔ Arquitectura por capas
- ✔ Conexión con SQL Server
- ✔ Entity Framework Core
- ✔ Dependency Injection
- ✔ Configuración de DbContext

## CRUD de Productos

- ✔ Obtener todos los productos
- ✔ Obtener producto por Id
- ✔ Crear productos
- ✔ Actualizar productos
- ✔ Eliminar productos

## DTOs

Se implementó el patrón **DTO (Data Transfer Object)** para evitar exponer directamente las entidades de la base de datos.

DTOs implementados:

- ProductoCreateDto
- ProductoUpdateDto
- ProductoResponseDto

---

## AutoMapper

Se implementó AutoMapper para automatizar la conversión entre entidades y DTOs, eliminando el mapeo manual y reduciendo código repetitivo.

Incluye:

- MappingProfile
- Registro en Program.cs
- Inyección mediante IMapper
- Conversión automática entre DTOs y entidades

---

## Validaciones

Se implementaron validaciones utilizando **Data Annotations**.

Actualmente se validan:

- Nombre obligatorio
- Longitud máxima del nombre
- Precio mayor que cero
- Stock no negativo

También se personalizó la respuesta de error de la API para entregar mensajes más claros y fáciles de consumir desde el frontend.

Ejemplo:

```json
{
  "mensaje": "Los datos enviados no son válidos.",
  "errores": {
    "Precio": [
      "El precio debe ser mayor que cero."
    ]
  }
}
```

---

# 📷 Pruebas

Todas las operaciones del CRUD han sido probadas mediante **Swagger**.

Pruebas realizadas:

- GET
- GET por Id
- POST
- PUT
- DELETE
- Validaciones
- Respuestas personalizadas de error

---

# 🚧 Próximas funcionalidades

Backend

- Manejo global de excepciones
- Logging
- Respuestas consistentes
- JWT Authentication
- Registro de usuarios
- Inicio de sesión
- Roles y autorización

Frontend

- Angular
- Consumo de la API
- CRUD completo
- Login
- Diseño responsivo

Despliegue

- Publicación del Backend
- Publicación del Frontend
- Base de datos en la nube

---

# 📈 Estado del proyecto

| Característica | Estado |
|----------------|--------|
| Arquitectura por capas | ✅ |
| SQL Server | ✅ |
| Entity Framework Core | ✅ |
| Dependency Injection | ✅ |
| CRUD | ✅ |
| DTOs | ✅ |
| AutoMapper | ✅ |
| Validaciones | ✅ |
| Respuestas personalizadas | ✅ |
| Manejo global de excepciones | ⏳ |
| JWT | ⏳ |
| Angular | ⏳ |

**Progreso estimado del Backend: 85%**

---

# 📚 Objetivos del proyecto

Este proyecto tiene como finalidad fortalecer conocimientos en:

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Arquitectura por capas
- DTOs
- AutoMapper
- Validaciones
- JWT Authentication
- Angular
- Buenas prácticas de desarrollo

---

# 👨‍💻 Autor

**César Sánchez**

- Estudiante de Ingeniería de Software
- Analista de Soporte IT
- Aspirante a Desarrollador Full Stack

GitHub:
https://github.com/csanchezm21
