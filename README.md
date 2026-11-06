# 🚀 ProyectoFullStack

Aplicación web Full Stack desarrollada con **ASP.NET Core Web API (.NET 8), C#, SQL Server y Angular**. El proyecto busca implementar un sistema de gestión de usuarios y productos, aplicando buenas prácticas de programación, arquitectura por capas, autenticación y autorización.

Actualmente se encuentra en desarrollo y evolución continua como proyecto de aprendizaje y portafolio profesional.

## 🎯 Objetivo del proyecto

Construir una aplicación web que permita gestionar usuarios y productos mediante una arquitectura donde Angular se comunica con un Backend desarrollado en .NET, el cual administra la información almacenada en SQL Server.

## 🛠️ Tecnologías utilizadas

### Backend
- C#
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- AutoMapper
- JWT (JSON Web Token)
- BCrypt para protección de contraseñas
- Swagger / OpenAPI

### Base de datos
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Entity Framework Core Code First
- Migraciones

### Frontend
- Angular
- TypeScript
- HTML5
- CSS3
- RxJS
- HttpClient

### Herramientas
- Visual Studio 2022
- Visual Studio Code
- Git
- GitHub
- Node.js y npm

## ✅ Funcionalidades implementadas

### Backend
- [x] Configuración de ASP.NET Core Web API.
- [x] Conexión con SQL Server.
- [x] Arquitectura organizada por capas.
- [x] CRUD de productos.
- [x] Uso de DTOs para transferir información.
- [x] Validaciones de datos.
- [x] Manejo centralizado de excepciones.
- [x] Registro de usuarios.
- [x] Validación de correos electrónicos únicos.
- [x] Inicio de sesión.
- [x] Autenticación mediante JWT.
- [x] Protección de contraseñas con BCrypt.
- [x] Autorización mediante roles de Usuario y Administrador.

### Frontend
- [x] Configuración inicial de Angular.
- [x] Pantalla de inicio.
- [x] Pantalla de inicio de sesión.
- [x] Pantalla de registro.
- [x] Configuración de rutas.
- [x] Configuración de HttpClient.
- [x] Servicio para consumir el Backend.
- [x] Consulta de productos desde la API.
- [x] Visualización de productos en tarjetas.

## 🏗️ Arquitectura del proyecto

```text
ProyectoFullStack/
│
├── Backend/
│   └── ProyectoFullStack/
│       └── ProyectoFullStack.API/
│           ├── Controllers/
│           ├── Data/
│           ├── DTOs/
│           ├── Interfaces/
│           ├── Models/
│           ├── Services/
│           └── Program.cs
│
├── Frontend/
│   └── frontend/
│       └── src/
│           └── app/
│               ├── pages/
│               └── services/
│
├── BaseDatos/
├── Documentacion/
└── README.md
```

## 🔄 Comunicación entre las tecnologías

1. Angular realiza solicitudes HTTP.
2. ASP.NET Core Web API recibe y procesa las solicitudes.
3. Entity Framework Core permite consultar o modificar la información.
4. SQL Server almacena los datos.
5. El Backend devuelve una respuesta que Angular procesa y muestra al usuario.

## 🗄️ Base de datos

Nombre de la base de datos:

`ProyectoFullStackDB`

La aplicación utiliza SQL Server y Entity Framework Core para administrar las entidades y sus migraciones.

## ▶️ Ejecución del proyecto

### Requisitos previos

- Visual Studio 2022.
- .NET 8 SDK.
- SQL Server.
- SQL Server Management Studio.
- Node.js y npm.
- Angular CLI.

### 1. Clonar el repositorio

```bash
git clone https://github.com/csanchezm21/ProyectoFullStack.git
```

### 2. Configurar el Backend

Abrir la solución del Backend en Visual Studio 2022.

Configurar la cadena de conexión a SQL Server en `appsettings.json`, utilizando los datos de la instancia local.

**Importante:** No publicar contraseñas ni credenciales reales en el repositorio.

Verificar la base de datos y ejecutar las migraciones cuando sea necesario.

Iniciar el proyecto ASP.NET Core Web API.

### 3. Ejecutar el Frontend

Abrir una terminal dentro de la carpeta:

```bash
cd Frontend/frontend
```

Instalar las dependencias:

```bash
npm install
```

Iniciar Angular:

```bash
ng serve
```

Abrir en el navegador:

`http://localhost:4200`

## 📌 Estado actual del proyecto

El Backend cuenta con funcionalidades de productos, registro, inicio de sesión, autenticación JWT y autorización por roles.

El Frontend ya cuenta con sus pantallas iniciales y realiza consultas exitosas al Backend para mostrar los productos almacenados en SQL Server.

La integración de autenticación y las operaciones CRUD desde Angular continúan en desarrollo.

## 🗺️ Próximas mejoras

- [ ] Integrar el registro de usuarios desde Angular.
- [ ] Integrar el inicio de sesión con JWT.
- [ ] Almacenar y administrar el token de autenticación.
- [ ] Implementar protección de rutas.
- [ ] Implementar CRUD completo de productos desde Angular.
- [ ] Mejorar validaciones y manejo de errores.
- [ ] Realizar pruebas funcionales.
- [ ] Desplegar la aplicación en la nube.
- [ ] Completar la documentación técnica.

## 👨‍💻 Autor

**César Sánchez**

Estudiante de Ingeniería de Software, desarrollando este proyecto como parte de su proceso de aprendizaje y preparación para oportunidades profesionales en desarrollo de software.

- GitHub: https://github.com/csanchezm21
- Proyecto: https://github.com/csanchezm21/ProyectoFullStack

---

⭐ Este proyecto continúa en desarrollo. Su objetivo es fortalecer conocimientos en desarrollo Backend, Frontend, bases de datos y construcción de aplicaciones Full Stack.