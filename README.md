🚀 Proyecto Full Stack — ASP.NET Core + SQL Server + Angular

Proyecto Full Stack desarrollado con el objetivo de construir una aplicación web completa utilizando ASP.NET Core Web API, C#, SQL Server y Angular, aplicando buenas prácticas de desarrollo, arquitectura por capas y principios utilizados en proyectos profesionales.

El proyecto se desarrolla progresivamente, comenzando por la construcción y seguridad del backend para posteriormente integrar el frontend con Angular.

🛠️ Tecnologías utilizadas
Backend
ASP.NET Core Web API (.NET 8)
C#
Entity Framework Core
SQL Server
AutoMapper
ILogger / Logging
JWT Authentication (en desarrollo)
Base de Datos
SQL Server
Entity Framework Core
Code First
Control de versiones
Git
GitHub
Frontend
Angular (próximamente)
TypeScript
HTML5
CSS3
Bootstrap
📂 Arquitectura del proyecto
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

El backend utiliza una arquitectura por capas, separando las responsabilidades de cada componente:

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

Esta estructura facilita el mantenimiento, la escalabilidad y la organización del proyecto.

✅ Funcionalidades implementadas
🏗️ Base del proyecto
✅ Arquitectura por capas
✅ ASP.NET Core Web API
✅ C#
✅ Conexión con SQL Server
✅ Entity Framework Core
✅ Dependency Injection
✅ Configuración de DbContext
📦 CRUD de Productos

Se implementó un CRUD completo utilizando Entity Framework Core:

✅ Obtener todos los productos
✅ Obtener producto por ID
✅ Crear productos
✅ Actualizar productos
✅ Eliminar productos

Endpoints principales:

GET     /api/Productos
GET     /api/Productos/{id}
POST    /api/Productos
PUT     /api/Productos/{id}
DELETE  /api/Productos/{id}
📋 DTOs

Se implementó el patrón DTO (Data Transfer Object) para evitar exponer directamente las entidades de la base de datos.

DTOs implementados:

ProductoCreateDto
ProductoUpdateDto
ProductoResponseDto
ApiResponseDto<T>
ErrorResponseDto
🔄 AutoMapper

Se implementó AutoMapper para automatizar la conversión entre entidades y DTOs.

Incluye:

MappingProfile
Registro de AutoMapper en Program.cs
Inyección mediante IMapper
Conversión automática entre DTOs y entidades
✔️ Validaciones

Se implementaron validaciones mediante Data Annotations.

Actualmente se validan:

Nombre obligatorio
Longitud máxima del nombre
Precio mayor que cero
Stock no negativo

También se personalizaron las respuestas de validación para entregar información clara al consumidor de la API.

Ejemplo:

{
  "success": false,
  "message": "Los datos enviados no son válidos.",
  "data": {
    "Precio": [
      "El precio debe ser mayor que cero."
    ]
  }
}
🛡️ Manejo global de excepciones

Se implementó un Middleware global para el manejo de excepciones.

Esto permite centralizar el tratamiento de errores inesperados de la API y devolver respuestas controladas al cliente.

Se implementó:

ExceptionMiddleware
ErrorResponseDto
Registro del Middleware en Program.cs
Manejo de errores 500
Respuestas controladas para diferentes situaciones
📝 Logging

Se implementó Logging utilizando ILogger.

Actualmente se utilizan diferentes niveles de registro:

LogInformation() → información sobre operaciones normales
LogWarning() → situaciones que requieren atención
LogError() → errores durante la ejecución

Ejemplo:

_logger.LogInformation("Se solicitó la lista de productos.");

Esto permite realizar un mejor seguimiento del comportamiento de la API y facilita la detección de problemas.

📦 Respuestas consistentes

Se implementó una estructura uniforme para las respuestas de la API mediante:

ApiResponseDto<T>

La estructura utiliza:

Success
Message
Data

Ejemplo de respuesta exitosa:

{
  "success": true,
  "message": "Producto consultado correctamente.",
  "data": {
    "id": 1,
    "nombre": "Mouse Gamer",
    "precio": 50000,
    "stock": 10
  }
}

Ejemplo de respuesta de error:

{
  "success": false,
  "message": "Producto no encontrado.",
  "data": null
}

Esto permite que el frontend pueda interpretar las respuestas de la API de una manera clara y uniforme.

🧪 Pruebas

Las funcionalidades implementadas han sido probadas utilizando Swagger / OpenAPI.

Pruebas realizadas:

✅ GET
✅ GET por ID
✅ POST
✅ PUT
✅ DELETE
✅ Validaciones
✅ Manejo de errores
✅ Logging
✅ Respuestas consistentes
✅ Códigos HTTP 200, 201, 204, 400, 404 y 500
🚧 Próximas funcionalidades
🔐 Seguridad y autenticación
⏳ JWT Authentication
⏳ Registro de usuarios
⏳ Login
⏳ Roles
⏳ Autorización
⏳ Protección de endpoints
🅰️ Frontend
⏳ Configuración del proyecto Angular
⏳ Conexión Angular + API
⏳ Registro de usuarios
⏳ Login
⏳ Manejo del token JWT
⏳ CRUD de productos
⏳ Guards y protección de rutas
⏳ Diseño responsivo
☁️ Despliegue
⏳ Publicación del Backend
⏳ Publicación del Frontend
⏳ Base de datos en la nube
📚 Documentación y portafolio
⏳ Documentación técnica
⏳ Diagrama de arquitectura
⏳ Evidencias de pruebas
⏳ Preparación final del proyecto para GitHub
⏳ Preparación del proyecto para portafolio
📈 Estado del proyecto
Característica	Estado
Arquitectura por capas	✅
ASP.NET Core Web API	✅
SQL Server	✅
Entity Framework Core	✅
Dependency Injection	✅
CRUD de Productos	✅
DTOs	✅
AutoMapper	✅
Validaciones	✅
Manejo global de excepciones	✅
Logging	✅
Respuestas consistentes	✅
JWT	⏳
Registro de usuarios	⏳
Login	⏳
Roles y autorización	⏳
Angular	⏳
Despliegue en la nube	⏳
Documentación final	⏳
🟢 Estado actual

Backend: funcionalidades principales implementadas.
Seguridad: pendiente implementación de JWT y autorización.
Frontend: pendiente desarrollo con Angular.
Despliegue: pendiente.

🎯 Objetivos del proyecto

Este proyecto tiene como finalidad fortalecer conocimientos y experiencia práctica en:

ASP.NET Core Web API
C#
Entity Framework Core
SQL Server
Arquitectura por capas
Dependency Injection
DTOs
AutoMapper
Validaciones
Middleware
Manejo de excepciones
Logging
Respuestas consistentes
JWT Authentication
Autorización y roles
Angular
Consumo de APIs REST
Buenas prácticas de desarrollo
Git y GitHub
Despliegue en la nube
🚀 Roadmap del proyecto
✅ Arquitectura por capas
        ↓
✅ SQL Server + Entity Framework Core
        ↓
✅ CRUD de Productos
        ↓
✅ DTOs + AutoMapper
        ↓
✅ Validaciones
        ↓
✅ Manejo global de excepciones
        ↓
✅ Logging
        ↓
✅ Respuestas consistentes
        ↓
⏳ JWT Authentication
        ↓
⏳ Registro de usuarios
        ↓
⏳ Login
        ↓
⏳ Roles y autorización
        ↓
⏳ Angular + API
        ↓
⏳ Login y Registro
        ↓
⏳ CRUD de Productos
        ↓
⏳ Pruebas y seguridad
        ↓
⏳ Despliegue en la nube ☁️
        ↓
⏳ Documentación
        ↓
🎯 Proyecto final para portafolio
👨‍💻 Autor

César Sánchez

Estudiante de Ingeniería de Software
Analista de Soporte IT
Aspirante a Desarrollador Full Stack
🔗 GitHub

https://github.com/csanchezm21

⭐ Este proyecto se encuentra en desarrollo y será actualizado progresivamente a medida que se incorporen nuevas funcionalidades.

GitHub:
https://github.com/csanchezm21
